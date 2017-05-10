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
    public partial class ajout : MetroWindow
    {
        private tab_organisateur Fen_Ajout;

        int idA;

        int stock = 0;
        

        private MySql.Data.MySqlClient.MySqlConnection conn;
        string myConnectionString = "server = 127.0.0.1;"
                                    + "uid = root;"
                                    + "pwd = ;"
                                    + "database = stock_resto;";

        public ajout(int idarticle, tab_organisateur Fen = null)
        {

            Fen_Ajout = Fen;
            idA = idarticle;

            InitializeComponent();

            affiche_article();
            
        }

        public void affiche_article()
        {

            conn = new MySql.Data.MySqlClient.MySqlConnection(myConnectionString);
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
                    lb_Article.Content = rdrArticle[0].ToString();

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
                
                stock = stock + Int32.Parse(tbox_ajout.Text);
                
                MySqlCommand cmd = new MySqlCommand("UPDATE article SET  qte=@qte WHERE id=" + idA, conn);

                cmd.Parameters.AddWithValue("@qte", stock);
                
                cmd.ExecuteNonQuery();
                cmd.Parameters.Clear();
                MessageBox.Show("Stock Ajouté.");
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

