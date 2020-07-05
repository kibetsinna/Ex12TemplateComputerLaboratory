using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex12TemplateComputerLaboratory
{
    public abstract class TemplateBuildAbsComputer
    {
        public string name;
        abstract public void BuildComputerCase();
        abstract public void AddMotherBoard();
        abstract public void AddProcessor();
        abstract public void AddGraphicCard();
        abstract public void AddMemory();
        

        public  void Test()
        {
            Console.WriteLine("Testing "+name);
            Console.WriteLine("************************************");
        }
        public void BuildComputer()
        {
            BuildComputerCase();
            AddMotherBoard();
            AddProcessor();
            AddGraphicCard();
            AddMemory();
            Test();
        }

    }
}
