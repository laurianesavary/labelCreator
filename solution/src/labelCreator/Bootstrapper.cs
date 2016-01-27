namespace labelCreator
{
    using Microsoft.Practices.Prism.UnityExtensions;
    using Microsoft.Practices.ServiceLocation;

    using System.Windows;

    public class Bootstrapper : UnityBootstrapper
    {    
        /// <summary>
        ///     Creates the shell or main window of the application.
        /// </summary>
        /// <returns>
        ///     The shell of the application.
        /// </returns>
        /// <remarks>
        ///     If the returned instance is a System.Windows.DependencyObject, the Microsoft.Practices.Prism.Bootstrapper
        ///     will attach the default Microsoft.Practices.Prism.Regions.IRegionManager of the
        ///     application in its Microsoft.Practices.Prism.Regions.RegionManager.RegionManagerProperty
        ///     attached property in order to be able to add regions by using the Microsoft.Practices.Prism.Regions.RegionManager.RegionNameProperty
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
            Application.Current.MainWindow = (Window)this.Shell;
            Application.Current.MainWindow.Show();
        }
    }
}
