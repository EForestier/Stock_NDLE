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
using System.Threading;
using System.Windows.Threading;

namespace stock_restauration
{
    /// <summary>
    /// Logique d'interaction pour tab_benevole.xaml
    /// </summary>
    public partial class Stand : MetroWindow
    {
        public delegate void D_liste();
        private bool _estOrganisateur;
        private bool _etat;
        private MySql.Data.MySqlClient.MySqlConnection conn;
       
        string myConnectionString = "server = 127.0.0.1;"
                                    + "uid = root;"
                                    + "pwd = ;"
                                    + "database = stock_resto;";
        string idStand;

        
        public Stand(bool estOrganisateur,string _idStand)
        {
            InitializeComponent();
            this._estOrganisateur = estOrganisateur;
            this.idStand = _idStand;
            afficher_liste(idStand);

            //DispatcherTimer MAJ_Tableau = new DispatcherTimer();
            //MAJ_Tableau.Tick += new EventHandler(afficher_liste(_idStand));
            //MAJ_Tableau.Interval = TimeSpan.FromSeconds(10);
            
            //MAJ_Tableau.Start();

            #region Titre tableau
            List<TITRE> items = new List<TITRE>();
            items.Add(new TITRE() { rien1 = "" ,article = "Article",  rien = "", stock = "Stock", sortie = "Sortie" });

            lbox_titre.ItemsSource = items;
            #endregion

            //Thread liste = new Thread(Refresh(afficher_liste()));
            //liste.Start();




        }

      
        //-------------------------------------------------------------------------------------
        //-------------------------------------------------------------------------------------

        #region Methode Refresh
        //private void Refresh(string IdStand)
        //{
        //    while (true)
        //    {
        //        Dispatcher.Invoke((D_liste)afficher_liste(_idStand));
        //        Task.Delay(500).Wait();
        //    }
        //}
        #endregion

        //-------------------------------------------------------------------------------------


        #region Afficher le liste des articles
        private void afficher_liste(string IdStand/*, object sender, EventArgs e*/)
        {

            conn = new MySql.Data.MySqlClient.MySqlConnection(myConnectionString);

            try
            {
                conn.Open();

                #region Recuperation des données
                MySqlCommand cmd = new MySqlCommand();

                cmd.CommandText = "SELECT article.id, nom, qte, sortie, stand.nom_stand FROM `article` JOIN stand ON article.id_stand = stand.id WHERE id_stand = " + IdStand;
                cmd.Connection = conn;
                MySqlDataReader rdrStock = cmd.ExecuteReader();

                #endregion

               
                #region Tableau avec données de BDD

                lbox_article.Items.Clear();

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
                    btn_ajout.Click += btn_ajouter_Click;
                    if (!this._estOrganisateur) { btn_ajout.IsEnabled = false; }
                    
                    btn_sup.Content     = "Supprimer" ;
                    btn_sup.Tag         = rdrStock[0].ToString();
                    btn_sup.Click      += btn_supp_Click;
                    if (!this._estOrganisateur) { btn_sup.IsEnabled = false; }

                    btn_sortie.Content = "Sortie";
                    btn_sortie.Tag     = rdrStock[0].ToString();
                    btn_sortie.Click  += btn_sortie_Click;

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
        #region Bouton "Ajouté"
        private void btn_ajouter_Click(object sender, RoutedEventArgs e)
        {
            
            Button btn = (Button)sender;

            int idarticle = Int32.Parse(btn.Tag.ToString());
            try
            {
                ajout action_ajout = new ajout(idarticle, this);
                action_ajout.ShowDialog();

                afficher_liste(idStand);

            }

            catch { this.Close(); }

            
        }
        #endregion

        #region Bouton "Sortie
        private void btn_sortie_Click(object sender, RoutedEventArgs e )
        {
            Button btn = (Button)sender;

           
            int idarticle = Int32.Parse(btn.Tag.ToString());
            try
            {
                sortie action_sortie = new sortie(idarticle, this);
                action_sortie.ShowDialog();

                afficher_liste(idStand);
            }

            catch { this.Close(); }

            
        }
        #endregion

        #region Bouton "Supprimé"
        private void btn_supp_Click(object sender, RoutedEventArgs e)
        {
            Button btn = (Button)sender;

            int idarticle = Int32.Parse(btn.Tag.ToString());
            try
            {
                supprime action_supp = new supprime(idarticle, this);
                action_supp.ShowDialog();

                afficher_liste(idStand);
            }

            catch { this.Close(); }
            

        }
        #endregion
    }
}
