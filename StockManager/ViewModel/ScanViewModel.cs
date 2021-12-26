using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StockManager.Model;

namespace StockManager.ViewModel
{
    public class ScanViewModel : BaseViewModel
    {
        ScanModel scanModel;

        public ScanViewModel()
        {
            scanModel = new ScanModel();
        }

        // Text de la zone de texte qui vient d'être renvoyé par la douchette.
        private string currentScan;
        public string CurrentScan
        {
            get
            {
                return currentScan;
            }
            set
            {
                currentScan = value;
                OnPropertyChanged("CurrentScan");
            }
        }

        // Liste de la saisie de la douchette.
        private string currentSelection;
        public string CurrentSelection
        {
            get { return currentSelection; }
            set
            {
                currentSelection = value;
                OnPropertyChanged("CurrentSelection");
            }
        }
    }
}
