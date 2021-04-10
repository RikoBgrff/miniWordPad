using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
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

namespace miniWordPad
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private readonly FileHelper _fileHelper = new FileHelper();
        public MainWindow()
        {
            InitializeComponent();
            //MessageBox.Show("Change Toggle Button");
        }

        private void OpenFileBtn_Click(object sender, RoutedEventArgs e)
        {
            TextTxtBx.Text = _fileHelper.ReadFromFile();
            FilePathTxtBx.Text = _fileHelper.fileName;
        }


        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void TextTxtBx_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void SaveBtn_Click(object sender, RoutedEventArgs e)
        {
            _fileHelper.SaveToFile(TextTxtBx.Text);

        }

        private void AutoSave_Checked(object sender, RoutedEventArgs e)
        {
            _fileHelper.AutoSave(TextTxtBx.Text);
        }

        private void CutBtn_Click(object sender, RoutedEventArgs e)
        {
            TextTxtBx.Cut();
        }

        private void CopyBtn_Click(object sender, RoutedEventArgs e)
        {
            TextTxtBx.Copy();
        }

        private void PasteBtn_Click(object sender, RoutedEventArgs e)
        {
            TextTxtBx.Paste();
        }

        private void SelectAllBtn_Click(object sender, RoutedEventArgs e)
        {
            TextTxtBx.SelectAll();
        }

        private void SaveBtn_Click_1(object sender, RoutedEventArgs e)
        {

        }
    }
}

