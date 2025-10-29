// This file is auto-generated - do not hand edit this file.

using Autodesk.GUIHarness;
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{

    [UIElement(Tag = "[Pane]$EditProjectSettingsDlg", Parent = typeof(Plant3D))]
    public partial class ProjectSetupPathsDLG : Pane
    {
        public  Pane Pane1PANE;
        public  Pane Pane2PANE;
        public  Pane Pane3PANE;
        public  Pane Pane4PANE;
        public  TreeView M_treeView;
        public  TreeViewItem GeneralSettingsTVI;
        public  TreeViewItem ProjectDetailsTVI;
        public  TreeViewItem DatabaseSetupTVI;
        public  TreeViewItem DrawingPropertiesTVI;
        public  TreeViewItem ReportsTVI;
        public  TreeViewItem FileNameFormatTVI;
        public  TreeViewItem PIDDWGSettingsTVI;
        public  TreeViewItem EndConnectionsTVI;
        public  TreeViewItem LineSettingsTVI;
        public  TreeViewItem ExportAndImportSettingsTVI;
        public  TreeViewItem PathsTVI;
        public  TreeViewItem DataManagerConfigurationTVI;
        public  TreeViewItem PIDClassDefinitionsTVI;
        public  TreeViewItem Plant3DDWGSettingsTVI;
        public  TreeViewItem IsometricDWGSettingsTVI;
        public  TreeViewItem OrthoDWGSettingsTVI;
        public  Pane Pane5PANE;
        public  Pane Pane6PANE;
        public  GroupBox PathsGB;
        public  PushButton PushButton1PB;
        public  PushButton PushButton2PB;
        public  TextField M_textBoxDrawingDwtTemplate;
        public  TextField PIDDWGDirectoryTF;
        public  StaticText DrawingTemplateFileDWTST;
        public  StaticText PIDDWGDirectoryST;
        public  TextField SymbolsAndStylesTF;
        public  StaticText SymbolsAndStylesST;
        public  StaticText ProjectPackageST;
        public  PushButton ReloadPB;
        public  TextField ProjectPackageTF;
        public  Pane Pane7PANE;
        public  PushButton HelpPB;
        public  PushButton CancelPB;
        public  PushButton M_btnOk;
        public  PushButton ApplyPB;
        public  TitleBar ProjectSetupCTL;
        public  CustomWin SystemMenuBarWIN;
        public  MenuItem SystemMI;
        public  PushButton ClosePB;

        partial void OnInitialize();

        public ProjectSetupPathsDLG()
        {
            InitializeComponent();
            OnInitialize();
        }

        private void InitializeComponent()
        {

            Pane1PANE = new Pane()
            {
                Tag = "[Pane]$m_splitHorz|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Pane1PANE);

            Pane2PANE = new Pane()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$25100524|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Pane2PANE);

            Pane3PANE = new Pane()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$25100524|#1/[Pane]$m_splitVert|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Pane3PANE);

            Pane4PANE = new Pane()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$25100524|#1/[Pane]$m_splitVert|#1/[Pane]$25625834|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Pane4PANE);

            M_treeView = new TreeView()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$25100524|#1/[Pane]$m_splitVert|#1/[Pane]$25625834|#1/[TreeView]$m_treeView|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_treeView);

            GeneralSettingsTVI = new TreeViewItem()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$25100524|#1/[Pane]$m_splitVert|#1/[Pane]$25625834|#1/[TreeView]$m_treeView|#1/[TreeViewItem]General Settings|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(GeneralSettingsTVI);

            ProjectDetailsTVI = new TreeViewItem()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$25100524|#1/[Pane]$m_splitVert|#1/[Pane]$25625834|#1/[TreeView]$m_treeView|#1/[TreeViewItem]General Settings|#1/[TreeViewItem]Project Details|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ProjectDetailsTVI);

            DatabaseSetupTVI = new TreeViewItem()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$25100524|#1/[Pane]$m_splitVert|#1/[Pane]$25625834|#1/[TreeView]$m_treeView|#1/[TreeViewItem]General Settings|#1/[TreeViewItem]Database Setup|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(DatabaseSetupTVI);

            DrawingPropertiesTVI = new TreeViewItem()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$25100524|#1/[Pane]$m_splitVert|#1/[Pane]$25625834|#1/[TreeView]$m_treeView|#1/[TreeViewItem]General Settings|#1/[TreeViewItem]Drawing Properties|#3",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(DrawingPropertiesTVI);

            ReportsTVI = new TreeViewItem()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$25100524|#1/[Pane]$m_splitVert|#1/[Pane]$25625834|#1/[TreeView]$m_treeView|#1/[TreeViewItem]General Settings|#1/[TreeViewItem]Reports|#4",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ReportsTVI);

            FileNameFormatTVI = new TreeViewItem()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$25100524|#1/[Pane]$m_splitVert|#1/[Pane]$25625834|#1/[TreeView]$m_treeView|#1/[TreeViewItem]General Settings|#1/[TreeViewItem]File Name Format|#5",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(FileNameFormatTVI);

            PIDDWGSettingsTVI = new TreeViewItem()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$25100524|#1/[Pane]$m_splitVert|#1/[Pane]$25625834|#1/[TreeView]$m_treeView|#1/[TreeViewItem]P*|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(PIDDWGSettingsTVI);

            EndConnectionsTVI = new TreeViewItem()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$25100524|#1/[Pane]$m_splitVert|#1/[Pane]$25625834|#1/[TreeView]$m_treeView|#1/[TreeViewItem]P*|#2/[TreeViewItem]End Connections|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(EndConnectionsTVI);

            LineSettingsTVI = new TreeViewItem()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$25100524|#1/[Pane]$m_splitVert|#1/[Pane]$25625834|#1/[TreeView]$m_treeView|#1/[TreeViewItem]P*|#2/[TreeViewItem]Line Settings|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(LineSettingsTVI);

            ExportAndImportSettingsTVI = new TreeViewItem()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$25100524|#1/[Pane]$m_splitVert|#1/[Pane]$25625834|#1/[TreeView]$m_treeView|#1/[TreeViewItem]P*|#2/[TreeViewItem]Export and Import Settings|#3",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ExportAndImportSettingsTVI);

            PathsTVI = new TreeViewItem()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$25100524|#1/[Pane]$m_splitVert|#1/[Pane]$25625834|#1/[TreeView]$m_treeView|#1/[TreeViewItem]P*|#2/[TreeViewItem]Paths|#4",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(PathsTVI);

            DataManagerConfigurationTVI = new TreeViewItem()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$25100524|#1/[Pane]$m_splitVert|#1/[Pane]$25625834|#1/[TreeView]$m_treeView|#1/[TreeViewItem]P*|#2/[TreeViewItem]Data Manager Configuration|#5",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(DataManagerConfigurationTVI);

            PIDClassDefinitionsTVI = new TreeViewItem()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$25100524|#1/[Pane]$m_splitVert|#1/[Pane]$25625834|#1/[TreeView]$m_treeView|#1/[TreeViewItem]P*|#2/[TreeViewItem]P*|#6",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(PIDClassDefinitionsTVI);

            Plant3DDWGSettingsTVI = new TreeViewItem()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$25100524|#1/[Pane]$m_splitVert|#1/[Pane]$25625834|#1/[TreeView]$m_treeView|#1/[TreeViewItem]Plant 3D DWG Settings|#3",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Plant3DDWGSettingsTVI);

            IsometricDWGSettingsTVI = new TreeViewItem()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$25100524|#1/[Pane]$m_splitVert|#1/[Pane]$25625834|#1/[TreeView]$m_treeView|#1/[TreeViewItem]Isometric DWG Settings|#4",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(IsometricDWGSettingsTVI);

            OrthoDWGSettingsTVI = new TreeViewItem()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$25100524|#1/[Pane]$m_splitVert|#1/[Pane]$25625834|#1/[TreeView]$m_treeView|#1/[TreeViewItem]Ortho DWG Settings|#5",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(OrthoDWGSettingsTVI);

            Pane5PANE = new Pane()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$25100524|#1/[Pane]$m_splitVert|#1/[Pane]$10617086|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Pane5PANE);

            Pane6PANE = new Pane()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$25100524|#1/[Pane]$m_splitVert|#1/[Pane]$10617086|#2/[Pane]$m_pathsUserControl|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Pane6PANE);

            PathsGB = new GroupBox()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$25100524|#1/[Pane]$m_splitVert|#1/[Pane]$10617086|#2/[Pane]$m_pathsUserControl|#1/[GroupBox]Paths|$m_groupBox|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(PathsGB);

            PushButton1PB = new PushButton()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$25100524|#1/[Pane]$m_splitVert|#1/[Pane]$10617086|#2/[Pane]$m_pathsUserControl|#1/[GroupBox]Paths|$m_groupBox|#1/[PushButton]**[1]|$m_btnDrawingDwtTemplate|#3",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(PushButton1PB);

            PushButton2PB = new PushButton()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$25100524|#1/[Pane]$m_splitVert|#1/[Pane]$10617086|#2/[Pane]$m_pathsUserControl|#1/[GroupBox]Paths|$m_groupBox|#1/[PushButton]**[2]|$m_btnProjectDwgDir|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(PushButton2PB);

            M_textBoxDrawingDwtTemplate = new TextField()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$25100524|#1/[Pane]$m_splitVert|#1/[Pane]$10617086|#2/[Pane]$m_pathsUserControl|#1/[GroupBox]Paths|$m_groupBox|#1/[TextField]Drawing template file (DWT):|$m_textBoxDrawingDwtTemplate|#4",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_textBoxDrawingDwtTemplate);

            PIDDWGDirectoryTF = new TextField()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$25100524|#1/[Pane]$m_splitVert|#1/[Pane]$10617086|#2/[Pane]$m_pathsUserControl|#1/[GroupBox]Paths|$m_groupBox|#1/[TextField]PID DWG directory:|$m_textBoxProjectDwgDirectory|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(PIDDWGDirectoryTF);

            DrawingTemplateFileDWTST = new StaticText()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$25100524|#1/[Pane]$m_splitVert|#1/[Pane]$10617086|#2/[Pane]$m_pathsUserControl|#1/[GroupBox]Paths|$m_groupBox|#1/[StaticText]Drawing template file (DWT):|$m_labelPnidDwtFileName|#4",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(DrawingTemplateFileDWTST);

            PIDDWGDirectoryST = new StaticText()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$25100524|#1/[Pane]$m_splitVert|#1/[Pane]$10617086|#2/[Pane]$m_pathsUserControl|#1/[GroupBox]Paths|$m_groupBox|#1/[StaticText]P*|$m_lablePnidDwgDwgDirectory|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(PIDDWGDirectoryST);

            SymbolsAndStylesTF = new TextField()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$25100524|#1/[Pane]$m_splitVert|#1/[Pane]$10617086|#2/[Pane]$m_pathsUserControl|#1/[GroupBox]Paths|$m_groupBox|#1/[TextField]Symbols and styles:|$m_textBoxProjSymbolStyles|#3",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(SymbolsAndStylesTF);

            SymbolsAndStylesST = new StaticText()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$25100524|#1/[Pane]$m_splitVert|#1/[Pane]$10617086|#2/[Pane]$m_pathsUserControl|#1/[GroupBox]Paths|$m_groupBox|#1/[StaticText]Symbols and styles:|$m_labelPssFile|#3",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(SymbolsAndStylesST);

            ProjectPackageST = new StaticText()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$25100524|#1/[Pane]$m_splitVert|#1/[Pane]$10617086|#2/[Pane]$m_pathsUserControl|#1/[GroupBox]Paths|$m_groupBox|#1/[StaticText]Project package:|$m_labelSchemaDcfx|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ProjectPackageST);

            ReloadPB = new PushButton()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$25100524|#1/[Pane]$m_splitVert|#1/[Pane]$10617086|#2/[Pane]$m_pathsUserControl|#1/[GroupBox]Paths|$m_groupBox|#1/[PushButton]Reload|$m_btnClassSchema|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ReloadPB);

            ProjectPackageTF = new TextField()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$25100524|#1/[Pane]$m_splitVert|#1/[Pane]$10617086|#2/[Pane]$m_pathsUserControl|#1/[GroupBox]Paths|$m_groupBox|#1/[TextField]Project package:|$m_textBoxSchema|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ProjectPackageTF);

            Pane7PANE = new Pane()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$3346566|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Pane7PANE);

            HelpPB = new PushButton()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$3346566|#2/[PushButton]Help|$m_btnHelp|#4",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(HelpPB);

            CancelPB = new PushButton()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$3346566|#2/[PushButton]Cancel|$m_btnCancel|#3",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(CancelPB);

            M_btnOk = new PushButton()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$3346566|#2/[PushButton]OK|$m_btnOk|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_btnOk);

            ApplyPB = new PushButton()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$3346566|#2/[PushButton]Apply|$m_btnSave|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ApplyPB);

            ProjectSetupCTL = new TitleBar()
            {
                Tag = "[TitleBar]Project Setup|$TitleBar|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ProjectSetupCTL);

            SystemMenuBarWIN = new CustomWin()
            {
                Tag = "[TitleBar]Project Setup|$TitleBar|#1/[CustomWin]System Menu Bar|$EditProjectSettingsDlg|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(SystemMenuBarWIN);

            SystemMI = new MenuItem()
            {
                Tag = "[TitleBar]Project Setup|$TitleBar|#1/[CustomWin]System Menu Bar|$EditProjectSettingsDlg|#1/[MenuItem]System|$Item 1|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(SystemMI);

            ClosePB = new PushButton()
            {
                Tag = "[TitleBar]Project Setup|$TitleBar|#1/[PushButton]Close|$Close|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ClosePB);
        }
    }
}
