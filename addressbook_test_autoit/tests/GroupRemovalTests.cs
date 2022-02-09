using System;
using System.Collections.Generic;
using NUnit.Framework;

namespace addressbook_test_autoit
{
    [TestFixture]
    public class GroupRemovalTests : TestBase
    {
        [Test]
        public void TestGroupRemoval()
        {
            {
                List<GroupData> oldGroups = app.Groups.GetGroupList();
                GroupData GroupToDelete = new GroupData()
                {
                    Id = "0"
                };
                app.Groups.Remove(GroupToDelete);
                List<GroupData> newGroups = app.Groups.GetGroupList();
                oldGroups.Remove(oldGroups[0]);
                oldGroups.Sort();
                newGroups.Sort();
                Assert.AreEqual(oldGroups, newGroups);
            }
        }
    }
}


