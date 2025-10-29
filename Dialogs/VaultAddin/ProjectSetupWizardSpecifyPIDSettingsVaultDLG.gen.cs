// This file is auto-generated - do not hand edit this file.

using Autodesk.GUIHarness;
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{

    [UIElement(Tag = "[Pane]$CreateProjectWizard", Parent = typeof(Plant3D))]
    public partial class ProjectSetupWizardSpecifyPIDSettingsVaultDLG : Autodesk.GUIHarness.AutoCAD.AcDialogBox
    {
        public  Pane Pane1PANE;
        public  Pane Pane2PANE;
        public  StaticText NoteAllSymbolsWillST;
        public  ListBox SelectThePIDSymbologyLB;
        public  ListBoxItem PIPLBI;
        public  ListBoxItem ISALBI;
        public  StaticText SelectThePIDSymbologyST;
        public  PushButton PushButtonPB;
        public  TextField SpecifyTheDirectoryWhereTF;
        public  StaticText SpecifyTheDirectoryWhereST;
        public  PushButton M_buttonNext;
        public  PushButton CancelPB;
        public  PushButton BackPB;
        public  TitleBar ProjectSetupWizardPageCTL;
        public  CustomWin SystemMenuBarWIN;
        public  MenuItem SystemMI;
        public  PushButton ClosePB;

        partial void OnInitialize();

        public ProjectSetupWizardSpecifyPIDSettingsVaultDLG()
        {
            InitializeComponent();
            OnInitialize();
        }

        private void InitializeComponent()
        {

            Pane1PANE = new Pane()
            {
                Tag = "[Pane]$m_wizardSetup|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Pane1PANE);

            Pane2PANE = new Pane()
            {
                Tag = "[Pane]$m_wizardSetup|#1/[Pane]$pagePIDSettings|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Pane2PANE);

            NoteAllSymbolsWillST = new StaticText()
            {
                Tag = "[Pane]$m_wizardSetup|#1/[Pane]$pagePIDSettings|#1/[StaticText]Note: All symbols will be drawn in inches*|$m_NotesLbl|#3",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(NoteAllSymbolsWillST);

            SelectThePIDSymbologyLB = new ListBox()
            {
                Tag = "[Pane]$m_wizardSetup|#1/[Pane]$pagePIDSettings|#1/[ListBox]Select the PID symbology standard to be used:|$m_listboxTemplate|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(SelectThePIDSymbologyLB);

            PIPLBI = new ListBoxItem()
            {
                Tag = "[Pane]$m_wizardSetup|#1/[Pane]$pagePIDSettings|#1/[ListBox]Select the PID symbology standard to be used:|$m_listboxTemplate|#1/[ListBoxItem]PIP|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(PIPLBI);

            ISALBI = new ListBoxItem()
            {
                Tag = "[Pane]$m_wizardSetup|#1/[Pane]$pagePIDSettings|#1/[ListBox]Select the PID symbology standard to be used:|$m_listboxTemplate|#1/[ListBoxItem]ISA|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ISALBI);

            SelectThePIDSymbologyST = new StaticText()
            {
                Tag = "[Pane]$m_wizardSetup|#1/[Pane]$pagePIDSettings|#1/[StaticText]Select the P*|$m_PIDStandardsLbl|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(SelectThePIDSymbologyST);

            PushButtonPB = new PushButton()
            {
                Tag = "[Pane]$m_wizardSetup|#1/[Pane]$pagePIDSettings|#1/[PushButton]**|$m_btnPIDDwgDir|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(PushButtonPB);

            SpecifyTheDirectoryWhereTF = new TextField()
            {
                Tag = "[Pane]$m_wizardSetup|#1/[Pane]$pagePIDSettings|#1/[TextField]Specify the directory where PID drawings are stored:|$m_editPIDDwgDir|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(SpecifyTheDirectoryWhereTF);

            SpecifyTheDirectoryWhereST = new StaticText()
            {
                Tag = "[Pane]$m_wizardSetup|#1/[Pane]$pagePIDSettings|#1/[StaticText]Specify the directory where P*|$m_PIDDwgsDirLbl|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(SpecifyTheDirectoryWhereST);

            M_buttonNext = new PushButton()
            {
                Tag = "[Pane]$m_wizardSetup|#1/[PushButton]Next|$m_buttonNext|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_buttonNext);

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
                Tag = "[TitleBar]Project Setup Wizard (Page 3 of 6)|$TitleBar|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ProjectSetupWizardPageCTL);

            SystemMenuBarWIN = new CustomWin()
            {
                Tag = "[TitleBar]Project Setup Wizard (Page 3 of 6)|$TitleBar|#1/[CustomWin]System Menu Bar|$CreateProjectWizard|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(SystemMenuBarWIN);

            SystemMI = new MenuItem()
            {
                Tag = "[TitleBar]Project Setup Wizard (Page 3 of 6)|$TitleBar|#1/[CustomWin]System Menu Bar|$CreateProjectWizard|#1/[MenuItem]System|$Item 1|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(SystemMI);

            ClosePB = new PushButton()
            {
                Tag = "[TitleBar]Project Setup Wizard (Page 3 of 6)|$TitleBar|#1/[PushButton]Close|$Close|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ClosePB);
        }
    }
}
