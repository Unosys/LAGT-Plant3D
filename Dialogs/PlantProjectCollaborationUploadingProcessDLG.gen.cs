// This file is auto-generated - do not hand edit this file.

using Autodesk.GUIHarness;
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{

    [UIElement(Tag = "[Window]Plant Project Collaboration|$Window_1", Parent = typeof(MainWin), GUIType = GuiType.UIA)]
    public partial class PlantProjectCollaborationUploadingProcessDLG : Window
    {
        public  TitleBar PlantProjectCollaborationCTL;
        public  CustomWin SystemMenuBarWIN;
        public  MenuItem SystemMI;
        public  PushButton ClosePB;
        public  CustomWin CustomWin1WIN;
        public  Image ImageIMG;
        public  StaticText UploadingProjectToTheST;
        public  PushButton WhyNotReadUpPB;
        public  StaticText WhyNotReadUpST;
        public  StaticText UploadingFilesToBIMST;
        public  CustomWin CustomWin2WIN;
        public  StaticText NozzleListxmlST;

        partial void OnInitialize();

        public PlantProjectCollaborationUploadingProcessDLG()
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

            CustomWin1WIN = new CustomWin()
            {
                Tag = "[CustomWin]$UserControl_1|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(CustomWin1WIN);

            ImageIMG = new Image()
            {
                Tag = "[CustomWin]$UserControl_1|#1/[Image]$Image_1|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ImageIMG);

            UploadingProjectToTheST = new StaticText()
            {
                Tag = "[CustomWin]$UserControl_1|#1/[StaticText]Uploading project to the cloud*|$TextBlock_1|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(UploadingProjectToTheST);

            WhyNotReadUpPB = new PushButton()
            {
                Tag = "[CustomWin]$UserControl_1|#1/[PushButton]Why not read up on working with BIM 360 Team projects while you wait?|$Button_LearnMore|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(WhyNotReadUpPB);

            WhyNotReadUpST = new StaticText()
            {
                Tag = "[CustomWin]$UserControl_1|#1/[PushButton]Why not read up on working with BIM 360 Team projects while you wait?|$Button_LearnMore|#1/[StaticText]Why not read up on working with BIM 360 Team projects while you wait?|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(WhyNotReadUpST);

            UploadingFilesToBIMST = new StaticText()
            {
                Tag = "[CustomWin]$UserControl_1|#1/[StaticText]Uploading files to BIM 360 Team project*|$TextBlock_2|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(UploadingFilesToBIMST);

            CustomWin2WIN = new CustomWin()
            {
                Tag = "[CustomWin]$UserControl_1|#1/[CustomWin]$ProgressBar_1|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(CustomWin2WIN);

            NozzleListxmlST = new StaticText()
            {
                Tag = "[CustomWin]$UserControl_1|#1/[StaticText]NozzleList*|$TextBlock_3|#3",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(NozzleListxmlST);
        }
    }
}
