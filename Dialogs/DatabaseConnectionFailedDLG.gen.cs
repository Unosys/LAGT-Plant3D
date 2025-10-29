// This file is auto-generated - do not hand edit this file.

using Autodesk.GUIHarness;
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{

    [UIElement(Tag = "[DialogBox]Database Connection Failed", Parent = typeof(Plant3D))]
    public partial class DatabaseConnectionFailedDLG : Autodesk.GUIHarness.AutoCAD.AcDialogBox
    {
        public  PushButton OK;
        public  CustomWin Icon1;
        public  StaticText LoginFailedForUserAaaTe;

        partial void OnInitialize();

        public DatabaseConnectionFailedDLG()
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

            Icon1 = new CustomWin()
            {
                Tag = "[CustomWin][Icon]#1|[Icon]$20",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Icon1);

            LoginFailedForUserAaaTe = new StaticText()
            {
                Tag = "[StaticText]Login failed for user 'aaa'.|#1|$65535",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(LoginFailedForUserAaaTe);
        }
    }
}
