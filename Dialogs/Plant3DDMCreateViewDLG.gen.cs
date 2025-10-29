// This file is auto-generated - do not hand edit this file.

using Autodesk.GUIHarness;
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{

    [UIElement(Tag = "[Pane]$EditProjectSettingsDlg", Parent = typeof(Plant3D))]
    public partial class Plant3DDMCreateViewDLG : Pane
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
        public  Pane Pane7PANE;
        public  GroupBox CustomizedViewsGB;
        public  Pane Pane8PANE;
        public  Pane Pane9PANE;
        public  ListBox ListBoxLB;
        public  ListBoxItem ANewCustomizedViewLBI;
        public  Pane Pane10PANE;
        public  Pane Pane11PANE;
        public  Pane Pane12PANE;
        public  GroupBox ANewCustomizedViewGB;
        public  StaticText StaticTextST;
        public  Pane Pane13PANE;
        public  StaticText NameST;
        public  TextField TextFieldTF;
        public  StaticText ScopeST;
        public  PopupList ScopePL;
        public  PushButton DropDownButtonPB;
        public  PushButton NewLevelPB;
        public  PushButton DeleteViewPB;
        public  PushButton CreateViewPB;
        public  Pane Pane14PANE;
        public  PushButton HelpPB;
        public  PushButton CancelPB;
        public  PushButton OKPB;
        public  PushButton ApplyPB;
        public  TitleBar ProjectSetupCTL;
        public  CustomWin SystemMenuBarWIN;
        public  MenuItem SystemMI;
        public  PushButton ClosePB;

        partial void OnInitialize();

        public Plant3DDMCreateViewDLG()
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
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$9832638|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Pane2PANE);

            Pane3PANE = new Pane()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$9832638|#1/[Pane]$m_splitVert|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Pane3PANE);

            Pane4PANE = new Pane()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$9832638|#1/[Pane]$m_splitVert|#1/[Pane]$29951654|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Pane4PANE);

            TreeViewTV = new TreeView()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$9832638|#1/[Pane]$m_splitVert|#1/[Pane]$29951654|#1/[TreeView]$m_treeView|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(TreeViewTV);

            GeneralSettingsTVI = new TreeViewItem()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$9832638|#1/[Pane]$m_splitVert|#1/[Pane]$29951654|#1/[TreeView]$m_treeView|#1/[TreeViewItem]General Settings|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(GeneralSettingsTVI);

            ProjectDetailsTVI = new TreeViewItem()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$9832638|#1/[Pane]$m_splitVert|#1/[Pane]$29951654|#1/[TreeView]$m_treeView|#1/[TreeViewItem]General Settings|#1/[TreeViewItem]Project Details|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ProjectDetailsTVI);

            DatabaseSetupTVI = new TreeViewItem()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$9832638|#1/[Pane]$m_splitVert|#1/[Pane]$29951654|#1/[TreeView]$m_treeView|#1/[TreeViewItem]General Settings|#1/[TreeViewItem]Database Setup|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(DatabaseSetupTVI);

            DrawingPropertiesTVI = new TreeViewItem()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$9832638|#1/[Pane]$m_splitVert|#1/[Pane]$29951654|#1/[TreeView]$m_treeView|#1/[TreeViewItem]General Settings|#1/[TreeViewItem]Drawing Properties|#3",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(DrawingPropertiesTVI);

            ReportsTVI = new TreeViewItem()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$9832638|#1/[Pane]$m_splitVert|#1/[Pane]$29951654|#1/[TreeView]$m_treeView|#1/[TreeViewItem]General Settings|#1/[TreeViewItem]Reports|#4",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ReportsTVI);

            FileNameFormatTVI = new TreeViewItem()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$9832638|#1/[Pane]$m_splitVert|#1/[Pane]$29951654|#1/[TreeView]$m_treeView|#1/[TreeViewItem]General Settings|#1/[TreeViewItem]File Name Format|#5",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(FileNameFormatTVI);

            PIDDWGSettingsTVI = new TreeViewItem()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$9832638|#1/[Pane]$m_splitVert|#1/[Pane]$29951654|#1/[TreeView]$m_treeView|#1/[TreeViewItem]P*|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(PIDDWGSettingsTVI);

            Plant3DDWGSettingsTVI = new TreeViewItem()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$9832638|#1/[Pane]$m_splitVert|#1/[Pane]$29951654|#1/[TreeView]$m_treeView|#1/[TreeViewItem]Plant 3D DWG Settings|#3",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Plant3DDWGSettingsTVI);

            ExportAndImportSettingsTVI = new TreeViewItem()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$9832638|#1/[Pane]$m_splitVert|#1/[Pane]$29951654|#1/[TreeView]$m_treeView|#1/[TreeViewItem]Plant 3D DWG Settings|#3/[TreeViewItem]Export and Import Settings|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ExportAndImportSettingsTVI);

            PathsTVI = new TreeViewItem()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$9832638|#1/[Pane]$m_splitVert|#1/[Pane]$29951654|#1/[TreeView]$m_treeView|#1/[TreeViewItem]Plant 3D DWG Settings|#3/[TreeViewItem]Paths|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(PathsTVI);

            DataManagerConfigurationTVI = new TreeViewItem()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$9832638|#1/[Pane]$m_splitVert|#1/[Pane]$29951654|#1/[TreeView]$m_treeView|#1/[TreeViewItem]Plant 3D DWG Settings|#3/[TreeViewItem]Data Manager Configuration|#3",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(DataManagerConfigurationTVI);

            LayerAndColorSettingsTVI = new TreeViewItem()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$9832638|#1/[Pane]$m_splitVert|#1/[Pane]$29951654|#1/[TreeView]$m_treeView|#1/[TreeViewItem]Plant 3D DWG Settings|#3/[TreeViewItem]Layer and Color Settings|#4",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(LayerAndColorSettingsTVI);

            PipingConnectionSettingsTVI = new TreeViewItem()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$9832638|#1/[Pane]$m_splitVert|#1/[Pane]$29951654|#1/[TreeView]$m_treeView|#1/[TreeViewItem]Plant 3D DWG Settings|#3/[TreeViewItem]Piping Connection Settings|#5",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(PipingConnectionSettingsTVI);

            PIDObjectMappingTVI = new TreeViewItem()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$9832638|#1/[Pane]$m_splitVert|#1/[Pane]$29951654|#1/[TreeView]$m_treeView|#1/[TreeViewItem]Plant 3D DWG Settings|#3/[TreeViewItem]P*|#6",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(PIDObjectMappingTVI);

            Plant3DClassDefinitionsTVI = new TreeViewItem()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$9832638|#1/[Pane]$m_splitVert|#1/[Pane]$29951654|#1/[TreeView]$m_treeView|#1/[TreeViewItem]Plant 3D DWG Settings|#3/[TreeViewItem]Plant 3D Class Definitions|#7",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Plant3DClassDefinitionsTVI);

            SpecUpdateSettingsTVI = new TreeViewItem()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$9832638|#1/[Pane]$m_splitVert|#1/[Pane]$29951654|#1/[TreeView]$m_treeView|#1/[TreeViewItem]Plant 3D DWG Settings|#3/[TreeViewItem]Spec Update Settings|#8",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(SpecUpdateSettingsTVI);

            IsometricDWGSettingsTVI = new TreeViewItem()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$9832638|#1/[Pane]$m_splitVert|#1/[Pane]$29951654|#1/[TreeView]$m_treeView|#1/[TreeViewItem]Isometric DWG Settings|#4",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(IsometricDWGSettingsTVI);

            OrthoDWGSettingsTVI = new TreeViewItem()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$9832638|#1/[Pane]$m_splitVert|#1/[Pane]$29951654|#1/[TreeView]$m_treeView|#1/[TreeViewItem]Ortho DWG Settings|#5",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(OrthoDWGSettingsTVI);

            Pane5PANE = new Pane()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$9832638|#1/[Pane]$m_splitVert|#1/[Pane]$14945454|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Pane5PANE);

            Pane6PANE = new Pane()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$9832638|#1/[Pane]$m_splitVert|#1/[Pane]$14945454|#2/[Pane]$m_dm3dConfigUserControl|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Pane6PANE);

            Pane7PANE = new Pane()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$9832638|#1/[Pane]$m_splitVert|#1/[Pane]$14945454|#2/[Pane]$m_dm3dConfigUserControl|#1/[Pane]$m_dataManagerConfigUserControl|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Pane7PANE);

            CustomizedViewsGB = new GroupBox()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$9832638|#1/[Pane]$m_splitVert|#1/[Pane]$14945454|#2/[Pane]$m_dm3dConfigUserControl|#1/[Pane]$m_dataManagerConfigUserControl|#1/[GroupBox]Customized views|$m_viewsGroupBox|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(CustomizedViewsGB);

            Pane8PANE = new Pane()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$9832638|#1/[Pane]$m_splitVert|#1/[Pane]$14945454|#2/[Pane]$m_dm3dConfigUserControl|#1/[Pane]$m_dataManagerConfigUserControl|#1/[GroupBox]Customized views|$m_viewsGroupBox|#1/[Pane]$splitContainer1|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Pane8PANE);

            Pane9PANE = new Pane()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$9832638|#1/[Pane]$m_splitVert|#1/[Pane]$14945454|#2/[Pane]$m_dm3dConfigUserControl|#1/[Pane]$m_dataManagerConfigUserControl|#1/[GroupBox]Customized views|$m_viewsGroupBox|#1/[Pane]$splitContainer1|#1/[Pane]$4722844|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Pane9PANE);

            ListBoxLB = new ListBox()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$9832638|#1/[Pane]$m_splitVert|#1/[Pane]$14945454|#2/[Pane]$m_dm3dConfigUserControl|#1/[Pane]$m_dataManagerConfigUserControl|#1/[GroupBox]Customized views|$m_viewsGroupBox|#1/[Pane]$splitContainer1|#1/[Pane]$4722844|#1/[ListBox]$m_viewListBox|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ListBoxLB);

            ANewCustomizedViewLBI = new ListBoxItem()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$9832638|#1/[Pane]$m_splitVert|#1/[Pane]$14945454|#2/[Pane]$m_dm3dConfigUserControl|#1/[Pane]$m_dataManagerConfigUserControl|#1/[GroupBox]Customized views|$m_viewsGroupBox|#1/[Pane]$splitContainer1|#1/[Pane]$4722844|#1/[ListBox]$m_viewListBox|#1/[ListBoxItem]A New Customized View - Drawing Data|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ANewCustomizedViewLBI);

            Pane10PANE = new Pane()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$9832638|#1/[Pane]$m_splitVert|#1/[Pane]$14945454|#2/[Pane]$m_dm3dConfigUserControl|#1/[Pane]$m_dataManagerConfigUserControl|#1/[GroupBox]Customized views|$m_viewsGroupBox|#1/[Pane]$splitContainer1|#1/[Pane]$4263994|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Pane10PANE);

            Pane11PANE = new Pane()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$9832638|#1/[Pane]$m_splitVert|#1/[Pane]$14945454|#2/[Pane]$m_dm3dConfigUserControl|#1/[Pane]$m_dataManagerConfigUserControl|#1/[GroupBox]Customized views|$m_viewsGroupBox|#1/[Pane]$splitContainer1|#1/[Pane]$4263994|#2/[Pane]$m_viewsPanel|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Pane11PANE);

            Pane12PANE = new Pane()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$9832638|#1/[Pane]$m_splitVert|#1/[Pane]$14945454|#2/[Pane]$m_dm3dConfigUserControl|#1/[Pane]$m_dataManagerConfigUserControl|#1/[GroupBox]Customized views|$m_viewsGroupBox|#1/[Pane]$splitContainer1|#1/[Pane]$4263994|#2/[Pane]$m_viewsPanel|#1/[Pane]$CustomizedViewUserControl|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Pane12PANE);

            ANewCustomizedViewGB = new GroupBox()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$9832638|#1/[Pane]$m_splitVert|#1/[Pane]$14945454|#2/[Pane]$m_dm3dConfigUserControl|#1/[Pane]$m_dataManagerConfigUserControl|#1/[GroupBox]Customized views|$m_viewsGroupBox|#1/[Pane]$splitContainer1|#1/[Pane]$4263994|#2/[Pane]$m_viewsPanel|#1/[Pane]$CustomizedViewUserControl|#1/[GroupBox]A New Customized View - Drawing Data|$m_groupBox|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ANewCustomizedViewGB);

            StaticTextST = new StaticText()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$9832638|#1/[Pane]$m_splitVert|#1/[Pane]$14945454|#2/[Pane]$m_dm3dConfigUserControl|#1/[Pane]$m_dataManagerConfigUserControl|#1/[GroupBox]Customized views|$m_viewsGroupBox|#1/[Pane]$splitContainer1|#1/[Pane]$4263994|#2/[Pane]$m_viewsPanel|#1/[Pane]$CustomizedViewUserControl|#1/[GroupBox]A New Customized View - Drawing Data|$m_groupBox|#1/[StaticText]$m_viewNameLabel|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(StaticTextST);

            Pane13PANE = new Pane()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$9832638|#1/[Pane]$m_splitVert|#1/[Pane]$14945454|#2/[Pane]$m_dm3dConfigUserControl|#1/[Pane]$m_dataManagerConfigUserControl|#1/[GroupBox]Customized views|$m_viewsGroupBox|#1/[Pane]$splitContainer1|#1/[Pane]$4263994|#2/[Pane]$m_viewsPanel|#1/[Pane]$CustomizedViewUserControl|#1/[GroupBox]A New Customized View - Drawing Data|$m_groupBox|#1/[Pane]$m_viewNamePanel|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Pane13PANE);

            NameST = new StaticText()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$9832638|#1/[Pane]$m_splitVert|#1/[Pane]$14945454|#2/[Pane]$m_dm3dConfigUserControl|#1/[Pane]$m_dataManagerConfigUserControl|#1/[GroupBox]Customized views|$m_viewsGroupBox|#1/[Pane]$splitContainer1|#1/[Pane]$4263994|#2/[Pane]$m_viewsPanel|#1/[Pane]$CustomizedViewUserControl|#1/[GroupBox]A New Customized View - Drawing Data|$m_groupBox|#1/[Pane]$m_viewNamePanel|#1/[StaticText]Name:|$m_labelName|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(NameST);

            TextFieldTF = new TextField()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$9832638|#1/[Pane]$m_splitVert|#1/[Pane]$14945454|#2/[Pane]$m_dm3dConfigUserControl|#1/[Pane]$m_dataManagerConfigUserControl|#1/[GroupBox]Customized views|$m_viewsGroupBox|#1/[Pane]$splitContainer1|#1/[Pane]$4263994|#2/[Pane]$m_viewsPanel|#1/[Pane]$CustomizedViewUserControl|#1/[GroupBox]A New Customized View - Drawing Data|$m_groupBox|#1/[Pane]$m_viewNamePanel|#1/[TextField]$m_textBoxViewName|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(TextFieldTF);

            ScopeST = new StaticText()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$9832638|#1/[Pane]$m_splitVert|#1/[Pane]$14945454|#2/[Pane]$m_dm3dConfigUserControl|#1/[Pane]$m_dataManagerConfigUserControl|#1/[GroupBox]Customized views|$m_viewsGroupBox|#1/[Pane]$splitContainer1|#1/[Pane]$4263994|#2/[Pane]$m_viewsPanel|#1/[Pane]$CustomizedViewUserControl|#1/[GroupBox]A New Customized View - Drawing Data|$m_groupBox|#1/[Pane]$m_viewNamePanel|#1/[StaticText]Scope:|$m_labelScope|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ScopeST);

            ScopePL = new PopupList()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$9832638|#1/[Pane]$m_splitVert|#1/[Pane]$14945454|#2/[Pane]$m_dm3dConfigUserControl|#1/[Pane]$m_dataManagerConfigUserControl|#1/[GroupBox]Customized views|$m_viewsGroupBox|#1/[Pane]$splitContainer1|#1/[Pane]$4263994|#2/[Pane]$m_viewsPanel|#1/[Pane]$CustomizedViewUserControl|#1/[GroupBox]A New Customized View - Drawing Data|$m_groupBox|#1/[Pane]$m_viewNamePanel|#1/[PopupList]Scope:|$m_comboBoxScope|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ScopePL);

            DropDownButtonPB = new PushButton()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$9832638|#1/[Pane]$m_splitVert|#1/[Pane]$14945454|#2/[Pane]$m_dm3dConfigUserControl|#1/[Pane]$m_dataManagerConfigUserControl|#1/[GroupBox]Customized views|$m_viewsGroupBox|#1/[Pane]$splitContainer1|#1/[Pane]$4263994|#2/[Pane]$m_viewsPanel|#1/[Pane]$CustomizedViewUserControl|#1/[GroupBox]A New Customized View - Drawing Data|$m_groupBox|#1/[Pane]$m_viewNamePanel|#1/[PopupList]Scope:|$m_comboBoxScope|#1/[PushButton]Drop Down Button|$DropDown|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(DropDownButtonPB);

            NewLevelPB = new PushButton()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$9832638|#1/[Pane]$m_splitVert|#1/[Pane]$14945454|#2/[Pane]$m_dm3dConfigUserControl|#1/[Pane]$m_dataManagerConfigUserControl|#1/[GroupBox]Customized views|$m_viewsGroupBox|#1/[Pane]$splitContainer1|#1/[Pane]$4263994|#2/[Pane]$m_viewsPanel|#1/[Pane]$CustomizedViewUserControl|#1/[GroupBox]A New Customized View - Drawing Data|$m_groupBox|#1/[PushButton]New Level*|$m_btnNewLevel|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(NewLevelPB);

            DeleteViewPB = new PushButton()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$9832638|#1/[Pane]$m_splitVert|#1/[Pane]$14945454|#2/[Pane]$m_dm3dConfigUserControl|#1/[Pane]$m_dataManagerConfigUserControl|#1/[GroupBox]Customized views|$m_viewsGroupBox|#1/[PushButton]Delete View|$m_buttonRemoveView|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(DeleteViewPB);

            CreateViewPB = new PushButton()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$9832638|#1/[Pane]$m_splitVert|#1/[Pane]$14945454|#2/[Pane]$m_dm3dConfigUserControl|#1/[Pane]$m_dataManagerConfigUserControl|#1/[GroupBox]Customized views|$m_viewsGroupBox|#1/[PushButton]Create View|$m_buttonNewView|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(CreateViewPB);

            Pane14PANE = new Pane()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$4787818|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Pane14PANE);

            HelpPB = new PushButton()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$4787818|#2/[PushButton]Help|$m_btnHelp|#4",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(HelpPB);

            CancelPB = new PushButton()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$4787818|#2/[PushButton]Cancel|$m_btnCancel|#3",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(CancelPB);

            OKPB = new PushButton()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$4787818|#2/[PushButton]OK|$m_btnOk|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(OKPB);

            ApplyPB = new PushButton()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$4787818|#2/[PushButton]Apply|$m_btnSave|#1",
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
