﻿using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using TradingCompany.BLL;

namespace WPFUI
{
    /// <summary>
    /// Логика взаимодействия для App.xaml
    /// </summary>
    ///     -
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            MainAppMenu mainWindow = DependencyInjectorBLL.Resolve<MainAppMenu>();
            mainWindow.Show();
        }
    }
}