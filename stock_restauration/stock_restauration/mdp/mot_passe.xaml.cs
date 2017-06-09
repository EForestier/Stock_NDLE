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
        bool estOrganisateur;
        //int btn_bene;
        private MySql.Data.MySqlClient.MySqlConnection conn;

        string myConnectionString = "server = 127.0.0.1;"
                                    + "uid = root;"
                                    + "pwd = ;"
                                    + "database = stock_resto;";



        public mot_passe(bool _estOrganisateur)
        {
            InitializeComponent();

            this.estOrganisateur = _estOrganisateur;
            lb_phrase.Content = "Veuillez scannez votre badge";
            tbox_mdp.Focus();
            tbox_mdp.Password = "";

           

            
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
            
            do
            {
                rdrMdp.Read();
                _mdp = rdrMdp[1].ToString();
                
            }
            while (tbox_mdp.Password != _mdp) ;


            //    if (tbox_mdp.Password == _mdp)
            //{
                this.Close();

                if (estOrganisateur == true && tbox_mdp.Password == "organisateur") {
                    menu_organisateur wind_organisateur = new menu_organisateur();
                    _mdp = "";
                    wind_organisateur.ShowDialog();
                }
               else if (estOrganisateur == false && tbox_mdp.Password == "benevole")
                {
                    ListeStand menu_stand = new ListeStand(false);
                    _mdp = "";
                    menu_stand.ShowDialog();
                }
                //else
                //{
                //    configuration wind_configuration = new configuration();
                //    _mdp = "";
                //    wind_configuration.ShowDialog();
                //}
            //}
                else
                {
                    MessageBox.Show("mot de passe incorrect");
                    tbox_mdp.Password = "";
                }
          
        }

       

       
    }
}


