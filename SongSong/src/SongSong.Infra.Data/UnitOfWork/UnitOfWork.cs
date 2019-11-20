using SongSong.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace SongSong.Infra.Data.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {

        //Construtor
        public UnitOfWork()
        { }
        public bool Commit()
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}
