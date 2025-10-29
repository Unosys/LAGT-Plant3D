// This file is auto-generated - do not hand edit this file.

using Autodesk.GUIHarness;
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{

    [UIElement(Tag = "[Window]Open Collaboration Project|$Window_1", Parent = typeof(MainWin), GUIType = GuiType.UIA)]
    public partial class OpenCollaborationProjectDLG : Autodesk.GUIHarness.AutoCAD.AcDialogBox
    {
        public  PushButton ClosePB;
        public  PushButton OpenProjectPB;
        public  TextField SearchTF;
        public  CustomWin SearchWIN;
        public  ListBoxItem AutoProject;
        public  ListBox ChooseAPlantProjectLB;

        partial void OnInitialize();

        public OpenCollaborationProjectDLG()
        {
            InitializeComponent();
            OnInitialize();
        }

        private void InitializeComponent()
        {

            ClosePB = new PushButton()
            {
                Tag = "[TitleBar]Collaboration for Plant 3D|$TitleBar|#1/[PushButton]Close|$Close|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ClosePB);

            OpenProjectPB = new PushButton()
            {
                Tag = "[CustomWin]$UserControl_1|#1/[PushButton]Open Project|$Button_Next|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(OpenProjectPB);

            SearchTF = new TextField()
            {
                Tag = "[CustomWin]$UserControl_1|#1/[CustomWin]$SearchProjectCtrl|#1/[TextField]$SearchText|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(SearchTF);

            SearchWIN = new CustomWin()
            {
                Tag = "[CustomWin]$UserControl_1|#1/[CustomWin]$SearchProjectCtrl|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(SearchWIN);

            AutoProject = new ListBoxItem()
            {
                Tag = "[CustomWin]$UserControl_1|#1/[ListBox]$ListBox_PlantProjects|#1/[ListBoxItem]#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(AutoProject);

            ChooseAPlantProjectLB = new ListBox()
            {
                Tag = "[CustomWin]$UserControl_1|#1/[ListBox]Loading Plant projects from 'LOC'*|$ListBox_PlantProjects|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ChooseAPlantProjectLB);
        }
    }
}
