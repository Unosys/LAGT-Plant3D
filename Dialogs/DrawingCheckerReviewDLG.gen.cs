// This file is auto-generated - do not hand edit this file.

using Autodesk.GUIHarness;
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{

    [UIElement(Tag = "[Pane]$DwgCheckerReview", Parent = typeof(Plant3D))]
    public partial class DrawingCheckerReviewDLG : Autodesk.GUIHarness.AutoCAD.AcDialogBox
    {
        public  Table AnnotationDataGridView;
        public  PushButton BtnCancel;
        public  PushButton BtnClose;
        public  PushButton BtnHelp;
        public  CheckBox IsEraseReview;
        public  StaticText Label1;
        public  StaticText Label2;
        public  GroupBox Panel1;
        public  CustomWin PictureBox1;

        partial void OnInitialize();

        public DrawingCheckerReviewDLG()
        {
            InitializeComponent();
            OnInitialize();
        }

        private void InitializeComponent()
        {

            AnnotationDataGridView = new Table()
            {
                Tag = "[Table]$AnnotationDataGridView",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(AnnotationDataGridView);

            BtnCancel = new PushButton()
            {
                Tag = "[PushButton]Cancel|$btnCancel|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(BtnCancel);

            BtnClose = new PushButton()
            {
                Tag = "[PushButton]$btnClose",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(BtnClose);

            BtnHelp = new PushButton()
            {
                Tag = "[PushButton]$btnHelp",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(BtnHelp);

            IsEraseReview = new CheckBox()
            {
                Tag = "[CheckBox]$isEraseReview",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(IsEraseReview);

            Label1 = new StaticText()
            {
                Tag = "[StaticText]$label1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Label1);

            Label2 = new StaticText()
            {
                Tag = "[StaticText]$label2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Label2);

            Panel1 = new GroupBox()
            {
                Tag = "[GroupBox]$panel1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Panel1);

            PictureBox1 = new CustomWin()
            {
                Tag = "[CustomWin]$pictureBox1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(PictureBox1);
        }
    }
}
