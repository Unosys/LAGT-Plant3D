// This file is auto-generated - do not hand edit this file.

using Autodesk.GUIHarness;
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{

    [UIElement(Tag = "[DialogBox]$EditProjectSettingsDlg", Parent = typeof(Plant3D))]
    public partial class PandIDProjectSetupSQLAuthDatabaseSetupDLG : Autodesk.GUIHarness.AutoCAD.AcDialogBox
    {
        public  PushButton M_btnCancel;
        public  PushButton M_btnHelp;
        public  PushButton M_btnOk;
        public  PushButton M_btnSave;
        public  CustomWin M_databaseSetupUserControl;
        public  GroupBox M_groupbox;
        public  StaticText M_label_Already;
        public  StaticText M_label_Authentication;
        public  StaticText M_label_databaseName;
        public  StaticText M_label_notes;
        public  StaticText M_label_servername;
        public  Link M_linkLabel_learnMore;
        public  RadioButton M_radioButton_sqlExpress;
        public  RadioButton M_radioButton_sqlite;
        public  CustomWin M_splitHorz;
        public  CustomWin M_splitVert;
        public  TextField M_textBox_Authentication;
        public  TextField M_textBox_DatabasePrefix;
        public  TextField M_textBox_serverName;
        public  TreeView M_treeView;
        public  GroupBox SystemWindowsFormsSplitterPanel;
        public  GroupBox SystemWindowsFormsSplitterPanel2;
        public  GroupBox SystemWindowsFormsSplitterPanel3;
        public  GroupBox SystemWindowsFormsSplitterPanel4;

        partial void OnInitialize();

        public PandIDProjectSetupSQLAuthDatabaseSetupDLG()
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

            M_btnHelp = new PushButton()
            {
                Tag = "[PushButton]$m_btnHelp",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_btnHelp);

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

            M_databaseSetupUserControl = new CustomWin()
            {
                Tag = "[CustomWin]$m_databaseSetupUserControl",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_databaseSetupUserControl);

            M_groupbox = new GroupBox()
            {
                Tag = "[GroupBox]$m_groupbox",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_groupbox);

            M_label_Already = new StaticText()
            {
                Tag = "[StaticText]$m_label_Already",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_label_Already);

            M_label_Authentication = new StaticText()
            {
                Tag = "[StaticText]$m_label_Authentication",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_label_Authentication);

            M_label_databaseName = new StaticText()
            {
                Tag = "[StaticText]$m_label_databaseName",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_label_databaseName);

            M_label_notes = new StaticText()
            {
                Tag = "[StaticText]$m_label_notes",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_label_notes);

            M_label_servername = new StaticText()
            {
                Tag = "[StaticText]$m_label_servername",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_label_servername);

            M_linkLabel_learnMore = new Link()
            {
                Tag = "[Link]$m_linkLabel_learnMore",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_linkLabel_learnMore);

            M_radioButton_sqlExpress = new RadioButton()
            {
                Tag = "[RadioButton]$m_radioButton_sqlExpress",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_radioButton_sqlExpress);

            M_radioButton_sqlite = new RadioButton()
            {
                Tag = "[RadioButton]$m_radioButton_sqlite",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_radioButton_sqlite);

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

            M_textBox_Authentication = new TextField()
            {
                Tag = "[TextField]$m_textBox_Authentication",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_textBox_Authentication);

            M_textBox_DatabasePrefix = new TextField()
            {
                Tag = "[TextField]$m_textBox_DatabasePrefix",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_textBox_DatabasePrefix);

            M_textBox_serverName = new TextField()
            {
                Tag = "[TextField]$m_textBox_serverName",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_textBox_serverName);

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
