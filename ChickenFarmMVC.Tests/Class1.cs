using System;
using System.Web.Mvc;
using ChickenFarmMVC.Controllers;
using Xunit;
using System.Collections;
using ChickenFarmMVC.Models;
using System.Collections.Generic;

namespace ChickenFarmMVC.Tests
{
    public class AboutTests: IDisposable
    {
        [Fact]
        public void AboutControllerReturnsChickenFarmers()
        {
            HomeController hc = new HomeController();
            var result = hc.About() as ViewResult;
            var data = (List<Farmer>)result.ViewData.Model;
            
            Assert.Equal("About", result.ViewName);
            Assert.Equal(2, data.Count);
            
        }
        
        public void Dispose()
        {
            //Dispose of tests
        }

    }
}
