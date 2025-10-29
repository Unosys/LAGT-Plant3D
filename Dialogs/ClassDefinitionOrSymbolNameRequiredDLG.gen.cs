// This file is auto-generated - do not hand edit this file.

using Autodesk.GUIHarness;
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{

    [UIElement(Tag = "[DialogBox]$SymbolSettingErrorMessageDlg", Parent = typeof(Plant3D))]
    public partial class ClassDefinitionOrSymbolNameRequiredDLG : Autodesk.GUIHarness.AutoCAD.AcDialogBox
    {
        public  CustomWin Panel1;
        public  RadioButton ContinueAddRadioBtn;
        public  PushButton Cancel;
        public  Table ItemDataGridView;
        public  TextField RichTextBox1;
        public  CustomWin ImagePictureBox;
        public  PushButton OK;

        partial void OnInitialize();

        public ClassDefinitionOrSymbolNameRequiredDLG()
        {
            InitializeComponent();
            OnInitialize();
        }

        private void InitializeComponent()
        {

            Panel1 = new CustomWin()
            {
                Tag = "[System.Windows.Forms.Panel]$panel1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Panel1);

            ContinueAddRadioBtn = new RadioButton()
            {
                Tag = "$continueAddRadioBtn",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ContinueAddRadioBtn);

            Cancel = new PushButton()
            {
                Tag = "[PushButton]$cancelBtn",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Cancel);

            ItemDataGridView = new Table()
            {
                Tag = "$itemDataGridView",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ItemDataGridView);

            RichTextBox1 = new TextField()
            {
                Tag = "$richTextBox1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(RichTextBox1);

            ImagePictureBox = new CustomWin()
            {
                Tag = "[System.Windows.Forms.PictureBox]$imagePictureBox",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ImagePictureBox);

            OK = new PushButton()
            {
                Tag = "[PushButton]$okBtn",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(OK);
        }
    }
}
