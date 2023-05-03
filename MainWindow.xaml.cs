using kapustin19RPM;
using System.Data.Entity;
using System.Windows;
using System.Windows.Controls;
namespace kapustinRPMBD18
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        Entity _dataBase = Entity.GetContext();
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            verification vWin = new verification();
            vWin.Focus();
            vWin.ShowDialog();
            if(DBSupClass._winIsClosed)
            {
                Close();
            }
            if (DBSupClass._isGuest)
            {
                CreateRec.IsEnabled = false;
                EditRec.IsEnabled = false;
                RemoveRec.IsEnabled = false;
                Querries.IsEnabled = false;
            }
            _dataBase.MasterPieceAccountings.Load();
            DataGrid.ItemsSource = _dataBase.MasterPieceAccountings.Local.ToBindingList();
        }
        private void CreateRec_Click(object sender, RoutedEventArgs e)
        {
            AddWin aWin = new AddWin();
            aWin.ShowDialog();
            DataGrid.Focus();
        }
        private void EditRec_Click(object sender, RoutedEventArgs e)
        {
            int indexRow = DataGrid.SelectedIndex;
            if (indexRow != -1)
            {
                MasterPieceAccounting row = (MasterPieceAccounting)DataGrid.Items[indexRow];
                DBSupClass._firstName = row.FirstName;
                DBSupClass._secondName = row.SecondName;
                DBSupClass._thirdName = row.ThirdName;
                DBSupClass._workshopName = row.WorkshopName;
                DBSupClass._workshopBossName = row.WorkshopBossName;
                DBSupClass._workersCount = row.WorkersCount;
                DBSupClass._aCount = row.ACount;
                DBSupClass._bCount = row.BCount;
                DBSupClass._cCount = row.CCount;
                EditWin erForm = new EditWin();
                erForm.ShowDialog();
                DataGrid.Items.Refresh();
                DataGrid.Focus();
            }
        }
        private void RemoveRec_Click(object sender, RoutedEventArgs e)
        {
            MessageBoxResult result;
            result = MessageBox.Show("Удалить запись?", "Удаление записи", MessageBoxButton.YesNo, MessageBoxImage.Warning);
            if (result == MessageBoxResult.Yes)
            {
                try
                {
                    MasterPieceAccounting row = (MasterPieceAccounting)DataGrid.SelectedItems[0];
                    _dataBase.MasterPieceAccountings.Remove(row);
                    _dataBase.SaveChanges();
                }
                catch (System.Exception)
                {
                    MessageBox.Show("Выберите запись");
                }
            }
        }
        private void Querries_Click(object sender, RoutedEventArgs e)
        {
            var qw = new QuerriesWin();
            qw.ShowDialog();
        }

        private void ViewButton_Click(object sender, RoutedEventArgs e)
        {
            int indexRow = DataGrid.SelectedIndex;
            if (indexRow != -1)
            {
                MasterPieceAccounting row = (MasterPieceAccounting)DataGrid.Items[indexRow];
                DBSupClass._firstName = row.FirstName;
                DBSupClass._secondName = row.SecondName;
                DBSupClass._thirdName = row.ThirdName;
                DBSupClass._workshopName = row.WorkshopName;
                DBSupClass._workshopBossName = row.WorkshopBossName;
                DBSupClass._workersCount = row.WorkersCount;
                DBSupClass._aCount = row.ACount;
                DBSupClass._bCount = row.BCount;
                DBSupClass._cCount = row.CCount;
                ShowWin sw = new ShowWin();
                sw.ShowDialog();
                DataGrid.Items.Refresh();
                DataGrid.Focus();
            }            
        }
    }
}
