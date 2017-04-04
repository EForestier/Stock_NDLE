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
    /// Logique d'interaction pour tab_benevole.xaml
    /// </summary>
    public partial class tab_benevole : MetroWindow
    {
        public tab_benevole()
        {
            InitializeComponent();

            #region Titre tableau
            List<TITRE> items = new List<TITRE>();
            items.Add(new TITRE() { article = "Article", nbsortie = "Nombre de sortie", stock = "Stock", sortie = "Sortie" });

            lbox_titre.ItemsSource = items;
            #endregion



        }

        #region Afficher le titre
        public class TITRE
        {
            public string article { get; set; }
            public string nbsortie { get; set; }
            public string stock { get; set; }
            public string sortie { get; set; }
        }
        #endregion

    }
}
