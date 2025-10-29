// This file is auto-generated - do not hand edit this file.

using Autodesk.GUIHarness;
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{

    [UIElement(Tag = "[DialogBox]Connection Succeeded", Parent = typeof(MainWin))]
    public partial class PandIDPMUConnectionSucceededDLG : Autodesk.GUIHarness.AutoCAD.AcDialogBox
    {
        public  PushButton OK;
        public  StaticText YourTestOfTheConnectionTo;

        partial void OnInitialize();

        public PandIDPMUConnectionSucceededDLG()
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

            YourTestOfTheConnectionTo = new StaticText()
            {
                Tag = "[StaticText]Your test of the connection to the specified server has been successful. Please select the convert button to proceed.|#1|$65535",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(YourTestOfTheConnectionTo);
        }
    }
}
