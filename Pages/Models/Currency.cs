using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DogecoinNewsDaily
{
    public class Currency
    {
            public string status { get; set; }
            public Data data { get; set; }
    }
    public class Data
    {
        public string network { get; set; }
        public Price[] prices { get; set; }
    }

    public class Price
    {
        public string price { get; set; }
        public string price_base { get; set; }
        public string exchange { get; set; }
        public int time { get; set; }
    }

}
