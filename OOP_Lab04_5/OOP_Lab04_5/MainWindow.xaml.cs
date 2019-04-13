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

namespace OOP_Lab04_5
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Dictionary<int, RichTextBox> dictionary = new Dictionary<int, RichTextBox>();
        private int tabIterator = 0;

        public MainWindow()
        { 
            InitializeComponent();
            BindKeys();

            textBox.IsEnabled = false;
            lock_btn.IsEnabled = false;
        }

        private void BindKey(RoutedCommand command, Key key, ModifierKeys modifier, ExecutedRoutedEventHandler handler)
        {
            command.InputGestures.Add(new KeyGesture(key, modifier));
            CommandBindings.Add(new CommandBinding(command, handler));
        }

        private void BindKeys()
        {
            RoutedCommand SaveCommand = new RoutedCommand();
            RoutedCommand OpenCommand = new RoutedCommand();
            RoutedCommand NewCommand = new RoutedCommand();

            BindKey(SaveCommand, Key.S, ModifierKeys.Control, MenuItem_Click);
            BindKey(OpenCommand, Key.O, ModifierKeys.Control, MenuItem_Click);
            BindKey(NewCommand, Key.N, ModifierKeys.Control, MenuItem_Click);
        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(sender.ToString());
        }

        private void btnUnderline_Click(object sender, RoutedEventArgs e)
        {
            if ((textBox.Selection.GetPropertyValue(Inline.TextDecorationsProperty)) == TextDecorations.Underline)
            {
                textBox.Selection.ApplyPropertyValue(Inline.TextDecorationsProperty, null);
            }
            else
                textBox.Selection.ApplyPropertyValue(Inline.TextDecorationsProperty, TextDecorations.Underline);
        }

        private void btnItalic_Click(object sender, RoutedEventArgs e)
        {
            if (((FontStyle)textBox.Selection.GetPropertyValue(FontStyleProperty)) == FontStyles.Italic)
            {
                textBox.Selection.ApplyPropertyValue(TextElement.FontStyleProperty, FontStyles.Normal);
            }
            else
                textBox.Selection.ApplyPropertyValue(TextElement.FontStyleProperty, FontStyles.Italic);
        }

        private void btnBold_Click(object sender, RoutedEventArgs e)
        {
            if (((FontWeight)textBox.Selection.GetPropertyValue(FontWeightProperty)) == FontWeights.Bold)
            {
                textBox.Selection.ApplyPropertyValue(TextElement.FontWeightProperty, FontWeights.Normal);
            }
            else
                textBox.Selection.ApplyPropertyValue(TextElement.FontWeightProperty, FontWeights.Bold);
        }

        private void btnTextBoxLock_Click(object sender, RoutedEventArgs e)
        {
            if (textBox.IsEnabled)
                textBox.IsEnabled = false;
            else
                textBox.IsEnabled = true;
        }

        private void FontList_SelectedChanged(object sender, SelectionChangedEventArgs e)
        {
            ComboBox comboBox = sender as ComboBox;
            if(textBox != null && comboBox != null)
            {
                string fontFamilyName = ((ComboBoxItem)comboBox.SelectedItem).Content.ToString();
                textBox.Selection.ApplyPropertyValue(TextElement.FontFamilyProperty, new FontFamily(fontFamilyName));
            }   
        }

        private void SizeList_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ComboBox comboBox = sender as ComboBox;
            if (textBox != null && comboBox != null)
            {
                double fontSize;
                double.TryParse(((ComboBoxItem)comboBox.SelectedItem).Content.ToString(), out fontSize);
                textBox.Selection.ApplyPropertyValue(TextElement.FontSizeProperty, fontSize);
            }
        }

        private void File_Drag(object sender, DragEventArgs e)
        {
            e.Effects = DragDropEffects.All;
            e.Handled = true;
        }

        private void File_Drop(object sender, DragEventArgs e)
        {
            try
            {
                string[] filename = (string[])e.Data.GetData(DataFormats.FileDrop, true);

                FileStream fileStream = new FileStream(filename[0], FileMode.Open);

                TextRange range = new TextRange(textBox.Document.ContentStart, textBox.Document.ContentEnd);
                range.Load(fileStream, DataFormats.Rtf);
                e.Handled = true;
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }

        private void Theme_Click(object sender, RoutedEventArgs e)
        {
            MenuItem choose = (MenuItem)sender;

            Uri uri;
            if(choose.Header.ToString() == "Light")
                uri = new Uri("/Themes/LightTheme.xaml", UriKind.Relative);
            else
                uri = new Uri("/Themes/DarkTheme.xaml", UriKind.Relative);

            // загружаем словарь ресурсов
            ResourceDictionary resourceDict = Application.LoadComponent(uri) as ResourceDictionary;
            // очищаем коллекцию ресурсов приложения
            Application.Current.Resources.Clear();
            // добавляем загруженный словарь ресурсов
            Application.Current.Resources.MergedDictionaries.Add(resourceDict);
        }

        private void Language_Click(object sender, RoutedEventArgs e)
        {
            MenuItem choose = (MenuItem)sender;

            if (choose.Header.ToString() == "English" || choose.Header.ToString() == "Английский")
            {
                using (StreamWriter sw = new StreamWriter("../../Properties/LangConfig.txt", false, System.Text.Encoding.Default))
                {
                    sw.WriteLine("en");
                }
            }
            else
            {
                using (StreamWriter sw = new StreamWriter("../../Properties/LangConfig.txt", false, System.Text.Encoding.Default))
                {
                    sw.WriteLine("ru-RU");
                }
            }
            MessageBox.Show("Перезапустите программу/Reload the programm");
        }

        private void AddTab_btn_Click(object sender, RoutedEventArgs e)
        {
            if(tabIterator < 10)
            {
                tabIterator++;

                TabItem newItem = new TabItem();
                newItem.Header = "New Tab" + tabIterator;

                tabControl.Items.Add(newItem);

                dictionary.Add(tabIterator-1, new RichTextBox());
                MessageBox.Show("added");
            }
            else
                return;
        }

        //private void tabItem_Click(object sender, MouseButtonEventArgs e)
        //{
        //    TabItem tab = (TabItem)sender;
        //    textBox.IsEnabled = true;
        //    lock_btn.IsEnabled = true;
        //}

        private void TabContol_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            TabControl tabCtrl = (TabControl)sender;
            textBox.IsEnabled = true;
            lock_btn.IsEnabled = true;

            textBox = dictionary[tabCtrl.SelectedIndex];
            MessageBox.Show(tabControl.SelectedIndex.ToString());

            e.Handled = true;
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            dictionary[tabControl.SelectedIndex] = textBox;
            MessageBox.Show("text");
            e.Handled = true;
        }
    }
}
