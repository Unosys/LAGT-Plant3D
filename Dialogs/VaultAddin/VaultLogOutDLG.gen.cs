// This file is auto-generated - do not hand edit this file.

using Autodesk.GUIHarness;
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{

    [UIElement(Tag = "[Pane]$LogoutDialog", Parent = typeof(Plant3D))]
    public partial class VaultLogOutDLG : Autodesk.GUIHarness.AutoCAD.AcDialogBox
    {
        public  Pane PanePANE;
        public  StaticText StaticTextST;
        public  StaticText AdministratorHasSuccessfullyLoggedST;
        public  Pane AdministratorHasSuccessfullyLoggedPANE;
        public  PushButton LogInPB;
        public  PushButton ClosePB;
        public  TitleBar LogOutCTL;
        public  CustomWin SystemMenuBarWIN;
        public  MenuItem SystemMI;
        public  PushButton Close2PB;

        partial void OnInitialize();

        public VaultLogOutDLG()
        {
            InitializeComponent();
            OnInitialize();
        }

        private void InitializeComponent()
        {

            PanePANE = new Pane()
            {
                Tag = "[Pane]$tableLayoutPanel1|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(PanePANE);

            StaticTextST = new StaticText()
            {
                Tag = "[Pane]$tableLayoutPanel1|#1/[StaticText]$m_image|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(StaticTextST);

            AdministratorHasSuccessfullyLoggedST = new StaticText()
            {
                Tag = "[Pane]$tableLayoutPanel1|#1/[StaticText]Administrator has successfully logged out of the Vault*|$m_informationLabel|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(AdministratorHasSuccessfullyLoggedST);

            AdministratorHasSuccessfullyLoggedPANE = new Pane()
            {
                Tag = "[Pane]$tableLayoutPanel1|#1/[Pane]Administrator has successfully logged out of the Vault*|$tableLayoutPanel2|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(AdministratorHasSuccessfullyLoggedPANE);

            LogInPB = new PushButton()
            {
                Tag = "[Pane]$tableLayoutPanel1|#1/[Pane]Administrator has successfully logged out of the Vault*|$tableLayoutPanel2|#1/[PushButton]Log In*|$okButton|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(LogInPB);

            ClosePB = new PushButton()
            {
                Tag = "[Pane]$tableLayoutPanel1|#1/[Pane]Administrator has successfully logged out of the Vault*|$tableLayoutPanel2|#1/[PushButton]Close|$cancelButton|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ClosePB);

            LogOutCTL = new TitleBar()
            {
                Tag = "[TitleBar]Log Out|$TitleBar|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(LogOutCTL);

            SystemMenuBarWIN = new CustomWin()
            {
                Tag = "[TitleBar]Log Out|$TitleBar|#1/[CustomWin]System Menu Bar|$LogoutDialog|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(SystemMenuBarWIN);

            SystemMI = new MenuItem()
            {
                Tag = "[TitleBar]Log Out|$TitleBar|#1/[CustomWin]System Menu Bar|$LogoutDialog|#1/[MenuItem]System|$Item 1|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(SystemMI);

            Close2PB = new PushButton()
            {
                Tag = "[TitleBar]Log Out|$TitleBar|#1/[PushButton]Close|$Close|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Close2PB);
        }
    }
}
