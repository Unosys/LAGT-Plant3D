// This file is auto-generated - do not hand edit this file.

using Autodesk.GUIHarness;
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{

    [UIElement(Tag = "[DialogBox]Tag in Use|#1", Parent = typeof(Pane), GUIType = GuiType.UIA)]
    public partial class PandIDTagInUse : Autodesk.GUIHarness.AutoCAD.AcDialogBox
    {
        public  PushButton OKPB;
        public  StaticText AnotherSchematicLineGroupST;
        public  TitleBar TagInUseCTL;
        public  PushButton ClosePB;

        partial void OnInitialize();

        public PandIDTagInUse()
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

            AnotherSchematicLineGroupST = new StaticText()
            {
                Tag = "[StaticText]Another schematic line group in the project has the same tag which has not been saved*|$65535|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(AnotherSchematicLineGroupST);

            TagInUseCTL = new TitleBar()
            {
                Tag = "[TitleBar]Tag in Use|$TitleBar|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(TagInUseCTL);

            ClosePB = new PushButton()
            {
                Tag = "[TitleBar]Tag in Use|$TitleBar|#1/[PushButton]Close|$Close|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ClosePB);
        }
    }
}
