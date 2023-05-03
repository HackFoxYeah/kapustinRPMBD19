using System.Windows;
namespace kapustinRPMBD18
{    
    public partial class ShowWin : Window
    {
        public ShowWin()
        {
            InitializeComponent();
        }
        Entity _dataBase = Entity.GetContext();
        MasterPieceAccounting _object = new MasterPieceAccounting();
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            _object = _dataBase.MasterPieceAccountings.Find(DBSupClass._firstName, DBSupClass._secondName, DBSupClass._thirdName);
            FirstNameTB.Text = _object.FirstName.ToString();
            SecondNameTB.Text = _object.SecondName.ToString();
            ThirdNameTB.Text = _object.ThirdName.ToString();
            WorkshopNameTB.Text = _object.WorkshopName.ToString();
            WorkshopBossNameTB.Text = _object.WorkshopBossName.ToString();
            WorkersCountTB.Text = _object.WorkersCount.ToString();
            AcountTB.Text = _object.ACount.ToString();
            BcountTB.Text = _object.BCount.ToString();
            CcountTB.Text = _object.CCount.ToString();
        }
        private void CancelTB_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
