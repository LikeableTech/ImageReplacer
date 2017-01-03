namespace ReplacementImage
{
    using Prism.Modularity;
    using Prism.Regions;
    using System;

    /// <summary>
    /// ReplacementImage module that contains the views for configuring the image that will replace the selected source images.
    /// </summary>
    public class Module : IModule
    {
        IRegionManager _regionManager;

        /// <summary>
        /// Initializes a new instance of the <see cref="Module"/> class.
        /// </summary>
        /// <param name="regionManager">
        /// The region manager.
        /// </param>
        public Module(RegionManager regionManager)
        {
            _regionManager = regionManager;
        }

        /// <summary>
        /// Initialize the module
        /// </summary>
        public void Initialize()
        {
            //throw new NotImplementedException();
        }
    }
}