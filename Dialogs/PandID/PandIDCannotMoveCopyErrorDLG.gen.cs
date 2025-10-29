// This file is auto-generated - do not hand edit this file.

using Autodesk.GUIHarness;
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{

    [UIElement(Tag = "[DialogBox]Error", Parent = typeof(MainWin))]
    public partial class PandIDCannotMoveCopyErrorDLG : Autodesk.GUIHarness.AutoCAD.AcDialogBox
    {
        public  PushButton OK;
        public  StaticText CannotMoveCopyAProject;

        partial void OnInitialize();

        public PandIDCannotMoveCopyErrorDLG()
        {
            InitializeComponent();
            OnInitialize();
        }

        private void InitializeComponent()
        {

            OK = new PushButton()
            {
                Tag = "[PushButton]OK|#1|$2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(OK);

            CannotMoveCopyAProject = new StaticText()
            {
                Tag = "[StaticText]Cannot Move?Copy a project which is not coverted to SQL server. Please convert it first.|#1|$65535",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(CannotMoveCopyAProject);
        }
    }
}
