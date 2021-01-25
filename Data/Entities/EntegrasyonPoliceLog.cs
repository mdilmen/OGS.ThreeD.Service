using System;
using System.Collections.Generic;

#nullable disable

namespace OGS.ThreeD.Service.Data.Entities
{
    public partial class EntegrasyonPoliceLog
    {
        public decimal EntegrasyonPoliceLogId { get; set; }
        public decimal? PoliceId { get; set; }
        public string PoliceGuid { get; set; }
        public decimal? EntegrasyonUrunId { get; set; }
        public decimal? EntegrasyonSablonTipId { get; set; }
        public string RequestXml { get; set; }
        public string ResponseXml { get; set; }
        public DateTime? RequestTarih { get; set; }
        public DateTime? ResponseTarih { get; set; }
        public string Hata { get; set; }
        public string Guncelleyen { get; set; }
        public DateTime? GuncellemeTarih { get; set; }
        public decimal? GuncellemeTarihNum { get; set; }
    }
}
