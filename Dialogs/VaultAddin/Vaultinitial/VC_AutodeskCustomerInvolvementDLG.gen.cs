// This file is auto-generated - do not hand edit this file.

using Autodesk.GUIHarness;
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{

    [UIElement(Tag = "[DialogBox]Data collection and use", Parent = typeof(VaultProServer))]
    public partial class VC_AutodeskCustomerInvolvementDLG : ProductTestSuite.CommonFiles.AdDialogBox
    {
        public  PushButton OK;

        partial void OnInitialize();

        public VC_AutodeskCustomerInvolvementDLG()
        {
            InitializeComponent();
            OnInitialize();
        }

        private void InitializeComponent()
        {

            OK = new PushButton()
            {
                Tag = "[PushButton]$1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(OK);
        }
    }
}
