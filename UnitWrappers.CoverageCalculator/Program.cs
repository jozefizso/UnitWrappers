using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using UnitWrappers.System;
using UnitWrappers.System.IO;

namespace UnitWrappers.CoverageCalculator
{
    
    class Program
    {
        static void Main(string[] args)
        {

            var staticMembers = "System";// static members and factories

            var wrappers = typeof (IDateTimeSystem).Assembly;
            var refrencedAssemblies =  wrappers.GetReferencedAssemblies().Select(Assembly.Load);
            var allClasses =
                from r in refrencedAssemblies
                from t in r.GetExportedTypes()
                orderby t.FullName
                select t;

            var interfaces = wrappers.GetExportedTypes().Where(x => x.IsInterface);
            var strippedNames = interfaces.Select(x => x.Name).Select(x =>
                                                                          {
                                                                              string name = x.Remove(0, 1); // remove I
                                                                              int index = name.LastIndexOf(staticMembers);
                                                                              if (index==name.Length-6)
                                                                              {
                                                                                  name = name.Remove(index, 6);
                                                                              }
                                                                              return name;
                                                                              })
                                                                             .Distinct().ToArray();

            var combinedInterfaces = new Dictionary<string,Type[]>();
            foreach (var n in strippedNames)
            {
                var wraps = new List<Type>();
                foreach (var i in interfaces)
                {
                    if (i.Name.Equals("I" + n) || i.Name.Equals("I" + n + staticMembers))
                    {
                       wraps.Add(i); 
                    }
                }
                combinedInterfaces.Add(n,wraps.ToArray());
            }

            var counterParts = new Dictionary<Type, Type[]>();
            foreach (var wraps in combinedInterfaces)
            {
                string frameworkTypeName = wraps.Value[0].Namespace
                    .Replace("UnitWrappers.","")
                    +"."+ wraps.Key;
                var type = allClasses.Where(x => x.FullName == frameworkTypeName).Single();
                counterParts.Add(type, wraps.Value);
            }

            using (var fileStream = new FileStreamWrap("Coverage.txt", FileMode.Create))
            {
                using (var streamWriter = new StreamWriterWrap(fileStream.FileStreamInstance))
                {
                    foreach (var counterPart in counterParts)
                    {
                        string entry = CalculateEntry(counterPart.Key, counterPart.Value);
                        streamWriter.WriteLine(entry);
                        streamWriter.Flush();
                    }

                }
            }
        }

        private static string CalculateEntry(Type real, Type[] wraps)
        {
            var realMembers = real.GetMembers().Where(x =>
                                                          {
                                                              if (x.DeclaringType == typeof(object))
                                                              {
                                                                  return false;
                                                              }
                                                              return true;
                                                          }).ToArray();

            var wrapsMembers =
                (from w in wraps
                 from m in w.GetMembers()
                 select m).ToArray();

            var realCount = realMembers.Length;
            var wrapsCount = wrapsMembers.Length;
            var coverage = 100 * wrapsCount / realCount;

            var newLine = Environment.NewLine;
            var wrapsFullName = wraps.Aggregate("", (x, y) => x + " " + y);
            var entry = "--------------------------------------------------------------------------------------------------" +
                        newLine
                        + real.FullName + "->" + wrapsFullName + " : " + coverage + "%" + newLine
                        + "--------------------------------------------------------------------------------------------------" +
                        newLine
                ;
            return entry;
        }
    }
}
