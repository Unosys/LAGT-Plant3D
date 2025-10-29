// This file is auto-generated - do not hand edit this file.

using Autodesk.GUIHarness;
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{

    [UIElement(Tag = "[Pane]$DataGridInfoDialog")]
    public partial class PandIDAutoCADPIDDLG : Autodesk.GUIHarness.AutoCAD.AcDialogBox
    {
        public  CheckBox M_notShowAgainChkBox;
        public  PushButton M_OKButton;

        partial void OnInitialize();

        public PandIDAutoCADPIDDLG()
        {
            InitializeComponent();
            OnInitialize();
        }

        private void InitializeComponent()
        {

            M_notShowAgainChkBox = new CheckBox()
            {
                Tag = "[CheckBox]$m_notShowAgainChkBox",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_notShowAgainChkBox);

            M_OKButton = new PushButton()
            {
                Tag = "[PushButton]$m_OKButton",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_OKButton);
        }
    }
}
