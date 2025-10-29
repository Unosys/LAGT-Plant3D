// This file is auto-generated - do not hand edit this file.

using Autodesk.GUIHarness;
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{

    [UIElement(Tag = "[Pane]$SelectDatabaseDialog", Parent = typeof(VC_LogInDLG))]
    public partial class VC_DatabaseListFormDLG : Pane
    {
        public  PushButton CancelPB;
        public  ListBox SelectAVaultFromLB;
        public  PushButton OKPB;

        partial void OnInitialize();

        public VC_DatabaseListFormDLG()
        {
            InitializeComponent();
            OnInitialize();
        }

        private void InitializeComponent()
        {

            CancelPB = new PushButton()
            {
                Tag = "[PushButton]$cancelButton",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(CancelPB);

            SelectAVaultFromLB = new ListBox()
            {
                Tag = "[ListBox]$vaultListBox",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(SelectAVaultFromLB);

            OKPB = new PushButton()
            {
                Tag = "[PushButton]$okButton",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(OKPB);
        }
    }
}
