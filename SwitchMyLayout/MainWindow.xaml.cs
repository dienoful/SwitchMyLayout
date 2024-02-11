using SwitchMyLayout.Converters;
using SwitchMyLayout.Models;
using System.Windows;
using System.Windows.Input;

namespace SwitchMyLayout
{
    /// <summary>
    /// MainWindow logic
    /// </summary>
    public partial class MainWindow : Window
    {
        private readonly KeyboardLayoutConverter keyboardLayoutConverter = new KeyboardLayoutConverter();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void ConvertButton_Click(object sender, RoutedEventArgs e)
        {
            ConverterType selectedConverterType = ConverterTypeComboBox.SelectedItem as ConverterType;
            var originalText = OriginalText.Text;
            if (!string.IsNullOrEmpty(originalText) && selectedConverterType != null)
            {
                var newText = keyboardLayoutConverter.ConvertString(originalText, selectedConverterType.LangName);
                ConvertedText.Text = newText;
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
