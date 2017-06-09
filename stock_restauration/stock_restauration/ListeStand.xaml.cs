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
using System.Windows.Threading;

namespace stock_restauration
{
    /// <summary>
    /// Logique d'interaction pour benevole.xaml
    /// </summary>
    public partial class ListeStand : MetroWindow
    {

        private string stand_id;
        private bool estOrganisateur;
        private MySql.Data.MySqlClient.MySqlConnection conn;


        string myConnectionString = "server = 127.0.0.1;"
                                    + "uid = root;"
                                    + "pwd = ;"
                                    + "database = stock_resto;";

        public ListeStand(bool estOrganisateur)
        {
            InitializeComponent();
            this.estOrganisateur = estOrganisateur;

            DispatcherTimer timer = new DispatcherTimer();
            timer.Interval = TimeSpan.FromSeconds(1);
            timer.Tick += new EventHandler(horloge);
            timer.Start();


        }

        private void nom_stand()
        {
            conn.Open();

            #region Recuperation des données
            MySqlCommand cmd = new MySqlCommand();

            cmd.CommandText = "SELECT * FROM `stand` ";
            cmd.Connection = conn;
            MySqlDataReader rdrStand = cmd.ExecuteReader();

            btn_Bar_erdre.Tag += " WHERE id = 1";
            #endregion
        }


        #region Barbeuck
        private void btn_Bar_erdre_Click(object sender, RoutedEventArgs e)
        {
            Stand wind_Bar_er = new Stand(estOrganisateur,"1");
            wind_Bar_er.ShowDialog();
        }

        private void btn_Bar_chat_Click(object sender, RoutedEventArgs e)
        {
            Stand wind_Bar_er = new Stand(estOrganisateur,"6");
            wind_Bar_er.ShowDialog();
        }
        #endregion

        #region Crêpe / Galette
        private void btn_Cer_erdre_Click(object sender, RoutedEventArgs e)
        {
            Stand wind_Cer = new Stand(estOrganisateur,"2");
            wind_Cer.ShowDialog();
        }
        #endregion

        #region Gâteau
        private void btn_Gat_erdre_Click(object sender, RoutedEventArgs e)
        {
            Stand wind_Gat_er = new Stand(estOrganisateur,"3");
            wind_Gat_er.ShowDialog();
        }

        private void btn_Gat_chat_Click(object sender, RoutedEventArgs e)
        {
            Stand wind_Gat_erdre = new Stand(estOrganisateur,"7");
            wind_Gat_erdre.ShowDialog();
        }
        #endregion

        #region Snack
        private void btn_Sna_erdre_Click(object sender, RoutedEventArgs e)
        {
            Stand wind_San_erdre = new Stand(estOrganisateur,"4");
            wind_San_erdre.ShowDialog();
        }

        private void btn_Sna_Chat_Click_1(object sender, RoutedEventArgs e)
        {
            Stand wind_San_erdre = new Stand(estOrganisateur,"9");
            wind_San_erdre.ShowDialog();
        }

        private void btn_Sna_pate_Click(object sender, RoutedEventArgs e)
        {
            Stand wind_San_erdre = new Stand(estOrganisateur,"11");
            wind_San_erdre.ShowDialog();
        }
        #endregion

        #region Vin
        private void btn_Vin_chat_Click(object sender, RoutedEventArgs e)
        {
            Stand wind_Vin_erdre = new Stand(estOrganisateur,"12");
            wind_Vin_erdre.ShowDialog();
        }
        
        #endregion

        #region Consomable
        private void btn_Con_erdre_Click(object sender, RoutedEventArgs e)
        {
            Stand wind_Con_erdre = new Stand(estOrganisateur,"5");
            wind_Con_erdre.ShowDialog();
        }

        private void btn_Con_chat_Click(object sender, RoutedEventArgs e)
        {
            Stand wind_Con_erdre = new Stand(estOrganisateur,"10");
            wind_Con_erdre.ShowDialog();
        }
        #endregion

        #region Heure
        public void horloge(object sender, EventArgs e)
        {
            heure.Content = DateTime.Now.ToLongTimeString();
        }
        #endregion

    }
}
