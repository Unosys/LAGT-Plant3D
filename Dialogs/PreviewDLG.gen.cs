// This file is auto-generated - do not hand edit this file.

using Autodesk.GUIHarness;
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{

    [UIElement(Tag = "[Pane]Preview|$PrintPreviewFormExBase", Parent = typeof(ReportCreatorDLG), GUIType = GuiType.UIA)]
    public partial class PreviewDLG : Pane
    {
        public  Pane Pane1PANE;
        public  Pane Pane2PANE;
        public  Pane Pane3PANE;
        public  ScrollBar HorizontalSB;
        public  Pane Pane4PANE;
        public  ScrollBar VerticalSB;
        public  Pane Pane5PANE;
        public  GroupBox DockBottomGB;
        public  StatusBar StatusBarSB;
        public  GroupBox DockTopGB;
        public  CustomWin MainMenuWIN;
        public  MenuItem FileMI;
        public  MenuItem ViewMI;
        public  MenuItem BackgroundMI;
        public  MenuItem Item1MI;
        public  ToolBar ToolbarTB;
        public  PushButton ParametersPB;
        public  PushButton ThumbnailsPB;
        public  PushButton SearchPB;
        public  PushButton Open1PB;
        public  PushButton SavePB;
        public  PushButton Print1PB;
        public  PushButton Print2PB;
        public  PushButton PageSetupPB;
        public  PushButton ScalePB;
        public  PushButton HandToolPB;
        public  PushButton MagnifierPB;
        public  PushButton ZoomOutPB;
        public  PushButton ZoomPB;
        public  PushButton ZoomInPB;
        public  PushButton FirstPagePB;
        public  PushButton PreviousPagePB;
        public  PushButton NextPagePB;
        public  PushButton LastPagePB;
        public  PushButton MultiplePagesPB;
        public  PushButton ColorPB;
        public  PushButton WatermarkPB;
        public  PushButton ExportDocumentPB;
        public  PushButton Open2PB;
        public  MenuItem Item2MI;
        public  TitleBar PreviewCTL;
        public  PushButton MinimizePB;
        public  PushButton MaximizePB;
        public  PushButton ClosePB;

        partial void OnInitialize();

        public PreviewDLG()
        {
            InitializeComponent();
            OnInitialize();
        }

        private void InitializeComponent()
        {

            Pane1PANE = new Pane()
            {
                Tag = "[Pane]#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Pane1PANE);

            Pane2PANE = new Pane()
            {
                Tag = "[Pane]$fPrintControl|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Pane2PANE);

            Pane3PANE = new Pane()
            {
                Tag = "[Pane]$fPrintControl|#2/[Pane]$DocumentViewer|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Pane3PANE);

            HorizontalSB = new ScrollBar()
            {
                Tag = "[Pane]$fPrintControl|#2/[ScrollBar]Horizontal|$hScrollBar|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(HorizontalSB);

            Pane4PANE = new Pane()
            {
                Tag = "[Pane]$fPrintControl|#2/[Pane]$sidePanel|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Pane4PANE);

            VerticalSB = new ScrollBar()
            {
                Tag = "[Pane]$fPrintControl|#2/[Pane]$sidePanel|#2/[ScrollBar]Vertical|$vScrollBar|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(VerticalSB);

            Pane5PANE = new Pane()
            {
                Tag = "[Pane]$fPrintControl|#2/[Pane]$sidePanel|#2/[Pane]$cornerPanel|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Pane5PANE);

            DockBottomGB = new GroupBox()
            {
                Tag = "[GroupBox]Dock Bottom|$7804338|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(DockBottomGB);

            StatusBarSB = new StatusBar()
            {
                Tag = "[GroupBox]Dock Bottom|$7804338|#2/[StatusBar]Status Bar|$10032034|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(StatusBarSB);

            DockTopGB = new GroupBox()
            {
                Tag = "[GroupBox]#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(DockTopGB);

            MainMenuWIN = new CustomWin()
            {
                Tag = "[GroupBox]#1/[CustomWin]#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(MainMenuWIN);

            FileMI = new MenuItem()
            {
                Tag = "[GroupBox]#1/[CustomWin]#1/[MenuItem]File|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(FileMI);

            ViewMI = new MenuItem()
            {
                Tag = "[GroupBox]#1/[CustomWin]#1/[MenuItem]View|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ViewMI);

            BackgroundMI = new MenuItem()
            {
                Tag = "[GroupBox]#1/[CustomWin]#1/[MenuItem]Background|#3",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(BackgroundMI);

            Item1MI = new MenuItem()
            {
                Tag = "[GroupBox]#1/[CustomWin]#1/[MenuItem]Item|#4",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Item1MI);

            ToolbarTB = new ToolBar()
            {
                Tag = "[GroupBox]#1/[ToolBar]#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ToolbarTB);

            ParametersPB = new PushButton()
            {
                Tag = "[GroupBox]#1/[ToolBar]#1/[PushButton]Parameters|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ParametersPB);

            ThumbnailsPB = new PushButton()
            {
                Tag = "[GroupBox]#1/[ToolBar]#1/[PushButton]Thumbnails|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ThumbnailsPB);

            SearchPB = new PushButton()
            {
                Tag = "[GroupBox]#1/[ToolBar]#1/[PushButton]#3",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(SearchPB);

            Open1PB = new PushButton()
            {
                Tag = "[GroupBox]#1/[ToolBar]#1/[PushButton]#4",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Open1PB);

            SavePB = new PushButton()
            {
                Tag = "[GroupBox]#1/[ToolBar]#1/[PushButton]#5",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(SavePB);

            Print1PB = new PushButton()
            {
                Tag = "[GroupBox]#1/[ToolBar]#1/[PushButton]Print*|#6",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Print1PB);

            Print2PB = new PushButton()
            {
                Tag = "[GroupBox]#1/[ToolBar]#1/[PushButton]Print|#7",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Print2PB);

            PageSetupPB = new PushButton()
            {
                Tag = "[GroupBox]#1/[ToolBar]#1/[PushButton]Page Setup*|#8",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(PageSetupPB);

            ScalePB = new PushButton()
            {
                Tag = "[GroupBox]#1/[ToolBar]#1/[PushButton]Scale|#9",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ScalePB);

            HandToolPB = new PushButton()
            {
                Tag = "[GroupBox]#1/[ToolBar]#1/[PushButton]Hand Tool|#10",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(HandToolPB);

            MagnifierPB = new PushButton()
            {
                Tag = "[GroupBox]#1/[ToolBar]#1/[PushButton]Magnifier|#11",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(MagnifierPB);

            ZoomOutPB = new PushButton()
            {
                Tag = "[GroupBox]#1/[ToolBar]#1/[PushButton]Zoom Out|#12",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ZoomOutPB);

            ZoomPB = new PushButton()
            {
                Tag = "[GroupBox]#1/[ToolBar]#1/[PushButton]Zoom|#13",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ZoomPB);

            ZoomInPB = new PushButton()
            {
                Tag = "[GroupBox]#1/[ToolBar]#1/[PushButton]Zoom In|#14",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ZoomInPB);

            FirstPagePB = new PushButton()
            {
                Tag = "[GroupBox]#1/[ToolBar]#1/[PushButton]First Page|#15",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(FirstPagePB);

            PreviousPagePB = new PushButton()
            {
                Tag = "[GroupBox]#1/[ToolBar]#1/[PushButton]Previous Page|#16",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(PreviousPagePB);

            NextPagePB = new PushButton()
            {
                Tag = "[GroupBox]#1/[ToolBar]#1/[PushButton]Next Page|#17",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(NextPagePB);

            LastPagePB = new PushButton()
            {
                Tag = "[GroupBox]#1/[ToolBar]#1/[PushButton]Last Page|#18",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(LastPagePB);

            MultiplePagesPB = new PushButton()
            {
                Tag = "[GroupBox]#1/[ToolBar]#1/[PushButton]Multiple Pages|#19",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(MultiplePagesPB);

            ColorPB = new PushButton()
            {
                Tag = "[GroupBox]#1/[ToolBar]#1/[PushButton]Color*|#20",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ColorPB);

            WatermarkPB = new PushButton()
            {
                Tag = "[GroupBox]#1/[ToolBar]#1/[PushButton]Watermark*|#21",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(WatermarkPB);

            ExportDocumentPB = new PushButton()
            {
                Tag = "[GroupBox]#1/[ToolBar]#1/[PushButton]Export Document*|#22",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ExportDocumentPB);

            Open2PB = new PushButton()
            {
                Tag = "[GroupBox]#1/[ToolBar]#1/[PushButton]Export Document*|#22/[PushButton]Open|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Open2PB);

            Item2MI = new MenuItem()
            {
                Tag = "[GroupBox]#1/[ToolBar]#1/[MenuItem]Item|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Item2MI);

            PreviewCTL = new TitleBar()
            {
                Tag = "[TitleBar]Preview|$TitleBar|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(PreviewCTL);

            MinimizePB = new PushButton()
            {
                Tag = "[TitleBar]Preview|$TitleBar|#1/[PushButton]Minimize|$Minimize|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(MinimizePB);

            MaximizePB = new PushButton()
            {
                Tag = "[TitleBar]Preview|$TitleBar|#1/[PushButton]Maximize|$Maximize|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(MaximizePB);

            ClosePB = new PushButton()
            {
                Tag = "[TitleBar]Preview|$TitleBar|#1/[PushButton]Close|$Close|#3",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ClosePB);
        }
    }
}
