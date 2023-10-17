using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionsContrd
{
    internal class Code
    {
        public bool aredictionaryequals(dictionary<ulong?, string> dictionarylist1, dictionary<ulong?, string> dictionarylist2)
        {

            if (dictionarylist1.count != dictionarylist2.count)
                return false;

            idictionary<ulong?, string> orderedlist1 = new dictionary<ulong?, string>();
            idictionary<ulong?, string> orderedlist2 = new dictionary<ulong?, string>();

            foreach (var itemdict1 in dictionarylist1.orderbydescending(key => key.id))
            {

                orderedlist1.add(itemdict1.id, itemdict1.propertyx);

            }

            foreach (var itemdict2 in dictionarylist2.orderbydescending(key => key.id))
            {

                orderedlist2.add(itemdict2.id, itemdict2.propertyx);

            }

            //check keys and values for equality
            return (orderedlist1.keys.sequenceequal(orderedlist2.keys) && orderedlist1.keys.all(k => orderedlist1[k].sequenceequal(orderedlist2[k])));

        }
    }
}
