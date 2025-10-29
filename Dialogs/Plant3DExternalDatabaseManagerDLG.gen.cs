// This file is auto-generated - do not hand edit this file.

using Autodesk.GUIHarness;
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{

    [UIElement(Tag = "[DialogBox]Plant 3D - External Database Manager|#1", Parent = typeof(MainWin), GUIType = GuiType.WIN32)]
    public partial class Plant3DExternalDatabaseManagerDLG : Autodesk.GUIHarness.AutoCAD.AcDialogBox
    {
        public  PushButton OpenProjectSetuprecommendedPB;
        public  PushButton UseTheOldPLANTXDBMANAGERPB;
        public  PushButton CancelPB;

        partial void OnInitialize();

        public Plant3DExternalDatabaseManagerDLG()
        {
            InitializeComponent();
            OnInitialize();
        }

        private void InitializeComponent()
        {

            OpenProjectSetuprecommendedPB = new PushButton()
            {
                Tag = "[Pane]$Window|#1/[PushButton]$CommandLink_1001|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(OpenProjectSetuprecommendedPB);

            UseTheOldPLANTXDBMANAGERPB = new PushButton()
            {
                Tag = "[Pane]$Window|#1/[PushButton]$CommandLink_1002|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(UseTheOldPLANTXDBMANAGERPB);

            CancelPB = new PushButton()
            {
                Tag = "[Pane]$Window|#1/[PushButton]$CommandButton_2|#3",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(CancelPB);
        }
    }
}
