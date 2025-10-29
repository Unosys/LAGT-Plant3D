// This file is auto-generated - do not hand edit this file.

using Autodesk.GUIHarness;
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{

    [UIElement(Tag = "[DialogBox]Duplicate File Name", Parent = typeof(Plant3D))]
    public partial class DuplicateFileNameDLG : Autodesk.GUIHarness.AutoCAD.AcDialogBox
    {
        public  PushButton Yes;
        public  PushButton NoPB;
        public  CustomWin Icon1;
        public  StaticText AFileWithThisNameAlready;

        partial void OnInitialize();

        public DuplicateFileNameDLG()
        {
            InitializeComponent();
            OnInitialize();
        }

        private void InitializeComponent()
        {

            Yes = new PushButton()
            {
                Tag = "[PushButton]$6",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Yes);

            NoPB = new PushButton()
            {
                Tag = "[PushButton]$7",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(NoPB);

            Icon1 = new CustomWin()
            {
                Tag = "[CustomWin][Icon]#1|[Icon]$20",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Icon1);

            AFileWithThisNameAlready = new StaticText()
            {
                Tag = "[StaticText]A file with this name already exists in the project manager. Do you want to rename?aa.DWG? to ?aa(2).DWG??|#1|$65535",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(AFileWithThisNameAlready);
        }
    }
}
