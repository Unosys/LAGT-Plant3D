// This file is auto-generated - do not hand edit this file.

using Autodesk.GUIHarness;
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{

    [UIElement(Tag = "[DialogBox]FileIsReadOnlyDLG", Parent = typeof(CustomWin))]
    public partial class PandIDFileIsReadOnlyDLG : Autodesk.GUIHarness.AutoCAD.AcDialogBox
    {
        public  PushButton OK;
        public  CustomWin Icon1;
        public  StaticText TheFileYouAreAttemptingTo;

        partial void OnInitialize();

        public PandIDFileIsReadOnlyDLG()
        {
            InitializeComponent();
            OnInitialize();
        }

        private void InitializeComponent()
        {

            OK = new PushButton()
            {
                Tag = "$2",
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

            TheFileYouAreAttemptingTo = new StaticText()
            {
                Tag = "$65535",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(TheFileYouAreAttemptingTo);
        }
    }
}
