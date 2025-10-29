// This file is auto-generated - do not hand edit this file.

using Autodesk.GUIHarness;
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{

    [UIElement(Tag = "[Pane]AutoCAD Plant|$DataGridInfoDialog")]
    public partial class AutoCADP3DWarningDLG : Pane
    {
        public  PushButton M_OKButton;
        public  CheckBox M_notShowAgainChkBox;
        public  Link M_helperLinkLabel;
        public  CustomWin M_iconPicture;

        partial void OnInitialize();

        public AutoCADP3DWarningDLG()
        {
            InitializeComponent();
            OnInitialize();
        }

        private void InitializeComponent()
        {

            M_OKButton = new PushButton()
            {
                Tag = "[PushButton]$m_OKButton",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_OKButton);

            M_notShowAgainChkBox = new CheckBox()
            {
                Tag = "[CheckBox]$m_notShowAgainChkBox",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_notShowAgainChkBox);

            M_helperLinkLabel = new Link()
            {
                Tag = "[Link]$m_helperLinkLabel",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_helperLinkLabel);

            M_iconPicture = new CustomWin()
            {
                Tag = "[CustomWin]$m_iconPicture",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_iconPicture);
        }
    }
}
