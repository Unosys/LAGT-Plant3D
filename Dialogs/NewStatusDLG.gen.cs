// This file is auto-generated - do not hand edit this file.

using Autodesk.GUIHarness;
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{

    [UIElement(Tag = "[DialogBox]New Status", Parent = typeof(Plant3D))]
    public partial class NewStatusDLG : Autodesk.GUIHarness.AutoCAD.AcDialogBox
    {
        public  PushButton Cancel;
        public  PushButton OK;
        public  TextField Name;
        public  StaticText NameText;

        partial void OnInitialize();

        public NewStatusDLG()
        {
            InitializeComponent();
            OnInitialize();
        }

        private void InitializeComponent()
        {

            Cancel = new PushButton()
            {
                Tag = "[PushButton]$btnCancel",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Cancel);

            OK = new PushButton()
            {
                Tag = "[PushButton]$btnOK",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(OK);

            Name = new TextField()
            {
                Tag = "[TextField]$tbName",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Name);

            NameText = new StaticText()
            {
                Tag = "[StaticText]#1|$lblName",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(NameText);
        }
    }
}
