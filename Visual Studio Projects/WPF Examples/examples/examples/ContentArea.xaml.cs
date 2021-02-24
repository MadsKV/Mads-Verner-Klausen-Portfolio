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
    /// Interaction logic for ContentArea.xaml
    /// </summary>
    public partial class ContentArea : UserControl
    {
        object previous;
        public ContentArea()
        {
            InitializeComponent();
        }
        public void Navigate(UserControl control)
        {
            previous = Content;
            Content = control;
            
        }
        public void Back()
        {
            Content = previous;

        }
    }
}
