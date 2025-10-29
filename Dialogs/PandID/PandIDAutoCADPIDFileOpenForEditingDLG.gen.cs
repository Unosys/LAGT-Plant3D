// This file is auto-generated - do not hand edit this file.

using Autodesk.GUIHarness;
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{

    [UIElement(Tag = "[DialogBox]AutoCAD Plant 3D", Parent = typeof(Pane), GUIType = GuiType.UIA)]
    public partial class PandIDAutoCADPIDFileOpenForEditingDLG : Autodesk.GUIHarness.AutoCAD.AcDialogBox
    {
        public  PushButton OKPB;
        public  Image ImageIMG;
        public  StaticText CUsersAdministratorAppDataRoamingAutodeskAutodeskAutoCADPlant3DST;
        public  TitleBar AutoCADPlant3DCTL;
        public  PushButton ClosePB;

        partial void OnInitialize();

        public PandIDAutoCADPIDFileOpenForEditingDLG()
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

            ImageIMG = new Image()
            {
                Tag = "[Image]$20|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ImageIMG);

            CUsersAdministratorAppDataRoamingAutodeskAutodeskAutoCADPlant3DST = new StaticText()
            {
                Tag = "[StaticText]'C:*|$65535|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(CUsersAdministratorAppDataRoamingAutodeskAutodeskAutoCADPlant3DST);

            AutoCADPlant3DCTL = new TitleBar()
            {
                Tag = "[TitleBar]AutoCAD Plant 3D|$TitleBar|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(AutoCADPlant3DCTL);

            ClosePB = new PushButton()
            {
                Tag = "[TitleBar]AutoCAD Plant 3D|$TitleBar|#1/[PushButton]Close|$Close|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ClosePB);
        }
    }
}
