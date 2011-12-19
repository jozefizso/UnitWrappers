﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reflection;
using UnitWrappers.Microsoft.Win32;
using UnitWrappers.System;
using UnitWrappers.System.IO;
using UnitWrappers.System.Windows.Threading;

namespace UnitWrappers.CoverageCalculator
{

    class Program
    {
        //TODO: add extensions methods calculator
        static void Main(string[] args)
        {
            // stripped out interface version of some framework class with less control above underlying instance
            // no corresponding direct implementation
            var serviceMembers = "Service";

            // static members and constuctors of class
            var staticMembers = "System";

            // namespace wide factories
            string factory = "Factory";

            Assembly unitWrappers = typeof(IDateTimeSystem).Assembly;
            Assembly wpfWrappers = typeof(IDispatcher).Assembly;

            IEnumerable<Assembly> unitRefrencedAssemblies = unitWrappers.GetReferencedAssemblies().Select(Assembly.Load);
            IEnumerable<Assembly> wpfRefrencedAssemblies = wpfWrappers.GetReferencedAssemblies().Select(Assembly.Load);

            var unitClasses =
                from r in unitRefrencedAssemblies
                from t in r.GetExportedTypes()
                orderby t.FullName
                select t;

            var wpfClasses =
    from r in wpfRefrencedAssemblies
    from t in r.GetExportedTypes()
    orderby t.FullName
    select t;

            var frameworkClasses = unitClasses.Union(wpfClasses).ToArray();

            var unitInterfaces = unitWrappers.GetExportedTypes().Where(x => x.IsInterface);
            var wpfInterfaces = wpfWrappers.GetExportedTypes().Where(x => x.IsInterface);

            var wrapInterfaces = unitInterfaces.Union(wpfInterfaces);

            var strippedInterfaceNames = wrapInterfaces.Select(x => x.Name).Select(x =>
                                                                          {
                                                                              string name = x.Remove(0, 1); // remove I
                                                                              name = cutEnd(name, staticMembers);
                                                                              name = cutEnd(name, serviceMembers);
                                                                              return name;
                                                                          })
                                                                             .Distinct()
                                                                           
                                                                             .ToArray();
            // next dictionary should be 
            // framework type short name = collection of correspoding wrap interfaces
            var combinedInterfaces = new Dictionary<string, Type[]>();
            foreach (var name in strippedInterfaceNames)
            {
                var wraps = new List<Type>();
                foreach (var i in wrapInterfaces)
                {
                    if (i.Name.Equals("I" + name) || i.Name.Equals("I" + name + staticMembers))
                    {
                        wraps.Add(i);
                    }
                }
                combinedInterfaces.Add(name, wraps.ToArray());
            }

            // next dictionary should be 
            // framework type= collection of correspoding wrap classes
            var counterParts = new List<FrameworkWrapsMap>();
            foreach (var wraps in combinedInterfaces)
            {
                string frameworkNameSpace = wraps.Value[0].Namespace.Replace("UnitWrappers.", "");
                string frameworkTypeName = frameworkNameSpace + "." + wraps.Key;

                // exclude namespace wide factories
                if (wraps.Key.EndsWith(factory)
                    && frameworkNameSpace.EndsWith(wraps.Key.Replace(factory, "")))
                {
                    continue;
                }
                var type = frameworkClasses.Where(x => x.FullName == frameworkTypeName).Single();
                counterParts.Add(new FrameworkWrapsMap(type, wraps.Value));
            }

            counterParts = counterParts.OrderBy(x => x.Wrapped.FullName).ToList();
            
            
            using (var fileStream = new FileStreamWrap("Coverage.txt", FileMode.Create))
            {
                using (var streamWriter = new StreamWriterWrap(fileStream.FileStreamInstance))
                {
                    streamWriter.WriteLine("Total number of wraps: " + counterParts.Count);
                    foreach (var counterPart in counterParts)
                    {
                        string entry = CalculateEntry(counterPart.Wrapped, counterPart.Wraps);
                        streamWriter.WriteLine(entry);
                        streamWriter.Flush();
                    }

                }
            }
        }

        private static string cutEnd(string value, string pattern)
        {
            int index = value.LastIndexOf(pattern);
            int lenght = pattern.Length;
            if (index == value.Length - lenght && index > 0)
            {
                value = value.Remove(index, lenght);
            }
            return value;
        }

        private static string CalculateEntry(Type real, Type[] wraps)
        {
            var realMembers = real.GetMembers().Where(x =>
                                                          {
                                                              // do not count object's not overriden members
                                                              if (x.DeclaringType == typeof(object))
                                                              {
                                                                  return false;
                                                              }
                                                              // do not count obsolete members
                                                              if (x.GetCustomAttributes(typeof(ObsoleteAttribute), false).Count() != 0)
                                                              {
                                                                  return false;
                                                              }
                                                              return true;
                                                          }).ToArray();


            var wrapsIntefaces =
                (from w in wraps
                 from i in w.GetInterfaces()
                 select i).ToArray();

            var wrapsIntefacesMembers =
                (from wi in wrapsIntefaces
                 from mi in wi.GetMembers()
                 select mi).ToArray();

            var wrapsMembers =
                (from w in wraps
                 from m in w.GetMembers()
                 select m).Concat(wrapsIntefacesMembers).ToArray();

            var realCount = realMembers.Length;
            var wrapsCount = wrapsMembers.Length;
            var coverage = 100 * wrapsCount / realCount;

            if (coverage>100)
            {
                Debugger.Break();
            }
            var wrapsFullName = wraps.Aggregate("", (x, y) => x + " " + y);
            var entry = real.FullName + "->" + wrapsFullName + " : " + coverage + "%";
            return entry;
        }
    }

    internal class FrameworkWrapsMap
    {
        public Type Wrapped { get; set; }
        public Type[] Wraps { get; set; }

        public FrameworkWrapsMap(Type wrapped, Type[] wraps)
        {
            Wrapped = wrapped;
            Wraps = wraps;
        }
    }
}
