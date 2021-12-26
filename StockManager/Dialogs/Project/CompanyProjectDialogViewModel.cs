using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using StockManager.Commands;
using StockManager.Dialogs.Service;
using StockManager.Model;
using StockManager.ViewModel;

namespace StockManager.Dialogs.Project
{
    public class CompanyProjectDialogViewModel : DialogViewModelBase<CompanyProject>
    {
        public ICommand okCommand { get; private set; }
        private CompanyProject _companyProject;

        public CompanyProjectDialogViewModel(string title, string message) : base(title, message)
        {
            _companyProject = new CompanyProject();
            okCommand = new RelayCommand<IDialogWindow>(OKCommand);
        }

        private string projectId;
        public string ProjectId
        {
            get { return projectId; }
            set 
            { 
                projectId = value;
                OnPropertyChanged("ProjectId");
            }
        }

        private string projectName;
        public string ProjectName
        {
            get { return projectName; }
            set 
            { 
                projectName = value;
                OnPropertyChanged("ProjectName");
            }
        }

        private string projectLocation;
        public string ProjectLocation
        {
            get { return projectLocation; }
            set 
            {
                projectLocation = value;
                OnPropertyChanged("ProjectLocation");
            }
        }

        private void OKCommand (IDialogWindow window)
        {
            _companyProject = new CompanyProject()
            {
                Id = ProjectId,
                Name = ProjectName,
                Location = ProjectLocation
            };

            CloseDialogWithResult(window, _companyProject);
                
        }
    }
}
