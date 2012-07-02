using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Security;
using System.Text;
using System.Windows;
using System.Windows.Markup;

namespace UnitWrappers.System.Windows
{
    public interface IWindow : IWindowState, IAddChild
    {
        /// <summary> 
        ///     Show the window
        /// </summary>
        /// <remarks>
        ///     Calling Show on window is the same as setting the 
        ///     Visibility property to Visibility.Visible.
        /// </remarks> 
         void Show();

        /// <summary> 
        ///     Hide the window
        /// </summary> 
        /// <remarks> 
        ///     Calling Hide on window is the same as setting the
        ///     Visibility property to Visibility.Hidden 
        ///     </remarks>
         void Hide();

        /// <summary>
        ///     Closes the Window 
        /// </summary> 
        /// <remarks>
        ///     Window fires the Closing event before it closes. If the 
        ///     user cancels the closing event, the window is not closed.
        ///     Otherwise, the window is closed and the Closed event is
        ///     fired.
        /// 
        ///     Callers must have UIPermission(UIPermissionWindow.AllWindows) to call this API.
        /// </remarks> 
        ///<SecurityNote> 
        ///  PublicOK: This API Demands UIPermission with AllWindows access
        ///  Critical: calls critical code (InternalClose) 
        ///</SecurityNote>
        [SecurityCritical]
         void Close();


        /// <summary> 
        ///     Kick off the Window's MoveWindow loop
        /// </summary> 
        /// <remarks> 
        ///     To enable custom chrome on Windows. First check if this is the Left MouseButton.
        ///     Will throw exception if it's not, otherwise, will kick off the Windows's MoveWindow loop. 
        ///     Callers must have UIPermission(UIPermissionWindow.AllWindows) to call this API.
        /// </remarks>
        ///<SecurityNote>
        ///     Critical - as this code performs an elevation via the calls to SendMessage. 
        ///     PublicOk - as there is a demand for all windows permission.
        ///     We explicitly demand unamnaged code permission - as there's no valid scenario for this in the SEE. 
        ///</SecurityNote> 
        [SecurityCritical]
        void DragMove();

        /// <summary>
        ///     Shows the window as a modal window
        /// </summary>
        /// <returns>bool?</returns> 
        /// <remarks>
        ///     Callers must have UIPermission(UIPermissionWindow.AllWindows) to call this API. 
        /// </remarks> 
        /// <SecurityNote>
        /// Critical: This code causes unmamanged code elevation in the call to GetWindowLong and GetDesktopWindow 
        ///           which has a SUC on it. There is also a call to SetFocus which returns a window handle.
        ///           It also accesses _dialogOwnerHandle, _dialogPreviousActiveHandle and _ownerHandle.
        /// PublicOK: There is a demand in the code
        /// </SecurityNote> 
        [SecurityCritical]
         Nullable<bool> ShowDialog();

        /// <summary>
        ///     This method tries to activate the Window. 
        /// </summary>
        /// <remarks>
        ///     This method calls SetForegroundWindow on the hWnd, thus the rules for SetForegroundWindow
        ///     apply to this method. 
        ///     Callers must have UIPermission(UIPermissionWindow.AllWindows) to call this API.
        /// </remarks> 
        /// <returns>bool -- indicating whether the window was activated or not</returns> 
        ///<SecurityNote>
        ///     Critical as this code performs an elevation in the call to SetForegroundWindow. 
        ///     PublicOk - there is a demand in the code. Any caller will require
        ///                     all window code permissions.
        ///</SecurityNote>
        [SecurityCritical]
         bool Activate();

        /// <summary> 
        ///     This enum can have following values 
        ///         Manual (default)
        ///         CenterScreen 
        ///         CenterOwner
        ///
        ///     If the WindowStartupLocation is WindowStartupLocation.Manual then
        ///     Top and Left properites are used to position the window. 
        ///     This property is used only before window creation. Once the window is
        ///     created hiding it and showing it will not take this property into account. 
        /// </summary> 
        /// <remarks>
        ///     WindowStartupLocation is used to position the window only it it is set to 
        ///     WindowStartupLocation.CenterScreen or WindowStartupLocation.CenterOwner,
        ///     otherwise Top/Left is used.  Furthermore, if determining the location
        ///     of the window is not possible when WindowStartupLocation is set to
        ///     WindowStartupLocation.CenterScreen or WindowStartupLocation.Owner, then 
        ///     Top/Left is used instead.
        /// </remarks> 
        [DefaultValue(WindowStartupLocation.Manual)]
         WindowStartupLocation WindowStartupLocation { get; set; }

        /// <summary>
        ///     Determines if this window is activated when shown (default = true). 
        /// </summary>
        /// <remarks> 
        ///     Not supported for RBW. 
        /// </remarks>
        bool ShowActivated { get; set; }




        /// <summary>
        ///     This set the owner for the property of the current window.
        ///     If the window has owner and the owner is minimized then 
        ///     owned window is also minimized. Owner window can never be
        ///     over owned window. Owned window is NOT modal. So user can 
        ///     still interact with owner window. This property can not be 
        ///     set of the top level window.
        /// </summary> 
        ///<remarks>
        ///     Callers must have UIPermission(UIPermissionWindow.AllWindows) to call this API.
        ///</remarks>
        ///<SecurityNote> 
        /// Critical - _ownerWindow is accessed, SetOwnerHandle is called.
        /// PublicOK - get/set protected by Demand's. 
        ///</SecurityNote> 
        [DefaultValue(null)]

        IWindow Owner { [SecurityCritical]get; [SecurityCritical]set; }

        /// <summary>
        ///     This is a collection of windows that are owned by current window. 
        /// </summary>
        IEnumerable<IWindow> OwnedWindows { get; }


    }
}
