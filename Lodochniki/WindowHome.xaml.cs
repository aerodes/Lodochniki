using Lodochniki.AppDataFile;
using Lodochniki.Pages;
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

namespace Lodochniki
{
    /// <summary>
    /// Логика взаимодействия для WindowHome.xaml
    /// </summary>
    public partial class WindowHome : Window
    {
        public WindowHome()
        {
            InitializeComponent();
            FrameObj.frame = frmMain;
            FrameObj.frame.Navigate(new PageNavigate());
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (FrameObj.frame.CanGoForward) FrameObj.frame.GoBack();
        }
    }
}
