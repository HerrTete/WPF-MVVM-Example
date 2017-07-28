using Demo1.Common.Interfaces;
using Demo1.Data;
using Demo1.View;
using Demo1.ViewModel;

namespace Demo1.Starter
{
    public class Integration
    {
        private Demo1MainWindow _mainWindow = null;
        private Demo1MainWindowViewModel _mainWindowViewModel = null;
        private IDataSource _dataSource = null;
            public Integration()
        {
            _mainWindow = new Demo1MainWindow();
            _mainWindowViewModel = new Demo1MainWindowViewModel();
            _dataSource = new DemoDataSource();
        }

        public void Init()
        {
            _mainWindow.DataContext = _mainWindowViewModel;
            _mainWindowViewModel.LoadPatients = ()=>Mapper.Map(_dataSource.GetPatientList());
            _mainWindowViewModel.SearchForPatients = (s) => Mapper.Map(_dataSource.SearchForPatient(s));
        }
        public void Run()
        {
            _mainWindow.ShowDialog();
        }
    }
}
