using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoinAPI.REST.V1 {
    public class Period {
        public string period_id { get; set; }
        public int length_seconds { get; set; }
        public int length_months { get; set; }
        public int unit_count { get; set; }
        public string unit_name { get; set; }
        public string display_name { get; set; }
    }
}
