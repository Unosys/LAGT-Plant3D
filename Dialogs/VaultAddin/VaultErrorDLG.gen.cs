// This file is auto-generated - do not hand edit this file.

using Autodesk.GUIHarness;
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{

    [UIElement(Tag = "[DialogBox]Error", Parent = typeof(Pane))]
    public partial class VaultErrorDLG : Autodesk.GUIHarness.AutoCAD.AcDialogBox
    {
        public  PushButton OK;
        public  CustomWin Icon1;
        public  StaticText TheCUsersAdministratorDoc;

        partial void OnInitialize();

        public VaultErrorDLG()
        {
            InitializeComponent();
            OnInitialize();
        }

        private void InitializeComponent()
        {

            OK = new PushButton()
            {
                Tag = "[PushButton]$2|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(OK);

            Icon1 = new CustomWin()
            {
                Tag = "[CustomWin][Icon]$20|[Icon]#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Icon1);

            TheCUsersAdministratorDoc = new StaticText()
            {
                Tag = "[StaticText]$65535|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(TheCUsersAdministratorDoc);
        }
    }
}
