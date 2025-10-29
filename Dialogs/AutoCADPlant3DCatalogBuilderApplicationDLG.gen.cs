// This file is auto-generated - do not hand edit this file.

using Autodesk.GUIHarness;
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{

    [UIElement(Tag = "[MainWin]Autodesk AutoCAD Plant 3D Catalog Builder (C:*|$Window", Parent = typeof(Desktop), GUIType = GuiType.UIA)]
    public partial class AutoCADPlant3DCatalogBuilderApplicationDLG : Autodesk.GUIHarness.MainWin
    {
        public  PushButton MaximizePB;
        public  RadioButton FittingsBtn;
        public  RadioButton FastenersBtn;
        public  StaticText BoltSet1ST;
        public  PushButton IdNewFamily;
        public  PushButton IdExportToExcel;
        public  PushButton IdNew;
        public  RadioButton RadioButton3;
        public  PushButton SelectPreviewImageBtn;
        public  StaticText CrossST;
        public  RadioButton RadioButton2;
        public  PushButton ClosePB;
        public  RadioButton RadioButton1;
        public  PushButton SelectDwgBtn;
        public  PushButton SelectPytonBtn;
        public  PushButton IdSaveAs;
        public  PushButton DeletePB;
        public  PushButton IdSettings;
        public  PushButton IdDeleteFamily;
        public  StaticText StaticText1ST;
        public  PushButton IdBuildCatalog;

        partial void OnInitialize();

        public AutoCADPlant3DCatalogBuilderApplicationDLG()
        {
            InitializeComponent();
            OnInitialize();
        }

        private void InitializeComponent()
        {

            MaximizePB = new PushButton()
            {
                Tag = "[TitleBar]$TitleBar|#1/[PushButton]$Maximize|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(MaximizePB);

            FittingsBtn = new RadioButton()
            {
                Tag = "[RadioButton]Part Family Details:[2]|$FittingsBtn|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(FittingsBtn);

            FastenersBtn = new RadioButton()
            {
                Tag = "[RadioButton]Part Family Details:[1]|$FastenersBtn|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(FastenersBtn);

            BoltSet1ST = new StaticText()
            {
                Tag = "[TreeView]$CategoryTreeView|#1/[TreeViewItem]All|$CategoryTreeRoot|#1/[TreeViewItem]BoltSet|#2/[StaticText]BoltSet|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(BoltSet1ST);

            IdNewFamily = new PushButton()
            {
                Tag = "[ListBox]#2/[ListViewItem]#1/[CustomWin]ID_TabHome|$ID_TabHome_PanelBarScrollViewer|#1/[ListBox]$mMainTabPanels|#1/[ListViewItem]#2/[CustomWin]$ID_PartFamilyPanel|#1/[ListBox]$mRibbonPanelView|#1/[ListViewItem]#2/[CustomWin]New|$ID_NewFamily_RibbonItemControl|#1/[PushButton]New|$ID_NewFamily|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(IdNewFamily);

            IdExportToExcel = new PushButton()
            {
                Tag = "[ListBox]#2/[ListViewItem]#1/[CustomWin]ID_TabHome|$ID_TabHome_PanelBarScrollViewer|#1/[ListBox]$mMainTabPanels|#1/[ListViewItem]#4/[CustomWin]Catalog|$ID_CatalogPanel|#1/[ListBox]Catalog|$mRibbonPanelView|#1/[ListViewItem]#2/[CustomWin]Export*|$ID_ExportToExcel_RibbonItemControl|#1/[PushButton]Export*|$ID_ExportToExcel|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(IdExportToExcel);

            IdNew = new PushButton()
            {
                Tag = "[ListBox]#2/[ListViewItem]#1/[CustomWin]ID_TabHome|$ID_TabHome_PanelBarScrollViewer|#1/[ListBox]$mMainTabPanels|#1/[ListViewItem]#1/[CustomWin]Catalog Template|$ID_CatalogTemplatePanel|#1/[ListBox]Catalog Template|$mRibbonPanelView|#1/[ListViewItem]#2/[CustomWin]New|$ID_New_RibbonItemControl|#1/[PushButton]New|$ID_New|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(IdNew);

            RadioButton3 = new RadioButton()
            {
                Tag = "[Pane]$ScrollViewer_2|#1/[GroupBox]Graphics|$GroupBox_1|#2/[RadioButton]Graphics[3]|$RadioButton_3|#3",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(RadioButton3);

            SelectPreviewImageBtn = new PushButton()
            {
                Tag = "[Pane]$ScrollViewer_2|#1/[GroupBox]Graphics|$GroupBox_1|#2/[PushButton]**[2]|$SelectPreviewImageBtn|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(SelectPreviewImageBtn);

            CrossST = new StaticText()
            {
                Tag = "[TreeView]$CategoryTreeView|#1/[TreeViewItem]All|$CategoryTreeRoot|#1/[TreeViewItem]Cross|#2/[StaticText]Cross|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(CrossST);

            RadioButton2 = new RadioButton()
            {
                Tag = "[Pane]$ScrollViewer_2|#1/[GroupBox]Graphics|$GroupBox_1|#2/[RadioButton]Graphics[2]|$RadioButton_2|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(RadioButton2);

            ClosePB = new PushButton()
            {
                Tag = "[TitleBar]$TitleBar|#1/[PushButton]Close|$Close|#3",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ClosePB);

            RadioButton1 = new RadioButton()
            {
                Tag = "[Pane]$ScrollViewer_2|#1/[GroupBox]Graphics|$GroupBox_1|#2/[RadioButton]Graphics[1]|$RadioButton_1|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(RadioButton1);

            SelectDwgBtn = new PushButton()
            {
                Tag = "[Pane]$ScrollViewer_2|#1/[GroupBox]Graphics|$GroupBox_1|#2/[PushButton]**|$SelectDwgBtn|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(SelectDwgBtn);

            SelectPytonBtn = new PushButton()
            {
                Tag = "[Pane]$ScrollViewer_2|#1/[GroupBox]Graphics|$GroupBox_1|#2/[PushButton]**[1]|$SelectPytonBtn|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(SelectPytonBtn);

            IdSaveAs = new PushButton()
            {
                Tag = "[ListBox]#2/[ListViewItem]#1/[CustomWin]ID_TabHome|$ID_TabHome_PanelBarScrollViewer|#1/[ListBox]$mMainTabPanels|#1/[ListViewItem]#1/[CustomWin]Catalog Template|$ID_CatalogTemplatePanel|#1/[ListBox]Catalog Template|$mRibbonPanelView|#1/[ListViewItem]#8/[CustomWin]Save As|$ID_SaveAs_RibbonItemControl|#1/[PushButton]Save As|$ID_SaveAs|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(IdSaveAs);

            DeletePB = new PushButton()
            {
                Tag = "[ListBox]#2/[ListViewItem]#1/[CustomWin]ID_TabHome|$ID_TabHome_PanelBarScrollViewer|#1/[ListBox]$mMainTabPanels|#1/[ListViewItem]#2/[CustomWin]$ID_PartFamilyPanel|#1/[ListBox]$mRibbonPanelView|#1/[ListViewItem]#6/[CustomWin]Delete|$ID_DeleteFamily_RibbonItemControl|#1/[PushButton]Delete|$ID_DeleteFamily|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(DeletePB);

            IdSettings = new PushButton()
            {
                Tag = "[ListBox]#2/[ListViewItem]#1/[CustomWin]ID_TabHome|$ID_TabHome_PanelBarScrollViewer/[ListBox]$mMainTabPanels|#1/[ListViewItem]#5/[CustomWin]Advanced|$ID_AdvancedPanel|#1/[ListBox]Advanced|$mRibbonPanelView|#1/[ListViewItem]#2/[CustomWin]Settings|$ID_Settings_RibbonItemControl|#1/[PushButton]$ID_Settings",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(IdSettings);

            IdDeleteFamily = new PushButton()
            {
                Tag = "[ListBox]#2/[ListViewItem]#1/[CustomWin]ID_TabHome|$ID_TabHome_PanelBarScrollViewer|#1/[ListBox]$mMainTabPanels|#1/[ListViewItem]#2/[CustomWin]$ID_PartFamilyPanel|#1/[ListBox]$mRibbonPanelView|#1/[ListViewItem]#6/[CustomWin]Delete|$ID_DeleteFamily_RibbonItemControl|#1/[PushButton]Delete|$ID_DeleteFamily|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(IdDeleteFamily);

            StaticText1ST = new StaticText()
            {
                Tag = "[Pane]$ScrollViewer_2|#1/[GroupBox]Graphics|$GroupBox_1|#2/[PushButton]**[1]|$SelectPytonBtn|#1/[StaticText]**|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(StaticText1ST);

            IdBuildCatalog = new PushButton()
            {
                Tag = "[ListBox]#2/[ListViewItem]#1/[CustomWin]ID_TabHome|$ID_TabHome_PanelBarScrollViewer|#1/[ListBox]$mMainTabPanels|#1/[ListViewItem]#4/[CustomWin]Catalog|$ID_CatalogPanel|#1/[ListBox]Catalog|$mRibbonPanelView|#1/[ListViewItem]#4/[CustomWin]Build*|$ID_BuildCatalog_RibbonItemControl|#1/[PushButton]Build*|$ID_BuildCatalog|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(IdBuildCatalog);
        }
    }
}
