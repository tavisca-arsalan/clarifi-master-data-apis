using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MasterDataDeliveryApis.Models
{
    public class Polygon
    {
        public Source Source { get; set; }
        public List<GeoCodes> Coordinates { get; set; }
    }
}