// This file is auto-generated - do not hand edit this file.

using Autodesk.GUIHarness;
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{

    [UIElement(Tag = "[Pane]Log In|$LoginDialog", Parent = typeof(VaultPro), GUIType = GuiType.UIA)]
    public partial class VC_LogInDLG : Pane
    {
        public  PopupList LoginTypePL;
        public  TextField UserNameTF;
        public  TextField PasswordTF;
        public  ComboBox ServerCB;
        public  PushButton OKPB;
        public  PushButton CancelPB;
        public  PushButton DatabasePB;
        public  ComboBox DatabaseCB;

        partial void OnInitialize();

        public VC_LogInDLG()
        {
            InitializeComponent();
            OnInitialize();
        }

        private void InitializeComponent()
        {

            LoginTypePL = new PopupList()
            {
                Tag = "[Pane]$tableLayoutPanel/[PopupList]$loginTypeComboBox",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(LoginTypePL);

            UserNameTF = new TextField()
            {
                Tag = "[Pane]$tableLayoutPanel/[TextField]$userNameTextBox",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(UserNameTF);

            PasswordTF = new TextField()
            {
                Tag = "[Pane]$tableLayoutPanel/[TextField]$passwordTextBox",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(PasswordTF);

            ServerCB = new ComboBox()
            {
                Tag = "[Pane]$tableLayoutPanel/[ComboBox]$serverComboBox",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ServerCB);

            OKPB = new PushButton()
            {
                Tag = "[Pane]$tableLayoutPanel/[Pane]$panel1/[Pane]$tableLayoutPanel2/[PushButton]$okButton",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(OKPB);

            CancelPB = new PushButton()
            {
                Tag = "[Pane]$tableLayoutPanel/[Pane]$panel1/[Pane]$tableLayoutPanel2/[PushButton]$cancelButton",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(CancelPB);

            DatabasePB = new PushButton()
            {
                Tag = "[Pane]$tableLayoutPanel/[Pane]$databasePanel/[Pane]$tableLayoutPanel1/[PushButton]$selectDatabaseButton",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(DatabasePB);

            DatabaseCB = new ComboBox()
            {
                Tag = "[Pane]$tableLayoutPanel/[Pane]$databasePanel/[Pane]$tableLayoutPanel1/[ComboBox]$databaseCombobox",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(DatabaseCB);
        }
    }
}
