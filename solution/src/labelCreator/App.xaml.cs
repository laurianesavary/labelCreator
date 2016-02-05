﻿namespace LabelCreator
{
    using System.Windows;

    /// <summary>
    ///     Interaction logic for App
    /// </summary>
    public partial class App : Application
    {
        /// <summary>
        ///     Raises the System.Windows.Application.Startup event.
        /// </summary>
        /// <param name="e">
        ///     A System.Windows.StartupEventArgs that contains the event data.
        /// </param>
        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);

            var bootstrapper = new Bootstrapper();
            bootstrapper.Run();
        }
    }
}
