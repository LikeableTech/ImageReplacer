namespace TitleBar
{
    using Prism.Modularity;
    using Prism.Regions;

    using ImageReplacer.Infrastructure;

    using Microsoft.Practices.Unity;

    using TitleBar.ViewModels;
    using TitleBar.Views;

    public class Module : IModule
    {
        private IRegionManager _regionManager;
        private IUnityContainer _container;

        /// <summary>
        /// Initializes a new instance of the <see cref="Module"/> class.
        /// </summary>
        /// <param name="regionManager">
        /// The region manager.
        /// </param>
        /// <param name="container">
        /// The container.
        /// </param>
        public Module(IRegionManager regionManager, IUnityContainer container)
        {
            _regionManager = regionManager;
            _container = container;
        }

        /// <summary>
        /// The initialize.
        /// </summary>
        public void Initialize()
        {
            _container.RegisterType<ITitleBarView, TitleBarControl>();
            _container.RegisterType<ITitleBarViewModel, TitleBarViewModel>();

            _regionManager.RegisterViewWithRegion(RegionNames.TitleBarRegion, () => _container.Resolve<ITitleBarView>());

            var region = _regionManager.Regions[RegionNames.ToolbarRegion];
        }
    }
}
