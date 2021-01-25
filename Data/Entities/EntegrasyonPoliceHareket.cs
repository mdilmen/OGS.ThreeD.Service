using System;
using System.Collections.Generic;

#nullable disable

namespace OGS.ThreeD.Service.Data.Entities
{
    public partial class EntegrasyonPoliceHareket
    {
        public decimal EntegrasyonPoliceHareketId { get; set; }
        public decimal? EntegrasyonPoliceId { get; set; }
        public decimal EntegrasyonPoliceLogId { get; set; }
        public decimal? RevizeNo { get; set; }
        public decimal? EskiHareketId { get; set; }
        public string EntegrasyonPoliceNo { get; set; }
        public string EntegrasyonZeylNo { get; set; }
        public string EntegrasyonYenilemeNo { get; set; }
        public decimal? EntegrasyonPoliceDurumId { get; set; }
        public string AcenteNo { get; set; }
        public string TaliAcenteNo { get; set; }
        public string ZeylKod { get; set; }
        public string ZeylAd { get; set; }
        public string TI { get; set; }
        public string SirketSonDurum { get; set; }
        public string Mt { get; set; }
        public string SirketUrunKod { get; set; }
        public double? ToplamPrim { get; set; }
        public double? ToplamPrimTl { get; set; }
        public double? ToplamNetPrim { get; set; }
        public double? ToplamNetPrimTl { get; set; }
        public double? ToplamVergi { get; set; }
        public double? ToplamVergiTl { get; set; }
        public double? ToplamKomisyon { get; set; }
        public double? ToplamKomisyonTl { get; set; }
        public decimal? DovizId { get; set; }
        public double? DovizKur { get; set; }
        public string DurumAciklama { get; set; }
        public DateTime? BaslamaTarih { get; set; }
        public DateTime? BitisTarih { get; set; }
        public DateTime? TanzimTarih { get; set; }
        public string Online { get; set; }
        public decimal? TahsilatTipId { get; set; }
        public decimal? SgrMusteriRolId { get; set; }
        public decimal? Taksit { get; set; }
        public string SgrMusteriRolAd { get; set; }
        public decimal? SgrSirketMusteriRolId { get; set; }
        public string SgrSirketMusteriRolAd { get; set; }
        public decimal? MtMusteriRolId { get; set; }
        public string MtMusteriRolAd { get; set; }
        public decimal? TpMusteriRolId { get; set; }
        public string TpMusteriRolAd { get; set; }
        public string PoliceIsTip { get; set; }
        public decimal? EskiSgrSirketMusteriRolId { get; set; }
        public string EskiSgrSirketMusteriRolAd { get; set; }
        public string EskiPoliceNo { get; set; }
        public string Guncelleyen { get; set; }
        public DateTime? GuncellemeTarih { get; set; }
        public string DovizKod { get; set; }
        public string SecurePaymentRefNo { get; set; }
        public decimal? PlcbrtIslemReferansId { get; set; }
        public decimal? PlckomIslemReferansId { get; set; }
    }
}
