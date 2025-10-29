// This file is auto-generated - do not hand edit this file.

using Autodesk.GUIHarness;
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{

    [UIElement(Tag = "[DialogBox]#1", Parent = typeof(MainWin), GUIType = GuiType.UIA)]
    public partial class ValveOperatorMappingWarningDLG : Autodesk.GUIHarness.AutoCAD.AcDialogBox
    {
        public  PushButton OKPB;
        public  PushButton ClosePB;

        partial void OnInitialize();

        public ValveOperatorMappingWarningDLG()
        {
            InitializeComponent();
            OnInitialize();
        }

        private void InitializeComponent()
        {

            OKPB = new PushButton()
            {
                Tag = "[PushButton]OK|$2|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(OKPB);

            ClosePB = new PushButton()
            {
                Tag = "[TitleBar]$TitleBar|#1/[PushButton]Close|$Close|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ClosePB);
        }
    }
}
