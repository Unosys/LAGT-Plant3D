// This file is auto-generated - do not hand edit this file.

using Autodesk.GUIHarness;
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{

    [UIElement(Tag = "[Pane]|$frmDrawingMigration1|#1", Parent = typeof(ProjManUndocked), GUIType = GuiType.UIA)]
    public partial class AutoCADPIDMigrationDLG : Pane
    {
        public  CheckBox ChkboxBackup;
        public  PushButton BtnCancel;

        partial void OnInitialize();

        public AutoCADPIDMigrationDLG()
        {
            InitializeComponent();
            OnInitialize();
        }

        private void InitializeComponent()
        {

            ChkboxBackup = new CheckBox()
            {
                Tag = "[CheckBox]$chkboxBackup",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ChkboxBackup);

            BtnCancel = new PushButton()
            {
                Tag = "[PushButton]$btnCancel",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(BtnCancel);
        }
    }
}
