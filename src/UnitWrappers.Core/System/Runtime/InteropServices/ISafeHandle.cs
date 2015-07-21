using System;

namespace UnitWrappers.System.Runtime.InteropServices
{
    /// <summary>
    /// 
    /// </summary>
    public interface ISafeHandle
    {
        /// <summary>
        /// Gets a value indicating whether the handle is closed.
        /// </summary>
        bool IsClosed { get; }

        /// <summary>
        /// Gets a value that indicates whether the handle is invalid.
        /// </summary>
        bool IsInvalid { get; }

        /// <summary>
        /// Marks the handle for releasing and freeing resources.
        /// </summary>
        void Close();

        /// <summary>
        /// Manually increments the reference counter on SafeHandle instances.
        /// </summary>
        /// <param name="success">true if the reference counter was successfully incremented; otherwise, false.</param>
        void DangerousAddRef(ref bool success);

        /// <summary>
        /// Returns the value of the handle field. 
        /// </summary>
        /// <returns></returns>
        IntPtr DangerousGetHandle();

        /// <summary>
        /// Manually decrements the reference counter on a SafeHandle instance.
        /// </summary>
        void DangerousRelease();

        /// <summary>
        /// Marks a handle as no longer used.
        /// </summary>
        void SetHandleAsInvalid();
    }
}