

using System.Web.Mvc;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using Job_Candidate.Controllers;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Job_Candidate.Tests
{
    [TestClass]
    public class Candidate1
    {
        [TestMethod]
        public void TestMethod1()
        {

           var app = new Candidates1Controller();

            var result = app.Details(1) as ViewResult;

           
            var candidate = (Candidate)result.ViewData.Model;

            Assert.AreEqual("Carson", candidate.FirstName );

        }
    }
}
