﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp
{
    public class OldDictionary
    {
        Dictionary<int,string> Catalog { get; } = new Dictionary<int, string>()
        {
            {1,"Arne"},
            {2,"Per" },
            {3,"Mads" }
        };

        public string FindByShortNumber(int no)
        {
            return Catalog[no];
        }
        

    }
}