﻿using System;
using System.Collections.Generic;
using NUnit.Framework;
//using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AddressBooktestsAutoit
{
    [TestFixture]
    public class GroupCreationTests: TestBase
    {
        [Test]
        public void TestGroupCreation()
        {
            List<GroupData> oldGroups = app.Groups.GetGroupList();

            GroupData newGroup = new GroupData() 
            {
            Name = "test"
            };

            app.Groups.Add(newGroup);

            List<GroupData> newGroups = app.Groups.GetGroupList();
            oldGroups.Add(newGroup);
            oldGroups.Sort();
            newGroups.Sort();
            Assert.AreEqual(oldGroups, newGroups);

        }
    }
}
