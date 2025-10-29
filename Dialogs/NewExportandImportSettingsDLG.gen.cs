// This file is auto-generated - do not hand edit this file.

using Autodesk.GUIHarness;
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{

    [UIElement(Tag = "[Pane]$PnPNewExportImportSettingDlg", Parent = typeof(ProjectSetupExportandImportSettingsDLG))]
    public partial class NewExportandImportSettingsDLG : Pane
    {
        public  PushButton Elipses;
        public  StaticText PIDClassesST;
        public  TextField DescriptionTF;
        public  ScrollBar DescriptionSB;
        public  GroupBox ExternalDataMappingGB;
        public  StaticText PropertiesST;
        public  StaticText ExternalClassNameST;
        public  Table M_dataGridView;
        public  TextField ExternalClassNameTF;
        public  TreeView M_treeView;
        public  TreeViewItem EngineeringItemsTVI;
        public  TreeViewItem EquipmentTVI;
        public  TreeViewItem InlineAssetsTVI;
        public  TreeViewItem InstrumentationTVI;
        public  TreeViewItem LinesTVI;
        public  TreeViewItem NozzlesTVI;
        public  TreeViewItem NonEngineeringItemsTVI;
        public  TreeViewItem ActuatorsTVI;
        public  TreeViewItem AnnotationTVI;
        public  TreeViewItem ClosedDrainNoPIDTVI;
        public  TreeViewItem ConnectorsTVI;
        public  TreeViewItem FlowArrowTVI;
        public  TreeViewItem FlagTVI;
        public  TreeViewItem GapTVI;
        public  TreeViewItem LineBreakersTVI;
        public  TreeViewItem OpenDrainNoPIDTVI;
        public  TreeViewItem TieInTVI;
        public  TreeViewItem SignalLineGroupTVI;
        public  PushButton M_btnCancel;
        public  PushButton M_btnOK;
        public  StaticText DescriptionST;
        public  PushButton HelpPB;
        public  TextField M_tbName;
        public  StaticText NameST;
        public  TitleBar NewExportAndImportCTL;
        public  CustomWin SystemMenuBarWIN;
        public  MenuItem SystemMI;
        public  PushButton ClosePB;

        partial void OnInitialize();

        public NewExportandImportSettingsDLG()
        {
            InitializeComponent();
            OnInitialize();
        }

        private void InitializeComponent()
        {

            Elipses = new PushButton()
            {
                Tag = "[GroupBox] External data mapping|$groupBox1|#1/[Table]DataGridView|$m_dataGridView|#1/[PushButton]**|$5968076|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Elipses);

            PIDClassesST = new StaticText()
            {
                Tag = "[StaticText]P*|$label3|#3",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(PIDClassesST);

            DescriptionTF = new TextField()
            {
                Tag = "[TextField]Description:|$m_tbDesc|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(DescriptionTF);

            DescriptionSB = new ScrollBar()
            {
                Tag = "[TextField]Description:|$m_tbDesc|#2/[ScrollBar]Description:|$Vertical ScrollBar|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(DescriptionSB);

            ExternalDataMappingGB = new GroupBox()
            {
                Tag = "[GroupBox] External data mapping|$groupBox1|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ExternalDataMappingGB);

            PropertiesST = new StaticText()
            {
                Tag = "[GroupBox] External data mapping|$groupBox1|#1/[StaticText]Properties:|$label5|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(PropertiesST);

            ExternalClassNameST = new StaticText()
            {
                Tag = "[GroupBox] External data mapping|$groupBox1|#1/[StaticText]External class name:|$label4|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ExternalClassNameST);

            M_dataGridView = new Table()
            {
                Tag = "[GroupBox] External data mapping|$groupBox1|#1/[Table]DataGridView|$m_dataGridView|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_dataGridView);

            ExternalClassNameTF = new TextField()
            {
                Tag = "[GroupBox] External data mapping|$groupBox1|#1/[TextField]External class name:|$m_tbExternalObjName|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ExternalClassNameTF);

            M_treeView = new TreeView()
            {
                Tag = "[TreeView]P*|$m_treeView|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_treeView);

            EngineeringItemsTVI = new TreeViewItem()
            {
                Tag = "[TreeView]P*|$m_treeView|#1/[TreeViewItem]Engineering Items|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(EngineeringItemsTVI);

            EquipmentTVI = new TreeViewItem()
            {
                Tag = "[TreeView]P*|$m_treeView|#1/[TreeViewItem]Engineering Items|#1/[TreeViewItem]Equipment|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(EquipmentTVI);

            InlineAssetsTVI = new TreeViewItem()
            {
                Tag = "[TreeView]P*|$m_treeView|#1/[TreeViewItem]Engineering Items|#1/[TreeViewItem]Inline Assets|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(InlineAssetsTVI);

            InstrumentationTVI = new TreeViewItem()
            {
                Tag = "[TreeView]P*|$m_treeView|#1/[TreeViewItem]Engineering Items|#1/[TreeViewItem]Instrumentation|#3",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(InstrumentationTVI);

            LinesTVI = new TreeViewItem()
            {
                Tag = "[TreeView]P*|$m_treeView|#1/[TreeViewItem]Engineering Items|#1/[TreeViewItem]Lines|#4",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(LinesTVI);

            NozzlesTVI = new TreeViewItem()
            {
                Tag = "[TreeView]P*|$m_treeView|#1/[TreeViewItem]Engineering Items|#1/[TreeViewItem]Nozzles|#5",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(NozzlesTVI);

            NonEngineeringItemsTVI = new TreeViewItem()
            {
                Tag = "[TreeView]P*|$m_treeView|#1/[TreeViewItem]Non Engineering Items|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(NonEngineeringItemsTVI);

            ActuatorsTVI = new TreeViewItem()
            {
                Tag = "[TreeView]P*|$m_treeView|#1/[TreeViewItem]Non Engineering Items|#2/[TreeViewItem]Actuators|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ActuatorsTVI);

            AnnotationTVI = new TreeViewItem()
            {
                Tag = "[TreeView]P*|$m_treeView|#1/[TreeViewItem]Non Engineering Items|#2/[TreeViewItem]Annotation|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(AnnotationTVI);

            ClosedDrainNoPIDTVI = new TreeViewItem()
            {
                Tag = "[TreeView]P*|$m_treeView|#1/[TreeViewItem]Non Engineering Items|#2/[TreeViewItem]Closed Drain No PID|#3",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ClosedDrainNoPIDTVI);

            ConnectorsTVI = new TreeViewItem()
            {
                Tag = "[TreeView]P*|$m_treeView|#1/[TreeViewItem]Non Engineering Items|#2/[TreeViewItem]Connectors|#4",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ConnectorsTVI);

            FlowArrowTVI = new TreeViewItem()
            {
                Tag = "[TreeView]P*|$m_treeView|#1/[TreeViewItem]Non Engineering Items|#2/[TreeViewItem]Flow Arrow|#5",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(FlowArrowTVI);

            FlagTVI = new TreeViewItem()
            {
                Tag = "[TreeView]P*|$m_treeView|#1/[TreeViewItem]Non Engineering Items|#2/[TreeViewItem]Flag|#6",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(FlagTVI);

            GapTVI = new TreeViewItem()
            {
                Tag = "[TreeView]P*|$m_treeView|#1/[TreeViewItem]Non Engineering Items|#2/[TreeViewItem]Gap|#7",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(GapTVI);

            LineBreakersTVI = new TreeViewItem()
            {
                Tag = "[TreeView]P*|$m_treeView|#1/[TreeViewItem]Non Engineering Items|#2/[TreeViewItem]Line Breakers|#8",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(LineBreakersTVI);

            OpenDrainNoPIDTVI = new TreeViewItem()
            {
                Tag = "[TreeView]P*|$m_treeView|#1/[TreeViewItem]Non Engineering Items|#2/[TreeViewItem]Open Drain No PID|#9",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(OpenDrainNoPIDTVI);

            TieInTVI = new TreeViewItem()
            {
                Tag = "[TreeView]P*|$m_treeView|#1/[TreeViewItem]Non Engineering Items|#2/[TreeViewItem]Tie In|#10",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(TieInTVI);

            SignalLineGroupTVI = new TreeViewItem()
            {
                Tag = "[TreeView]P*|$m_treeView|#1/[TreeViewItem]Signal Line Group|#3",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(SignalLineGroupTVI);

            M_btnCancel = new PushButton()
            {
                Tag = "[PushButton]Cancel|$m_btnCancel|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_btnCancel);

            M_btnOK = new PushButton()
            {
                Tag = "[PushButton]OK|$m_btnOK|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_btnOK);

            DescriptionST = new StaticText()
            {
                Tag = "[StaticText]Description:|$label2|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(DescriptionST);

            HelpPB = new PushButton()
            {
                Tag = "[PushButton]Help|$m_btnHelp|#3",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(HelpPB);

            M_tbName = new TextField()
            {
                Tag = "[TextField]Name:|$m_tbName|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_tbName);

            NameST = new StaticText()
            {
                Tag = "[StaticText]Name:|$label1|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(NameST);

            NewExportAndImportCTL = new TitleBar()
            {
                Tag = "[TitleBar]New Export and Import Settings|$TitleBar|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(NewExportAndImportCTL);

            SystemMenuBarWIN = new CustomWin()
            {
                Tag = "[TitleBar]New Export and Import Settings|$TitleBar|#1/[CustomWin]System Menu Bar|$PnPNewExportImportSettingDlg|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(SystemMenuBarWIN);

            SystemMI = new MenuItem()
            {
                Tag = "[TitleBar]New Export and Import Settings|$TitleBar|#1/[CustomWin]System Menu Bar|$PnPNewExportImportSettingDlg|#1/[MenuItem]System|$Item 1|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(SystemMI);

            ClosePB = new PushButton()
            {
                Tag = "[TitleBar]New Export and Import Settings|$TitleBar|#1/[PushButton]Close|$Close|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ClosePB);
        }
    }
}
