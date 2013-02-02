using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Text;
using System.Windows;
using System.Windows.Interop;

namespace UnitWrappers.System.Windows
{
    public class MessageBoxWrap : IMessageBox
    {
        [SecurityCritical]
        public MessageBoxResult Show(string messageBoxText, string caption, MessageBoxButton button, MessageBoxImage icon, MessageBoxResult defaultResult, MessageBoxOptions options)
        {
            return MessageBox.Show(messageBoxText, caption, button, icon, defaultResult, options);
        }

        [SecurityCritical]
        public MessageBoxResult Show(string messageBoxText, string caption, MessageBoxButton button, MessageBoxImage icon, MessageBoxResult defaultResult)
        {
            return MessageBox.Show(messageBoxText, caption, button, icon, defaultResult);
        }

        [SecurityCritical]
        public MessageBoxResult Show(string messageBoxText, string caption, MessageBoxButton button, MessageBoxImage icon)
        {
            return MessageBox.Show(messageBoxText, caption, button, icon);
        }

        [SecurityCritical]
        public MessageBoxResult Show(string messageBoxText, string caption, MessageBoxButton button)
        {
            return MessageBox.Show( messageBoxText, caption, button);
        }

        [SecurityCritical]
        public MessageBoxResult Show(string messageBoxText, string caption)
        {
            return MessageBox.Show(messageBoxText, caption);
        }

        [SecurityCritical]
        public MessageBoxResult Show(string messageBoxText)
        {
            return MessageBox.Show( messageBoxText);
        }

        [SecurityCritical]
        public MessageBoxResult Show(Window owner, string messageBoxText, string caption, MessageBoxButton button, MessageBoxImage icon, MessageBoxResult defaultResult, MessageBoxOptions options)
        {
            return MessageBox.Show(owner, messageBoxText, caption, button, icon, defaultResult, options);
        }

        [SecurityCritical]
        public MessageBoxResult Show(Window owner, string messageBoxText, string caption, MessageBoxButton button, MessageBoxImage icon, MessageBoxResult defaultResult)
        {
            return MessageBox.Show(owner, messageBoxText, caption, button, icon, defaultResult);
        }

        [SecurityCritical]
        public MessageBoxResult Show(Window owner, string messageBoxText, string caption, MessageBoxButton button, MessageBoxImage icon)
        {
            return MessageBox.Show(owner, messageBoxText, caption, button, icon);
        }

        [SecurityCritical]
        public MessageBoxResult Show(Window owner, string messageBoxText, string caption, MessageBoxButton button)
        {
            return MessageBox.Show(owner, messageBoxText, caption, button);
        }

        [SecurityCritical]
        public MessageBoxResult Show(Window owner, string messageBoxText, string caption)
        {
            return MessageBox.Show(owner, messageBoxText, caption);
        }

        [SecurityCritical]
        public MessageBoxResult Show(Window owner, string messageBoxText)
        {
            return MessageBox.Show(owner, messageBoxText);
        }
    }
}
