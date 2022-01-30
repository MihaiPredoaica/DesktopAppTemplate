using EmployeeManager.Common.DataProvider;
using EmployeeManager.Common.Model;
using EmployeeManager.ViewModel.Command;
using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace EmployeeManager.ViewModel
{
    public class EmployeeViewModel : ViewModelBase
    {
        private readonly Employee _employee;
        private readonly IEmployeeDataProvider _employeeDataProvider;

        public DelegateCommand SaveCommand { get; }

        public EmployeeViewModel(Employee employee, IEmployeeDataProvider employeeDataProvider)
        {
            _employee = employee;
            _employeeDataProvider = employeeDataProvider;
            SaveCommand = new DelegateCommand(Save, () => CanSave);
        }

        public string FirstName
        {
            get { return _employee.FirstName; }
            set 
            {
                if(_employee.FirstName != value)
                {
                    _employee.FirstName = value;
                    RaisePropertyChangedEvent();
                    RaisePropertyChangedEvent(nameof(CanSave));
                    SaveCommand.RaiseCanExecuteChanged();
                }
            }
        }

        public DateTimeOffset EntryDate
        {
            get { return _employee.EntryDate; }
            set
            {
                if (_employee.EntryDate != value)
                {
                    _employee.EntryDate = value;
                    RaisePropertyChangedEvent();
                }
            }
        }

        public DateTime EntryDateTime
        {
            get { return _employee.EntryDate.DateTime; }
            set
            {
                if (_employee.EntryDate != value)
                {
                    _employee.EntryDate = value;
                    RaisePropertyChangedEvent();
                }
            }
        }

        public int JobRole
        {
            get { return _employee.JobRoleId; }
            set
            {
                if (_employee.JobRoleId != value)
                {
                    _employee.JobRoleId = value;
                    RaisePropertyChangedEvent();
                }
            }
        }

        public bool IsCoffeeDrinker
        {
            get { return _employee.IsCoffeeDrinker; }
            set
            {
                if (_employee.IsCoffeeDrinker != value)
                {
                    _employee.IsCoffeeDrinker = value;
                    RaisePropertyChangedEvent();
                }
            }
        }

        public bool CanSave => !string.IsNullOrEmpty(FirstName);

        public void Save()
        {
            _employeeDataProvider.SaveEmployee(_employee);
        }
    }
}
