namespace ETİCARET.DAL.entityFrameWork
{
    using MODEL;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.ModelConfiguration.Conventions;
    using System.Linq;

    public class eticaret : DbContext
    {
        // Your context has been configured to use a 'eticaret' connection string from your application's 
        // configuration file (App.config or Web.config). By default, this connection string targets the 
        // 'ETİCARET.DAL.entityFrameWork.eticaret' database on your LocalDb instance. 
        // 
        // If you wish to target a different database and/or database provider, modify the 'eticaret' 
        // connection string in the application configuration file.
        public eticaret()
            : base("name=eticaret")
        {
            #region Veritabanı oluşturma stratejileri
            //son migrationa göre veritabanını güncelle
            //Database.SetInitializer<eticaret>(new MigrateDatabaseToLatestVersion<eticaret, Configuration>());
            //her çalışmada veritabanını sil yeniden yarat
            //Database.SetInitializer<eticaret>(new DropCreateDatabaseAlways<eticaret>());
            //eğer model değişirse veritabanını sil yeniden yarat
            //Database.SetInitializer<eticaret>(new DropCreateDatabaseIfModelChanges<eticaret>());
            //eğer veritabanı yoksa yarat 
            #endregion
            Database.SetInitializer<eticaret>(new CreateDatabaseIfNotExists<eticaret>());
        }

        // Add a DbSet for each entity type that you want to include in your model. For more information 
        // on configuring and using a Code First model, see http://go.microsoft.com/fwlink/?LinkId=390109.

        public virtual DbSet<ayarlar> ayarlar { get; set; }
        public virtual DbSet<kargoBilgileri> kargoBilgileri { get; set; }
        public virtual DbSet<kategori> kategori { get; set; }
        public virtual DbSet<Kullanici> Kullanici { get; set; }
        public virtual DbSet<kullaniciRol> kullaniciRol { get; set; }
        public virtual DbSet<marka> marka { get; set; }
        public virtual DbSet<Rol> Rol { get; set; }
        public virtual DbSet<satis> satis { get; set; }
        public virtual DbSet<sepet> sepet { get; set; }
        public virtual DbSet<sepetSiparis> sepetSiparis { get; set; }
        public virtual DbSet<urun> urun { get; set; }
        public virtual DbSet<urunOzellikleri> urunOzellikleri { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //tablo yaratırken isimleri çoğullaştırmasın diye ekliyorum , bu algoritmayı kaldırmış oluyorum
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            base.OnModelCreating(modelBuilder);
        }
    }
     
    //public class MyEntity
    //{
    //    public int Id { get; set; }
    //    public string Name { get; set; }
    //}
}