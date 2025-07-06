using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using HandyControl.Controls;
using HandyControl.Data;
using PQToolBoxCore.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PQToolBoxCore.ViewModels
{
    public partial class MenuViewModel : ObservableObject
    {
        private IRegionManager iRegionManager;
        private IEventAggregator iEventAggregator;
        public static ToolType CurToolType { get; set; }
        public MenuViewModel()
        {

        }
        public MenuViewModel(IRegionManager iRegionManager, IEventAggregator iEventAggregator)
        {

            this.iRegionManager = iRegionManager;
            this.iEventAggregator = iEventAggregator;
        }
        [RelayCommand]
        private void SelectMenu(FunctionEventArgs<object> e)
        {
            var menuItem = e.Info as PQSideMenuItem;
            if (menuItem == null)
            {
                return;
            }
            var header = menuItem.Header.ToString();
            Growl.Info(header);
            iEventAggregator.GetEvent<SelectToolEvent>().Publish(menuItem.ToolType);

        }

    }
}
