// This file is auto-generated - do not hand edit this file.

using Autodesk.GUIHarness;
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{

    [UIElement(Tag = "[Pane]$IsometricMapTBAttributesDlg")]
    public partial class MapTitleBlockAttributesDLG : Pane
    {
        public  PushButton M_cancelBtn;
        public  PushButton M_okBtn;

        partial void OnInitialize();

        public MapTitleBlockAttributesDLG()
        {
            InitializeComponent();
            OnInitialize();
        }

        private void InitializeComponent()
        {

            M_cancelBtn = new PushButton()
            {
                Tag = "[PushButton]$m_cancelBtn",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_cancelBtn);

            M_okBtn = new PushButton()
            {
                Tag = "[PushButton]$m_okBtn",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_okBtn);
        }
    }
}
