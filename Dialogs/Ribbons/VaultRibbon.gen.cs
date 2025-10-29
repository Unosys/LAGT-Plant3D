// This file is auto-generated - do not hand edit this file.

using Autodesk.GUIHarness;
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{

    [UIElement(Tag = "[CustomWin]Ribbon|$59419/[CustomWin]Ribbon|$16719/[CustomWin]Ribbon|$7/[Pane]#1", Parent = typeof(Plant3D), GUIType = GuiType.UIA)]
    public partial class VaultRibbon : RibbonDialogClassP3D
    {
        public  AdminPanelClass AdminPanel;
        public  FilePanelClass FilePanel;

        partial void OnInitialize();

        public VaultRibbon()
        {
            InitializeComponent();
            OnInitialize();
        }

        private void InitializeComponent()
        {

            AdminPanel = new AdminPanelClass()
            {
                Tag = "[CustomWin]$PNP.ID_TabPnPVault_PanelBarScrollViewer/[CustomWin]Admin|$ID_PanelPnPVaultAdmin",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(AdminPanel);

            FilePanel = new FilePanelClass()
            {
                Tag = "[CustomWin]$PNP.ID_TabPnPVault_PanelBarScrollViewer/[CustomWin]File|$ID_PanelPnPVaultFile",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(FilePanel);
        }

        public partial class AdminPanelClass : CustomWin
        {
            public PushButton AutodeskVaultPB;

            partial void OnInitialize();

            public AdminPanelClass()
            {
                InitializeComponent();
                OnInitialize();
            }

            private void InitializeComponent()
            {
                Tag = "[CustomWin]$PNP.ID_TabPnPVault_PanelBarScrollViewer/[CustomWin]Admin|$ID_PanelPnPVaultAdmin";
                ParentType = this.GetType();

                AutodeskVaultPB = new PushButton()
                {
                    Tag = "[CustomWin]$ID_PP_Open_Vault_Explorer_RibbonItemControl/[PushButton]$ID_PP_Open_Vault_Explorer",
                    ParentType = this.GetType(),
                    Parent = this
                };
                DeclaredChildren.Add(AutodeskVaultPB);
            }
        }

        public partial class FilePanelClass : CustomWin
        {
            public PushButton CheckOutPB;

            partial void OnInitialize();

            public FilePanelClass()
            {
                InitializeComponent();
                OnInitialize();
            }

            private void InitializeComponent()
            {
                Tag = "[CustomWin]$PNP.ID_TabPnPVault_PanelBarScrollViewer/[CustomWin]File|$ID_PanelPnPVaultFile";
                ParentType = this.GetType();

                CheckOutPB = new PushButton()
                {
                    Tag = "[CustomWin]$ID_PP_Vault_Check_Out_RibbonItemControl/[PushButton]$ID_PP_Vault_Check_Out",
                    ParentType = this.GetType(),
                    Parent = this
                };
                DeclaredChildren.Add(CheckOutPB);
            }
        }
    }
}
