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

namespace stock_restauration.mdp
{
    /// <summary>
    /// Logique d'interaction pour mot_passe.xaml
    /// </summary>
    public partial class mot_passe : MetroWindow
    {
        string _mdp;
        private bool verif = false;

        private MySql.Data.MySqlClient.MySqlConnection conn;

        string myConnectionString = "server = 127.0.0.1;"
                                    + "uid = root;"
                                    + "pwd = ;"
                                    + "database = stock_resto;";



        public mot_passe()
        {
            InitializeComponent();

            lb_phrase.Content = "Veuillez entrée votre mot de passe";
            
        }

      
        private void btn_OK_Click(object sender, RoutedEventArgs e)
        {
            conn = new MySql.Data.MySqlClient.MySqlConnection(myConnectionString);

            conn.Open();

            #region Recuperation des données
            MySqlCommand cmd = new MySqlCommand();

            cmd.CommandText = "SELECT nom_stand, login_stand.login_stand FROM `stand` INNER JOIN login_stand ON stand.id_login_stand = login_stand.id ";
            cmd.Connection = conn;
            MySqlDataReader rdrMdp = cmd.ExecuteReader();

            #endregion

            while (rdrMdp.Read())
            {
                _mdp = rdrMdp[1].ToString();
                label.Content = rdrMdp[1].ToString();
            }

            if (tbox_mdp.Text == _mdp)
            {
                verif = true;
                menu_organisateur wind_organisateur = new menu_organisateur();
                wind_organisateur.ShowDialog();
            }
            else
            {
                verif = false;
                MessageBox.Show("mot de passe incorrect");
            }


        }
    }
}
