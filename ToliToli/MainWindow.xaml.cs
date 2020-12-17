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

namespace ToliToli
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        public MainWindow()
        {
            InitializeComponent();
        }
        int[] actualPositions = { 0, 1, 2, 3, 4, 5, 6, 7, 8 };
        int[] finalPositions = { 0, 1, 2, 3, 4, 5, 6, 7, 8 };


        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Button senderButton = sender as Button;
            Button zeroButton = (Button)FindName("Button0");
            var ftav = Math.Abs(senderButton.Margin.Top - zeroButton.Margin.Top);
            var vtav = Math.Abs(senderButton.Margin.Left - zeroButton.Margin.Left);
            int senderButtonContent = int.Parse(senderButton.Content.ToString());
            int senderButtonIndex = Array.IndexOf(actualPositions, senderButtonContent);
            int zeroButtonIndex = Array.IndexOf(actualPositions, 0);
            if ((ftav == 50 && vtav == 0) || (vtav == 50 && ftav == 0)) 
            {
                var seged = senderButton.Margin;
                senderButton.Margin = zeroButton.Margin;
                zeroButton.Margin = seged;

                var seged2 = senderButtonContent;
                actualPositions[zeroButtonIndex] = seged2;
                actualPositions[senderButtonIndex] = 0;

                if (actualPositions.SequenceEqual(finalPositions))
                {
                    MessageBox.Show("Vége a Játékank ügyes vagy!");
                }
                

            }
            for (int i = 0; i < finalPositions.Length; i++)
            {
                Console.WriteLine(finalPositions[i]);
            }
            for (int i = 0; i < actualPositions.Length; i++)
            {
                Console.WriteLine(actualPositions[i]);
            }
        }

        private void Keveres_Click(object sender, RoutedEventArgs e)
        {
            Random r = new Random();
            for (int i = 0; i < 100; i++)
            {
                
                Button senderButton = (Button)FindName("Button" + Convert.ToString(r.Next(1, 9)));
                Button zeroButton = (Button)FindName("Button0");
                
                var ftav = Math.Abs(senderButton.Margin.Top - zeroButton.Margin.Top);
                var vtav = Math.Abs(senderButton.Margin.Left - zeroButton.Margin.Left);
                int senderButtonContent = int.Parse(senderButton.Content.ToString());
                int senderButtonIndex = Array.IndexOf(actualPositions, senderButtonContent);
                int zeroButtonIndex = Array.IndexOf(actualPositions, 0);
                if ((ftav == 50 && vtav == 0) || (vtav == 50 && ftav == 0))
                {
                    var seged = senderButton.Margin;
                    senderButton.Margin = zeroButton.Margin;
                    zeroButton.Margin = seged;


                    var seged2 = senderButtonContent;
                    actualPositions[zeroButtonIndex] = seged2;
                    actualPositions[senderButtonIndex] = 0;

                }
            }
        }

        private void Ellenoriz_Click(object sender, RoutedEventArgs e)
        {
            
        }
    }
}
