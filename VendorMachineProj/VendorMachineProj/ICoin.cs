using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendorMachineProj
{
    interface ICoin
    {
        float CointValue();
        string CoinName { get; set; }
    }
}
