using Lodochniki.AppDataFile;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Lodochniki.Pages
{
    /// <summary>
    /// Логика взаимодействия для PageNavigate.xaml
    /// </summary>
    public partial class PageNavigate : Page
    {
        public PageNavigate()
        {
            InitializeComponent();
        }

        private void btnCatalog_Click(object sender, RoutedEventArgs e)
        {
            FrameObj.frame.Navigate(new PageCatalog());
        }

        private void btn_Contract_Click(object sender, RoutedEventArgs e)
        {
            FrameObj.frame.Navigate(new PageContract());
        }
    }
}
