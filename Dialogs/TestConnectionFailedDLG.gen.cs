// This file is auto-generated - do not hand edit this file.

using Autodesk.GUIHarness;
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{

    [UIElement(Tag = "[DialogBox]Test Connection Failed", Parent = typeof(Plant3D))]
    public partial class TestConnectionFailedDLG : Autodesk.GUIHarness.AutoCAD.AcDialogBox
    {
        public  PushButton OK;
        public  CustomWin Icon1;
        public  StaticText YourTestConnectionToTheSp;

        partial void OnInitialize();

        public TestConnectionFailedDLG()
        {
            InitializeComponent();
            OnInitialize();
        }

        private void InitializeComponent()
        {

            OK = new PushButton()
            {
                Tag = "[PushButton]$2",
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
