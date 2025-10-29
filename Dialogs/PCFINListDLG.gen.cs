// This file is auto-generated - do not hand edit this file.

using Autodesk.GUIHarness;
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{

    [UIElement(Tag = "[Window]PCF To Pipe|$Window_1|#1", Parent = typeof(Plant3D), GUIType = GuiType.UIA)]
    public partial class PCFINListDLG : Autodesk.GUIHarness.AutoCAD.AcDialogBox
    {
        public  TitleBar PCFToPipeCTL;
        public  CustomWin SystemMenuBarWIN;
        public  MenuItem SystemMI;
        public  PushButton ClosePB;
        public  StaticText PCFFiles1ST;
        public  StaticText PCFFiles2ST;
        public  StaticText Status1ST;
        public  StaticText Status2ST;
        public  PushButton PipeSettingsPB;
        public  Image Image1IMG;
        public  PushButton PushButton2PB;
        public  Image Image2IMG;
        public  Pane PanePANE;
        public  CustomWin CustomWin1WIN;
        public  Image Image3IMG;
        public  StaticText one001ST;
        public  StaticText Ok1ST;
        public  StaticText Ok2ST;
        public  CustomWin CustomWin2WIN;
        public  Image Image4IMG;
        public  StaticText one002ST;
        public  StaticText Ok3ST;
        public  StaticText Ok4ST;
        public  CustomWin CustomWin3WIN;
        public  Image Image5IMG;
        public  StaticText one003ST;
        public  StaticText CannotCreateModel1ST;
        public  StaticText CannotCreateModel2ST;
        public  PushButton CreatePipingPB;
        public  StaticText CreatePipingST;
        public  PushButton CancelPB;
        public  StaticText CancelST;
        public  PushButton HelpPB;
        public  StaticText HelpST;

        partial void OnInitialize();

        public PCFINListDLG()
        {
            InitializeComponent();
            OnInitialize();
        }

        private void InitializeComponent()
        {

            PCFToPipeCTL = new TitleBar()
            {
                Tag = "[TitleBar]PCF To Pipe|$TitleBar|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(PCFToPipeCTL);

            SystemMenuBarWIN = new CustomWin()
            {
                Tag = "[TitleBar]PCF To Pipe|$TitleBar|#1/[CustomWin]System Menu Bar|$SystemMenuBar|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(SystemMenuBarWIN);

            SystemMI = new MenuItem()
            {
                Tag = "[TitleBar]PCF To Pipe|$TitleBar|#1/[CustomWin]System Menu Bar|$SystemMenuBar|#1/[MenuItem]System|$Item 1|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(SystemMI);

            ClosePB = new PushButton()
            {
                Tag = "[TitleBar]PCF To Pipe|$TitleBar|#1/[PushButton]Close|$Close|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ClosePB);

            PCFFiles1ST = new StaticText()
            {
                Tag = "[StaticText]PCF Files|$Label_1|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(PCFFiles1ST);

            PCFFiles2ST = new StaticText()
            {
                Tag = "[StaticText]PCF Files|$Label_1|#1/[StaticText]PCF Files|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(PCFFiles2ST);

            Status1ST = new StaticText()
            {
                Tag = "[StaticText]Status|$Label_2|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Status1ST);

            Status2ST = new StaticText()
            {
                Tag = "[StaticText]Status|$Label_2|#2/[StaticText]Status|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Status2ST);

            PipeSettingsPB = new PushButton()
            {
                Tag = "[PushButton]$SettingBtn|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(PipeSettingsPB);

            Image1IMG = new Image()
            {
                Tag = "[PushButton]$SettingBtn|#1/[Image]$Image_1|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Image1IMG);

            PushButton2PB = new PushButton()
            {
                Tag = "[PushButton]$AddFileBtn|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(PushButton2PB);

            Image2IMG = new Image()
            {
                Tag = "[PushButton]$AddFileBtn|#2/[Image]$Image_2|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Image2IMG);

            PanePANE = new Pane()
            {
                Tag = "[Pane]$ScrollViewer_1|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(PanePANE);

            CustomWin1WIN = new CustomWin()
            {
                Tag = "[Pane]$ScrollViewer_1|#1/[CustomWin]$UserControl_1|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(CustomWin1WIN);

            Image3IMG = new Image()
            {
                Tag = "[Pane]$ScrollViewer_1|#1/[CustomWin]$UserControl_1|#1/[Image]$DeleteImage|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Image3IMG);

            one001ST = new StaticText()
            {
                Tag = "[Pane]$ScrollViewer_1|#1/[CustomWin]$UserControl_1|#1/[StaticText]1001|$FileNameTB|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(one001ST);

            Ok1ST = new StaticText()
            {
                Tag = "[Pane]$ScrollViewer_1|#1/[CustomWin]$UserControl_1|#1/[StaticText]ok|$StatusLabel|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Ok1ST);

            Ok2ST = new StaticText()
            {
                Tag = "[Pane]$ScrollViewer_1|#1/[CustomWin]$UserControl_1|#1/[StaticText]ok|$StatusLabel|#2/[StaticText]ok|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Ok2ST);

            CustomWin2WIN = new CustomWin()
            {
                Tag = "[Pane]$ScrollViewer_1|#1/[CustomWin]$UserControl_1|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(CustomWin2WIN);

            Image4IMG = new Image()
            {
                Tag = "[Pane]$ScrollViewer_1|#1/[CustomWin]$UserControl_1|#2/[Image]$DeleteImage|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Image4IMG);

            one002ST = new StaticText()
            {
                Tag = "[Pane]$ScrollViewer_1|#1/[CustomWin]$UserControl_1|#2/[StaticText]1002|$FileNameTB|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(one002ST);

            Ok3ST = new StaticText()
            {
                Tag = "[Pane]$ScrollViewer_1|#1/[CustomWin]$UserControl_1|#2/[StaticText]ok|$StatusLabel|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Ok3ST);

            Ok4ST = new StaticText()
            {
                Tag = "[Pane]$ScrollViewer_1|#1/[CustomWin]$UserControl_1|#2/[StaticText]ok|$StatusLabel|#2/[StaticText]ok|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Ok4ST);

            CustomWin3WIN = new CustomWin()
            {
                Tag = "[Pane]$ScrollViewer_1|#1/[CustomWin]$UserControl_1|#3",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(CustomWin3WIN);

            Image5IMG = new Image()
            {
                Tag = "[Pane]$ScrollViewer_1|#1/[CustomWin]$UserControl_1|#3/[Image]$DeleteImage|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Image5IMG);

            one003ST = new StaticText()
            {
                Tag = "[Pane]$ScrollViewer_1|#1/[CustomWin]$UserControl_1|#3/[StaticText]1003|$FileNameTB|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(one003ST);

            CannotCreateModel1ST = new StaticText()
            {
                Tag = "[Pane]$ScrollViewer_1|#1/[CustomWin]$UserControl_1|#3/[StaticText]cannot create model|$StatusLabel|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(CannotCreateModel1ST);

            CannotCreateModel2ST = new StaticText()
            {
                Tag = "[Pane]$ScrollViewer_1|#1/[CustomWin]$UserControl_1|#3/[StaticText]cannot create model|$StatusLabel|#2/[StaticText]cannot create model|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(CannotCreateModel2ST);

            CreatePipingPB = new PushButton()
            {
                Tag = "[PushButton]Create Piping|$CreatPipingBtn|#3",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(CreatePipingPB);

            CreatePipingST = new StaticText()
            {
                Tag = "[PushButton]Create Piping|$CreatPipingBtn|#3/[StaticText]Create Piping|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(CreatePipingST);

            CancelPB = new PushButton()
            {
                Tag = "[PushButton]Cancel|$CancelBtn|#4",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(CancelPB);

            CancelST = new StaticText()
            {
                Tag = "[PushButton]Cancel|$CancelBtn|#4/[StaticText]Cancel|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(CancelST);

            HelpPB = new PushButton()
            {
                Tag = "[PushButton]Help|$HelpBtn|#5",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(HelpPB);

            HelpST = new StaticText()
            {
                Tag = "[PushButton]Help|$HelpBtn|#5/[StaticText]Help|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(HelpST);
        }
    }
}
