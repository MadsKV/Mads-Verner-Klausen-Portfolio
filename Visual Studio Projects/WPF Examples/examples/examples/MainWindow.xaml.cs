using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Windows;

namespace examples
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        
        public MainWindow()
        {
            InitializeComponent();
            
            contentArea.Navigate(new DatabaseLogin(this));
        }
        public void Login()
        {
            contentArea.Navigate(new AddUser(contentArea));
            //contentArea.Navigate(new DatabaseLogin());
        }
        private void loginBtn_Click(object sender, RoutedEventArgs e)
        {
            
        }
        public ContentArea ContentArea()
        {
            return contentArea;
        }
    }
}
