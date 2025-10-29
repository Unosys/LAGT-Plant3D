// This file is auto-generated - do not hand edit this file.

using Autodesk.GUIHarness;
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{

    [UIElement(Tag = "[Pane]$CreateProjectWizard", Parent = typeof(Plant3D))]
    public partial class ProjectSetupWizardFinishVaultDLG : Autodesk.GUIHarness.AutoCAD.AcDialogBox
    {
        public  Pane PanePANE;
        public  Pane NoteAllSymbolsWillPANE;
        public  CheckBox EditAdditionalProjectSettingsCK;
        public  StaticText TheWizardHasCollectedST;
        public  PushButton M_buttonFinish;
        public  PushButton CancelPB;
        public  PushButton BackPB;
        public  TitleBar ProjectSetupWizardPageCTL;
        public  CustomWin SystemMenuBarWIN;
        public  MenuItem SystemMI;
        public  PushButton ClosePB;

        partial void OnInitialize();

        public ProjectSetupWizardFinishVaultDLG()
        {
            InitializeComponent();
            OnInitialize();
        }

        private void InitializeComponent()
        {

            PanePANE = new Pane()
            {
                Tag = "[Pane]$m_wizardSetup|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(PanePANE);

            NoteAllSymbolsWillPANE = new Pane()
            {
                Tag = "[Pane]$m_wizardSetup|#1/[Pane]Note: All symbols will be drawn in inches*|$pageFinish|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(NoteAllSymbolsWillPANE);

            EditAdditionalProjectSettingsCK = new CheckBox()
            {
                Tag = "[Pane]$m_wizardSetup|#1/[Pane]Note: All symbols will be drawn in inches*|$pageFinish|#1/[CheckBox]Edit additional project settings after creating project|$m_checkboxLaunchSetupDlg|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(EditAdditionalProjectSettingsCK);

            TheWizardHasCollectedST = new StaticText()
            {
                Tag = "[Pane]$m_wizardSetup|#1/[Pane]Note: All symbols will be drawn in inches*|$pageFinish|#1/[StaticText]The wizard has collected enough information to create your project*|$m_finishPageLbl|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(TheWizardHasCollectedST);

            M_buttonFinish = new PushButton()
            {
                Tag = "[Pane]$m_wizardSetup|#1/[PushButton]Finish|$m_buttonFinish|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_buttonFinish);

            CancelPB = new PushButton()
            {
                Tag = "[Pane]$m_wizardSetup|#1/[PushButton]Cancel|$m_buttonCancel|#3",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(CancelPB);

            BackPB = new PushButton()
            {
                Tag = "[Pane]$m_wizardSetup|#1/[PushButton]<< Back|$m_buttonBack|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(BackPB);

            ProjectSetupWizardPageCTL = new TitleBar()
            {
                Tag = "[TitleBar]Project Setup Wizard (Page 6 of 6)|$TitleBar|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ProjectSetupWizardPageCTL);

            SystemMenuBarWIN = new CustomWin()
            {
                Tag = "[TitleBar]Project Setup Wizard (Page 6 of 6)|$TitleBar|#1/[CustomWin]System Menu Bar|$CreateProjectWizard|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(SystemMenuBarWIN);

            SystemMI = new MenuItem()
            {
                Tag = "[TitleBar]Project Setup Wizard (Page 6 of 6)|$TitleBar|#1/[CustomWin]System Menu Bar|$CreateProjectWizard|#1/[MenuItem]System|$Item 1|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(SystemMI);

            ClosePB = new PushButton()
            {
                Tag = "[TitleBar]Project Setup Wizard (Page 6 of 6)|$TitleBar|#1/[PushButton]Close|$Close|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ClosePB);
        }
    }
}
