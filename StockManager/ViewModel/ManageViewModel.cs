using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StockManager.Model;
using StockManager.Commands;
using System.Windows.Input;
using System.Collections.ObjectModel;
using StockManager.Dialogs.Service;
using StockManager.Dialogs.Project;
using System.Windows;

namespace StockManager.ViewModel
{
    internal class ManageViewModel : BaseViewModel
    {
        private IDialogService _dialogService;

        public ManageModel mwm;

        public ManageViewModel()
        {
            _dialogService = new DialogService();

            NewProjectCommand = new BaseCommand(E_NewProjectCommand, CanE_NewProjectCommand);

            mwm = new ManageModel();
        }

        //Liste des projets
        private ObservableCollection<CompanyProject> projects;
        public ObservableCollection<CompanyProject> Projects
        {
            get { return projects; }
            set 
            { 
                projects = value;
                OnPropertyChanged("Projects");
            }
        }

        #region New Project Command

        private BaseCommand newProjectCommand;

        public BaseCommand NewProjectCommand
        {
            get { return newProjectCommand; }
            set { newProjectCommand = value; }
        }

        private bool CanE_NewProjectCommand(object obj)
        {
            return true;
        }

        private void E_NewProjectCommand(object obj)
        {
            CompanyProjectDialogViewModel viewModel = new CompanyProjectDialogViewModel("Nouveau projet","");
            CompanyProject proj = _dialogService.OpenDialog(viewModel);
            MessageBox.Show("Resultat", $"ID : {proj.Id}\n Name : {proj.Name}\nLocation : {proj.Location}");
        }

        #endregion
    }
}
