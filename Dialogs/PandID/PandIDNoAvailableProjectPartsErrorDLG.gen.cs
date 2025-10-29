// This file is auto-generated - do not hand edit this file.

using Autodesk.GUIHarness;
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{

    [UIElement(Tag = "[DialogBox]Error", Parent = typeof(MainWin))]
    public partial class PandIDNoAvailableProjectPartsErrorDLG : Autodesk.GUIHarness.AutoCAD.AcDialogBox
    {
        public  PushButton OK;
        public  StaticText NoAvailableProjectPartsTex;

        partial void OnInitialize();

        public PandIDNoAvailableProjectPartsErrorDLG()
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

            NoAvailableProjectPartsTex = new StaticText()
            {
                Tag = "[StaticText]No available Project Parts.|#1|$65535",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(NoAvailableProjectPartsTex);
        }
    }
}
