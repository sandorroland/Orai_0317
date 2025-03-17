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
using System.Windows.Shapes;

namespace Orai_0317
{
    /// <summary>
    /// Interaction logic for FelvetelWindow.xaml
    /// </summary>
    public partial class FelvetelWindow : Window
    {
        public FelvetelWindow()
        {
            InitializeComponent();
        }

        private void Megse_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void Felvetel_Click(object sender, RoutedEventArgs e)
        {
            //A kötelező mezők ellenőrzése HF
            //Ha kitöltöttek, akkor példányosítunk egy új kedvencetű
            Pet ujKedvenc=new Pet(tbxNev.Text,tbxFaj.Text,tbxFajta.Text,tbxNem.Text,tbxSzin.Text,DateTime.Parse(dpSzulDatum.Text),int.Parse(tbxSuly.Text),tbxEtel.Text,tbxJatek.Text);

            //Hozzáadjuk az eredeti listához a főablakban
            MainWindow.pets.Add(ujKedvenc);
            MessageBox.Show("Sikeres felvétel.");
            Close();
        }
    }
}
