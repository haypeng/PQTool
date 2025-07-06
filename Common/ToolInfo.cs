using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using HandyControl.Controls;
using PQToolBoxCore.Views;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PQToolBoxCore.Common
{
    public partial class ToolInfo : ObservableObject
    {
        [ObservableProperty]
        private int _id;
        [ObservableProperty]
        private string _name;
        [ObservableProperty]
        private string _description;
        [ObservableProperty]
        private string _url;
        [ObservableProperty]
        private string _image;

        private IEventAggregator iEventAggregator => App.Container.Resolve<IEventAggregator>();
        private IDialogService iDiaolgService => App.Container.Resolve<IDialogService>();
        [RelayCommand]
        private void AddTool()
        {
            this.iEventAggregator.GetEvent<AddToolEvent>().Publish();
        }
        [RelayCommand]
        private void ShowInfo()
        {
            this.iDiaolgService.ShowDialog(nameof(ToolInfoWindow), new
                 DialogParameters() { { "toolInfo", this } });
        }
        [RelayCommand]
        private void GoTo()
        {
            if (string.IsNullOrWhiteSpace(this.Url))
            {
                Growl.Error("当前工具没有提供官网地址！");
                return;
            }
            //使用默认浏览器打开
            using Process process = new()
            {
                StartInfo = new()
                {
                    FileName = this.Url,
                    UseShellExecute = true
                }
            };
            process.Start();
        }


    }

    public enum ToolType
    {
        Hot,
        Practical,
        Media,
        AI,
        To,
        Essential,
        Treasure,
        Study,
        Resource,
        Browser,
        Search,
        Life,
        Program,
        Blog,
        Entertainment


    }
}
