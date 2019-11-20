using Microsoft.AspNetCore.Mvc;
using SongSong.Application.Interfaces;
using SongSong.Application.Services;
using SongSong.Services.Api.Controllers;
using System;
using Xunit;

namespace SongSong.Tests
{
    public class ApiTests
    {
        ValuesController _controller;
        IAlbumAplicationService _service;
        
        //Construtor
        public ApiTests()
        {
            _service = new AlbumApplicationService();
            //Adicionar service no construtor da controller
            _controller = new ValuesController();
        }
        [Fact]
        public void Get_WhenCalled_Returns_Ok_Result()
        {
            var okResult = _controller.Get();

            Assert.IsType<OkObjectResult>(okResult.Result);
        }
    }
}
