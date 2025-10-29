// This file is auto-generated - do not hand edit this file.

using Autodesk.GUIHarness;
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{

    [UIElement(Tag = "[Pane]Project Setup|$EditProjectSettingsDlg", Parent = typeof(Plant3D), GUIType = GuiType.UIA)]
    public partial class ProjectSetupIsometricDWGSettingsDLG : Pane
    {
        public  TreeView TreeViewTV;
        public  TreeViewItem GeneralSettingsTVI;
        public  TreeViewItem DatabaseSetupTVI;
        public  TreeViewItem DrawingPropertiesTVI;
        public  TreeViewItem FileNameFormatTVI;
        public  TreeViewItem PathsTVI;
        public  TreeViewItem ProjectDetailsTVI;
        public  TreeViewItem ReportsTVI;
        public  TreeViewItem SharedPlantContentTVI;
        public  TreeViewItem PIDDWGSettingsTVI;
        public  TreeViewItem Plant3DDWGSettingsTVI;
        public  TreeViewItem IsometricDWGSettingsTVI;
        public  TreeViewItem SymbolsAndReferenceTVI;
        public  TreeViewItem IsoStyleSetupTVI;
        public  TreeViewItem IsoStyleDefaultSettingsTVI;
        public  TreeViewItem ThemesTVI;
        public  TreeViewItem AnnotationsTVI;
        public  TreeViewItem DimensionsTVI;
        public  TreeViewItem SlopedAndOffsetPipingTVI;
        public  TreeViewItem TitleBlockAndDisplayTVI;
        public  TreeViewItem LivePreviewTVI;
        public  TreeViewItem OrthoDWGSettingsTVI;
        public  PushButton CancelPB;
        public  PushButton OKPB;
        public  TitleBar ProjectSetupCTL;
        public  CustomWin SystemMenuBarWIN;
        public  MenuItem SystemMI;
        public  PushButton ClosePB;

        partial void OnInitialize();

        public ProjectSetupIsometricDWGSettingsDLG()
        {
            InitializeComponent();
            OnInitialize();
        }

        private void InitializeComponent()
        {

            TreeViewTV = new TreeView()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]#1/[Pane]$m_splitVert|#1/[Pane]#1/[TreeView]$m_treeView|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(TreeViewTV);

            GeneralSettingsTVI = new TreeViewItem()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]#1/[Pane]$m_splitVert|#1/[Pane]#1/[TreeView]$m_treeView|#1/[TreeViewItem]General Settings|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(GeneralSettingsTVI);

            DatabaseSetupTVI = new TreeViewItem()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]#1/[Pane]$m_splitVert|#1/[Pane]#1/[TreeView]$m_treeView|#1/[TreeViewItem]General Settings|#1/[TreeViewItem]Database Setup|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(DatabaseSetupTVI);

            DrawingPropertiesTVI = new TreeViewItem()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]#1/[Pane]$m_splitVert|#1/[Pane]#1/[TreeView]$m_treeView|#1/[TreeViewItem]General Settings|#1/[TreeViewItem]Drawing Properties|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(DrawingPropertiesTVI);

            FileNameFormatTVI = new TreeViewItem()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]#1/[Pane]$m_splitVert|#1/[Pane]#1/[TreeView]$m_treeView|#1/[TreeViewItem]General Settings|#1/[TreeViewItem]File Name Format|#3",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(FileNameFormatTVI);

            PathsTVI = new TreeViewItem()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]#1/[Pane]$m_splitVert|#1/[Pane]#1/[TreeView]$m_treeView|#1/[TreeViewItem]General Settings|#1/[TreeViewItem]Paths|#4",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(PathsTVI);

            ProjectDetailsTVI = new TreeViewItem()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]#1/[Pane]$m_splitVert|#1/[Pane]#1/[TreeView]$m_treeView|#1/[TreeViewItem]General Settings|#1/[TreeViewItem]Project Details|#5",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ProjectDetailsTVI);

            ReportsTVI = new TreeViewItem()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]#1/[Pane]$m_splitVert|#1/[Pane]#1/[TreeView]$m_treeView|#1/[TreeViewItem]General Settings|#1/[TreeViewItem]Reports|#6",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ReportsTVI);

            SharedPlantContentTVI = new TreeViewItem()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]#1/[Pane]$m_splitVert|#1/[Pane]#1/[TreeView]$m_treeView|#1/[TreeViewItem]General Settings|#1/[TreeViewItem]Shared Plant Content|#7",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(SharedPlantContentTVI);

            PIDDWGSettingsTVI = new TreeViewItem()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]#1/[Pane]$m_splitVert|#1/[Pane]#1/[TreeView]$m_treeView|#1/[TreeViewItem]P*|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(PIDDWGSettingsTVI);

            Plant3DDWGSettingsTVI = new TreeViewItem()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]#1/[Pane]$m_splitVert|#1/[Pane]#1/[TreeView]$m_treeView|#1/[TreeViewItem]Plant 3D DWG Settings|#3",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Plant3DDWGSettingsTVI);

            IsometricDWGSettingsTVI = new TreeViewItem()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]#1/[Pane]$m_splitVert|#1/[Pane]#1/[TreeView]$m_treeView|#1/[TreeViewItem]Isometric DWG Settings|#4",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(IsometricDWGSettingsTVI);

            SymbolsAndReferenceTVI = new TreeViewItem()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]#1/[Pane]$m_splitVert|#1/[Pane]#1/[TreeView]$m_treeView|#1/[TreeViewItem]Isometric DWG Settings|#4/[TreeViewItem]Symbols and Reference|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(SymbolsAndReferenceTVI);

            IsoStyleSetupTVI = new TreeViewItem()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]#1/[Pane]$m_splitVert|#1/[Pane]#1/[TreeView]$m_treeView|#1/[TreeViewItem]Isometric DWG Settings|#4/[TreeViewItem]Iso Style Setup|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(IsoStyleSetupTVI);

            IsoStyleDefaultSettingsTVI = new TreeViewItem()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]#1/[Pane]$m_splitVert|#1/[Pane]#1/[TreeView]$m_treeView|#1/[TreeViewItem]Isometric DWG Settings|#4/[TreeViewItem]Iso Style Default Settings|#3",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(IsoStyleDefaultSettingsTVI);

            ThemesTVI = new TreeViewItem()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]#1/[Pane]$m_splitVert|#1/[Pane]#1/[TreeView]$m_treeView|#1/[TreeViewItem]Isometric DWG Settings|#4/[TreeViewItem]Themes|#4",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ThemesTVI);

            AnnotationsTVI = new TreeViewItem()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]#1/[Pane]$m_splitVert|#1/[Pane]#1/[TreeView]$m_treeView|#1/[TreeViewItem]Isometric DWG Settings|#4/[TreeViewItem]Annotations|#5",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(AnnotationsTVI);

            DimensionsTVI = new TreeViewItem()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]#1/[Pane]$m_splitVert|#1/[Pane]#1/[TreeView]$m_treeView|#1/[TreeViewItem]Isometric DWG Settings|#4/[TreeViewItem]Dimensions|#6",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(DimensionsTVI);

            SlopedAndOffsetPipingTVI = new TreeViewItem()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]#1/[Pane]$m_splitVert|#1/[Pane]#1/[TreeView]$m_treeView|#1/[TreeViewItem]Isometric DWG Settings|#4/[TreeViewItem]Sloped and Offset Piping|#7",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(SlopedAndOffsetPipingTVI);

            TitleBlockAndDisplayTVI = new TreeViewItem()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]#1/[Pane]$m_splitVert|#1/[Pane]#1/[TreeView]$m_treeView|#1/[TreeViewItem]Isometric DWG Settings|#4/[TreeViewItem]Title Block and Display|#8",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(TitleBlockAndDisplayTVI);

            LivePreviewTVI = new TreeViewItem()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]#1/[Pane]$m_splitVert|#1/[Pane]#1/[TreeView]$m_treeView|#1/[TreeViewItem]Isometric DWG Settings|#4/[TreeViewItem]Live Preview|#9",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(LivePreviewTVI);

            OrthoDWGSettingsTVI = new TreeViewItem()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]#1/[Pane]$m_splitVert|#1/[Pane]#1/[TreeView]$m_treeView|#1/[TreeViewItem]Ortho DWG Settings|#5",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(OrthoDWGSettingsTVI);

            CancelPB = new PushButton()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$13239420|#2/[PushButton]Cancel|$m_btnCancel|#3",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(CancelPB);

            OKPB = new PushButton()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$13239420|#2/[PushButton]OK|$m_btnOk|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(OKPB);

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
