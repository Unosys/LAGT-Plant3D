// This file is auto-generated - do not hand edit this file.

using Autodesk.GUIHarness;
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{

    [UIElement(Tag = "[DialogBox]Symbol Settings", Parent = typeof(ProjectSetupPalnt3DAnnotationDLG))]
    public partial class SymbolSettingsDLG : Autodesk.GUIHarness.AutoCAD.AcDialogBox
    {
        public  PushButton Cancel;
        public  PushButton Help;
        public  ListBox ListBox;
        public  PushButton OK;

        partial void OnInitialize();

        public SymbolSettingsDLG()
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

            Help = new PushButton()
            {
                Tag = "[PushButton]$9",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Help);

            ListBox = new ListBox()
            {
                Tag = "[ListBox]$",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ListBox);

            OK = new PushButton()
            {
                Tag = "[PushButton]$1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(OK);
        }
    }
}
