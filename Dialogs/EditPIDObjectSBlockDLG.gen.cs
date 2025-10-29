// This file is auto-generated - do not hand edit this file.

using Autodesk.GUIHarness;
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{

    [UIElement(Tag = "[DialogBox]EditPIDObjectSBlockDLG", Parent = typeof(Plant3D))]
    public partial class EditPIDObjectSBlockDLG : Autodesk.GUIHarness.AutoCAD.AcDialogBox
    {
        public  PushButton PushButton1;
        public  PushButton PushButton2;
        public  TextField TextField1;

        partial void OnInitialize();

        public EditPIDObjectSBlockDLG()
        {
            InitializeComponent();
            OnInitialize();
        }

        private void InitializeComponent()
        {

            PushButton1 = new PushButton()
            {
                Tag = "[PushButton]$",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(PushButton1);

            PushButton2 = new PushButton()
            {
                Tag = "[PushButton]$",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(PushButton2);

            TextField1 = new TextField()
            {
                Tag = "[TextField]$",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(TextField1);
        }
    }
}
