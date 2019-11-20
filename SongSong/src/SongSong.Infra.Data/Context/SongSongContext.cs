using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using SongSong.Domain.Models;
using SongSong.Infra.Data.Mappings;
using System;
using System.Collections.Generic;
using System.Text;

namespace SongSong.Infra.Data.Context
{
    public class SongSongContext : DbContext
    {
        private readonly IHostingEnvironment _env;

        public SongSongContext(IHostingEnvironment env)
        {
            _env = env;
        }
        public DbSet<Album> Albums { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new AlbumMap());

            base.OnModelCreating(modelBuilder);
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var config = new ConfigurationBuilder()
                .SetBasePath(_env.ContentRootPath)
                .AddJsonFile("appsettings.json")
                .Build();

            // escolher banco
            //optionsBuilder.UseSqlServer(config.GetConnectionString("DefaultConnection"));
        }
    }
}
