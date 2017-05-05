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
            items.Add(new TITRE() { rien1 = "" ,article = "Article",  rien = "", stock = "Stock", sortie = "Sortie" });

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

                cmd.CommandText = "SELECT article.id, nom, qte, sortie, stand.nom_stand FROM `article` JOIN stand ON article.id_stand = stand.id WHERE id_stand = " + _idStand;
                cmd.Connection = conn;
                MySqlDataReader rdrStock = cmd.ExecuteReader();

                #endregion

               
                #region Tableau avec données de BDD

                //lbox_article.Items.Clear();

                while (rdrStock.Read())
                {
                    

                    StackPanel spStock = new StackPanel();

                    spStock.Orientation = Orientation.Horizontal;

                    Button btn_sup      = new Button();
                    Button btn_ajout    = new Button();
                    Button btn_sortie   = new Button();
                    Label rien3         = new Label();
                    Label nom           = new Label();
                    TextBox nbsortie    = new TextBox();
                    Label rien          = new Label();
                    Label rien1         = new Label();
                    Label rien2         = new Label();
                    Label quantite      = new Label();
                    Label sortie        = new Label();

                    rien3.Width        = 5;
                    nom.Width          = 170;
                    rien.Width         = 15;
                    nbsortie.Width     = 200;
                    quantite.Width     = 170;
                    sortie.Width       = 160;

                    btn_ajout.Width    = 80;
                    rien1.Width        = 5;
                    btn_sortie.Width   = 80;
                    rien2.Width        = 15;
                    btn_sup.Width      = 80;
                  

                    Titre.Content = rdrStock[4].ToString();

                    btn_ajout.Content = "Ajouer";
                    btn_ajout.Tag = rdrStock[0].ToString();
                    btn_ajout.Click += btn_suprimmer_Click;

                    btn_sup.Content        = "Supprimer" ;
                    btn_sup.Tag            = rdrStock[0].ToString();
                    btn_sup.Click        += btn_suprimmer_Click;
                    
                    btn_sortie.Content = "Sortie";
                    btn_sortie.Tag = rdrStock[0].ToString();
                    btn_sortie.Click += btn_suprimmer_Click;

                    nom.Content        = rdrStock[1].ToString();
                    quantite.Content   = rdrStock[2].ToString();
                    sortie.Content     = rdrStock[3].ToString();

                    spStock.Children.Add(rien3);
                    spStock.Children.Add(nom);
                    spStock.Children.Add(rien);
                    spStock.Children.Add(quantite);
                    spStock.Children.Add(sortie);

                    spStock.Children.Add(btn_ajout);
                    spStock.Children.Add(rien1);
                    spStock.Children.Add(btn_sortie);
                    spStock.Children.Add(rien2);
                    spStock.Children.Add(btn_sup);
                    

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

            Button btn = sender as Button;
           
            int id_article = Int32.Parse(btn.Tag.ToString());

            conn = new MySql.Data.MySqlClient.MySqlConnection(myConnectionString);
            conn.Open();

            MySqlCommand cmd = new MySqlCommand();

            cmd.CommandText = "DELETE FROM `article` WHERE `article`.`id` = @Article_id";

            cmd.Parameters.AddWithValue("@Article_id", id_article);

            cmd.ExecuteNonQuery();
            cmd.Parameters.Clear();
            MessageBox.Show("Article supprimé avec succès.");

            conn.Close();
            

        }
    
    }
}
