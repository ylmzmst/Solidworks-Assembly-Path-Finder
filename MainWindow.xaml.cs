using Microsoft.Win32;
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

namespace Find_File_Path
{

 
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            if (string.IsNullOrEmpty(txt1.Text) && string.IsNullOrEmpty(txt2.Text))
            {
                MessageBox.Show("Dosya Seçin ...");
            }

        }

        

        private void btn1_Click(object sender, RoutedEventArgs e)
        {
            txt1.Text = Find_path().Replace(@"\", @"\\");
        }

        private void btn2_Click(object sender, RoutedEventArgs e)
        {
            txt2.Text = Find_path().Replace(@"\", @"\\");
        }

        public string Find_path()
        {
            OpenFileDialog file = new OpenFileDialog();
            file.Filter = "Montaj Dosyası |*.sldasm|Montaj Dosyası |*.sldasm";
            file.FilterIndex = 2;
            file.RestoreDirectory = true;
            file.CheckFileExists = false;
            file.Title = "Montaj Dosyası Şablonu Seçin:";
            file.ShowDialog();

            return file.FileName;
        }
    }

}
