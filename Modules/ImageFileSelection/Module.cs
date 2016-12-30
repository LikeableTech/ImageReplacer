using Microsoft.Practices.Unity;
using Prism.Modularity;
using Prism.Regions;
using System;

namespace ImageFileSelection
{
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

        public void Initialize()
        {
            //throw new NotImplementedException();
        }
    }
}