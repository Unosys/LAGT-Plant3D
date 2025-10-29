// This file is auto-generated - do not hand edit this file.

using Autodesk.GUIHarness;
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{

    [UIElement(Tag = "[DialogBox]Select PCF File", Parent = typeof(IsometricDWGSettingsLivePreviewDLG))]
    public partial class SelectPCFFileDLG : Autodesk.GUIHarness.AutoCAD.AcDialogBox
    {
        public  PushButton Cancel;
        public  TextField FileNameTextField;
        public  PushButton Help;
        public  PushButton Open;

        partial void OnInitialize();

        public SelectPCFFileDLG()
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
                Tag = "[TextField]$",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(FileNameTextField);

            Help = new PushButton()
            {
                Tag = "[PushButton]$1038",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Help);

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
