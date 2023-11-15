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
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.ComponentModel;
using Eternity_Dialoger.Models;
using System.Collections.ObjectModel;

namespace Eternity_Dialoger
{
    public partial class MainWindow : Window
    {
        const string programm_name = "Eternity Dialoguer";
        //private BindingList<DialogueObject> DialogueData;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            counterLabel.Content = $"Кол-во записей: {App.ActiveViewModel.DialogueObjects.Count}";
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            //DialogueObjects.Add(new DialogueObject());
            App.ActiveViewModel.AddDialogeObject();
            counterLabel.Content = $"Кол-во записей: {App.ActiveViewModel.DialogueObjects.Count}";
        }

        private void delButton_Click(object sender, RoutedEventArgs e)
        {
            App.ActiveViewModel.RemoveDialogueObject();
            counterLabel.Content = $"Кол-во записей: {App.ActiveViewModel.DialogueObjects.Count}";
        }

        private void openButton_Click(object sender, RoutedEventArgs e)
        {
            var dialog = new Microsoft.Win32.OpenFileDialog();
            dialog.FileName = "Dialog Animator";
            dialog.DefaultExt = ".csv";
            dialog.Filter = "Text documents (.csv)|*.csv";

            bool? result = dialog.ShowDialog();

            if (result == true)
            {
                string filename = dialog.FileName;
                Title = programm_name + " " + filename;

                App.ActiveViewModel.SetData(FileHandler.OpenCSVFile(filename));
            }

            counterLabel.Content = $"Кол-во записей: {App.ActiveViewModel.DialogueObjects.Count}";
        }

        private void saveButton_Click(object sender, RoutedEventArgs e)
        {
            var dialog = new Microsoft.Win32.SaveFileDialog();
            dialog.FileName = "Dialog Animator";
            dialog.DefaultExt = ".csv";
            dialog.Filter = "Text documents (.csv)|*.csv";

            bool? result = dialog.ShowDialog();

            if (result == true)
            {
                string filename = dialog.FileName;
                Title = programm_name + " " + filename;

                FileHandler.WriteCSVFile(filename, App.ActiveViewModel.GetData());
            }
        }

        private void clButton_Click(object sender, RoutedEventArgs e)
        {
            constructGrid.SelectedIndex = -1;
        }
    }
}
