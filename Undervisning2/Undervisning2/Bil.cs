using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Undervisning2
{
    /*
             let bil = {
                motor: 'V8',
                registreringsnr: 'BJ69693',
                farge: 'blå',
                wunderbaum: true
            }
                          
             */
    internal class Bil
    {
        
        //string _registreringsnr = "BJ69693";
        //string _farge = "blå";
        //bool _harWunderbaum = true;

        public string Motor { get; private set; }

        public void PutInEngine(string engineType)
        {
            Motor = engineType;
        }


    }
}
