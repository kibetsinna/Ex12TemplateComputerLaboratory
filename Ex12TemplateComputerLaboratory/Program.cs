using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex12TemplateComputerLaboratory
{
    class Program
    {
        static void Main(string[] args)
        {
            HomeTVComputer home = new HomeTVComputer();
            OfficeComputer office = new OfficeComputer();
            GamingComputer game = new GamingComputer();
            home.BuildComputer();
            office.BuildComputer();
            game.BuildComputer();
            Console.ReadLine();
        }
    }
}
