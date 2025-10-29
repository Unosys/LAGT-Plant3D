// This file is auto-generated - do not hand edit this file.

using Autodesk.GUIHarness;
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{

    [UIElement(Tag = "[Pane]$CommonMessageBox", Parent = typeof(VaultPro))]
    public partial class VM_AfterDeleteCustomObjectMSG : Pane
    {
        public  PushButton OKPB;

        partial void OnInitialize();

        public VM_AfterDeleteCustomObjectMSG()
        {
            InitializeComponent();
            OnInitialize();
        }

        private void InitializeComponent()
        {

            OKPB = new PushButton()
            {
                Tag = "[Pane]$tableLayoutPanel1/[Pane]$tableLayoutPanel2/[PushButton]$button1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(OKPB);
        }
    }
}
