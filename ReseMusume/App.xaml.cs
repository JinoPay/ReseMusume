using Prism.Ioc;
using Prism.Modularity;
using ReseMusume.Views;
using System.Windows;
using ReseMusume.Modules.Home;

namespace ReseMusume
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App
    {
        protected override Window CreateShell()
        {
            return Container.Resolve<MainWindow>();
        }

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {

        }
        protected override void ConfigureModuleCatalog(IModuleCatalog moduleCatalog)
        {
            moduleCatalog.AddModule<HomeModule>();

            base.ConfigureModuleCatalog(moduleCatalog);
        }
    }
}
