// This file is auto-generated - do not hand edit this file.

using Autodesk.GUIHarness;
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{

    [UIElement(Tag = "[Pane]Query Configuration|$QueryDefinitionForm|#1", Parent = typeof(ReportConfigurationDLG), GUIType = GuiType.UIA)]
    public partial class QueryConfigurationDLG : Autodesk.GUIHarness.AutoCAD.AcDialogBox
    {
        public  TreeView AvailableClassesTV;
        public  TreeViewItem EngineeringItemsTVI;
        public  TreeViewItem EquipmentTVI;
        public  TreeViewItem FastenersTVI;
        public  TreeViewItem PipeRunComponentTVI;
        public  TreeViewItem P3dLineGroupTVI;
        public  TreeViewItem SteelStructureTVI;
        public  TreeViewItem StructureAnchorTVI;
        public  TreeViewItem StructureLadderTVI;
        public  TreeViewItem StructureMemberTVI;
        public  TreeViewItem StructurePlateTVI;
        public  TreeViewItem StructureRailingTVI;
        public  TreeViewItem StructureStairTVI;
        public  TreeViewItem StructureStepTVI;
        public  Pane Pane4PANE;
        public  PushButton PushButton1PB;
        public  PushButton PushButton2PB;
        public  StaticText AvailableClassesST;
        public  Pane Pane5PANE;
        public  Pane Pane6PANE;
        public  Pane Pane7PANE;
        public  PushButton PushButton3PB;
        public  StaticText IncludedClassesST;
        public  PushButton IncludedClassesPB;
        public  ListView IncludedClassesLV;
        public  PushButton TestQueryResultPB;
        public  PushButton PushButton4PB;
        public  PushButton PushButton5PB;
        public  Table DataGridViewTBL;
        public  Pane VerticalScrollBarPANE;
        public  CustomWin TopRowWIN;
        public  Header FieldCTL;
        public  Header FilterCTL;
        public  Header SortOrderCTL;
        public  RadioButton RadioButton1RB;
        public  RadioButton RadioButton2RB;
        public  RadioButton RadioButton3RB;
        public  PushButton ShowFilterExamplesPB;
        public  Pane Pane10PANE;
        public  PushButton CancelPB;
        public  PushButton OKPB;
        public  StaticText QueryTypeST;
        public  TitleBar QueryConfigurationCTL;
        public  CustomWin SystemMenuBarWIN;
        public  MenuItem SystemMI;
        public  PushButton MinimizePB;
        public  PushButton MaximizePB;
        public  PushButton ClosePB;

        partial void OnInitialize();

        public QueryConfigurationDLG()
        {
            InitializeComponent();
            OnInitialize();
        }

        private void InitializeComponent()
        {

            AvailableClassesTV = new TreeView()
            {
                Tag = "[Pane]$m_mainDBufferedTableLayoutPanel|#1/[Pane]$m_mainDBufferedSplitContainer|#2/[Pane]$263478|#1/[TreeView]Available Classes|$m_classDefinitionsTreeView|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(AvailableClassesTV);

            EngineeringItemsTVI = new TreeViewItem()
            {
                Tag = "[Pane]$m_mainDBufferedTableLayoutPanel|#1/[Pane]$m_mainDBufferedSplitContainer|#2/[Pane]$263478|#1/[TreeView]Available Classes|$m_classDefinitionsTreeView|#1/[TreeViewItem]Engineering Items|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(EngineeringItemsTVI);

            EquipmentTVI = new TreeViewItem()
            {
                Tag = "[Pane]$m_mainDBufferedTableLayoutPanel|#1/[Pane]$m_mainDBufferedSplitContainer|#2/[Pane]$263478|#1/[TreeView]Available Classes|$m_classDefinitionsTreeView|#1/[TreeViewItem]Engineering Items|#1/[TreeViewItem]Equipment|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(EquipmentTVI);

            FastenersTVI = new TreeViewItem()
            {
                Tag = "[Pane]$m_mainDBufferedTableLayoutPanel|#1/[Pane]$m_mainDBufferedSplitContainer|#2/[Pane]$263478|#1/[TreeView]Available Classes|$m_classDefinitionsTreeView|#1/[TreeViewItem]Engineering Items|#1/[TreeViewItem]Fasteners|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(FastenersTVI);

            PipeRunComponentTVI = new TreeViewItem()
            {
                Tag = "[Pane]$m_mainDBufferedTableLayoutPanel|#1/[Pane]$m_mainDBufferedSplitContainer|#2/[Pane]$263478|#1/[TreeView]Available Classes|$m_classDefinitionsTreeView|#1/[TreeViewItem]Engineering Items|#1/[TreeViewItem]PipeRunComponent|#3",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(PipeRunComponentTVI);

            P3dLineGroupTVI = new TreeViewItem()
            {
                Tag = "[Pane]$m_mainDBufferedTableLayoutPanel|#1/[Pane]$m_mainDBufferedSplitContainer|#2/[Pane]$263478|#1/[TreeView]Available Classes|$m_classDefinitionsTreeView|#1/[TreeViewItem]P3dLineGroup|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(P3dLineGroupTVI);

            SteelStructureTVI = new TreeViewItem()
            {
                Tag = "[Pane]$m_mainDBufferedTableLayoutPanel|#1/[Pane]$m_mainDBufferedSplitContainer|#2/[Pane]$263478|#1/[TreeView]Available Classes|$m_classDefinitionsTreeView|#1/[TreeViewItem]SteelStructure|#3",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(SteelStructureTVI);

            StructureAnchorTVI = new TreeViewItem()
            {
                Tag = "[Pane]$m_mainDBufferedTableLayoutPanel|#1/[Pane]$m_mainDBufferedSplitContainer|#2/[Pane]$263478|#1/[TreeView]Available Classes|$m_classDefinitionsTreeView|#1/[TreeViewItem]SteelStructure|#3/[TreeViewItem]StructureAnchor|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(StructureAnchorTVI);

            StructureLadderTVI = new TreeViewItem()
            {
                Tag = "[Pane]$m_mainDBufferedTableLayoutPanel|#1/[Pane]$m_mainDBufferedSplitContainer|#2/[Pane]$263478|#1/[TreeView]Available Classes|$m_classDefinitionsTreeView|#1/[TreeViewItem]SteelStructure|#3/[TreeViewItem]StructureLadder|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(StructureLadderTVI);

            StructureMemberTVI = new TreeViewItem()
            {
                Tag = "[Pane]$m_mainDBufferedTableLayoutPanel|#1/[Pane]$m_mainDBufferedSplitContainer|#2/[Pane]$263478|#1/[TreeView]Available Classes|$m_classDefinitionsTreeView|#1/[TreeViewItem]SteelStructure|#3/[TreeViewItem]StructureMember|#3",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(StructureMemberTVI);

            StructurePlateTVI = new TreeViewItem()
            {
                Tag = "[Pane]$m_mainDBufferedTableLayoutPanel|#1/[Pane]$m_mainDBufferedSplitContainer|#2/[Pane]$263478|#1/[TreeView]Available Classes|$m_classDefinitionsTreeView|#1/[TreeViewItem]SteelStructure|#3/[TreeViewItem]StructurePlate|#4",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(StructurePlateTVI);

            StructureRailingTVI = new TreeViewItem()
            {
                Tag = "[Pane]$m_mainDBufferedTableLayoutPanel|#1/[Pane]$m_mainDBufferedSplitContainer|#2/[Pane]$263478|#1/[TreeView]Available Classes|$m_classDefinitionsTreeView|#1/[TreeViewItem]SteelStructure|#3/[TreeViewItem]StructureRailing|#5",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(StructureRailingTVI);

            StructureStairTVI = new TreeViewItem()
            {
                Tag = "[Pane]$m_mainDBufferedTableLayoutPanel|#1/[Pane]$m_mainDBufferedSplitContainer|#2/[Pane]$263478|#1/[TreeView]Available Classes|$m_classDefinitionsTreeView|#1/[TreeViewItem]SteelStructure|#3/[TreeViewItem]StructureStair|#6",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(StructureStairTVI);

            StructureStepTVI = new TreeViewItem()
            {
                Tag = "[Pane]$m_mainDBufferedTableLayoutPanel|#1/[Pane]$m_mainDBufferedSplitContainer|#2/[Pane]$263478|#1/[TreeView]Available Classes|$m_classDefinitionsTreeView|#1/[TreeViewItem]SteelStructure|#3/[TreeViewItem]StructureStep|#7",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(StructureStepTVI);

            Pane4PANE = new Pane()
            {
                Tag = "[Pane]$m_mainDBufferedTableLayoutPanel|#1/[Pane]$m_mainDBufferedSplitContainer|#2/[Pane]$263478|#1/[Pane]$m_addRemovePanel|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Pane4PANE);

            PushButton1PB = new PushButton()
            {
                Tag = "[Pane]$m_mainDBufferedTableLayoutPanel|#1/[Pane]$m_mainDBufferedSplitContainer|#2/[Pane]$263478|#1/[Pane]$m_addRemovePanel|#1/[PushButton]>|$m_addClassBtn|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(PushButton1PB);

            PushButton2PB = new PushButton()
            {
                Tag = "[Pane]$m_mainDBufferedTableLayoutPanel|#1/[Pane]$m_mainDBufferedSplitContainer|#2/[Pane]$263478|#1/[Pane]$m_addRemovePanel|#1/[PushButton]<|$m_removeClassBtn|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(PushButton2PB);

            AvailableClassesST = new StaticText()
            {
                Tag = "[Pane]$m_mainDBufferedTableLayoutPanel|#1/[Pane]$m_mainDBufferedSplitContainer|#2/[Pane]$263478|#1/[StaticText]Available Classes|$m_availableClassesLbl|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(AvailableClassesST);

            Pane5PANE = new Pane()
            {
                Tag = "[Pane]$m_mainDBufferedTableLayoutPanel|#1/[Pane]$m_mainDBufferedSplitContainer|#2/[Pane]$132394|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Pane5PANE);

            Pane6PANE = new Pane()
            {
                Tag = "[Pane]$m_mainDBufferedTableLayoutPanel|#1/[Pane]$m_mainDBufferedSplitContainer|#2/[Pane]$132394|#2/[Pane]$m_secDBufferedSplitContainer|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Pane6PANE);

            Pane7PANE = new Pane()
            {
                Tag = "[Pane]$m_mainDBufferedTableLayoutPanel|#1/[Pane]$m_mainDBufferedSplitContainer|#2/[Pane]$132394|#2/[Pane]$m_secDBufferedSplitContainer|#1/[Pane]$197986|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Pane7PANE);

            PushButton3PB = new PushButton()
            {
                Tag = "[Pane]$m_mainDBufferedTableLayoutPanel|#1/[Pane]$m_mainDBufferedSplitContainer|#2/[Pane]$132394|#2/[Pane]$m_secDBufferedSplitContainer|#1/[Pane]$197986|#1/[PushButton]$m_downBtn|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(PushButton3PB);

            IncludedClassesST = new StaticText()
            {
                Tag = "[Pane]$m_mainDBufferedTableLayoutPanel|#1/[Pane]$m_mainDBufferedSplitContainer|#2/[Pane]$132394|#2/[Pane]$m_secDBufferedSplitContainer|#1/[Pane]$197986|#1/[StaticText]Included Classes|$m_includedClassesLbl|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(IncludedClassesST);

            IncludedClassesPB = new PushButton()
            {
                Tag = "[Pane]$m_mainDBufferedTableLayoutPanel|#1/[Pane]$m_mainDBufferedSplitContainer|#2/[Pane]$132394|#2/[Pane]$m_secDBufferedSplitContainer|#1/[Pane]$197986|#1/[PushButton]Included Classes|$m_upBtn|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(IncludedClassesPB);

            IncludedClassesLV = new ListView()
            {
                Tag = "[Pane]$m_mainDBufferedTableLayoutPanel|#1/[Pane]$m_mainDBufferedSplitContainer|#2/[Pane]$132394|#2/[Pane]$m_secDBufferedSplitContainer|#1/[Pane]$197986|#1/[ListView]Included Classes|$m_includedClassesList|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(IncludedClassesLV);

            TestQueryResultPB = new PushButton()
            {
                Tag = "[Pane]$m_mainDBufferedTableLayoutPanel|#1/[Pane]$m_mainDBufferedSplitContainer|#2/[Pane]$17367614|#2/[Pane]$m_secDBufferedSplitContainer|#1/[Pane]$15599658|#2/[Pane]$tableLayoutPanel1|#1/[PushButton]Test query result|$m_executeQueryBtn|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(TestQueryResultPB);

            PushButton4PB = new PushButton()
            {
                Tag = "[Pane]$m_mainDBufferedTableLayoutPanel|#1/[Pane]$m_mainDBufferedSplitContainer|#2/[Pane]$132394|#2/[Pane]$m_secDBufferedSplitContainer|#1/[Pane]$262912|#2/[PushButton]$m_propertyUpBtn|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(PushButton4PB);

            PushButton5PB = new PushButton()
            {
                Tag = "[Pane]$m_mainDBufferedTableLayoutPanel|#1/[Pane]$m_mainDBufferedSplitContainer|#2/[Pane]$132394|#2/[Pane]$m_secDBufferedSplitContainer|#1/[Pane]$262912|#2/[PushButton]$m_propertyDownBtn|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(PushButton5PB);

            DataGridViewTBL = new Table()
            {
                Tag = "[Pane]$m_mainDBufferedTableLayoutPanel|#1/[Pane]$m_mainDBufferedSplitContainer|#2/[Pane]$132394|#2/[Pane]$m_secDBufferedSplitContainer|#1/[Pane]$262912|#2/[Table]DataGridView|$m_propertiesGridView|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(DataGridViewTBL);

            VerticalScrollBarPANE = new Pane()
            {
                Tag = "[Pane]$m_mainDBufferedTableLayoutPanel|#1/[Pane]$m_mainDBufferedSplitContainer|#2/[Pane]$132394|#2/[Pane]$m_secDBufferedSplitContainer|#1/[Pane]$262912|#2/[Table]DataGridView|$m_propertiesGridView|#1/[Pane]Vertical Scroll Bar|$393986|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(VerticalScrollBarPANE);

            TopRowWIN = new CustomWin()
            {
                Tag = "[Pane]$m_mainDBufferedTableLayoutPanel|#1/[Pane]$m_mainDBufferedSplitContainer|#2/[Pane]$132394|#2/[Pane]$m_secDBufferedSplitContainer|#1/[Pane]$262912|#2/[Table]DataGridView|$m_propertiesGridView|#1/[CustomWin]Top Row|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(TopRowWIN);

            FieldCTL = new Header()
            {
                Tag = "[Pane]$m_mainDBufferedTableLayoutPanel|#1/[Pane]$m_mainDBufferedSplitContainer|#2/[Pane]$132394|#2/[Pane]$m_secDBufferedSplitContainer|#1/[Pane]$262912|#2/[Table]DataGridView|$m_propertiesGridView|#1/[CustomWin]Top Row|#1/[Header]Field|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(FieldCTL);

            FilterCTL = new Header()
            {
                Tag = "[Pane]$m_mainDBufferedTableLayoutPanel|#1/[Pane]$m_mainDBufferedSplitContainer|#2/[Pane]$132394|#2/[Pane]$m_secDBufferedSplitContainer|#1/[Pane]$262912|#2/[Table]DataGridView|$m_propertiesGridView|#1/[CustomWin]Top Row|#1/[Header]Filter|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(FilterCTL);

            SortOrderCTL = new Header()
            {
                Tag = "[Pane]$m_mainDBufferedTableLayoutPanel|#1/[Pane]$m_mainDBufferedSplitContainer|#2/[Pane]$132394|#2/[Pane]$m_secDBufferedSplitContainer|#1/[Pane]$262912|#2/[Table]DataGridView|$m_propertiesGridView|#1/[CustomWin]Top Row|#1/[Header]Sort Order|#3",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(SortOrderCTL);

            RadioButton1RB = new RadioButton()
            {
                Tag = "[Pane]$m_mainDBufferedTableLayoutPanel|#1/[Pane]$m_queryTypePanel|#1/[RadioButton]$m_plant3DRadioBtn|#3",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(RadioButton1RB);

            RadioButton2RB = new RadioButton()
            {
                Tag = "[Pane]$m_mainDBufferedTableLayoutPanel|#1/[Pane]$m_queryTypePanel|#1/[RadioButton]$m_drawingsRadioBtn|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(RadioButton2RB);

            RadioButton3RB = new RadioButton()
            {
                Tag = "[Pane]$m_mainDBufferedTableLayoutPanel|#1/[Pane]$m_queryTypePanel|#1/[RadioButton]$m_pidClassesRadioBtn|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(RadioButton3RB);

            ShowFilterExamplesPB = new PushButton()
            {
                Tag = "[Pane]$m_mainDBufferedTableLayoutPanel|#1/[PushButton]Show Filter Examples|$m_showHideBtn|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ShowFilterExamplesPB);

            Pane10PANE = new Pane()
            {
                Tag = "[Pane]$m_mainDBufferedTableLayoutPanel|#1/[Pane]$m_okCancelBtnsPanel|#3",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Pane10PANE);

            CancelPB = new PushButton()
            {
                Tag = "[Pane]$m_mainDBufferedTableLayoutPanel|#1/[Pane]$m_okCancelBtnsPanel/[PushButton]$m_cancelBtn",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(CancelPB);

            OKPB = new PushButton()
            {
                Tag = "[Pane]$m_mainDBufferedTableLayoutPanel|#1/[Pane]$m_okCancelBtnsPanel|#4/[PushButton]OK|$m_okBtn|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(OKPB);

            QueryTypeST = new StaticText()
            {
                Tag = "[Pane]$m_mainDBufferedTableLayoutPanel|#1/[StaticText]Query type:|$m_queryTypeLbl|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(QueryTypeST);

            QueryConfigurationCTL = new TitleBar()
            {
                Tag = "[TitleBar]Query Configuration|$TitleBar|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(QueryConfigurationCTL);

            SystemMenuBarWIN = new CustomWin()
            {
                Tag = "[TitleBar]Query Configuration|$TitleBar|#1/[CustomWin]System Menu Bar|$QueryDefinitionForm|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(SystemMenuBarWIN);

            SystemMI = new MenuItem()
            {
                Tag = "[TitleBar]Query Configuration|$TitleBar|#1/[CustomWin]System Menu Bar|$QueryDefinitionForm|#1/[MenuItem]System|$Item 1|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(SystemMI);

            MinimizePB = new PushButton()
            {
                Tag = "[TitleBar]Query Configuration|$TitleBar|#1/[PushButton]Minimize|$Minimize|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(MinimizePB);

            MaximizePB = new PushButton()
            {
                Tag = "[TitleBar]Query Configuration|$TitleBar|#1/[PushButton]Maximize|$Maximize|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(MaximizePB);

            ClosePB = new PushButton()
            {
                Tag = "[TitleBar]Query Configuration|$TitleBar|#1/[PushButton]Close|$Close|#3",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ClosePB);
        }
    }
}
