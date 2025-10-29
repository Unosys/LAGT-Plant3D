// This file is auto-generated - do not hand edit this file.

using Autodesk.GUIHarness;
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{

    [UIElement(Tag = "[DialogBox]Privacy Settings|#1", Parent = typeof(VaultPro))]
    public partial class VC_PrivacySettingsDLG : ProductTestSuite.CommonFiles.AdDialogBox
    {
        public  PushButton OKPB;

        partial void OnInitialize();

        public VC_PrivacySettingsDLG()
        {
            InitializeComponent();
            OnInitialize();
        }

        private void InitializeComponent()
        {

            OKPB = new PushButton()
            {
                Tag = "[Pane]$1/[PushButton]$1002",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(OKPB);
        }
    }
}
