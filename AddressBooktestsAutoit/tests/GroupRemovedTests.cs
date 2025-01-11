using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using NUnit.Framework;

namespace AddressBooktestsAutoit
{
    [TestFixture]
    public class GroupRemovedTests : TestBase
    {

        [Test]
        public void TestRemovedGroup()
        {
            List<GroupData> oldGroups = app.Groups.GetGroupList();

            GroupData groupDelete = new GroupData()
            {
                Name = "test"
            };

            app.Groups.RemovedGroup(groupDelete);

            List<GroupData> newGroups = app.Groups.GetGroupList();
            int oldGroups2 = oldGroups.Count -1 ;
           
            Assert.AreEqual(oldGroups2, newGroups.Count);

        }




    }
}
