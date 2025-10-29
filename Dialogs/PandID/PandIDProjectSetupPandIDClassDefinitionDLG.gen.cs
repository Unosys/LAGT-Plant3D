// This file is auto-generated - do not hand edit this file.

using Autodesk.GUIHarness;
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{

    [UIElement(Tag = "[Pane]$EditProjectSettingsDlg", Parent = typeof(Plant3D))]
    public partial class PandIDProjectSetupPandIDClassDefinitionDLG : Autodesk.GUIHarness.AutoCAD.AcDialogBox
    {
        public  ScrollBar ClassSettingsEngineeringItems;
        public  PushButton M_btnAdd2TP;
        public  PushButton M_btnAddAnn;
        public  PushButton M_btnAddProperty;
        public  PushButton M_btnAddStyle;
        public  PushButton M_btnCancel;
        public  PushButton M_btnDeleteTag;
        public  PushButton M_btnEditAnn;
        public  PushButton M_btnEditProperties;
        public  PushButton M_btnEditStyle;
        public  PushButton M_btnHelp;
        public  PushButton M_btnModifyAnn;
        public  PushButton M_btnModifyStyle;
        public  PushButton M_btnModifyTag;
        public  PushButton M_btnNewTag;
        public  PushButton M_btnOk;
        public  PushButton M_btnRemoveAnn;
        public  PushButton M_btnRemoveProperties;
        public  PushButton M_btnRemoveStyle;
        public  PushButton M_btnSave;
        public  ComboBox M_comboBoxAnn;
        public  ComboBox M_comboBoxGraphical;
        public  Table M_dataGridView;
        public  GroupBox M_groupBox;
        public  GroupBox M_groupBoxAnn;
        public  GroupBox M_GroupBoxGraphical;
        public  GroupBox M_groupBoxProperties;
        public  GroupBox M_groupBoxTag;
        public  ListBox M_listBoxTag;
        public  StaticText M_PreviewStatic;
        public  TreeView M_treeView;
        public  GroupBox SystemWindowsFormsSplitterPanel;
        public  GroupBox SystemWindowsFormsSplitterPanel2;
        public  GroupBox SystemWindowsFormsSplitterPanel3;
        public  GroupBox SystemWindowsFormsSplitterPanel4;
        public  ListViewItem M_dataGridView0;
        public  StaticText ISAUpdateAvailableST;
        public  Link ISAUpdateAvailableLINK;

        partial void OnInitialize();

        public PandIDProjectSetupPandIDClassDefinitionDLG()
        {
            InitializeComponent();
            OnInitialize();
        }

        private void InitializeComponent()
        {

            ClassSettingsEngineeringItems = new ScrollBar()
            {
                Tag = "[ScrollBar]$m_dataGridView",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ClassSettingsEngineeringItems);

            M_btnAdd2TP = new PushButton()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$12783222|#1/[Pane]$m_splitVert|#1/[Pane]$4458802|#2/[Pane]$m_classPropertySettingsUserCtrl|#1/[GroupBox]Class settings: Centrifugal Blower|$m_groupBox|#1/[GroupBox]Symbol|$m_GroupBoxGraphical|#1/[PushButton]Add to Tool Palette *|$m_btnAdd2TP|#5",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_btnAdd2TP);

            M_btnAddAnn = new PushButton()
            {
                Tag = "[PushButton]$m_btnAddAnn",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_btnAddAnn);

            M_btnAddProperty = new PushButton()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$1313584|#1/[Pane]$m_splitVert|#1/[Pane]$1444510|#2/[Pane]$m_classPropertySettingsUserCtrl|#1/[GroupBox]Class settings: Engineering Items|$m_groupBox|#1/[GroupBox]Properties|$m_groupBoxProperties|#2/[PushButton]$m_btnAddProperty",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_btnAddProperty);

            M_btnAddStyle = new PushButton()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$1902372|#1/[Pane]$m_splitVert|#1/[Pane]$4458354|#2/[Pane]$m_classPropertySettingsUserCtrl|#1/[GroupBox]Class settings: Engineering Items|$m_groupBox|#1/[GroupBox]Symbol|$m_GroupBoxGraphical|#1/[PushButton]$m_btnAddStyle",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_btnAddStyle);

            M_btnCancel = new PushButton()
            {
                Tag = "[PushButton]$m_btnCancel",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_btnCancel);

            M_btnDeleteTag = new PushButton()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$14289030|#1/[Pane]$m_splitVert|#1/[Pane]$7144168|#2/[Pane]$m_classPropertySettingsUserCtrl|#1/[GroupBox]Class settings: Centrifugal Blower|$m_groupBox|#1/[GroupBox]Tag format|$m_groupBoxTag|#3/[PushButton]Delete|$m_btnDeleteTag|#3",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_btnDeleteTag);

            M_btnEditAnn = new PushButton()
            {
                Tag = "[PushButton]$m_btnEditAnn",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_btnEditAnn);

            M_btnEditProperties = new PushButton()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]#1/[Pane]$m_splitVert|#1/[Pane]#2/[Pane]$m_classPropertySettingsUserCtrl|#1/[GroupBox]$m_groupBox|#1/[GroupBox]$m_groupBoxProperties|#2/[PushButton]$m_btnEditProperties|#3",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_btnEditProperties);

            M_btnEditStyle = new PushButton()
            {
                Tag = "[PushButton]$m_btnEditStyle",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_btnEditStyle);

            M_btnHelp = new PushButton()
            {
                Tag = "[PushButton]$m_btnHelp",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_btnHelp);

            M_btnModifyAnn = new PushButton()
            {
                Tag = "[PushButton]$m_btnModifyAnn",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_btnModifyAnn);

            M_btnModifyStyle = new PushButton()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$1902372|#1/[Pane]$m_splitVert|#1/[Pane]$4458354|#2/[Pane]$m_classPropertySettingsUserCtrl|#1/[GroupBox]Class settings: Engineering Items|$m_groupBox|#1/[GroupBox]Symbol|$m_GroupBoxGraphical|#1/[PushButton]$m_btnModifyStyle",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_btnModifyStyle);

            M_btnModifyTag = new PushButton()
            {
                Tag = "[PushButton]$m_btnModifyTag",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_btnModifyTag);

            M_btnNewTag = new PushButton()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$20450718|#1/[Pane]$m_splitVert|#1/[Pane]$5375226|#2/[Pane]$m_classPropertySettingsUserCtrl|#1/[GroupBox]Class settings: Centrifugal Blower|$m_groupBox|#1/[GroupBox]Tag format|$m_groupBoxTag|#3/[PushButton]New*|$m_btnNewTag|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_btnNewTag);

            M_btnOk = new PushButton()
            {
                Tag = "[PushButton]$m_btnOk",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_btnOk);

            M_btnRemoveAnn = new PushButton()
            {
                Tag = "[PushButton]$m_btnRemoveAnn",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_btnRemoveAnn);

            M_btnRemoveProperties = new PushButton()
            {
                Tag = "[PushButton]$m_btnRemoveProperties",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_btnRemoveProperties);

            M_btnRemoveStyle = new PushButton()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$5375044|#1/[Pane]$m_splitVert|#1/[Pane]$65602554|#2/[Pane]$m_classPropertySettingsUserCtrl|#1/[GroupBox]Class settings: Centrifugal Blower|$m_groupBox|#1/[GroupBox]Symbol|$m_GroupBoxGraphical|#1/[PushButton]Remove Symbol*|$m_btnRemoveStyle|#3",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_btnRemoveStyle);

            M_btnSave = new PushButton()
            {
                Tag = "[PushButton]$m_btnSave",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_btnSave);

            M_comboBoxAnn = new ComboBox()
            {
                Tag = "[ComboBox]$m_comboBoxAnn",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_comboBoxAnn);

            M_comboBoxGraphical = new ComboBox()
            {
                Tag = "[ComboBox]$m_comboBoxGraphical",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_comboBoxGraphical);

            M_dataGridView = new Table()
            {
                Tag = "[Table]$m_dataGridView",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_dataGridView);

            M_groupBox = new GroupBox()
            {
                Tag = "[GroupBox]$m_groupBox",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_groupBox);

            M_groupBoxAnn = new GroupBox()
            {
                Tag = "[GroupBox]$m_groupBoxAnn",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_groupBoxAnn);

            M_GroupBoxGraphical = new GroupBox()
            {
                Tag = "[GroupBox]$m_GroupBoxGraphical",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_GroupBoxGraphical);

            M_groupBoxProperties = new GroupBox()
            {
                Tag = "[GroupBox]$m_groupBoxProperties",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_groupBoxProperties);

            M_groupBoxTag = new GroupBox()
            {
                Tag = "[GroupBox]$m_groupBoxTag",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_groupBoxTag);

            M_listBoxTag = new ListBox()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$14289030|#1/[Pane]$m_splitVert|#1/[Pane]$7144168|#2/[Pane]$m_classPropertySettingsUserCtrl|#1/[GroupBox]Class settings: Centrifugal Blower|$m_groupBox|#1/[GroupBox]Tag format|$m_groupBoxTag|#3/[ListBox]$m_listBoxTag|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_listBoxTag);

            M_PreviewStatic = new StaticText()
            {
                Tag = "[StaticText]$m_PreviewStatic",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_PreviewStatic);

            M_treeView = new TreeView()
            {
                Tag = "[Pane]$m_splitHorz/[Pane]#1/[Pane]$m_splitVert/[Pane]#1/[TreeView]$m_treeView",
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

            M_dataGridView0 = new ListViewItem()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]#1/[Pane]$m_splitVert|#1/[Pane]#2/[Pane]$m_classPropertySettingsUserCtrl|#1/[GroupBox]$m_groupBox|#1/[GroupBox]$m_groupBoxProperties|#2/[ListView]$m_dataGridView|#1/[CustomWin]#2/[ListViewItem]#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_dataGridView0);

            ISAUpdateAvailableST = new StaticText()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]#1/[Pane]$m_splitVert|#1/[Pane]#2/[Pane]$m_classPropertySettingsUserCtrl|#1/[GroupBox]$m_groupBox|#1/[StaticText]$m_linkLabelISAUpdate|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ISAUpdateAvailableST);

            ISAUpdateAvailableLINK = new Link()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]#1/[Pane]$m_splitVert|#1/[Pane]#2/[Pane]$m_classPropertySettingsUserCtrl|#1/[GroupBox]$m_groupBox|#1/[StaticText]$m_linkLabelISAUpdate|#1/[Link]#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ISAUpdateAvailableLINK);
        }
    }
}
