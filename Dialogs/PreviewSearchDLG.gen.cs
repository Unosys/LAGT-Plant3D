// This file is auto-generated - do not hand edit this file.

using Autodesk.GUIHarness;
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{

    [UIElement(Tag = "[Pane]Preview|$PrintPreviewFormExBase", Parent = typeof(MainWin), GUIType = GuiType.UIA)]
    public partial class PreviewSearchDLG : Pane
    {
        public  Pane Pane1PANE;
        public  Pane Pane2PANE;
        public  Pane Pane3PANE;
        public  ScrollBar HorizontalSB;
        public  Pane Pane4PANE;
        public  ScrollBar VerticalSB;
        public  Pane Pane5PANE;
        public  Pane Pane6PANE;
        public  Pane Pane7PANE;
        public  Pane TheXtraLayoutControlPANE;
        public  PushButton Close1PB;
        public  PushButton NextPB;
        public  PushButton PreviousPB;
        public  PushButton PushButtonPB;
        public  TextField TextField1TF;
        public  TextField TextField2TF;
        public  TextField TextField3TF;
        public  StaticText SearchST;
        public  GroupBox DockBottomGB;
        public  StatusBar StatusBarSB;
        public  TextField TextField4TF;
        public  TextField TextField5TF;
        public  TextField TextField6TF;
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
        public  PushButton Close2PB;

        partial void OnInitialize();

        public PreviewSearchDLG()
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
                Tag = "[Pane]$fPrintControl|#2/[Pane]$DocumentViewer|#2",
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
                Tag = "[Pane]$fPrintControl|#2/[Pane]$sidePanel|#3",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Pane4PANE);

            VerticalSB = new ScrollBar()
            {
                Tag = "[Pane]$fPrintControl|#2/[Pane]$sidePanel|#3/[ScrollBar]Vertical|$vScrollBar|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(VerticalSB);

            Pane5PANE = new Pane()
            {
                Tag = "[Pane]$fPrintControl|#2/[Pane]$sidePanel|#3/[Pane]$cornerPanel|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Pane5PANE);

            Pane6PANE = new Pane()
            {
                Tag = "[Pane]$fPrintControl|#2/[Pane]$530384|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Pane6PANE);

            Pane7PANE = new Pane()
            {
                Tag = "[Pane]$fPrintControl|#2/[Pane]$530384|#1/[Pane]$FindControl|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Pane7PANE);

            TheXtraLayoutControlPANE = new Pane()
            {
                Tag = "[Pane]$fPrintControl|#2/[Pane]$530384|#1/[Pane]$FindControl|#1/[Pane]The XtraLayoutControl|$layoutControl1|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(TheXtraLayoutControlPANE);

            Close1PB = new PushButton()
            {
                Tag = "[Pane]$fPrintControl|#2/[Pane]$530384|#1/[Pane]$FindControl|#1/[Pane]The XtraLayoutControl|$layoutControl1|#1/[PushButton]Close|$btnClose|#4",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Close1PB);

            NextPB = new PushButton()
            {
                Tag = "[Pane]$fPrintControl|#2/[Pane]$530384|#1/[Pane]$FindControl|#1/[Pane]The XtraLayoutControl|$layoutControl1|#1/[PushButton]Next|$btnFindNext|#3",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(NextPB);

            PreviousPB = new PushButton()
            {
                Tag = "[Pane]$fPrintControl|#2/[Pane]$530384|#1/[Pane]$FindControl|#1/[Pane]The XtraLayoutControl|$layoutControl1|#1/[PushButton]Previous|$btnFindPrev|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(PreviousPB);

            PushButtonPB = new PushButton()
            {
                Tag = "[Pane]$fPrintControl|#2/[Pane]$530384|#1/[Pane]$FindControl|#1/[Pane]The XtraLayoutControl|$layoutControl1|#1/[PushButton] |$ddBtnParameters|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(PushButtonPB);

            TextField1TF = new TextField()
            {
                Tag = "[Pane]$fPrintControl|#2/[Pane]$530384|#1/[Pane]$FindControl|#1/[Pane]The XtraLayoutControl|$layoutControl1|#1/[TextField]$textEdit|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(TextField1TF);

            TextField2TF = new TextField()
            {
                Tag = "[Pane]$fPrintControl|#2/[Pane]$530384|#1/[Pane]$FindControl|#1/[Pane]The XtraLayoutControl|$layoutControl1|#1/[TextField]$textEdit|#1/[TextField]$3217440|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(TextField2TF);

            TextField3TF = new TextField()
            {
                Tag = "[Pane]$fPrintControl|#2/[Pane]$530384|#1/[Pane]$FindControl|#1/[Pane]The XtraLayoutControl|$layoutControl1|#1/[TextField]$textEdit|#1/[TextField]#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(TextField3TF);

            SearchST = new StaticText()
            {
                Tag = "[Pane]$fPrintControl|#2/[Pane]$530384|#1/[Pane]$FindControl|#1/[Pane]The XtraLayoutControl|$layoutControl1|#1/[StaticText]Search|$lbSearch|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(SearchST);

            DockBottomGB = new GroupBox()
            {
                Tag = "[GroupBox]Dock Bottom|$857158|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(DockBottomGB);

            StatusBarSB = new StatusBar()
            {
                Tag = "[GroupBox]Dock Bottom|$857158|#2/[StatusBar]Status Bar|$2496542|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(StatusBarSB);

            TextField4TF = new TextField()
            {
                Tag = "[GroupBox]Dock Bottom|$857158|#2/[StatusBar]Status Bar|$2496542|#1/[TextField]$StatusBar.Pane0|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(TextField4TF);

            TextField5TF = new TextField()
            {
                Tag = "[GroupBox]Dock Bottom|$857158|#2/[StatusBar]Status Bar|$2496542|#1/[TextField]$StatusBar.Pane1|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(TextField5TF);

            TextField6TF = new TextField()
            {
                Tag = "[GroupBox]Dock Bottom|$857158|#2/[StatusBar]Status Bar|$2496542|#1/[TextField]$StatusBar.Pane2|#3",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(TextField6TF);

            DockTopGB = new GroupBox()
            {
                Tag = "[GroupBox]Dock Top|$2298784|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(DockTopGB);

            MainMenuWIN = new CustomWin()
            {
                Tag = "[GroupBox]Dock Top|$2298784|#1/[CustomWin]Main Menu|$1775704|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(MainMenuWIN);

            FileMI = new MenuItem()
            {
                Tag = "[GroupBox]Dock Top|$2298784|#1/[CustomWin]Main Menu|$1775704|#1/[MenuItem]File|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(FileMI);

            ViewMI = new MenuItem()
            {
                Tag = "[GroupBox]Dock Top|$2298784|#1/[CustomWin]Main Menu|$1775704|#1/[MenuItem]View|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ViewMI);

            BackgroundMI = new MenuItem()
            {
                Tag = "[GroupBox]Dock Top|$2298784|#1/[CustomWin]Main Menu|$1775704|#1/[MenuItem]Background|#3",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(BackgroundMI);

            Item1MI = new MenuItem()
            {
                Tag = "[GroupBox]Dock Top|$2298784|#1/[CustomWin]Main Menu|$1775704|#1/[MenuItem]Item|#4",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Item1MI);

            ToolbarTB = new ToolBar()
            {
                Tag = "[GroupBox]Dock Top|$2298784|#1/[ToolBar]Toolbar|$202966|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ToolbarTB);

            ParametersPB = new PushButton()
            {
                Tag = "[GroupBox]Dock Top|$2298784|#1/[ToolBar]Toolbar|$202966|#1/[PushButton]Parameters|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ParametersPB);

            ThumbnailsPB = new PushButton()
            {
                Tag = "[GroupBox]Dock Top|$2298784|#1/[ToolBar]Toolbar|$202966|#1/[PushButton]Thumbnails|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ThumbnailsPB);

            SearchPB = new PushButton()
            {
                Tag = "[GroupBox]Dock Top|$2298784|#1/[ToolBar]Toolbar|$202966|#1/[PushButton]Search|#3",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(SearchPB);

            Open1PB = new PushButton()
            {
                Tag = "[GroupBox]Dock Top|$2298784|#1/[ToolBar]Toolbar|$202966|#1/[PushButton]Open|#4",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Open1PB);

            SavePB = new PushButton()
            {
                Tag = "[GroupBox]Dock Top|$2298784|#1/[ToolBar]Toolbar|$202966|#1/[PushButton]Save|#5",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(SavePB);

            Print1PB = new PushButton()
            {
                Tag = "[GroupBox]Dock Top|$2298784|#1/[ToolBar]Toolbar|$202966|#1/[PushButton]Print*|#6",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Print1PB);

            Print2PB = new PushButton()
            {
                Tag = "[GroupBox]Dock Top|$2298784|#1/[ToolBar]Toolbar|$202966|#1/[PushButton]Print|#7",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Print2PB);

            PageSetupPB = new PushButton()
            {
                Tag = "[GroupBox]Dock Top|$2298784|#1/[ToolBar]Toolbar|$202966|#1/[PushButton]Page Setup*|#8",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(PageSetupPB);

            ScalePB = new PushButton()
            {
                Tag = "[GroupBox]Dock Top|$2298784|#1/[ToolBar]Toolbar|$202966|#1/[PushButton]Scale|#9",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ScalePB);

            HandToolPB = new PushButton()
            {
                Tag = "[GroupBox]Dock Top|$2298784|#1/[ToolBar]Toolbar|$202966|#1/[PushButton]Hand Tool|#10",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(HandToolPB);

            MagnifierPB = new PushButton()
            {
                Tag = "[GroupBox]Dock Top|$2298784|#1/[ToolBar]Toolbar|$202966|#1/[PushButton]Magnifier|#11",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(MagnifierPB);

            ZoomOutPB = new PushButton()
            {
                Tag = "[GroupBox]Dock Top|$2298784|#1/[ToolBar]Toolbar|$202966|#1/[PushButton]Zoom Out|#12",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ZoomOutPB);

            ZoomPB = new PushButton()
            {
                Tag = "[GroupBox]Dock Top|$2298784|#1/[ToolBar]Toolbar|$202966|#1/[PushButton]Zoom|#13",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ZoomPB);

            ZoomInPB = new PushButton()
            {
                Tag = "[GroupBox]Dock Top|$2298784|#1/[ToolBar]Toolbar|$202966|#1/[PushButton]Zoom In|#14",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ZoomInPB);

            FirstPagePB = new PushButton()
            {
                Tag = "[GroupBox]Dock Top|$2298784|#1/[ToolBar]Toolbar|$202966|#1/[PushButton]First Page|#15",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(FirstPagePB);

            PreviousPagePB = new PushButton()
            {
                Tag = "[GroupBox]Dock Top|$2298784|#1/[ToolBar]Toolbar|$202966|#1/[PushButton]Previous Page|#16",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(PreviousPagePB);

            NextPagePB = new PushButton()
            {
                Tag = "[GroupBox]Dock Top|$2298784|#1/[ToolBar]Toolbar|$202966|#1/[PushButton]Next Page|#17",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(NextPagePB);

            LastPagePB = new PushButton()
            {
                Tag = "[GroupBox]Dock Top|$2298784|#1/[ToolBar]Toolbar|$202966|#1/[PushButton]Last Page|#18",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(LastPagePB);

            MultiplePagesPB = new PushButton()
            {
                Tag = "[GroupBox]Dock Top|$2298784|#1/[ToolBar]Toolbar|$202966|#1/[PushButton]Multiple Pages|#19",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(MultiplePagesPB);

            ColorPB = new PushButton()
            {
                Tag = "[GroupBox]Dock Top|$2298784|#1/[ToolBar]Toolbar|$202966|#1/[PushButton]Color*|#20",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ColorPB);

            WatermarkPB = new PushButton()
            {
                Tag = "[GroupBox]Dock Top|$2298784|#1/[ToolBar]Toolbar|$202966|#1/[PushButton]Watermark*|#21",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(WatermarkPB);

            ExportDocumentPB = new PushButton()
            {
                Tag = "[GroupBox]Dock Top|$2298784|#1/[ToolBar]Toolbar|$202966|#1/[PushButton]Export Document*|#22",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ExportDocumentPB);

            Open2PB = new PushButton()
            {
                Tag = "[GroupBox]Dock Top|$2298784|#1/[ToolBar]Toolbar|$202966|#1/[PushButton]Export Document*|#22/[PushButton]Open|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Open2PB);

            Item2MI = new MenuItem()
            {
                Tag = "[GroupBox]Dock Top|$2298784|#1/[ToolBar]Toolbar|$202966|#1/[MenuItem]Item|#1",
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

            Close2PB = new PushButton()
            {
                Tag = "[TitleBar]Preview|$TitleBar|#1/[PushButton]Close|$Close|#3",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Close2PB);
        }
    }
}
