using System;
using System.Collections.Generic;
using System.Text;

namespace SongSong.Domain.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        bool Commit();
    }
}
