// This file is auto-generated - do not hand edit this file.

using Autodesk.GUIHarness;
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{

    [UIElement(Tag = "[Pane]Project Setup|$EditProjectSettingsDlg", Parent = typeof(Plant3D), GUIType = GuiType.UIA)]
    public partial class Plant3DConnJointDLG : Pane
    {
        public  TextField RoundUpToNearestTF;
        public  TextField DiameterTF;
        public  TextField GapSizeTF;
        public  CheckBox M_cbUseWeldgaps;
        public  TextField TxtboxMinLength;
        public  PushButton BtnDeleteCompound;
        public  PushButton BtnModifyCompound;
        public  PushButton Add2PB;
        public  Table M_dataGridView1;
        public  PushButton M_btnDeleteSimple;
        public  Table DataGridView2TBL;
        public  PushButton Modify1PB;
        public  PushButton Add1PB;
        public  PushButton M_btnHelp;
        public  PushButton M_btnCancel;
        public  PushButton M_btnOk;
        public  PushButton M_btnSave;
        public  PushButton ClosePB;
        public  TextField M_tbWaferBoltRounding;
        public  TextField M_tbWeldDiameter;
        public  TextField M_tbWeldgapSize;
        public  TreeView M_treeView;

        partial void OnInitialize();

        public Plant3DConnJointDLG()
        {
            InitializeComponent();
            OnInitialize();
        }

        private void InitializeComponent()
        {

            RoundUpToNearestTF = new TextField()
            {
                Tag = "[Pane]$m_splitHorz/[Pane]#1/[Pane]$m_splitVert/[Pane]#2/[Pane]$m_jointsUserCtrl/[GroupBox]Joint setup|$groupBox1/[GroupBox]Wafer bolts|$groupBox7/[TextField]Round up to nearest:|$m_tbWaferBoltRounding",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(RoundUpToNearestTF);

            DiameterTF = new TextField()
            {
                Tag = "[Pane]$m_splitHorz/[Pane]#1/[Pane]$m_splitVert/[Pane]#2/[Pane]$m_jointsUserCtrl/[GroupBox]Joint setup|$groupBox1/[GroupBox]Weld dots|$groupBox6/[TextField]Diameter:|$m_tbWeldDiameter",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(DiameterTF);

            GapSizeTF = new TextField()
            {
                Tag = "[Pane]$m_splitHorz/[Pane]#1/[Pane]$m_splitVert/[Pane]#2/[Pane]$m_jointsUserCtrl/[GroupBox]Joint setup|$groupBox1/[GroupBox]Weld gaps|$groupBox5/[TextField]Gap size:|$m_tbWeldgapSize",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(GapSizeTF);

            M_cbUseWeldgaps = new CheckBox()
            {
                Tag = "[Pane]$m_splitHorz/[Pane]#1/[Pane]$m_splitVert/[Pane]#2/[Pane]$m_jointsUserCtrl/[GroupBox]Joint setup|$groupBox1/[GroupBox]Weld gaps|$groupBox5/[CheckBox]Use weld gaps|$m_cbUseWeldgaps",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_cbUseWeldgaps);

            TxtboxMinLength = new TextField()
            {
                Tag = "[Pane]$m_splitHorz/[Pane]#1/[Pane]$m_splitVert/[Pane]#2/[Pane]$m_jointsUserCtrl/[GroupBox]Joint setup|$groupBox1/[GroupBox]Pipe segments|$groupBox4/[TextField]Minimum length:|$txtboxMinLength",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(TxtboxMinLength);

            BtnDeleteCompound = new PushButton()
            {
                Tag = "[Pane]$m_splitHorz/[Pane]#1/[Pane]$m_splitVert/[Pane]#2/[Pane]$m_jointsUserCtrl/[GroupBox]Joint setup|$groupBox1/[GroupBox]Compound joints|$groupBox3/[PushButton]Delete|$btnDeleteCompound",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(BtnDeleteCompound);

            BtnModifyCompound = new PushButton()
            {
                Tag = "[Pane]$m_splitHorz/[Pane]#1/[Pane]$m_splitVert/[Pane]#2/[Pane]$m_jointsUserCtrl/[GroupBox]Joint setup|$groupBox1/[GroupBox]Compound joints|$groupBox3/[PushButton]Modify*|$btnModifyCompound",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(BtnModifyCompound);

            Add2PB = new PushButton()
            {
                Tag = "[Pane]$m_splitHorz|/[Pane]$332030|/[Pane]$m_splitVert|/[Pane]$330778|/[Pane]$m_jointsUserCtrl|/[GroupBox]Joint setup|$groupBox_JointSetup|/[GroupBox]Compound joints|$groupBox_CompoundJoints|/[PushButton]Add*|$btnAddCompound|",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Add2PB);

            M_dataGridView1 = new Table()
            {
                Tag = "[Pane]$m_splitHorz/[Pane]#1/[Pane]$m_splitVert/[Pane]#2/[Pane]$m_jointsUserCtrl/[GroupBox]Joint setup|$groupBox1/[GroupBox]Compound joints|$groupBox3/[Table]DataGridView|$m_dataGridView2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_dataGridView1);

            M_btnDeleteSimple = new PushButton()
            {
                Tag = "[Pane]$m_splitHorz/[Pane]#1/[Pane]$m_splitVert/[Pane]#2/[Pane]$m_jointsUserCtrl/[GroupBox]Joint setup|$groupBox1/[GroupBox]Simple joints|$groupBox2/[PushButton]Delete|$m_btnDeleteSimple",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_btnDeleteSimple);

            DataGridView2TBL = new Table()
            {
                Tag = "[Pane]$m_splitHorz/[Pane]#1/[Pane]$m_splitVert/[Pane]#2/[Pane]$m_jointsUserCtrl/[GroupBox]Joint setup|$groupBox1/[GroupBox]Simple joints|$groupBox2/[Table]DataGridView|$m_dataGridView1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(DataGridView2TBL);

            Modify1PB = new PushButton()
            {
                Tag = "[Pane]$m_splitHorz|/[Pane]$262754|/[Pane]$m_splitVert|/[Pane]$132790|/[Pane]$m_jointsUserCtrl|/[GroupBox]Joint setup|$groupBox_JointSetup|/[GroupBox]Simple joints|$groupBox_SimpleJoints|/[PushButton]Modify*|$m_btnModifySimple|",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Modify1PB);

            Add1PB = new PushButton()
            {
                Tag = "[Pane]$m_splitHorz|/[Pane]$394682|/[Pane]$m_splitVert|/[Pane]$394668|/[Pane]$m_jointsUserCtrl|/[GroupBox]Joint setup|$groupBox_JointSetup|/[GroupBox]Simple joints|$groupBox_SimpleJoints|/[PushButton]Add*|$m_btnAddSimple",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Add1PB);

            M_btnHelp = new PushButton()
            {
                Tag = "[Pane]$m_splitHorz/[Pane]$1247246/[PushButton]Help|$m_btnHelp",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_btnHelp);

            M_btnCancel = new PushButton()
            {
                Tag = "[Pane]$m_splitHorz/[Pane]$1247246/[PushButton]Cancel|$m_btnCancel",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_btnCancel);

            M_btnOk = new PushButton()
            {
                Tag = "[Pane]$m_splitHorz/[Pane]$1247246/[PushButton]OK|$m_btnOk",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_btnOk);

            M_btnSave = new PushButton()
            {
                Tag = "[Pane]$m_splitHorz/[Pane]$1247246/[PushButton]Apply|$m_btnSave",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_btnSave);

            ClosePB = new PushButton()
            {
                Tag = "[TitleBar]Project Setup|$TitleBar/[PushButton]Close|$Close",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ClosePB);

            M_tbWaferBoltRounding = new TextField()
            {
                Tag = "[TextField]$m_tbWaferBoltRounding",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_tbWaferBoltRounding);

            M_tbWeldDiameter = new TextField()
            {
                Tag = "[TextField]$m_tbWeldDiameter",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_tbWeldDiameter);

            M_tbWeldgapSize = new TextField()
            {
                Tag = "[TextField]$m_tbWeldgapSize",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_tbWeldgapSize);

            M_treeView = new TreeView()
            {
                Tag = "[TreeView]$m_treeView",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_treeView);
        }
    }
}
