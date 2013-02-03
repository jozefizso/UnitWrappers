using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Security;
using System.Security.Permissions;
using System.Text;
using System.Windows;
using System.Windows.Markup;
using System.Windows.Media;
#if NET40
using System.Windows.Shell;
#endif

namespace UnitWrappers.System.Windows
{
    [Localizability(LocalizationCategory.Ignore)]
    [UIPermission(SecurityAction.InheritanceDemand, Window = UIPermissionWindow.AllWindows)] 
    public  class WindowWrap:IWindow,IWrap<Window>
    {
        private Window _underlyingObject;

        public static implicit operator WindowWrap(Window o)
        {
            return new WindowWrap(o);
        }

        public static implicit operator Window(WindowWrap o)
        {
            return o._underlyingObject;
        }

        Window IWrap<Window>.UnderlyingObject
        {
            get { return _underlyingObject; }
        }

        /// <summary>
        ///     Constructs a window object 
        /// </summary>
        /// <remarks>
        ///     Automatic determination of current Dispatcher. Use alternative constructor
        ///     that accepts a Dispatcher for best performance. 
        ///
        ///     Initializes the Width/Height, Top/Left properties to use windows 
        ///     default. Updates Application object properties if inside app. 
        ///
        ///     Also, window style is set to WS_CHILD inside CreateSourceWindow 
        ///     for browser hosted case
        ///
        ///     Callers must have UIPermission(UIPermissionWindow.AllWindows) to call this API.
        /// </remarks> 
        /// <SecurityNote>
        /// Critical: We explicitly demand all window permission currently Window creation is not available in Internet Zone. 
        ///     _ownerHandle and _dialogOwnerHandle fields are initialized when this .ctor gets called. 
        /// PublicOK: The only scenarios where we're currently going to enable creation of Windows is with RootBrowserWindow.
        ///     This code has a demand. 
        /// </SecurityNote>
        [SecurityCritical]
        public WindowWrap()
        {
            _underlyingObject = new Window();
        }

        [SecurityCritical]
        public WindowWrap(global::System.Windows.Window window)
        {
            _underlyingObject = window;
        }

#if NET40
        public TaskbarItemInfo TaskbarItemInfo
        {
            get { return _underlyingObject.TaskbarItemInfo; }
            set { _underlyingObject.TaskbarItemInfo = value; }
        }

#endif

        public bool AllowsTransparency
        {
           get { return _underlyingObject.AllowsTransparency; }
            set { _underlyingObject.AllowsTransparency = value; }
        }

        public string Title
        {
           get { return _underlyingObject.Title; }
            set { _underlyingObject.Title = value; }
        }

        public ImageSource Icon
        {
           get { return _underlyingObject.Icon; }
            set { _underlyingObject.Icon = value; }
        }

        public SizeToContent SizeToContent
        {
           get { return _underlyingObject.SizeToContent; }
            set { _underlyingObject.SizeToContent = value; }
        }

        public double Top
        {
           get { return _underlyingObject.Top; }
            set { _underlyingObject.Top = value; }
        }

        public double Left
        {
           get { return _underlyingObject.Left; }
            set { _underlyingObject.Left = value; }
        }

        public Rect RestoreBounds
        {
           get { return _underlyingObject.RestoreBounds; }
        }

        public bool IsActive
        {
           get { return _underlyingObject.IsActive; }
        }

        public bool? DialogResult
        {
           get { return _underlyingObject.DialogResult; }
            set { _underlyingObject.DialogResult = value; }
        }

        public WindowStyle WindowStyle
        {
           get { return _underlyingObject.WindowStyle; }
            set { _underlyingObject.WindowStyle = value; }
        }

        public WindowState WindowState
        {
           get { return _underlyingObject.WindowState; }
            set { _underlyingObject.WindowState = value; }
        }

        public bool ShowInTaskbar
        {
           get { return _underlyingObject.ShowInTaskbar; }
            set { _underlyingObject.ShowInTaskbar = value; }
        }

        public ResizeMode ResizeMode
        {
           get { return _underlyingObject.ResizeMode; }
            set { _underlyingObject.ResizeMode = value; }
        }

        public bool Topmost
        {
           get { return _underlyingObject.Topmost; }
            set { _underlyingObject.Topmost = value; }
        }

        public event EventHandler SourceInitialized;
        public event EventHandler Activated;
        public event EventHandler Deactivated;
        public event EventHandler StateChanged;
        public event EventHandler LocationChanged;
        public event CancelEventHandler Closing;
        public event EventHandler Closed;
        public event EventHandler ContentRendered;

        public void AddChild(object value)
        {
           ((IAddChild) _underlyingObject).AddChild(value);
        }

        public void AddText(string text)
        {
            ((IAddChild)_underlyingObject).AddChild(text);
        }

        public void Show()
        {
           _underlyingObject.Show();
        }

        public void Hide()
        {
            _underlyingObject.Hide();
        }

        public void Close()
        {
            _underlyingObject.Close();
        }

        public void DragMove()
        {
            _underlyingObject.DragMove();
        }

        public bool? ShowDialog()
        {
           return _underlyingObject.ShowDialog();
        }

        public bool Activate()
        {
           return _underlyingObject.Activate();
        }

        public WindowStartupLocation WindowStartupLocation
        {
           get { return _underlyingObject.WindowStartupLocation; }
            set { _underlyingObject.WindowStartupLocation = value; }
        }

        public bool ShowActivated
        {
           get { return _underlyingObject.ShowActivated; }
            set { _underlyingObject.ShowActivated = value; }
        }

        public IWindow Owner
        {
           get { return new WindowWrap(_underlyingObject.Owner); }
            set { _underlyingObject.Owner = ((IWrap<Window>)value).UnderlyingObject; }
        }

        public IEnumerable<IWindow> OwnedWindows
        {
           get { return _underlyingObject.OwnedWindows.Cast<Window>().Select(x=> new WindowWrap(x) as IWindow); }
        }
    }
}
