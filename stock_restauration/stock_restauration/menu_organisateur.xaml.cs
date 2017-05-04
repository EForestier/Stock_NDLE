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
using MahApps.Metro.Controls;

namespace stock_restauration
{
    /// <summary>
    /// Logique d'interaction pour menu_organisateur.xaml
    /// </summary>
    public partial class menu_organisateur : MetroWindow
    {
        public menu_organisateur()
        {
            InitializeComponent();
        }

        private void btn_stand_Click(object sender, RoutedEventArgs e)
        {
           organisateur wind_organisateur = new organisateur();
           wind_organisateur.ShowDialog();
        }

        private void btn_nouveau_Click(object sender, RoutedEventArgs e)
        {
            nouveau_article wind_organisateur = new nouveau_article();
            wind_organisateur.ShowDialog();
        }
    }
}
