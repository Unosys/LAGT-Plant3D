// This file is auto-generated - do not hand edit this file.

using Autodesk.GUIHarness;
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{

    [UIElement(Tag = "[DialogBox]Error|#1", Parent = typeof(ProjManUndocked), GUIType = GuiType.WIN32)]
    public partial class SpecAlreadyExistsErrorDLG : Autodesk.GUIHarness.AutoCAD.AcDialogBox
    {
        public  PushButton OKPB;
        public  StaticText CUsersAdministratorDesktopNewFolderSpecUpdateAvailableSpecpspxAlreadyExistsST;

        partial void OnInitialize();

        public SpecAlreadyExistsErrorDLG()
        {
            InitializeComponent();
            OnInitialize();
        }

        private void InitializeComponent()
        {

            OKPB = new PushButton()
            {
                Tag = "[PushButton]OK|$2|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(OKPB);

            CUsersAdministratorDesktopNewFolderSpecUpdateAvailableSpecpspxAlreadyExistsST = new StaticText()
            {
                Tag = "[StaticText]'C:*|$65535|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(CUsersAdministratorDesktopNewFolderSpecUpdateAvailableSpecpspxAlreadyExistsST);
        }
    }
}
