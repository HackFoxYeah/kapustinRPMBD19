using System;
using System.Linq;
using System.Windows;
namespace kapustinRPMBD18
{
    public partial class UpdateQuerry : Window
    {
        public UpdateQuerry()
        {
            InitializeComponent();
        }
        Entity dataBase = Entity.GetContext();
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (int.TryParse(oldWorkshopNum.Text, out int oldCount) && int.TryParse(newWorkshopNum.Text, out int newCount))
            {
                var query = from mpaTable in dataBase.MasterPieceAccountings 
                            where mpaTable.WorkersCount == oldCount
                            select mpaTable.WorkersCount;
                foreach (MasterPieceAccounting mpa in dataBase.MasterPieceAccountings)
                    if (query.Contains(mpa.WorkersCount))
                        mpa.WorkersCount = newCount;
                try
                {
                    dataBase.SaveChanges();
                }
                catch (Exception)
                {
                    MessageBox.Show("Чот не удалось сохранить, проверьте вводимые данные", "Ашибка", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
            else
                MessageBox.Show("Нужно ввести два числа чётных", "Йошибка", MessageBoxButton.OK, MessageBoxImage.Error);
            Close();
        }
    }
}
