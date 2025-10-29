// This file is auto-generated - do not hand edit this file.

using Autodesk.GUIHarness;
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{

    [UIElement(Tag = "[Pane]$AccessManagementDialog", Parent = typeof(VM_GlobalSettingsDLG))]
    public partial class VC_UserAndGroupManagementDLG_PageList : VC_UserAndGroupManagementDLG
    {
        public  PageList PageListPG;

        partial void OnInitialize();

        public VC_UserAndGroupManagementDLG_PageList()
        {
            InitializeComponent();
            OnInitialize();
        }

        private void InitializeComponent()
        {

            PageListPG = new PageList()
            {
                Tag = "[Pane]$tableLayoutPanel1/[PageList]$m_accesManagementTabControl",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(PageListPG);
        }
    }
}
