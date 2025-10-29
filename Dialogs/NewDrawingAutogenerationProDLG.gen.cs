// This file is auto-generated - do not hand edit this file.

using Autodesk.GUIHarness;
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{

    [UIElement(Tag = "[DialogBox]$AddItemDlg", Parent = typeof(Plant3D))]
    public partial class NewDrawingAutogenerationProDLG : Autodesk.GUIHarness.AutoCAD.AcDialogBox
    {
        public  PushButton M_btnCancel;
        public  PushButton M_btnOk;
        public  StaticText M_labelDesc;
        public  StaticText M_labelInc;
        public  StaticText M_labelKey;
        public  StaticText M_labelLast;
        public  TextField M_textBoxDesc;
        public  TextField M_textBoxInc;
        public  TextField M_textBoxKey;
        public  TextField M_textBoxLast;

        partial void OnInitialize();

        public NewDrawingAutogenerationProDLG()
        {
            InitializeComponent();
            OnInitialize();
        }

        private void InitializeComponent()
        {

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

            M_labelDesc = new StaticText()
            {
                Tag = "[StaticText]$m_labelDesc",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_labelDesc);

            M_labelInc = new StaticText()
            {
                Tag = "[StaticText]$m_labelInc",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_labelInc);

            M_labelKey = new StaticText()
            {
                Tag = "[StaticText]$m_labelKey",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_labelKey);

            M_labelLast = new StaticText()
            {
                Tag = "[StaticText]$m_labelLast",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_labelLast);

            M_textBoxDesc = new TextField()
            {
                Tag = "[TextField]$m_textBoxDesc",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_textBoxDesc);

            M_textBoxInc = new TextField()
            {
                Tag = "[TextField]$m_textBoxInc",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_textBoxInc);

            M_textBoxKey = new TextField()
            {
                Tag = "[TextField]$m_textBoxKey",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_textBoxKey);

            M_textBoxLast = new TextField()
            {
                Tag = "[TextField]$m_textBoxLast",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_textBoxLast);
        }
    }
}
