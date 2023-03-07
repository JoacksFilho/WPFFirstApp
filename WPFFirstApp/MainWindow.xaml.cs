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
using static System.Net.Mime.MediaTypeNames;

namespace WPFFirstApp
{
    /// <summary>
    /// Interação lógica para MainWindow.xam
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow() // Construtor que inicializa o sistema.
        {
            InitializeComponent();
            //mybutton.FontSize = 50;
            //mybutton.FontWeight = FontWeights.Bold;
            //mybutton.Content = "Hello Joacks";

            //myTextBlock.Text = "Hello Joacks";
            //myTextBlock.Foreground = Brushes.AliceBlue; // Forma de alterar um textblock por meio do codebehind - mudança de cor.

            //TextBlock myTb = new TextBlock(); // criando uma textBlock no codebehind
            //myTb.Text = "Hello Joacks";
            //myTb.Inlines.Add(" this is added using inlines");
            //myTb.Inlines.Add(new Run("Run text that I added in Code behind")
            //{
            //    Foreground = Brushes.Blue,
            //    TextDecorations = TextDecorations.Underline

            //});
            //myTb.TextWrapping = TextWrapping.Wrap;
            //myTb.Foreground = Brushes.BurlyWood;
            //this.Content = myTb;

            //myTextBLock.Text = myCalendar.SelectedDate.ToString();

        }

        //private void DatePicker_SelectedDateChanged(object sender, SelectionChangedEventArgs e)
        //{
        //    if ((sender as DatePicker).SelectedDate != null)
        //    {
        //        string myDate = (sender as DatePicker).SelectedDate.ToString();
        //        MessageBox.Show("Date has been changed to " + myDate);
        //    }          
        //}

        //private void myCalendar_SelectedDatesChanged(object sender, SelectionChangedEventArgs e)
        //{
        //    if (myTextBLock != null)                        
        //        myTextBLock.Text = myCalendar.SelectedDate.ToString();
        //}

        //private void mySlider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        //{
        //    //if (mytextblock != null && myslider.value > 0)
        //    //{
        //    //    mytextblock.text = "slyder value is " + myslider.value.tostring();
        //    //    mytextblock.fontsize = myslider.value;
        //    //}

        //}

        //private void Image_MouseUp(object sender, MouseButtonEventArgs e)
        //{
        //    myImage.Source = new BitmapImage( new Uri(@"C:\Users\agger\Downloads\joe-biden.png", UriKind.Relative));
        //}

        //private void cbParentCheckedChanged(object sender, RoutedEventArgs e)
        //{
        //    bool newVal = (cbParent.IsChecked == true);
        //    cbCheese.IsChecked = newVal;
        //    cbChocolate.IsChecked = newVal;
        //    cbHam.IsChecked = newVal;
        //} 

        //private void cbTopingsCheckedChanged(object sender, RoutedEventArgs e)
        //{
        //    cbParent.IsChecked = null;
        //    if ((cbCheese.IsChecked == true) && (cbChocolate.IsChecked == true) && (cbHam.IsChecked == true))
        //    {
        //        cbParent.IsChecked = true;
        //    }
        //    if ((cbCheese.IsChecked == false) && (cbChocolate.IsChecked == false) && (cbHam.IsChecked == false))
        //    {
        //        cbParent.IsChecked = false;
        //    }

        //}
        //private void rbObama_Checked(object sender, RoutedEventArgs e)
        //{
        //    lbObama.Background = Brushes.DarkKhaki;
        //}

        //private void rbObama_Unchecked(object sender, RoutedEventArgs e)
        //{
        //    lbObama.Background = null;
        //}

        //private void mybutton_Click(object sender, RoutedEventArgs e)
        //{

        //}
        // private void Hyperlink_RequestNavigate(object sender, RequestNavigateEventArgs e)
        // {
        //     System.Diagnostics.Process.Start(e.Uri.AbsoluteUri);
        // }

        // private void Button_Click(object sender, RoutedEventArgs e)
        // {
        //     mylabel.Foreground = Brushes.Peru;
        //     mylabel.FontSize++; 
        // }

        // private void myButton_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        // {
        //     mylabel.FontSize--;
        // }

        // private void myButton_MouseEnter(object sender, MouseEventArgs e)
        // {
        //     mylabel.Foreground = Brushes.WhiteSmoke;

        // }

        //private void myButton_MouseLeave(object sender, MouseEventArgs e)
        // {
        //     mylabel.Foreground = Brushes.Black;
        // }
    }
}
