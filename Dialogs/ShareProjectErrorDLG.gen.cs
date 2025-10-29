// This file is auto-generated - do not hand edit this file.

using Autodesk.GUIHarness;
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{

    [UIElement(Tag = "[Window]Plant Project Collaboration|$Window_1", Parent = typeof(MainWin), GUIType = GuiType.UIA)]
    public partial class ShareProjectErrorDLG : Autodesk.GUIHarness.AutoCAD.AcDialogBox
    {
        public  TitleBar PlantProjectCollaborationCTL;
        public  CustomWin SystemMenuBarWIN;
        public  MenuItem SystemMI;
        public  PushButton ClosePB;
        public  CustomWin CustomWinWIN;
        public  StaticText SharePlantProjectErrorST;
        public  StaticText OneOrMoreProjectsST;

        partial void OnInitialize();

        public ShareProjectErrorDLG()
        {
            InitializeComponent();
            OnInitialize();
        }

        private void InitializeComponent()
        {

            PlantProjectCollaborationCTL = new TitleBar()
            {
                Tag = "[TitleBar]Plant Project Collaboration|$TitleBar|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(PlantProjectCollaborationCTL);

            SystemMenuBarWIN = new CustomWin()
            {
                Tag = "[TitleBar]Plant Project Collaboration|$TitleBar|#1/[CustomWin]System Menu Bar|$SystemMenuBar|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(SystemMenuBarWIN);

            SystemMI = new MenuItem()
            {
                Tag = "[TitleBar]Plant Project Collaboration|$TitleBar|#1/[CustomWin]System Menu Bar|$SystemMenuBar|#1/[MenuItem]System|$Item 1|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(SystemMI);

            ClosePB = new PushButton()
            {
                Tag = "[TitleBar]Plant Project Collaboration|$TitleBar|#1/[PushButton]Close|$Close|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ClosePB);

            CustomWinWIN = new CustomWin()
            {
                Tag = "[CustomWin]$UserControl_1|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(CustomWinWIN);

            SharePlantProjectErrorST = new StaticText()
            {
                Tag = "[CustomWin]$UserControl_1|#1/[StaticText]Share Plant Project Error*|$TextBlock_1|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(SharePlantProjectErrorST);

            OneOrMoreProjectsST = new StaticText()
            {
                Tag = "[CustomWin]$UserControl_1|#1/[StaticText]One or more projects drawings are open*|$TextBlock_2|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(OneOrMoreProjectsST);
        }
    }
}
