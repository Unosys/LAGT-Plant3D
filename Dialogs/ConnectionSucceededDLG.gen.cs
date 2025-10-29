// This file is auto-generated - do not hand edit this file.

using Autodesk.GUIHarness;
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{

    [UIElement(Tag = "[DialogBox]Connection Succeeded", Parent = typeof(Plant3D))]
    public partial class ConnectionSucceededDLG : Autodesk.GUIHarness.AutoCAD.AcDialogBox
    {
        public  PushButton OK;
        public  StaticText YourTestOfTheConnectionTo;

        partial void OnInitialize();

        public ConnectionSucceededDLG()
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

            YourTestOfTheConnectionTo = new StaticText()
            {
                Tag = "[StaticText]Your test of the connection to the specified server has been successful.|#1|$65535",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(YourTestOfTheConnectionTo);
        }
    }
}
