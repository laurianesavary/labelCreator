namespace LabelCreator
{
    using System;
    using System.Collections.Generic;
    using System.Windows;
    using Caliburn.Micro;
    using LabelCreator.ViewModels;
    using ViewModels.Contracts;

    /// <summary>
    ///     This bootstrapper configures Caliburn Library.
    /// </summary>
    public class CaliburnBootstrapper : BootstrapperBase
    {
        #region Fields

        private SimpleContainer container;

        #endregion Fields

        #region Constructors and Destructors

        /// <summary>
        ///     Initializes a new instance of the <see cref="CaliburnBootstrapper" /> class.
        /// </summary>
        public CaliburnBootstrapper()
        {
            this.Initialize();
        }

        #endregion Constructors and Destructors

        #region Methods

        /// <summary>
        ///     Override this to provide an IoC specific implementation.
        /// </summary>
        /// <param name="instance">
        ///     The instance to perform injection on.
        /// </param>
        protected override void BuildUp(object instance)
        {
            this.container.BuildUp(instance);
        }

        /// <summary>
        ///     Override to configure the framework and setup your IoC container.
        /// </summary>
        protected override void Configure()
        {
            base.Configure();

            this.container = new SimpleContainer();
            this.container.Singleton<IWindowManager, WindowManager>();
            this.container.Singleton<IEventAggregator, EventAggregator>();

            this.container.PerRequest<ISettingsFlyoutViewModel, SettingsFlyoutViewModel>();
            this.container.PerRequest<IShellViewModel, ShellViewModel>();
        }

        /// <summary>
        ///     Override this to provide an IoC specific implementation
        /// </summary>
        /// <param name="service">
        ///     The service to locate.
        /// </param>
        /// <returns>
        ///     The located services.
        /// </returns>
        protected override IEnumerable<object> GetAllInstances(Type service)
        {
            return this.container.GetAllInstances(service);
        }

        /// <summary>
        ///     Override this to provide an IoC specific implementation.
        /// </summary>
        /// <param name="service">
        ///     The service to locate.
        /// </param>
        /// <param name="key">
        ///     The key to locate.
        /// </param>
        /// <returns>
        ///     The located service.
        /// </returns>
        protected override object GetInstance(Type service, string key)
        {
            var instance = this.container.GetInstance(service, key);
            if (instance != null)
            {
                return instance;
            }

            throw new InvalidOperationException("Could not locate any instances.");
        }

        /// <summary>
        ///     Override this to add custom behavior to execute after the application starts.
        /// </summary>
        /// <param name="sender">
        ///     The sender.
        /// </param>
        /// <param name="e">
        ///     The args.
        /// </param>
        protected override void OnStartup(object sender, StartupEventArgs e)
        {
            this.DisplayRootViewFor<IShellViewModel>();
        }

        #endregion Methods
    }
}
