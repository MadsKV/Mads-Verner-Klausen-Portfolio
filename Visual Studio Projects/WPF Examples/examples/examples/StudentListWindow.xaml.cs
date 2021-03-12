using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace examples
{
    /// <summary>
    /// Interaction logic for StudentListWindow.xaml
    /// </summary>
    
    public partial class StudentListWindow : Window
    {
        BackgroundWorker w = new BackgroundWorker();
        public StudentListWindow(MainWindow window)
        {
            InitializeComponent();

            w.DoWork += StudentList;
            w.RunWorkerAsync();

            
        }
        public void StudentList(object sender, DoWorkEventArgs args)
        {
            List<Student> students = Database.FillGrid();
            Dispatcher.Invoke(() =>
            StudentsGrid.ItemsSource = students
            );
            System.Threading.Thread.Sleep(200);

        }
    }
}
