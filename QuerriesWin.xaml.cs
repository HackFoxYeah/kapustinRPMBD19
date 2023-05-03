using System;
using System.Data.Entity;
using System.Linq;
using System.Windows;
namespace kapustinRPMBD18
{
    public partial class QuerriesWin : Window
    {
        public QuerriesWin()
        {
            InitializeComponent();
        }
        Entity dataBase = Entity.GetContext();
        private void monkeyFlip_Click(object sender, RoutedEventArgs e)
        {
            if (int.TryParse(monkeyBox.Text, out int querryNum))
            {
                switch (querryNum)
                {
                    case 1:
                        var firstQuerryResults = from mpaTable in dataBase.MasterPieceAccountings 
                                                 select new { FIO = mpaTable.FirstName + " " + mpaTable.SecondName + " " + mpaTable.ThirdName };
                        DGQBR.ItemsSource = firstQuerryResults.ToList();
                        break;
                    case 2:
                        var secondQuerryResults = from mpaTable in dataBase.MasterPieceAccountings 
                                                  select new { FIO = mpaTable.FirstName + " " + mpaTable.ThirdName, Acount = mpaTable.ACount, Bcount = mpaTable.BCount, Ccount = mpaTable.CCount };
                        DGQBR.ItemsSource = secondQuerryResults.ToList();
                        break;
                    case 3:
                        UpdateQuerry uq = new UpdateQuerry();
                        uq.ShowDialog();
                        dataBase.MasterPieceAccountings.Load();
                        DGQBR.ItemsSource = dataBase.MasterPieceAccountings.Local.ToBindingList();
                        break;
                    case 4:
                        DeleteQuerry dq = new DeleteQuerry();
                        dq.ShowDialog();
                        dataBase.MasterPieceAccountings.Load();
                        DGQBR.ItemsSource = dataBase.MasterPieceAccountings.Local.ToBindingList();
                        break;
                    default:                        
                        MessageBox.Show("Нет такого запроса. Их всего 4", "Ашибка", MessageBoxButton.OK, MessageBoxImage.Error);
                        break;
                }
            }
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("1 - Все ФИО; 2 - ФИО + кол - во деталей; 3 - Изменяет поле; 4 - Удаляет по знач. поля", "Информация");            
        }
    }
}
