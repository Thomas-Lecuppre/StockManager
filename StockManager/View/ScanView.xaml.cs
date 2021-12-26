using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using StockManager.ViewModel;

namespace StockManager.View
{
    /// <summary>
    /// Logique d'interaction pour ScanView.xaml
    /// </summary>
    public partial class ScanView : Page
    {
        ScanViewModel scanViewModel;
         
        public ScanView()
        {
            InitializeComponent();
            scanViewModel = new ScanViewModel();
        }

        private void Barecode_TextChanged(object sender, TextChangedEventArgs e)
        {
            scanViewModel.CurrentScan = Barecode.Text;
            if (scanViewModel.CurrentScan.EndsWith("\t"))
            {
                scanViewModel.CurrentScan = scanViewModel.CurrentScan.Remove(Barecode.Text.Length - 2);
                long code;
                if (long.TryParse(scanViewModel.CurrentScan, out code))
                {
                    scanViewModel.CurrentSelection += $"\n Code barre saisi : {code}";
                }
                else
                {
                    scanViewModel.CurrentSelection += $"\n Il semblerait que \"{Barecode.Text}\" ne soit pas un code barre !";
                }
                scanViewModel.CurrentScan = "";
            }
        }
    }
}
