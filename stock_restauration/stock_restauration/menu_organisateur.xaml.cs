using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using MahApps.Metro.Controls;
using System.Windows.Threading;
using iTextSharp;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;
using MySql.Data;
using MySql.Data.MySqlClient;


namespace stock_restauration
{
    /// <summary>
    /// Logique d'interaction pour menu_organisateur.xaml
    /// </summary>
    public partial class menu_organisateur : MetroWindow
    {
        protected MySql.Data.MySqlClient.MySqlConnection conn;
        string info_BDD = "server=" + Properties.Settings.Default.BDD_adresse + ";"
                              + "uid=" + Properties.Settings.Default.BDD_user + ";"
                              + "pwd=" + Properties.Settings.Default.BDD_password + ";"
                              + "database=" + Properties.Settings.Default.BDD_nom + ";";

        string nomStandString;

        bool etat = false;
        DispatcherTimer Retour = new DispatcherTimer();

        public menu_organisateur()
        {
            InitializeComponent();

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

        //****** Bouton Action ******

        #region Bouton "Liste Stand"
        private void btn_stand_Click(object sender, RoutedEventArgs e)
        {
           ListeStand wind_organisateur = new ListeStand(true);
            etat = true;
            Retour.Stop();
            wind_organisateur.ShowDialog();
            etat = false;
            Retour.Start();
        }
        #endregion

        #region Bouton "Nouvel Article"
        private void btn_nouveau_Click(object sender, RoutedEventArgs e)
        {
            nouveau_article wind_organisateur = new nouveau_article();
            etat = true;
            Retour.Stop();
            wind_organisateur.ShowDialog();
            etat = false;
            Retour.Start();
        }
        #endregion


        #region Bouton "exporter synthèse en PDF"
        private void BTN_export_Click(object sender, RoutedEventArgs e)
        {
            System.IO.FileStream fs = new FileStream("C:\\Users\\nicol\\Desktop" + "\\" + "Synthese gestion de stock.pdf", FileMode.Create);

            Document document = new Document(PageSize.A4, 25, 25, 30, 30);
            // Create an instance to the PDF file by creating an instance of the PDF 
            // Writer class using the document and the filestrem in the constructor.
            PdfWriter writer = PdfWriter.GetInstance(document, fs);

            // Add meta information to the document
            document.AddAuthor("nuit de l'erdre");
            document.AddCreator("Gestion de stock");
            document.AddTitle("synthèse des stock");

            document.Open();

            conn = new MySql.Data.MySqlClient.MySqlConnection(info_BDD);

            conn.Open();

            for (int IdStand = 1; IdStand <= 12; IdStand++)
            {
                MySqlCommand _cmd = new MySqlCommand();

                //création du tableau
                PdfPTable table = new PdfPTable(3);
                
                

                _cmd.CommandText = "SELECT `nom_stand` FROM `stand` WHERE `id` = " + IdStand;
                _cmd.Connection = conn;
                MySqlDataReader nomStand = _cmd.ExecuteReader();
                
                while (nomStand.Read())
                {
                    nomStandString = nomStand[0].ToString();
                }
                PdfPCell cell = new PdfPCell(new Phrase(nomStandString));
                nomStand.Close();

                cell.Colspan = 3;
                cell.HorizontalAlignment = 1; //0=Left, 1=Centre, 2=Right
                table.AddCell(cell);

                _cmd.CommandText = "SELECT article.id, nom, qte, sortie, stand.nom_stand FROM `article` JOIN stand ON article.id_stand = stand.id WHERE id_stand = " + IdStand;
                _cmd.Connection = conn;
                MySqlDataReader rdrStock = _cmd.ExecuteReader();




                while (rdrStock.Read())
                {

                    table.AddCell(rdrStock[1].ToString());
                    table.AddCell(rdrStock[2].ToString());
                    table.AddCell(rdrStock[3].ToString());


                }

                document.Add(table);
                document.Add(new Paragraph("\n"));


                rdrStock.Close();
            }



            conn.Close();



            // Add a simple and wellknown phrase to the document in a flow layout manner

            // Close the document
            document.Close();
            // Close the writer instance
            writer.Close();
            // Always close open filehandles explicity
            fs.Close();

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
            if (etat == false)
            { this.Close(); }
        }
        #endregion

    }

}
