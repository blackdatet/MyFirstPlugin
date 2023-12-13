using Rocket.API;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstPlugin
{
    internal class Command : IRocketCommand
    {
        public AllowedCaller AllowedCaller => AllowedCaller.Both;

        public string Name => "test";

        public string Help => "";

        public string Syntax => "";

        public List<string> Aliases => new List<string> { "T" };

        public List<string> Permissions => new List<string> { "Test" };

        public void Execute(IRocketPlayer caller, string[] command)
        {
            
        }
    }
}
