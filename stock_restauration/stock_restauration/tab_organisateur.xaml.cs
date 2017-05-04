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

namespace stock_restauration
{
    /// <summary>
    /// Logique d'interaction pour tab_benevole.xaml
    /// </summary>
    public partial class tab_organisateur : MetroWindow
    {

        private MySql.Data.MySqlClient.MySqlConnection conn;


        string myConnectionString = "server = 127.0.0.1;"
                                    + "uid = root;"
                                    + "pwd = ;"
                                    + "database = stock_resto;";

        
        public tab_organisateur(string _idStand)
        {
            InitializeComponent();

            #region Titre tableau
            List<TITRE> items = new List<TITRE>();
            items.Add(new TITRE() { check = "" ,article = "Article", nbsortie = "Nombre de sortie", rien = "", stock = "Stock", sortie = "Sortie" });

            lbox_titre.ItemsSource = items;
            #endregion

           

            afficher_liste(_idStand);


        }

        //-------------------------------------------------------------------------------------
        //-------------------------------------------------------------------------------------

        #region Afficher le liste des articless
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

                    CheckBox sup        = new CheckBox();
                    Label nom           = new Label();
                    TextBox nbsortie    = new TextBox();
                    Label rien          = new Label();
                    Label quantite      = new Label();
                    Label sortie        = new Label();

                    sup.Width          = 30;
                    nom.Width          = 195;
                    rien.Width         = 15;
                    nbsortie.Width     = 200;
                    quantite.Width     = 195;
                    sortie.Width       = 175;

                    Titre.Content = rdrStock[3].ToString();
                    
                    nom.Content        = rdrStock[0].ToString();
                    quantite.Content   = rdrStock[1].ToString();
                    sortie.Content     = rdrStock[2].ToString();
                   
                    spStock.Children.Add(sup);
                    spStock.Children.Add(nom);
                    spStock.Children.Add(nbsortie);
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
            public string check { get; set; }
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

        }


        private void btn_suprimmer_Click(object sender, RoutedEventArgs e)
        {




        }
    }
}
