// This file is auto-generated - do not hand edit this file.

using Autodesk.GUIHarness;
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{

    [UIElement(Tag = "[Pane]Log In|$LoginDialog")]
    public partial class VaultLogInDLG : Pane
    {
        public  Pane Pane1PANE;
        public  CheckBox AutomaticallyLogInNextCK;
        public  StaticText UserNameST;
        public  StaticText PasswordST;
        public  StaticText ServerST;
        public  StaticText VaultST;
        public  TextField UserNameTextBox;
        public  TextField TextField1TF;
        public  TextField TextField2TF;
        public  TextField PasswordTF;
        public  TextField TextField3TF;
        public  TextField TextField4TF;
        public  ComboBox ServerCB;
        public  Pane Pane2PANE;
        public  Pane Pane3PANE;
        public  PushButton PushButton1PB;
        public  PushButton OK;
        public  PushButton CancelPB;
        public  Pane Pane4PANE;
        public  Pane Pane5PANE;
        public  ComboBox ComboBoxCB;
        public  PushButton PushButton2PB;
        public  PopupList AuthenticationPL;
        public  StaticText VaultAccountST;
        public  PushButton OpenPB;
        public  StaticText AuthenticationST;
        public  Pane Pane6PANE;
        public  Pane Pane7PANE;
        public  StatusBar StatusStrip1SB;
        public  TitleBar LogInCTL;
        public  CustomWin SystemMenuBarWIN;
        public  MenuItem SystemMI;
        public  PushButton ClosePB;

        partial void OnInitialize();

        public VaultLogInDLG()
        {
            InitializeComponent();
            OnInitialize();
        }

        private void InitializeComponent()
        {

            Pane1PANE = new Pane()
            {
                Tag = "[Pane]$tableLayoutPanel|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Pane1PANE);

            AutomaticallyLogInNextCK = new CheckBox()
            {
                Tag = "[Pane]$tableLayoutPanel|#2/[CheckBox]Automatically log in next session|$autoLoginCheckbox|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(AutomaticallyLogInNextCK);

            UserNameST = new StaticText()
            {
                Tag = "[Pane]$tableLayoutPanel|#2/[StaticText]User Name:|$userNameLabel|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(UserNameST);

            PasswordST = new StaticText()
            {
                Tag = "[Pane]$tableLayoutPanel|#2/[StaticText]Password:|$passwordLabel|#3",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(PasswordST);

            ServerST = new StaticText()
            {
                Tag = "[Pane]$tableLayoutPanel|#2/[StaticText]Server:|$serverLabel|#4",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ServerST);

            VaultST = new StaticText()
            {
                Tag = "[Pane]$tableLayoutPanel|#2/[StaticText]Vault:|$databaseLabel|#5",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(VaultST);

            UserNameTextBox = new TextField()
            {
                Tag = "[Pane]$tableLayoutPanel|#2/[TextField]User Name:|$userNameTextBox|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(UserNameTextBox);

            TextField1TF = new TextField()
            {
                Tag = "[Pane]$tableLayoutPanel|#2/[TextField]User Name:|$userNameTextBox|#1/[TextField]$15338124|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(TextField1TF);

            TextField2TF = new TextField()
            {
                Tag = "[Pane]$tableLayoutPanel|#2/[TextField]User Name:|$userNameTextBox|#1/[TextField]#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(TextField2TF);

            PasswordTF = new TextField()
            {
                Tag = "[Pane]$tableLayoutPanel|#2/[TextField]Password:|$passwordTextBox|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(PasswordTF);

            TextField3TF = new TextField()
            {
                Tag = "[Pane]$tableLayoutPanel|#2/[TextField]Password:|$passwordTextBox|#2/[TextField]$30868590|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(TextField3TF);

            TextField4TF = new TextField()
            {
                Tag = "[Pane]$tableLayoutPanel|#2/[TextField]Password:|$passwordTextBox|#2/[TextField]#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(TextField4TF);

            ServerCB = new ComboBox()
            {
                Tag = "[Pane]$tableLayoutPanel|#2/[ComboBox]Server:|$serverComboBox|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ServerCB);

            Pane2PANE = new Pane()
            {
                Tag = "[Pane]$tableLayoutPanel|#2/[Pane]$panel1|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Pane2PANE);

            Pane3PANE = new Pane()
            {
                Tag = "[Pane]$tableLayoutPanel|#2/[Pane]$panel1|#2/[Pane]$tableLayoutPanel2|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Pane3PANE);

            PushButton1PB = new PushButton()
            {
                Tag = "[Pane]$tableLayoutPanel|#2/[Pane]$panel1|#2/[Pane]$tableLayoutPanel2|#1/[PushButton]<<|$expandCollapseButton|#3",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(PushButton1PB);

            OK = new PushButton()
            {
                Tag = "[Pane]$tableLayoutPanel|#2/[Pane]$panel1|#2/[Pane]$tableLayoutPanel2|#1/[PushButton]OK|$okButton|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(OK);

            CancelPB = new PushButton()
            {
                Tag = "[Pane]$tableLayoutPanel|#2/[Pane]$panel1|#2/[Pane]$tableLayoutPanel2|#1/[PushButton]Cancel|$cancelButton|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(CancelPB);

            Pane4PANE = new Pane()
            {
                Tag = "[Pane]$tableLayoutPanel|#2/[Pane]$databasePanel|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Pane4PANE);

            Pane5PANE = new Pane()
            {
                Tag = "[Pane]$tableLayoutPanel|#2/[Pane]$databasePanel|#1/[Pane]$tableLayoutPanel1|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Pane5PANE);

            ComboBoxCB = new ComboBox()
            {
                Tag = "[Pane]$tableLayoutPanel|#2/[Pane]$databasePanel|#1/[Pane]$tableLayoutPanel1|#1/[ComboBox]$databaseCombobox|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ComboBoxCB);

            PushButton2PB = new PushButton()
            {
                Tag = "[Pane]$tableLayoutPanel|#2/[Pane]$databasePanel|#1/[Pane]$tableLayoutPanel1|#1/[PushButton]**|$selectDatabaseButton|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(PushButton2PB);

            AuthenticationPL = new PopupList()
            {
                Tag = "[Pane]$tableLayoutPanel|#2/[PopupList]Authentication:|$loginTypeComboBox|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(AuthenticationPL);

            VaultAccountST = new StaticText()
            {
                Tag = "[Pane]$tableLayoutPanel|#2/[PopupList]Authentication:|$loginTypeComboBox|#1/[StaticText]Vault Account|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(VaultAccountST);

            OpenPB = new PushButton()
            {
                Tag = "[Pane]$tableLayoutPanel|#2/[PopupList]Authentication:|$loginTypeComboBox|#1/[PushButton]Open|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(OpenPB);

            AuthenticationST = new StaticText()
            {
                Tag = "[Pane]$tableLayoutPanel|#2/[StaticText]Authentication:|$loginTypeLabel|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(AuthenticationST);

            Pane6PANE = new Pane()
            {
                Tag = "[Pane]$panel2|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Pane6PANE);

            Pane7PANE = new Pane()
            {
                Tag = "[Pane]$panel2|#1/[Pane]$pictureBox1|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Pane7PANE);

            StatusStrip1SB = new StatusBar()
            {
                Tag = "[StatusBar]statusStrip1|$statusStrip1|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(StatusStrip1SB);

            LogInCTL = new TitleBar()
            {
                Tag = "[TitleBar]Log In|$TitleBar|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(LogInCTL);

            SystemMenuBarWIN = new CustomWin()
            {
                Tag = "[TitleBar]Log In|$TitleBar|#1/[CustomWin]System Menu Bar|$LoginDialog|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(SystemMenuBarWIN);

            SystemMI = new MenuItem()
            {
                Tag = "[TitleBar]Log In|$TitleBar|#1/[CustomWin]System Menu Bar|$LoginDialog|#1/[MenuItem]System|$Item 1|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(SystemMI);

            ClosePB = new PushButton()
            {
                Tag = "[TitleBar]Log In|$TitleBar|#1/[PushButton]Close|$Close|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ClosePB);
        }
    }
}
