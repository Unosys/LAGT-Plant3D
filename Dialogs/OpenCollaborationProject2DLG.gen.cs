// This file is auto-generated - do not hand edit this file.

using Autodesk.GUIHarness;
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{

    [UIElement(Tag = "[Window]Open Collaboration Project|$Window_1", Parent = typeof(MainWin), GUIType = GuiType.UIA)]
    public partial class OpenCollaborationProject2DLG : Autodesk.GUIHarness.AutoCAD.AcDialogBox
    {
        public  TitleBar OpenCollaborationProjectCTL;
        public  CustomWin SystemMenuBarWIN;
        public  MenuItem SystemMI;
        public  PushButton ClosePB;
        public  CustomWin CustomWinWIN;
        public  PushButton OpenProjectPB;
        public  StaticText OpenProjectST;
        public  Image ImageIMG;
        public  StaticText StaticText1ST;
        public  PopupList PopupList1PL;
        public  StaticText StaticText2ST;
        public  PopupList PopupList2PL;
        public  StaticText ChooseAPlantProjectST;
        public  ListBox ChooseAPlantProjectLB;
        public  ListBoxItem AutodeskProcessPowerCloudServiceCloudDocProject1LBI;
        public  StaticText CHS0001ST;
        public  ListBoxItem AutodeskProcessPowerCloudServiceCloudDocProject2LBI;
        public  StaticText CHSMetric001ST;
        public  ListBoxItem AutodeskProcessPowerCloudServiceCloudDocProject3LBI;
        public  StaticText DEU0001ST;
        public  ListBoxItem AutodeskProcessPowerCloudServiceCloudDocProject4LBI;
        public  StaticText FRA001ST;
        public  ListBoxItem AutodeskProcessPowerCloudServiceCloudDocProject5LBI;
        public  StaticText ImperialST;
        public  ListBoxItem AutodeskProcessPowerCloudServiceCloudDocProject6LBI;
        public  StaticText ImperialENU03ST;
        public  ListBoxItem AutodeskProcessPowerCloudServiceCloudDocProject7LBI;
        public  StaticText ImperialENU04ST;
        public  ListBoxItem AutodeskProcessPowerCloudServiceCloudDocProject8LBI;
        public  StaticText ImperialENU05ST;
        public  ListBoxItem AutodeskProcessPowerCloudServiceCloudDocProject9LBI;
        public  StaticText JPN1ST;
        public  ListBoxItem AutodeskProcessPowerCloudServiceCloudDocProject10LBI;
        public  StaticText KOR0001ST;
        public  ListBoxItem AutodeskProcessPowerCloudServiceCloudDocProject11LBI;
        public  StaticText RUS0001ST;

        partial void OnInitialize();

        public OpenCollaborationProject2DLG()
        {
            InitializeComponent();
            OnInitialize();
        }

        private void InitializeComponent()
        {

            OpenCollaborationProjectCTL = new TitleBar()
            {
                Tag = "[TitleBar]Open Collaboration Project|$TitleBar|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(OpenCollaborationProjectCTL);

            SystemMenuBarWIN = new CustomWin()
            {
                Tag = "[TitleBar]Open Collaboration Project|$TitleBar|#1/[CustomWin]System Menu Bar|$SystemMenuBar|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(SystemMenuBarWIN);

            SystemMI = new MenuItem()
            {
                Tag = "[TitleBar]Open Collaboration Project|$TitleBar|#1/[CustomWin]System Menu Bar|$SystemMenuBar|#1/[MenuItem]System|$Item 1|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(SystemMI);

            ClosePB = new PushButton()
            {
                Tag = "[TitleBar]Open Collaboration Project|$TitleBar|#1/[PushButton]Close|$Close|#1",
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

            OpenProjectPB = new PushButton()
            {
                Tag = "[CustomWin]$UserControl_1|#1/[PushButton]Open Project|$Button_Next|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(OpenProjectPB);

            OpenProjectST = new StaticText()
            {
                Tag = "[CustomWin]$UserControl_1|#1/[PushButton]Open Project|$Button_Next|#1/[StaticText]Open Project|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(OpenProjectST);

            ImageIMG = new Image()
            {
                Tag = "[CustomWin]$UserControl_1|#1/[Image]$Image_1|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ImageIMG);

            StaticText1ST = new StaticText()
            {
                Tag = "[CustomWin]$UserControl_1|#1/[StaticText]>[1]|$TextBlock_3|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(StaticText1ST);

            PopupList1PL = new PopupList()
            {
                Tag = "[CustomWin]$UserControl_1|#1/[PopupList]$ComboBox_1|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(PopupList1PL);

            StaticText2ST = new StaticText()
            {
                Tag = "[CustomWin]$UserControl_1|#1/[StaticText]>[2]|$TextBlock_7|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(StaticText2ST);

            PopupList2PL = new PopupList()
            {
                Tag = "[CustomWin]$UserControl_1|#1/[PopupList]$ComboBox_2|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(PopupList2PL);

            ChooseAPlantProjectST = new StaticText()
            {
                Tag = "[CustomWin]$UserControl_1|#1/[StaticText]Choose a Plant project:|$TextBlock_2|#3",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ChooseAPlantProjectST);

            ChooseAPlantProjectLB = new ListBox()
            {
                Tag = "[CustomWin]$UserControl_1|#1/[ListBox]Choose a Plant project:|$ListBox_PlantProjects|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ChooseAPlantProjectLB);

            AutodeskProcessPowerCloudServiceCloudDocProject1LBI = new ListBoxItem()
            {
                Tag = "[CustomWin]$UserControl_1|#1/[ListBox]Choose a Plant project:|$ListBox_PlantProjects|#1/[ListBoxItem]Autodesk*[1]|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(AutodeskProcessPowerCloudServiceCloudDocProject1LBI);

            CHS0001ST = new StaticText()
            {
                Tag = "[CustomWin]$UserControl_1|#1/[ListBox]Choose a Plant project:|$ListBox_PlantProjects|#1/[ListBoxItem]Autodesk*[1]|#1/[StaticText]CHS_0001|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(CHS0001ST);

            AutodeskProcessPowerCloudServiceCloudDocProject2LBI = new ListBoxItem()
            {
                Tag = "[CustomWin]$UserControl_1|#1/[ListBox]Choose a Plant project:|$ListBox_PlantProjects|#1/[ListBoxItem]Autodesk*[2]|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(AutodeskProcessPowerCloudServiceCloudDocProject2LBI);

            CHSMetric001ST = new StaticText()
            {
                Tag = "[CustomWin]$UserControl_1|#1/[ListBox]Choose a Plant project:|$ListBox_PlantProjects|#1/[ListBoxItem]Autodesk*[2]|#2/[StaticText]CHS_Metric_001|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(CHSMetric001ST);

            AutodeskProcessPowerCloudServiceCloudDocProject3LBI = new ListBoxItem()
            {
                Tag = "[CustomWin]$UserControl_1|#1/[ListBox]Choose a Plant project:|$ListBox_PlantProjects|#1/[ListBoxItem]Autodesk*[3]|#3",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(AutodeskProcessPowerCloudServiceCloudDocProject3LBI);

            DEU0001ST = new StaticText()
            {
                Tag = "[CustomWin]$UserControl_1|#1/[ListBox]Choose a Plant project:|$ListBox_PlantProjects|#1/[ListBoxItem]Autodesk*[3]|#3/[StaticText]DEU_0001|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(DEU0001ST);

            AutodeskProcessPowerCloudServiceCloudDocProject4LBI = new ListBoxItem()
            {
                Tag = "[CustomWin]$UserControl_1|#1/[ListBox]Choose a Plant project:|$ListBox_PlantProjects|#1/[ListBoxItem]Autodesk*[4]|#4",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(AutodeskProcessPowerCloudServiceCloudDocProject4LBI);

            FRA001ST = new StaticText()
            {
                Tag = "[CustomWin]$UserControl_1|#1/[ListBox]Choose a Plant project:|$ListBox_PlantProjects|#1/[ListBoxItem]Autodesk*[4]|#4/[StaticText]FRA_001|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(FRA001ST);

            AutodeskProcessPowerCloudServiceCloudDocProject5LBI = new ListBoxItem()
            {
                Tag = "[CustomWin]$UserControl_1|#1/[ListBox]Choose a Plant project:|$ListBox_PlantProjects|#1/[ListBoxItem]Autodesk*[5]|#5",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(AutodeskProcessPowerCloudServiceCloudDocProject5LBI);

            ImperialST = new StaticText()
            {
                Tag = "[CustomWin]$UserControl_1|#1/[ListBox]Choose a Plant project:|$ListBox_PlantProjects|#1/[ListBoxItem]Autodesk*[5]|#5/[StaticText]Imperial|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ImperialST);

            AutodeskProcessPowerCloudServiceCloudDocProject6LBI = new ListBoxItem()
            {
                Tag = "[CustomWin]$UserControl_1|#1/[ListBox]Choose a Plant project:|$ListBox_PlantProjects|#1/[ListBoxItem]Autodesk*[6]|#6",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(AutodeskProcessPowerCloudServiceCloudDocProject6LBI);

            ImperialENU03ST = new StaticText()
            {
                Tag = "[CustomWin]$UserControl_1|#1/[ListBox]Choose a Plant project:|$ListBox_PlantProjects|#1/[ListBoxItem]Autodesk*[6]|#6/[StaticText]Imperial_ENU_03|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ImperialENU03ST);

            AutodeskProcessPowerCloudServiceCloudDocProject7LBI = new ListBoxItem()
            {
                Tag = "[CustomWin]$UserControl_1|#1/[ListBox]Choose a Plant project:|$ListBox_PlantProjects|#1/[ListBoxItem]Autodesk*[7]|#7",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(AutodeskProcessPowerCloudServiceCloudDocProject7LBI);

            ImperialENU04ST = new StaticText()
            {
                Tag = "[CustomWin]$UserControl_1|#1/[ListBox]Choose a Plant project:|$ListBox_PlantProjects|#1/[ListBoxItem]Autodesk*[7]|#7/[StaticText]Imperial_ENU_04|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ImperialENU04ST);

            AutodeskProcessPowerCloudServiceCloudDocProject8LBI = new ListBoxItem()
            {
                Tag = "[CustomWin]$UserControl_1|#1/[ListBox]Choose a Plant project:|$ListBox_PlantProjects|#1/[ListBoxItem]Autodesk*[8]|#8",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(AutodeskProcessPowerCloudServiceCloudDocProject8LBI);

            ImperialENU05ST = new StaticText()
            {
                Tag = "[CustomWin]$UserControl_1|#1/[ListBox]Choose a Plant project:|$ListBox_PlantProjects|#1/[ListBoxItem]Autodesk*[8]|#8/[StaticText]Imperial_ENU_05|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ImperialENU05ST);

            AutodeskProcessPowerCloudServiceCloudDocProject9LBI = new ListBoxItem()
            {
                Tag = "[CustomWin]$UserControl_1|#1/[ListBox]Choose a Plant project:|$ListBox_PlantProjects|#1/[ListBoxItem]Autodesk*[9]|#9",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(AutodeskProcessPowerCloudServiceCloudDocProject9LBI);

            JPN1ST = new StaticText()
            {
                Tag = "[CustomWin]$UserControl_1|#1/[ListBox]Choose a Plant project:|$ListBox_PlantProjects|#1/[ListBoxItem]Autodesk*[9]|#9/[StaticText]JPN__1|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(JPN1ST);

            AutodeskProcessPowerCloudServiceCloudDocProject10LBI = new ListBoxItem()
            {
                Tag = "[CustomWin]$UserControl_1|#1/[ListBox]Choose a Plant project:|$ListBox_PlantProjects|#1/[ListBoxItem]Autodesk*[10]|#10",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(AutodeskProcessPowerCloudServiceCloudDocProject10LBI);

            KOR0001ST = new StaticText()
            {
                Tag = "[CustomWin]$UserControl_1|#1/[ListBox]Choose a Plant project:|$ListBox_PlantProjects|#1/[ListBoxItem]Autodesk*[10]|#10/[StaticText]KOR_0001|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(KOR0001ST);

            AutodeskProcessPowerCloudServiceCloudDocProject11LBI = new ListBoxItem()
            {
                Tag = "[CustomWin]$UserControl_1|#1/[ListBox]Choose a Plant project:|$ListBox_PlantProjects|#1/[ListBoxItem]Autodesk*[11]|#11",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(AutodeskProcessPowerCloudServiceCloudDocProject11LBI);

            RUS0001ST = new StaticText()
            {
                Tag = "[CustomWin]$UserControl_1|#1/[ListBox]Choose a Plant project:|$ListBox_PlantProjects|#1/[ListBoxItem]Autodesk*[11]|#11/[StaticText]RUS_0001|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(RUS0001ST);
        }
    }
}
