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
using MySql.Data;
using MySql.Data.MySqlClient;
using System.Data;
using MahApps.Metro.Controls;
using System.Windows.Threading;

namespace stock_restauration
{
    /// <summary>
    /// Logique d'interaction pour tab_benevole.xaml
    /// </summary>
    public partial class tab_benevole : MetroWindow
    {

        private MySql.Data.MySqlClient.MySqlConnection conn;


        string myConnectionString = "server = 127.0.0.1;"
                                    + "uid = root;"
                                    + "pwd = ;"
                                    + "database = stock_resto;";

        
        public tab_benevole(string _idStand)
        {
            InitializeComponent();

            DispatcherTimer timer = new DispatcherTimer();
            timer.Interval = TimeSpan.FromSeconds(1);
            timer.Tick += new EventHandler(horloge);
            timer.Start();

            #region Titre tableau
            List<TITRE> items = new List<TITRE>();
            items.Add(new TITRE() { rien1 = "",  article = "Article", nbsortie = "Nombre de sortie",rien = "", stock = "Stock", sortie = "Sortie" });

            lbox_titre.ItemsSource = items;
            #endregion

           

            afficher_liste(_idStand);


        }

     //-------------------------------------------------------------------------------------
     //-------------------------------------------------------------------------------------

        #region Afficher le liste des articles
        private void afficher_liste(string _idStand)
        {

            conn = new MySql.Data.MySqlClient.MySqlConnection(myConnectionString);

            try
            {
                conn.Open();

                #region Recuperation des données
                MySqlCommand cmd = new MySqlCommand();

                cmd.CommandText = "SELECT nom, qte, sortie, stand.nom_stand FROM `article` JOIN stand ON article.id_stand = stand.id WHERE id_stand = " + _idStand;
                cmd.Connection = conn;
                MySqlDataReader rdrStock = cmd.ExecuteReader();

                #endregion

               
                #region Tableau avec données de BDD

                //lbox_article.Items.Clear();

                while (rdrStock.Read())
                {
                    

                    StackPanel spStock = new StackPanel();

                    spStock.Orientation = Orientation.Horizontal;

                    Label rien1         = new Label();
                    Label nom           = new Label();
                    TextBox nbsotie     = new TextBox();
                    Label rien          = new Label();
                    Label quantite      = new Label();
                    Label sortie        = new Label();

                    rien1.Width        = 10;
                    nom.Width          = 195;
                    nbsotie.Width      = 200;
                    rien.Width         = 70;
                    quantite.Width     = 155;
                    sortie.Width       = 145;

                    Titre.Content = rdrStock[3].ToString();

                    nom.Content        = rdrStock[0].ToString();
                    quantite.Content   = rdrStock[1].ToString();
                    sortie.Content     = rdrStock[2].ToString();

                    spStock.Children.Add(rien1);
                    spStock.Children.Add(nom);
                    spStock.Children.Add(nbsotie);
                    spStock.Children.Add(rien);
                    spStock.Children.Add(quantite);
                    spStock.Children.Add(sortie);

                    lbox_article.Items.Add(spStock);

                }
                #endregion
            }

            catch { }

            conn.Close();


        }
        #endregion

    //-------------------------------------------------------------------------------------
        
        #region Afficher le titre
        public class TITRE
        {
            public string rien1 { get; set; }
            public string article { get; set; }
            public string nbsortie { get; set; }
            public string rien { get; set; }
            public string stock { get; set; }
            public string sortie { get; set; }
        }
        #endregion

        //-------------------------------------------------------------------------------------

        private void btn_sortie_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Veuillez entre le mot de passe");

           // int nb_sortie = nbsortie;


        }

        public void horloge(object sender, EventArgs e)
        {
            heure.Content = DateTime.Now.ToLongTimeString();
        }


    }
}
