// This file is auto-generated - do not hand edit this file.

using Autodesk.GUIHarness;
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{

    [UIElement(Tag = "[DialogBox]Drawing Already Exists", Parent = typeof(NewDWGDLG))]
    public partial class DrawingAlreadyExistsDLG : Autodesk.GUIHarness.AutoCAD.AcDialogBox
    {
        public  StaticText CUsersAdministratorAppDataRoam;
        public  StaticText Label;
        public  PushButton OK;

        partial void OnInitialize();

        public DrawingAlreadyExistsDLG()
        {
            InitializeComponent();
            OnInitialize();
        }

        private void InitializeComponent()
        {

            CUsersAdministratorAppDataRoam = new StaticText()
            {
                Tag = "[StaticText]$",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(CUsersAdministratorAppDataRoam);

            Label = new StaticText()
            {
                Tag = "[StaticText]$",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Label);

            OK = new PushButton()
            {
                Tag = "[PushButton]$2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(OK);
        }
    }
}
