// This file is auto-generated - do not hand edit this file.

using Autodesk.GUIHarness;
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{

    [UIElement(Tag = "[Pane]Plant 3D Project - Some Files Could Not be Added to Project|$frmMultilineMsgBox", Parent = typeof(ProjManUndocked), GUIType = GuiType.UIA)]
    public partial class PandIDPlant3DProjectSomeFilesDLG : Pane
    {
        public  PushButton M_btnOk;
        public  TextField M_txtBox;
        public  PushButton ClosePB;

        partial void OnInitialize();

        public PandIDPlant3DProjectSomeFilesDLG()
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

            M_txtBox = new TextField()
            {
                Tag = "[TextField]Not all files could be added to the project*|$m_txtBox",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_txtBox);

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
