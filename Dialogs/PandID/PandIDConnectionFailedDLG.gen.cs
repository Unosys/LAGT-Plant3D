// This file is auto-generated - do not hand edit this file.

using Autodesk.GUIHarness;
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{

    [UIElement(Tag = "[DialogBox]Connection Failed", Parent = typeof(MainWin))]
    public partial class PandIDConnectionFailedDLG : Autodesk.GUIHarness.AutoCAD.AcDialogBox
    {
        public  PushButton OK;
        public  StaticText YourTestConnectionToTheSp;

        partial void OnInitialize();

        public PandIDConnectionFailedDLG()
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

            YourTestConnectionToTheSp = new StaticText()
            {
                Tag = "[StaticText]Your test connection to the specified server has failed. Please try again.|#1|$65535",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(YourTestConnectionToTheSp);
        }
    }
}
