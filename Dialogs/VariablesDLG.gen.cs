// This file is auto-generated - do not hand edit this file.

using Autodesk.GUIHarness;
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{

    [UIElement(Tag = "[Pane]Variables|$VariablesInfoForm|#1", Parent = typeof(ReportConfigurationDLG), GUIType = GuiType.UIA)]
    public partial class VariablesDLG : Pane
    {
        public  PushButton M_okBtn;
        public  Pane PanePANE;
        public  StaticText PNPPDTDWGST;
        public  StaticText ProjectNameCreatedST;
        public  StaticText TheFollowingCharactersCantST;
        public  StaticText AvailableVariablesForExportST;
        public  TitleBar VariablesCTL;
        public  PushButton MinimizePB;
        public  PushButton MaximizePB;
        public  PushButton ClosePB;

        partial void OnInitialize();

        public VariablesDLG()
        {
            InitializeComponent();
            OnInitialize();
        }

        private void InitializeComponent()
        {

            M_okBtn = new PushButton()
            {
                Tag = "[PushButton]OK|$m_okBtn|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_okBtn);

            PanePANE = new Pane()
            {
                Tag = "[Pane]$m_tableLayoutPanel|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(PanePANE);

            PNPPDTDWGST = new StaticText()
            {
                Tag = "[Pane]$m_tableLayoutPanel|#1/[StaticText]*PN*|$m_varsLbl|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(PNPPDTDWGST);

            ProjectNameCreatedST = new StaticText()
            {
                Tag = "[Pane]$m_tableLayoutPanel|#1/[StaticText]= Project name created by Autodesk AutoCAD P*|$m_varsDescripLbl|#3",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ProjectNameCreatedST);

            TheFollowingCharactersCantST = new StaticText()
            {
                Tag = "[Pane]$m_tableLayoutPanel|#1/[StaticText]The following characters can?t be used: *|$m_helpLbl|#4",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(TheFollowingCharactersCantST);

            AvailableVariablesForExportST = new StaticText()
            {
                Tag = "[Pane]$m_tableLayoutPanel|#1/[StaticText]Available variables for ?Export file path? are:|$m_helpIntroductionLbl|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(AvailableVariablesForExportST);

            VariablesCTL = new TitleBar()
            {
                Tag = "[TitleBar]Variables|$TitleBar|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(VariablesCTL);

            MinimizePB = new PushButton()
            {
                Tag = "[TitleBar]Variables|$TitleBar|#1/[PushButton]Minimize|$Minimize|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(MinimizePB);

            MaximizePB = new PushButton()
            {
                Tag = "[TitleBar]Variables|$TitleBar|#1/[PushButton]Maximize|$Maximize|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(MaximizePB);

            ClosePB = new PushButton()
            {
                Tag = "[TitleBar]Variables|$TitleBar|#1/[PushButton]Close|$Close|#3",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ClosePB);
        }
    }
}
