// This file is auto-generated - do not hand edit this file.

using Autodesk.GUIHarness;
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{

    [UIElement(Tag = "[Pane]$EditProjectSettingsDlg", Parent = typeof(Plant3D))]
    public partial class ProjectSetupP3DExportImportDLG : Pane
    {
        public  Pane Pane1PANE;
        public  Pane Pane2PANE;
        public  Pane Pane3PANE;
        public  Pane Pane4PANE;
        public  TreeView TreeViewTV;
        public  TreeViewItem GeneralSettingsTVI;
        public  TreeViewItem ProjectDetailsTVI;
        public  TreeViewItem DatabaseSetupTVI;
        public  TreeViewItem DrawingPropertiesTVI;
        public  TreeViewItem ReportsTVI;
        public  TreeViewItem FileNameFormatTVI;
        public  TreeViewItem PIDDWGSettingsTVI;
        public  TreeViewItem Plant3DDWGSettingsTVI;
        public  TreeViewItem ExportAndImportSettingsTVI;
        public  TreeViewItem PathsTVI;
        public  TreeViewItem DataManagerConfigurationTVI;
        public  TreeViewItem LayerAndColorSettingsTVI;
        public  TreeViewItem PipingConnectionSettingsTVI;
        public  TreeViewItem PIDObjectMappingTVI;
        public  TreeViewItem Plant3DClassDefinitionsTVI;
        public  TreeViewItem SpecUpdateSettingsTVI;
        public  TreeViewItem IsometricDWGSettingsTVI;
        public  TreeViewItem OrthoDWGSettingsTVI;
        public  Pane Pane5PANE;
        public  Pane Pane6PANE;
        public  GroupBox ExportAndImportSettingsGB;
        public  PushButton DeletePB;
        public  PushButton M_btnModify;
        public  PushButton M_btnNew;
        public  ListBox ListBoxLB;
        public  Pane Pane7PANE;
        public  PushButton HelpPB;
        public  PushButton CancelPB;
        public  PushButton OKPB;
        public  PushButton ApplyPB;
        public  TitleBar ProjectSetupCTL;
        public  CustomWin SystemMenuBarWIN;
        public  MenuItem SystemMI;
        public  PushButton ClosePB;

        partial void OnInitialize();

        public ProjectSetupP3DExportImportDLG()
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
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$1118462|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Pane2PANE);

            Pane3PANE = new Pane()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$1118462|#1/[Pane]$m_splitVert|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Pane3PANE);

            Pane4PANE = new Pane()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$1118462|#1/[Pane]$m_splitVert|#1/[Pane]$18483476|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Pane4PANE);

            TreeViewTV = new TreeView()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$1118462|#1/[Pane]$m_splitVert|#1/[Pane]$18483476|#1/[TreeView]$m_treeView|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(TreeViewTV);

            GeneralSettingsTVI = new TreeViewItem()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$1118462|#1/[Pane]$m_splitVert|#1/[Pane]$18483476|#1/[TreeView]$m_treeView|#1/[TreeViewItem]General Settings|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(GeneralSettingsTVI);

            ProjectDetailsTVI = new TreeViewItem()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$1118462|#1/[Pane]$m_splitVert|#1/[Pane]$18483476|#1/[TreeView]$m_treeView|#1/[TreeViewItem]General Settings|#1/[TreeViewItem]Project Details|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ProjectDetailsTVI);

            DatabaseSetupTVI = new TreeViewItem()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$1118462|#1/[Pane]$m_splitVert|#1/[Pane]$18483476|#1/[TreeView]$m_treeView|#1/[TreeViewItem]General Settings|#1/[TreeViewItem]Database Setup|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(DatabaseSetupTVI);

            DrawingPropertiesTVI = new TreeViewItem()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$1118462|#1/[Pane]$m_splitVert|#1/[Pane]$18483476|#1/[TreeView]$m_treeView|#1/[TreeViewItem]General Settings|#1/[TreeViewItem]Drawing Properties|#3",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(DrawingPropertiesTVI);

            ReportsTVI = new TreeViewItem()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$1118462|#1/[Pane]$m_splitVert|#1/[Pane]$18483476|#1/[TreeView]$m_treeView|#1/[TreeViewItem]General Settings|#1/[TreeViewItem]Reports|#4",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ReportsTVI);

            FileNameFormatTVI = new TreeViewItem()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$1118462|#1/[Pane]$m_splitVert|#1/[Pane]$18483476|#1/[TreeView]$m_treeView|#1/[TreeViewItem]General Settings|#1/[TreeViewItem]File Name Format|#5",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(FileNameFormatTVI);

            PIDDWGSettingsTVI = new TreeViewItem()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$1118462|#1/[Pane]$m_splitVert|#1/[Pane]$18483476|#1/[TreeView]$m_treeView|#1/[TreeViewItem]P*|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(PIDDWGSettingsTVI);

            Plant3DDWGSettingsTVI = new TreeViewItem()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$1118462|#1/[Pane]$m_splitVert|#1/[Pane]$18483476|#1/[TreeView]$m_treeView|#1/[TreeViewItem]Plant 3D DWG Settings|#3",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Plant3DDWGSettingsTVI);

            ExportAndImportSettingsTVI = new TreeViewItem()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$1118462|#1/[Pane]$m_splitVert|#1/[Pane]$18483476|#1/[TreeView]$m_treeView|#1/[TreeViewItem]Plant 3D DWG Settings|#3/[TreeViewItem]Export and Import Settings|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ExportAndImportSettingsTVI);

            PathsTVI = new TreeViewItem()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$1118462|#1/[Pane]$m_splitVert|#1/[Pane]$18483476|#1/[TreeView]$m_treeView|#1/[TreeViewItem]Plant 3D DWG Settings|#3/[TreeViewItem]Paths|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(PathsTVI);

            DataManagerConfigurationTVI = new TreeViewItem()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$1118462|#1/[Pane]$m_splitVert|#1/[Pane]$18483476|#1/[TreeView]$m_treeView|#1/[TreeViewItem]Plant 3D DWG Settings|#3/[TreeViewItem]Data Manager Configuration|#3",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(DataManagerConfigurationTVI);

            LayerAndColorSettingsTVI = new TreeViewItem()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$1118462|#1/[Pane]$m_splitVert|#1/[Pane]$18483476|#1/[TreeView]$m_treeView|#1/[TreeViewItem]Plant 3D DWG Settings|#3/[TreeViewItem]Layer and Color Settings|#4",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(LayerAndColorSettingsTVI);

            PipingConnectionSettingsTVI = new TreeViewItem()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$1118462|#1/[Pane]$m_splitVert|#1/[Pane]$18483476|#1/[TreeView]$m_treeView|#1/[TreeViewItem]Plant 3D DWG Settings|#3/[TreeViewItem]Piping Connection Settings|#5",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(PipingConnectionSettingsTVI);

            PIDObjectMappingTVI = new TreeViewItem()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$1118462|#1/[Pane]$m_splitVert|#1/[Pane]$18483476|#1/[TreeView]$m_treeView|#1/[TreeViewItem]Plant 3D DWG Settings|#3/[TreeViewItem]P*|#6",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(PIDObjectMappingTVI);

            Plant3DClassDefinitionsTVI = new TreeViewItem()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$1118462|#1/[Pane]$m_splitVert|#1/[Pane]$18483476|#1/[TreeView]$m_treeView|#1/[TreeViewItem]Plant 3D DWG Settings|#3/[TreeViewItem]Plant 3D Class Definitions|#7",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Plant3DClassDefinitionsTVI);

            SpecUpdateSettingsTVI = new TreeViewItem()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$1118462|#1/[Pane]$m_splitVert|#1/[Pane]$18483476|#1/[TreeView]$m_treeView|#1/[TreeViewItem]Plant 3D DWG Settings|#3/[TreeViewItem]Spec Update Settings|#8",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(SpecUpdateSettingsTVI);

            IsometricDWGSettingsTVI = new TreeViewItem()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$1118462|#1/[Pane]$m_splitVert|#1/[Pane]$18483476|#1/[TreeView]$m_treeView|#1/[TreeViewItem]Isometric DWG Settings|#4",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(IsometricDWGSettingsTVI);

            OrthoDWGSettingsTVI = new TreeViewItem()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$1118462|#1/[Pane]$m_splitVert|#1/[Pane]$18483476|#1/[TreeView]$m_treeView|#1/[TreeViewItem]Ortho DWG Settings|#5",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(OrthoDWGSettingsTVI);

            Pane5PANE = new Pane()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$1118462|#1/[Pane]$m_splitVert|#1/[Pane]$594490|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Pane5PANE);

            Pane6PANE = new Pane()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$1118462|#1/[Pane]$m_splitVert|#1/[Pane]$594490|#2/[Pane]$m_exportImportSettingsUserControl|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Pane6PANE);

            ExportAndImportSettingsGB = new GroupBox()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$1118462|#1/[Pane]$m_splitVert|#1/[Pane]$594490|#2/[Pane]$m_exportImportSettingsUserControl|#1/[GroupBox]Export and import settings|$groupBox1|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ExportAndImportSettingsGB);

            DeletePB = new PushButton()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$1118462|#1/[Pane]$m_splitVert|#1/[Pane]$594490|#2/[Pane]$m_exportImportSettingsUserControl|#1/[GroupBox]Export and import settings|$groupBox1|#1/[PushButton]Delete|$m_btnDelete|#3",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(DeletePB);

            M_btnModify = new PushButton()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$1118462|#1/[Pane]$m_splitVert|#1/[Pane]$594490|#2/[Pane]$m_exportImportSettingsUserControl|#1/[GroupBox]Export and import settings|$groupBox1|#1/[PushButton]Modify*|$m_btnModify|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_btnModify);

            M_btnNew = new PushButton()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$1118462|#1/[Pane]$m_splitVert|#1/[Pane]$594490|#2/[Pane]$m_exportImportSettingsUserControl|#1/[GroupBox]Export and import settings|$groupBox1|#1/[PushButton]New*|$m_btnNew|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_btnNew);

            ListBoxLB = new ListBox()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$1118462|#1/[Pane]$m_splitVert|#1/[Pane]$594490|#2/[Pane]$m_exportImportSettingsUserControl|#1/[GroupBox]Export and import settings|$groupBox1|#1/[ListBox]$m_listBox|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ListBoxLB);

            Pane7PANE = new Pane()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$1969572|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Pane7PANE);

            HelpPB = new PushButton()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$1969572|#2/[PushButton]Help|$m_btnHelp|#4",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(HelpPB);

            CancelPB = new PushButton()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$1969572|#2/[PushButton]Cancel|$m_btnCancel|#3",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(CancelPB);

            OKPB = new PushButton()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$1969572|#2/[PushButton]OK|$m_btnOk|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(OKPB);

            ApplyPB = new PushButton()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$1969572|#2/[PushButton]Apply|$m_btnSave|#1",
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
