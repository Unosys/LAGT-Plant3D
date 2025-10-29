// This file is auto-generated - do not hand edit this file.

using Autodesk.GUIHarness;
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{

    [UIElement(Tag = "[Pane]$EditProjectSettingsDlg", Parent = typeof(MainWin), GUIType = GuiType.UIA)]
    public partial class PandIDProjectSetupPathsDLG : Autodesk.GUIHarness.AutoCAD.AcDialogBox
    {
        public  PushButton CancelPB;
        public  PushButton M_btnClassSchema;
        public  PushButton M_btnDrawingDwtTemplate;
        public  PushButton M_btnHelp;
        public  PushButton M_btnOk;
        public  PushButton M_btnProjectDwgDir;
        public  PushButton M_btnSave;
        public  GroupBox M_groupBox;
        public  StaticText M_labelPnidDwtFileName;
        public  StaticText M_labelPssFile;
        public  StaticText M_labelSchemaDcfx;
        public  StaticText M_lablePnidDwgDwgDirectory;
        public  CustomWin M_pathsUserControl;
        public  CustomWin M_splitHorz;
        public  CustomWin M_splitVert;
        public  TextField M_textBoxDrawingDwtTemplate;
        public  TextField DrawingTemplateFileDWT1TF;
        public  TextField DrawingTemplateFileDWT2TF;
        public  TextField M_textBoxProjectDwgDirectory;
        public  TextField PIDDWGPTF;
        public  TextField M_textBoxProjSymbolStyles;
        public  TextField M_textBoxSchema;
        public  TreeView M_treeView;
        public  GroupBox SystemWindowsFormsSplitterPanel;
        public  GroupBox SystemWindowsFormsSplitterPanel2;
        public  GroupBox SystemWindowsFormsSplitterPanel3;
        public  GroupBox SystemWindowsFormsSplitterPanel4;

        partial void OnInitialize();

        public PandIDProjectSetupPathsDLG()
        {
            InitializeComponent();
            OnInitialize();
        }

        private void InitializeComponent()
        {

            CancelPB = new PushButton()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$1509842|#2/[PushButton]$m_btnCancel|#3",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(CancelPB);

            M_btnClassSchema = new PushButton()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$5898448|#1/[Pane]$m_splitVert|#1/[Pane]$4524392|#2/[Pane]$m_pathsUserControl|#1/[GroupBox]Paths|$m_groupBox|#1/[PushButton]$m_btnClassSchema",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_btnClassSchema);

            M_btnDrawingDwtTemplate = new PushButton()
            {
                Tag = "[PushButton]$m_btnDrawingDwtTemplate",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_btnDrawingDwtTemplate);

            M_btnHelp = new PushButton()
            {
                Tag = "[PushButton]$m_btnHelp",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_btnHelp);

            M_btnOk = new PushButton()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$3998772|#2/[PushButton]OK|$m_btnOk|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_btnOk);

            M_btnProjectDwgDir = new PushButton()
            {
                Tag = "[PushButton]$m_btnProjectDwgDir",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_btnProjectDwgDir);

            M_btnSave = new PushButton()
            {
                Tag = "[PushButton]$m_btnSave",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_btnSave);

            M_groupBox = new GroupBox()
            {
                Tag = "[GroupBox]$m_groupBox",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_groupBox);

            M_labelPnidDwtFileName = new StaticText()
            {
                Tag = "[StaticText]$m_labelPnidDwtFileName",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_labelPnidDwtFileName);

            M_labelPssFile = new StaticText()
            {
                Tag = "[StaticText]$m_labelPssFile",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_labelPssFile);

            M_labelSchemaDcfx = new StaticText()
            {
                Tag = "[StaticText]$m_labelSchemaDcfx",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_labelSchemaDcfx);

            M_lablePnidDwgDwgDirectory = new StaticText()
            {
                Tag = "[StaticText]$m_lablePnidDwgDwgDirectory",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_lablePnidDwgDwgDirectory);

            M_pathsUserControl = new CustomWin()
            {
                Tag = "[CustomWin]$m_pathsUserControl",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_pathsUserControl);

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
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$5898448|#1/[Pane]$m_splitVert|#1/[Pane]$4524392|#2/[Pane]$m_pathsUserControl|#1/[GroupBox]Paths|$m_groupBox|#1/[TextField]Drawing template file (DWT):|$m_textBoxDrawingDwtTemplate|#4",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_textBoxDrawingDwtTemplate);

            DrawingTemplateFileDWT1TF = new TextField()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$1705280|#1/[Pane]$m_splitVert|#1/[Pane]$853292|#2/[Pane]$m_pathsUserControl|#1/[GroupBox]$m_groupBoxProjectPath|#1/[TextField]$m_textBoxP3dDwtPath|#3",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(DrawingTemplateFileDWT1TF);

            DrawingTemplateFileDWT2TF = new TextField()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$16581128|#1/[Pane]$m_splitVert|#1/[Pane]$2295856|#2/[Pane]$m_pathsUserControl|#1/[GroupBox]$m_groupBoxProjectPath|#1/[TextField]$m_textBoxPnIdDwtPath|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(DrawingTemplateFileDWT2TF);

            M_textBoxProjectDwgDirectory = new TextField()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$10620054|#1/[Pane]$m_splitVert|#1/[Pane]$2036110|#2/[Pane]$m_pathsUserControl|#1/[GroupBox]Paths|$m_groupBox|#1/[TextField]PID DWG directory:|$m_textBoxProjectDwgDirectory|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_textBoxProjectDwgDirectory);

            PIDDWGPTF = new TextField()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]#1/[Pane]$m_splitVert|#1/[Pane]#2/[Pane]$m_pathsUserControl|#1/[GroupBox]$m_groupBoxProjectPath|#1/[TextField]$m_textBoxPnIdDwgPath|#3",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(PIDDWGPTF);

            M_textBoxProjSymbolStyles = new TextField()
            {
                Tag = "[TextField]$m_textBoxProjSymbolStyles",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_textBoxProjSymbolStyles);

            M_textBoxSchema = new TextField()
            {
                Tag = "[TextField]$m_textBoxSchema",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_textBoxSchema);

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
