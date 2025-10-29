// This file is auto-generated - do not hand edit this file.

using Autodesk.GUIHarness;
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{

    [UIElement(Tag = "[DialogBox]Autodesk Vault Stand Alone Client", Parent = typeof(MainWin))]
    public partial class AutodeskVaultStandAloneDLG : Autodesk.GUIHarness.AutoCAD.AcDialogBox
    {
        public  PushButton LaunchAutodeskVaultPB;
        public  PushButton DoNotLaunchAutodeskPB;

        partial void OnInitialize();

        public AutodeskVaultStandAloneDLG()
        {
            InitializeComponent();
            OnInitialize();
        }

        private void InitializeComponent()
        {

            LaunchAutodeskVaultPB = new PushButton()
            {
                Tag = "[Pane]$Window|#1/[PushButton]Launch Autodesk Vault|$CommandLink_1001|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(LaunchAutodeskVaultPB);

            DoNotLaunchAutodeskPB = new PushButton()
            {
                Tag = "[Pane]$Window|#1/[PushButton]Do Not Launch Autodesk Vault|$CommandLink_2|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(DoNotLaunchAutodeskPB);
        }
    }
}
