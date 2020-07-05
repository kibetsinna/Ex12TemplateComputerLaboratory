using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex12TemplateComputerLaboratory
{
    public class GamingComputer : TemplateBuildAbsComputer
    {
  
         
        public override void AddGraphicCard()
        {
           

            Console.WriteLine("Add card with powerful graphics");
        }

        public override void AddMemory()
        {
            Console.WriteLine("Add lot of memory");
        }

        public override void AddMotherBoard()
        {
            Console.WriteLine("Add motherBoard");
        }

        public override void AddProcessor()
        {
            Console.WriteLine("Add powerful processor");
        }

        public override void BuildComputerCase()
        {
            name = "Gaming Computer";
            Console.WriteLine("************************************");
            Console.WriteLine("Build case of gaming computer");
        }
       
    }
}
