using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Необходимо к библиотеке классов подключить файл tyuiu.cources.programming.interfaces.dll
//Alt+Enter
using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.OsipenkoAA.Sprint1.Task0.V0.Lib
{
    public class DataService : ISprint1Task0V0
    {
        public double Calculate()
        {
            return 10 / (2 + 3);
        }
    }
}
