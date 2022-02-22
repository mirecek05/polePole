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

namespace TreninkPole
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int[] pole;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            pole = GenerujPole(10, 0, 100);
            txtText.Text = string.Join("; ", pole);
            txtText.Text += "\r\n\r\n";
            txtText.Text += $"Součet = {SoucetPrvkuVPoli(pole)}\r\n";
            txtText.Text += $"Průměr = {SoucetPrvkuVPoli(pole) / Convert.ToDouble(pole.Length)}\r\n";

            Array.Sort(pole);
            txtText.Text += "\r\n\r\n";
            txtText.Text += string.Join("; ", pole);

            txtText.Text += "\r\n\r\n";
            txtText.Text += $"Nepřesný medián = {pole[pole.Length / 2]}\r\n";
            txtText.Text += $"Přesný medián = {Median(pole)}\r\n";




        }

        private double Median(int[] pole)
        {
            if (pole.Length % 2 == 0) // % = operator pro zbytek po celociselnem deleni
            {
                return (pole[pole.Length / 2] + pole[pole.Length / 2 - 1]) / 2D; 
            }
            else
            {
                return pole[pole.Length / 2];
            }
        }

        private void GenerujPole(int[] array, int min, int max)
        {
            Random random = new Random();
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = random.Next(min, max);
            }
        }

        private int[] GenerujPole(int count, int min, int max)
        {
            int[] array = new int[count];
            Random random = new Random();
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = random.Next(min, max);
            }
            return array;
        }

        private int SoucetPrvkuVPoli(int[] array)
        {
            int soucet = 0;
            for (int i = 0; i < array.Length; i++)
            {
                soucet = soucet + array[i];
            }
            return soucet;
        }
    }
}
