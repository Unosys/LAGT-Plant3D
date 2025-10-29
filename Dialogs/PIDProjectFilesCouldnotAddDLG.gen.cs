// This file is auto-generated - do not hand edit this file.

using Autodesk.GUIHarness;
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{

    [UIElement(Tag = "[DialogBox]$frmMultilineMsgBox", Parent = typeof(Plant3D))]
    public partial class PIDProjectFilesCouldnotAddDLG : Autodesk.GUIHarness.AutoCAD.AcDialogBox
    {
        public  PushButton M_btnOk;
        public  StaticText M_lbl;
        public  TextField M_txtBox;

        partial void OnInitialize();

        public PIDProjectFilesCouldnotAddDLG()
        {
            InitializeComponent();
            OnInitialize();
        }

        private void InitializeComponent()
        {

            M_btnOk = new PushButton()
            {
                Tag = "[PushButton]$m_btnOk",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_btnOk);

            M_lbl = new StaticText()
            {
                Tag = "[StaticText]$m_lbl",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_lbl);

            M_txtBox = new TextField()
            {
                Tag = "[TextField]$m_txtBox",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_txtBox);
        }
    }
}
