using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using HandyControl.Controls;
using PQToolBoxCore.Common;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PQToolBoxCore.ViewModels
{
    public partial class ToolsViewModel : ObservableObject
    {
        private IRegionManager? iRegionManager;
        private IEventAggregator? iEventAggregator;
        public ToolsViewModel()
        {
        }
        public ToolsViewModel(IRegionManager iRegionManager, IEventAggregator iEventAggregator) : this()
        {
            this.iRegionManager = iRegionManager;
            this.iEventAggregator = iEventAggregator;

            this.iEventAggregator.GetEvent<AddToolEvent>().Subscribe(AddToolInfo);
            this.iEventAggregator.GetEvent<SelectToolEvent>().Subscribe(SelectToolInfo);
        }
        [RelayCommand]
        private void LoadTools()
        {
            this.ToolInfos.AddRange(Workbench.Instance.GetToolInfosByType(ToolType.Hot));
        }

        [ObservableProperty]
        private ObservableCollection<ToolInfo> _toolInfos = [];

        /// <summary>
        /// 添加工具信息
        /// </summary>
        private void AddToolInfo()
        {

        }

        private void SelectToolInfo(ToolType type)
        {
            this.ToolInfos.Clear();
            try
            {
                this.ToolInfos.AddRange(Workbench.Instance.GetToolInfosByType(type));
            }
            catch (Exception ex)
            {
                Growl.Error(ex.Message);
            }
        }
    }
}
