// This file is auto-generated - do not hand edit this file.

using Autodesk.GUIHarness;
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{

    [UIElement(Tag = "[Pane]$ControlAxSourcingSite", Parent = typeof(CustomWin), GUIType = GuiType.UIA)]
    public partial class DATAMANAGER : Pane
    {
        public  PushButton PushButton1PB;
        public  PopupList PopupListPL;
        public  PushButton DropDownButtonPB;
        public  Pane Pane1PANE;
        public  PushButton PushButton2PB;
        public  TextField TextField1TF;
        public  ToolBar ImportToolStrip1TB;
        public  CustomWin CustomWin1WIN;
        public  PushButton RefreshPB;
        public  PushButton SynchronizePIDSymbolsAndPB;
        public  PushButton HideBlankColumnsPB;
        public  PushButton ClearFilterPB;
        public  CustomWin CustomWin2WIN;
        public  PushButton ZoomPB;
        public  PushButton ShowSelectedPB;
        public  ToolBar ImportToolStrip2TB;
        public  CustomWin CustomWin3WIN;
        public  PushButton PrintPB;
        public  PushButton ExportPB;
        public  CustomWin CustomWin4WIN;
        public  PushButton ImportPB;
        public  PushButton AcceptPB;
        public  PushButton RejectPB;
        public  PushButton AcceptAllPB;
        public  PushButton RejectAllPB;
        public  PushButton HideRevisionCloudsPB;
        public  Pane Pane2PANE;
        public  Pane Pane3PANE;
        public  Pane Pane4PANE;
        public  Table DataGridViewTBL;
        public  Pane Pane5PANE;
        public  Pane Pane6PANE;
        public  PushButton PushButton3PB;
        public  PushButton Of0PB;
        public  StaticText Of0ST;
        public  TextField TextField2TF;
        public  StaticText RecordST;
        public  PushButton Record1PB;
        public  PushButton Record2PB;
        public  Pane Pane7PANE;
        public  Pane Pane8PANE;
        public  Pane Pane9PANE;
        public  Pane Pane10PANE;
        public  TreeView TreeViewTV;

        partial void OnInitialize();

        public DATAMANAGER()
        {
            InitializeComponent();
            OnInitialize();
        }

        private void InitializeComponent()
        {

            PushButton1PB = new PushButton()
            {
                Tag = "[PushButton]$m_btnSearch|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(PushButton1PB);

            PopupListPL = new PopupList()
            {
                Tag = "[PopupList]$m_dataModeCombo|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(PopupListPL);

            DropDownButtonPB = new PushButton()
            {
                Tag = "[PopupList]$m_dataModeCombo|#1/[PushButton]$DropDown|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(DropDownButtonPB);

            Pane1PANE = new Pane()
            {
                Tag = "[Pane]$panel1|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Pane1PANE);

            PushButton2PB = new PushButton()
            {
                Tag = "[Pane]$panel1|#1/[PushButton]$m_btnChevron|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(PushButton2PB);

            TextField1TF = new TextField()
            {
                Tag = "[Pane]$panel1|#1/[TextField]$m_textBoxSearch|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(TextField1TF);

            ImportToolStrip1TB = new ToolBar()
            {
                Tag = "[Pane]$panel1|#1/[ToolBar]$m_toolStripExport|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ImportToolStrip1TB);

            CustomWin1WIN = new CustomWin()
            {
                Tag = "[Pane]$panel1|#1/[ToolBar]$m_toolStripExport|#1/[CustomWin]#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(CustomWin1WIN);

            RefreshPB = new PushButton()
            {
                Tag = "[Pane]$panel1|#1/[ToolBar]$m_toolStripExport|#1/[PushButton]Refresh|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(RefreshPB);

            SynchronizePIDSymbolsAndPB = new PushButton()
            {
                Tag = "[Pane]$panel1|#1/[ToolBar]$m_toolStripExport|#1/[PushButton]Synchronize PID Symbols and Annotations|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(SynchronizePIDSymbolsAndPB);

            HideBlankColumnsPB = new PushButton()
            {
                Tag = "[Pane]$panel1|#1/[ToolBar]$m_toolStripExport|#1/[PushButton]Hide Blank Columns|#3",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(HideBlankColumnsPB);

            ClearFilterPB = new PushButton()
            {
                Tag = "[Pane]$panel1|#1/[ToolBar]$m_toolStripExport|#1/[PushButton]Clear Filter|#4",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ClearFilterPB);

            CustomWin2WIN = new CustomWin()
            {
                Tag = "[Pane]$panel1|#1/[ToolBar]$m_toolStripExport|#1/[CustomWin]#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(CustomWin2WIN);

            ZoomPB = new PushButton()
            {
                Tag = "[Pane]$panel1|#1/[ToolBar]$m_toolStripExport|#1/[PushButton]Zoom|#5",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ZoomPB);

            ShowSelectedPB = new PushButton()
            {
                Tag = "[Pane]$panel1|#1/[ToolBar]$m_toolStripExport|#1/[PushButton]Show Selected|#6",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ShowSelectedPB);

            ImportToolStrip2TB = new ToolBar()
            {
                Tag = "[Pane]$panel1|#1/[ToolBar]$m_toolStripImport|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ImportToolStrip2TB);

            CustomWin3WIN = new CustomWin()
            {
                Tag = "[Pane]$panel1|#1/[ToolBar]$m_toolStripImport|#2/[CustomWin]#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(CustomWin3WIN);

            PrintPB = new PushButton()
            {
                Tag = "[Pane]$panel1|#1/[ToolBar]$m_toolStripImport|#2/[PushButton]#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(PrintPB);

            ExportPB = new PushButton()
            {
                Tag = "[Pane]$panel1|#1/[ToolBar]$m_toolStripImport|#2/[PushButton]#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ExportPB);

            CustomWin4WIN = new CustomWin()
            {
                Tag = "[Pane]$panel1|#1/[ToolBar]$m_toolStripImport|#2/[CustomWin]#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(CustomWin4WIN);

            ImportPB = new PushButton()
            {
                Tag = "[Pane]$panel1|#1/[ToolBar]$m_toolStripImport|#2/[PushButton]#3",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ImportPB);

            AcceptPB = new PushButton()
            {
                Tag = "[Pane]$panel1|#1/[ToolBar]$m_toolStripImport|#2/[PushButton]#4",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(AcceptPB);

            RejectPB = new PushButton()
            {
                Tag = "[Pane]$panel1|#1/[ToolBar]$m_toolStripImport|#2/[PushButton]#5",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(RejectPB);

            AcceptAllPB = new PushButton()
            {
                Tag = "[Pane]$panel1|#1/[ToolBar]$m_toolStripImport|#2/[PushButton]Accept All|#6",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(AcceptAllPB);

            RejectAllPB = new PushButton()
            {
                Tag = "[Pane]$panel1|#1/[ToolBar]$m_toolStripImport|#2/[PushButton]Reject All|#7",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(RejectAllPB);

            HideRevisionCloudsPB = new PushButton()
            {
                Tag = "[Pane]$panel1|#1/[ToolBar]$m_toolStripImport|#2/[PushButton]Hide Revision Clouds|#8",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(HideRevisionCloudsPB);

            Pane2PANE = new Pane()
            {
                Tag = "[Pane]$m_dataGridPanel|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Pane2PANE);

            Pane3PANE = new Pane()
            {
                Tag = "[Pane]$m_dataGridPanel|#2/[Pane]$m_gridView|#3",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Pane3PANE);

            Pane4PANE = new Pane()
            {
                Tag = "[Pane]$m_dataGridPanel|#2/[Pane]$m_gridView|#3/[Pane]$m_dataGridPanel|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Pane4PANE);

            DataGridViewTBL = new Table()
            {
                Tag = "[Pane]$m_dataGridPanel|#2/[Pane]$m_gridView|#3/[Pane]$m_dataGridPanel|#1/[Table]DataGridView|$m_pnIDDataGridView|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(DataGridViewTBL);

            Pane5PANE = new Pane()
            {
                Tag = "[Pane]$m_dataGridPanel|#2/[Pane]$m_gridView|#3/[Pane]$m_hScrollPanel|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Pane5PANE);

            Pane6PANE = new Pane()
            {
                Tag = "[Pane]$m_dataGridPanel|#2/[Pane]$m_gridView|#3/[Pane]$m_hScrollPanel|#2/[Pane]$m_datagridRowSpinner|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Pane6PANE);

            PushButton3PB = new PushButton()
            {
                Tag = "[Pane]$m_dataGridPanel|#2/[Pane]$m_gridView|#3/[Pane]$m_hScrollPanel|#2/[Pane]$m_datagridRowSpinner|#1/[PushButton]$m_lastRowBtn|#4",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(PushButton3PB);

            Of0PB = new PushButton()
            {
                Tag = "[Pane]$m_dataGridPanel|#2/[Pane]$m_gridView|#3/[Pane]$m_hScrollPanel|#2/[Pane]$m_datagridRowSpinner|#1/[PushButton]of 0|$m_nextRowBtn|#3",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Of0PB);

            Of0ST = new StaticText()
            {
                Tag = "[Pane]$m_dataGridPanel|#2/[Pane]$m_gridView|#3/[Pane]$m_hScrollPanel|#2/[Pane]$m_datagridRowSpinner|#1/[StaticText]of 0|$m_rowCountLabel|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Of0ST);

            TextField2TF = new TextField()
            {
                Tag = "[Pane]$m_dataGridPanel|#2/[Pane]$m_gridView|#3/[Pane]$m_hScrollPanel|#2/[Pane]$m_datagridRowSpinner|#1/[TextField]$m_recordIndexTextBox|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(TextField2TF);

            RecordST = new StaticText()
            {
                Tag = "[Pane]$m_dataGridPanel|#2/[Pane]$m_gridView|#3/[Pane]$m_hScrollPanel|#2/[Pane]$m_datagridRowSpinner|#1/[StaticText]Record|$label1|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(RecordST);

            Record1PB = new PushButton()
            {
                Tag = "[Pane]$m_dataGridPanel|#2/[Pane]$m_gridView|#3/[Pane]$m_hScrollPanel|#2/[Pane]$m_datagridRowSpinner|#1/[PushButton]Record|$m_previousRowBtn|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Record1PB);

            Record2PB = new PushButton()
            {
                Tag = "[Pane]$m_dataGridPanel|#2/[Pane]$m_gridView|#3/[Pane]$m_hScrollPanel|#2/[Pane]$m_datagridRowSpinner|#1/[PushButton]Record|$m_firstRowBtn|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Record2PB);

            Pane7PANE = new Pane()
            {
                Tag = "[Pane]$m_dataGridPanel|#2/[Pane]$splitter1|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Pane7PANE);

            Pane8PANE = new Pane()
            {
                Tag = "[Pane]$m_dataGridPanel|#2/[Pane]$m_treeView|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Pane8PANE);

            Pane9PANE = new Pane()
            {
                Tag = "[Pane]$m_dataGridPanel|#2/[Pane]$m_treeView|#1/[Pane]$m_treeViewPanel|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Pane9PANE);

            Pane10PANE = new Pane()
            {
                Tag = "[Pane]$m_dataGridPanel|#2/[Pane]$m_treeView|#1/[Pane]$m_treeViewPanel|#1/[Pane]$m_comboBoxViewTpye|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Pane10PANE);

            TreeViewTV = new TreeView()
            {
                Tag = "[Pane]$m_dataGridPanel|#2/[Pane]$m_treeView|#1/[Pane]$m_treeViewPanel|#1/[TreeView]$m_pnidTreeView|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(TreeViewTV);
        }
    }
}
