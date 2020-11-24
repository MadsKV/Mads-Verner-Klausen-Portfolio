using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using CardForm;

namespace CardForm
{
    public partial class CardGeneratorIndex : Form
    {
        public CardGeneratorIndex()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void generateDeck_Click(object sender, EventArgs e)
        {
            Deck deck = new Deck();
            deck.FillDeck();
            deck.PrintDeck();

            textWindow.Text = deck.PrintDeck();
















            /*var rnd = new Random();
            var randomNumbers = new List<int>();
            string newLine = Environment.NewLine;

            //randomNumbers[0].ToString;
            randomNumbers = Enumerable.Range(1, 54).OrderBy(q => rnd.Next()).Take(54).ToList();
            foreach (var item in randomNumbers)
            {

                textWindow.Text = textWindow.Text + item + newLine;
                randomNumbers.Sort();
                    break;
            }
            

            Random rnd = new Random();
            string newLine = Environment.NewLine;
            int nums = rnd.Next(1, 55);
            textWindow.Text = nums.ToString();
            List<int> list = new List<int>();

            for (int i = 1; i <= 54; i++)
            {
                list.Add(nums = rnd.Next(0, 54));
                textWindow.Text = textWindow.Text + newLine + nums.ToString();
                list.Sort();
            }*/
        }
        private void chooseDeck_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void missingCard_Click(object sender, EventArgs e)
        {

        }

        private void userWindow_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void exit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void textWindow_TextChanged(object sender, EventArgs e)
        {
            textWindow.ScrollBars = ScrollBars.Vertical;
        }

        public void Database_Click(object sender, EventArgs e)
        {
            SqlConnectionStringBuilder builder =
            new SqlConnectionStringBuilder();

            builder.DataSource = @"MADS-V-KLAUSEN\MSSQLSERVER01";
            builder.InitialCatalog = "Cards";
            builder.IntegratedSecurity = true;

            SqlConnection connection = new SqlConnection(builder.ConnectionString);
            connection.Open();

            string c = (Console.ReadLine());
            string t = (Console.ReadLine());
            string o = (Console.ReadLine());
            Cards cards = new Cards();


            cards.InsertCards(c, t, o, connection);
        }
    }
}
