// This file is auto-generated - do not hand edit this file.

using Autodesk.GUIHarness;
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{

    [UIElement(Tag = "[Pane]$CreateConnectionDlg", Parent = typeof(MainWin), GUIType = GuiType.UIA)]
    public partial class PandIDCreateConnectionDLG : Autodesk.GUIHarness.AutoCAD.AcDialogBox
    {
        public  GroupBox PreviewGB;
        public  Pane DrawingPreview1PANE;
        public  StaticText TheSelectedDrawingDoesST;
        public  StaticText SelectOffpageConnectorToST;
        public  Pane SelectOffpageConnectorTo1PANE;
        public  Pane DrawingPreview2PANE;
        public  Table DataGridViewTBL;
        public  Pane HorizontalScrollBarPANE;
        public  CustomWin TopRowWIN;
        public  Header DWGNameCTL;
        public  Header TagCTL;
        public  Header SizeCTL;
        public  Header SpecCTL;
        public  Header ConnectorNumberCTL;
        public  Header OriginOrDestinationCTL;
        public  Header InsulationTypeCTL;
        public  Header InsulationThicknessCTL;
        public  GroupBox ProjectDrawingsGB;
        public  CheckBox ShowAllDrawingsCK;
        public  TreeView SelectDrawingToConnectTV;
        public  TreeViewItem Project6TVI;
        public  StaticText SelectDrawingToConnectST;
        public  Pane SelectOffpageConnectorTo2PANE;
        public  Pane Pane1PANE;
        public  Pane Pane2PANE;
        public  Pane Pane3PANE;
        public  Pane Pane4PANE;
        public  Pane Pane5PANE;
        public  PushButton OKPB;
        public  PushButton HelpPB;
        public  PushButton CancelPB;
        public  TitleBar CreateConnectionCTL;
        public  PushButton ClosePB;

        partial void OnInitialize();

        public PandIDCreateConnectionDLG()
        {
            InitializeComponent();
            OnInitialize();
        }

        private void InitializeComponent()
        {

            PreviewGB = new GroupBox()
            {
                Tag = "[GroupBox]$groupBoxPreview|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(PreviewGB);

            DrawingPreview1PANE = new Pane()
            {
                Tag = "[GroupBox]$groupBoxPreview|#2/[Pane]$OPCListPanel|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(DrawingPreview1PANE);

            TheSelectedDrawingDoesST = new StaticText()
            {
                Tag = "[GroupBox]$groupBoxPreview|#2/[Pane]$OPCListPanel|#2/[StaticText]$dwgPreviewLabel|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(TheSelectedDrawingDoesST);

            SelectOffpageConnectorToST = new StaticText()
            {
                Tag = "[GroupBox]$groupBoxPreview|#2/[StaticText]$label2|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(SelectOffpageConnectorToST);

            SelectOffpageConnectorTo1PANE = new Pane()
            {
                Tag = "[GroupBox]$groupBoxPreview|#2/[Pane]$previewPanel|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(SelectOffpageConnectorTo1PANE);

            DrawingPreview2PANE = new Pane()
            {
                Tag = "[GroupBox]$groupBoxPreview|#2/[Pane]$previewPanel|#1/[Pane]$4195652|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(DrawingPreview2PANE);

            DataGridViewTBL = new Table()
            {
                Tag = "[GroupBox]$groupBoxPreview|#2/[Table]$OPCDataGridView|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(DataGridViewTBL);

            HorizontalScrollBarPANE = new Pane()
            {
                Tag = "[GroupBox]$groupBoxPreview|#2/[Table]$OPCDataGridView|#1/[Pane]$6882028|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(HorizontalScrollBarPANE);

            TopRowWIN = new CustomWin()
            {
                Tag = "[GroupBox]$groupBoxPreview|#2/[Table]$OPCDataGridView|#1/[CustomWin]#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(TopRowWIN);

            DWGNameCTL = new Header()
            {
                Tag = "[GroupBox]$groupBoxPreview|#2/[Table]$OPCDataGridView|#1/[CustomWin]#1/[Header]#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(DWGNameCTL);

            TagCTL = new Header()
            {
                Tag = "[GroupBox]$groupBoxPreview|#2/[Table]$OPCDataGridView|#1/[CustomWin]#1/[Header]#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(TagCTL);

            SizeCTL = new Header()
            {
                Tag = "[GroupBox]$groupBoxPreview|#2/[Table]$OPCDataGridView|#1/[CustomWin]#1/[Header]#3",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(SizeCTL);

            SpecCTL = new Header()
            {
                Tag = "[GroupBox]$groupBoxPreview|#2/[Table]$OPCDataGridView|#1/[CustomWin]#1/[Header]#4",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(SpecCTL);

            ConnectorNumberCTL = new Header()
            {
                Tag = "[GroupBox]$groupBoxPreview|#2/[Table]$OPCDataGridView|#1/[CustomWin]#1/[Header]#5",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ConnectorNumberCTL);

            OriginOrDestinationCTL = new Header()
            {
                Tag = "[GroupBox]$groupBoxPreview|#2/[Table]$OPCDataGridView|#1/[CustomWin]#1/[Header]#6",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(OriginOrDestinationCTL);

            InsulationTypeCTL = new Header()
            {
                Tag = "[GroupBox]$groupBoxPreview|#2/[Table]$OPCDataGridView|#1/[CustomWin]#1/[Header]#7",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(InsulationTypeCTL);

            InsulationThicknessCTL = new Header()
            {
                Tag = "[GroupBox]$groupBoxPreview|#2/[Table]$OPCDataGridView|#1/[CustomWin]#1/[Header]#8",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(InsulationThicknessCTL);

            ProjectDrawingsGB = new GroupBox()
            {
                Tag = "[GroupBox]$groupBox1|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ProjectDrawingsGB);

            ShowAllDrawingsCK = new CheckBox()
            {
                Tag = "[GroupBox]$groupBox1|#1/[CheckBox]$cbShowAllDrawings|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ShowAllDrawingsCK);

            SelectDrawingToConnectTV = new TreeView()
            {
                Tag = "[GroupBox]$groupBox1|#1/[TreeView]$treePrjDwg|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(SelectDrawingToConnectTV);

            Project6TVI = new TreeViewItem()
            {
                Tag = "[GroupBox]$groupBox1|#1/[TreeView]$treePrjDwg|#1/[TreeViewItem]#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Project6TVI);

            SelectDrawingToConnectST = new StaticText()
            {
                Tag = "[GroupBox]$groupBox1|#1/[StaticText]$label1|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(SelectDrawingToConnectST);

            SelectOffpageConnectorTo2PANE = new Pane()
            {
                Tag = "[Pane]$splitHoriz|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(SelectOffpageConnectorTo2PANE);

            Pane1PANE = new Pane()
            {
                Tag = "[Pane]$splitHoriz|#1/[Pane]$5243650|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Pane1PANE);

            Pane2PANE = new Pane()
            {
                Tag = "[Pane]$splitHoriz|#1/[Pane]$5243650|#1/[Pane]$splitVert|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Pane2PANE);

            Pane3PANE = new Pane()
            {
                Tag = "[Pane]$splitHoriz|#1/[Pane]$5243650|#1/[Pane]$splitVert|#1/[Pane]$5572540|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Pane3PANE);

            Pane4PANE = new Pane()
            {
                Tag = "[Pane]$splitHoriz|#1/[Pane]$5243650|#1/[Pane]$splitVert|#1/[Pane]$4261602|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Pane4PANE);

            Pane5PANE = new Pane()
            {
                Tag = "[Pane]$splitHoriz|#1/[Pane]$4325578|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Pane5PANE);

            OKPB = new PushButton()
            {
                Tag = "[Pane]$splitHoriz|#1/[Pane]$4325578|#2/[PushButton]$btnOk|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(OKPB);

            HelpPB = new PushButton()
            {
                Tag = "[Pane]$splitHoriz|#1/[Pane]$4325578|#2/[PushButton]$btnHelp|#3",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(HelpPB);

            CancelPB = new PushButton()
            {
                Tag = "[Pane]$splitHoriz|#1/[Pane]$4325578|#2/[PushButton]$btnCancel|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(CancelPB);

            CreateConnectionCTL = new TitleBar()
            {
                Tag = "[TitleBar]$TitleBar|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(CreateConnectionCTL);

            ClosePB = new PushButton()
            {
                Tag = "[TitleBar]$TitleBar|#1/[PushButton]$Close|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ClosePB);
        }
    }
}
