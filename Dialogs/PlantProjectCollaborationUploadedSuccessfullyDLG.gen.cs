// This file is auto-generated - do not hand edit this file.

using Autodesk.GUIHarness;
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{

    [UIElement(Tag = "[Window]$Window_1", Parent = typeof(MainWin), GUIType = GuiType.UIA)]
    public partial class PlantProjectCollaborationUploadedSuccessfullyDLG : Autodesk.GUIHarness.AutoCAD.AcDialogBox
    {
        public  PushButton Close1PB;
        public  PushButton Close2PB;
        public  PushButton InviteMyTeamPB;

        partial void OnInitialize();

        public PlantProjectCollaborationUploadedSuccessfullyDLG()
        {
            InitializeComponent();
            OnInitialize();
        }

        private void InitializeComponent()
        {

            Close1PB = new PushButton()
            {
                Tag = "[TitleBar]Collaboration for Plant 3D|$TitleBar|#1/[PushButton]Close|$Close|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Close1PB);

            Close2PB = new PushButton()
            {
                Tag = "[CustomWin]$UserControl_1|#1/[PushButton]Close|$Button_GetStarted|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Close2PB);

            InviteMyTeamPB = new PushButton()
            {
                Tag = "[CustomWin]$UserControl_1|#1/[PushButton]Invite my Team|$Button_InviteMyTeam|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(InviteMyTeamPB);
        }
    }
}
