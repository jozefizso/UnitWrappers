using System.Security;
using System.Windows;

namespace UnitWrappers.System.Windows
{
    public interface IMessageBox
    {
        [SecurityCritical]
        MessageBoxResult Show(string messageBoxText, string caption, MessageBoxButton button, MessageBoxImage icon, MessageBoxResult defaultResult, MessageBoxOptions options);

        [SecurityCritical]
        MessageBoxResult Show(string messageBoxText, string caption, MessageBoxButton button, MessageBoxImage icon, MessageBoxResult defaultResult);

        [SecurityCritical]
        MessageBoxResult Show(string messageBoxText, string caption, MessageBoxButton button, MessageBoxImage icon);

        [SecurityCritical]
        MessageBoxResult Show(string messageBoxText, string caption, MessageBoxButton button);

        [SecurityCritical]
        MessageBoxResult Show(string messageBoxText, string caption);

        [SecurityCritical]
        MessageBoxResult Show(string messageBoxText);

        [SecurityCritical]
        MessageBoxResult Show(Window owner, string messageBoxText, string caption, MessageBoxButton button, MessageBoxImage icon, MessageBoxResult defaultResult, MessageBoxOptions options);

        [SecurityCritical]
        MessageBoxResult Show(Window owner, string messageBoxText, string caption, MessageBoxButton button, MessageBoxImage icon, MessageBoxResult defaultResult);

        [SecurityCritical]
        MessageBoxResult Show(Window owner, string messageBoxText, string caption, MessageBoxButton button, MessageBoxImage icon);

        [SecurityCritical]
        MessageBoxResult Show(Window owner, string messageBoxText, string caption, MessageBoxButton button);

        [SecurityCritical]
        MessageBoxResult Show(Window owner, string messageBoxText, string caption);

        [SecurityCritical]
        MessageBoxResult Show(Window owner, string messageBoxText);
    }
}