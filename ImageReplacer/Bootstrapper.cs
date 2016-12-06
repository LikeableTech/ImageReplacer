using Microsoft.Practices.Unity;
using Prism.Unity;
using ImageReplacer.Views;
using System.Windows;
using Prism.Modularity;

namespace ImageReplacer
{
    class Bootstrapper : UnityBootstrapper
    {
        protected override DependencyObject CreateShell()
        {
            return Container.Resolve<MainWindow>();
        }

        protected override void InitializeShell()
        {
            base.InitializeShell();

            Application.Current.MainWindow = (Window) Shell;
            Application.Current.MainWindow.Show();
        }
        protected override IModuleCatalog CreateModuleCatalog()
        {
            var catalog = new ModuleCatalog();
            catalog.AddModule(typeof(SearchForImageFiles.Module));
            catalog.AddModule(typeof(ConfigureReplacementImage.Module));
            return catalog;
        }
    }
}
