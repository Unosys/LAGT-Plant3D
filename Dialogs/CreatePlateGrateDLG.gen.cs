// This file is auto-generated - do not hand edit this file.

using Autodesk.GUIHarness;
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{

    [UIElement(Tag = "[DialogBox]Create Plate*Grate", Parent = typeof(Plant3D))]
    public partial class CreatePlateGrateDLG : Autodesk.GUIHarness.AutoCAD.AcDialogBox
    {
        public  PushButton Cancel;
        public  PushButton Create;
        public  PushButton Help;

        partial void OnInitialize();

        public CreatePlateGrateDLG()
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

            Create = new PushButton()
            {
                Tag = "[PushButton]$1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Create);

            Help = new PushButton()
            {
                Tag = "[PushButton]$1018",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Help);
        }
    }
}
