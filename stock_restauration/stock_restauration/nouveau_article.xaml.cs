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
using System.Windows.Threading;
using MySql.Data;
using MySql.Data.MySqlClient;
using System.Data;


namespace stock_restauration
{
    /// <summary>
    /// Logique d'interaction pour nouveau_article.xaml
    /// </summary>
    public partial class nouveau_article : MetroWindow
    {
       

        private MySql.Data.MySqlClient.MySqlConnection conn;


        string myConnectionString = "server = 127.0.0.1;"
                                    + "uid = root;"
                                    + "pwd = ;"
                                    + "database = stock_resto;";


        public nouveau_article()
        {
            InitializeComponent();

            DispatcherTimer timer = new DispatcherTimer();
            timer.Interval = TimeSpan.FromSeconds(1);
            timer.Tick += new EventHandler(horloge);
            timer.Start();

           
            
        }


        private void btn_nouveau_Click(object sender, RoutedEventArgs e)
        {
            conn = new MySql.Data.MySqlClient.MySqlConnection(myConnectionString);

            conn.Open();
            
            MySqlCommand cmd = new MySqlCommand("INSERT INTO article(id, nom, qte, sortie, id_stand) VALUES(NULL,@nom,@qte,NULL,@id_stand)", conn);
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@nom", tBox_article.Text);
            cmd.Parameters.AddWithValue("@qte", tBox_quantite.Text);

            #region Parametre filtre requete " ERDRE "
            
            //Barbeuck = 1
            if ((cb_barbeuck.IsChecked == true) && (cb_erdre.IsChecked == true))
            {
                cmd.Parameters.AddWithValue("@id_stand", 1);
            }
            //Crepe = 2
            if ((cb_crepe.IsChecked == true) && (cb_erdre.IsChecked == true))
            {
                cmd.Parameters.AddWithValue("@id_stand", 2);
            }
            //Gateau = 3
            if ((cb_gateau.IsChecked == true) && (cb_erdre.IsChecked == true))
            {
                cmd.Parameters.AddWithValue("@id_stand", 3);
            }
            //Chiken = 4
            if ((cb_chiken.IsChecked == true) && (cb_erdre.IsChecked == true))
            {
                cmd.Parameters.AddWithValue("@id_stand", 4);
            }
            //Consomable = 5
            if ((cb_consomable.IsChecked == true) && (cb_erdre.IsChecked == true))
            {
                cmd.Parameters.AddWithValue("@id_stand", 5);
            }

            #endregion

            #region Parametre filtre requete " CHATEAU "

            //Barbeuck = 6
            if ((cb_chateau.IsChecked == true) && (cb_chateau.IsChecked == true))
            {
                cmd.Parameters.AddWithValue("@id_stand", 6);
            }  
            //Gateau = 8
            if ((cb_gateau.IsChecked == true) && (cb_chateau.IsChecked == true))
            {
                cmd.Parameters.AddWithValue("@id_stand", 7);
            }
            //Chiken = 9
            if ((cb_chiken.IsChecked == true) && (cb_chateau.IsChecked == true))
            {
                cmd.Parameters.AddWithValue("@id_stand", 9);
            }
            //Pate = 11
            if ((cb_pate.IsChecked == true) && (cb_chateau.IsChecked == true))
            {
                cmd.Parameters.AddWithValue("@id_stand", 11);
            }
            //Vin = 12
            if ((cb_vin.IsChecked == true) && (cb_chateau.IsChecked == true))
            {
                cmd.Parameters.AddWithValue("@id_stand", 12);
            }
            //Consomable = 10
            if ((cb_consomable.IsChecked == true) && (cb_chateau.IsChecked == true))
            {
                cmd.Parameters.AddWithValue("@id_stand", 10);
            }
           
            #endregion

            cmd.ExecuteNonQuery();
            cmd.Parameters.Clear();
            MessageBox.Show("Article ajouté avec succès.");
            conn.Close();

        }


        #region Gestion des Filtres
        private void filtrer(object sender, RoutedEventArgs e)
        {

            #region CheckBox = RadionButton
            CheckBox ck = sender as CheckBox;

            if ((ck.Name == "cb_barbeuck") && (ck.IsChecked == true))
            {
                cb_crepe.IsChecked = false;
                cb_gateau.IsChecked = false;
                cb_chiken.IsChecked = false;
                cb_vin.IsChecked = false;
                cb_pate.IsChecked = false;
                cb_consomable.IsChecked = false;              
            }
            else if ((ck.Name == "cb_crepe") && (ck.IsChecked == true))
            {
                cb_barbeuck.IsChecked = false;
                cb_gateau.IsChecked = false;
                cb_chiken.IsChecked = false;
                cb_vin.IsChecked = false;
                cb_pate.IsChecked = false;
                cb_consomable.IsChecked = false;
            }

            else if ((ck.Name == "cb_gateau") && (ck.IsChecked == true))
            {
                cb_barbeuck.IsChecked = false;
                cb_crepe.IsChecked = false;
                cb_chiken.IsChecked = false;
                cb_vin.IsChecked = false;
                cb_pate.IsChecked = false;
                cb_consomable.IsChecked = false;              
            }
            else if ((ck.Name == "cb_chiken") && (ck.IsChecked == true))
            {
                cb_barbeuck.IsChecked = false;
                cb_crepe.IsChecked = false;
                cb_gateau.IsChecked = false;
                cb_vin.IsChecked = false;
                cb_pate.IsChecked = false;
                cb_consomable.IsChecked = false;
            }
            else if ((ck.Name == "cb_vin") && (ck.IsChecked == true))
            {
                cb_barbeuck.IsChecked = false;
                cb_crepe.IsChecked = false;
                cb_gateau.IsChecked = false;
                cb_chiken.IsChecked = false;
                cb_pate.IsChecked = false;
                cb_consomable.IsChecked = false;
            }
            else if ((ck.Name == "cb_pate") && (ck.IsChecked == true))
            {
                cb_barbeuck.IsChecked = false;
                cb_crepe.IsChecked = false;
                cb_gateau.IsChecked = false;
                cb_chiken.IsChecked = false;
                cb_vin.IsChecked = false;
                cb_consomable.IsChecked = false;
            }
            else if ((ck.Name == "cb_consomable") && (ck.IsChecked == true))
            {
                cb_barbeuck.IsChecked = false;
                cb_crepe.IsChecked = false;
                cb_gateau.IsChecked = false;
                cb_vin.IsChecked = false;
                cb_pate.IsChecked = false;
                cb_chiken.IsChecked = false;              
            }

            // -------------------------------------------------------------------------

           else if ((ck.Name == "cb_erdre") && (ck.IsChecked == true))
            {
                cb_chateau.IsChecked = false;
            }
            else if ((ck.Name == " cb_chateau") && (ck.IsChecked == true))
            {
                cb_erdre.IsChecked = false;
            }
           
            #endregion

        }
        #endregion

        public void horloge(object sender, EventArgs e)
        {
            heure.Content = DateTime.Now.ToLongTimeString();
        }

       
    }
}
