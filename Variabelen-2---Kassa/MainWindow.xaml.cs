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

namespace Variabelen_2___Kassa
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

        private void checkNumberButton_Click(object sender, RoutedEventArgs e)
        {
            const int getal = 97;
            int ondernemingsnummer = int.Parse(VATNumberTextBox.Text);
            // int ondernemingsnummer = Convert.ToInt32(TxtOndNr1.Text);
            int resultaat = getal - (ondernemingsnummer % getal);

            checkNumberTextBox.Text = Convert.ToString(resultaat);
        }

        private void calculateButton_Click(object sender, RoutedEventArgs e)
        {
            // Declaratie variabelen.     
            float prijs, teBetalen;
            int aantal;

            // De gebruiker geeft de prijs en het aantal stuks in.  
            // prijs = Convert.ToSingle(TxtPrijs.Text); 
            prijs = float.Parse(priceTextBox.Text);
            aantal = int.Parse(amountTextBox.Text);

            // Berekenen van het te betalen bedrag.     
            teBetalen = prijs * aantal;

            // Tonen van het te betalen bedrag.
            amountToPayTextBox.Text = teBetalen.ToString();

            clearButton.Focus();
        }

        public void clearButton_Click(object sender, RoutedEventArgs e)
        {
            amountTextBox.Text = string.Empty;
            priceTextBox.Text = "";
            amountToPayTextBox.Text = string.Empty;
            VATNumberTextBox.Clear();
            checkNumberTextBox.Clear();

            priceTextBox.Focus();
        }

        public void closeButton_Click(object sender, RoutedEventArgs e)
        {
            // Formulier sluiten.       
            Close();
        }
    }
}
