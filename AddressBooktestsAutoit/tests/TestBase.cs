﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace AddressBooktestsAutoit
{
    public class TestBase
    {
        public ApplicationManager app;

        [OneTimeSetUp]
        public void InitApplication() 
        {
            app = new ApplicationManager();
        }

        [OneTimeTearDown]
        public void StopApplication() 
        {
            app.Stop();
        }



    }
}
