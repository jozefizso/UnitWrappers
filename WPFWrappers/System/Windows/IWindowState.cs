using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Security;
using System.Text;
using System.Windows;
using System.Windows.Media;
#if NET40
using System.Windows.Shell;
#endif

namespace UnitWrappers.System.Windows
{
    public interface IWindowState
    {

#if NET40
        /// <summary> 
        /// Get or set the TaskbarItemInfo associated with this Window.
        /// </summary> 
        TaskbarItemInfo TaskbarItemInfo { get; set; }
#endif

        /// <summary>
        /// Whether or not the Window uses per-pixel opacity
        /// </summary> 
        bool AllowsTransparency { get; set; }

        /// <summary>
        ///     The data that will be displayed as the title of the window.
        ///     Hosts are free to display the title in any manner that they
        ///     want.  For example, the browser may display the title set via 
        ///     the Title property somewhere besides the caption bar
        /// </summary> 
        [Localizability(LocalizationCategory.Title)]
        string Title { get; set; }

        /// <summary>
        ///     Sets the Icon of the Window
        /// </summary> 
        /// <remarks>
        ///     Following is the precedence for displaying the icon: 
        /// 
        ///     1) Use ImageSource provided by the Icon property.  If Icon property is
        ///     null, see 2 below. 
        ///     2) If Icon Property is not set, then use the Application icon
        ///     embedded in the exe.  Querying Icon property returns null.
        ///     3) If no icon is embedded in the exe, then we set IntPtr.Zero
        ///     as the icon and Win32 displays its default icon.  Querying Icon 
        ///     property returns null.
        /// 
        ///     If Icon property is set, Window does not dispose that object when it 
        ///     is closed.
        ///     Callers must have UIPermission(UIPermissionWindow.AllWindows) to call this API. 
        /// </remarks>
        /// <SecurityNote>
        ///     Critical: This code causes icon value to be set. This in turn causes property invalidation
        ///               which will access unsafe native methods. 
        ///     PublicOK: There exists a demand , safe to expose
        /// </SecurityNote> 
        ImageSource Icon { get; [SecurityCritical]
        set; }

        /// <summary>
        /// Auto size Window to its content's size
        /// </summary> 
        /// <remarks>
        /// 1. SizeToContent can be applied to Width Height independently 
        /// 2. After SizeToContent is set, setting Width/Height does not take affect if that 
        ///    dimension is sizing to content.
        /// 3. SizeToContent is turned off (restored to SizeToContent.Manual) if user starts to 
        ///    interact with window in terms of size
        /// </remarks>
        /// <value>
        /// Default value is SizeToContent.Manual 
        /// </value>
        SizeToContent SizeToContent { get; set; }

        /// <summary>
        ///     Position for Top of the host window 
        /// </summary> 
        /// <remarks>
        ///     The following values are valid: 
        ///     Positive Doubles: sets the top location to the specified value
        ///     NaN: indicates to use the system default value. This
        ///     is the default for Top property
        ///     PositiveInfinity, NegativeInfinity: These are invalid inputs. 
        /// </remarks>
        /// <value></value> 
        [TypeConverter("System.Windows.LengthConverter, PresentationFramework")]
        double Top { get; set; }

        /// <summary>
        ///     Position for Left edge of  coordinate of the host window
        /// </summary> 
        /// <remarks>
        ///     The following values are valid: 
        ///     Positive Doubles: sets the top location to the specified value 
        ///     NaN: indicates to use the system default value. This
        ///     is the default for Top property 
        ///     PositiveInfinity, NegativeInfinity: These are invalid inputs.
        /// </remarks>
        /// <value></value>
        [TypeConverter("System.Windows.LengthConverter, PresentationFramework")]
        double Left { get; set; }

        /// <summary> 
        ///     This property returns the restoring rectangle of the window.  This information
        ///     can be used to track a users size and position preferences when the 
        ///     Window is maximized or minimized.
        ///
        ///     If RestoreBounds is queried before the Window has been shown or after it has
        ///     been closed, it will return Rect.Empty. 
        /// </summary>
        /// <remarks> 
        ///     Callers must have UIPermission(UIPermissionWindow.AllWindows) to call this API. 
        /// </remarks>
        /// <SecurityNote> 
        ///     Critical: This code accesses Handle and calls critical method GetNormalRectLogicalUnits
        ///     PublicOK: This code only works under RBW code path , this operation is ok since
        ///     RBW window is bound to the restrictions of its parent window which is the browser
        /// </SecurityNote> 
        Rect RestoreBounds { [SecurityCritical]
        get; }

   

        /// <summary>
        /// IsActive property. It indicates whether the Window is active. 
        /// The title bar will have the active theme. The active window will be 
        /// the topmost of all top-level windows that don't explicitly set the TopMost property or style.
        /// If a window is active, focus is within the window. 
        /// </summary>
        bool IsActive { get; }

        /// <summary> 
        /// Sets/gets DialogResult
        /// </summary>
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden),
         TypeConverter(typeof (DialogResultConverter))]
        Nullable<bool> DialogResult { get; set; }

        /// <summary>
        ///     Defines the visual style of the window (3DBorderWindow,
        ///     SingleBorderWindow, ToolWindow, none).
        /// </summary> 
        /// <remarks>
        ///     Default will be SingleBorderWindow. 
        /// </remarks> 
         WindowStyle WindowStyle { get; set; }

        /// <summary> 
        ///     Current state of the window.  Valid options are Maximized, Minimized,
        ///     or Normal.  The host window may choose to ignore a request to change 
        ///     the current window state. 
        /// </summary>
          WindowState WindowState { get; set; }

          ///<summary> 
          ///     Determines if the window should show up in the system taskbar. 
          ///     This also determines if the window appears in the Alt-Tab list.
          ///</summary> 
          bool ShowInTaskbar { get; set; }

        /// <summary> 
        ///     Current state of the window.  Valid options are Maximized, Minimized,
        ///     or Normal.  The host window may choose to ignore a request to change
        ///     the current window state.
        /// </summary> 
           ResizeMode ResizeMode { get; set; }

        /// <summary>
        ///     Determines if this window is always on the top. 
        /// </summary> 
            bool Topmost { get; set; }


             /// <summary> 
             ///     This event is raised after the window source is created before it is shown 
             /// </summary>
             event EventHandler SourceInitialized;

             /// <summary> 
             ///     This event is raised when the window is activated 
             /// </summary>
             event EventHandler Activated;

             /// <summary> 
             ///     This event is raised when the window is deactivated 
             /// </summary>
             event EventHandler Deactivated;

             /// <summary> 
             ///     This event is raised when the window state is changed 
             /// </summary>
             event EventHandler StateChanged;

             /// <summary> 
             ///     This event is raised when the window location is changed 
             /// </summary>
             event EventHandler LocationChanged;

             /// <summary> 
             ///     This event is raised before the window is closed 
             /// </summary>
             /// <remarks> 
             ///     The user can set the CancelEventArg.Cancel property to true to prevent
             ///     the window from closing. However, if the Applicaiton is shutting down
             ///     the window closing cannot be cancelled
             /// </remarks> 
             event CancelEventHandler Closing;

             /// <summary>
             ///     This event is raised when the window is closed.
             /// </summary> 
             event EventHandler Closed;

             /// <summary>
             ///     This event is raised when the window and its content is rendered.
             /// </summary> 
             event EventHandler ContentRendered;
    
    }
}
