using EmployeeManager.Common.DataProvider;
using EmployeeManager.Common.Model;
using EmployeeManager.ViewModel.Command;
using System.Collections.ObjectModel;

namespace EmployeeManager.ViewModel
{
    public class MainViewModel : ViewModelBase
    {
        public ObservableCollection<EmployeeViewModel> Employees { get; } = new();

        public ObservableCollection<JobRole> JobRoles { get; } = new();

        private EmployeeViewModel _selectedEmployee;
        private readonly IEmployeeDataProvider _employeeDataProvider;

        public DelegateCommand LoadCommand { get; }

        public EmployeeViewModel SelectedEmployee
        {
            get { return _selectedEmployee; }
            set
            {
                if (_selectedEmployee != value)
                {
                    _selectedEmployee = value;
                    RaisePropertyChangedEvent();
                    RaisePropertyChangedEvent(nameof(IsEmployeeSelected));
                }
            }
        }

        public bool IsEmployeeSelected => SelectedEmployee != null;

        public MainViewModel(IEmployeeDataProvider employeeDataProvider)
        {
            _employeeDataProvider = employeeDataProvider;
            LoadCommand = new DelegateCommand(Load, null);
        }

        public void Load()
        {
            var employees = _employeeDataProvider.LoadEmployees();
            var jobRoles = _employeeDataProvider.LoadJobRoles();

            Employees.Clear();
            foreach(var employee in employees)
            {
                Employees.Add(new EmployeeViewModel(employee, _employeeDataProvider));
            }

            JobRoles.Clear();
            foreach (var jobRole in jobRoles)
            {
                JobRoles.Add(jobRole);
            }
        }
    }
}
