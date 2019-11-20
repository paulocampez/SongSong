using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SongSong.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace SongSong.Infra.Data.Mappings
{
    public class AlbumMap : IEntityTypeConfiguration<Album>
    {
        public void Configure(EntityTypeBuilder<Album> builder)
        {
            builder.Property(c => c.Id)
           .HasColumnName("Id");

            builder.Property(c => c.Name)
             .HasColumnType("varchar(100)")
             .HasMaxLength(100)
             .IsRequired();

            builder.Property(c => c.Price)
            .HasColumnType("decimal(5,2)")
            .IsRequired(true);
        }
    }
}
