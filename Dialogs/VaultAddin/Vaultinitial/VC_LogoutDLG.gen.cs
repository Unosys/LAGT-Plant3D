// This file is auto-generated - do not hand edit this file.

using Autodesk.GUIHarness;
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{

    [UIElement(Tag = "[Pane]Log Out|$LogoutDialog", Parent = typeof(VaultPro), GUIType = GuiType.UIA)]
    public partial class VC_LogoutDLG : Pane
    {
        public  PushButton LogInPB;

        partial void OnInitialize();

        public VC_LogoutDLG()
        {
            InitializeComponent();
            OnInitialize();
        }

        private void InitializeComponent()
        {

            LogInPB = new PushButton()
            {
                Tag = "[Pane]$tableLayoutPanel1/[Pane]$tableLayoutPanel2/[PushButton]$okButton",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(LogInPB);
        }
    }
}
