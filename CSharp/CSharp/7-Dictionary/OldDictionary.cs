using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp
{
    public class OldDictionary
    {
        public Dictionary<int, string> Catalog { get; private set; }

        public string FindByShortNumber(int no)
        {
            return Catalog[no];
        }

        public OldDictionary()
        {
            Catalog = new Dictionary<int, string>
                {
                    {1,"Arne"},
                    {2,"Per" },
                    {3,"Mads" }
                };
        }
    }
}
