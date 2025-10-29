// This file is auto-generated - do not hand edit this file.

using Autodesk.GUIHarness;
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{

    [UIElement(Tag = "[DialogBox]AutoCAD Alert", Parent = typeof(MainWin), GUIType = GuiType.WIN32)]
    public partial class DrawingAlertDLG : Autodesk.GUIHarness.AutoCAD.AcDialogBox
    {
        public  PushButton YesPB;
        public  PushButton NoPB;
        public  Image ImageIMG;
        public  StaticText CUsersAdministratorAppDataRoamingAutodeskAutodeskAutoCADPlant3DST;

        partial void OnInitialize();

        public DrawingAlertDLG()
        {
            InitializeComponent();
            OnInitialize();
        }

        private void InitializeComponent()
        {

            YesPB = new PushButton()
            {
                Tag = "[PushButton]Yes|$6|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(YesPB);

            NoPB = new PushButton()
            {
                Tag = "[PushButton]No|$7|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(NoPB);

            ImageIMG = new Image()
            {
                Tag = "[Image]$20|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ImageIMG);

            CUsersAdministratorAppDataRoamingAutodeskAutodeskAutoCADPlant3DST = new StaticText()
            {
                Tag = "[StaticText]C:*|$65535|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(CUsersAdministratorAppDataRoamingAutodeskAutodeskAutoCADPlant3DST);
        }
    }
}
