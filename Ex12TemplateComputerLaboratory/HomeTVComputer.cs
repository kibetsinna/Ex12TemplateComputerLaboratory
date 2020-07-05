using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex12TemplateComputerLaboratory
{
  
    public class HomeTVComputer : TemplateBuildAbsComputer
    {
        public override void AddGraphicCard()
        {
            Console.WriteLine("Add card with powerful graphics");
        }

        public override void AddMemory()
        {
            Console.WriteLine("Add  memory");
        }

        public override void AddMotherBoard()
        {
            Console.WriteLine("Add  ultrathin motherBoard");
        }

        public override void AddProcessor()
        {
            Console.WriteLine("Add medium processor");
        }

        public override void BuildComputerCase()
        {
            name = "Home TV computer";
            Console.WriteLine("************************************");
            Console.WriteLine("Build  slim case of Home TV computer");
        }

    }
}
