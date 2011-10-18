using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Text;
using SystemWrapper.Configuration;
using SystemWrapper.IO;

namespace SystemWrapper.CoverageCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var fileStream = new FileStreamWrap("Coverage.txt", FileMode.Create))
            {
                using (var streamWriter = new StreamWriterWrap(fileStream.FileStreamInstance))
                {
                    var real = typeof(ConfigurationManager);
                    var wraps = typeof(IConfigurationManager);

                    var realMembers = real.GetMembers();
                    var wrapsMembers = wraps.GetMembers();
                    var realCount = realMembers.Length;
                    var wrapsCount = wrapsMembers.Length;
                    var coverage = 100 * wrapsCount / realCount;

                    var newLine = Environment.NewLine;

                    var entry = "--------------------------------------------------------------------------------------------------" + newLine
                        + real.FullName + "->" + wraps.FullName + " : " + coverage + "%" +  newLine
                        + "--------------------------------------------------------------------------------------------------" + newLine
                        ;

                    streamWriter.WriteLine(entry);
                    streamWriter.Flush();
                }   
            }

        }
    }
}
