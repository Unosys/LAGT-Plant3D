// This file is auto-generated - do not hand edit this file.

using Autodesk.GUIHarness;
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{

    [UIElement(Tag = "[DialogBox]AlreadyLoggendInDLG", Parent = typeof(Plant3D))]
    public partial class AlreadyLoggendInDLG : Autodesk.GUIHarness.AutoCAD.AcDialogBox
    {
        public  PushButton OK;
        public  StaticText AlreadyLoggedInServerEnv00;

        partial void OnInitialize();

        public AlreadyLoggendInDLG()
        {
            InitializeComponent();
            OnInitialize();
        }

        private void InitializeComponent()
        {

            OK = new PushButton()
            {
                Tag = "[PushButton]$2|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(OK);

            AlreadyLoggedInServerEnv00 = new StaticText()
            {
                Tag = "[StaticText]$65535|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(AlreadyLoggedInServerEnv00);
        }
    }
}
