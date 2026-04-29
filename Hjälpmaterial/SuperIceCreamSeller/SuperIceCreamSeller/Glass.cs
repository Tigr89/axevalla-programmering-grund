using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperIceCreamSeller
{
    class Glass
    {
        public string glassNamn;
        public int value;
        public string topping;
        public bool isPutInCone;


        public Glass(string _name, int _value, string _topping, bool _inCone)
        {
            glassNamn = _name;
            value = _value;
            topping = _topping;
            isPutInCone = _inCone;
        }

        public int CheckCash(int cash)
        {
            if(cash < value)
            {
                Console.WriteLine("DU har inte råd! Välj en annan glass");
                return 0;
            }
            else
            {
                Console.WriteLine("Du köper en " + glassNamn);
                return value;
            }
        }
    }
}
