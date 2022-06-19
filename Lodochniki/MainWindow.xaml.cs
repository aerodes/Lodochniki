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

namespace Lodochniki
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnSingIn_Click(object sender, RoutedEventArgs e)
        {
            using (ProbaWSEntities db = new ProbaWSEntities())
            {
                try
                {
                    Auth authDefolt = db.Auth.Where(x => x.id_user == 1).First();
                    Auth auth = db.Auth.Where(x => x.login == txtLogin.Text).DefaultIfEmpty(authDefolt).First();
                    if (txtPass.Text == auth.password)
                    {
                        WindowHome windowHome = new WindowHome();
                        windowHome.Show();
                        ClassRoot.Root = auth.root;
                        Close();
                    }
                    else MessageBox.Show("Неправильный логин или пароль", "Ошибка входа", MessageBoxButton.OK, MessageBoxImage.Error);
                }
                catch
                {
                    MessageBox.Show("Неправильный логин или пароль", "Ошибка входа", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
        }

        private void btnSingUp_Click(object sender, RoutedEventArgs e)
        {
            WindowRegistration windowRegistration = new WindowRegistration();
            windowRegistration.Show();
            Close();
        }

        // Це было написано в первой ветки экзамена!!
    }
}
