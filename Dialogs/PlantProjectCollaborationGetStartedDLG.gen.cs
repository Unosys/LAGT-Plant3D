// This file is auto-generated - do not hand edit this file.

using Autodesk.GUIHarness;
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{

    [UIElement(Tag = "[Window]Plant Project Collaboration|$Window_1", Parent = typeof(MainWin), GUIType = GuiType.UIA)]
    public partial class PlantProjectCollaborationGetStartedDLG : Autodesk.GUIHarness.AutoCAD.AcDialogBox
    {
        public  TitleBar PlantProjectCollaborationCTL;
        public  CustomWin SystemMenuBarWIN;
        public  MenuItem SystemMI;
        public  PushButton ClosePB;
        public  CustomWin CustomWinWIN;
        public  StaticText ShareYourProjectWithST;
        public  PushButton LearnMoreAboutWorkingPB;
        public  StaticText LearnMoreAboutWorkingST;
        public  PushButton GetStartedPB;
        public  StaticText GetStartedST;
        public  Image Image1IMG;
        public  Image Image2IMG;
        public  Image Image3IMG;
        public  StaticText oneChooseABIMST;
        public  StaticText twoUploadACopyST;
        public  StaticText threeInviteYourTeamST;

        partial void OnInitialize();

        public PlantProjectCollaborationGetStartedDLG()
        {
            InitializeComponent();
            OnInitialize();
        }

        private void InitializeComponent()
        {

            PlantProjectCollaborationCTL = new TitleBar()
            {
                Tag = "[TitleBar]Plant Project Collaboration|$TitleBar|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(PlantProjectCollaborationCTL);

            SystemMenuBarWIN = new CustomWin()
            {
                Tag = "[TitleBar]Plant Project Collaboration|$TitleBar|#1/[CustomWin]System Menu Bar|$SystemMenuBar|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(SystemMenuBarWIN);

            SystemMI = new MenuItem()
            {
                Tag = "[TitleBar]Plant Project Collaboration|$TitleBar|#1/[CustomWin]System Menu Bar|$SystemMenuBar|#1/[MenuItem]System|$Item 1|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(SystemMI);

            ClosePB = new PushButton()
            {
                Tag = "[TitleBar]Plant Project Collaboration|$TitleBar|#1/[PushButton]Close|$Close|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ClosePB);

            CustomWinWIN = new CustomWin()
            {
                Tag = "[CustomWin]$UserControl_1|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(CustomWinWIN);

            ShareYourProjectWithST = new StaticText()
            {
                Tag = "[CustomWin]$UserControl_1|#1/[StaticText]Share your project with the cloud*|$TextBlock_1|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ShareYourProjectWithST);

            LearnMoreAboutWorkingPB = new PushButton()
            {
                Tag = "[CustomWin]$UserControl_1|#1/[PushButton]Learn more about working with BIM 360 Team Projects|$Button_LearnMore|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(LearnMoreAboutWorkingPB);

            LearnMoreAboutWorkingST = new StaticText()
            {
                Tag = "[CustomWin]$UserControl_1|#1/[PushButton]Learn more about working with BIM 360 Team Projects|$Button_LearnMore|#2/[StaticText]Learn more about working with BIM 360 Team Projects|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(LearnMoreAboutWorkingST);

            GetStartedPB = new PushButton()
            {
                Tag = "[CustomWin]$UserControl_1|#1/[PushButton]Get Started*|$Button_GetStarted|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(GetStartedPB);

            GetStartedST = new StaticText()
            {
                Tag = "[CustomWin]$UserControl_1|#1/[PushButton]Get Started*|$Button_GetStarted|#1/[StaticText]Get Started*|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(GetStartedST);

            Image1IMG = new Image()
            {
                Tag = "[CustomWin]$UserControl_1|#1/[Image]$Image_1|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Image1IMG);

            Image2IMG = new Image()
            {
                Tag = "[CustomWin]$UserControl_1|#1/[Image]$Image_2|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Image2IMG);

            Image3IMG = new Image()
            {
                Tag = "[CustomWin]$UserControl_1|#1/[Image]$Image_3|#3",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Image3IMG);

            oneChooseABIMST = new StaticText()
            {
                Tag = "[CustomWin]$UserControl_1|#1/[StaticText]1*|$TextBlock_2|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(oneChooseABIMST);

            twoUploadACopyST = new StaticText()
            {
                Tag = "[CustomWin]$UserControl_1|#1/[StaticText]2*|$TextBlock_3|#3",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(twoUploadACopyST);

            threeInviteYourTeamST = new StaticText()
            {
                Tag = "[CustomWin]$UserControl_1|#1/[StaticText]3*|$TextBlock_4|#4",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(threeInviteYourTeamST);
        }
    }
}
