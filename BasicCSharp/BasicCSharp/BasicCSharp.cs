using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;  //Different namespaces containing different sorts of function-members and data-members which we can use

namespace BasicCSharp //Outermost level of program types are organized into namespaces
{
    class BasicCSharp //Class is a function contaiting data-members and function-members
    {
        int x = 5; //Function data-member

        public int MultiplikasjosKalkulator(int tall1, int tall2) //Method (function-member)
        {
            int sum = tall1 * tall2;

            return sum;
        }
          

    }
}
