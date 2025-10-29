// This file is auto-generated - do not hand edit this file.

using Autodesk.GUIHarness;
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{

    [UIElement(Tag = "[Window]Open Collaboration Project|$Window_1", Parent = typeof(MainWin), GUIType = GuiType.UIA)]
    public partial class OpenCollaborationProject : Autodesk.GUIHarness.AutoCAD.AcDialogBox
    {
        public  TitleBar OpenCollaborationProjectCTL;
        public  CustomWin SystemMenuBarWIN;
        public  MenuItem SystemMI;
        public  PushButton ClosePB;
        public  CustomWin CustomWinWIN;
        public  StaticText WeNeedYouToST;
        public  Image ImageIMG;
        public  StaticText WhyCollaborationProjectsAreST;
        public  PushButton LearnMoreAboutWorkingPB;
        public  StaticText LearnMoreAboutWorkingST;
        public  PushButton LoginPB;
        public  StaticText LoginST;

        partial void OnInitialize();

        public OpenCollaborationProject()
        {
            InitializeComponent();
            OnInitialize();
        }

        private void InitializeComponent()
        {

            OpenCollaborationProjectCTL = new TitleBar()
            {
                Tag = "[TitleBar]Open Collaboration Project|$TitleBar|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(OpenCollaborationProjectCTL);

            SystemMenuBarWIN = new CustomWin()
            {
                Tag = "[TitleBar]Open Collaboration Project|$TitleBar|#1/[CustomWin]System Menu Bar|$SystemMenuBar|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(SystemMenuBarWIN);

            SystemMI = new MenuItem()
            {
                Tag = "[TitleBar]Open Collaboration Project|$TitleBar|#1/[CustomWin]System Menu Bar|$SystemMenuBar|#1/[MenuItem]System|$Item 1|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(SystemMI);

            ClosePB = new PushButton()
            {
                Tag = "[TitleBar]Open Collaboration Project|$TitleBar|#1/[PushButton]Close|$Close|#1",
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

            WeNeedYouToST = new StaticText()
            {
                Tag = "[CustomWin]$UserControl_1|#1/[StaticText]We need you to login to your*|$TextBlock_1|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(WeNeedYouToST);

            ImageIMG = new Image()
            {
                Tag = "[CustomWin]$UserControl_1|#1/[Image]$Image_1|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ImageIMG);

            WhyCollaborationProjectsAreST = new StaticText()
            {
                Tag = "[CustomWin]$UserControl_1|#1/[StaticText]Why?*|$TextBlock_2|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(WhyCollaborationProjectsAreST);

            LearnMoreAboutWorkingPB = new PushButton()
            {
                Tag = "[CustomWin]$UserControl_1|#1/[PushButton]Learn more about working with BIM 360 Projects|$Button_LearnMore|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(LearnMoreAboutWorkingPB);

            LearnMoreAboutWorkingST = new StaticText()
            {
                Tag = "[CustomWin]$UserControl_1|#1/[PushButton]Learn more about working with BIM 360 Projects|$Button_LearnMore|#2/[StaticText]Learn more about working with BIM 360 Projects|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(LearnMoreAboutWorkingST);

            LoginPB = new PushButton()
            {
                Tag = "[CustomWin]$UserControl_1|#1/[PushButton]Login|$Button_GetStarted|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(LoginPB);

            LoginST = new StaticText()
            {
                Tag = "[CustomWin]$UserControl_1|#1/[PushButton]Login|$Button_GetStarted|#1/[StaticText]Login|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(LoginST);
        }
    }
}
