using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Drawing;

namespace CardForm
{
    public partial class CardGeneratorIndex : Form
    {
        Deck myDeck;
        private PictureBox[] pictures;
        public const string imagePath = @"C:\Users\MadsV\OneDrive\Dokumenter\GitHub\Mads-Verner-Klausen-Portfolio\Visual Studio Projects\Cards\Cards\CardForm\CardForm\Cards\";
        public CardGeneratorIndex()
        {
            InitializeComponent();
            pictures = new PictureBox[52];
        }
        public static SqlConnection Connection()
        {
            SqlConnectionStringBuilder builder =
            new SqlConnectionStringBuilder();

            //Finds and Uses the correct Database
            builder.DataSource = @"MADS-V-KLAUSEN\MSSQLSERVER01";
            //builder.DataSource = @"DESKTOP-CHHJASV\SQLEXPRESS";
            builder.InitialCatalog = "Cards";
            builder.IntegratedSecurity = true;

            //Opens the database's connection
            SqlConnection connection = new SqlConnection(builder.ConnectionString);
            connection.Open();
            return connection;
        }

        private void ShuffleCards()
        {
            Random rand = new Random();
            for (int i = 0; i < 1000; i++)
            {
                int firstCard = rand.Next(0, 52);
                int secondCard = rand.Next(0, 52);
                if (firstCard != secondCard)
                {
                    var temp = pictures[firstCard];
                    pictures[firstCard] = pictures[secondCard];
                    pictures[secondCard] = temp;
                }
            }
        }
        private void CreateControlsWhole()
        {
            for (int i = 0; i < 52; i++)
            {
                var newPictureBox = new PictureBox();
                newPictureBox.Width = 75;
                newPictureBox.Height = 100;
                //newPictureBox.BorderStyle = BorderStyle.Fixed3D;
                pictures[i] = SizeImage(newPictureBox, i + 1);
            }
        }
        private void CreateControlsSeven()
        {
            for (int i = 0; i < 7; i++)
            {
                var newPictureBox = new PictureBox();
                newPictureBox.Width = 75;
                newPictureBox.Height = 100;
                //newPictureBox.BorderStyle = BorderStyle.Fixed3D;
                pictures[i] = SizeImage(newPictureBox, i + 1);
            }
        }
        private PictureBox SizeImage(PictureBox pb, int i)
        {
            Image img = Image.FromFile(imagePath + i.ToString() + ".jpg");
            pb.Image = img;
            pb.SizeMode = PictureBoxSizeMode.CenterImage;

            return pb;
        }
        private void DisplayControlsWhole()
        {
            for (int p = 0; p < 52; p++)
            {
                pictures[p].Left = (p * 20) + 80;
                pictures[p].Top = 50;
                this.Controls.Add(pictures[p]);
            }
        }
        private void DisplayControlsSeven()
        {
            for (int p = 0; p < 7; p++)
            {
                pictures[p].Left = (p * 20) + 80;
                pictures[p].Top = 50;
                this.Controls.Add(pictures[p]);
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        //Generates the deck, sorts it out in Value, Suit and color and afterwards prints it to the textbox.
        private void generateDeck_Click(object sender, EventArgs e)
        {
            myDeck = new Deck();
            //deck.FillDeck();
            //deck.PrintDeck();
            myDeck.FillDeck2();
            textWindow.Text = myDeck.PrintDeck2();

            CreateControlsWhole();
            ShuffleCards();
            DisplayControlsWhole();
        }
        //Choose if you want to modify the deck your about to create.
        private void chooseDeck_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        public void missingCard_Click(object sender, EventArgs e)
        {
            //instantiate the DB again.
            CardsToDB cardsToDB = new CardsToDB();
            //Get connection to the DB
            SqlConnection connection = Connection();
            //Uses the "Delete history" from CardsToDB
            cardsToDB.deleteHistory(connection);
            //Displays Message when button is pressed.
            const string message = "The previous cards have been deleted.";
            const string caption = "Form Closing";
            var result = MessageBox.Show(message, caption, MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }

        private void userWindow_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        //Asks for confirmation and terminates the application.
        private void exit_Click(object sender, EventArgs e)
        {
            const string message = "Are you sure you want to close the application?";
            const string caption = "Form Closing";
            var result = MessageBox.Show(message, caption, MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            Close();
        }

        private void textWindow_TextChanged(object sender, EventArgs e)
        {
            textWindow.ScrollBars = ScrollBars.Vertical;
        }

        //Sends the sorted deck into the DB by the press of the database button.
        public void Database_Click(object sender, EventArgs e)
        {
            CardsToDB cardsToDB = new CardsToDB();
            List<Card> cards1 = myDeck.Cards2;
            SqlConnection connection = Connection();
            foreach (Card card in cards1)
            {
                string c = card.Color.ToString();
                string t = card.Suite.ToString();
                string o = card.Value.ToString();
                cardsToDB.InsertCards(o, t, c, connection);
                //s += card.ToString() + newline;
            }
            
            const string message = "The deck have been saved.";
            const string caption = "Form Closing";
            var result = MessageBox.Show(message, caption, MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }

        public void HandDeck_Click(object sender, EventArgs e)
        {
            CardsToDB cardsToDB = new CardsToDB();
            SqlConnection connection = Connection();

            cardsToDB.getCards(connection);

            CreateControlsSeven();
            ShuffleCards();
            DisplayControlsSeven();
            //Console.WriteLine = cardsToDB.getCards(connection);
        }

        private void HandCard_Click(object sender, EventArgs e)
        {
            CardsToDB cardsToDB = new CardsToDB();
            SqlConnection connection = Connection();

            cardsToDB.getCard(connection);
        }

        private void HandHalf_Click(object sender, EventArgs e)
        {
            CardsToDB cardsToDB = new CardsToDB();
            SqlConnection connection = Connection();

            cardsToDB.getHalf(connection);
        }

        private void HandWhole_Click(object sender, EventArgs e)
        {
            CardsToDB cardsToDB = new CardsToDB();
            SqlConnection connection = Connection();

            cardsToDB.getWhole(connection);
        }

        private void Reset_Click(object sender, EventArgs e)
        {
            Console.Clear();
        }
    }
}
