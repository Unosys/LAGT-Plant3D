// This file is auto-generated - do not hand edit this file.

using Autodesk.GUIHarness;
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{

    [UIElement(Tag = "[CustomWin]#4", Parent = typeof(Plant3D), GUIType = GuiType.WIN32)]
    public partial class LayerPropertiesManagerDLG : Autodesk.GUIHarness.AutoCAD.AcDialogBox
    {
        public  CustomWin Layer1WIN;
        public  CustomWin Layer2WIN;
        public  CustomWin LayerPaletteWIN;
        public  Pane Pane1PANE;
        public  TextField TextField1TF;
        public  PushButton PushButton1PB;
        public  Pane Pane2PANE;
        public  Pane Pane3PANE;
        public  Pane Pane4PANE;
        public  PushButton FiltersPB;
        public  ToolBar ToolBar1TB;
        public  PushButton PushButton2PB;
        public  TreeView TreeViewTV;
        public  ScrollBar HorizontalScrollBarSB;
        public  TreeViewItem AllTVI;
        public  TreeViewItem AllUsedLayersTVI;
        public  CheckBox InvertFilterCK;
        public  ToolBar ToolBar2TB;
        public  PushButton PushButton3PB;
        public  Pane Pane5PANE;
        public  Table GridLayersTBL;
        public  Pane HorizontalScrollBarPANE;
        public  Pane VerticalScrollBarPANE;
        public  Header ColumnHeaderCTL;
        public  CustomWin StatusWIN;
        public  CustomWin NameWIN;
        public  CustomWin OnWIN;
        public  CustomWin FreezeWIN;
        public  CustomWin LockWIN;
        public  CustomWin PlotWIN;
        public  CustomWin ColorWIN;
        public  CustomWin LinetypeWIN;
        public  CustomWin LineweightWIN;
        public  CustomWin NewVPFreezeWIN;
        public  CustomWin VPFreezeWIN;
        public  CustomWin VPColorWIN;
        public  CustomWin VPLinetypeWIN;
        public  CustomWin VPLineweightWIN;
        public  Pane Pane6PANE;
        public  StatusBar StatusBar1SB;
        public  ToolBar ToolBar3TB;
        public  PushButton PushButton4PB;
        public  PushButton PushButton5PB;
        public  PushButton PushButton6PB;
        public  PushButton PushButton7PB;
        public  StatusBar StatusBar2SB;
        public  TextField TextField2TF;
        public  ToolBar ToolBar4TB;
        public  PushButton PushButton8PB;
        public  PushButton PushButton9PB;
        public  CustomWin CustomWinWIN;
        public  PushButton PushButton10PB;
        public  ToolBar ToolBar5TB;
        public  PushButton PushButton11PB;
        public  PushButton PushButton12PB;
        public  PushButton PushButton13PB;

        partial void OnInitialize();

        public LayerPropertiesManagerDLG()
        {
            InitializeComponent();
            OnInitialize();
        }

        private void InitializeComponent()
        {

            Layer1WIN = new CustomWin()
            {
                Tag = "[CustomWin]Layer|$59423|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Layer1WIN);

            Layer2WIN = new CustomWin()
            {
                Tag = "[CustomWin]Layer|$59423|#1/[CustomWin]Layer|$16721|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Layer2WIN);

            LayerPaletteWIN = new CustomWin()
            {
                Tag = "[CustomWin]Layer|$59423|#1/[CustomWin]Layer|$16721|#1/[CustomWin]Layer Palette|$62|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(LayerPaletteWIN);

            Pane1PANE = new Pane()
            {
                Tag = "[CustomWin]Layer|$59423|#1/[CustomWin]Layer|$16721|#1/[CustomWin]Layer Palette|$62|#1/[Pane]$ControlAxSourcingSite|#1",
                ParentType = this.GetType(),
                Parent = this,
                GUIType = GuiType.UIA,
            };
            DeclaredChildren.Add(Pane1PANE);

            TextField1TF = new TextField()
            {
                Tag = "[CustomWin]Layer|$59423|#1/[CustomWin]Layer|$16721|#1/[CustomWin]Layer Palette|$62|#1/[Pane]$ControlAxSourcingSite|#1/[TextField]$editQuickFilter_|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(TextField1TF);

            PushButton1PB = new PushButton()
            {
                Tag = "[CustomWin]Layer|$59423|#1/[CustomWin]Layer|$16721|#1/[CustomWin]Layer Palette|$62|#1/[Pane]$ControlAxSourcingSite|#1/[TextField]$editQuickFilter_|#1/[PushButton]$1|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(PushButton1PB);

            Pane2PANE = new Pane()
            {
                Tag = "[CustomWin]Layer|$59423|#1/[CustomWin]Layer|$16721|#1/[CustomWin]Layer Palette|$62|#1/[Pane]$ControlAxSourcingSite|#1/[Pane]$splitContainer_|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Pane2PANE);

            Pane3PANE = new Pane()
            {
                Tag = "[CustomWin]Layer|$59423|#1/[CustomWin]Layer|$16721|#1/[CustomWin]Layer Palette|$62|#1/[Pane]$ControlAxSourcingSite|#1/[Pane]$splitContainer_|#1/[Pane]$264800|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Pane3PANE);

            Pane4PANE = new Pane()
            {
                Tag = "[CustomWin]Layer|$59423|#1/[CustomWin]Layer|$16721|#1/[CustomWin]Layer Palette|$62|#1/[Pane]$ControlAxSourcingSite|#1/[Pane]$splitContainer_|#1/[Pane]$264800|#1/[Pane]$tableLayoutPanelTree_|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Pane4PANE);

            FiltersPB = new PushButton()
            {
                Tag = "[CustomWin]Layer|$59423|#1/[CustomWin]Layer|$16721|#1/[CustomWin]Layer Palette|$62|#1/[Pane]$ControlAxSourcingSite|#1/[Pane]$splitContainer_|#1/[Pane]$264800|#1/[Pane]$tableLayoutPanelTree_|#1/[PushButton]Filters|$btnFilterHeader_|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(FiltersPB);

            ToolBar1TB = new ToolBar()
            {
                Tag = "[CustomWin]Layer|$59423|#1/[CustomWin]Layer|$16721|#1/[CustomWin]Layer Palette|$62|#1/[Pane]$ControlAxSourcingSite|#1/[Pane]$splitContainer_|#1/[Pane]$264800|#1/[Pane]$tableLayoutPanelTree_|#1/[ToolBar]$tbFilterHeader_|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ToolBar1TB);

            PushButton2PB = new PushButton()
            {
                Tag = "[CustomWin]Layer|$59423|#1/[CustomWin]Layer|$16721|#1/[CustomWin]Layer Palette|$62|#1/[Pane]$ControlAxSourcingSite|#1/[Pane]$splitContainer_|#1/[Pane]$264800|#1/[Pane]$tableLayoutPanelTree_|#1/[ToolBar]$tbFilterHeader_|#1/[PushButton]$Item 1|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(PushButton2PB);

            TreeViewTV = new TreeView()
            {
                Tag = "[CustomWin]Layer|$59423|#1/[CustomWin]Layer|$16721|#1/[CustomWin]Layer Palette|$62|#1/[Pane]$ControlAxSourcingSite|#1/[Pane]$splitContainer_|#1/[Pane]$264800|#1/[Pane]$tableLayoutPanelTree_|#1/[TreeView]$tvFilters_|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(TreeViewTV);

            HorizontalScrollBarSB = new ScrollBar()
            {
                Tag = "[CustomWin]Layer|$59423|#1/[CustomWin]Layer|$16721|#1/[CustomWin]Layer Palette|$62|#1/[Pane]$ControlAxSourcingSite|#1/[Pane]$splitContainer_|#1/[Pane]$264800|#1/[Pane]$tableLayoutPanelTree_|#1/[TreeView]$tvFilters_|#1/[ScrollBar]Horizontal Scroll Bar|$Horizontal ScrollBar|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(HorizontalScrollBarSB);

            AllTVI = new TreeViewItem()
            {
                Tag = "[CustomWin]Layer|$59423|#1/[CustomWin]Layer|$16721|#1/[CustomWin]Layer Palette|$62|#1/[Pane]$ControlAxSourcingSite|#1/[Pane]$splitContainer_|#1/[Pane]$264800|#1/[Pane]$tableLayoutPanelTree_|#1/[TreeView]$tvFilters_|#1/[TreeViewItem]All|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(AllTVI);

            AllUsedLayersTVI = new TreeViewItem()
            {
                Tag = "[CustomWin]Layer|$59423|#1/[CustomWin]Layer|$16721|#1/[CustomWin]Layer Palette|$62|#1/[Pane]$ControlAxSourcingSite|#1/[Pane]$splitContainer_|#1/[Pane]$264800|#1/[Pane]$tableLayoutPanelTree_|#1/[TreeView]$tvFilters_|#1/[TreeViewItem]All|#1/[TreeViewItem]All Used Layers|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(AllUsedLayersTVI);

            InvertFilterCK = new CheckBox()
            {
                Tag = "[CustomWin]Layer|$59423|#1/[CustomWin]Layer|$16721|#1/[CustomWin]Layer Palette|$62|#1/[Pane]$ControlAxSourcingSite|#1/[Pane]$splitContainer_|#1/[Pane]$264800|#1/[Pane]$tableLayoutPanelTree_|#1/[CheckBox]Invert filter|$checkBoxInvert_|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(InvertFilterCK);

            ToolBar2TB = new ToolBar()
            {
                Tag = "[CustomWin]Layer|$59423|#1/[CustomWin]Layer|$16721|#1/[CustomWin]Layer Palette|$62|#1/[Pane]$ControlAxSourcingSite|#1/[Pane]$splitContainer_|#1/[Pane]$264800|#1/[Pane]$tableLayoutPanelTree_|#1/[ToolBar]$tbFilterFooter_|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ToolBar2TB);

            PushButton3PB = new PushButton()
            {
                Tag = "[CustomWin]Layer|$59423|#1/[CustomWin]Layer|$16721|#1/[CustomWin]Layer Palette|$62|#1/[Pane]$ControlAxSourcingSite|#1/[Pane]$splitContainer_|#1/[Pane]$264800|#1/[Pane]$tableLayoutPanelTree_|#1/[ToolBar]$tbFilterFooter_|#2/[PushButton]$Item 1|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(PushButton3PB);

            Pane5PANE = new Pane()
            {
                Tag = "[CustomWin]Layer|$59423|#1/[CustomWin]Layer|$16721|#1/[CustomWin]Layer Palette|$62|#1/[Pane]$ControlAxSourcingSite|#1/[Pane]$splitContainer_|#1/[Pane]$199316|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Pane5PANE);

            GridLayersTBL = new Table()
            {
                Tag = "[CustomWin]Layer|$59423|#1/[CustomWin]Layer|$16721|#1/[CustomWin]Layer Palette|$62|#1/[Pane]$ControlAxSourcingSite|#1/[Pane]$splitContainer_|#1/[Pane]$199316|#2/[Table]gridLayers_|$gridLayers_|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(GridLayersTBL);

            HorizontalScrollBarPANE = new Pane()
            {
                Tag = "[CustomWin]Layer|$59423|#1/[CustomWin]Layer|$16721|#1/[CustomWin]Layer Palette|$62|#1/[Pane]$ControlAxSourcingSite|#1/[Pane]$splitContainer_|#1/[Pane]$199316|#2/[Table]gridLayers_|$gridLayers_|#1/[Pane]Horizontal Scroll Bar|$199310|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(HorizontalScrollBarPANE);

            VerticalScrollBarPANE = new Pane()
            {
                Tag = "[CustomWin]Layer|$59423|#1/[CustomWin]Layer|$16721|#1/[CustomWin]Layer Palette|$62|#1/[Pane]$ControlAxSourcingSite|#1/[Pane]$splitContainer_|#1/[Pane]$199316|#2/[Table]gridLayers_|$gridLayers_|#1/[Pane]Vertical Scroll Bar|$68260|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(VerticalScrollBarPANE);

            ColumnHeaderCTL = new Header()
            {
                Tag = "[CustomWin]Layer|$59423|#1/[CustomWin]Layer|$16721|#1/[CustomWin]Layer Palette|$62|#1/[Pane]$ControlAxSourcingSite|#1/[Pane]$splitContainer_|#1/[Pane]$199316|#2/[Table]gridLayers_|$gridLayers_|#1/[Header]Column Header|$Column Header|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ColumnHeaderCTL);

            StatusWIN = new CustomWin()
            {
                Tag = "[CustomWin]Layer|$59423|#1/[CustomWin]Layer|$16721|#1/[CustomWin]Layer Palette|$62|#1/[Pane]$ControlAxSourcingSite|#1/[Pane]$splitContainer_|#1/[Pane]$199316|#2/[Table]gridLayers_|$gridLayers_|#1/[Header]Column Header|$Column Header|#1/[CustomWin]Status|$Status|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(StatusWIN);

            NameWIN = new CustomWin()
            {
                Tag = "[CustomWin]Layer|$59423|#1/[CustomWin]Layer|$16721|#1/[CustomWin]Layer Palette|$62|#1/[Pane]$ControlAxSourcingSite|#1/[Pane]$splitContainer_|#1/[Pane]$199316|#2/[Table]gridLayers_|$gridLayers_|#1/[Header]Column Header|$Column Header|#1/[CustomWin]Name|$Name|#3",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(NameWIN);

            OnWIN = new CustomWin()
            {
                Tag = "[CustomWin]Layer|$59423|#1/[CustomWin]Layer|$16721|#1/[CustomWin]Layer Palette|$62|#1/[Pane]$ControlAxSourcingSite|#1/[Pane]$splitContainer_|#1/[Pane]$199316|#2/[Table]gridLayers_|$gridLayers_|#1/[Header]Column Header|$Column Header|#1/[CustomWin]On|$On|#4",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(OnWIN);

            FreezeWIN = new CustomWin()
            {
                Tag = "[CustomWin]Layer|$59423|#1/[CustomWin]Layer|$16721|#1/[CustomWin]Layer Palette|$62|#1/[Pane]$ControlAxSourcingSite|#1/[Pane]$splitContainer_|#1/[Pane]$199316|#2/[Table]gridLayers_|$gridLayers_|#1/[Header]Column Header|$Column Header|#1/[CustomWin]Freeze|$Freeze|#5",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(FreezeWIN);

            LockWIN = new CustomWin()
            {
                Tag = "[CustomWin]Layer|$59423|#1/[CustomWin]Layer|$16721|#1/[CustomWin]Layer Palette|$62|#1/[Pane]$ControlAxSourcingSite|#1/[Pane]$splitContainer_|#1/[Pane]$199316|#2/[Table]gridLayers_|$gridLayers_|#1/[Header]Column Header|$Column Header|#1/[CustomWin]Lock|$Lock|#7",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(LockWIN);

            PlotWIN = new CustomWin()
            {
                Tag = "[CustomWin]Layer|$59423|#1/[CustomWin]Layer|$16721|#1/[CustomWin]Layer Palette|$62|#1/[Pane]$ControlAxSourcingSite|#1/[Pane]$splitContainer_|#1/[Pane]$199316|#2/[Table]gridLayers_|$gridLayers_|#1/[Header]Column Header|$Column Header|#1/[CustomWin]Plot|$Plot|#8",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(PlotWIN);

            ColorWIN = new CustomWin()
            {
                Tag = "[CustomWin]Layer|$59423|#1/[CustomWin]Layer|$16721|#1/[CustomWin]Layer Palette|$62|#1/[Pane]$ControlAxSourcingSite|#1/[Pane]$splitContainer_|#1/[Pane]$199316|#2/[Table]gridLayers_|$gridLayers_|#1/[Header]Column Header|$Column Header|#1/[CustomWin]Color|$Color|#9",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ColorWIN);

            LinetypeWIN = new CustomWin()
            {
                Tag = "[CustomWin]Layer|$59423|#1/[CustomWin]Layer|$16721|#1/[CustomWin]Layer Palette|$62|#1/[Pane]$ControlAxSourcingSite|#1/[Pane]$splitContainer_|#1/[Pane]$199316|#2/[Table]gridLayers_|$gridLayers_|#1/[Header]Column Header|$Column Header|#1/[CustomWin]Linetype|$Linetype|#11",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(LinetypeWIN);

            LineweightWIN = new CustomWin()
            {
                Tag = "[CustomWin]Layer|$59423|#1/[CustomWin]Layer|$16721|#1/[CustomWin]Layer Palette|$62|#1/[Pane]$ControlAxSourcingSite|#1/[Pane]$splitContainer_|#1/[Pane]$199316|#2/[Table]gridLayers_|$gridLayers_|#1/[Header]Column Header|$Column Header|#1/[CustomWin]Lineweight|$Lineweight|#13",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(LineweightWIN);

            NewVPFreezeWIN = new CustomWin()
            {
                Tag = "[CustomWin]Layer|$59423|#1/[CustomWin]Layer|$16721|#1/[CustomWin]Layer Palette|$62|#1/[Pane]$ControlAxSourcingSite|#1/[Pane]$splitContainer_|#1/[Pane]$199316|#2/[Table]gridLayers_|$gridLayers_|#1/[Header]Column Header|$Column Header|#1/[CustomWin]New VP Freeze|$New VP Freeze|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(NewVPFreezeWIN);

            VPFreezeWIN = new CustomWin()
            {
                Tag = "[CustomWin]Layer|$59423|#1/[CustomWin]Layer|$16721|#1/[CustomWin]Layer Palette|$62|#1/[Pane]$ControlAxSourcingSite|#1/[Pane]$splitContainer_|#1/[Pane]$199316|#2/[Table]gridLayers_|$gridLayers_|#1/[Header]Column Header|$Column Header|#1/[CustomWin]VP Freeze|$VP Freeze|#6",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(VPFreezeWIN);

            VPColorWIN = new CustomWin()
            {
                Tag = "[CustomWin]Layer|$59423|#1/[CustomWin]Layer|$16721|#1/[CustomWin]Layer Palette|$62|#1/[Pane]$ControlAxSourcingSite|#1/[Pane]$splitContainer_|#1/[Pane]$199316|#2/[Table]gridLayers_|$gridLayers_|#1/[Header]Column Header|$Column Header|#1/[CustomWin]VP Color|$VP Color|#10",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(VPColorWIN);

            VPLinetypeWIN = new CustomWin()
            {
                Tag = "[CustomWin]Layer|$59423|#1/[CustomWin]Layer|$16721|#1/[CustomWin]Layer Palette|$62|#1/[Pane]$ControlAxSourcingSite|#1/[Pane]$splitContainer_|#1/[Pane]$199316|#2/[Table]gridLayers_|$gridLayers_|#1/[Header]Column Header|$Column Header|#1/[CustomWin]VP Linetype|$VP Linetype|#12",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(VPLinetypeWIN);

            VPLineweightWIN = new CustomWin()
            {
                Tag = "[CustomWin]Layer|$59423|#1/[CustomWin]Layer|$16721|#1/[CustomWin]Layer Palette|$62|#1/[Pane]$ControlAxSourcingSite|#1/[Pane]$splitContainer_|#1/[Pane]$199316|#2/[Table]gridLayers_|$gridLayers_|#1/[Header]Column Header|$Column Header|#1/[CustomWin]VP Lineweight|$VP Lineweight|#14",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(VPLineweightWIN);

            Pane6PANE = new Pane()
            {
                Tag = "[CustomWin]Layer|$59423|#1/[CustomWin]Layer|$16721|#1/[CustomWin]Layer Palette|$62|#1/[Pane]$ControlAxSourcingSite|#1/[Pane]$panelOverall_|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Pane6PANE);

            StatusBar1SB = new StatusBar()
            {
                Tag = "[CustomWin]Layer|$59423|#1/[CustomWin]Layer|$16721|#1/[CustomWin]Layer Palette|$62|#1/[Pane]$ControlAxSourcingSite|#1/[Pane]$panelOverall_|#2/[StatusBar]$statusBarOverall_|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(StatusBar1SB);

            ToolBar3TB = new ToolBar()
            {
                Tag = "[CustomWin]Layer|$59423|#1/[CustomWin]Layer|$16721|#1/[CustomWin]Layer Palette|$62|#1/[Pane]$ControlAxSourcingSite|#1/[ToolBar]$tbList_|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ToolBar3TB);

            PushButton4PB = new PushButton()
            {
                Tag = "[CustomWin]Layer|$59423|#1/[CustomWin]Layer|$16721|#1/[CustomWin]Layer Palette|$62|#1/[Pane]$ControlAxSourcingSite|#1/[ToolBar]$tbList_|#2/[PushButton]#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(PushButton4PB);

            PushButton5PB = new PushButton()
            {
                Tag = "[CustomWin]Layer|$59423|#1/[CustomWin]Layer|$16721|#1/[CustomWin]Layer Palette|$62|#1/[Pane]$ControlAxSourcingSite|#1/[ToolBar]$tbList_|#2/[PushButton]$Item 1|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(PushButton5PB);

            PushButton6PB = new PushButton()
            {
                Tag = "[CustomWin]Layer|$59423|#1/[CustomWin]Layer|$16721|#1/[CustomWin]Layer Palette|$62|#1/[Pane]$ControlAxSourcingSite|#1/[ToolBar]$tbList_|#2/[PushButton]$Item 2|#3",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(PushButton6PB);

            PushButton7PB = new PushButton()
            {
                Tag = "[CustomWin]Layer|$59423|#1/[CustomWin]Layer|$16721|#1/[CustomWin]Layer Palette|$62|#1/[Pane]$ControlAxSourcingSite|#1/[ToolBar]$tbList_|#2/[PushButton]$Item 3|#4",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(PushButton7PB);

            StatusBar2SB = new StatusBar()
            {
                Tag = "[CustomWin]Layer|$59423|#1/[CustomWin]Layer|$16721|#1/[CustomWin]Layer Palette|$62|#1/[Pane]$ControlAxSourcingSite|#1/[StatusBar]$statusBar_|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(StatusBar2SB);

            TextField2TF = new TextField()
            {
                Tag = "[CustomWin]Layer|$59423|#1/[CustomWin]Layer|$16721|#1/[CustomWin]Layer Palette|$62|#1/[Pane]$ControlAxSourcingSite|#1/[StatusBar]$statusBar_|#1/[TextField]$StatusBar.Pane0|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(TextField2TF);

            ToolBar4TB = new ToolBar()
            {
                Tag = "[CustomWin]Layer|$59423|#1/[CustomWin]Layer|$16721|#1/[CustomWin]Layer Palette|$62|#1/[Pane]$ControlAxSourcingSite|#1/[ToolBar]$tbTree_|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ToolBar4TB);

            PushButton8PB = new PushButton()
            {
                Tag = "[CustomWin]Layer|$59423|#1/[CustomWin]Layer|$16721|#1/[CustomWin]Layer Palette|$62|#1/[Pane]$ControlAxSourcingSite|#1/[ToolBar]$tbTree_|#1/[PushButton]#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(PushButton8PB);

            PushButton9PB = new PushButton()
            {
                Tag = "[CustomWin]Layer|$59423|#1/[CustomWin]Layer|$16721|#1/[CustomWin]Layer Palette|$62|#1/[Pane]$ControlAxSourcingSite|#1/[ToolBar]$tbTree_|#1/[PushButton]$Item 1|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(PushButton9PB);

            CustomWinWIN = new CustomWin()
            {
                Tag = "[CustomWin]Layer|$59423|#1/[CustomWin]Layer|$16721|#1/[CustomWin]Layer Palette|$62|#1/[Pane]$ControlAxSourcingSite|#1/[ToolBar]$tbTree_|#1/[CustomWin]$Item 2|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(CustomWinWIN);

            PushButton10PB = new PushButton()
            {
                Tag = "[CustomWin]Layer|$59423|#1/[CustomWin]Layer|$16721|#1/[CustomWin]Layer Palette|$62|#1/[Pane]$ControlAxSourcingSite|#1/[ToolBar]$tbTree_|#1/[PushButton]$Item 3|#3",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(PushButton10PB);

            ToolBar5TB = new ToolBar()
            {
                Tag = "[CustomWin]Layer|$59423|#1/[CustomWin]Layer|$16721|#1/[CustomWin]Layer Palette|$62|#1/[Pane]$ControlAxSourcingSite|#1/[ToolBar]$tbSettings_|#3",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ToolBar5TB);

            PushButton11PB = new PushButton()
            {
                Tag = "[CustomWin]Layer|$59423|#1/[CustomWin]Layer|$16721|#1/[CustomWin]Layer Palette|$62|#1/[Pane]$ControlAxSourcingSite|#1/[ToolBar]$tbSettings_|#3/[PushButton]#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(PushButton11PB);

            PushButton12PB = new PushButton()
            {
                Tag = "[CustomWin]Layer|$59423|#1/[CustomWin]Layer|$16721|#1/[CustomWin]Layer Palette|$62|#1/[Pane]$ControlAxSourcingSite|#1/[ToolBar]$tbSettings_|#3/[PushButton]$Item 1|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(PushButton12PB);

            PushButton13PB = new PushButton()
            {
                Tag = "[CustomWin]Layer|$59423|#1/[CustomWin]Layer|$16721|#1/[CustomWin]Layer Palette|$62|#1/[Pane]$ControlAxSourcingSite|#1/[ToolBar]$tbSettings_|#3/[PushButton]$Item 2|#3",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(PushButton13PB);
        }
    }
}
