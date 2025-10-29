// This file is auto-generated - do not hand edit this file.

using Autodesk.GUIHarness;
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{

    [UIElement(Tag = "[DialogBox]$AddItemDlg", Parent = typeof(Plant3D))]
    public partial class AddRowDLG : Autodesk.GUIHarness.AutoCAD.AcDialogBox
    {
        public  PushButton M_btnCancel;
        public  PushButton M_btnOk;
        public  StaticText M_DescriptionLabel;
        public  StaticText M_NameLabel;
        public  TextField M_textBoxDesc;
        public  TextField M_textBoxName;

        partial void OnInitialize();

        public AddRowDLG()
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

            M_DescriptionLabel = new StaticText()
            {
                Tag = "[StaticText]$m_DescriptionLabel",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_DescriptionLabel);

            M_NameLabel = new StaticText()
            {
                Tag = "[StaticText]$m_NameLabel",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_NameLabel);

            M_textBoxDesc = new TextField()
            {
                Tag = "[TextField]$m_textBoxDesc",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_textBoxDesc);

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
