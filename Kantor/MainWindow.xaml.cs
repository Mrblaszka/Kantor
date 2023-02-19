using System;
using System.Collections;
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

namespace Kantor
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        public float wartosc = 0;
        public float przelicznik = 1;
        public int ilosc = 0;




        public MainWindow()
        {
            InitializeComponent();
            txt2.IsReadOnly = true;

            pierwsza.Items.Add("EUR");
            pierwsza.Items.Add("PLN");
            pierwsza.Items.Add("USD");
            pierwsza.Items.Add("CHF");
            pierwsza.Items.Add("GBP");
            pierwsza.Items.Add("JPY");
            pierwsza.Items.Add("CAD");

            druga.Items.Add("EUR");
            druga.Items.Add("PLN");
            druga.Items.Add("USD");
            druga.Items.Add("CHF");
            druga.Items.Add("GBP");
            druga.Items.Add("JPY");
            druga.Items.Add("CAD");



        }

        private void pierwsza_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string ilosc_str = txt1.Text.ToString();
            int.TryParse(ilosc_str, out ilosc);
            string wynik_str = txt2.Text;
            float wynik;
            float.TryParse(wynik_str, out wynik);
            wynik = przelicznik * ilosc;
            txt2.Text = wynik.ToString();
            string str = druga.Text;

            //EURO
            if (pierwsza.Text == "EUR")
            {
                switch (str)
                {
                    case "EUR": przelicznik = 1f; break;
                    case "PLN": przelicznik = 4.755f; break;
                    case "USD": przelicznik = 1.08f; break;
                    case "CHF": przelicznik = 0.99f; break;
                    case "GBP": przelicznik = 0.89f; break;
                    case "JPY": przelicznik = 140.79f; break;
                    case "CAD": przelicznik = 1.44f; break;
                }
            }

            //ZŁOTY
            if (pierwsza.Text == "PLN")
            {
                switch (str)
                {
                    case "EUR": przelicznik = 0.21f; break;
                    case "PLN": przelicznik = 1f; break;
                    case "USD": przelicznik = 0.23f; break;
                    case "CHF": przelicznik = 0.21f; break;
                    case "GBP": przelicznik = 0.19f; break;
                    case "JPY": przelicznik = 29.68f; break;
                    case "CAD": przelicznik = 0.30f; break;
                }
            }

            //JEN
            if (pierwsza.Text == "JPY")
            {
                switch (str)
                {
                    case "EUR": przelicznik = 0.0071f; break;
                    case "PLN": przelicznik = 0.034f; break;
                    case "USD": przelicznik = 0.0077f; break;
                    case "CHF": przelicznik = 0.0070f; break;
                    case "GBP": przelicznik = 0.0063f; break;
                    case "JPY": przelicznik = 1f; break;
                    case "CAD": przelicznik = 0.010f; break;
                }
            }

            //DOLAR AMERYKAŃSKI
            if (pierwsza.Text == "USD")
            {
                switch (str)
                {
                    case "EUR": przelicznik = 0.93f; break;
                    case "PLN": przelicznik = 4.39f; break;
                    case "USD": przelicznik = 1f; break;
                    case "CHF": przelicznik = 0.92f; break;
                    case "GBP": przelicznik = 0.82f; break;
                    case "JPY": przelicznik = 130.40f; break;
                    case "CAD": przelicznik = 1.34f; break;
                }
            }

            //FUNT BRYTYJSKI
            if (pierwsza.Text == "GBP")
            {
                switch (str)
                {
                    case "EUR": przelicznik = 1.13f; break;
                    case "PLN": przelicznik = 5.36f; break;
                    case "USD": przelicznik = 1.22f; break;
                    case "CHF": przelicznik = 1.12f; break;
                    case "GBP": przelicznik = 1f; break;
                    case "JPY": przelicznik = 159.10f; break;
                    case "CAD": przelicznik = 1.63f; break;
                }
            }

            //FRANK SZWAJCARSKI
            if (pierwsza.Text == "CHF")
            {
                switch (str)
                {
                    case "EUR": przelicznik = 1.01f; break;
                    case "PLN": przelicznik = 4.79f; break;
                    case "USD": przelicznik = 1.09f; break;
                    case "CHF": przelicznik = 1f; break;
                    case "GBP": przelicznik = 0.90f; break;
                    case "JPY": przelicznik = 142.38f; break;
                    case "CAD": przelicznik = 1.46f; break;
                }
            }


            //DOLAR KANADYJSKI
            if (pierwsza.Text == "CAD")
            {
                switch (str)
                {
                    case "EUR": przelicznik = 0.69f; break;
                    case "PLN": przelicznik = 3.28f; break;
                    case "USD": przelicznik = 0.75f; break;
                    case "CHF": przelicznik = 0.69f; break;
                    case "GBP": przelicznik = 0.61f; break;
                    case "JPY": przelicznik = 97.55f; break;
                    case "CAD": przelicznik = 1f; break;
                }
            }

        

    }

        private void druga_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
          
        }
    }
}
