// This file is auto-generated - do not hand edit this file.

using Autodesk.GUIHarness;
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{

    [UIElement(Tag = "[Window]Plant Project Collaboration|$Window_1", Parent = typeof(MainWin), GUIType = GuiType.UIA)]
    public partial class PlantProjectCollaborationChooseTeamDLG : Window
    {
        public  TitleBar PlantProjectCollaborationCTL;
        public  CustomWin SystemMenuBarWIN;
        public  MenuItem SystemMI;
        public  PushButton ClosePB;
        public  CustomWin CustomWinWIN;
        public  Image ImageIMG;
        public  StaticText StaticTextST;
        public  PopupList PopupListPL;
        public  StaticText ChooseABIM360ST;
        public  PushButton UploadProjectPB;
        public  StaticText UploadProjectST;
        public  StaticText WellSendACopyST;
        public  ListBox ChooseABIM360LB;
        public  ListBoxItem AutodeskProcessPowerCloudServiceCloudDocA360ProjectLBI;
        public  TreeView TreeViewTV;
        public  TreeViewItem LocTVI;
        public  StaticText P3DST;

        partial void OnInitialize();

        public PlantProjectCollaborationChooseTeamDLG()
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

            ImageIMG = new Image()
            {
                Tag = "[CustomWin]$UserControl_1|#1/[Image]$Image_1|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ImageIMG);

            StaticTextST = new StaticText()
            {
                Tag = "[CustomWin]$UserControl_1|#1/[StaticText]>|$TextBlock_4|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(StaticTextST);

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

            UploadProjectPB = new PushButton()
            {
                Tag = "[CustomWin]$UserControl_1|#1/[PushButton]Upload Project|$Button_Next|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(UploadProjectPB);

            UploadProjectST = new StaticText()
            {
                Tag = "[CustomWin]$UserControl_1|#1/[PushButton]Upload Project|$Button_Next|#1/[StaticText]Upload Project|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(UploadProjectST);

            WellSendACopyST = new StaticText()
            {
                Tag = "[CustomWin]$UserControl_1|#1/[StaticText]We'll send a copy of your current project to the cloud, but your original project will remain untouched*|$Button_LearnMore|#3",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(WellSendACopyST);

            ChooseABIM360LB = new ListBox()
            {
                Tag = "[CustomWin]$UserControl_1|#1/[ListBox]Choose a BIM 360 Team project folder:|$ComboBox_PA360Projects|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ChooseABIM360LB);

            AutodeskProcessPowerCloudServiceCloudDocA360ProjectLBI = new ListBoxItem()
            {
                Tag = "[CustomWin]$UserControl_1|#1/[ListBox]Choose a BIM 360 Team project folder:|$ComboBox_PA360Projects|#1/[ListBoxItem]Autodesk*|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(AutodeskProcessPowerCloudServiceCloudDocA360ProjectLBI);

            TreeViewTV = new TreeView()
            {
                Tag = "[CustomWin]$UserControl_1|#1/[TreeView]$TreeView_ACCProjectFolders|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(TreeViewTV);

            LocTVI = new TreeViewItem()
            {
                Tag = "[CustomWin]$UserControl_1|#1/[TreeView]$TreeView_ACCProjectFolders|#1/[TreeViewItem]#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(LocTVI);

            P3DST = new StaticText()
            {
                Tag = "[CustomWin]$UserControl_1|#1/[ListBox]Choose a BIM 360 Team project folder:|$ComboBox_PA360Projects|#1/[ListBoxItem]Autodesk*|#1/[StaticText]P3D|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(P3DST);
        }
    }
}
