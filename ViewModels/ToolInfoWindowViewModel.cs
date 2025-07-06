using CommunityToolkit.Mvvm.ComponentModel;
using PQToolBoxCore.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PQToolBoxCore.ViewModels
{
    public partial class ToolInfoWindowViewModel : ObservableObject, IDialogAware
    {
        private IRegionManager iRegionManager;
        private IEventAggregator iEventAggregator;
        public ToolInfoWindowViewModel()
        {

        }

        public ToolInfoWindowViewModel(IRegionManager iRegionManager, IEventAggregator iEventAggregator) : this()
        {
            this.iRegionManager = iRegionManager;
            this.iEventAggregator = iEventAggregator;

        }

        public DialogCloseListener RequestClose { get; }

        public bool CanCloseDialog()
        {
            return true;
        }

        public void OnDialogClosed()
        {

        }

        public void OnDialogOpened(IDialogParameters parameters)
        {
            this.CurToolInfo = parameters.GetValue<ToolInfo>("toolInfo");
        }
        [ObservableProperty]
        private ToolInfo curToolInfo;
    }
}
