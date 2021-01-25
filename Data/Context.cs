using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using OGS.ThreeD.Service.Data.Entities;

#nullable disable

namespace OGS.ThreeD.Service.Data
{
    public partial class Context : DbContext
    {
        public Context()
        {
        }

        public Context(DbContextOptions<Context> options)
            : base(options)
        {
        }

        public virtual DbSet<EntegrasyonPoliceHareket> EntegrasyonPoliceHarekets { get; set; }
        public virtual DbSet<EntegrasyonPoliceLog> EntegrasyonPoliceLogs { get; set; }

        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    if (!optionsBuilder.IsConfigured)
        //    {
        //        optionsBuilder.UseSqlServer("server=10.65.101.10;Database=BrokerExpDB;User Id=hdolek; password=Hd121314; Integrated Security=false;MultipleActiveResultSets=true;");
        //    }
        //}

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "Turkish_CI_AS");

            modelBuilder.Entity<EntegrasyonPoliceHareket>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ENTEGRASYON_POLICE_HAREKET");

                entity.HasIndex(e => e.EntegrasyonPoliceLogId, "XIE1ENTEGRASYON_POLICE_HAREKET");

                entity.HasIndex(e => e.EntegrasyonPoliceDurumId, "XIF1ENTEGRASYON_POLICE_HAREKET");

                entity.HasIndex(e => e.EntegrasyonPoliceId, "XIF2ENTEGRASYON_POLICE_HAREKET");

                entity.HasIndex(e => e.EntegrasyonPoliceLogId, "XIF3ENTEGRASYON_POLICE_HAREKET");

                entity.HasIndex(e => e.TahsilatTipId, "XIF4ENTEGRASYON_POLICE_HAREKET");

                entity.HasIndex(e => e.EntegrasyonPoliceHareketId, "XPKENTEGRASYON_POLICE_HAREKET")
                    .IsUnique()
                    .IsClustered();

                entity.Property(e => e.AcenteNo)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("ACENTE_NO");

                entity.Property(e => e.BaslamaTarih)
                    .HasColumnType("date")
                    .HasColumnName("BASLAMA_TARIH");

                entity.Property(e => e.BitisTarih)
                    .HasColumnType("date")
                    .HasColumnName("BITIS_TARIH");

                entity.Property(e => e.DovizId)
                    .HasColumnType("numeric(20, 0)")
                    .HasColumnName("DOVIZ_ID");

                entity.Property(e => e.DovizKod)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("DOVIZ_KOD");

                entity.Property(e => e.DovizKur).HasColumnName("DOVIZ_KUR");

                entity.Property(e => e.DurumAciklama)
                    .IsUnicode(false)
                    .HasColumnName("DURUM_ACIKLAMA");

                entity.Property(e => e.EntegrasyonPoliceDurumId)
                    .HasColumnType("numeric(20, 0)")
                    .HasColumnName("ENTEGRASYON_POLICE_DURUM_ID");

                entity.Property(e => e.EntegrasyonPoliceHareketId)
                    .HasColumnType("numeric(20, 0)")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ENTEGRASYON_POLICE_HAREKET_ID");

                entity.Property(e => e.EntegrasyonPoliceId)
                    .HasColumnType("numeric(20, 0)")
                    .HasColumnName("ENTEGRASYON_POLICE_ID");

                entity.Property(e => e.EntegrasyonPoliceLogId)
                    .HasColumnType("numeric(20, 0)")
                    .HasColumnName("ENTEGRASYON_POLICE_LOG_ID");

                entity.Property(e => e.EntegrasyonPoliceNo)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("ENTEGRASYON_POLICE_NO");

                entity.Property(e => e.EntegrasyonYenilemeNo)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("ENTEGRASYON_YENILEME_NO");

                entity.Property(e => e.EntegrasyonZeylNo)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("ENTEGRASYON_ZEYL_NO");

                entity.Property(e => e.EskiHareketId)
                    .HasColumnType("numeric(20, 0)")
                    .HasColumnName("ESKI_HAREKET_ID");

                entity.Property(e => e.EskiPoliceNo)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("ESKI_POLICE_NO");

                entity.Property(e => e.EskiSgrSirketMusteriRolAd)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("ESKI_SGR_SIRKET_MUSTERI_ROL_AD");

                entity.Property(e => e.EskiSgrSirketMusteriRolId)
                    .HasColumnType("numeric(20, 0)")
                    .HasColumnName("ESKI_SGR_SIRKET_MUSTERI_ROL_ID");

                entity.Property(e => e.GuncellemeTarih)
                    .HasColumnType("datetime")
                    .HasColumnName("GUNCELLEME_TARIH");

                entity.Property(e => e.Guncelleyen)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("GUNCELLEYEN");

                entity.Property(e => e.Mt)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("MT");

                entity.Property(e => e.MtMusteriRolAd)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("MT_MUSTERI_ROL_AD");

                entity.Property(e => e.MtMusteriRolId)
                    .HasColumnType("numeric(20, 0)")
                    .HasColumnName("MT_MUSTERI_ROL_ID");

                entity.Property(e => e.Online)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("ONLINE");

                entity.Property(e => e.PlcbrtIslemReferansId)
                    .HasColumnType("numeric(20, 0)")
                    .HasColumnName("PLCBRT_ISLEM_REFERANS_ID");

                entity.Property(e => e.PlckomIslemReferansId)
                    .HasColumnType("numeric(20, 0)")
                    .HasColumnName("PLCKOM_ISLEM_REFERANS_ID");

                entity.Property(e => e.PoliceIsTip)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("POLICE_IS_TIP");

                entity.Property(e => e.RevizeNo)
                    .HasColumnType("numeric(20, 0)")
                    .HasColumnName("REVIZE_NO");

                entity.Property(e => e.SecurePaymentRefNo)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("SECURE_PAYMENT_REF_NO");

                entity.Property(e => e.SgrMusteriRolAd)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("SGR_MUSTERI_ROL_AD");

                entity.Property(e => e.SgrMusteriRolId)
                    .HasColumnType("numeric(20, 0)")
                    .HasColumnName("SGR_MUSTERI_ROL_ID");

                entity.Property(e => e.SgrSirketMusteriRolAd)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("SGR_SIRKET_MUSTERI_ROL_AD");

                entity.Property(e => e.SgrSirketMusteriRolId)
                    .HasColumnType("numeric(20, 0)")
                    .HasColumnName("SGR_SIRKET_MUSTERI_ROL_ID");

                entity.Property(e => e.SirketSonDurum)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("SIRKET_SON_DURUM");

                entity.Property(e => e.SirketUrunKod)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("SIRKET_URUN_KOD");

                entity.Property(e => e.TI)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("T_I");

                entity.Property(e => e.TahsilatTipId)
                    .HasColumnType("numeric(20, 0)")
                    .HasColumnName("TAHSILAT_TIP_ID");

                entity.Property(e => e.Taksit)
                    .HasColumnType("numeric(20, 0)")
                    .HasColumnName("TAKSIT");

                entity.Property(e => e.TaliAcenteNo)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("TALI_ACENTE_NO");

                entity.Property(e => e.TanzimTarih)
                    .HasColumnType("date")
                    .HasColumnName("TANZIM_TARIH");

                entity.Property(e => e.ToplamKomisyon).HasColumnName("TOPLAM_KOMISYON");

                entity.Property(e => e.ToplamKomisyonTl).HasColumnName("TOPLAM_KOMISYON_TL");

                entity.Property(e => e.ToplamNetPrim).HasColumnName("TOPLAM_NET_PRIM");

                entity.Property(e => e.ToplamNetPrimTl).HasColumnName("TOPLAM_NET_PRIM_TL");

                entity.Property(e => e.ToplamPrim).HasColumnName("TOPLAM_PRIM");

                entity.Property(e => e.ToplamPrimTl).HasColumnName("TOPLAM_PRIM_TL");

                entity.Property(e => e.ToplamVergi).HasColumnName("TOPLAM_VERGI");

                entity.Property(e => e.ToplamVergiTl).HasColumnName("TOPLAM_VERGI_TL");

                entity.Property(e => e.TpMusteriRolAd)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("TP_MUSTERI_ROL_AD");

                entity.Property(e => e.TpMusteriRolId)
                    .HasColumnType("numeric(20, 0)")
                    .HasColumnName("TP_MUSTERI_ROL_ID");

                entity.Property(e => e.ZeylAd)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("ZEYL_AD");

                entity.Property(e => e.ZeylKod)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("ZEYL_KOD");
            });

            modelBuilder.Entity<EntegrasyonPoliceLog>(entity =>
            {
                entity.ToTable("ENTEGRASYON_POLICE_LOG");

                entity.HasIndex(e => e.EntegrasyonUrunId, "ENTEGRASYON_POLICE_LOG_R_212_NDX");

                entity.HasIndex(e => e.EntegrasyonUrunId, "ENTEGRASYON_POLICE_R_218_NDX");

                entity.HasIndex(e => e.GuncellemeTarihNum, "XIE1ENTEGRASYON_POLICE_LOG");

                entity.HasIndex(e => e.EntegrasyonUrunId, "XIF1ENTEGRASYON_POLICE_LOG");

                entity.HasIndex(e => e.EntegrasyonSablonTipId, "XIF2ENTEGRASYON_POLICE_LOG");

                entity.Property(e => e.EntegrasyonPoliceLogId)
                    .HasColumnType("numeric(20, 0)")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ENTEGRASYON_POLICE_LOG_ID");

                entity.Property(e => e.EntegrasyonSablonTipId)
                    .HasColumnType("numeric(20, 0)")
                    .HasColumnName("ENTEGRASYON_SABLON_TIP_ID");

                entity.Property(e => e.EntegrasyonUrunId)
                    .HasColumnType("numeric(20, 0)")
                    .HasColumnName("ENTEGRASYON_URUN_ID");

                entity.Property(e => e.GuncellemeTarih)
                    .HasColumnType("datetime")
                    .HasColumnName("GUNCELLEME_TARIH");

                entity.Property(e => e.GuncellemeTarihNum)
                    .HasColumnType("numeric(14, 0)")
                    .HasColumnName("GUNCELLEME_TARIH_NUM");

                entity.Property(e => e.Guncelleyen)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("GUNCELLEYEN");

                entity.Property(e => e.Hata)
                    .IsUnicode(false)
                    .HasColumnName("HATA");

                entity.Property(e => e.PoliceGuid)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("POLICE_GUID");

                entity.Property(e => e.PoliceId)
                    .HasColumnType("numeric(20, 0)")
                    .HasColumnName("POLICE_ID");

                entity.Property(e => e.RequestTarih)
                    .HasColumnType("datetime")
                    .HasColumnName("REQUEST_TARIH");

                entity.Property(e => e.RequestXml)
                    .IsUnicode(false)
                    .HasColumnName("REQUEST_XML");

                entity.Property(e => e.ResponseTarih)
                    .HasColumnType("datetime")
                    .HasColumnName("RESPONSE_TARIH");

                entity.Property(e => e.ResponseXml)
                    .IsUnicode(false)
                    .HasColumnName("RESPONSE_XML");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
