// This file is auto-generated - do not hand edit this file.

using Autodesk.GUIHarness;
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{

    [UIElement(Tag = "*/[DialogBox]Select Long Description Style File")]
    public partial class SelectLongDescriptionStyleFileDLG : Autodesk.GUIHarness.AutoCAD.AcDialogBox
    {
        public  PushButton Cancel;
        public  TextField FileNameTextField;
        public  PushButton Open;

        partial void OnInitialize();

        public SelectLongDescriptionStyleFileDLG()
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

            FileNameTextField = new TextField()
            {
                Tag = "[TextField]$1001",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(FileNameTextField);

            Open = new PushButton()
            {
                Tag = "[PushButton]$1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Open);
        }
    }
}
