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
    /// Logique d'interaction pour benevole.xaml
    /// </summary>
    public partial class organisateur : MetroWindow
    {

        private string stand_id;

        private MySql.Data.MySqlClient.MySqlConnection conn;


        string myConnectionString = "server = 127.0.0.1;"
                                    + "uid = root;"
                                    + "pwd = ;"
                                    + "database = stock_resto;";

        public organisateur()
        {
            InitializeComponent();
            

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
            tab_organisateur wind_Bar_er = new tab_organisateur("1");
            wind_Bar_er.ShowDialog();
        }

        private void btn_Bar_chat_Click(object sender, RoutedEventArgs e)
        {
            tab_organisateur wind_Bar_er = new tab_organisateur("6");
            wind_Bar_er.ShowDialog();
        }
        #endregion

        #region Crêpe / Galette
        private void btn_Cer_erdre_Click(object sender, RoutedEventArgs e)
        {
            tab_organisateur wind_Cer = new tab_organisateur("2");
            wind_Cer.ShowDialog();
        }
        #endregion

        #region Gâteau
        private void btn_Gat_erdre_Click(object sender, RoutedEventArgs e)
        {
            tab_organisateur wind_Gat_er = new tab_organisateur("3");
            wind_Gat_er.ShowDialog();
        }

        private void btn_Gat_chat_Click(object sender, RoutedEventArgs e)
        {
            tab_organisateur wind_Gat_erdre = new tab_organisateur("7");
            wind_Gat_erdre.ShowDialog();
        }
        #endregion

        #region Snack
        private void btn_Sna_erdre_Click(object sender, RoutedEventArgs e)
        {
            tab_organisateur wind_San_erdre = new tab_organisateur("4");
            wind_San_erdre.ShowDialog();
        }

        private void btn_Sna_Chat_Click_1(object sender, RoutedEventArgs e)
        {
            tab_organisateur wind_San_erdre = new tab_organisateur("9");
            wind_San_erdre.ShowDialog();
        }

        private void btn_Sna_pate_Click(object sender, RoutedEventArgs e)
        {
            tab_organisateur wind_San_erdre = new tab_organisateur("11");
            wind_San_erdre.ShowDialog();
        }
        #endregion

        #region Vin
        private void btn_Vin_chat_Click(object sender, RoutedEventArgs e)
        {
            tab_organisateur wind_Vin_erdre = new tab_organisateur("12");
            wind_Vin_erdre.ShowDialog();
        }
        
        #endregion

        #region Consomable
        private void btn_Con_erdre_Click(object sender, RoutedEventArgs e)
        {
            tab_organisateur wind_Con_erdre = new tab_organisateur("5");
            wind_Con_erdre.ShowDialog();
        }

        private void btn_Con_chat_Click(object sender, RoutedEventArgs e)
        {
            tab_organisateur wind_Con_erdre = new tab_organisateur("10");
            wind_Con_erdre.ShowDialog();
        }
        #endregion

      
    }
}
