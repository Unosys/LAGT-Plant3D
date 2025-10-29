// This file is auto-generated - do not hand edit this file.

using Autodesk.GUIHarness;
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{

    [UIElement(Tag = "[Pane]Plant 3D Project - Some Files Could Not be Added to Project|$frmMultilineMsgBox")]
    public partial class Plant3DProjectSomeFilesDLG : Pane
    {
        public  PushButton M_btnOk;
        public  PushButton ClosePB;

        partial void OnInitialize();

        public Plant3DProjectSomeFilesDLG()
        {
            InitializeComponent();
            OnInitialize();
        }

        private void InitializeComponent()
        {

            M_btnOk = new PushButton()
            {
                Tag = "[PushButton]OK|$m_btnOk",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_btnOk);

            ClosePB = new PushButton()
            {
                Tag = "[TitleBar]Plant 3D Project - Some Files Could Not be Added to Project|$TitleBar/[PushButton]Close|$Close",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ClosePB);
        }
    }
}
