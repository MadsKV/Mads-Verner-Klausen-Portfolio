using System.Windows;
using System.Windows.Controls;

namespace examples
{
    /// <summary>
    /// Interaction logic for DatabaseLogin.xaml
    /// </summary>
    public partial class DatabaseLogin : UserControl
    {
        MainWindow window;
        public string Username { get; set; } = "";
        public DatabaseLogin(MainWindow window)
        {
            InitializeComponent();
            DataContext = this;

            this.window = window;
        }

        private void Login_Click(object sender, RoutedEventArgs e)
        {
            //if (Database.Connect(txtUsername.Text, txtPassword.Password))
            if (Database.Connect(Username, txtPassword.Password))
            {
                window.Login();

            }
            else
            {
                MessageBox.Show("Username or Password is incorrect.");
            }
        }
    }
}
