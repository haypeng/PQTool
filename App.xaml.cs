using PQToolBoxCore.Common;
using PQToolBoxCore.Views;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Windows;

namespace PQToolBoxCore
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : PrismApplication
    {
        private IUnityContainer _container;
        public static new IUnityContainer Container => (App.Current as App)._container;
        protected override Window CreateShell()
        {
            return Container.Resolve<Main>();

        }

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            var iRegionManager = containerRegistry.GetContainer().Resolve<IRegionManager>();
            if (iRegionManager == null)
                return;
            iRegionManager.RegisterViewWithRegion(RegionName.MenuRegion, typeof(Menu));
            iRegionManager.RegisterViewWithRegion(RegionName.MainRegion, typeof(Tools));
            var iDialogService = containerRegistry.GetContainer().Resolve<IDialogService>();
            if (iDialogService == null)
                return;
            containerRegistry.RegisterDialog<ToolInfoWindow>();
            _container = containerRegistry.GetContainer();

            Workbench.Instance.Init();
        }


    }

}
