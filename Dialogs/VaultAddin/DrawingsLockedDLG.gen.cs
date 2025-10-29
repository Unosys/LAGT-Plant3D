// This file is auto-generated - do not hand edit this file.

using Autodesk.GUIHarness;
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{

    [UIElement(Tag = "[DialogBox]DrawingsLockedDLG", Parent = typeof(Plant3D))]
    public partial class DrawingsLockedDLG : Autodesk.GUIHarness.AutoCAD.AcDialogBox
    {
        public  PushButton OK;
        public  CustomWin Icon1;
        public  StaticText TheFollowingDrawingsCouldN;

        partial void OnInitialize();

        public DrawingsLockedDLG()
        {
            InitializeComponent();
            OnInitialize();
        }

        private void InitializeComponent()
        {

            OK = new PushButton()
            {
                Tag = "[PushButton]$2|OK|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(OK);

            Icon1 = new CustomWin()
            {
                Tag = "[CustomWin][Icon]$20|[Icon]#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Icon1);

            TheFollowingDrawingsCouldN = new StaticText()
            {
                Tag = "[StaticText]$65535|The following drawings could not be opened because either they are opened by another user or you do not have write permissions*|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(TheFollowingDrawingsCouldN);
        }
    }
}
