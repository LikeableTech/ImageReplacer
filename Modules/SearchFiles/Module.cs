using Microsoft.Practices.Unity;
using Prism.Modularity;
using Prism.Regions;
using System;

namespace SearchForImageFiles
{
    public class Module : IModule
    {
        private IRegionManager _regionManager;
        private IUnityContainer _container;

        public Module(IRegionManager regionManager, IUnityContainer container)
        {
            _regionManager = regionManager;
            _container = container;
        }

        public void Initialize()
        {
            throw new NotImplementedException();
        }
    }
}