using Microsoft.Practices.Unity;
using Prism.Modularity;
using Prism.Regions;
using System;

namespace ImageFileSelection
{
    using ImageFileSelection.ViewModels;
    using ImageFileSelection.Views;

    using ImageReplacer.Infrastructure;

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
            _container.RegisterType<ISelectionContentView, SelectionContent>();
            _container.RegisterType<ISelectionToolbarView, SelectionToolbar>();
            _container.RegisterType<ISelectionPropertiesView, SelectionProperties>();

            _container.RegisterType<ISelectionContentViewModel, SelectionContentViewModel>();
            _container.RegisterType<ISelectionToolbarViewModel, SelectionToolbarViewModel>();
            _container.RegisterType<ISelectionPropertiesViewModel, SelectionPropertiesViewModel>();

            _regionManager.RegisterViewWithRegion(RegionNames.ContentRegion, () => _container.Resolve<ISelectionContentView>());
            _regionManager.RegisterViewWithRegion(RegionNames.ToolbarRegion, () => _container.Resolve<ISelectionToolbarView>());
            _regionManager.RegisterViewWithRegion(RegionNames.PropertiesRegion, () => _container.Resolve<ISelectionPropertiesView>());

            var region = _regionManager.Regions[RegionNames.ToolbarRegion];
        }
    }
}