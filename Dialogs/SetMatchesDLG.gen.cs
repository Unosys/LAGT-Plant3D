// This file is auto-generated - do not hand edit this file.

using Autodesk.GUIHarness;
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{

    [UIElement(Tag = "[Pane]Set Matches|$SetPropertyMatchesDlg", Parent = typeof(Pane), GUIType = GuiType.UIA)]
    public partial class SetMatchesDLG : Autodesk.GUIHarness.AutoCAD.AcDialogBox
    {
        public  PushButton CancelPB;
        public  PushButton OKPB;
        public  TextField SelectEndToMatchTF;
        public  RadioButton SelectEndToMatch1RB;
        public  RadioButton SelectEndToMatch2RB;
        public  RadioButton SelectEndToMatch3RB;
        public  RadioButton SelectEndToMatch4RB;
        public  StaticText SelectEndToMatchST;
        public  TitleBar SetMatchesCTL;
        public  PushButton ClosePB;

        partial void OnInitialize();

        public SetMatchesDLG()
        {
            InitializeComponent();
            OnInitialize();
        }

        private void InitializeComponent()
        {

            CancelPB = new PushButton()
            {
                Tag = "[PushButton]Cancel|$btnCancel|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(CancelPB);

            OKPB = new PushButton()
            {
                Tag = "[PushButton]OK|$btnOK|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(OKPB);

            SelectEndToMatchTF = new TextField()
            {
                Tag = "[TextField]Select end to match:|$txtboxValue|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(SelectEndToMatchTF);

            SelectEndToMatch1RB = new RadioButton()
            {
                Tag = "[RadioButton]Select end to match:|$rdobtnSetValue|#4",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(SelectEndToMatch1RB);

            SelectEndToMatch2RB = new RadioButton()
            {
                Tag = "[RadioButton]Select end to match:|$rdobtnEnd2|#3",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(SelectEndToMatch2RB);

            SelectEndToMatch3RB = new RadioButton()
            {
                Tag = "[RadioButton]Select end to match:|$rdobtnEnd1|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(SelectEndToMatch3RB);

            SelectEndToMatch4RB = new RadioButton()
            {
                Tag = "[RadioButton]Select end to match:|$rdobtnBoth|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(SelectEndToMatch4RB);

            SelectEndToMatchST = new StaticText()
            {
                Tag = "[StaticText]Select end to match:|$label1|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(SelectEndToMatchST);

            SetMatchesCTL = new TitleBar()
            {
                Tag = "[TitleBar]Set Matches|$TitleBar|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(SetMatchesCTL);

            ClosePB = new PushButton()
            {
                Tag = "[TitleBar]Set Matches|$TitleBar|#1/[PushButton]Close|$Close|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ClosePB);
        }
    }
}
