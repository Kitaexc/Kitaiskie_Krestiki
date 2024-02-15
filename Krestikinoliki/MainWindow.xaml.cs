using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Krestikinoliki
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Random random = new Random();
        Button[] pikalki;
        int i = 0;
        public MainWindow()
        {
            InitializeComponent();
            pikalki = new Button[] {knp1, knp2, knp3, knp4, knp5, knp6, knp7, knp8, knp9 };
            (Itog as TextBox).IsEnabled = false;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            (knp1 as Button).IsEnabled = true;
            (knp2 as Button).IsEnabled = true;
            (knp3 as Button).IsEnabled = true;
            (knp4 as Button).IsEnabled = true;
            (knp5 as Button).IsEnabled = true;
            (knp6 as Button).IsEnabled = true;
            (knp7 as Button).IsEnabled = true;
            (knp8 as Button).IsEnabled = true;
            (knp9 as Button).IsEnabled = true;


        }

        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            (knp1 as Button).IsEnabled = false;
            (knp1 as Button).Content = "";
            (knp2 as Button).IsEnabled = false;
            (knp2 as Button).Content = "";
            (knp3 as Button).IsEnabled = false;
            (knp3 as Button).Content = "";
            (knp4 as Button).IsEnabled = false;
            (knp4 as Button).Content = "";
            (knp5 as Button).IsEnabled = false;
            (knp5 as Button).Content = "";
            (knp6 as Button).IsEnabled = false;
            (knp6 as Button).Content = "";
            (knp7 as Button).IsEnabled = false;
            (knp7 as Button).Content = "";
            (knp8 as Button).IsEnabled = false;
            (knp8 as Button).Content = "";
            (knp9 as Button).IsEnabled = false;
            (knp9 as Button).Content = "";

            (Itog as TextBox).Text = "";
        }

        private void knp1_Click(object sender, RoutedEventArgs e)
        {
            i++;
            if (i < 8)
            {
                (sender as Button).Content = "X";
                (sender as Button).IsEnabled = false;
                int pikalka = random.Next(pikalki.Length);
                while (pikalki[pikalka].IsEnabled == false)
                    pikalka = random.Next(pikalki.Length);
                pikalki[pikalka].Content = "0";
                pikalki[pikalka].IsEnabled = false;

                CheckForWinner();
            }
            if (i == 8)
            {
                (sender as Button).Content = "X";
                (sender as Button).IsEnabled = false;
                CheckForWinner();
            }
        }
        private void CheckForWinner()
        {
            if ((knp1.Content == "X" && knp2.Content == "X" && knp3.Content == "X") 
                || (knp4.Content == "X" && knp5.Content == "X" && knp6.Content == "X") 
                || (knp7.Content == "X" && knp8.Content == "X" && knp9.Content == "X") 
                || (knp1.Content == "X" && knp4.Content == "X" && knp7.Content == "X") 
                || (knp2.Content == "X" && knp5.Content == "X" && knp8.Content == "X") 
                || (knp3.Content == "X" && knp6.Content == "X" && knp9.Content == "X") 
                || (knp1.Content == "X" && knp5.Content == "X" && knp9.Content == "X") 
                || (knp3.Content == "X" && knp5.Content == "X" && knp7.Content == "X"))
            {
                Itog.Text = "Победа крестиков!";
                DisableAllButtons();
            }
            if ((knp1.Content == "0" && knp2.Content == "0" && knp3.Content == "0")
                || (knp4.Content == "0" && knp5.Content == "0" && knp6.Content == "0")
                || (knp7.Content == "0" && knp8.Content == "0" && knp9.Content == "0")
                || (knp1.Content == "0" && knp4.Content == "0" && knp7.Content == "0")
                || (knp2.Content == "0" && knp5.Content == "0" && knp8.Content == "0")
                || (knp3.Content == "0" && knp6.Content == "0" && knp9.Content == "0")
                || (knp1.Content == "0" && knp5.Content == "0" && knp9.Content == "0")
                || (knp3.Content == "0" && knp5.Content == "0" && knp7.Content == "0"))
            {
                Itog.Text = "Победа ноликов!";
                DisableAllButtons();
            }
            else if (knp1.Content != "" && knp2.Content != "" && knp3.Content != ""
                && knp4.Content != "" && knp5.Content != "" && knp6.Content != ""
                && knp7.Content != "" && knp8.Content != "" && knp9.Content != "")
            {
                Itog.Text = "Ничья!";
                DisableAllButtons();
            }
        }
    private void DisableAllButtons()
        {
            foreach (Button btn in pikalki)
            {
                btn.IsEnabled = false;
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
                    }
    }
}