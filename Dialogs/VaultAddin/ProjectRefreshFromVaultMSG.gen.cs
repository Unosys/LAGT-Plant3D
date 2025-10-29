// This file is auto-generated - do not hand edit this file.

using Autodesk.GUIHarness;
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{

    [UIElement(Tag = "[DialogBox]Project Refresh from Vault Incomplete")]
    public partial class ProjectRefreshFromVaultMSG : Autodesk.GUIHarness.AutoCAD.AcDialogBox
    {
        public  Link LocalProjectFilesHaveLINK;
        public  PushButton OKPB;

        partial void OnInitialize();

        public ProjectRefreshFromVaultMSG()
        {
            InitializeComponent();
            OnInitialize();
        }

        private void InitializeComponent()
        {

            LocalProjectFilesHaveLINK = new Link()
            {
                Tag = "[Pane]#1/[Pane]#1/[Link]#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(LocalProjectFilesHaveLINK);

            OKPB = new PushButton()
            {
                Tag = "[Pane]$Window|#1/[PushButton]$CommandButton_1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(OKPB);
        }
    }
}
