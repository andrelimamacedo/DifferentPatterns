using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrozenMountainAssessment
{
    public class FrozenMountain
    {
        static void Main(string[] args)
        {
            FrozenMountainLibrary lib = new FrozenMountainLibrary();
            foreach (var entry in lib.getDifferentPatterns("zf3kabxcde224lkzf3mabxc51+crsdtzf3nab=", 1))
            {
                Console.WriteLine($"{entry.Key}={entry.Value}");
            }
            foreach (var entry in lib.getDifferentPatterns("zf3kabxcde224lkzf3mabxc51+crsdtzf3nab=", 3))
            {
                Console.WriteLine($"{entry.Key}={entry.Value}");
            }
            
        }
      
    }
}
