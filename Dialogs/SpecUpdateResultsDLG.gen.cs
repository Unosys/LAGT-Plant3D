// This file is auto-generated - do not hand edit this file.

using Autodesk.GUIHarness;
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{

    [UIElement(Tag = "[Pane]$NoUpdatesAvailableDlg", Parent = typeof(Plant3D))]
    public partial class SpecUpdateResultsDLG : Pane
    {
        public  StaticText Label_MainText;
        public  PushButton M_btnClose;

        partial void OnInitialize();

        public SpecUpdateResultsDLG()
        {
            InitializeComponent();
            OnInitialize();
        }

        private void InitializeComponent()
        {

            Label_MainText = new StaticText()
            {
                Tag = "[StaticText]$label_MainText",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Label_MainText);

            M_btnClose = new PushButton()
            {
                Tag = "[PushButton]$m_btnClose",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_btnClose);
        }
    }
}
