// This file is auto-generated - do not hand edit this file.

using Autodesk.GUIHarness;
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{

    [UIElement(Tag = "[DialogBox]Project Move Success", Parent = typeof(MainWin))]
    public partial class PandIDProjectMoveSuccessDLG : Autodesk.GUIHarness.AutoCAD.AcDialogBox
    {
        public  PushButton OK;
        public  StaticText YourProjectHasBeenSuccessf;

        partial void OnInitialize();

        public PandIDProjectMoveSuccessDLG()
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

            YourProjectHasBeenSuccessf = new StaticText()
            {
                Tag = "[StaticText]Your project has been successfully moved.|#1|$65535",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(YourProjectHasBeenSuccessf);
        }
    }
}
