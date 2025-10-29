// This file is auto-generated - do not hand edit this file.

using Autodesk.GUIHarness;
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{

    [UIElement(Tag = "[Pane]Query result|$QueryDataForm", Parent = typeof(QueryConfigurationDLG), GUIType = GuiType.UIA)]
    public partial class QueryResultDLG : Pane
    {
        public  Pane PanePANE;
        public  ToolBar M_bindingNavigator;
        public  TextField TextFieldTF;
        public  PushButton M_bindingNavigatorMoveFirstItem;
        public  PushButton M_bindingNavigatorMovePreviousItem;
        public  CustomWin CustomWinWIN;
        public  Table M_dataGridView;
        public  Pane HorizontalScrollBar;
        public  CustomWin TopRowWIN;
        public  Header TopLeftHeaderCellCTL;
        public  Header PnPIDCTL;
        public  Header PnPDrawingGuidCTL;
        public  Header PnPParentGuidCTL;
        public  Header PnPTypeCTL;
        public  Header PnPTimestampGuidCTL;
        public  Header PnIDCTL;
        public  Header DwgNameCTL;
        public  Header TitleCTL;
        public  Header PathCTL;
        public  PushButton M_closeBtn;
        public  TitleBar QueryResultCTL;
        public  PushButton MinimizePB;
        public  PushButton MaximizePB;
        public  PushButton Close2PB;
        public  RadioButton RadioButton2RB;
        public  PushButton TestQueryResultPB;

        partial void OnInitialize();

        public QueryResultDLG()
        {
            InitializeComponent();
            OnInitialize();
        }

        private void InitializeComponent()
        {

            PanePANE = new Pane()
            {
                Tag = "[Pane]$m_mainDBufferedTableLayoutPanel|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(PanePANE);

            M_bindingNavigator = new ToolBar()
            {
                Tag = "[Pane]$m_mainDBufferedTableLayoutPanel|#1/[ToolBar]bindingNavigator1|$394548|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_bindingNavigator);

            TextFieldTF = new TextField()
            {
                Tag = "[Pane]$m_mainDBufferedTableLayoutPanel|#1/[ToolBar]bindingNavigator1|$394548|#1/[TextField]$328914|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(TextFieldTF);

            M_bindingNavigatorMoveFirstItem = new PushButton()
            {
                Tag = "[Pane]$m_mainDBufferedTableLayoutPanel|#1/[ToolBar]bindingNavigator1|$394548|#1/[PushButton]Move first|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_bindingNavigatorMoveFirstItem);

            M_bindingNavigatorMovePreviousItem = new PushButton()
            {
                Tag = "[Pane]$m_mainDBufferedTableLayoutPanel|#1/[ToolBar]bindingNavigator1|$394548|#1/[PushButton]Move previous|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_bindingNavigatorMovePreviousItem);

            CustomWinWIN = new CustomWin()
            {
                Tag = "[Pane]$m_mainDBufferedTableLayoutPanel|#1/[ToolBar]bindingNavigator1|$394548|#1/[CustomWin]#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(CustomWinWIN);

            M_dataGridView = new Table()
            {
                Tag = "[Pane]$m_mainDBufferedTableLayoutPanel|#1/[Table]DataGridView|$m_dataGridView|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_dataGridView);

            HorizontalScrollBar = new Pane()
            {
                Tag = "[Pane]$m_mainDBufferedTableLayoutPanel|#1/[Table]DataGridView|$m_dataGridView|#1/[Pane]Horizontal Scroll Bar|$197932|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(HorizontalScrollBar);

            TopRowWIN = new CustomWin()
            {
                Tag = "[Pane]$m_mainDBufferedTableLayoutPanel|#1/[Table]DataGridView|$m_dataGridView|#1/[CustomWin]Top Row|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(TopRowWIN);

            TopLeftHeaderCellCTL = new Header()
            {
                Tag = "[Pane]$m_mainDBufferedTableLayoutPanel|#1/[Table]DataGridView|$m_dataGridView|#1/[CustomWin]Top Row|#1/[Header]Top Left Header Cell|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(TopLeftHeaderCellCTL);

            PnPIDCTL = new Header()
            {
                Tag = "[Pane]$m_mainDBufferedTableLayoutPanel|#1/[Table]DataGridView|$m_dataGridView|#1/[CustomWin]Top Row|#1/[Header]PnPID|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(PnPIDCTL);

            PnPDrawingGuidCTL = new Header()
            {
                Tag = "[Pane]$m_mainDBufferedTableLayoutPanel|#1/[Table]DataGridView|$m_dataGridView|#1/[CustomWin]Top Row|#1/[Header]PnPDrawingGuid|#3",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(PnPDrawingGuidCTL);

            PnPParentGuidCTL = new Header()
            {
                Tag = "[Pane]$m_mainDBufferedTableLayoutPanel|#1/[Table]DataGridView|$m_dataGridView|#1/[CustomWin]Top Row|#1/[Header]PnPParentGuid|#4",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(PnPParentGuidCTL);

            PnPTypeCTL = new Header()
            {
                Tag = "[Pane]$m_mainDBufferedTableLayoutPanel|#1/[Table]DataGridView|$m_dataGridView|#1/[CustomWin]Top Row|#1/[Header]PnPType|#5",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(PnPTypeCTL);

            PnPTimestampGuidCTL = new Header()
            {
                Tag = "[Pane]$m_mainDBufferedTableLayoutPanel|#1/[Table]DataGridView|$m_dataGridView|#1/[CustomWin]Top Row|#1/[Header]PnPTimestampGuid|#6",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(PnPTimestampGuidCTL);

            PnIDCTL = new Header()
            {
                Tag = "[Pane]$m_mainDBufferedTableLayoutPanel|#1/[Table]DataGridView|$m_dataGridView|#1/[CustomWin]Top Row|#1/[Header]PnID|#7",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(PnIDCTL);

            DwgNameCTL = new Header()
            {
                Tag = "[Pane]$m_mainDBufferedTableLayoutPanel|#1/[Table]DataGridView|$m_dataGridView|#1/[CustomWin]Top Row|#1/[Header]Dwg Name|#8",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(DwgNameCTL);

            TitleCTL = new Header()
            {
                Tag = "[Pane]$m_mainDBufferedTableLayoutPanel|#1/[Table]DataGridView|$m_dataGridView|#1/[CustomWin]Top Row|#1/[Header]Title|#9",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(TitleCTL);

            PathCTL = new Header()
            {
                Tag = "[Pane]$m_mainDBufferedTableLayoutPanel|#1/[Table]DataGridView|$m_dataGridView|#1/[CustomWin]Top Row|#1/[Header]Path|#10",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(PathCTL);

            M_closeBtn = new PushButton()
            {
                Tag = "[PushButton]Close|$m_closeBtn|",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_closeBtn);

            QueryResultCTL = new TitleBar()
            {
                Tag = "[TitleBar]Query result|$TitleBar|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(QueryResultCTL);

            MinimizePB = new PushButton()
            {
                Tag = "[TitleBar]Query result|$TitleBar|#1/[PushButton]Minimize|$Minimize|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(MinimizePB);

            MaximizePB = new PushButton()
            {
                Tag = "[TitleBar]Query result|$TitleBar|#1/[PushButton]Maximize|$Maximize|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(MaximizePB);

            Close2PB = new PushButton()
            {
                Tag = "[TitleBar]Query result|$TitleBar|#1/[PushButton]Close|$Close|#3",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Close2PB);

            RadioButton2RB = new RadioButton()
            {
                Tag = "[Pane]$m_mainDBufferedTableLayoutPanel|#1/[Pane]$m_queryTypePanel|#1/[RadioButton]$m_drawingsRadioBtn|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(RadioButton2RB);

            TestQueryResultPB = new PushButton()
            {
                Tag = "[Pane]$m_mainDBufferedTableLayoutPanel|#1/[Pane]$m_mainDBufferedSplitContainer|#2/[Pane]$17367614|#2/[Pane]$m_secDBufferedSplitContainer|#1/[Pane]$15599658|#2/[Pane]$tableLayoutPanel1|#1/[PushButton]Test query result|$m_executeQueryBtn|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(TestQueryResultPB);
        }
    }
}
