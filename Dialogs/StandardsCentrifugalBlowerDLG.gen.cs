// This file is auto-generated - do not hand edit this file.

using Autodesk.GUIHarness;
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{

    [UIElement(Tag = "[DialogBox]Standards - *", Parent = typeof(Plant3D))]
    public partial class StandardsCentrifugalBlowerDLG : Autodesk.GUIHarness.AutoCAD.AcDialogBox
    {
        public  PushButton OK;
        public  PushButton Cancel;
        public  PushButton M_btnAddList;
        public  PushButton M_btnAddRow;
        public  PushButton M_btnCancel;
        public  PushButton M_btnDeleteList;
        public  PushButton M_btnDeleteRow;
        public  PushButton M_btnOk;
        public  Table M_dataGridView;
        public  StaticText M_labelName;
        public  ListBox M_listBox;
        public  TextField M_textBoxName;
        public  ScrollBar VerticalScrollBar;

        partial void OnInitialize();

        public StandardsCentrifugalBlowerDLG()
        {
            InitializeComponent();
            OnInitialize();
        }

        private void InitializeComponent()
        {

            OK = new PushButton()
            {
                Tag = "[PushButton]$okButton",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(OK);

            Cancel = new PushButton()
            {
                Tag = "[PushButton]$cancelButton",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Cancel);

            M_btnAddList = new PushButton()
            {
                Tag = "[PushButton]$m_btnAddList",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_btnAddList);

            M_btnAddRow = new PushButton()
            {
                Tag = "[PushButton]$m_btnAddRow",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_btnAddRow);

            M_btnCancel = new PushButton()
            {
                Tag = "[PushButton]$m_btnCancel",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_btnCancel);

            M_btnDeleteList = new PushButton()
            {
                Tag = "[PushButton]$m_btnDeleteList",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_btnDeleteList);

            M_btnDeleteRow = new PushButton()
            {
                Tag = "[PushButton]$m_btnDeleteRow",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_btnDeleteRow);

            M_btnOk = new PushButton()
            {
                Tag = "[PushButton]$m_btnOk",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_btnOk);

            M_dataGridView = new Table()
            {
                Tag = "[Table]$m_dataGridView",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_dataGridView);

            M_labelName = new StaticText()
            {
                Tag = "[StaticText]$m_labelName",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_labelName);

            M_listBox = new ListBox()
            {
                Tag = "[ListBox]$m_listBox",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_listBox);

            M_textBoxName = new TextField()
            {
                Tag = "[TextField]$m_textBoxName",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_textBoxName);

            VerticalScrollBar = new ScrollBar()
            {
                Tag = "[ScrollBar]$m_dataGridView",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(VerticalScrollBar);
        }
    }
}
