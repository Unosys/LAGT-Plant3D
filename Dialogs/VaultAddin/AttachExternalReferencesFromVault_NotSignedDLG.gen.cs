// This file is auto-generated - do not hand edit this file.

using Autodesk.GUIHarness;
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{

    [UIElement(Tag = "[DialogBox]Attach External References from Vault", Parent = typeof(MainWin), GUIType = GuiType.WIN32)]
    public partial class AttachExternalReferencesFromVault_NotSignedDLG : Autodesk.GUIHarness.AutoCAD.AcDialogBox
    {
        public  PushButton OK;
        public  StaticText NotSignedInVaultST;

        partial void OnInitialize();

        public AttachExternalReferencesFromVault_NotSignedDLG()
        {
            InitializeComponent();
            OnInitialize();
        }

        private void InitializeComponent()
        {

            OK = new PushButton()
            {
                Tag = "[PushButton]OK|$2|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(OK);

            NotSignedInVaultST = new StaticText()
            {
                Tag = "[StaticText]Not signed in vault document service*|$65535|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(NotSignedInVaultST);
        }
    }
}
