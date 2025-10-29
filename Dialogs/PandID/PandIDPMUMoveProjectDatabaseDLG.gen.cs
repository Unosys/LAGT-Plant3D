// This file is auto-generated - do not hand edit this file.

using Autodesk.GUIHarness;
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{

    [UIElement(Tag = "[DialogBox]$ProjectMaintenanceDlg", Parent = typeof(Desktop))]
    public partial class PandIDPMUMoveProjectDatabaseDLG : Autodesk.GUIHarness.AutoCAD.AcDialogBox
    {
        public  ComboBox AuthenticationCombobox;
        public  GroupBox AuthGroup;
        public  PushButton CheckConnectionBtn;
        public  PushButton CloseBtn;
        public  GroupBox DBGroup;
        public  TextField DbPrefixTxt;
        public  CustomWin DetailsControl;
        public  PushButton DoBtn;
        public  PushButton GenerateNameBtn;
        public  StaticText InfoLable;
        public  StaticText Label1;
        public  StaticText Label2;
        public  StaticText Label3;
        public  StaticText Label4;
        public  StaticText Label6;
        public  GroupBox LogGroup;
        public  ListBox LogList;
        public  PushButton MoveBrowseBtn;
        public  GroupBox MoveGroup;
        public  TextField MovePjtPathTB;
        public  TextField PasswordTxtBox;
        public  ComboBox ServerListCombbox;
        public  ComboBox ServerListCombboxTextField;
        public  TextField UserNameTxtbox;

        partial void OnInitialize();

        public PandIDPMUMoveProjectDatabaseDLG()
        {
            InitializeComponent();
            OnInitialize();
        }

        private void InitializeComponent()
        {

            AuthenticationCombobox = new ComboBox()
            {
                Tag = "[ComboBox]$AuthenticationCombobox",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(AuthenticationCombobox);

            AuthGroup = new GroupBox()
            {
                Tag = "[GroupBox]$AuthGroup",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(AuthGroup);

            CheckConnectionBtn = new PushButton()
            {
                Tag = "[PushButton]$CheckConnectionBtn",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(CheckConnectionBtn);

            CloseBtn = new PushButton()
            {
                Tag = "[PushButton]$CloseBtn",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(CloseBtn);

            DBGroup = new GroupBox()
            {
                Tag = "[GroupBox]$DBGroup",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(DBGroup);

            DbPrefixTxt = new TextField()
            {
                Tag = "[Pane]$DetailsControl|#1/[GroupBox]Database|$DBGroup|#2/[TextField]Database prefix name: |$DbPrefixTxt|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(DbPrefixTxt);

            DetailsControl = new CustomWin()
            {
                Tag = "[CustomWin]$DetailsControl",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(DetailsControl);

            DoBtn = new PushButton()
            {
                Tag = "[Pane]$DetailsControl|#1/[PushButton]Move|$DoBtn|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(DoBtn);

            GenerateNameBtn = new PushButton()
            {
                Tag = "[PushButton]$GenerateNameBtn",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(GenerateNameBtn);

            InfoLable = new StaticText()
            {
                Tag = "[StaticText]$infoLable",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(InfoLable);

            Label1 = new StaticText()
            {
                Tag = "[StaticText]$label1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Label1);

            Label2 = new StaticText()
            {
                Tag = "[StaticText]$label2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Label2);

            Label3 = new StaticText()
            {
                Tag = "[StaticText]$label3",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Label3);

            Label4 = new StaticText()
            {
                Tag = "[StaticText]$label4",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Label4);

            Label6 = new StaticText()
            {
                Tag = "[StaticText]$label6",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Label6);

            LogGroup = new GroupBox()
            {
                Tag = "[GroupBox]$LogGroup",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(LogGroup);

            LogList = new ListBox()
            {
                Tag = "[ListBox]$LogList",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(LogList);

            MoveBrowseBtn = new PushButton()
            {
                Tag = "[Pane]$DetailsControl|#1/[GroupBox]Move details|$MoveGroup|#1/[PushButton]Browse*|$MoveBrowseBtn|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(MoveBrowseBtn);

            MoveGroup = new GroupBox()
            {
                Tag = "[GroupBox]$MoveGroup",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(MoveGroup);

            MovePjtPathTB = new TextField()
            {
                Tag = "[TextField]$MovePjtPathTB",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(MovePjtPathTB);

            PasswordTxtBox = new TextField()
            {
                Tag = "[TextField]$PasswordTxtBox",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(PasswordTxtBox);

            ServerListCombbox = new ComboBox()
            {
                Tag = "[ComboBox]$ServerListCombbox",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ServerListCombbox);

            ServerListCombboxTextField = new ComboBox()
            {
                Tag = "[Pane]$DetailsControl|#1/[GroupBox]Database|$DBGroup|#2/[ComboBox]SQL Server name:|$ServerListCombbox|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ServerListCombboxTextField);

            UserNameTxtbox = new TextField()
            {
                Tag = "[TextField]$UserNameTxtbox",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(UserNameTxtbox);
        }
    }
}
