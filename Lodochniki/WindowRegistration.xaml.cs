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
using System.Windows.Shapes;

namespace Lodochniki
{
    /// <summary>
    /// Логика взаимодействия для WindowRegistration.xaml
    /// </summary>
    public partial class WindowRegistration : Window
    {
        public WindowRegistration()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                using (var db = new ProbaWSEntities())
                {
                    var proverka = db.Auth.Where(x => x.login == txtNewLogin.Text).First();
                }
                MessageBox.Show("Пользователь с таким логином уже сушествует!", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            catch
            {
                if (txtNewPass.Text == txtNewAgeinPass.Text & txtNewPass.Text != "" & txtNewAgeinPass.Text != "" & txtNewLogin.Text != "")
                {
                    Auth auth = new Auth()
                    {
                        login = txtNewLogin.Text,
                        password = txtNewPass.Text,
                        root = false
                    };
                    ServiceObj.Add(auth);

                    MainWindow mainWindow = new MainWindow();
                    mainWindow.Show();
                    Close();
                    MessageBox.Show("Регистрация выполнена успешно", "Ошибка входа", MessageBoxButton.OK, MessageBoxImage.Information);
                }
                else MessageBox.Show("Неправильный логин или пароль", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}
