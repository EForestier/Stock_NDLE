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
    public partial class supprime : MetroWindow
    {

        private Stand Fen_Ajout;

        int idA;

        int stock = 0;


        private MySql.Data.MySqlClient.MySqlConnection conn;
        string info_BDD = "server=" + Properties.Settings.Default.BDD_adresse + ";"
                             + "uid=" + Properties.Settings.Default.BDD_user + ";"
                             + "pwd=" + Properties.Settings.Default.BDD_password + ";"
                             + "database=" + Properties.Settings.Default.BDD_nom + ";";

        public supprime(int idarticle, Stand Fen = null)
        {
            Fen_Ajout = Fen;
            idA = idarticle;

            InitializeComponent();

            affiche_article();

        }

        //-------------------------------------------------------------------------------------
        //-------------------------------------------------------------------------------------

        public void affiche_article()
        {

            conn = new MySql.Data.MySqlClient.MySqlConnection(info_BDD);
            try
            {
                conn.Open();

                MySqlCommand cmd = new MySqlCommand();
                cmd.CommandText = "SELECT nom, qte, stand.nom_stand FROM `article` INNER JOIN `stand`  ON article.id_stand = stand.id WHERE article.id = " + idA;
                cmd.Connection = conn;
                MySqlDataReader rdrArticle = cmd.ExecuteReader();

                while (rdrArticle.Read())
                {

                    lb_Titre.Content = rdrArticle[2].ToString();
                    lb_Article.Content = "Voullez vous vraiment supprimé : " + rdrArticle[0].ToString();

                    stock = rdrArticle[1].GetHashCode();
                }

                rdrArticle.Close();
            }
            catch
            {
                this.Close();
                MessageBox.Show("Base de données inexistante.");
            }

        }

        private void btn_valider_Click(object sender, RoutedEventArgs e)
        {

            try
            {
               
                MySqlCommand cmd = new MySqlCommand("DELETE FROM `article` WHERE `article`.`id` = " + idA, conn);
                
                cmd.ExecuteNonQuery();
                cmd.Parameters.Clear();
                MessageBox.Show("Article Supprimé.");
                conn.Close();

                //if (Fen_Ajout != null) Fen_Ajout.afficher_liste();
                this.Close();
            }
            catch
            {
                this.Close();
                MessageBox.Show("Base de données inexistante.");
            }
        }

        private void btn_annule_Click(object sender, RoutedEventArgs e)
        {
                this.Close();    
        }

    }
}
