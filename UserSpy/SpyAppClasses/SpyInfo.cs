using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

//dll с классами
namespace SpyAppClasses
{
    //представление путей отчетов и настроек в виде строки;
    //необходим для передачи в другое приложение (в виде аргументов),
    //поэтому нельзя допустить пробелы.
    //преобразуем в аски коды (трехразрядные напр: 123,002,023, чтобы лечге было читать)
    //свойства сериализуются автоматически (поддерживаются типы с методом Parse и тип string)
    public class SpyInfo
    {
        public string WhereToWriteKeys { get; set; } = string.Empty;
        public string WhereToWriteWords { get; set; } = string.Empty;
        public string WhereToReadBadWords { get; set; } = string.Empty;

        public string WhereToWriteProcs { get; set; } = string.Empty;
        public string WhereToWriteBadProcs { get; set; } = string.Empty;
        public string WhereToReadBadApps { get; set; } = string.Empty;
        public bool IsCloseBadApp { get; set; } = false;

        //автоматически считываем все свойства класса SpyInfo 
        //(нет необходимости редактирвоать метод SerializeToString при добавлении нового)
        //свойство1;;значение1\n
        //свойство2;;значение2\n
        public string SerializeToString()
        {
            string resStr = ConvertPropsTotring();

            string resASCII = ConvertSymbolsToASCII(resStr);

            return resASCII;
        }
        private string ConvertPropsTotring()
        {
            string resStr = string.Empty;

            var propsName = this.GetType().GetProperties();
            foreach (var p in propsName)
            {
                resStr += p.Name + ";;" + p.GetValue(this).ToString() + "\n";
            }
            return resStr;
        }
        private string ConvertSymbolsToASCII(string resStr)
        {
            string resASCII = string.Empty;

            foreach (var s in resStr)
            {
                string code = ((int)s).ToString();

                while (code.Length < 3)
                    code = "0" + code;

                resASCII += code;
            }
            return resASCII;
        }
        
        /// <summary>Нужен try-catch</summary>
        /// <exception cref="FormatException"></exception>
        /// <exception cref="IndexOutOfRangeException"></exception>
        /// <exception cref="AmbiguousMatchException"></exception>
        public void DeserializeFromString(string data)
        {
            string info = ConvertASCIIToSymbols(data);

            //парсим
            using (StringReader sr = new StringReader(info))
            {
                // nameProp;;valProp
                string propLine;

                while ((propLine = sr.ReadLine()) != null)
                {
                    var propPair = propLine.Split(new string[1] { ";;"}, StringSplitOptions.None);

                    //определяем тип нужного свойства
                    Type propType = this.GetType()
                        .GetProperty(propPair[0]).PropertyType;

                    object propVal = SetValueToObj(propType, propPair[1]);
                    
                    // устанавливаем значение в текущий объект
                    this.GetType()
                        .GetProperty(propPair[0])
                        .SetValue(this, propVal);
                    
                }
            }
        }
        private string ConvertASCIIToSymbols(string data)
        {
            string info = string.Empty;
            for (int i = 0; i < data.Length; i += 3)
            {
                char code = (char)int.Parse(data.Substring(i, 3));
                info += code;
            }
            return info;
        }        
        private object SetValueToObj(Type valType, string value)
        {
            object propVal;
            //у string нет метода parse
            if (valType == typeof(string))
            {
                propVal = value;
            }
            else
            {
                propVal = valType.GetMethod("Parse").Invoke(valType, new object[1] { value });
            }
            
            return propVal;
        }
    }
    
}
