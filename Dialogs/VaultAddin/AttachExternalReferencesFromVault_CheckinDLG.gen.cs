// This file is auto-generated - do not hand edit this file.

using Autodesk.GUIHarness;
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{

    [UIElement(Tag = "[Pane]Attach External References|$frmVaultAttachReferences", Parent = typeof(MainWin), GUIType = GuiType.UIA)]
    public partial class AttachExternalReferencesFromVault_CheckinDLG : Autodesk.GUIHarness.AutoCAD.AcDialogBox
    {
        public  PushButton OK;
        public  StaticText FileIsNotCheckedST;

        partial void OnInitialize();

        public AttachExternalReferencesFromVault_CheckinDLG()
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

            FileIsNotCheckedST = new StaticText()
            {
                Tag = "[StaticText]File is not checked out*|$65535|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(FileIsNotCheckedST);
        }
    }
}
