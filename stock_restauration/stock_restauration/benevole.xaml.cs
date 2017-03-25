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
    /// Logique d'interaction pour benevole.xaml
    /// </summary>
    public partial class benevole : MetroWindow
    {
        public benevole()
        {
            InitializeComponent();
        }

        private void btn_Bar_erdre_Click(object sender, RoutedEventArgs e)
        {
            tab_benevole wind_Bar_er = new tab_benevole;
            wind_Bar_er.ShowDialog();
        }
        


    }
}
