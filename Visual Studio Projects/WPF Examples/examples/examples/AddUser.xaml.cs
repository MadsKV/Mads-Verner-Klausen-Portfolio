using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace examples
{
    /// <summary>
    /// Interaction logic for AddUser.xaml
    /// </summary>
    public partial class AddUser : UserControl
    {
        public static Student studentBuffer { get; set; } = new Student();
        ContentArea contentArea;
        public AddUser(ContentArea contentArea)
        {
            InitializeComponent();
            this.contentArea = contentArea;
            DataContext = studentBuffer;

            Dictionary<int, string> classID = Database.Fill_ClassID();
            selectClass.ItemsSource = classID;
        }
        
        private void createUser_Click(object sender, RoutedEventArgs e)
        {
            Database.InsertNewStudent(studentBuffer);
            MessageBox.Show("Student Created!");
        }

        private void back_Click(object sender, RoutedEventArgs e)
        {
            contentArea.Back();
        }

        private void createClass_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
