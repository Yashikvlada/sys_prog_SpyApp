using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//dll с классами
namespace SpyAppClasses
{
    public interface ISpyCommand
    {
        public void Execute();
    }
    public class WriteStatsCommand : ISpyCommand
    {
        private string _reportPath;
        public WriteStatsCommand(string reportPath)
        {
            _reportPath = reportPath;
        }
        public void Execute()
        {
            //тут код, который сканирует и пишет лог в _reportPath
            throw new NotImplementedException();
        }
    }
    public class ModeringCommand : ISpyCommand
    {
        private string _reportPath;
        private string _badWordsPath;
        private string _badAppsPath;
        public ModeringCommand(string reportPath, string badWordsPath, string badAppsPath)
        {
            _reportPath = reportPath;
            _badWordsPath = badWordsPath;
            _badAppsPath = badAppsPath;
        }
        public void Execute()
        {
            //тут код, который модерирует нажатые клавиши и приложения из 
            //_badWordsPath и _badAppsPath и пишет лог в _reportPath
            throw new NotImplementedException();
        }
    }
}
