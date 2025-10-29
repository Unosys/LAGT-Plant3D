// This file is auto-generated - do not hand edit this file.

using Autodesk.GUIHarness;
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{

    [UIElement(Tag = "[Window]Project Compare|$Window_1", Parent = typeof(MainWin), GUIType = GuiType.UIA)]
    public partial class ProjectCompareDLG : Autodesk.GUIHarness.AutoCAD.AcDialogBox
    {
        public  TitleBar ProjectCompareCTL;
        public  CustomWin SystemMenuBarWIN;
        public  MenuItem SystemMI;
        public  PushButton Close1PB;
        public  StaticText CompareTheCurrentProjectST;
        public  Image ImageIMG;
        public  StaticText ViewDifferencesOrSeeST;
        public  PushButton Close2PB;
        public  StaticText CloseST;
        public  PopupList LearnHowToCreatePL;
        public  PushButton ChooseAProjectToPB;
        public  StaticText ChooseAProjectToST;
        public  StaticText LearnHowToCreateST;
        public  Link LearnHowToCreateLINK;

        partial void OnInitialize();

        public ProjectCompareDLG()
        {
            InitializeComponent();
            OnInitialize();
        }

        private void InitializeComponent()
        {

            ProjectCompareCTL = new TitleBar()
            {
                Tag = "[TitleBar]Project Compare|$TitleBar|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ProjectCompareCTL);

            SystemMenuBarWIN = new CustomWin()
            {
                Tag = "[TitleBar]Project Compare|$TitleBar|#1/[CustomWin]System Menu Bar|$SystemMenuBar|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(SystemMenuBarWIN);

            SystemMI = new MenuItem()
            {
                Tag = "[TitleBar]Project Compare|$TitleBar|#1/[CustomWin]System Menu Bar|$SystemMenuBar|#1/[MenuItem]System|$Item 1|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(SystemMI);

            Close1PB = new PushButton()
            {
                Tag = "[TitleBar]Project Compare|$TitleBar|#1/[PushButton]Close|$Close|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Close1PB);

            CompareTheCurrentProjectST = new StaticText()
            {
                Tag = "[StaticText]Compare the Current Project*|$TextBlock_1|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(CompareTheCurrentProjectST);

            ImageIMG = new Image()
            {
                Tag = "[Image]$Image_1|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ImageIMG);

            ViewDifferencesOrSeeST = new StaticText()
            {
                Tag = "[StaticText]View differences or see what is missing from your current project*|$TextBlock_2|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ViewDifferencesOrSeeST);

            Close2PB = new PushButton()
            {
                Tag = "[PushButton]Close|$CloseButton|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Close2PB);

            CloseST = new StaticText()
            {
                Tag = "[PushButton]Close|$CloseButton|#1/[StaticText]Close|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(CloseST);

            LearnHowToCreatePL = new PopupList()
            {
                Tag = "[PopupList]$OpenProjectComboBox",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(LearnHowToCreatePL);

            ChooseAProjectToPB = new PushButton()
            {
                Tag = "[PushButton]Choose a Project to Compare|$OpenLocalDefaultButton|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ChooseAProjectToPB);

            ChooseAProjectToST = new StaticText()
            {
                Tag = "[PushButton]Choose a Project to Compare|$OpenLocalDefaultButton|#2/[StaticText]Choose a Project to Compare|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ChooseAProjectToST);

            LearnHowToCreateST = new StaticText()
            {
                Tag = "[StaticText]Learn how to create a project backup before you start*|$TextBlock_3|#3",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(LearnHowToCreateST);

            LearnHowToCreateLINK = new Link()
            {
                Tag = "[StaticText]Learn how to create a project backup before you start*|$TextBlock_3|#3/[Link]Learn how to create a project backup before you start*|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(LearnHowToCreateLINK);
        }
    }
}
