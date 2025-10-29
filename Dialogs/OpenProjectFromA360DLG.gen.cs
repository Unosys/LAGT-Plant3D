// This file is auto-generated - do not hand edit this file.

using Autodesk.GUIHarness;
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{

    [UIElement(Tag = "[Pane]Open Project from A360|$frmOpenFromVault|#1", Parent = typeof(ProjManUndocked), GUIType = GuiType.UIA)]
    public partial class OpenProjectFromA360DLG : Pane
    {
        public  Link WhatIsAnA360LINK;
        public  PushButton OpenPB;
        public  ListView A360PlantProjectsLV;
        public  Header HeaderCTL;
        public  CustomWin ProjectNameWIN;
        public  ScrollBar A360PlantProjectsSB;
        public  PushButton CancelPB;
        public  StaticText A360PlantProjectsST;
        public  TitleBar OpenProjectFromA360CTL;
        public  CustomWin SystemMenuBarWIN;
        public  MenuItem SystemMI;
        public  PushButton ClosePB;

        partial void OnInitialize();

        public OpenProjectFromA360DLG()
        {
            InitializeComponent();
            OnInitialize();
        }

        private void InitializeComponent()
        {

            WhatIsAnA360LINK = new Link()
            {
                Tag = "[Link]What is an A360 project?|$m_A360ProjLink|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(WhatIsAnA360LINK);

            OpenPB = new PushButton()
            {
                Tag = "[PushButton]Open|$m_btnOpen|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(OpenPB);

            A360PlantProjectsLV = new ListView()
            {
                Tag = "[ListView]A360 Plant Projects|$m_listViewProjects|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(A360PlantProjectsLV);

            HeaderCTL = new Header()
            {
                Tag = "[ListView]A360 Plant Projects|$m_listViewProjects|#1/[Header]Header|$Header|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(HeaderCTL);

            ProjectNameWIN = new CustomWin()
            {
                Tag = "[ListView]A360 Plant Projects|$m_listViewProjects|#1/[Header]Header|$Header|#1/[CustomWin]Project Name|$HeaderItem 0|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ProjectNameWIN);

            A360PlantProjectsSB = new ScrollBar()
            {
                Tag = "[ListView]A360 Plant Projects|$m_listViewProjects|#1/[ScrollBar]A360 Plant Projects|$Horizontal ScrollBar|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(A360PlantProjectsSB);

            CancelPB = new PushButton()
            {
                Tag = "[PushButton]Cancel|$m_btnCancel|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(CancelPB);

            A360PlantProjectsST = new StaticText()
            {
                Tag = "[StaticText]A360 Plant Projects|$m_labelServer|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(A360PlantProjectsST);

            OpenProjectFromA360CTL = new TitleBar()
            {
                Tag = "[TitleBar]Open Project from A360|$TitleBar|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(OpenProjectFromA360CTL);

            SystemMenuBarWIN = new CustomWin()
            {
                Tag = "[TitleBar]Open Project from A360|$TitleBar|#1/[CustomWin]System Menu Bar|$frmOpenFromVault|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(SystemMenuBarWIN);

            SystemMI = new MenuItem()
            {
                Tag = "[TitleBar]Open Project from A360|$TitleBar|#1/[CustomWin]System Menu Bar|$frmOpenFromVault|#1/[MenuItem]System|$Item 1|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(SystemMI);

            ClosePB = new PushButton()
            {
                Tag = "[TitleBar]Open Project from A360|$TitleBar|#1/[PushButton]Close|$Close|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ClosePB);
        }
    }
}
