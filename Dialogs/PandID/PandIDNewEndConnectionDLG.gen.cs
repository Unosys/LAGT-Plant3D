// This file is auto-generated - do not hand edit this file.

using Autodesk.GUIHarness;
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{

    [UIElement(Tag = "[DialogBox]$NewEndConnectionDlg")]
    public partial class PandIDNewEndConnectionDLG : Autodesk.GUIHarness.AutoCAD.AcDialogBox
    {
        public  PushButton M_btnBrowse;
        public  PushButton M_btnCancel;
        public  PushButton M_btnOk;
        public  StaticText M_labelBlockDef;
        public  StaticText M_labelName;
        public  TextField M_textBoxBlockDef;
        public  TextField M_textBoxName;

        partial void OnInitialize();

        public PandIDNewEndConnectionDLG()
        {
            InitializeComponent();
            OnInitialize();
        }

        private void InitializeComponent()
        {

            M_btnBrowse = new PushButton()
            {
                Tag = "[PushButton]$m_btnBrowse",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_btnBrowse);

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

            M_labelBlockDef = new StaticText()
            {
                Tag = "[StaticText]$m_labelBlockDef",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_labelBlockDef);

            M_labelName = new StaticText()
            {
                Tag = "[StaticText]$m_labelName",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_labelName);

            M_textBoxBlockDef = new TextField()
            {
                Tag = "[TextField]$m_textBoxBlockDef",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_textBoxBlockDef);

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
