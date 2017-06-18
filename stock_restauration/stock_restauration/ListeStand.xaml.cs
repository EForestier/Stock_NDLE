﻿using System;
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
using System.Threading;


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

        bool etat = false;
        DispatcherTimer Retour = new DispatcherTimer();

        public ListeStand(bool estOrganisateur)
        {
            InitializeComponent();
            this.estOrganisateur = estOrganisateur;

            // Timer "Heure"
            DispatcherTimer timer = new DispatcherTimer();
            timer.Interval = TimeSpan.FromSeconds(1);
            timer.Tick += new EventHandler(horloge);
            timer.Start();

            // Timer "Fremeture automatique"
            Retour.Interval = TimeSpan.FromSeconds(10);
            Retour.Tick += new EventHandler(Ferme);
            Retour.Start();

        }

   
        #region Recuperation des données
        private void nom_stand()
        {
            conn.Open();

            
            MySqlCommand cmd = new MySqlCommand();

            cmd.CommandText = "SELECT * FROM `stand` ";
            cmd.Connection = conn;
            MySqlDataReader rdrStand = cmd.ExecuteReader();

            btn_Bar_erdre.Tag += " WHERE id = 1";
           
        }
        #endregion

        //****** Bouton Stand ******

        #region Stand "Barbeuck"
        private void btn_Bar_erdre_Click(object sender, RoutedEventArgs e)
        {
            Stand wind_Bar_er = new Stand(estOrganisateur,"1");
            etat = true;
            Retour.Stop();
            wind_Bar_er.ShowDialog();
            etat = false;
            Retour.Start();
        }

        private void btn_Bar_chat_Click(object sender, RoutedEventArgs e)
        {
            Stand wind_Bar_er = new Stand(estOrganisateur,"6");
            etat = true;
            Retour.Stop();
            wind_Bar_er.ShowDialog();
            etat = false;
            Retour.Start();
        }
        #endregion

        #region Stand "Crêpe / Galette"
        private void btn_Cer_erdre_Click(object sender, RoutedEventArgs e)
        {
            Stand wind_Cer = new Stand(estOrganisateur,"2");
            etat = true;
            Retour.Stop();
            wind_Cer.ShowDialog();
            etat = false;
            Retour.Start();
        }
        #endregion

        #region Stand "Gâteau"
        private void btn_Gat_erdre_Click(object sender, RoutedEventArgs e)
        {
            Stand wind_Gat_er = new Stand(estOrganisateur,"3");
            etat = true;
            Retour.Stop();
            wind_Gat_er.ShowDialog();
            etat = false;
            Retour.Start();
           
        }

        private void btn_Gat_chat_Click(object sender, RoutedEventArgs e)
        {
            Stand wind_Gat_erdre = new Stand(estOrganisateur,"7");
            etat = true;
            Retour.Stop();
            wind_Gat_erdre.ShowDialog();
            etat = false;
            Retour.Start();
        }
        #endregion

        #region Stand "Snack"
        private void btn_Sna_erdre_Click(object sender, RoutedEventArgs e)
        {
            Stand wind_San_erdre = new Stand(estOrganisateur,"4");
            etat = true;
            Retour.Stop();
            wind_San_erdre.ShowDialog();
            etat = false;
            Retour.Start();
        }

        private void btn_Sna_Chat_Click_1(object sender, RoutedEventArgs e)
        {
            Stand wind_San_erdre = new Stand(estOrganisateur,"9");
            etat = true;
            Retour.Stop();
            wind_San_erdre.ShowDialog();
            etat = false;
            Retour.Start();
        }

        private void btn_Sna_pate_Click(object sender, RoutedEventArgs e)
        {
            Stand wind_San_erdre = new Stand(estOrganisateur,"11");
            etat = true;
            Retour.Stop();
            wind_San_erdre.ShowDialog();
            etat = false;
            Retour.Start();
        }
        #endregion

        #region Stand "Vin / Formage"
        private void btn_Vin_chat_Click(object sender, RoutedEventArgs e)
        {
            Stand wind_Vin_erdre = new Stand(estOrganisateur,"12");
            etat = true;
            Retour.Stop();
            wind_Vin_erdre.ShowDialog();
            etat = false;
            Retour.Start();
        }

        #endregion

        #region Stand "Consomable"
        private void btn_Con_erdre_Click(object sender, RoutedEventArgs e)
        {
            Stand wind_Con_erdre = new Stand(estOrganisateur,"5");
            etat = true;
            Retour.Stop();
            wind_Con_erdre.ShowDialog();
            etat = false;
            Retour.Start();
        }

        private void btn_Con_chat_Click(object sender, RoutedEventArgs e)
        {
            Stand wind_Con_erdre = new Stand(estOrganisateur,"10");
            etat = true;
            Retour.Stop();
            wind_Con_erdre.ShowDialog();
            etat = false;
            Retour.Start();
        }
        #endregion

        // ****** OPTION ******

        #region Heure
        public void horloge(object sender, EventArgs e)
        {
            heure.Content = DateTime.Now.ToLongTimeString();
        }
        #endregion

        #region Fremeture automatique si aucune action
        public void Ferme(object sender, EventArgs e)
        {            
            if(etat == false)
            { this.Close(); }                
        }
        #endregion



    }
}
