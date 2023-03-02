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

            TextBlock myTb = new TextBlock(); // criando uma textBlock no codebehind
            myTb.Text = "Hello Joacks";
            myTb.Inlines.Add(" this is added using inlines");
            myTb.Inlines.Add(new Run("Run text that I added in Code behind")
            {
                Foreground = Brushes.Blue,
                TextDecorations = TextDecorations.Underline

            });
            myTb.TextWrapping = TextWrapping.Wrap;
            myTb.Foreground = Brushes.BurlyWood;
            this.Content = myTb;
            
        }

        //private void mybutton_Click(object sender, RoutedEventArgs e)
        //{

        //}
        private void Hyperlink_RequestNavigate(object sender, RequestNavigateEventArgs e)
        {
            System.Diagnostics.Process.Start(e.Uri.AbsoluteUri);
        }
    }
}
