using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Badges_Console
{
    class Program
    {
        static void Main(string[] args)
        {
            ProgramUI program = new ProgramUI();
            program.Run();
        }
        // While loop to ask if they want to add another door
        // OR ask how many doors and then do foreach loop to get door names
    }
}
