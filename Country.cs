using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prakt_16_4
{
    public class Country
    {
        private string Name { get; set; }
        private long Population { get; set; }

        public string NameValue
        {
            get { return Name; }
            set { Name = value; }
        }
        public long PopulationValue
        {
            get { return Population; }
            set { Population = value; }
        }
    }
     
}
