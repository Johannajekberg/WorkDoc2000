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

namespace WorkDoc2000
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        string texten = "Likadana händer,\nmunnarna fulla av tänder.\nPå fötterna tår\noch på huvudet hår\nhar vi i öst och de i väst.\nAck så lika men vi är ändå bäst\n(från böckerna om Halvdan\nav Martin Widmark)";
        string texten3 = "likadana händer,\nmunnarna fulla av tänder.\npå fötterna tår\noch på huvudet hår\nhar vi i öst och de i väst.\nack så lika men vi är ändå bäst\n(från böckerna om halvdan\nav martin widmark)";
        bool firstClick = false;

        public MainWindow()
        {
           
            InitializeComponent();
            dikten.Text = texten;
        }

        private void wordCounter_Click(object sender, RoutedEventArgs e)
        {
            string[] ordArray = texten.Split(' ', '\n');
            MessageBox.Show($"Denna dikt är {ordArray.Length.ToString()} ord lång! :)");
        }

        private void firstToUpper_Click(object sender, RoutedEventArgs e)
        {
            
            if (!firstClick)
            {
                dikten.Text = texten.ToUpper();
                firstClick = true;
                firstToUpper.Content = "Liten bokstav";
            }else
            {
                dikten.Text = texten.ToLower();
                firstClick=false;
                firstToUpper.Content = "Stor bokstav";
            }
            

        }

        private void textFix_Click(object sender, RoutedEventArgs e)
        {
            string texten2 = "";

            for (int i = 0; i < texten3.Length; i++)
            {
               if(i == 0)
                {
                    texten2 += texten3[i].ToString().ToUpper();
                }else if (texten3[i] == '.')
                {
                    texten2 += ". \n" + texten3[i+2].ToString().ToUpper();
                    i += 2;
                }else
                {
                    texten2 += texten3[i].ToString();
                }
            }

            dikten.Text = texten2;
        }

        private void charToNum_Click(object sender, RoutedEventArgs e)
        {
            dikten.Text = texten.Replace('e', '3').Replace('a', '4').Replace('A','4');
        }
    }
}
