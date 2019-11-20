using Microsoft.Extensions.DependencyInjection;
using SongSong.Application.Interfaces;
using SongSong.Application.Services;
using SongSong.Domain.Interfaces;
using SongSong.Infra.Data.Context;
using SongSong.Infra.Data.UnitOfWork;
using System;

namespace SongSong.Infra.CrossCutting.IoC
{
    public class Bootstrapper
    {
        public static void RegisterServices(IServiceCollection service)
        {
            //Data
            service.AddScoped<IUnitOfWork, UnitOfWork>();
            service.AddScoped<SongSongContext>();

            //Application
            service.AddScoped<IAlbumAplicationService, AlbumApplicationService>();
        }
    }
}
