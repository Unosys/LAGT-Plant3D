// This file is auto-generated - do not hand edit this file.

using Autodesk.GUIHarness;
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{

    [UIElement(Tag = "[DialogBox]Edit Grid", Parent = typeof(Plant3D))]
    public partial class EditGridDLG : Autodesk.GUIHarness.AutoCAD.AcDialogBox
    {
        public  PushButton Cancel;
        public  PushButton Create;
        public  PushButton Help;

        partial void OnInitialize();

        public EditGridDLG()
        {
            InitializeComponent();
            OnInitialize();
        }

        private void InitializeComponent()
        {

            Cancel = new PushButton()
            {
                Tag = "[PushButton]$1003",
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
                Tag = "[PushButton]$1052",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Help);
        }
    }
}
