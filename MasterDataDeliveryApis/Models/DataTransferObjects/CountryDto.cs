using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MasterDataDeliveryApis.Models.DataTransferObjects
{
    public class CountryMasterDto
    {
        public string RegionName { get; set; }

        public string SubRegionName { get; set; }

        public string IntermediateRegionName { get; set; }

        public string Name { get; set; }

        public string IsoCode2 { get; set; }

        public string IsoCode3 { get; set; }

        public string Language { get; set; }

        public DateTime AddedDate { get; set; }

        public DateTime ModifiedDate { get; set; }

        public string FlagUrl { get; set; }

        public string IconUrl { get; set; }

        public List<PolygonDto> Polygons { get; set; }

        public SourceDto Source { get; set; }
    }
}