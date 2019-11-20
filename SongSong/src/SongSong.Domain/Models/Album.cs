using SongSong.Domain.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace SongSong.Domain.Models
{
    public class Album : Entity
    {
        public Album(Guid id, string name, decimal price = 0)
        {
            Id = id;
            Name = name;
            Price = price;
        }

        //Construtor EF
        public Album() { }

        public string Name { get; set; }
        public decimal? Price { get; set; }
    }
}
