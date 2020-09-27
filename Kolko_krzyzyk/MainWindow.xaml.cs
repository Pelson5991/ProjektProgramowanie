using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
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

namespace KolkoiKrzyzyk
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        /// <summary>
        /// Metoda tworzona automatycznie do konfiguracji kontrolek
        /// i konstruktur uruchamiajacy nową gre przy wlaczeniu
        /// </summary>
        public MainWindow()
        {
            InitializeComponent();

            NewGame();
        }
        /// <summary>
        /// Zliczanie przycisniec
        /// </summary>
        public int Zliczanie { get; set; }
        /// <summary>
        /// Ktora kolej gracza
        /// </summary>
        public bool Gracz1 { get; set; }
        /// <summary>
        /// Metoda ktora bedzie uruchamiala nową gre
        /// </summary>
        public void NewGame()
        {
            Gracz1 = false;
            Zliczanie = 0;

            Button_0_0.Content = string.Empty;
            Button_1_0.Content = string.Empty;
            Button_2_0.Content = string.Empty;
            Button_0_1.Content = string.Empty;
            Button_1_1.Content = string.Empty;
            Button_2_1.Content = string.Empty;
            Button_0_2.Content = string.Empty;
            Button_1_2.Content = string.Empty;
            Button_2_2.Content = string.Empty;

            Button_0_0.Background = Brushes.White;
            Button_1_0.Background = Brushes.White;
            Button_2_0.Background = Brushes.White;
            Button_0_1.Background = Brushes.White;
            Button_1_1.Background = Brushes.White;
            Button_2_1.Background = Brushes.White;
            Button_0_2.Background = Brushes.White;
            Button_1_2.Background = Brushes.White;
            Button_2_2.Background = Brushes.White;


        }
        /// <summary>
        /// Zliczanie przycisniec
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (Gracz1)
            {
                Gracz1 = false;
            }
            else
            {
                Gracz1 = true;
            }
            Zliczanie++;

            if (Zliczanie > 9)
            {
                NewGame();
                return;
            }

            var button = sender as Button;

            button.Content = Gracz1 ? "O" : "X";

            if (Wygrana())
            {
                Zliczanie = 9;
            }

        }
        /// <summary>
        /// sprawdzanie wygranej
        /// </summary>
        /// <returns> Zwracana jest wartość true lub false </returns>
        private bool Wygrana()
        {
            if (Button_0_0.Content.ToString() != string.Empty &&
                Button_0_0.Content == Button_0_1.Content && Button_0_1.Content == Button_0_2.Content)
            {
                Button_0_0.Background = Brushes.Red;
                Button_0_1.Background = Brushes.Red;
                Button_0_2.Background = Brushes.Red;
                return true;

            }
            if (Button_1_0.Content.ToString() != string.Empty &&
                Button_1_0.Content == Button_1_1.Content && Button_1_1.Content == Button_1_2.Content)
            {
                Button_1_0.Background = Brushes.Red;
                Button_1_1.Background = Brushes.Red;
                Button_1_2.Background = Brushes.Red;
                return true;
            }
            if (Button_2_0.Content.ToString() != string.Empty &&
                Button_2_0.Content == Button_2_1.Content && Button_2_1.Content == Button_2_2.Content)
            {
                Button_2_0.Background = Brushes.Red;
                Button_2_1.Background = Brushes.Red;
                Button_2_2.Background = Brushes.Red;
                return true;
            }
            if (Button_0_0.Content.ToString() != string.Empty &&
                Button_0_0.Content == Button_1_0.Content && Button_1_0.Content == Button_2_0.Content)
            {
                Button_0_0.Background = Brushes.Red;
                Button_1_0.Background = Brushes.Red;
                Button_2_0.Background = Brushes.Red;
                return true;
            }
            if (Button_0_1.Content.ToString() != string.Empty &&
                Button_0_1.Content == Button_1_1.Content && Button_1_1.Content == Button_2_1.Content)
            {
                Button_0_1.Background = Brushes.Red;
                Button_1_1.Background = Brushes.Red;
                Button_2_1.Background = Brushes.Red;
                return true;
            }
            if (Button_0_2.Content.ToString() != string.Empty &&
                Button_0_2.Content == Button_1_2.Content && Button_1_2.Content == Button_2_2.Content)
            {
                Button_0_2.Background = Brushes.Red;
                Button_1_2.Background = Brushes.Red;
                Button_2_2.Background = Brushes.Red;
                return true;
            }
            if (Button_0_0.Content.ToString() != string.Empty &&
                Button_0_0.Content == Button_1_1.Content && Button_1_1.Content == Button_2_2.Content)
            {
                Button_0_0.Background = Brushes.Red;
                Button_1_1.Background = Brushes.Red;
                Button_2_2.Background = Brushes.Red;
                return true;
            }
            if (Button_0_2.Content.ToString() != string.Empty &&
                Button_0_2.Content == Button_1_1.Content && Button_1_1.Content == Button_2_0.Content)
            {
                Button_0_2.Background = Brushes.Red;
                Button_1_1.Background = Brushes.Red;
                Button_2_0.Background = Brushes.Red;
                return true;
            }

            return false;
        }
    }
}
