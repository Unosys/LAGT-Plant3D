// This file is auto-generated - do not hand edit this file.

using Autodesk.GUIHarness;
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{

    [UIElement(Tag = "[CustomWin]#3", Parent = typeof(Plant3D))]
    public partial class PandIDDataManagerDLG : CustomWin
    {
        public  CustomWin CustomWin1WIN;
        public  CustomWin CustomWin2WIN;
        public  CustomWin PnPDataGridWIN;
        public  Pane Pane1PANE;
        public  PushButton PushButton1PB;
        public  PopupList PopupListPL;
        public  PushButton DropDownButtonPB;
        public  Pane Pane2PANE;
        public  PushButton PushButton2PB;
        public  TextField TextField1TF;
        public  ToolBar ImportToolStrip1TB;
        public  CustomWin CustomWin3WIN;
        public  PushButton RefreshPB;
        public  PushButton SynchronizePIDSymbolsAndPB;
        public  PushButton HideBlankColumnsPB;
        public  PushButton ClearFilterPB;
        public  CustomWin CustomWin4WIN;
        public  PushButton ZoomPB;
        public  PushButton ShowSelectedPB;
        public  ToolBar ImportToolStrip2TB;
        public  CustomWin CustomWin5WIN;
        public  PushButton PrintPB;
        public  PushButton ExportPB;
        public  CustomWin CustomWin6WIN;
        public  PushButton ImportPB;
        public  PushButton AcceptPB;
        public  PushButton RejectPB;
        public  PushButton AcceptAllPB;
        public  PushButton RejectAllPB;
        public  PushButton HideRevisionCloudsPB;
        public  Pane Pane3PANE;
        public  Pane Pane4PANE;
        public  Pane Pane5PANE;
        public  Table DataGridViewTBL;
        public  CustomWin TopRowWIN;
        public  Header TopLeftHeaderCellCTL;
        public  Header DescriptionCTL;
        public  Header ManufacturerCTL;
        public  Header ModelNumberCTL;
        public  Header SupplierCTL;
        public  Header CommentCTL;
        public  Header ClassNameCTL;
        public  Header PnPIDCTL;
        public  CustomWin Row0WIN;
        public  Header Row0CTL;
        public  CustomWin DescriptionRow0WIN;
        public  CustomWin ManufacturerRow0WIN;
        public  CustomWin ModelNumberRow0WIN;
        public  CustomWin SupplierRow0WIN;
        public  CustomWin CommentRow0WIN;
        public  CustomWin ClassNameRow0WIN;
        public  CustomWin PnPIDRow0WIN;
        public  Pane Pane6PANE;
        public  Pane Pane7PANE;
        public  Pane Pane8PANE;
        public  PushButton PushButton3PB;
        public  PushButton Of1PB;
        public  StaticText Of1ST;
        public  TextField TextField2TF;
        public  StaticText RecordST;
        public  PushButton Record1PB;
        public  PushButton Record2PB;
        public  Pane Pane9PANE;
        public  Pane Pane10PANE;
        public  Pane Pane11PANE;
        public  Pane Pane12PANE;
        public  TreeView TreeViewTV;
        public  TreeViewItem EngineeringItemsTVI;
        public  TreeViewItem LinesTVI;
        public  TreeViewItem PipeLineGroupTVI;
        public  TreeViewItem PipeLineSegmentsTVI;
        public  TreeViewItem PrimaryLineSegmentTVI;
        public  TreeViewItem NonEngineeringItemsTVI;
        public  TreeViewItem FlowArrowTVI;

        partial void OnInitialize();

        public PandIDDataManagerDLG()
        {
            InitializeComponent();
            OnInitialize();
        }

        private void InitializeComponent()
        {

            CustomWin1WIN = new CustomWin()
            {
                Tag = "[CustomWin]$59423|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(CustomWin1WIN);

            CustomWin2WIN = new CustomWin()
            {
                Tag = "[CustomWin]$59423|#1/[CustomWin]$16722|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(CustomWin2WIN);

            PnPDataGridWIN = new CustomWin()
            {
                Tag = "[CustomWin]$59423|#1/[CustomWin]$16722|#1/[CustomWin]PnPDataGrid|$10|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(PnPDataGridWIN);

            Pane1PANE = new Pane()
            {
                Tag = "[CustomWin]$59423|#1/[CustomWin]$16722|#1/[CustomWin]PnPDataGrid|$10|#1/[Pane]$ControlAxSourcingSite|#1",
                ParentType = this.GetType(),
                Parent = this,
                GUIType = GuiType.UIA,
            };
            DeclaredChildren.Add(Pane1PANE);

            PushButton1PB = new PushButton()
            {
                Tag = "[CustomWin]$59423|#1/[CustomWin]$16722|#1/[CustomWin]PnPDataGrid|$10|#1/[Pane]$ControlAxSourcingSite|#1/[PushButton]$m_btnSearch|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(PushButton1PB);

            PopupListPL = new PopupList()
            {
                Tag = "[CustomWin]$59423|#1/[CustomWin]$16722|#1/[CustomWin]PnPDataGrid|$10|#1/[Pane]$ControlAxSourcingSite|#1/[PopupList]$m_dataModeCombo|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(PopupListPL);

            DropDownButtonPB = new PushButton()
            {
                Tag = "[CustomWin]$59423|#1/[CustomWin]$16722|#1/[CustomWin]PnPDataGrid|$10|#1/[Pane]$ControlAxSourcingSite|#1/[PopupList]$m_dataModeCombo|#1/[PushButton]Drop Down Button|$DropDown|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(DropDownButtonPB);

            Pane2PANE = new Pane()
            {
                Tag = "[CustomWin]$59423|#1/[CustomWin]$16722|#1/[CustomWin]PnPDataGrid|$10|#1/[Pane]$ControlAxSourcingSite|#1/[Pane]$panel1|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Pane2PANE);

            PushButton2PB = new PushButton()
            {
                Tag = "[CustomWin]$59423|#1/[CustomWin]$16722|#1/[CustomWin]PnPDataGrid|$10|#1/[Pane]$ControlAxSourcingSite|#1/[Pane]$panel1|#1/[PushButton]$m_btnChevron|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(PushButton2PB);

            TextField1TF = new TextField()
            {
                Tag = "[CustomWin]$59423|#1/[CustomWin]$16722|#1/[CustomWin]PnPDataGrid|$10|#1/[Pane]$ControlAxSourcingSite|#1/[Pane]$panel1|#1/[TextField]$m_textBoxSearch|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(TextField1TF);

            ImportToolStrip1TB = new ToolBar()
            {
                Tag = "[CustomWin]$59423|#1/[CustomWin]$16722|#1/[CustomWin]PnPDataGrid|$10|#1/[Pane]$ControlAxSourcingSite|#1/[Pane]$panel1|#1/[ToolBar]ImportToolStrip|$m_toolStripExport|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ImportToolStrip1TB);

            CustomWin3WIN = new CustomWin()
            {
                Tag = "[CustomWin]$59423|#1/[CustomWin]$16722|#1/[CustomWin]PnPDataGrid|$10|#1/[Pane]$ControlAxSourcingSite|#1/[Pane]$panel1|#1/[ToolBar]ImportToolStrip|$m_toolStripExport|#1/[CustomWin]#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(CustomWin3WIN);

            RefreshPB = new PushButton()
            {
                Tag = "[CustomWin]$59423|#1/[CustomWin]$16722|#1/[CustomWin]PnPDataGrid|$10|#1/[Pane]$ControlAxSourcingSite|#1/[Pane]$panel1|#1/[ToolBar]ImportToolStrip|$m_toolStripExport|#1/[PushButton]Refresh|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(RefreshPB);

            SynchronizePIDSymbolsAndPB = new PushButton()
            {
                Tag = "[CustomWin]$59423|#1/[CustomWin]$16722|#1/[CustomWin]PnPDataGrid|$10|#1/[Pane]$ControlAxSourcingSite|#1/[Pane]$panel1|#1/[ToolBar]ImportToolStrip|$m_toolStripExport|#1/[PushButton]Synchronize PID Symbols and Annotations|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(SynchronizePIDSymbolsAndPB);

            HideBlankColumnsPB = new PushButton()
            {
                Tag = "[CustomWin]$59423|#1/[CustomWin]$16722|#1/[CustomWin]PnPDataGrid|$10|#1/[Pane]$ControlAxSourcingSite|#1/[Pane]$panel1|#1/[ToolBar]ImportToolStrip|$m_toolStripExport|#1/[PushButton]Hide Blank Columns|#3",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(HideBlankColumnsPB);

            ClearFilterPB = new PushButton()
            {
                Tag = "[CustomWin]$59423|#1/[CustomWin]$16722|#1/[CustomWin]PnPDataGrid|$10|#1/[Pane]$ControlAxSourcingSite|#1/[Pane]$panel1|#1/[ToolBar]ImportToolStrip|$m_toolStripExport|#1/[PushButton]Clear Filter|#4",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ClearFilterPB);

            CustomWin4WIN = new CustomWin()
            {
                Tag = "[CustomWin]$59423|#1/[CustomWin]$16722|#1/[CustomWin]PnPDataGrid|$10|#1/[Pane]$ControlAxSourcingSite|#1/[Pane]$panel1|#1/[ToolBar]ImportToolStrip|$m_toolStripExport|#1/[CustomWin]#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(CustomWin4WIN);

            ZoomPB = new PushButton()
            {
                Tag = "[CustomWin]$59423|#1/[CustomWin]$16722|#1/[CustomWin]PnPDataGrid|$10|#1/[Pane]$ControlAxSourcingSite|#1/[Pane]$panel1|#1/[ToolBar]ImportToolStrip|$m_toolStripExport|#1/[PushButton]Zoom|#5",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ZoomPB);

            ShowSelectedPB = new PushButton()
            {
                Tag = "[CustomWin]$59423|#1/[CustomWin]$16722|#1/[CustomWin]PnPDataGrid|$10|#1/[Pane]$ControlAxSourcingSite|#1/[Pane]$panel1|#1/[ToolBar]ImportToolStrip|$m_toolStripExport|#1/[PushButton]Show Selected|#6",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ShowSelectedPB);

            ImportToolStrip2TB = new ToolBar()
            {
                Tag = "[CustomWin]$59423|#1/[CustomWin]$16722|#1/[CustomWin]PnPDataGrid|$10|#1/[Pane]$ControlAxSourcingSite|#1/[Pane]$panel1|#1/[ToolBar]ImportToolStrip|$m_toolStripImport|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ImportToolStrip2TB);

            CustomWin5WIN = new CustomWin()
            {
                Tag = "[CustomWin]$59423|#1/[CustomWin]$16722|#1/[CustomWin]PnPDataGrid|$10|#1/[Pane]$ControlAxSourcingSite|#1/[Pane]$panel1|#1/[ToolBar]ImportToolStrip|$m_toolStripImport|#2/[CustomWin]#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(CustomWin5WIN);

            PrintPB = new PushButton()
            {
                Tag = "[CustomWin]$59423|#1/[CustomWin]$16722|#1/[CustomWin]PnPDataGrid|$10|#1/[Pane]$ControlAxSourcingSite|#1/[Pane]$panel1|#1/[ToolBar]ImportToolStrip|$m_toolStripImport|#2/[PushButton]Print|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(PrintPB);

            ExportPB = new PushButton()
            {
                Tag = "[CustomWin]$59423|#1/[CustomWin]$16722|#1/[CustomWin]PnPDataGrid|$11|#1/[Pane]$ControlAxSourcingSite|#1/[Pane]$panel1|#1/[ToolBar]ImportToolStrip|$m_toolStripImport|#2/[PushButton]#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ExportPB);

            CustomWin6WIN = new CustomWin()
            {
                Tag = "[CustomWin]$59423|#1/[CustomWin]$16722|#1/[CustomWin]PnPDataGrid|$11|#1/[Pane]$ControlAxSourcingSite|#1/[Pane]$panel1|#1/[ToolBar]ImportToolStrip|$m_toolStripImport|#2/[CustomWin]#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(CustomWin6WIN);

            ImportPB = new PushButton()
            {
                Tag = "[CustomWin]$59423|#1/[CustomWin]$16722|#1/[CustomWin]PnPDataGrid|$11|#1/[Pane]$ControlAxSourcingSite|#1/[Pane]$panel1|#1/[ToolBar]ImportToolStrip|$m_toolStripImport|#2/[PushButton]#3",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ImportPB);

            AcceptPB = new PushButton()
            {
                Tag = "[CustomWin]$59423|#1/[CustomWin]$16722|#1/[CustomWin]PnPDataGrid|$11|#1/[Pane]$ControlAxSourcingSite|#1/[Pane]$panel1|#1/[ToolBar]ImportToolStrip|$m_toolStripImport|#2/[PushButton]Accept|#4",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(AcceptPB);

            RejectPB = new PushButton()
            {
                Tag = "[CustomWin]$59423|#1/[CustomWin]$16722|#1/[CustomWin]PnPDataGrid|$11|#1/[Pane]$ControlAxSourcingSite|#1/[Pane]$panel1|#1/[ToolBar]ImportToolStrip|$m_toolStripImport|#2/[PushButton]Reject|#5",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(RejectPB);

            AcceptAllPB = new PushButton()
            {
                Tag = "[CustomWin]$59423|#1/[CustomWin]$16722|#1/[CustomWin]PnPDataGrid|$11|#1/[Pane]$ControlAxSourcingSite|#1/[Pane]$panel1|#1/[ToolBar]ImportToolStrip|$m_toolStripImport|#2/[PushButton]Accept All|#6",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(AcceptAllPB);

            RejectAllPB = new PushButton()
            {
                Tag = "[CustomWin]$59423|#1/[CustomWin]$16722|#1/[CustomWin]PnPDataGrid|$11|#1/[Pane]$ControlAxSourcingSite|#1/[Pane]$panel1|#1/[ToolBar]ImportToolStrip|$m_toolStripImport|#2/[PushButton]Reject All|#7",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(RejectAllPB);

            HideRevisionCloudsPB = new PushButton()
            {
                Tag = "[CustomWin]$59423|#1/[CustomWin]$16722|#1/[CustomWin]PnPDataGrid|$10|#1/[Pane]$ControlAxSourcingSite|#1/[Pane]$panel1|#1/[ToolBar]ImportToolStrip|$m_toolStripImport|#2/[PushButton]Hide Revision Clouds|#8",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(HideRevisionCloudsPB);

            Pane3PANE = new Pane()
            {
                Tag = "[CustomWin]$59423|#1/[CustomWin]$16722|#1/[CustomWin]PnPDataGrid|$10|#1/[Pane]$ControlAxSourcingSite|#1/[Pane]$m_dataGridPanel|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Pane3PANE);

            Pane4PANE = new Pane()
            {
                Tag = "[CustomWin]$59423|#1/[CustomWin]$16722|#1/[CustomWin]PnPDataGrid|$10|#1/[Pane]$ControlAxSourcingSite|#1/[Pane]$m_dataGridPanel|#2/[Pane]$m_gridView|#3",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Pane4PANE);

            Pane5PANE = new Pane()
            {
                Tag = "[CustomWin]$59423|#1/[CustomWin]$16722|#1/[CustomWin]PnPDataGrid|$10|#1/[Pane]$ControlAxSourcingSite|#1/[Pane]$m_dataGridPanel|#2/[Pane]$m_gridView|#3/[Pane]$m_dataGridPanel|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Pane5PANE);

            DataGridViewTBL = new Table()
            {
                Tag = "[CustomWin]$59423|#1/[CustomWin]$16722|#1/[CustomWin]PnPDataGrid|$10|#1/[Pane]$ControlAxSourcingSite|#1/[Pane]$m_dataGridPanel|#2/[Pane]$m_gridView|#3/[Pane]$m_dataGridPanel|#1/[Table]DataGridView|$m_pnIDDataGridView|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(DataGridViewTBL);

            TopRowWIN = new CustomWin()
            {
                Tag = "[CustomWin]$59423|#1/[CustomWin]$16722|#1/[CustomWin]PnPDataGrid|$10|#1/[Pane]$ControlAxSourcingSite|#1/[Pane]$m_dataGridPanel|#2/[Pane]$m_gridView|#3/[Pane]$m_dataGridPanel|#1/[Table]DataGridView|$m_pnIDDataGridView|#1/[CustomWin]Top Row|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(TopRowWIN);

            TopLeftHeaderCellCTL = new Header()
            {
                Tag = "[CustomWin]$59423|#1/[CustomWin]$16722|#1/[CustomWin]PnPDataGrid|$10|#1/[Pane]$ControlAxSourcingSite|#1/[Pane]$m_dataGridPanel|#2/[Pane]$m_gridView|#3/[Pane]$m_dataGridPanel|#1/[Table]DataGridView|$m_pnIDDataGridView|#1/[CustomWin]Top Row|#1/[Header]Top Left Header Cell|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(TopLeftHeaderCellCTL);

            DescriptionCTL = new Header()
            {
                Tag = "[CustomWin]$59423|#1/[CustomWin]$16722|#1/[CustomWin]PnPDataGrid|$10|#1/[Pane]$ControlAxSourcingSite|#1/[Pane]$m_dataGridPanel|#2/[Pane]$m_gridView|#3/[Pane]$m_dataGridPanel|#1/[Table]DataGridView|$m_pnIDDataGridView|#1/[CustomWin]Top Row|#1/[Header]Description|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(DescriptionCTL);

            ManufacturerCTL = new Header()
            {
                Tag = "[CustomWin]$59423|#1/[CustomWin]$16722|#1/[CustomWin]PnPDataGrid|$10|#1/[Pane]$ControlAxSourcingSite|#1/[Pane]$m_dataGridPanel|#2/[Pane]$m_gridView|#3/[Pane]$m_dataGridPanel|#1/[Table]DataGridView|$m_pnIDDataGridView|#1/[CustomWin]Top Row|#1/[Header]Manufacturer|#3",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ManufacturerCTL);

            ModelNumberCTL = new Header()
            {
                Tag = "[CustomWin]$59423|#1/[CustomWin]$16722|#1/[CustomWin]PnPDataGrid|$10|#1/[Pane]$ControlAxSourcingSite|#1/[Pane]$m_dataGridPanel|#2/[Pane]$m_gridView|#3/[Pane]$m_dataGridPanel|#1/[Table]DataGridView|$m_pnIDDataGridView|#1/[CustomWin]Top Row|#1/[Header]Model Number|#4",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ModelNumberCTL);

            SupplierCTL = new Header()
            {
                Tag = "[CustomWin]$59423|#1/[CustomWin]$16722|#1/[CustomWin]PnPDataGrid|$10|#1/[Pane]$ControlAxSourcingSite|#1/[Pane]$m_dataGridPanel|#2/[Pane]$m_gridView|#3/[Pane]$m_dataGridPanel|#1/[Table]DataGridView|$m_pnIDDataGridView|#1/[CustomWin]Top Row|#1/[Header]Supplier|#5",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(SupplierCTL);

            CommentCTL = new Header()
            {
                Tag = "[CustomWin]$59423|#1/[CustomWin]$16722|#1/[CustomWin]PnPDataGrid|$10|#1/[Pane]$ControlAxSourcingSite|#1/[Pane]$m_dataGridPanel|#2/[Pane]$m_gridView|#3/[Pane]$m_dataGridPanel|#1/[Table]DataGridView|$m_pnIDDataGridView|#1/[CustomWin]Top Row|#1/[Header]Comment|#6",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(CommentCTL);

            ClassNameCTL = new Header()
            {
                Tag = "[CustomWin]$59423|#1/[CustomWin]$16722|#1/[CustomWin]PnPDataGrid|$10|#1/[Pane]$ControlAxSourcingSite|#1/[Pane]$m_dataGridPanel|#2/[Pane]$m_gridView|#3/[Pane]$m_dataGridPanel|#1/[Table]DataGridView|$m_pnIDDataGridView|#1/[CustomWin]Top Row|#1/[Header]Class Name|#7",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ClassNameCTL);

            PnPIDCTL = new Header()
            {
                Tag = "[CustomWin]$59423|#1/[CustomWin]$16722|#1/[CustomWin]PnPDataGrid|$10|#1/[Pane]$ControlAxSourcingSite|#1/[Pane]$m_dataGridPanel|#2/[Pane]$m_gridView|#3/[Pane]$m_dataGridPanel|#1/[Table]DataGridView|$m_pnIDDataGridView|#1/[CustomWin]Top Row|#1/[Header]PnPID|#8",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(PnPIDCTL);

            Row0WIN = new CustomWin()
            {
                Tag = "[CustomWin]$59423|#1/[CustomWin]$16722|#1/[CustomWin]PnPDataGrid|$10|#1/[Pane]$ControlAxSourcingSite|#1/[Pane]$m_dataGridPanel|#2/[Pane]$m_gridView|#3/[Pane]$m_dataGridPanel|#1/[Table]DataGridView|$m_pnIDDataGridView|#1/[CustomWin]Row 0|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Row0WIN);

            Row0CTL = new Header()
            {
                Tag = "[CustomWin]$59423|#1/[CustomWin]$16722|#1/[CustomWin]PnPDataGrid|$10|#1/[Pane]$ControlAxSourcingSite|#1/[Pane]$m_dataGridPanel|#2/[Pane]$m_gridView|#3/[Pane]$m_dataGridPanel|#1/[Table]DataGridView|$m_pnIDDataGridView|#1/[CustomWin]Row 0|#2/[Header]Row 0|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Row0CTL);

            DescriptionRow0WIN = new CustomWin()
            {
                Tag = "[CustomWin]$59423|#1/[CustomWin]$16722|#1/[CustomWin]PnPDataGrid|$10|#1/[Pane]$ControlAxSourcingSite|#1/[Pane]$m_dataGridPanel|#2/[Pane]$m_gridView|#3/[Pane]$m_dataGridPanel|#1/[Table]DataGridView|$m_pnIDDataGridView|#1/[CustomWin]Row 0|#2/[CustomWin]Description Row 0|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(DescriptionRow0WIN);

            ManufacturerRow0WIN = new CustomWin()
            {
                Tag = "[CustomWin]$59423|#1/[CustomWin]$16722|#1/[CustomWin]PnPDataGrid|$10|#1/[Pane]$ControlAxSourcingSite|#1/[Pane]$m_dataGridPanel|#2/[Pane]$m_gridView|#3/[Pane]$m_dataGridPanel|#1/[Table]DataGridView|$m_pnIDDataGridView|#1/[CustomWin]Row 0|#2/[CustomWin]Manufacturer Row 0|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ManufacturerRow0WIN);

            ModelNumberRow0WIN = new CustomWin()
            {
                Tag = "[CustomWin]$59423|#1/[CustomWin]$16722|#1/[CustomWin]PnPDataGrid|$10|#1/[Pane]$ControlAxSourcingSite|#1/[Pane]$m_dataGridPanel|#2/[Pane]$m_gridView|#3/[Pane]$m_dataGridPanel|#1/[Table]DataGridView|$m_pnIDDataGridView|#1/[CustomWin]Row 0|#2/[CustomWin]Model Number Row 0|#3",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ModelNumberRow0WIN);

            SupplierRow0WIN = new CustomWin()
            {
                Tag = "[CustomWin]$59423|#1/[CustomWin]$16722|#1/[CustomWin]PnPDataGrid|$10|#1/[Pane]$ControlAxSourcingSite|#1/[Pane]$m_dataGridPanel|#2/[Pane]$m_gridView|#3/[Pane]$m_dataGridPanel|#1/[Table]DataGridView|$m_pnIDDataGridView|#1/[CustomWin]Row 0|#2/[CustomWin]Supplier Row 0|#4",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(SupplierRow0WIN);

            CommentRow0WIN = new CustomWin()
            {
                Tag = "[CustomWin]$59423|#1/[CustomWin]$16722|#1/[CustomWin]PnPDataGrid|$10|#1/[Pane]$ControlAxSourcingSite|#1/[Pane]$m_dataGridPanel|#2/[Pane]$m_gridView|#3/[Pane]$m_dataGridPanel|#1/[Table]DataGridView|$m_pnIDDataGridView|#1/[CustomWin]Row 0|#2/[CustomWin]Comment Row 0|#5",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(CommentRow0WIN);

            ClassNameRow0WIN = new CustomWin()
            {
                Tag = "[CustomWin]$59423|#1/[CustomWin]$16722|#1/[CustomWin]PnPDataGrid|$10|#1/[Pane]$ControlAxSourcingSite|#1/[Pane]$m_dataGridPanel|#2/[Pane]$m_gridView|#3/[Pane]$m_dataGridPanel|#1/[Table]DataGridView|$m_pnIDDataGridView|#1/[CustomWin]Row 0|#2/[CustomWin]Class Name Row 0|#6",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ClassNameRow0WIN);

            PnPIDRow0WIN = new CustomWin()
            {
                Tag = "[CustomWin]$59423|#1/[CustomWin]$16722|#1/[CustomWin]PnPDataGrid|$10|#1/[Pane]$ControlAxSourcingSite|#1/[Pane]$m_dataGridPanel|#2/[Pane]$m_gridView|#3/[Pane]$m_dataGridPanel|#1/[Table]DataGridView|$m_pnIDDataGridView|#1/[CustomWin]Row 0|#2/[CustomWin]PnPID Row 0|#7",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(PnPIDRow0WIN);

            Pane6PANE = new Pane()
            {
                Tag = "[CustomWin]$59423|#1/[CustomWin]$16722|#1/[CustomWin]PnPDataGrid|$10|#1/[Pane]$ControlAxSourcingSite|#1/[Pane]$m_dataGridPanel|#2/[Pane]$m_gridView|#3/[Pane]$m_hScrollPanel|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Pane6PANE);

            Pane7PANE = new Pane()
            {
                Tag = "[CustomWin]$59423|#1/[CustomWin]$16722|#1/[CustomWin]PnPDataGrid|$10|#1/[Pane]$ControlAxSourcingSite|#1/[Pane]$m_dataGridPanel|#2/[Pane]$m_gridView|#3/[Pane]$m_hScrollPanel|#2/[Pane]$m_dataGridViewHScroll|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Pane7PANE);

            Pane8PANE = new Pane()
            {
                Tag = "[CustomWin]$59423|#1/[CustomWin]$16722|#1/[CustomWin]PnPDataGrid|$10|#1/[Pane]$ControlAxSourcingSite|#1/[Pane]$m_dataGridPanel|#2/[Pane]$m_gridView|#3/[Pane]$m_hScrollPanel|#2/[Pane]$m_datagridRowSpinner|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Pane8PANE);

            PushButton3PB = new PushButton()
            {
                Tag = "[CustomWin]$59423|#1/[CustomWin]$16722|#1/[CustomWin]PnPDataGrid|$10|#1/[Pane]$ControlAxSourcingSite|#1/[Pane]$m_dataGridPanel|#2/[Pane]$m_gridView|#3/[Pane]$m_hScrollPanel|#2/[Pane]$m_datagridRowSpinner|#1/[PushButton]$m_lastRowBtn|#4",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(PushButton3PB);

            Of1PB = new PushButton()
            {
                Tag = "[CustomWin]$59423|#1/[CustomWin]$16722|#1/[CustomWin]PnPDataGrid|$10|#1/[Pane]$ControlAxSourcingSite|#1/[Pane]$m_dataGridPanel|#2/[Pane]$m_gridView|#3/[Pane]$m_hScrollPanel|#2/[Pane]$m_datagridRowSpinner|#1/[PushButton]of 1|$m_nextRowBtn|#3",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Of1PB);

            Of1ST = new StaticText()
            {
                Tag = "[CustomWin]$59423|#1/[CustomWin]$16722|#1/[CustomWin]PnPDataGrid|$10|#1/[Pane]$ControlAxSourcingSite|#1/[Pane]$m_dataGridPanel|#2/[Pane]$m_gridView|#3/[Pane]$m_hScrollPanel|#2/[Pane]$m_datagridRowSpinner|#1/[StaticText]of 1|$m_rowCountLabel|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Of1ST);

            TextField2TF = new TextField()
            {
                Tag = "[CustomWin]$59423|#1/[CustomWin]$16722|#1/[CustomWin]PnPDataGrid|$10|#1/[Pane]$ControlAxSourcingSite|#1/[Pane]$m_dataGridPanel|#2/[Pane]$m_gridView|#3/[Pane]$m_hScrollPanel|#2/[Pane]$m_datagridRowSpinner|#1/[TextField]$m_recordIndexTextBox|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(TextField2TF);

            RecordST = new StaticText()
            {
                Tag = "[CustomWin]$59423|#1/[CustomWin]$16722|#1/[CustomWin]PnPDataGrid|$10|#1/[Pane]$ControlAxSourcingSite|#1/[Pane]$m_dataGridPanel|#2/[Pane]$m_gridView|#3/[Pane]$m_hScrollPanel|#2/[Pane]$m_datagridRowSpinner|#1/[StaticText]Record|$label1|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(RecordST);

            Record1PB = new PushButton()
            {
                Tag = "[CustomWin]$59423|#1/[CustomWin]$16722|#1/[CustomWin]PnPDataGrid|$10|#1/[Pane]$ControlAxSourcingSite|#1/[Pane]$m_dataGridPanel|#2/[Pane]$m_gridView|#3/[Pane]$m_hScrollPanel|#2/[Pane]$m_datagridRowSpinner|#1/[PushButton]Record|$m_previousRowBtn|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Record1PB);

            Record2PB = new PushButton()
            {
                Tag = "[CustomWin]$59423|#1/[CustomWin]$16722|#1/[CustomWin]PnPDataGrid|$10|#1/[Pane]$ControlAxSourcingSite|#1/[Pane]$m_dataGridPanel|#2/[Pane]$m_gridView|#3/[Pane]$m_hScrollPanel|#2/[Pane]$m_datagridRowSpinner|#1/[PushButton]Record|$m_firstRowBtn|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Record2PB);

            Pane9PANE = new Pane()
            {
                Tag = "[CustomWin]$59423|#1/[CustomWin]$16722|#1/[CustomWin]PnPDataGrid|$10|#1/[Pane]$ControlAxSourcingSite|#1/[Pane]$m_dataGridPanel|#2/[Pane]$splitter1|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Pane9PANE);

            Pane10PANE = new Pane()
            {
                Tag = "[CustomWin]$59423|#1/[CustomWin]$16722|#1/[CustomWin]PnPDataGrid|$10|#1/[Pane]$ControlAxSourcingSite|#1/[Pane]$m_dataGridPanel|#2/[Pane]$m_treeView|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Pane10PANE);

            Pane11PANE = new Pane()
            {
                Tag = "[CustomWin]$59423|#1/[CustomWin]$16722|#1/[CustomWin]PnPDataGrid|$10|#1/[Pane]$ControlAxSourcingSite|#1/[Pane]$m_dataGridPanel|#2/[Pane]$m_treeView|#1/[Pane]$m_treeViewPanel|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Pane11PANE);

            Pane12PANE = new Pane()
            {
                Tag = "[CustomWin]$59423|#1/[CustomWin]$16722|#1/[CustomWin]PnPDataGrid|$10|#1/[Pane]$ControlAxSourcingSite|#1/[Pane]$m_dataGridPanel|#2/[Pane]$m_treeView|#1/[Pane]$m_treeViewPanel|#1/[Pane]$m_comboBoxViewTpye|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Pane12PANE);

            TreeViewTV = new TreeView()
            {
                Tag = "[CustomWin]$59423|#1/[CustomWin]$16722|#1/[CustomWin]PnPDataGrid|$11|#1/[Pane]$ControlAxSourcingSite|#1/[Pane]$m_dataGridPanel|#2/[Pane]$m_treeView|#1/[Pane]$m_treeViewPanel|#1/[TreeView]$m_pnidTreeView|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(TreeViewTV);

            EngineeringItemsTVI = new TreeViewItem()
            {
                Tag = "[CustomWin]$59423|#1/[CustomWin]$16722|#1/[CustomWin]PnPDataGrid|$11|#1/[Pane]$ControlAxSourcingSite|#1/[Pane]$m_dataGridPanel|#2/[Pane]$m_treeView|#1/[Pane]$m_treeViewPanel|#1/[TreeView]$m_pnidTreeView|#1/[TreeViewItem]#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(EngineeringItemsTVI);

            LinesTVI = new TreeViewItem()
            {
                Tag = "[CustomWin]$59423|#1/[CustomWin]$16722|#1/[CustomWin]PnPDataGrid|$11|#1/[Pane]$ControlAxSourcingSite|#1/[Pane]$m_dataGridPanel|#2/[Pane]$m_treeView|#1/[Pane]$m_treeViewPanel|#1/[TreeView]$m_pnidTreeView|#1/[TreeViewItem]Engineering Items|#1/[TreeViewItem]Lines|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(LinesTVI);

            PipeLineGroupTVI = new TreeViewItem()
            {
                Tag = "[CustomWin]$59423|#1/[CustomWin]$16722|#1/[CustomWin]PnPDataGrid|$11|#1/[Pane]$ControlAxSourcingSite|#1/[Pane]$m_dataGridPanel|#2/[Pane]$m_treeView|#1/[Pane]$m_treeViewPanel|#1/[TreeView]$m_pnidTreeView|#1/[TreeViewItem]Engineering Items|#1/[TreeViewItem]Lines|#1/[TreeViewItem]Pipe Line Group|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(PipeLineGroupTVI);

            PipeLineSegmentsTVI = new TreeViewItem()
            {
                Tag = "[CustomWin]$59423|#1/[CustomWin]$16722|#1/[CustomWin]PnPDataGrid|$11|#1/[Pane]$ControlAxSourcingSite|#1/[Pane]$m_dataGridPanel|#2/[Pane]$m_treeView|#1/[Pane]$m_treeViewPanel|#1/[TreeView]$m_pnidTreeView|#1/[TreeViewItem]Engineering Items|#1/[TreeViewItem]Lines|#1/[TreeViewItem]Pipe Line Segments|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(PipeLineSegmentsTVI);

            PrimaryLineSegmentTVI = new TreeViewItem()
            {
                Tag = "[CustomWin]$59423|#1/[CustomWin]$16722|#1/[CustomWin]PnPDataGrid|$11|#1/[Pane]$ControlAxSourcingSite|#1/[Pane]$m_dataGridPanel|#2/[Pane]$m_treeView|#1/[Pane]$m_treeViewPanel|#1/[TreeView]$m_pnidTreeView|#1/[TreeViewItem]Engineering Items|#1/[TreeViewItem]Lines|#1/[TreeViewItem]Pipe Line Segments|#2/[TreeViewItem]Primary Line Segment|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(PrimaryLineSegmentTVI);

            NonEngineeringItemsTVI = new TreeViewItem()
            {
                Tag = "[CustomWin]$59423|#1/[CustomWin]$16722|#1/[CustomWin]PnPDataGrid|$11|#1/[Pane]$ControlAxSourcingSite|#1/[Pane]$m_dataGridPanel|#2/[Pane]$m_treeView|#1/[Pane]$m_treeViewPanel|#1/[TreeView]$m_pnidTreeView|#1/[TreeViewItem]Non Engineering Items|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(NonEngineeringItemsTVI);

            FlowArrowTVI = new TreeViewItem()
            {
                Tag = "[CustomWin]$59423|#1/[CustomWin]$16722|#1/[CustomWin]PnPDataGrid|$11|#1/[Pane]$ControlAxSourcingSite|#1/[Pane]$m_dataGridPanel|#2/[Pane]$m_treeView|#1/[Pane]$m_treeViewPanel|#1/[TreeView]$m_pnidTreeView|#1/[TreeViewItem]Non Engineering Items|#2/[TreeViewItem]Flow Arrow|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(FlowArrowTVI);
        }
    }
}
