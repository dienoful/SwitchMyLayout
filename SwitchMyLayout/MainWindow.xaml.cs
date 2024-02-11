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

namespace SwitchMyLayout
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        KeyboardLayoutConverter converter = new KeyboardLayoutConverter();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void FromEnglishButton_Click(object sender, RoutedEventArgs e)
        {
            var originalText = EnText.Text;
            if (!string.IsNullOrEmpty(originalText))
            {
                var newText = converter.ConvertString(originalText, "en");
                RuText.Text = newText;
            }
        }

        private void FromRussianButton_Click(object sender, RoutedEventArgs e)
        {
            var originalText = RuText.Text;
            if (!string.IsNullOrEmpty(originalText))
            {
                var newText = converter.ConvertString(originalText, "ru");
                EnText.Text = newText;
            }
        }

        private void Window_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.ChangedButton == MouseButton.Left)
            {
                DragMove();
            }
        }

        private void CloseButton_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
