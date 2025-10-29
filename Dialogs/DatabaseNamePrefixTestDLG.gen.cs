// This file is auto-generated - do not hand edit this file.

using Autodesk.GUIHarness;
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{

    [UIElement(Tag = "[DialogBox]Database Name Prefix Test", Parent = typeof(Plant3D), GUIType = GuiType.WIN32)]
    public partial class DatabaseNamePrefixTestDLG : Autodesk.GUIHarness.AutoCAD.AcDialogBox
    {
        public  Pane DatabaseNamePrefixTestPANE;
        public  Pane PanePANE;
        public  Image MainInstructionIconIMG;
        public  StaticText SuccessST;
        public  StaticText TheNameCanBeST;
        public  PushButton ClosePB;

        partial void OnInitialize();

        public DatabaseNamePrefixTestDLG()
        {
            InitializeComponent();
            OnInitialize();
        }

        private void InitializeComponent()
        {

            DatabaseNamePrefixTestPANE = new Pane()
            {
                Tag = "[Pane]Database Name Prefix Test|$Window|#1",
                ParentType = this.GetType(),
                Parent = this,
                GUIType = GuiType.UIA,
            };
            DeclaredChildren.Add(DatabaseNamePrefixTestPANE);

            PanePANE = new Pane()
            {
                Tag = "[Pane]Database Name Prefix Test|$Window|#1/[Pane]#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(PanePANE);

            MainInstructionIconIMG = new Image()
            {
                Tag = "[Pane]Database Name Prefix Test|$Window|#1/[Image]MainInstructionIcon|$MainIcon|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(MainInstructionIconIMG);

            SuccessST = new StaticText()
            {
                Tag = "[Pane]Database Name Prefix Test|$Window|#1/[StaticText]Success|$MainInstruction|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(SuccessST);

            TheNameCanBeST = new StaticText()
            {
                Tag = "[Pane]Database Name Prefix Test|$Window|#1/[StaticText]The name can be used and is available*|$ContentText|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(TheNameCanBeST);

            ClosePB = new PushButton()
            {
                Tag = "[Pane]Database Name Prefix Test|$Window|#1/[PushButton]Close|$CommandButton_8|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ClosePB);
        }
    }
}
