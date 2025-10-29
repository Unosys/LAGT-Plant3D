// This file is auto-generated - do not hand edit this file.

using Autodesk.GUIHarness;
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{

    [UIElement(Tag = "[Pane]Project Setup|$EditProjectSettingsDlg", Parent = typeof(Plant3D))]
    public partial class ProjectSetupPlant3DConnectionsDLG : Autodesk.GUIHarness.AutoCAD.AcDialogBox
    {
        public  TreeView M_treeView;
        public  StaticText JointSetup;
        public  StaticText SimpleJoints;
        public  Table M_dataGridView1;
        public  ScrollBar VerticalScrollBar;
        public  PushButton Add;
        public  PushButton Modify;
        public  PushButton Modify1PB;
        public  PushButton Modify2PB;
        public  PushButton Delete;
        public  CheckBox EnableImperialToMetricConn;
        public  StaticText CompoundJoints;
        public  Table M_dataGridView2;
        public  PushButton AddCompound;
        public  PushButton ModifyCompound;
        public  PushButton DeleteCompound;
        public  StaticText PipeSegments;
        public  StaticText MinimumLengthText;
        public  TextField MinimumLength;
        public  StaticText WeldGaps;
        public  CheckBox UseWeldGaps;
        public  StaticText GapSizeText;
        public  TextField GapSize;
        public  StaticText WeldDots;
        public  StaticText DiameterText;
        public  TextField Diameter;
        public  StaticText WaferBolts;
        public  StaticText RoundUpToNearestText;
        public  TextField RoundUpToNearest;
        public  CustomWin SystemWindowsFormsSplitterP2;
        public  PushButton Help;
        public  PushButton Cancel;
        public  PushButton OK;
        public  PushButton Apply;

        partial void OnInitialize();

        public ProjectSetupPlant3DConnectionsDLG()
        {
            InitializeComponent();
            OnInitialize();
        }

        private void InitializeComponent()
        {

            M_treeView = new TreeView()
            {
                Tag = "$m_treeView",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_treeView);

            JointSetup = new StaticText()
            {
                Tag = "[StaticText]Joint setup|$groupBox1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(JointSetup);

            SimpleJoints = new StaticText()
            {
                Tag = "[StaticText]Simple joints|$groupBox2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(SimpleJoints);

            M_dataGridView1 = new Table()
            {
                Tag = "$m_dataGridView1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_dataGridView1);

            VerticalScrollBar = new ScrollBar()
            {
                Tag = "[ScrollBar]Vertical Scroll Bar|$VerticalScrollBar",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(VerticalScrollBar);

            Add = new PushButton()
            {
                Tag = "[PushButton]Add|$m_btnAddSimple",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Add);

            Modify = new PushButton()
            {
                Tag = "[PushButton]Modify|$m_btnModifySimple",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Modify);

            Modify1PB = new PushButton()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]#1/[Pane]$m_splitVert|#1/[Pane]#2/[Pane]$m_jointsUserCtrl|#1/[GroupBox]Joint setup|$groupBox1|#1/[GroupBox]Compound joints|$groupBox3|#2/[PushButton]|$btnModifyCompound|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Modify1PB);

            Modify2PB = new PushButton()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]#1/[Pane]$m_splitVert|#1/[Pane]#2/[Pane]$m_jointsUserCtrl|#1/[GroupBox]Joint setup|$groupBox1|#1/[GroupBox]Simple joints|$groupBox2|#1/[PushButton]Modify*|$m_btnModifySimple|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Modify2PB);

            Delete = new PushButton()
            {
                Tag = "[PushButton]Delete|$m_btnDeleteSimple",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Delete);

            EnableImperialToMetricConn = new CheckBox()
            {
                Tag = "[CheckBox]Enable Imperial to Metric connection control|$m_ChkBoxEnableAnsiDin",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(EnableImperialToMetricConn);

            CompoundJoints = new StaticText()
            {
                Tag = "[StaticText]Compound joints|$groupBox3",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(CompoundJoints);

            M_dataGridView2 = new Table()
            {
                Tag = "$m_dataGridView2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_dataGridView2);

            AddCompound = new PushButton()
            {
                Tag = "[PushButton]Add|$btnAddCompound",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(AddCompound);

            ModifyCompound = new PushButton()
            {
                Tag = "[PushButton]Modify|$btnModifyCompound",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ModifyCompound);

            DeleteCompound = new PushButton()
            {
                Tag = "[PushButton]Delete|$btnDeleteCompound",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(DeleteCompound);

            PipeSegments = new StaticText()
            {
                Tag = "[StaticText]Pipe segments|$groupBox4",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(PipeSegments);

            MinimumLengthText = new StaticText()
            {
                Tag = "[StaticText]Minimum length:|$label1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(MinimumLengthText);

            MinimumLength = new TextField()
            {
                Tag = "[TextField]Minimum length:|$txtboxMinLength",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(MinimumLength);

            WeldGaps = new StaticText()
            {
                Tag = "[StaticText]Weld gaps|$groupBox5",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(WeldGaps);

            UseWeldGaps = new CheckBox()
            {
                Tag = "[CheckBox]Use weld gaps|$m_cbUseWeldgaps",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(UseWeldGaps);

            GapSizeText = new StaticText()
            {
                Tag = "[StaticText]Gap size:|$label3",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(GapSizeText);

            GapSize = new TextField()
            {
                Tag = "[TextField]Gap size:|$m_tbWeldgapSize",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(GapSize);

            WeldDots = new StaticText()
            {
                Tag = "[StaticText]Weld dots|$groupBox6",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(WeldDots);

            DiameterText = new StaticText()
            {
                Tag = "[StaticText]Diameter:|$label4",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(DiameterText);

            Diameter = new TextField()
            {
                Tag = "[TextField]Diameter:|$m_tbWeldDiameter",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Diameter);

            WaferBolts = new StaticText()
            {
                Tag = "[StaticText]Wafer bolts|$groupBox7",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(WaferBolts);

            RoundUpToNearestText = new StaticText()
            {
                Tag = "[StaticText]Round up to nearest:|$label2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(RoundUpToNearestText);

            RoundUpToNearest = new TextField()
            {
                Tag = "[TextField]Round up to nearest:|$m_tbWaferBoltRounding",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(RoundUpToNearest);

            SystemWindowsFormsSplitterP2 = new CustomWin()
            {
                Tag = "[System.Windows.Forms.SplitterPanel]#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(SystemWindowsFormsSplitterP2);

            Help = new PushButton()
            {
                Tag = "[PushButton]Help|$m_btnHelp",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Help);

            Cancel = new PushButton()
            {
                Tag = "[PushButton]Cancel|$m_btnCancel",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Cancel);

            OK = new PushButton()
            {
                Tag = "[PushButton]OK|$m_btnOk",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(OK);

            Apply = new PushButton()
            {
                Tag = "[PushButton]Apply|$m_btnSave",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Apply);
        }
    }
}
