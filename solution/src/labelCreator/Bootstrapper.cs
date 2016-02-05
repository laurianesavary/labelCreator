namespace LabelCreator
{
    using System.Windows;
    using Microsoft.Practices.ServiceLocation;
    using Microsoft.Practices.Unity;
    using Views;
    using ViewModels.Contracts;
    using ViewModels;
    using Microsoft.Practices.Prism.Regions;
    using Microsoft.Practices.Prism.UnityExtensions;

    public class Bootstrapper : UnityBootstrapper
    {
        /// <summary>
        ///     Creates the shell or main window of the application.
        /// </summary>
        /// <returns>
        ///     The shell of the application.
        /// </returns>
        /// <remarks>
        ///     If the returned instance is a System.Windows.DependencyObject, the Prism.Bootstrapper
        ///     will attach the default Prism.Regions.IRegionManager of the application in its
        ///     Prism.Regions.RegionManager.RegionManagerProperty attached property in order
        ///     to be able to add regions by using the Prism.Regions.RegionManager.RegionNameProperty
        ///     attached property from XAML.
        /// </remarks>
        protected override DependencyObject CreateShell()
        {
            return ServiceLocator.Current.GetInstance<ShellView>();
        }

        /// <summary>
        ///     Initializes the shell.
        /// </summary>
        protected override void InitializeShell()
        {
            Application.Current.MainWindow = (Window)Shell;
            Application.Current.MainWindow.Show();
        }

        /// <summary>
        ///     Configures the Microsoft.Practices.Unity.IUnityContainer. May be overwritten
        ///     in a derived class to add specific type mappings required by the application.
        /// </summary>
        protected override void ConfigureContainer()
        {
            base.ConfigureContainer();
            
            this.Container.RegisterType<IRegionManager, RegionManager>();
            this.Container.RegisterType<IRegionViewRegistry, RegionViewRegistry>();

            this.Container.RegisterType<ISettingsFlyoutViewModel, SettingsFlyoutViewModel>();
            this.Container.RegisterType<IShellViewModel, ShellViewModel>();
        }
    }
}
