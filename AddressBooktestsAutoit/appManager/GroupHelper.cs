




using System;
using System.Collections.Generic;
using System.Reflection;

namespace AddressBooktestsAutoit
{
    public class GroupHelper : HelperBase
    {
        public static string GROUPWINTITLE = "Group editor";
        public GroupHelper(ApplicationManager manager) : base(manager) { }

        public void Add(GroupData newGroup)
        {
            OpenGroupsDialog();
            aux.ControlClick(GROUPWINTITLE, "", "WindowsForms10.BUTTON.app.0.2c908d53");

            manager.Aux.Send(newGroup.Name);
                                             
            aux.Send("{ENTER}");
            CloseGroupDialog();
        }
      



        private void CloseGroupDialog()
        {
            aux.ControlClick(GROUPWINTITLE, "", "WindowsForms10.BUTTON.app.0.2c908d54");
        }

        private void OpenGroupsDialog()
        {
            aux.ControlClick(WINTITLE, "", "WindowsForms10.BUTTON.app.0.2c908d512");
            aux.WinWait(GROUPWINTITLE);
        }

        public List<GroupData> GetGroupList()
        {
            List<GroupData> list = new List<GroupData>();   
            OpenGroupsDialog();
           string count= aux.ControlTreeView(GROUPWINTITLE, "", "WindowsForms10.SysTreeView32.app.0.2c908d51",
                "GetItemCount", "#0","");
            for (int i = 0; i < int.Parse(count); i++) 
            {
                string item = aux.ControlTreeView(GROUPWINTITLE, "", "WindowsForms10.SysTreeView32.app.0.2c908d51",
                                "GetText", "#0|#"+i, "");

                list.Add(new GroupData()
                {
                    Name = item


                });
            }
            CloseGroupDialog();
            return list;
        }

        public void RemovedGroup2()
        {
            OpenGroupsDialog();

            //выбрать группу            
            aux.ControlTreeView(GROUPWINTITLE, "", "WindowsForms10.SysTreeView32.app.0.2c908d51", "Select", "#0|#0", ""); ;

            //кликнуть удалить
            aux.ControlClick(GROUPWINTITLE, "", "WindowsForms10.BUTTON.app.0.2c908d51");
            aux.WinWait("Delete group");
            aux.WinActivate("Delete group");
            aux.WinWaitActive("Delete group");
            //подтвердить удаление
            aux.ControlClick("Delete group", "", "WindowsForms10.BUTTON.app.0.2c908d53");


            //aux.WinWait("GROUPWINTITLE");
            //aux.WinActivate("GROUPWINTITLE");
            //aux.WinWaitActive("GROUPWINTITLE");
            CloseGroupDialog();
        }



    }
}