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
    /// Interaction logic for menu.xaml
    /// </summary>
    public partial class Menu : UserControl
    {
        MainWindow window;
        public Menu(MainWindow window)
        {
            InitializeComponent();

            this.window = window;
        }
        private void studentMenu_Click(object sender, RoutedEventArgs e)
        {
            window.contentArea.Navigate(new AddUser(window.contentArea));
        }

        private void teacherMenu_Click(object sender, RoutedEventArgs e)
        {
            window.contentArea.Navigate(new AddTeacher(window.contentArea));
        }

        private void classmenu_Click(object sender, RoutedEventArgs e)
        {

        }
        private void logout_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void studentMenuList_Click(object sender, RoutedEventArgs e)
        {
            //window.contentArea.Navigate(new StudentList(window.contentArea));
            StudentListWindow win2 = new StudentListWindow(window);
            win2.Show();
        }

        private void teacherMenuList_Click(object sender, RoutedEventArgs e)
        {
            //window.contentArea.Navigate(new TeacherList(window.contentArea));
            TeacherListWindow win2 = new TeacherListWindow();
            win2.Show();
        }

        private void classMenuList_Click(object sender, RoutedEventArgs e)
        {
            //window.contentArea.Navigate(new ClassList(window.contentArea));
            ClassListWindow win2 = new ClassListWindow();
            win2.Show();
        }
    }
}
