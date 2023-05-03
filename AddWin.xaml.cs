using System.Windows;
namespace kapustinRPMBD18
{  
    public partial class AddWin : Window
    {
        public AddWin()
        {
            InitializeComponent();
        }        
        Entity _dataBase = Entity.GetContext();        
        MasterPieceAccounting _object = new MasterPieceAccounting();
        private void AddRecordBTN_Click(object sender, RoutedEventArgs e)
        {
            string errorMessage = "Проверьте корректность ввода следующих данных:\n";
            if (string.IsNullOrEmpty(FirstNameTB.Text))
                errorMessage += "+ Имя\n";
            if (string.IsNullOrEmpty(SecondNameTB.Text))
                errorMessage += "+ Фамилия\n";
            if (string.IsNullOrEmpty(ThirdNameTB.Text))
                errorMessage += "+ Отчество\n";
            if (string.IsNullOrEmpty(WorkshopNameTB.Text))
                errorMessage += "+ Название цеха\n";
            if (string.IsNullOrEmpty(WorkshopBossNameTB.Text))
                errorMessage += "+ Имя начальника цеха\n";
            if (!int.TryParse(WorkersCountTB.Text, out int workersCount))
                errorMessage += "+ Кол-во рабочих в цеху\n";
            if (!int.TryParse(AcountTB.Text, out int aCount))
                errorMessage += "+ А кол-во\n";
            if (!int.TryParse(BcountTB.Text, out int bCount))
                errorMessage += "+ В кол-во\n";
            if (!int.TryParse(CcountTB.Text, out int cCount))
                errorMessage += "+ С кол-во\n";
            _object.FirstName = FirstNameTB.Text;
            _object.SecondName = SecondNameTB.Text;
            _object.ThirdName = ThirdNameTB.Text;
            _object.WorkshopName = WorkshopNameTB.Text;
            _object.WorkshopBossName = WorkshopBossNameTB.Text;
            _object.WorkersCount = workersCount;
            _object.ACount = aCount;
            _object.BCount = bCount;
            _object.CCount = cCount;
            _dataBase.MasterPieceAccountings.Add(_object);
            MessageBox.Show("Информация успешно сохранена.", "Добавление прошло успешно!");
            _dataBase.SaveChanges();
            Close();
        }
        private void CancelTB_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
