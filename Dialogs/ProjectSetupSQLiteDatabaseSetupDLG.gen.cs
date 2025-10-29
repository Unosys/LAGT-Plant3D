// This file is auto-generated - do not hand edit this file.

using Autodesk.GUIHarness;
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{

    [UIElement(Tag = "[DialogBox]$EditProjectSettingsDlg", Parent = typeof(Plant3D))]
    public partial class ProjectSetupSQLiteDatabaseSetupDLG : Autodesk.GUIHarness.AutoCAD.AcDialogBox
    {
        public  TreeView M_treeView;
        public  StaticText DatabaseSetup;
        public  StaticText TheDatabaseSelectionForAP1;
        public  RadioButton TheDatabaseSelectionForAP2;
        public  StaticText ServerNameText;
        public  TextField ServerName;
        public  StaticText DatabaseNameText;
        public  TextField DatabaseName;
        public  StaticText AuthenticationText;
        public  TextField Authentication;
        public  StaticText AlreadyHaveAProjectThatYo;
        public  PushButton Help;
        public  PushButton CancelPB;
        public  PushButton OK;
        public  PushButton Apply;

        partial void OnInitialize();

        public ProjectSetupSQLiteDatabaseSetupDLG()
        {
            InitializeComponent();
            OnInitialize();
        }

        private void InitializeComponent()
        {

            M_treeView = new TreeView()
            {
                Tag = "[TreeView]#1|$m_treeView",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_treeView);

            DatabaseSetup = new StaticText()
            {
                Tag = "[StaticText]Database Setup|#1|$m_groupbox",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(DatabaseSetup);

            TheDatabaseSelectionForAP1 = new StaticText()
            {
                Tag = "[StaticText]The database selection for a project is specified in the Project Setup Wizard at the time of project creation. Settings displa*|#1|$m_label_notes",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(TheDatabaseSelectionForAP1);

            TheDatabaseSelectionForAP2 = new RadioButton()
            {
                Tag = "[RadioButton]The database selection for a project is specified in the Project Setup Wizard at the time of project creation. Settings displa*|#1|$m_radioButton_sqlite",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(TheDatabaseSelectionForAP2);

            ServerNameText = new StaticText()
            {
                Tag = "[StaticText]Server name:|#2|$m_label_servername",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ServerNameText);

            ServerName = new TextField()
            {
                Tag = "[TextField]Server name:|#1|$m_textBox_serverName",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ServerName);

            DatabaseNameText = new StaticText()
            {
                Tag = "[StaticText]Database name:|#3|$m_label_databaseName",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(DatabaseNameText);

            DatabaseName = new TextField()
            {
                Tag = "[TextField]Database name:|#2|$m_textBox_DatabasePrefix",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(DatabaseName);

            AuthenticationText = new StaticText()
            {
                Tag = "[StaticText]Authentication:|#4|$m_label_Authentication",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(AuthenticationText);

            Authentication = new TextField()
            {
                Tag = "[TextField]Authentication:|#3|$m_textBox_Authentication",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Authentication);

            AlreadyHaveAProjectThatYo = new StaticText()
            {
                Tag = "[StaticText]Already have a project that you'd like to convert from a local database to a server database?|#5|$m_label_Already",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(AlreadyHaveAProjectThatYo);

            Help = new PushButton()
            {
                Tag = "[PushButton]Help|#4|$m_btnHelp",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Help);

            CancelPB = new PushButton()
            {
                Tag = "[PushButton]Cancel|#3|$m_btnCancel",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(CancelPB);

            OK = new PushButton()
            {
                Tag = "[PushButton]OK|#2|$m_btnOk",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(OK);

            Apply = new PushButton()
            {
                Tag = "[PushButton]Apply|#1|$m_btnSave",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Apply);
        }
    }
}
