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
            const int CheckNumber = 97;
            int vatNumber = int.Parse(VATNumberTextBox.Text);
            // int ondernemingsnummer = Convert.ToInt32(TxtOndNr1.Text);
            int result = CheckNumber - (vatNumber % CheckNumber);

            checkNumberTextBox.Text = Convert.ToString(result);
        }

        private void calculateButton_Click(object sender, RoutedEventArgs e)
        {
            // Declaratie variabelen.     
            float price;
            float amountToPay;
            int amount;

            // De gebruiker geeft de prijs en het aantal stuks in.  
            // prijs = Convert.ToSingle(TxtPrijs.Text); 
            price = float.Parse(priceTextBox.Text);
            amount = int.Parse(amountTextBox.Text);

            // Berekenen van het te betalen bedrag.     
            amountToPay = price * amount;

            // Tonen van het te betalen bedrag.
            amountToPayTextBox.Text = amountToPay.ToString();

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
