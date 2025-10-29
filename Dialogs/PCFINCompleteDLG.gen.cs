// This file is auto-generated - do not hand edit this file.

using Autodesk.GUIHarness;
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{

    [UIElement(Tag = "[Window]PCF To Pipe|$Window_1|#1", Parent = typeof(Plant3D), GUIType = GuiType.UIA)]
    public partial class PCFINCompleteDLG : Autodesk.GUIHarness.AutoCAD.AcDialogBox
    {
        public  TitleBar PCFToPipeCTL;
        public  CustomWin SystemMenuBarWIN;
        public  MenuItem SystemMI;
        public  PushButton Close1PB;
        public  StaticText PCFFiles1ST;
        public  StaticText PCFFiles2ST;
        public  StaticText Status1ST;
        public  StaticText Status2ST;
        public  StaticText OverallProgress1ST;
        public  StaticText OverallProgress2ST;
        public  StaticText one00Complete1ST;
        public  StaticText one00Complete2ST;
        public  CustomWin CustomWin1WIN;
        public  StaticText Open1ST;
        public  StaticText Open2ST;
        public  StaticText SystemWindowsDocumentsHyperlinkST;
        public  StaticText StaticText1ST;
        public  Link LinkLINK;
        public  StaticText LogFileST;
        public  StaticText ToReviewImportingResult1ST;
        public  StaticText ToReviewImportingResult2ST;
        public  Pane PanePANE;
        public  CustomWin CustomWin2WIN;
        public  StaticText one001ST;
        public  StaticText StaticText2ST;
        public  StaticText StaticText3ST;
        public  Image Image1IMG;
        public  StaticText StaticText4ST;
        public  StaticText StaticText5ST;
        public  CustomWin CustomWin3WIN;
        public  StaticText one002ST;
        public  StaticText StaticText6ST;
        public  StaticText StaticText7ST;
        public  Image Image2IMG;
        public  StaticText StaticText8ST;
        public  StaticText StaticText9ST;
        public  CustomWin CustomWin4WIN;
        public  StaticText one003ST;
        public  StaticText StaticText10ST;
        public  StaticText StaticText11ST;
        public  Image Image3IMG;
        public  StaticText StaticText12ST;
        public  StaticText StaticText13ST;
        public  PushButton Close2PB;

        partial void OnInitialize();

        public PCFINCompleteDLG()
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

            Close1PB = new PushButton()
            {
                Tag = "[TitleBar]PCF To Pipe|$TitleBar|#1/[PushButton]Close|$Close|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Close1PB);

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

            OverallProgress1ST = new StaticText()
            {
                Tag = "[StaticText]Overall Progress:|$Label_3|#3",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(OverallProgress1ST);

            OverallProgress2ST = new StaticText()
            {
                Tag = "[StaticText]Overall Progress:|$Label_3|#3/[StaticText]Overall Progress:|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(OverallProgress2ST);

            one00Complete1ST = new StaticText()
            {
                Tag = "[StaticText]100% complete|$FileProgressLabel|#4",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(one00Complete1ST);

            one00Complete2ST = new StaticText()
            {
                Tag = "[StaticText]100% complete|$FileProgressLabel|#4/[StaticText]100% complete|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(one00Complete2ST);

            CustomWin1WIN = new CustomWin()
            {
                Tag = "[CustomWin]$OverallProgressBar|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(CustomWin1WIN);

            Open1ST = new StaticText()
            {
                Tag = "[StaticText]Open |$Label_4|#5",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Open1ST);

            Open2ST = new StaticText()
            {
                Tag = "[StaticText]Open |$Label_4|#5/[StaticText]Open |#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Open2ST);

            SystemWindowsDocumentsHyperlinkST = new StaticText()
            {
                Tag = "[StaticText]System*|$LogLabel|#6",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(SystemWindowsDocumentsHyperlinkST);

            StaticText1ST = new StaticText()
            {
                Tag = "[StaticText]System*|$LogLabel|#6/[StaticText] |#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(StaticText1ST);

            LinkLINK = new Link()
            {
                Tag = "[StaticText]System*|$LogLabel|#6/[StaticText] |#1/[Link] |$LogHyperlink|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(LinkLINK);

            LogFileST = new StaticText()
            {
                Tag = "[StaticText]System*|$LogLabel|#6/[StaticText] |#1/[Link] |$LogHyperlink|#1/[StaticText]Log file|$TextBlock_1|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(LogFileST);

            ToReviewImportingResult1ST = new StaticText()
            {
                Tag = "[StaticText] to review importing result*|$Label_5|#7",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ToReviewImportingResult1ST);

            ToReviewImportingResult2ST = new StaticText()
            {
                Tag = "[StaticText] to review importing result*|$Label_5|#7/[StaticText] to review importing result*|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ToReviewImportingResult2ST);

            PanePANE = new Pane()
            {
                Tag = "[Pane]$ScrollViewer_1|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(PanePANE);

            CustomWin2WIN = new CustomWin()
            {
                Tag = "[Pane]$ScrollViewer_1|#1/[CustomWin]$UserControl_1|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(CustomWin2WIN);

            one001ST = new StaticText()
            {
                Tag = "[Pane]$ScrollViewer_1|#1/[CustomWin]$UserControl_1|#1/[StaticText]1001|$FileNameTB|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(one001ST);

            StaticText2ST = new StaticText()
            {
                Tag = "[Pane]$ScrollViewer_1|#1/[CustomWin]$UserControl_1|#1/[StaticText] [1]|$Label_1|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(StaticText2ST);

            StaticText3ST = new StaticText()
            {
                Tag = "[Pane]$ScrollViewer_1|#1/[CustomWin]$UserControl_1|#1/[StaticText] [1]|$Label_1|#2/[StaticText] |#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(StaticText3ST);

            Image1IMG = new Image()
            {
                Tag = "[Pane]$ScrollViewer_1|#1/[CustomWin]$UserControl_1|#1/[Image]$ProcessImage|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Image1IMG);

            StaticText4ST = new StaticText()
            {
                Tag = "[Pane]$ScrollViewer_1|#1/[CustomWin]$UserControl_1|#1/[StaticText] [2]|$Label_2|#3",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(StaticText4ST);

            StaticText5ST = new StaticText()
            {
                Tag = "[Pane]$ScrollViewer_1|#1/[CustomWin]$UserControl_1|#1/[StaticText] [2]|$Label_2|#3/[StaticText] |#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(StaticText5ST);

            CustomWin3WIN = new CustomWin()
            {
                Tag = "[Pane]$ScrollViewer_1|#1/[CustomWin]$UserControl_1|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(CustomWin3WIN);

            one002ST = new StaticText()
            {
                Tag = "[Pane]$ScrollViewer_1|#1/[CustomWin]$UserControl_1|#2/[StaticText]1002|$FileNameTB|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(one002ST);

            StaticText6ST = new StaticText()
            {
                Tag = "[Pane]$ScrollViewer_1|#1/[CustomWin]$UserControl_1|#2/[StaticText] [1]|$Label_1|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(StaticText6ST);

            StaticText7ST = new StaticText()
            {
                Tag = "[Pane]$ScrollViewer_1|#1/[CustomWin]$UserControl_1|#2/[StaticText] [1]|$Label_1|#2/[StaticText] |#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(StaticText7ST);

            Image2IMG = new Image()
            {
                Tag = "[Pane]$ScrollViewer_1|#1/[CustomWin]$UserControl_1|#2/[Image]$ProcessImage|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Image2IMG);

            StaticText8ST = new StaticText()
            {
                Tag = "[Pane]$ScrollViewer_1|#1/[CustomWin]$UserControl_1|#2/[StaticText] [2]|$Label_2|#3",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(StaticText8ST);

            StaticText9ST = new StaticText()
            {
                Tag = "[Pane]$ScrollViewer_1|#1/[CustomWin]$UserControl_1|#2/[StaticText] [2]|$Label_2|#3/[StaticText] |#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(StaticText9ST);

            CustomWin4WIN = new CustomWin()
            {
                Tag = "[Pane]$ScrollViewer_1|#1/[CustomWin]$UserControl_1|#3",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(CustomWin4WIN);

            one003ST = new StaticText()
            {
                Tag = "[Pane]$ScrollViewer_1|#1/[CustomWin]$UserControl_1|#3/[StaticText]1003|$FileNameTB|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(one003ST);

            StaticText10ST = new StaticText()
            {
                Tag = "[Pane]$ScrollViewer_1|#1/[CustomWin]$UserControl_1|#3/[StaticText] [1]|$Label_1|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(StaticText10ST);

            StaticText11ST = new StaticText()
            {
                Tag = "[Pane]$ScrollViewer_1|#1/[CustomWin]$UserControl_1|#3/[StaticText] [1]|$Label_1|#2/[StaticText] |#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(StaticText11ST);

            Image3IMG = new Image()
            {
                Tag = "[Pane]$ScrollViewer_1|#1/[CustomWin]$UserControl_1|#3/[Image]$ProcessImage|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Image3IMG);

            StaticText12ST = new StaticText()
            {
                Tag = "[Pane]$ScrollViewer_1|#1/[CustomWin]$UserControl_1|#3/[StaticText] [2]|$Label_2|#3",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(StaticText12ST);

            StaticText13ST = new StaticText()
            {
                Tag = "[Pane]$ScrollViewer_1|#1/[CustomWin]$UserControl_1|#3/[StaticText] [2]|$Label_2|#3/[StaticText] |#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(StaticText13ST);

            Close2PB = new PushButton()
            {
                Tag = "[PushButton]Close|$ProgressCancelBtn|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Close2PB);
        }
    }
}
