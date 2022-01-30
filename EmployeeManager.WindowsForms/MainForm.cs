using EmployeeManager.DataAccess;
using EmployeeManager.ViewModel;
using System;
using System.Windows.Forms;

namespace EmployeeManager.WindowsForms
{
    public partial class MainForm : Form
    {

        private readonly MainViewModel _viewModel;
        public MainForm()
        {
            InitializeComponent();
            _viewModel = new MainViewModel(new EmployeeDataProvider());
        }

        

        private void MainForm_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            _viewModel.Load();
            employeeBindingSource.DataSource = _viewModel.Employees;
            lsbEmployees.DataSource = employeeBindingSource;
            lsbEmployees.DisplayMember = "FirstName";

            cmbJobRole.DataSource = _viewModel.JobRoles;
            cmbJobRole.DisplayMember = "RoleName";
            cmbJobRole.ValueMember = "Id";

            var areDataBindingsInitialized = cmbJobRole.DataBindings.Count > 0;
            if(areDataBindingsInitialized)
            {
                employeeBindingSource.ResetBindings(false);
            }
            else
            {
                cmbJobRole.DataBindings.Add("SelectedValue", employeeBindingSource, "JobRole");

                txtFirstName.DataBindings.Add("Text", employeeBindingSource, "FirstName", false, DataSourceUpdateMode.OnPropertyChanged);
                dtpEntryDate.DataBindings.Add("Value", employeeBindingSource, "EntryDateTime");
                chcCoffeeDrinker.DataBindings.Add("Checked", employeeBindingSource, "IsCoffeeDrinker");

                btnSave.DataBindings.Add("Enabled", employeeBindingSource, "CanSave");

            }
            
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if(employeeBindingSource.Current is EmployeeViewModel employeeViewModel && employeeViewModel.CanSave)
            {
                employeeViewModel.Save();
            }
        }
    }
}
