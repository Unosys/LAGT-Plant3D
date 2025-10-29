// This file is auto-generated - do not hand edit this file.

using Autodesk.GUIHarness;
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{

    [UIElement(Tag = "[Pane]$LoginDialog", Parent = typeof(MainWin), GUIType = GuiType.UIA)]
    public partial class LogInDLG : Pane
    {
        public  Pane Pane1PANE;
        public  Pane Pane2PANE;
        public  Pane Pane3PANE;
        public  Pane UserNamePANE;
        public  Pane PasswordPANE;
        public  Pane ServerPANE;
        public  Pane VaultPANE;
        public  Pane Pane4PANE;
        public  TextField UserNameTF;
        public  Pane Pane5PANE;
        public  TextField TextField2TF;
        public  Pane Pane6PANE;
        public  TextField TextField3TF;
        public  Pane Pane7PANE;
        public  Pane Pane8PANE;
        public  Pane Pane9PANE;
        public  Pane OKPANE;
        public  Pane CancelPANE;
        public  Pane Pane10PANE;
        public  Pane Pane11PANE;
        public  Pane Pane12PANE;
        public  TextField TextField4TF;
        public  Pane Pane13PANE;
        public  Pane Pane14PANE;
        public  Pane AuthenticationPANE;
        public  Pane Pane15PANE;
        public  Pane Pane16PANE;
        public  Pane StatusStrip1PANE;
        public  TitleBar LogInCTL;
        public  CustomWin SystemMenuBarWIN;
        public  MenuItem SystemMI;
        public  PushButton ClosePB;

        partial void OnInitialize();

        public LogInDLG()
        {
            InitializeComponent();
            OnInitialize();
        }

        private void InitializeComponent()
        {

            Pane1PANE = new Pane()
            {
                Tag = "[Pane]#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Pane1PANE);

            Pane2PANE = new Pane()
            {
                Tag = "[Pane]$tableLayoutPanel",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Pane2PANE);

            Pane3PANE = new Pane()
            {
                Tag = "[Pane]$tableLayoutPanel/[Pane]$autoLoginCheckbox|#11",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Pane3PANE);

            UserNamePANE = new Pane()
            {
                Tag = "[Pane]$tableLayoutPanel/[Pane]User Name:|$userNameLabel|#3",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(UserNamePANE);

            PasswordPANE = new Pane()
            {
                Tag = "[Pane]$tableLayoutPanel/[Pane]Password:|$passwordLabel|#5",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(PasswordPANE);

            ServerPANE = new Pane()
            {
                Tag = "[Pane]$tableLayoutPanel/[Pane]Server:|$serverLabel|#7",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ServerPANE);

            VaultPANE = new Pane()
            {
                Tag = "[Pane]$tableLayoutPanel/[Pane]Vault:|$databaseLabel|#9",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(VaultPANE);

            Pane4PANE = new Pane()
            {
                Tag = "[Pane]$tableLayoutPanel/[Pane]$userNameTextBox|#4",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Pane4PANE);

            UserNameTF = new TextField()
            {
                Tag = "[Pane]$tableLayoutPanel/[Pane]$userNameTextBox|#4/[TextField]#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(UserNameTF);

            Pane5PANE = new Pane()
            {
                Tag = "[Pane]$tableLayoutPanel/[Pane]$passwordTextBox|#6",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Pane5PANE);

            TextField2TF = new TextField()
            {
                Tag = "[Pane]$tableLayoutPanel/[Pane]$passwordTextBox|#6/[TextField]#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(TextField2TF);

            Pane6PANE = new Pane()
            {
                Tag = "[Pane]$tableLayoutPanel/[Pane]$serverComboBox|#8",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Pane6PANE);

            TextField3TF = new TextField()
            {
                Tag = "[Pane]$tableLayoutPanel/[Pane]$serverComboBox|#8/[TextField]#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(TextField3TF);

            Pane7PANE = new Pane()
            {
                Tag = "[Pane]$tableLayoutPanel/[Pane]$panel1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Pane7PANE);

            Pane8PANE = new Pane()
            {
                Tag = "[Pane]$tableLayoutPanel/[Pane]$panel1/[Pane]$tableLayoutPanel2|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Pane8PANE);

            Pane9PANE = new Pane()
            {
                Tag = "[Pane]$tableLayoutPanel/[Pane]$panel1/[Pane]$tableLayoutPanel2|#1/[Pane]$expandCollapseButton|#3",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Pane9PANE);

            OKPANE = new Pane()
            {
                Tag = "[Pane]$tableLayoutPanel/[Pane]$panel1/[Pane]$tableLayoutPanel2|#1/[Pane]$okButton|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(OKPANE);

            CancelPANE = new Pane()
            {
                Tag = "[Pane]$tableLayoutPanel/[Pane]$panel1/[Pane]$tableLayoutPanel2|#1/[Pane]Cancel|$cancelButton|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(CancelPANE);

            Pane10PANE = new Pane()
            {
                Tag = "[Pane]$tableLayoutPanel/[Pane]$databasePanel",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Pane10PANE);

            Pane11PANE = new Pane()
            {
                Tag = "[Pane]$tableLayoutPanel/[Pane]$databasePanel/[Pane]$tableLayoutPanel1|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Pane11PANE);

            Pane12PANE = new Pane()
            {
                Tag = "[Pane]$tableLayoutPanel/[Pane]$databasePanel/[Pane]$tableLayoutPanel1|#1/[Pane]$databaseCombobox|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Pane12PANE);

            TextField4TF = new TextField()
            {
                Tag = "[Pane]$tableLayoutPanel/[Pane]$databasePanel/[Pane]$tableLayoutPanel1|#1/[Pane]$databaseCombobox|#1/[TextField]$7079138|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(TextField4TF);

            Pane13PANE = new Pane()
            {
                Tag = "[Pane]$tableLayoutPanel/[Pane]$databasePanel/[Pane]$tableLayoutPanel1|#1/[Pane]**|$selectDatabaseButton|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Pane13PANE);

            Pane14PANE = new Pane()
            {
                Tag = "[Pane]$tableLayoutPanel/[Pane]$loginTypeComboBox|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Pane14PANE);

            AuthenticationPANE = new Pane()
            {
                Tag = "[Pane]$tableLayoutPanel/[Pane]Authentication:|$loginTypeLabel|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(AuthenticationPANE);

            Pane15PANE = new Pane()
            {
                Tag = "[Pane]$panel2|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Pane15PANE);

            Pane16PANE = new Pane()
            {
                Tag = "[Pane]$panel2|#2/[Pane]$pictureBox1|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Pane16PANE);

            StatusStrip1PANE = new Pane()
            {
                Tag = "[Pane]statusStrip1|$statusStrip1|#4",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(StatusStrip1PANE);

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
