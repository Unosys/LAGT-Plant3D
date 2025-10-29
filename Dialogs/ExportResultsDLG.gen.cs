// This file is auto-generated - do not hand edit this file.

using Autodesk.GUIHarness;
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{

    [UIElement(Tag = "[Pane]Export results|$ExportResultsForm|#2", Parent = typeof(ReportCreatorDLG), GUIType = GuiType.UIA)]
    public partial class ExportResultsDLG : Pane
    {
        public  Pane PanePANE;
        public  ListBox ExportSucceededTheFollowingLB;
        public  ListBoxItem CUsersAdministratorW7EN1ENUx64VM7AppDataRoamingAutodeskAutodeskAutoCADPlant3DLBI;
        public  StaticText ExportSucceededTheFollowingST;
        public  PushButton M_okBtn;
        public  Pane ExportSucceededTheFollowingPANE;
        public  TitleBar ExportResultsCTL;
        public  PushButton MinimizePB;
        public  PushButton MaximizePB;
        public  PushButton ClosePB;

        partial void OnInitialize();

        public ExportResultsDLG()
        {
            InitializeComponent();
            OnInitialize();
        }

        private void InitializeComponent()
        {

            PanePANE = new Pane()
            {
                Tag = "[Pane]$m_mainTableLayoutPanel|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(PanePANE);

            ExportSucceededTheFollowingLB = new ListBox()
            {
                Tag = "[Pane]$m_mainTableLayoutPanel|#1/[ListBox]Export succeeded*|$m_exportsListBox|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ExportSucceededTheFollowingLB);

            CUsersAdministratorW7EN1ENUx64VM7AppDataRoamingAutodeskAutodeskAutoCADPlant3DLBI = new ListBoxItem()
            {
                Tag = "[Pane]$m_mainTableLayoutPanel|#1/[ListBox]Export succeeded*|$m_exportsListBox|#1/[ListBoxItem]C:*|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(CUsersAdministratorW7EN1ENUx64VM7AppDataRoamingAutodeskAutodeskAutoCADPlant3DLBI);

            ExportSucceededTheFollowingST = new StaticText()
            {
                Tag = "[Pane]$m_mainTableLayoutPanel|#1/[StaticText]Export succeeded*|$m_descriptionLbl|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ExportSucceededTheFollowingST);

            M_okBtn = new PushButton()
            {
                Tag = "[Pane]$m_mainTableLayoutPanel|#1/[PushButton]OK|$m_okBtn|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_okBtn);

            ExportSucceededTheFollowingPANE = new Pane()
            {
                Tag = "[Pane]$m_mainTableLayoutPanel|#1/[Pane]Export succeeded*|$m_iconPicBox|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ExportSucceededTheFollowingPANE);

            ExportResultsCTL = new TitleBar()
            {
                Tag = "[TitleBar]Export results|$TitleBar|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ExportResultsCTL);

            MinimizePB = new PushButton()
            {
                Tag = "[TitleBar]Export results|$TitleBar|#1/[PushButton]Minimize|$Minimize|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(MinimizePB);

            MaximizePB = new PushButton()
            {
                Tag = "[TitleBar]Export results|$TitleBar|#1/[PushButton]Maximize|$Maximize|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(MaximizePB);

            ClosePB = new PushButton()
            {
                Tag = "[TitleBar]Export results|$TitleBar|#1/[PushButton]Close|$Close|#3",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ClosePB);
        }
    }
}
