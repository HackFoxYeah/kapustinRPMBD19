using kapustinRPMBD18;
using System.Data.Entity;
using System.Windows;
namespace kapustin19RPM
{
    public partial class verification : Window
    {
        public verification()
        {
            InitializeComponent();
        }
        Entity _dataBase = Entity.GetContext();
        private void signInBTN_Click(object sender, RoutedEventArgs e)
        {
            _dataBase.Users.Load();
            try
            {
                if (_dataBase.Users.Find(nameTB.Text).Password == passwordTB.Text)
                {
                    MessageBox.Show("Вход прошёл успешно!", "Добро пожаловать");
                    DBSupClass._winIsClosed = false;
                    Close();
                }
                else
                    MessageBox.Show("Неправильно введён пароль", "Проверьте ввод");
            }
            catch (System.Exception)
            {
                MessageBox.Show("Не существует пользователя с таким логином", "Проверьте ввод");
            }
        }
        private void signUpBTN_Click(object sender, RoutedEventArgs e)
        {
            _dataBase.Users.Load();
            try
            {
                if (_dataBase.Users.Find(nameTB.Text).Password == passwordTB.Text)
                {
                    MessageBox.Show($"Пользователь с подобными данными уже существует,\nвы вошли в систему как {_dataBase.Users.Find(nameTB.Text).Login}", "Добро пожаловать");
                    DBSupClass._winIsClosed = false;
                    Close();
                }
                else
                    MessageBox.Show("Пользователь с таким логином уже существует", "!!!");
            }
            catch (System.Exception)
            {
                if (!string.IsNullOrEmpty(nameTB.Text) && !string.IsNullOrEmpty(passwordTB.Text))
                {
                    User obj = new User();
                    obj.Login = nameTB.Text;
                    obj.Password = passwordTB.Text;
                    _dataBase.Users.Add(obj);
                    MessageBox.Show("Информация успешно сохранена.", "Добавление прошло успешно!");
                    _dataBase.SaveChanges();
                    DBSupClass._winIsClosed = false;
                }
            }
        }
        private void singInLikeGuestBTN_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Вход госетм прошёл успешно!", "Добро пожаловать");
            DBSupClass._winIsClosed = false;
            DBSupClass._isGuest = true;
            Close();
        }
    }
}
