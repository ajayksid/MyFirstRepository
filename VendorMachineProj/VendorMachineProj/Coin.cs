﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendorMachineProj
{
    public class Coin
    {

    
        public class nickel : ICoin
        {
            public nickel()
            {
                CoinName = "nickel";
            }
            public string CoinName { get; set; }
            public float CointValue()
            {
                float i = (1 / 20);
                return i;

            }

        }

        public class demies : ICoin
        {
            public demies()
            {
                CoinName = "demies";
            }
            public float CointValue()
            {
                float i = 0.10f;

                return (i);

            }
            public string CoinName { get; set; }

        }
        public class quarters : ICoin
        {
            public quarters()
            {
                CoinName = "quarters";
            }
            public float CointValue()
            {
                float i = (1f / 4f);
                return (i);

            }
            public string CoinName { get; set; }

        }
        public class pennies : ICoin
        {
            public pennies()
            {
                CoinName = "pennies";
            }
            public float CointValue()
            {
                float i = (1f / 100f);
                return i;

            }
            public string CoinName { get; set; }

        }
    }
}
