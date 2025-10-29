// This file is auto-generated - do not hand edit this file.

using Autodesk.GUIHarness;
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{

    [UIElement(Tag = "[MainWin]$ProjectMaintenanceDlg", Parent = typeof(Desktop))]
    public partial class PandIDPMUConvertProjectToSQLExpressDLG : Autodesk.GUIHarness.AutoCAD.AcDialogBox
    {
        public  PopupList AuthenticationCombobox;
        public  GroupBox AuthGroup;
        public  PushButton CheckConnectionBtn;
        public  PushButton CloseBtn;
        public  PushButton ConvertBrowseBtn;
        public  GroupBox ConvertGroup;
        public  TextField ConvertPjtPathTB;
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
        public  StaticText Label5;
        public  GroupBox LogGroup;
        public  ListBox LogList;
        public  TextField PasswordTxtBox;
        public  ComboBox ServerListCombbox;
        public  ComboBox ServerListCombboxTextField;
        public  TextField UserNameTxtbox;

        partial void OnInitialize();

        public PandIDPMUConvertProjectToSQLExpressDLG()
        {
            InitializeComponent();
            OnInitialize();
        }

        private void InitializeComponent()
        {

            AuthenticationCombobox = new PopupList()
            {
                Tag = "[Pane]$DetailsControl|#1/[GroupBox]Authentication details|$AuthGroup|#3/[PopupList]$AuthenticationCombobox|#1",
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
                Tag = "[Pane]$DetailsControl|#1/[GroupBox]Database|$DBGroup|#2/[PushButton]Test Connection |$CheckConnectionBtn|#1",
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

            ConvertBrowseBtn = new PushButton()
            {
                Tag = "[Pane]$DetailsControl|#1/[GroupBox]Convert details|$ConvertGroup|#1/[PushButton]Browse*|$ConvertBrowseBtn|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ConvertBrowseBtn);

            ConvertGroup = new GroupBox()
            {
                Tag = "[GroupBox]$ConvertGroup",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ConvertGroup);

            ConvertPjtPathTB = new TextField()
            {
                Tag = "[TextField]$ConvertPjtPathTB",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ConvertPjtPathTB);

            DBGroup = new GroupBox()
            {
                Tag = "[GroupBox]$DBGroup",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(DBGroup);

            DbPrefixTxt = new TextField()
            {
                Tag = "[Pane]$DetailsControl|#1/[GroupBox]Database|$DBGroup|#2/[TextField]$DbPrefixTxt",
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
                Tag = "[Pane]$DetailsControl|#1/[PushButton]Convert|$DoBtn|#1",
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

            Label5 = new StaticText()
            {
                Tag = "[StaticText]$label5",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Label5);

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

            PasswordTxtBox = new TextField()
            {
                Tag = "[Pane]$DetailsControl|#1/[GroupBox]Authentication details|$AuthGroup|#3/[TextField]$PasswordTxtBox",
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
                Tag = "[Pane]$DetailsControl|#1/[GroupBox]Authentication details|$AuthGroup|#3/[TextField]User name:|$UserNameTxtbox|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(UserNameTxtbox);
        }
    }
}
