﻿using Prism.Modularity;
using Prism.Regions;
using System;

namespace ConfigureReplacementImage
{
    public class Module : IModule
    {
        IRegionManager _regionManager;

        public Module(RegionManager regionManager)
        {
            _regionManager = regionManager;
        }

        public void Initialize()
        {
            throw new NotImplementedException();
        }
    }
}