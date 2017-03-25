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

using MahApps.Metro.Controls;

namespace stock_restauration
{
    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    public partial class MainWindow :MetroWindow
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btn_benevole_Click(object sender, RoutedEventArgs e)
        {
            benevole wind_bene = new benevole();
            wind_bene.ShowDialog(); 
        }

        private void btn_organisateur_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
