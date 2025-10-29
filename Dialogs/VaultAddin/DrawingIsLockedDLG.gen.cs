// This file is auto-generated - do not hand edit this file.

using Autodesk.GUIHarness;
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{

    [UIElement(Tag = "[DialogBox]DrawingIsLockedDLG", Parent = typeof(CreateConnectionDLG))]
    public partial class DrawingIsLockedDLG : Autodesk.GUIHarness.AutoCAD.AcDialogBox
    {
        public  PushButton OK;
        public  CustomWin Icon1;
        public  StaticText CUsersENV002DocumentsPlan;

        partial void OnInitialize();

        public DrawingIsLockedDLG()
        {
            InitializeComponent();
            OnInitialize();
        }

        private void InitializeComponent()
        {

            OK = new PushButton()
            {
                Tag = "[PushButton]$2|OK|#1",
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

            CUsersENV002DocumentsPlan = new StaticText()
            {
                Tag = "[StaticText]$65535|C:\\Users\\ENV002\\Documents\\Plant Vault Projects\\zsemi\\PID DWG\\c.dwg is currently locked. Connector cannot be placed.|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(CUsersENV002DocumentsPlan);
        }
    }
}
