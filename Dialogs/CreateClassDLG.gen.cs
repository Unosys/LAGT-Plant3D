// This file is auto-generated - do not hand edit this file.

using Autodesk.GUIHarness;
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{

    [UIElement(Tag = "[DialogBox]$NewObjectDefinitionDlg", Parent = typeof(Plant3D))]
    public partial class CreateClassDLG : Autodesk.GUIHarness.AutoCAD.AcDialogBox
    {
        public  PushButton BtnHelp;
        public  PushButton M_btnCancel;
        public  PushButton M_btnOk;
        public  StaticText M_labelDisplayName;
        public  StaticText M_labelName;
        public  TextField M_textBoxDisplayName;
        public  TextField M_textBoxName;

        partial void OnInitialize();

        public CreateClassDLG()
        {
            InitializeComponent();
            OnInitialize();
        }

        private void InitializeComponent()
        {

            BtnHelp = new PushButton()
            {
                Tag = "[PushButton]$btnHelp",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(BtnHelp);

            M_btnCancel = new PushButton()
            {
                Tag = "[PushButton]$m_btnCancel",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_btnCancel);

            M_btnOk = new PushButton()
            {
                Tag = "[PushButton]$m_btnOk",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_btnOk);

            M_labelDisplayName = new StaticText()
            {
                Tag = "[StaticText]$m_labelDisplayName",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_labelDisplayName);

            M_labelName = new StaticText()
            {
                Tag = "[StaticText]$m_labelName",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_labelName);

            M_textBoxDisplayName = new TextField()
            {
                Tag = "[TextField]$m_textBoxDisplayName",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_textBoxDisplayName);

            M_textBoxName = new TextField()
            {
                Tag = "[TextField]$m_textBoxName",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_textBoxName);
        }
    }
}
