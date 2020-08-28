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

namespace WpfApp1
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        MIAPOEntities db = new MIAPOEntities();

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Login_Click(object sender, RoutedEventArgs e)
        {
            var user = db.Users.AsNoTracking().FirstOrDefault(u => u.Login == LoginB.Text && u.Password == PasswordB.Password);
            if (user == null) MessageBox.Show("Пользователь с таким именем не найден!");
            else 

        


                }

        private void Reg_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
