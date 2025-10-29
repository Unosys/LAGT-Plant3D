// This file is auto-generated - do not hand edit this file.

using Autodesk.GUIHarness;
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{

    [UIElement(Tag = "[DialogBox]AutoCAD Plant 3D", Parent = typeof(MainWin), GUIType = GuiType.UIA)]
    public partial class RCFConvertToRCFXMSG : Autodesk.GUIHarness.AutoCAD.AcDialogBox
    {
        public  PushButton AutomaticallyConvertTheSelectedPB;
        public  PushButton ChooseAnotherFilePB;
        public  PushButton CancelPB;
        public  PushButton ClosePB;

        partial void OnInitialize();

        public RCFConvertToRCFXMSG()
        {
            InitializeComponent();
            OnInitialize();
        }

        private void InitializeComponent()
        {

            AutomaticallyConvertTheSelectedPB = new PushButton()
            {
                Tag = "[Pane]AutoCAD Plant 3D|$Window|#1/[PushButton]Automatically convert the selected file(recommended)|$CommandLink_1001|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(AutomaticallyConvertTheSelectedPB);

            ChooseAnotherFilePB = new PushButton()
            {
                Tag = "[Pane]AutoCAD Plant 3D|$Window|#1/[PushButton]Choose another file|$CommandLink_1003|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ChooseAnotherFilePB);

            CancelPB = new PushButton()
            {
                Tag = "[Pane]AutoCAD Plant 3D|$Window|#1/[PushButton]Cancel|$CommandButton_2|#3",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(CancelPB);

            ClosePB = new PushButton()
            {
                Tag = "[TitleBar]AutoCAD Plant 3D|$TitleBar|#1/[PushButton]Close|$Close|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ClosePB);
        }
    }
}
