using System;
using System.Data.SqlClient;
using System.Windows;


namespace WPF_intro
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

        }
        
        private void loginBtn_Click(object sender, RoutedEventArgs e)
        {
            SqlConnectionStringBuilder builder =
            new SqlConnectionStringBuilder();

            //Finds and Uses the correct Database
            builder.DataSource = @"DESKTOP-CHHJASV\MSQLSERVERDEV";
            //builder.DataSource = @"DESKTOP-CHHJASV\SQLEXPRESS";
            builder.InitialCatalog = "WPF_Intro";
            SqlConnection connection = new SqlConnection(builder.ConnectionString);
            connection.Open();
            try
            {
                if (connection.State == System.Data.ConnectionState.Closed)
                    connection.Open();
                string query = "SELECT COUNT(1) FROM Users WHERE Username=@Username AND Password=@Password";
                SqlCommand sqlCmd = new SqlCommand(query, connection);
                sqlCmd.CommandType = System.Data.CommandType.Text;
                sqlCmd.Parameters.AddWithValue("@Username", txtUsername.Text);
                sqlCmd.Parameters.AddWithValue("@Password", txtPassword.Password);
                int count = Convert.ToInt32(sqlCmd.ExecuteScalar());
                if (count == 1)
                {
                    LoginScreen dashboard = new LoginScreen();
                    dashboard.Show();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Username or Password is incorrect.");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }
        private void newUserBtn_Click(object sender, RoutedEventArgs e)
        {
            SqlConnectionStringBuilder builder =
            new SqlConnectionStringBuilder();

            //Finds and Uses the correct Database
            builder.DataSource = @"DESKTOP-CHHJASV\MSQLSERVERDEV";
            //builder.DataSource = @"DESKTOP-CHHJASV\SQLEXPRESS";
            builder.InitialCatalog = "WPF_Intro";
            builder.IntegratedSecurity = true;
            SqlConnection connection = new SqlConnection(builder.ConnectionString);
            connection.Open();

            try
            {
                if (connection.State == System.Data.ConnectionState.Closed)
                    connection.Open();
                string query = @"INSERT INTO Users (Username, Password)
                VALUES('{0}', '{1}')";
                SqlCommand sqlCmd = new SqlCommand(query, connection);
                sqlCmd.CommandType = System.Data.CommandType.Text;
                sqlCmd.Parameters.AddWithValue("@Username", txtUsername.Text);
                sqlCmd.Parameters.AddWithValue("@Password", txtPassword.Password);
                int count = Convert.ToInt32(sqlCmd.ExecuteScalar());

                newUser createUser = new newUser();
                createUser.Show();
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                connection.Close();
            }
            /*
            newUser createUser = new newUser();
            createUser.Show();
            this.Close();
            */
        }
    }
}