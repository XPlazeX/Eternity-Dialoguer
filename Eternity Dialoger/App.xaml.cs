using Eternity_Dialoger.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace Eternity_Dialoger
{
    /// <summary>
    /// Логика взаимодействия для App.xaml
    /// </summary>
    public partial class App : Application
    {
        public static ViewModel ActiveViewModel { get; private set; }
        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);

            MainWindow window = new MainWindow();
            ActiveViewModel = new ViewModel();

            window.DataContext = ActiveViewModel;
            window.Show();
        }
    }
}
