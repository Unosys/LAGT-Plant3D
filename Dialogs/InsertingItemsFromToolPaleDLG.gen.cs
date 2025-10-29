// This file is auto-generated - do not hand edit this file.

using Autodesk.GUIHarness;
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{

    [UIElement(Tag = "[DialogBox]$DragandDropInfoDlg", Parent = typeof(Plant3D))]
    public partial class InsertingItemsFromToolPaleDLG : Autodesk.GUIHarness.AutoCAD.AcDialogBox
    {
        public  CheckBox CheckBox1;
        public  PushButton CloseButton;
        public  StaticText LabelInfo;
        public  StaticText LabelItem;
        public  GroupBox Panel1;
        public  CustomWin PictureBox1;

        partial void OnInitialize();

        public InsertingItemsFromToolPaleDLG()
        {
            InitializeComponent();
            OnInitialize();
        }

        private void InitializeComponent()
        {

            CheckBox1 = new CheckBox()
            {
                Tag = "[CheckBox]$checkBox1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(CheckBox1);

            CloseButton = new PushButton()
            {
                Tag = "[PushButton]$closeButton",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(CloseButton);

            LabelInfo = new StaticText()
            {
                Tag = "[StaticText]$labelInfo",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(LabelInfo);

            LabelItem = new StaticText()
            {
                Tag = "[StaticText]$labelItem",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(LabelItem);

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
