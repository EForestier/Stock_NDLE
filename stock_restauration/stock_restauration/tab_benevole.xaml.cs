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
    public partial class tab_benevole : MetroWindow
    {

        private MySql.Data.MySqlClient.MySqlConnection conn;


        string myConnectionString = "server = 127.0.0.1;"
                                    + "uid = root;"
                                    + "pwd = ;"
                                    + "database = stock_resto;";

        
        public tab_benevole()
        {
            InitializeComponent();

            #region Titre tableau
            List<TITRE> items = new List<TITRE>();
            items.Add(new TITRE() { article = "Article", nbsortie = "Nombre de sortie", stock = "Stock", sortie = "Sortie" });

            lbox_titre.ItemsSource = items;
            #endregion

            afficher_liste();


        }

     //-------------------------------------------------------------------------------------
     //-------------------------------------------------------------------------------------

        #region Afficher le liste de base et avec les filtres
        private void afficher_liste()
        {

            conn = new MySql.Data.MySqlClient.MySqlConnection(myConnectionString);

            try
            {
                conn.Open();

                #region Recuperation des données
                MySqlCommand cmd = new MySqlCommand();

                cmd.CommandText = "SELECT nom, qte, sortie FROM `article` JOIN stand ON article.id_stand = stand.id WHERE id_stand = 3 ";
                cmd.Connection = conn;
                MySqlDataReader rdrStock = cmd.ExecuteReader();

                #endregion

                #region Tableau avec données de BDD

                //Boucle qui recupere les informations dans la base de données 
                // et qui les mets dans un tableau.


                //lbox_article.Items.Clear();

                while (rdrStock.Read())
                {

                    //string Article = rdrStock[0].ToString();
                    //string Stock = rdrStock[0].ToString();
                    //string Sortie = rdrStock[0].ToString();

                    //List<Liste> items = new List<Liste>();
                    //items.Add(new Liste() { liste_article = Article,  liste_nbsortie = "", liste_stock = Stock , liste_sortie = Sortie });

                    //lbox_article.ItemsSource = items;


                    StackPanel spStock = new StackPanel();

                    spStock.Orientation = Orientation.Horizontal;


                    Label nom = new Label();
                    //TextBox nbsotie = new TextBox();
                    Label quantite = new Label();
                    Label sortie = new Label();

                    nom.Width = 395;
                    //nbsotie.Width = 200;
                    quantite.Width = 195;
                    sortie.Width = 195;

                    //nom.HorizontalAlignment = Center;

                    nom.Content = rdrStock[0].ToString();
                    quantite.Content = rdrStock[1].ToString();
                    sortie.Content = rdrStock[2].ToString();
                    //nbsotie.Text = "";
                    //nbsotie.Text = rdrStock[3].ToString();


                    spStock.Children.Add(nom);
                    //spStock.Children.Add(nbsotie);
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
            public string article { get; set; }
            public string nbsortie { get; set; }
            public string stock { get; set; }
            public string sortie { get; set; }
        }
        #endregion

        //-------------------------------------------------------------------------------------

        #region Afficher le titre
        public class Liste
        {
            public string liste_article { get; set; }
            public string liste_nbsortie { get; set; }
            public string liste_stock { get; set; }
            public string liste_sortie { get; set; }
        }
        #endregion
    }
}
