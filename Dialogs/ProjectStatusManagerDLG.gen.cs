// This file is auto-generated - do not hand edit this file.

using Autodesk.GUIHarness;
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{

    [UIElement(Tag = "[DialogBox]Project Status Manager", Parent = typeof(Plant3D))]
    public partial class ProjectStatusManagerDLG : Autodesk.GUIHarness.AutoCAD.AcDialogBox
    {
        public  PushButton Cancel;
        public  CustomWin PictureBox1;
        public  PushButton Help;
        public  PushButton Close;
        public  PushButton NewPB;
        public  StaticText CurrentProjectDefaultProjec;

        partial void OnInitialize();

        public ProjectStatusManagerDLG()
        {
            InitializeComponent();
            OnInitialize();
        }

        private void InitializeComponent()
        {

            Cancel = new PushButton()
            {
                Tag = "[PushButton]#1|$btnCancel",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Cancel);

            PictureBox1 = new CustomWin()
            {
                Tag = "[CustomWin][System.Windows.Forms.PictureBox]#1|[System.Windows.Forms.PictureBox]$pictureBox1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(PictureBox1);

            Help = new PushButton()
            {
                Tag = "[PushButton]#3|$btnHelp",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Help);

            Close = new PushButton()
            {
                Tag = "[PushButton]$btnClose",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Close);

            NewPB = new PushButton()
            {
                Tag = "[PushButton]$btnNew",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(NewPB);

            CurrentProjectDefaultProjec = new StaticText()
            {
                Tag = "[StaticText]#1|$lblCurrentProject",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(CurrentProjectDefaultProjec);
        }
    }
}
