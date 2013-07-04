using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;

namespace UnitWrappers.System.Windows
{
    public interface IWindowSystem
    {
        /// <summary>
        /// Gets Window in which the given DependecyObject is hosted in. 
        /// </summary>
        /// <param name="dependencyObject">Returns the Window the given dependencyObject is hosted in.</param>
        /// <returns>Window</returns>
        IWindow GetWindow(DependencyObject dependencyObject);

        IWindow CreateWindow();
    }
}
