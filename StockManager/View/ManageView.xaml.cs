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
    /// Logique d'interaction pour ManageView.xaml
    /// </summary>
    public partial class ManageView : Page
    {
        ManageViewModel viewModel;

        public ManageView()
        {
            InitializeComponent();
            viewModel = new ManageViewModel();
            this.DataContext = viewModel;


        }
    }
}
