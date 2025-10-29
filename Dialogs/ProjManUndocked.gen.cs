// This file is auto-generated - do not hand edit this file.

using Autodesk.GUIHarness;
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{

    [UIElement(Tag = "[CustomWin]PROJECTMANAGER", Parent = typeof(MainWin), GUIType = GuiType.WIN32)]
    public partial class ProjManUndocked : CustomWin
    {
        public  CustomWin PROJECTMANAGER1WIN;
        public  TreeView TreeViewTV;
        public  TreeViewItem DefaultProjectTVI;
        public  TreeViewItem PIDDrawingsTVI;
        public  TreeViewItem Plant3DDrawingsTVI;
        public  TreeViewItem PipeSpecsTVI;
        public  TreeViewItem one00HC01TVI;
        public  TreeViewItem RelatedFilesTVI;
        public  PopupList CurrentProjectPL;
        public  MenuItem OpenMI;
        public  MenuItem OpenReadonlyMI;
        public  MenuItem AddWorkHistoryMI;
        public  MenuItem RemoveDrawingMI;
        public  MenuItem RenameDrawingMI;
        public  MenuItem LocateDrawingMI;
        public  MenuItem RefreshXrefListMI;
        public  MenuItem XrefIntoCurrentDWGMI;
        public  MenuItem DataManagerMI;
        public  MenuItem PublishMI;
        public  MenuItem ValidateMI;
        public  MenuItem ExportToAutoCADMI;
        public  MenuItem DrawingAutogenPropertiesMI;
        public  MenuItem PropertiesMI;
        public  TreeView OrthoTreeViewTV;
        public  TreeViewItem OrthoDefaultProjectTVI;
        public  TreeViewItem OrthographicDrawingsTVI;
        public  TreeViewItem OrthoViewPortTVI;
        public  TreeViewItem UnnamedView1TVI;
        public  MenuItem OrthoValidateViewsMI;
        public  MenuItem OrthoUpdateViewsMI;
        public  MenuItem OrthoUpdateAnnotationsMI;
        public  MenuItem OrthoOpenMI;
        public  MenuItem OrthoOpenReadonlyMI;
        public  MenuItem OrthoRemoveDrawingMI;
        public  MenuItem OrthoRenameDrawingMI;
        public  MenuItem OrthoPublishMI;
        public  MenuItem OrthoPropertiesMI;
        public  Menu VaultDropDownMNU;
        public  Menu DropDownMNU;
        public  PushButton OpenPB;
        public  MenuItem CloseProjectMI;
        public  MenuItem ProjectCollaborationMI;
        public  MenuItem CheckInMI;
        public  MenuItem CheckOutMI;
        public  MenuItem UndoCheckOutMI;
        public  MenuItem RefreshFromProjectMI;
        public  MenuItem CleanupCachedFilesMI;
        public  MenuItem OptionsMI;
        public  MenuItem ValidateProjectMI;
        public  MenuItem ValidationSettingsMI;
        public  MenuItem ValidationSummaryMI;
        public  MenuItem ProjectAdministrationMI;
        public  MenuItem AuditProjectMI;
        public  MenuItem AuditDatabaseMI;
        public  MenuItem CreateProjectBackupMI;
        public  MenuItem ProjectCompareMI;
        public  MenuItem ProjectSetupMI;

        partial void OnInitialize();

        public ProjManUndocked()
        {
            InitializeComponent();
            OnInitialize();
        }

        private void InitializeComponent()
        {

            PROJECTMANAGER1WIN = new CustomWin()
            {
                Tag = "[CustomWin]#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(PROJECTMANAGER1WIN);

            TreeViewTV = new TreeView()
            {
                Tag = "[CustomWin]#1/[CustomWin]#1/[CustomWin]$1|#1/[Pane]$ControlAxSourcingSite|#1/[Pane]$splitContainer1|#1/[Pane]#1/[Pane]$m_collapsiblePanelTreeView|#1/[TreeView]$m_treeView|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(TreeViewTV);

            DefaultProjectTVI = new TreeViewItem()
            {
                Tag = "[CustomWin]#1/[CustomWin]#1/[CustomWin]$1|#1/[Pane]$ControlAxSourcingSite|#1/[Pane]$splitContainer1|#1/[Pane]#1/[Pane]$m_collapsiblePanelTreeView|#1/[TreeView]$m_treeView|#1/[TreeViewItem]Default Project|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(DefaultProjectTVI);

            PIDDrawingsTVI = new TreeViewItem()
            {
                Tag = "[CustomWin]#1/[CustomWin]#1/[CustomWin]$1|#1/[Pane]$ControlAxSourcingSite|#1/[Pane]$splitContainer1|#1/[Pane]#1/[Pane]$m_collapsiblePanelTreeView|#1/[TreeView]$m_treeView|#1/[TreeViewItem]Default Project|#1/[TreeViewItem]P*|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(PIDDrawingsTVI);

            Plant3DDrawingsTVI = new TreeViewItem()
            {
                Tag = "[CustomWin]#1/[CustomWin]#1/[CustomWin]$1|#1/[Pane]$ControlAxSourcingSite|#1/[Pane]$splitContainer1|#1/[Pane]#1/[Pane]$m_collapsiblePanelTreeView|#1/[TreeView]$m_treeView|#1/[TreeViewItem]Default Project|#1/[TreeViewItem]Plant 3D Drawings|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Plant3DDrawingsTVI);

            PipeSpecsTVI = new TreeViewItem()
            {
                Tag = "[CustomWin]#1/[CustomWin]#1/[CustomWin]$1|#1/[Pane]$ControlAxSourcingSite|#1/[Pane]$splitContainer1|#1/[Pane]$1049010|#1/[Pane]$m_collapsiblePanelTreeView|#1/[TreeView]$m_treeView|#1/[TreeViewItem]Default Project|#1/[TreeViewItem]Pipe Specs|#3",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(PipeSpecsTVI);

            one00HC01TVI = new TreeViewItem()
            {
                Tag = "[CustomWin]#1/[CustomWin]#1/[CustomWin]$1|#1/[Pane]$ControlAxSourcingSite|#1/[Pane]$splitContainer1|#1/[Pane]$1049010|#1/[Pane]$m_collapsiblePanelTreeView|#1/[TreeView]$m_treeView|#1/[TreeViewItem]Default Project|#1/[TreeViewItem]Pipe Specs|#3/[TreeViewItem]100HC01|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(one00HC01TVI);

            RelatedFilesTVI = new TreeViewItem()
            {
                Tag = "[CustomWin]#1/[CustomWin]#1/[CustomWin]$1|#1/[Pane]$ControlAxSourcingSite|#1/[Pane]$splitContainer1|#1/[Pane]$4653870|#1/[Pane]$m_collapsiblePanelTreeView|#1/[TreeView]$m_treeView|#1/[TreeViewItem]Default Project|#1/[TreeViewItem]Related Files|#4",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(RelatedFilesTVI);

            CurrentProjectPL = new PopupList()
            {
                Tag = "[CustomWin]#1/[CustomWin]#1/[CustomWin]$1|#1/[Pane]$ControlAxSourcingSite|#1/[PopupList]Current Project:|$m_comboPrjFiles|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(CurrentProjectPL);

            OpenMI = new MenuItem()
            {
                Tag = "[Menu]$contextMenuStrip1|#1/[MenuItem]Open|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(OpenMI);

            OpenReadonlyMI = new MenuItem()
            {
                Tag = "[Menu]$contextMenuStrip1|#1/[MenuItem]Open Read-only|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(OpenReadonlyMI);

            AddWorkHistoryMI = new MenuItem()
            {
                Tag = "[Menu]$contextMenuStrip1|#1/[MenuItem]Add Work History*|#3",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(AddWorkHistoryMI);

            RemoveDrawingMI = new MenuItem()
            {
                Tag = "[Menu]$contextMenuStrip1|#1/[MenuItem]Remove Drawing|#4",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(RemoveDrawingMI);

            RenameDrawingMI = new MenuItem()
            {
                Tag = "[Menu]$contextMenuStrip1|#1/[MenuItem]Rename Drawing*|#5",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(RenameDrawingMI);

            LocateDrawingMI = new MenuItem()
            {
                Tag = "[Menu]$contextMenuStrip1|#1/[MenuItem]Locate Drawing*|#6",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(LocateDrawingMI);

            RefreshXrefListMI = new MenuItem()
            {
                Tag = "[Menu]$contextMenuStrip1|#1/[MenuItem]Refresh Xref List|#7",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(RefreshXrefListMI);

            XrefIntoCurrentDWGMI = new MenuItem()
            {
                Tag = "[Menu]$contextMenuStrip1|#1/[MenuItem]Xref into current DWG|#8",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(XrefIntoCurrentDWGMI);

            DataManagerMI = new MenuItem()
            {
                Tag = "[Menu]$contextMenuStrip1|#1/[MenuItem]Data Manager*|#9",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(DataManagerMI);

            PublishMI = new MenuItem()
            {
                Tag = "[Menu]$contextMenuStrip1|#1/[MenuItem]Publish*|#10",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(PublishMI);

            ValidateMI = new MenuItem()
            {
                Tag = "[Menu]$contextMenuStrip1|#1/[MenuItem]Validate*|#11",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ValidateMI);

            ExportToAutoCADMI = new MenuItem()
            {
                Tag = "[Menu]$contextMenuStrip1|#1/[MenuItem]Export to AutoCAD*|#12",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ExportToAutoCADMI);

            DrawingAutogenPropertiesMI = new MenuItem()
            {
                Tag = "[Menu]$contextMenuStrip1|#1/[MenuItem]Drawing Autogen Properties*|#13",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(DrawingAutogenPropertiesMI);

            PropertiesMI = new MenuItem()
            {
                Tag = "[Menu]$contextMenuStrip1|#1/[MenuItem]Properties*|#14",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(PropertiesMI);

            OrthoTreeViewTV = new TreeView()
            {
                Tag = "[CustomWin]#1/[CustomWin]#1/[CustomWin]$2|#1/[Pane]$ControlAxSourcingSite|#1/[Pane]$splitContainer1|#1/[Pane]#1/[Pane]$m_collapsiblePanelTreeView|#1/[TreeView]$m_treeView|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(OrthoTreeViewTV);

            OrthoDefaultProjectTVI = new TreeViewItem()
            {
                Tag = "[CustomWin]#1/[CustomWin]#1/[CustomWin]$2|#1/[Pane]$ControlAxSourcingSite|#1/[Pane]$splitContainer1|#1/[Pane]#1/[Pane]$m_collapsiblePanelTreeView|#1/[TreeView]$m_treeView|#1/[TreeViewItem]#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(OrthoDefaultProjectTVI);

            OrthographicDrawingsTVI = new TreeViewItem()
            {
                Tag = "[CustomWin]#1/[CustomWin]#1/[CustomWin]$2|#1/[Pane]$ControlAxSourcingSite|#1/[Pane]$splitContainer1|#1/[Pane]#1/[Pane]$m_collapsiblePanelTreeView|#1/[TreeView]$m_treeView|#1/[TreeViewItem]#1/[TreeViewItem]#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(OrthographicDrawingsTVI);

            OrthoViewPortTVI = new TreeViewItem()
            {
                Tag = "[CustomWin]#1/[CustomWin]#1/[CustomWin]$2|#1/[Pane]$ControlAxSourcingSite|#1/[Pane]$splitContainer1|#1/[Pane]#1/[Pane]$m_collapsiblePanelTreeView|#1/[TreeView]$m_treeView|#1/[TreeViewItem]#1/[TreeViewItem]Orthographic Drawings|#1/[TreeViewItem]OrthoViewPort|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(OrthoViewPortTVI);

            UnnamedView1TVI = new TreeViewItem()
            {
                Tag = "[CustomWin]#1/[CustomWin]#1/[CustomWin]$2|#1/[Pane]$ControlAxSourcingSite|#1/[Pane]$splitContainer1|#1/[Pane]#1/[Pane]$m_collapsiblePanelTreeView|#1/[TreeView]$m_treeView|#1/[TreeViewItem]#1/[TreeViewItem]Orthographic Drawings|#1/[TreeViewItem]OrthoViewPort|#1/[TreeViewItem]#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(UnnamedView1TVI);

            OrthoValidateViewsMI = new MenuItem()
            {
                Tag = "[Menu]$contextMenuStrip1|#1/[MenuItem]Validate Views|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(OrthoValidateViewsMI);

            OrthoUpdateViewsMI = new MenuItem()
            {
                Tag = "[Menu]$contextMenuStrip1|#1/[MenuItem]Update Views|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(OrthoUpdateViewsMI);

            OrthoUpdateAnnotationsMI = new MenuItem()
            {
                Tag = "[Menu]$contextMenuStrip1|#1/[MenuItem]Update Annotations|#3",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(OrthoUpdateAnnotationsMI);

            OrthoOpenMI = new MenuItem()
            {
                Tag = "[Menu]$contextMenuStrip1|#1/[MenuItem]Open|#4",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(OrthoOpenMI);

            OrthoOpenReadonlyMI = new MenuItem()
            {
                Tag = "[Menu]$contextMenuStrip1|#1/[MenuItem]Open Read-only|#5",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(OrthoOpenReadonlyMI);

            OrthoRemoveDrawingMI = new MenuItem()
            {
                Tag = "[Menu]$contextMenuStrip1|#1/[MenuItem]Remove Drawing|#6",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(OrthoRemoveDrawingMI);

            OrthoRenameDrawingMI = new MenuItem()
            {
                Tag = "[Menu]$contextMenuStrip1|#1/[MenuItem]Rename Drawing*|#7",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(OrthoRenameDrawingMI);

            OrthoPublishMI = new MenuItem()
            {
                Tag = "[Menu]$contextMenuStrip1|#1/[MenuItem]Publish*|#8",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(OrthoPublishMI);

            OrthoPropertiesMI = new MenuItem()
            {
                Tag = "[Menu]$contextMenuStrip1|#1/[MenuItem]Properties*|#9",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(OrthoPropertiesMI);

            VaultDropDownMNU = new Menu()
            {
                Tag = "[Menu]VaultDropDown|#1",
                ParentType = this.GetType(),
                Parent = this,
                GUIType = GuiType.UIA,
            };
            DeclaredChildren.Add(VaultDropDownMNU);

            DropDownMNU = new Menu()
            {
                Tag = "[Menu]DropDown|#2",
                ParentType = this.GetType(),
                Parent = this,
                GUIType = GuiType.UIA,
            };
            DeclaredChildren.Add(DropDownMNU);

            OpenPB = new PushButton()
            {
                Tag = "[CustomWin]#1/[CustomWin]#1/[CustomWin]#1/[Pane]$ControlAxSourcingSite|#1/[PopupList]$m_comboPrjFiles|#1/[PushButton]Open|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(OpenPB);

            CloseProjectMI = new MenuItem()
            {
                Tag = "[Menu]$m_ProjectNodeContextMenuStrip|#1/[MenuItem]Close Project|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(CloseProjectMI);

            ProjectCollaborationMI = new MenuItem()
            {
                Tag = "[Menu]$m_ProjectNodeContextMenuStrip|#1/[MenuItem]Project Collaboration|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ProjectCollaborationMI);

            CheckInMI = new MenuItem()
            {
                Tag = "[Menu]$m_ProjectNodeContextMenuStrip|#1/[MenuItem]Check In*|#3",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(CheckInMI);

            CheckOutMI = new MenuItem()
            {
                Tag = "[Menu]$m_ProjectNodeContextMenuStrip|#1/[MenuItem]Check Out*|#4",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(CheckOutMI);

            UndoCheckOutMI = new MenuItem()
            {
                Tag = "[Menu]$m_ProjectNodeContextMenuStrip|#1/[MenuItem]Undo Check Out*|#5",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(UndoCheckOutMI);

            RefreshFromProjectMI = new MenuItem()
            {
                Tag = "[Menu]$m_ProjectNodeContextMenuStrip|#1/[MenuItem]Refresh from Project|#6",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(RefreshFromProjectMI);

            CleanupCachedFilesMI = new MenuItem()
            {
                Tag = "[Menu]$m_ProjectNodeContextMenuStrip|#1/[MenuItem]Cleanup Cached Files|#7",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(CleanupCachedFilesMI);

            OptionsMI = new MenuItem()
            {
                Tag = "[Menu]$m_ProjectNodeContextMenuStrip|#1/[MenuItem]Options*|#8",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(OptionsMI);

            ValidateProjectMI = new MenuItem()
            {
                Tag = "[Menu]$m_ProjectNodeContextMenuStrip|#1/[MenuItem]Validate Project|#11",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ValidateProjectMI);

            ValidationSettingsMI = new MenuItem()
            {
                Tag = "[Menu]$m_ProjectNodeContextMenuStrip|#1/[MenuItem]Validation Settings*|#12",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ValidationSettingsMI);

            ValidationSummaryMI = new MenuItem()
            {
                Tag = "[Menu]$m_ProjectNodeContextMenuStrip|#1/[MenuItem]Validation Summary|#13",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ValidationSummaryMI);

            ProjectAdministrationMI = new MenuItem()
            {
                Tag = "[Menu]$m_ProjectNodeContextMenuStrip|#1/[MenuItem]Project Administration|#14",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ProjectAdministrationMI);

            AuditProjectMI = new MenuItem()
            {
                Tag = "[Menu]$m_ProjectNodeContextMenuStrip|#1/[MenuItem]Audit Project|#15",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(AuditProjectMI);

            AuditDatabaseMI = new MenuItem()
            {
                Tag = "[Menu]$m_ProjectNodeContextMenuStrip|#1/[MenuItem]Audit Database|#16",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(AuditDatabaseMI);

            CreateProjectBackupMI = new MenuItem()
            {
                Tag = "[Menu]$m_ProjectNodeContextMenuStrip|#1/[MenuItem]Create Project Backup|#17",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(CreateProjectBackupMI);

            ProjectCompareMI = new MenuItem()
            {
                Tag = "[Menu]$m_ProjectNodeContextMenuStrip|#1/[MenuItem]Project Compare*|#18",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ProjectCompareMI);

            ProjectSetupMI = new MenuItem()
            {
                Tag = "[Menu]$m_ProjectNodeContextMenuStrip|#1/[MenuItem]Project Setup*|#19",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ProjectSetupMI);
        }
    }
}
