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
    public class SpyInfo
    {
        public string WhereToWriteKeys { get; set; } = string.Empty;
        public string WhereToWriteWords { get; set; } = string.Empty;
        public string WhereToReadBadWords { get; set; } = string.Empty;

        public string WhereToWriteProcs { get; set; } = string.Empty;
        public string WhereToWriteBadProcs { get; set; } = string.Empty;
        public string WhereToReadBadApps { get; set; } = string.Empty;
        public bool IsCloseBadApp { get; set; } = false;

        public string SerializeToString()
        {
            string resStr = string.Empty;

            var propsName = this.GetType().GetProperties();
            foreach (var p in propsName)
            {
                resStr += p.Name + ";;" + p.GetValue(this).ToString() + "\n";
            }

            //переведем в аски коды (чтобы исключить пробелы по три символа)
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

        /// <summary>Unsafe method! Pls use try-catch section!</summary>
        /// <exception cref="FormatException"></exception>
        /// <exception cref="IndexOutOfRangeException"></exception>
        /// <exception cref="AmbiguousMatchException"></exception>
        public void DeserializeFromString(string data)
        {
            string info = string.Empty;
            for(int i = 0; i < data.Length; i += 3)
            {
                char code = (char)int.Parse(data.Substring(i, 3));
                info += code;
            }
            //парсим
            using(StringReader sr = new StringReader(info))
            {
                string prop;

                while ((prop = sr.ReadLine()) != null)
                {
                    var propPair = prop.Split(new string[1] { ";;"}, StringSplitOptions.None);

                    Type propType = this.GetType()
                        .GetProperty(propPair[0]).PropertyType;
                    //Console.WriteLine(propType);

                    object propVal;
                    if (propType == typeof(string))
                    {
                        propVal = propPair[1];
                    }
                    else
                    {
                        propVal = Activator.CreateInstance(propType);
                    }
                    
                    if (propType == typeof(string))
                    {
                        propVal = propPair[1];
                    }
                    else
                    {
                        propVal = propType.GetMethod("Parse").Invoke(propType, new object[1] {propPair[1]});
                    }
               
                    this.GetType()
                        .GetProperty(propPair[0])
                        .SetValue(this, propVal);
                    
                }
            }
        }
    }
    
}
