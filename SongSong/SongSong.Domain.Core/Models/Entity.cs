﻿using System;
using System.Collections.Generic;
using System.Text;

namespace SongSong.Domain.Core.Models
{
    public abstract class Entity
    {
        public Guid Id { get; protected set; }
    }
}
