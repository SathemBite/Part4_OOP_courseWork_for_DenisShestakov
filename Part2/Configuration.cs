using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Part2
{
    enum ParetoClass { 
        INFERIOR,
        NON_INFERIOR,
        DOMINANT
    }

    class Configuration
    {
        public int Id { get; private set; }
        public ParetoClass ParetoClass { private get; set; }
        private int[] attributes;
        private static int attrCount = 4;
        

        public Configuration(int Id, int[] attributes)
        {
            this.Id = Id;
            this.attributes = attributes;
        }

        public ParetoClass GetParClassRelation(Configuration c)
        {
            bool isThisDominant = true;
            bool isOtherDominant = true;
            for (int i = 0; i < attrCount; i++)
            {
                if (attributes[i] != c.attributes[i])
                {
                    if (attributes[i] > c.attributes[i])
                    {
                        isOtherDominant = false;
                    }
                    else
                    {
                        isThisDominant = false;
                    }
                }
            }

            return (isThisDominant == isOtherDominant)
                ? ParetoClass.NON_INFERIOR
                : isThisDominant
                    ? ParetoClass.DOMINANT
                    : ParetoClass.INFERIOR;
        }

        public override string ToString()
        {
            return "Configuration №" + Id + ", pareto class: " + ParetoClass + "\n";
        }
    }
}
