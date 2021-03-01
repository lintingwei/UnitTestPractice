using System;
using System.Collections.Generic;
using System.Text;

namespace UnitTestPractice
{
    public class LogAnalyzer
    {
        private IExtensionManager manager;
        public LogAnalyzer() 
        {
            manager = ExtensionMangerFactory.Create(); 
        }

        public bool IsValidLogFileName(string fileName) 
        {
            return manager.IsValid(fileName);
        }
    }
}
