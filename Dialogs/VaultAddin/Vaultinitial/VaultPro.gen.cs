// This file is auto-generated - do not hand edit this file.

using Autodesk.GUIHarness;
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{

    [UIElement(Tag = "[MainWin]Autodesk Vault Professional*|$ExplorerForm", Parent = typeof(Desktop), GUIType = GuiType.UIA)]
    public partial class VaultPro : Plant3DMainWin
    {
        public  Pane PropertiesPANE;
        public  Pane SharedViewsPANE;
        public  TreeView TreeViewTV;
        public  PushButton AboutAutodeskVaultProfessionalPB;

        partial void OnInitialize();

        public VaultPro()
        {
            InitializeComponent();
            OnInitialize();
        }

        private void InitializeComponent()
        {

            PropertiesPANE = new Pane()
            {
                Tag = "[Pane]Properties",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(PropertiesPANE);

            SharedViewsPANE = new Pane()
            {
                Tag = "[Pane]Shared Views",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(SharedViewsPANE);

            TreeViewTV = new TreeView()
            {
                Tag = "[Pane]$m_MainContainer/[Pane]#1/[Pane]$m_navBarControl/[Pane]$m_navBar/[Pane]#1/[Pane]#1/[Pane]#1/[Pane]#1/[Pane]#1/[TreeView]#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(TreeViewTV);

            AboutAutodeskVaultProfessionalPB = new PushButton()
            {
                Tag = "[GroupBox]#1/[ToolBar]#1/[PushButton]About Autodesk Vault Professional",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(AboutAutodeskVaultProfessionalPB);
        }
    }
}
