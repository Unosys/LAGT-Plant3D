// This file is auto-generated - do not hand edit this file.

using Autodesk.GUIHarness;
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{

    [UIElement(Tag = "[Pane]$EditProjectSettingsDlg", Parent = typeof(Plant3D))]
    public partial class ProjectSetupP3DPathsDLG : Pane
    {
        public  PushButton M_btnCancel;
        public  PushButton M_btnDrawingDwtTemplate;
        public  PushButton M_btnEquipSnapshotsDir;
        public  PushButton M_btnHelp;
        public  PushButton M_btnModelDwgDir;
        public  PushButton M_btnOk;
        public  PushButton M_btnSave;
        public  PushButton M_btnSpecDir;
        public  GroupBox M_groupBoxMain;
        public  StaticText M_labelEquipSnapshotsDir;
        public  StaticText M_labelModelDwgDir;
        public  StaticText M_labelPipingDwtFileName;
        public  StaticText M_labelSpecDir;
        public  CustomWin M_paths3dUserControl;
        public  CustomWin M_splitHorz;
        public  CustomWin M_splitVert;
        public  TextField M_textBoxDrawingDwtTemplate;
        public  TextField M_textBoxEquipSnapshotsDir;
        public  TextField M_textBoxModelDwgDir;
        public  TextField M_textBoxSpecDir;
        public  TreeView M_treeView;
        public  GroupBox SystemWindowsFormsSplitterPanel;
        public  GroupBox SystemWindowsFormsSplitterPanel2;
        public  GroupBox SystemWindowsFormsSplitterPanel3;
        public  GroupBox SystemWindowsFormsSplitterPanel4;

        partial void OnInitialize();

        public ProjectSetupP3DPathsDLG()
        {
            InitializeComponent();
            OnInitialize();
        }

        private void InitializeComponent()
        {

            M_btnCancel = new PushButton()
            {
                Tag = "[PushButton]$m_btnCancel",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_btnCancel);

            M_btnDrawingDwtTemplate = new PushButton()
            {
                Tag = "[PushButton]$m_btnDrawingDwtTemplate",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_btnDrawingDwtTemplate);

            M_btnEquipSnapshotsDir = new PushButton()
            {
                Tag = "[PushButton]$m_btnEquipSnapshotsDir",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_btnEquipSnapshotsDir);

            M_btnHelp = new PushButton()
            {
                Tag = "[PushButton]$m_btnHelp",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_btnHelp);

            M_btnModelDwgDir = new PushButton()
            {
                Tag = "[PushButton]$m_btnModelDwgDir",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_btnModelDwgDir);

            M_btnOk = new PushButton()
            {
                Tag = "[PushButton]$m_btnOk",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_btnOk);

            M_btnSave = new PushButton()
            {
                Tag = "[PushButton]$m_btnSave",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_btnSave);

            M_btnSpecDir = new PushButton()
            {
                Tag = "[PushButton]$m_btnSpecDir",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_btnSpecDir);

            M_groupBoxMain = new GroupBox()
            {
                Tag = "[GroupBox]$m_groupBoxMain",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_groupBoxMain);

            M_labelEquipSnapshotsDir = new StaticText()
            {
                Tag = "[StaticText]$m_labelEquipSnapshotsDir",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_labelEquipSnapshotsDir);

            M_labelModelDwgDir = new StaticText()
            {
                Tag = "[StaticText]$m_labelModelDwgDir",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_labelModelDwgDir);

            M_labelPipingDwtFileName = new StaticText()
            {
                Tag = "[StaticText]$m_labelPipingDwtFileName",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_labelPipingDwtFileName);

            M_labelSpecDir = new StaticText()
            {
                Tag = "[StaticText]$m_labelSpecDir",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_labelSpecDir);

            M_paths3dUserControl = new CustomWin()
            {
                Tag = "[CustomWin]$m_paths3dUserControl",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_paths3dUserControl);

            M_splitHorz = new CustomWin()
            {
                Tag = "[CustomWin]$m_splitHorz",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_splitHorz);

            M_splitVert = new CustomWin()
            {
                Tag = "[CustomWin]$m_splitVert",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_splitVert);

            M_textBoxDrawingDwtTemplate = new TextField()
            {
                Tag = "[TextField]$m_textBoxDrawingDwtTemplate",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_textBoxDrawingDwtTemplate);

            M_textBoxEquipSnapshotsDir = new TextField()
            {
                Tag = "[TextField]$m_textBoxEquipSnapshotsDir",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_textBoxEquipSnapshotsDir);

            M_textBoxModelDwgDir = new TextField()
            {
                Tag = "[TextField]$m_textBoxModelDwgDir",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_textBoxModelDwgDir);

            M_textBoxSpecDir = new TextField()
            {
                Tag = "[TextField]$m_textBoxSpecDir",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_textBoxSpecDir);

            M_treeView = new TreeView()
            {
                Tag = "[TreeView]$m_treeView",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_treeView);

            SystemWindowsFormsSplitterPanel = new GroupBox()
            {
                Tag = "[GroupBox]$m_splitHorz",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(SystemWindowsFormsSplitterPanel);

            SystemWindowsFormsSplitterPanel2 = new GroupBox()
            {
                Tag = "[GroupBox]$m_splitVert",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(SystemWindowsFormsSplitterPanel2);

            SystemWindowsFormsSplitterPanel3 = new GroupBox()
            {
                Tag = "[GroupBox]$m_splitVert",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(SystemWindowsFormsSplitterPanel3);

            SystemWindowsFormsSplitterPanel4 = new GroupBox()
            {
                Tag = "[GroupBox]$m_splitHorz",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(SystemWindowsFormsSplitterPanel4);
        }
    }
}
