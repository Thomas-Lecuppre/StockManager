using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace StockManager.Model
{
    public class MainWindowModel
    {
        public MainWindowModel()
        {

        }

        public string GetAppTitle()
        {
            Assembly a = Assembly.GetExecutingAssembly();
            return $"{a.GetName()} - v{FileVersionInfo.GetVersionInfo(a.Location).FileVersion}";
        }
    }
}
