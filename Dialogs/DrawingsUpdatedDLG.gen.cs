// This file is auto-generated - do not hand edit this file.

using Autodesk.GUIHarness;
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{

    [UIElement(Tag = "[DialogBox]Drawings Updated", Parent = typeof(Plant3D))]
    public partial class DrawingsUpdatedDLG : Autodesk.GUIHarness.AutoCAD.AcDialogBox
    {
        public  PushButton OK;
        public  CustomWin Icon1;
        public  StaticText TheFollowingDrawingsHaveUp;

        partial void OnInitialize();

        public DrawingsUpdatedDLG()
        {
            InitializeComponent();
            OnInitialize();
        }

        private void InitializeComponent()
        {

            OK = new PushButton()
            {
                Tag = "[PushButton]OK|$2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(OK);

            Icon1 = new CustomWin()
            {
                Tag = "[Icon]$20",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Icon1);

            TheFollowingDrawingsHaveUp = new StaticText()
            {
                Tag = "[StaticText]The following drawings have updated records:??C:\\Documents and Settings\\nsarch\\Application Data\\Autodesk\\AutoCAD Plant 3D 201*|$65535",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(TheFollowingDrawingsHaveUp);
        }
    }
}
