using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace OOP_Lab04_5
{
    /// <summary>
    /// Логика взаимодействия для App.xaml
    /// </summary>
    public partial class App : Application
    {
        private string lang = "en";

        App()
        {
            checkLang();
            System.Threading.Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo(lang);
        }


        private void checkLang()
        {
            using (StreamReader sr = new StreamReader("../../Properties/LangConfig.txt", System.Text.Encoding.Default))
            {
                lang = sr.ReadLine();
            }
        }
    }
}
