using Microsoft.Practices.Unity;
using Prism.Unity;
using ImageReplacer.Views;
using System.Windows;
using Prism.Modularity;

namespace ImageReplacer
{
    using System;

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
            this.AddModuleTypeToCatalog(typeof(ImageFileSelection.Module), catalog);
            this.AddModuleTypeToCatalog(typeof(ReplacementImage.Module), catalog);
            this.AddModuleTypeToCatalog(typeof(TitleBar.Module), catalog);
            return catalog;
        }

        private void AddModuleTypeToCatalog(Type moduleType, IModuleCatalog catalog)
        {
            catalog.AddModule(new ModuleInfo(moduleType.AssemblyQualifiedName, moduleType.AssemblyQualifiedName));
        }
    }
}
