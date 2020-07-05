using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex12TemplateComputerLaboratory
{
    public class OfficeComputer : TemplateBuildAbsComputer
    {
        public override void AddGraphicCard()
        {
            Console.WriteLine("Add card with medium graphics");
        }

        public override void AddMemory()
        {
            Console.WriteLine("Add  memory");
        }

        public override void AddMotherBoard()
        {
            Console.WriteLine("Add  motherBoard");
        }

        public override void AddProcessor()
        {
            Console.WriteLine("Add medium processor");
        }

        public override void BuildComputerCase()
        {
            name = "Office Computer";
            Console.WriteLine("************************************");
            Console.WriteLine("Build  case of office computer");
        }
       
    }
}
