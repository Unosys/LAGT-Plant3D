// This file is auto-generated - do not hand edit this file.

using Autodesk.GUIHarness;
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{

    [UIElement(Tag = "[Window]Plant Project Collaboration|$Window_1", Parent = typeof(MainWin), GUIType = GuiType.UIA)]
    public partial class PlantProjectCollaborationCannotFindTeamDLG : Autodesk.GUIHarness.AutoCAD.AcDialogBox
    {
        public  TitleBar PlantProjectCollaborationCTL;
        public  CustomWin SystemMenuBarWIN;
        public  PushButton ClosePB;
        public  PopupList PopupListPL;
        public  StaticText ChooseABIM360ST;
        public  ListBox ChooseABIM360LB;
        public  PushButton CreateABIMTeamPB;
        public  TextField TextFieldTF;

        partial void OnInitialize();

        public PlantProjectCollaborationCannotFindTeamDLG()
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

            ClosePB = new PushButton()
            {
                Tag = "[TitleBar]Plant Project Collaboration|$TitleBar|#1/[PushButton]Close|$Close|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ClosePB);

            PopupListPL = new PopupList()
            {
                Tag = "[CustomWin]$UserControl_1|#1/[PopupList]$ComboBox_1|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(PopupListPL);

            ChooseABIM360ST = new StaticText()
            {
                Tag = "[CustomWin]$UserControl_1|#1/[StaticText]Choose a BIM 360 Team project folder:|$TextBlock_1|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ChooseABIM360ST);

            ChooseABIM360LB = new ListBox()
            {
                Tag = "[CustomWin]$UserControl_1|#1/[ListBox]Choose a BIM 360 Team project folder:|$ComboBox_PA360Projects|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ChooseABIM360LB);

            CreateABIMTeamPB = new PushButton()
            {
                Tag = "[CustomWin]$UserControl_1|#1/[PushButton]Create a BIM Team project for this hub|$Button_1|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(CreateABIMTeamPB);

            TextFieldTF = new TextField()
            {
                Tag = "[CustomWin]$UserControl_1|#1/[CustomWin]$SearchProjectCtrl|#1/[TextField]$SearchText|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(TextFieldTF);
        }
    }
}
