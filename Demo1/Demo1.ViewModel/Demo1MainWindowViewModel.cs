using Demo1.Common.DTOs;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo1.ViewModel
{
    public class Demo1MainWindowViewModel : ViewModelBase
    {
        public Func<List<PatientViewModel>> LoadPatients { get; set; }
        public Func<string, List<PatientViewModel>> SearchForPatients { get; set; }
        public Func<Guid, List<InsuranceViewModel>> LoadInsurances { get; set; }
        public Func<Guid, PatientDetailsViewModel> LoadPatientDetails { get; set; }

        public List<PatientViewModel> PatientList { get; set; }

        public RelayCommand LoadPatientsCommand { get; set; }
        public RelayCommand ShowInsuranceCommand { get; set; }

        public ViewModelBase MultiContent { get; set; }

        public Action SearchStringChanged { get; set; }

        private string _searchString;
        public string SearchString
        {
            get
            {
                return _searchString;
            }
            set
            {
                _searchString = value;
                SearchStringChanged?.Invoke();
            }
        }

        public Demo1MainWindowViewModel()
        {
            LoadPatientsCommand = new RelayCommand(OnLoadPatientsCommand);
            ShowInsuranceCommand = new RelayCommand(OnShowInsuranceCommand);

            SearchStringChanged = OnSearchStringChanged;
        }

        private void OnSearchStringChanged()
        {
            PatientList = SearchForPatients(_searchString);
            RaisePropertyChanged("PatientList");
        }

        private void OnShowInsuranceCommand()
        {
        }

        private void OnLoadPatientsCommand()
        {
            PatientList = LoadPatients();
            RaisePropertyChanged("PatientList");
        }
    }
}
