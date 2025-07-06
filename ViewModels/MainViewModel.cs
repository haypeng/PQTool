using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using PQToolBoxCore.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PQToolBoxCore.ViewModels
{
    public partial class MainViewModel : ObservableObject
    {
        private IRegionManager iRegionManager;
        private IEventAggregator iEventAggregator;
        public MainViewModel()
        {

        }
        public MainViewModel(IRegionManager iRegionManager, IEventAggregator iEventAggregator)
        {
            this.iRegionManager = iRegionManager;
            this.iEventAggregator = iEventAggregator;
        }
        [RelayCommand]
        private void WinClosing()
        {
            Workbench.Instance.SaveToolInfo();
        }

    }
}
