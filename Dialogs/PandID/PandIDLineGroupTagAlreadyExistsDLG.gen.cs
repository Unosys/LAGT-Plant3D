// This file is auto-generated - do not hand edit this file.

using Autodesk.GUIHarness;
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{

    [UIElement(Tag = "[DialogBox]Tag Already Assigned|#1", Parent = typeof(Pane), GUIType = GuiType.UIA)]
    public partial class PandIDLineGroupTagAlreadyExistsDLG : Autodesk.GUIHarness.AutoCAD.AcDialogBox
    {
        public  PushButton OKPB;
        public  StaticText NoTwoSchematicLineST;
        public  TitleBar TagAlreadyAssignedCTL;
        public  PushButton ClosePB;

        partial void OnInitialize();

        public PandIDLineGroupTagAlreadyExistsDLG()
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

            NoTwoSchematicLineST = new StaticText()
            {
                Tag = "[StaticText]No two schematic line groups can have the same tag*|$65535|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(NoTwoSchematicLineST);

            TagAlreadyAssignedCTL = new TitleBar()
            {
                Tag = "[TitleBar]Tag Already Assigned|$TitleBar|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(TagAlreadyAssignedCTL);

            ClosePB = new PushButton()
            {
                Tag = "[TitleBar]Tag Already Assigned|$TitleBar|#1/[PushButton]Close|$Close|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ClosePB);
        }
    }
}
