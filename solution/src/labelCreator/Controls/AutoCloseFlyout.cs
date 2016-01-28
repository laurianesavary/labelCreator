namespace LabelCreator.Controls
{
    using System;
    using System.Windows.Input;

    using MahApps.Metro.Controls;

    /// <summary>
    ///     A <see cref="Flyout" /> control which automatically closes when it loses focus.
    /// </summary>
    public class AutoCloseFlyout : Flyout
    {
        /// <summary>
        ///     Initializes a new instance of the <see cref="AutoCloseFlyout" /> class.
        /// </summary>
        public AutoCloseFlyout()
        {
            this.IsOpenChanged += this.OnIsOpenChanged;
            this.IsTabStop = false;
        }

        /// <summary>
        ///     Invoked when an unhandled System.Windows.Input.Keyboard.LostKeyboardFocus attached
        ///     event reaches an element in its route that is derived from this class. Implement
        ///     this method to add class handling for this event.
        /// </summary>
        /// <param name="e">
        ///     The System.Windows.Input.KeyboardFocusChangedEventArgs that contains event data.
        /// </param>
        protected override void OnLostKeyboardFocus(KeyboardFocusChangedEventArgs e)
        {
            base.OnLostKeyboardFocus(e);

            if (!this.IsFocused && !this.IsKeyboardFocusWithin)
            {
                this.IsOpen = false;
            }
        }

        /// <summary>
        ///     Brings the focus to the <see cref="Flyout" /> when the <see cref="Flyout" /> is opened.
        /// </summary>
        /// <param name="sender">
        ///     The sender.
        /// </param>
        /// <param name="e">
        ///     The event arguments.
        /// </param>
        private void OnIsOpenChanged(object sender, EventArgs e)
        {
            this.IsHitTestVisible = this.IsOpen;

            if (this.IsOpen)
            {
                this.MoveFocus(new TraversalRequest(FocusNavigationDirection.First));
            }
        }
    }
}
