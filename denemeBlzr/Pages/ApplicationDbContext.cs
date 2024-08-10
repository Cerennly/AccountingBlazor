using Microsoft.EntityFrameworkCore;
using System.Data.Common;

namespace denemeBlzr.Pages
{
    public class ApplicationDbContext : DbContext
    {
        public virtual DbSet<Stok> Stoks { get; set; }
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }
    }
    public class Stok
    {
            public int Id { get; set; }

            public bool? Durum { get; set; }

            public string? StokKodu { get; set; }

            public string? StokAdi { get; set; }

            public string? Birimi { get; set; }

            public string? Modeli { get; set; }

            public string? StokGrubu { get; set; }

            public string? Marka { get; set; }

            public int? AlisKdv { get; set; }

            public int? SatisKdv { get; set; }

            public decimal? AlisFiyati1 { get; set; }

            public decimal? AlisFiyati2 { get; set; }

            public decimal? AlisFiyati3 { get; set; }

            public decimal? SatisFiyati1 { get; set; }

            public decimal? SatisFiyati2 { get; set; }

            public decimal? SatisFiyati3 { get; set; }

            public string? Aciklama { get; set; }

    }
}

