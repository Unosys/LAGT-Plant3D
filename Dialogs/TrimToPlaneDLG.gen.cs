// This file is auto-generated - do not hand edit this file.

using Autodesk.GUIHarness;
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{

    [UIElement(Tag = "[DialogBox]Trim to Plane", Parent = typeof(Plant3D))]
    public partial class TrimToPlaneDLG : Autodesk.GUIHarness.AutoCAD.AcDialogBox
    {
        public  PushButton Cancel;
        public  PushButton OK;
        public  PushButton Help;

        partial void OnInitialize();

        public TrimToPlaneDLG()
        {
            InitializeComponent();
            OnInitialize();
        }

        private void InitializeComponent()
        {

            Cancel = new PushButton()
            {
                Tag = "[PushButton]$2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Cancel);

            OK = new PushButton()
            {
                Tag = "[PushButton]$1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(OK);

            Help = new PushButton()
            {
                Tag = "[PushButton]$3",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Help);
        }
    }
}
