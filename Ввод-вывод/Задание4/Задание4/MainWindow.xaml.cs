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
using System.IO.IsolatedStorage;
using Xceed.Wpf.Toolkit;
using System.IO;



namespace Задание4
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            IsolatedStorageFile isolatedStorageFile = IsolatedStorageFile.GetUserStoreForAssembly();
            InitializeComponent();
            string color;
            try
            {
                IsolatedStorageFileStream isolatedStorageFileStream = new IsolatedStorageFileStream("ColorLabel.cfg", FileMode.Open, FileAccess.Read, FileShare.Read);
                StreamReader reader = new StreamReader(isolatedStorageFileStream);
                color = reader.ReadLine();
                LC.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString(color));
                LC.Content = color;
                reader.Close();
            }
            catch (Exception e)
            {
                LC.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#00000000"));
                LC.Content = "#00000000";
            }
        }
        
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            System.Windows.MessageBox.Show("Сохранено. Перезапустите приложение");
        }

        private void CP_SelectedColorChanged(object sender, RoutedPropertyChangedEventArgs<Color?> e)
        {
            IsolatedStorageFileStream isolatedStorageFileStream = new IsolatedStorageFileStream("ColorLabel.cfg", FileMode.OpenOrCreate, FileAccess.Write, FileShare.ReadWrite);
            StreamWriter writer = new StreamWriter(isolatedStorageFileStream);
            LC.Content = CP.SelectedColor.Value;
            LC.Background = new SolidColorBrush(CP.SelectedColor.Value);
            writer.WriteLine(LC.Background.ToString());
            writer.Close();
        }
    }
}
