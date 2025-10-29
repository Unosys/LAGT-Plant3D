// This file is auto-generated - do not hand edit this file.

using Autodesk.GUIHarness;
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{

    [UIElement(Tag = "[Pane]$AccessManagementDialog", Parent = typeof(VM_GlobalSettingsDLG))]
    public partial class VC_UserAndGroupManagementDLG : ProductTestSuite.CommonFiles.AdDialogBox
    {
        public  PushButton NewPB;
        public  PushButton ClosePB;
        public  ListBoxItem UserRow1WIN;

        partial void OnInitialize();

        public VC_UserAndGroupManagementDLG()
        {
            InitializeComponent();
            OnInitialize();
        }

        private void InitializeComponent()
        {

            NewPB = new PushButton()
            {
                Tag = "[GroupBox]#1/[ToolBar]#1/[PushButton]New*",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(NewPB);

            ClosePB = new PushButton()
            {
                Tag = "[Pane]$tableLayoutPanel1/[Pane]$panel1/[PushButton]$m_closeButton",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ClosePB);

            UserRow1WIN = new ListBoxItem()
            {
                Tag = "[Pane]$tableLayoutPanel1/[PageList]$m_accesManagementTabControl/[Pane]Users|$m_usersTabPage/[Pane]$m_usersTableLayoutPanel/[Pane]$m_userManagementGridControl/[Table]$m_gridControl/[CustomWin]#2/[ListBoxItem]Row 1|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(UserRow1WIN);
        }
    }
}
