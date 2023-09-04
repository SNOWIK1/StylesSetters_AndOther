using System;
using System.Collections.Generic;
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
using System.Windows.Shapes;

namespace StylesAsResources
{
    /// <summary>
    /// Логика взаимодействия для Task2.xaml
    /// </summary>
    public partial class Task2 : Page
    {
        private Style senderStyle = null;
        public Task2()
        {
            InitializeComponent();
        }

        private void GotTextBoxFocus(object sender, RoutedEventArgs e)
        {
            senderStyle = (sender as FrameworkElement).Style;

            if (senderStyle == (Style)Resources["txt_box_main"])
            {
                (sender as FrameworkElement).Style = (Style)Resources["txt_box_active"];

            } else if (senderStyle == (Style)Resources["txt_box_extra"])
            {
                (sender as FrameworkElement).Style = (Style)Resources["txt_bigbox_active"];
            }
        }

        private void LostTextBoxFocus(object sender, RoutedEventArgs e)
        {
            // (sender as FrameworkElement).Style = (Style)Resources["txt_box_main"];
            senderStyle = (sender as FrameworkElement).Style;

            if (senderStyle == (Style)Resources["txt_box_active"])
            {
                (sender as FrameworkElement).Style = (Style)Resources["txt_box_main"];

            }
            else if (senderStyle == (Style)Resources["txt_bigbox_active"])
            {
                (sender as FrameworkElement).Style = (Style)Resources["txt_box_extra"];
            }
        }
    }
}
