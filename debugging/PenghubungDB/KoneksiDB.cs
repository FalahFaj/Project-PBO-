using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using debugging.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Internal;
using Microsoft.Extensions.Logging;
using Project_PBO_Kel_5.Model;

namespace debugging.PenghubungDB
{
    public class KoneksiDB : DbContext
    {
        public DbSet<Produk> produk { get; set; }
        public DbSet<Akun_admin> akun_admin { get; set; }
        public DbSet<Customer> customer { get; set; }
        public DbSet<Item_penyewaan> item_penyewaan { get; set; }
        public DbSet<Kategori> kategori { get; set; }
        public DbSet<Model.Penyewaan> penyewaan { get; set; }
        public DbSet<Item_transaksi> item_transaksi { get; set; }
        public DbSet<Detail_keranjang> detail_keranjang { get; set; }
        public DbSet<Metode_pembayaran> metode_pembayaran { get; set; }
        public DbSet<Transaksi> transaksi { get; set; }
        public DbSet<Data_chat> data_chat { get; set; }
        public DbSet<Keranjang> keranjang { get; set; }
        public DbSet<Jenis_transaksi> jenis_transaksi { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string koneksiDB = ConfigurationManager.ConnectionStrings["KoneksiDB"].ConnectionString;
            optionsBuilder.UseNpgsql(koneksiDB)
                .LogTo(Console.WriteLine, LogLevel.Information);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Kategori  
            modelBuilder.Entity<Kategori>()
                .HasKey(k => k.id_kategori);

            // Produk  
            modelBuilder.Entity<Produk>()
                .HasOne(p => p.kategori)
                .WithMany(k => k.produk)
                .HasForeignKey(p => p.id_kategori);

            // Akun Admin  
            modelBuilder.Entity<Akun_admin>()
                .HasKey(a => a.id_admin);

            // Customer  
            modelBuilder.Entity<Customer>();

            // Transaksi  
            modelBuilder.Entity<Transaksi>();

            // Data Chat  
            modelBuilder.Entity<Data_chat>()
                .HasOne(dc => dc.customer)
                .WithMany(c => c.data_chat)
                .HasForeignKey(dc => dc.id_customer);

            // Daftar Transaksi  
            modelBuilder.Entity<Item_penyewaan>();

            // Item Transaksi  
            modelBuilder.Entity<Item_transaksi>();

            // Metode Pembayaran  
            modelBuilder.Entity<Metode_pembayaran>();

            // Penyewaan  
            modelBuilder.Entity<Model.Penyewaan>();

            // Keranjang  
            modelBuilder.Entity<Keranjang>();

            modelBuilder.Entity<Detail_keranjang>()
                .HasOne(dk => dk.Keranjang)
                .WithMany(k => k.detail_keranjang)
                .HasForeignKey(dk => dk.id_keranjang);

            // Jenis Transaksi  
            modelBuilder.Entity<Jenis_transaksi>();
        }
    }
}
