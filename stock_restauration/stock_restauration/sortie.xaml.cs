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
using MySql.Data;
using MySql.Data.MySqlClient;
using System.Data;
using System.Configuration;


namespace stock_restauration
{
    /// <summary>
    /// Logique d'interaction pour configuration.xaml
    /// </summary>
    public partial class sortie : MetroWindow
    {
        private Stand Fen_Sortie;

        int idA;
        int stock     = 0;
        int st_sortie = 0;

        private MySql.Data.MySqlClient.MySqlConnection conn;
        string info_BDD = "server=" + Properties.Settings.Default.BDD_adresse + ";"
                             + "uid=" + Properties.Settings.Default.BDD_user + ";"
                             + "pwd=" + Properties.Settings.Default.BDD_password + ";"
                             + "database=" + Properties.Settings.Default.BDD_nom + ";";

        public sortie(int idarticle, Stand Fen = null)
        {
            Fen_Sortie = Fen;
            idA = idarticle;

            InitializeComponent();

            affiche_article();


        }


        public void affiche_article()
        {

            conn = new MySql.Data.MySqlClient.MySqlConnection(info_BDD);
            try
            {
                conn.Open();

                MySqlCommand cmd = new MySqlCommand();
                cmd.CommandText = "SELECT nom, qte, sortie, stand.nom_stand FROM `article` INNER JOIN `stand`  ON article.id_stand = stand.id WHERE article.id = " + idA;
                cmd.Connection = conn;
                MySqlDataReader rdrArticle = cmd.ExecuteReader();

                while (rdrArticle.Read())
                {

                    lb_Titre.Content = rdrArticle[3].ToString();
                    lb_Article.Content = rdrArticle[0].ToString();

                    stock = rdrArticle[1].GetHashCode();
                    st_sortie = rdrArticle[2].GetHashCode();

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
                stock = stock - Int32.Parse(tbox_sortie.Text);
                st_sortie = st_sortie + Int32.Parse(tbox_sortie.Text);


                MySqlCommand cmd = new MySqlCommand("UPDATE article SET  qte=@qte, sortie=@sortie WHERE id=" + idA, conn);

                cmd.Parameters.AddWithValue("@qte", stock);
                cmd.Parameters.AddWithValue("@sortie", st_sortie);

                cmd.ExecuteNonQuery();
                cmd.Parameters.Clear();
                MessageBox.Show("Stock Sortie.");
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
    }


}
