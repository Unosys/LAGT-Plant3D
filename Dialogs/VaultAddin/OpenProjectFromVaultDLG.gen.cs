// This file is auto-generated - do not hand edit this file.

using Autodesk.GUIHarness;
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{

    [UIElement(Tag = "[Pane]Open Project From Vault|$frmOpenFromVault", Parent = typeof(MainWin), GUIType = GuiType.UIA)]
    public partial class OpenProjectFromVaultDLG : Autodesk.GUIHarness.AutoCAD.AcDialogBox
    {
        public  PushButton ChangePB;
        public  PushButton OpenPB;
        public  ListView VaultLocationLV;
        public  ListBoxItem TestVaultLBI;
        public  PushButton Cancel;
        public  TitleBar OpenProjectFromVaultCTL;
        public  PushButton ClosePB;

        partial void OnInitialize();

        public OpenProjectFromVaultDLG()
        {
            InitializeComponent();
            OnInitialize();
        }

        private void InitializeComponent()
        {

            ChangePB = new PushButton()
            {
                Tag = "[PushButton]Change*|$m_btnChange|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ChangePB);

            OpenPB = new PushButton()
            {
                Tag = "[PushButton]Open|$m_btnOpen|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(OpenPB);

            VaultLocationLV = new ListView()
            {
                Tag = "[ListView]$m_listViewProjects|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(VaultLocationLV);

            TestVaultLBI = new ListBoxItem()
            {
                Tag = "[ListBox]$m_listViewProjects|#1/[ListBoxItem]$ListViewItem-0|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(TestVaultLBI);

            Cancel = new PushButton()
            {
                Tag = "[PushButton]Cancel|$m_btnCancel|#3",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Cancel);

            OpenProjectFromVaultCTL = new TitleBar()
            {
                Tag = "[TitleBar]Open Project From Vault|$TitleBar|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(OpenProjectFromVaultCTL);

            ClosePB = new PushButton()
            {
                Tag = "[TitleBar]Open Project From Vault|$TitleBar|#1/[PushButton]Close|$Close|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ClosePB);
        }
    }
}
