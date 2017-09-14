using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MasterDataDeliveryApis.Models.DataTransferObjects
{
    public class PolygonDto
    {
        public SourceDto Source { get; set; }
        public List<GeoCodesDto> Coordinates { get; set; }
    }
}