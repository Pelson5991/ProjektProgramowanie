using Kolko_krzyzyk;
using System;
using System.Collections.Generic;
using System.Net.Configuration;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace KolkoiKrzyzyk
{
    /// <summary>
    /// Logika interakcji dla klasy login_screen.xaml
    /// </summary>
    public partial class login_screen : Window
    {
        /// <summary>
        ///  Metoda tworzona automatycznie do konfiguracji kontrolek
        /// </summary>
        public login_screen()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Metoda obsługująca  przycisk logownia
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (helper.ver_login(login.Text))
            {
                var dashboard = new MainWindow();
                dashboard.Show();

                MessageBox.Show("Zalogowano");
                this.Close();
            }
            else
            {
                MessageBox.Show("Niepoprawne dane logowania", "Błąd", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}
