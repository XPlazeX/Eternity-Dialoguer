using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using Eternity_Dialoger.Models;

namespace Eternity_Dialoger
{
    /// <summary>
    /// Логика взаимодействия для ConfigWindow.xaml
    /// </summary>
    public partial class ConfigWindow : Window
    {
        public ConfigWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            //Title = $"Eternity Dialoguer : Config: {FileHandler.ConfigFilePath}";
        }

        private void saveCloseButton_Click(object sender, RoutedEventArgs e)
        {
            var result = MessageBox.Show(
                "Новых персонажей нельзя будет убрать, но редактировать значения можно будет всегда. Вы точно хотите сохранить изменения?",
                "Подтверждение",
                MessageBoxButton.YesNo,
                MessageBoxImage.Information);

            if (result == MessageBoxResult.Yes)
            {
                FileHandler.SaveConfigFile(new List<ConfigObject>(App.ActiveViewModel.ConfigObjects));

                App.ActiveViewModel.Load();

                Close();
            }
        }

        private void addButton_Click(object sender, RoutedEventArgs e)
        {
            App.ActiveViewModel.AddConfigObject();
        }
    }
}
