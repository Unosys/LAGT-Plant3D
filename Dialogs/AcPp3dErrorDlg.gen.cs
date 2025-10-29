// This file is auto-generated - do not hand edit this file.

using Autodesk.GUIHarness;
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{

    [UIElement(Tag = "[DialogBox]$AcPp3dErrorDlg", Parent = typeof(Plant3D))]
    public partial class AcPp3dErrorDlg : Autodesk.GUIHarness.AutoCAD.AcDialogBox
    {
        public  CustomWin Panel1;
        public  Table GridView;
        public  PushButton BtnClose;
        public  StaticText LabelText;
        public  CustomWin IconPicBox;

        partial void OnInitialize();

        public AcPp3dErrorDlg()
        {
            InitializeComponent();
            OnInitialize();
        }

        private void InitializeComponent()
        {

            Panel1 = new CustomWin()
            {
                Tag = "[CustomWin][System.Windows.Forms.Panel]$panel1|[System.Windows.Forms.Panel]One or more items have caused an error.|[System.Windows.Forms.Panel]#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Panel1);

            GridView = new Table()
            {
                Tag = "[Table]$GridView|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(GridView);

            BtnClose = new PushButton()
            {
                Tag = "[PushButton]$BtnClose|Close|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(BtnClose);

            LabelText = new StaticText()
            {
                Tag = "[StaticText]$LabelText|One or more items have caused an error.|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(LabelText);

            IconPicBox = new CustomWin()
            {
                Tag = "[CustomWin][System.Windows.Forms.PictureBox]$IconPicBox|[System.Windows.Forms.PictureBox]#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(IconPicBox);
        }
    }
}
