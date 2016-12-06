using Microsoft.Practices.Unity;
using Prism.Unity;
using ImageReplacer.Views;
using System.Windows;

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
            Application.Current.MainWindow.Show();
        }
    }
}
