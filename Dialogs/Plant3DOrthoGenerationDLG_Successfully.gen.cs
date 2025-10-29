// This file is auto-generated - do not hand edit this file.

using Autodesk.GUIHarness;
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{

    [UIElement(Tag = "Plant 3D - Ortho Generation|$OrthoUpdateDlg")]
    public partial class Plant3DOrthoGenerationDLG_Successfully : Autodesk.GUIHarness.AutoCAD.AcDialogBox
    {
        public  PushButton ClosePB;
        public  PushButton Close1PB;
        public  Link LogFileLINK;

        partial void OnInitialize();

        public Plant3DOrthoGenerationDLG_Successfully()
        {
            InitializeComponent();
            OnInitialize();
        }

        private void InitializeComponent()
        {

            ClosePB = new PushButton()
            {
                Tag = "[CustomWin]$SuccessPage|#1/[PushButton]$CloseButton",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ClosePB);

            Close1PB = new PushButton()
            {
                Tag = "[TitleBar]Plant 3D - Ortho Generation|$TitleBar|#1/[PushButton]Close|$Close|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Close1PB);

            LogFileLINK = new Link()
            {
                Tag = "[CustomWin]$SuccessPage|#1/[StaticText]$LogFileText|#3/[Link]$LogFileHyperlink|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(LogFileLINK);
        }
    }
}
