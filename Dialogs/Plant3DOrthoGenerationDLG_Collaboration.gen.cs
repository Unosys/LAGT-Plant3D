// This file is auto-generated - do not hand edit this file.

using Autodesk.GUIHarness;
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{

    [UIElement(Tag = "[Window]Plant 3D - Ortho Generation|$OrthoUpdateDlg", Parent = typeof(MainWin), GUIType = GuiType.UIA)]
    public partial class Plant3DOrthoGenerationDLG_Collaboration : Autodesk.GUIHarness.AutoCAD.AcDialogBox
    {
        public  CheckBox CheckBox1CK;
        public  CheckBox CheckBox2CK;
        public  PushButton CancelPB;
        public  PushButton UpdatePB;
        public  PushButton ClosePB;
        public  PushButton Close2PB;

        partial void OnInitialize();

        public Plant3DOrthoGenerationDLG_Collaboration()
        {
            InitializeComponent();
            OnInitialize();
        }

        private void InitializeComponent()
        {

            CheckBox1CK = new CheckBox()
            {
                Tag = "[CustomWin]$StartPage|#1/[CheckBox]$OptionCheckBox|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(CheckBox1CK);

            CheckBox2CK = new CheckBox()
            {
                Tag = "[CustomWin]$StartPage|#1/[CheckBox]$OptionCheckBox|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(CheckBox2CK);

            CancelPB = new PushButton()
            {
                Tag = "[CustomWin]$StartPage|#1/[PushButton]Cancel|$CancelButton|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(CancelPB);

            UpdatePB = new PushButton()
            {
                Tag = "[CustomWin]$StartPage|#1/[PushButton]Update|$UpdateButton|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(UpdatePB);

            ClosePB = new PushButton()
            {
                Tag = "[TitleBar]$TitleBar|#1/[PushButton]$Close|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ClosePB);

            Close2PB = new PushButton()
            {
                Tag = "[CustomWin]$SuccessPage|#1/[PushButton]$CloseButton|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Close2PB);
        }
    }
}
