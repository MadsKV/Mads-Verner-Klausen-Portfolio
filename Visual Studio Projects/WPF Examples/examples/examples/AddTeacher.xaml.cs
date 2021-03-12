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
    /// Interaction logic for AddTeacher.xaml
    /// </summary>
    public partial class AddTeacher : UserControl
    {
        public static Teacher teacherBuffer { get; set; } = new Teacher();
        ContentArea contentArea;
        public AddTeacher(ContentArea contentArea)
        {
            InitializeComponent();
            this.contentArea = contentArea;
            DataContext = teacherBuffer;

            Dictionary<int, string> SubjectName = Database.Fill_TeacherDiscipline();
            selectClass.ItemsSource = SubjectName;

            Application.Current.Exit += Exit_Save;
        }

        private void Exit_Save(object sender, ExitEventArgs e)
        {
            Database.InsertNewTeacher(teacherBuffer);
        }

        private void createTeacher_Click(object sender, RoutedEventArgs e)
        {
            Database.InsertNewTeacher(teacherBuffer);
            MessageBox.Show("Teacher Created!","Created", MessageBoxButton.OK, MessageBoxImage.Information);
        }

        private void back_Click(object sender, RoutedEventArgs e)
        {
            contentArea.Back();
        }
    }
}
