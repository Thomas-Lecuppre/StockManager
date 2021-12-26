using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StockManager.Model;
using StockManager.Dialogs.Service;

namespace StockManager.ViewModel
{
    internal class WindowViewModel : BaseViewModel
    {
        private IDialogService _dialogService;

        MainWindowModel mainWindowModel;
        public WindowViewModel()
        {
            _dialogService = new DialogService();

            mainWindowModel = new MainWindowModel();
            WindowTitle = mainWindowModel.GetAppTitle();
        }

        private string windowTitle;
        public string WindowTitle
        {
            get
            {
                return windowTitle;
            }
            set
            {
                windowTitle = value;
                OnPropertyChanged("WindowTitle");
            }
        }
    }
}
