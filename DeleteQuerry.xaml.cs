using System;
using System.Linq;
using System.Windows;
namespace kapustinRPMBD18
{
    public partial class DeleteQuerry : Window
    {
        public DeleteQuerry()
        {
            InitializeComponent();
        }
        Entity dataBase = Entity.GetContext();
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (int.TryParse(workshopNum.Text, out int workshopCount))
            {
                var query = from mpaTable in dataBase.MasterPieceAccountings where mpaTable.WorkersCount == workshopCount select mpaTable.WorkersCount;
                foreach (MasterPieceAccounting mpa in dataBase.MasterPieceAccountings)
                    if (query.Contains(mpa.WorkersCount))
                        dataBase.MasterPieceAccountings.Remove(mpa);                
                try
                {
                    dataBase.SaveChanges();
                }
                catch (Exception)
                {
                    MessageBox.Show("Чот не удалось сохранить, проверьте вводимые данные", "Йошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
            else
                MessageBox.Show("Нужно ввести чётное число", "Йошибка", MessageBoxButton.OK, MessageBoxImage.Error);
        }
    }
}
