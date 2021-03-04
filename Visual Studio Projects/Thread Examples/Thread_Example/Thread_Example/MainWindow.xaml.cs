using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Thread_Example
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        BackgroundWorker worker = new BackgroundWorker();
        public MainWindow()
        {
            InitializeComponent();
            worker.DoWork += loadh2;
            worker.RunWorkerAsync();
        }
        public void loadh2(object sender, DoWorkEventArgs args)
        {
            while(true)
            {
            Dispatcher.Invoke(() => 
            textbox.Text = System.IO.File.ReadAllText(@"D:\GitHub\Mads-Verner-Klausen---Rep\Visual Studio Projects\Thread Examples\Thread_Example\Thread_Example\h2thread.txt")
            );
                System.Threading.Thread.Sleep(250);
            }
        }
    }
}
