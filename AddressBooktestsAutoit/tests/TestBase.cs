using System;
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

        [SetUp]
        public void initApplication() 
        {
            app = new ApplicationManager();
        }

        [TearDown]
        public void stopApplication() 
        {
            app.Stop();
        }



    }
}
