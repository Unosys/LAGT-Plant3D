// This file is auto-generated - do not hand edit this file.

using Autodesk.GUIHarness;
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{

    [UIElement(Tag = "[Pane]$CreateProjectWizard", Parent = typeof(Plant3D))]
    public partial class ProjectSetupWizardSpecifyUnitSettingsVaultDLG : Autodesk.GUIHarness.AutoCAD.AcDialogBox
    {
        public  GroupBox PageUnitSettings;
        public  Pane PanePANE;
        public  Pane SpecifyTheDirectoryWherePANE;
        public  Pane MostUnitsbasedPropertiesArePANE;
        public  StaticText ReportNominalDiametersOfST;
        public  RadioButton ReportNominalDiametersOf1RB;
        public  RadioButton ReportNominalDiametersOf2RB;
        public  StaticText MostUnitsbasedPropertiesAreST;
        public  RadioButton SpecifyTheBaseUnit1RB;
        public  StaticText AllUnitsbasedPropertiesAreST;
        public  RadioButton SpecifyTheBaseUnit2RB;
        public  StaticText SpecifyTheBaseUnitST;
        public  PushButton M_buttonNext;
        public  PushButton CancelPB;
        public  PushButton BackPB;
        public  TitleBar ProjectSetupWizardPageCTL;
        public  CustomWin SystemMenuBarWIN;
        public  MenuItem SystemMI;
        public  PushButton ClosePB;

        partial void OnInitialize();

        public ProjectSetupWizardSpecifyUnitSettingsVaultDLG()
        {
            InitializeComponent();
            OnInitialize();
        }

        private void InitializeComponent()
        {

            PageUnitSettings = new GroupBox()
            {
                Tag = "[GroupBox]$pageUnitSettings",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(PageUnitSettings);

            PanePANE = new Pane()
            {
                Tag = "[Pane]$m_wizardSetup|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(PanePANE);

            SpecifyTheDirectoryWherePANE = new Pane()
            {
                Tag = "[Pane]$m_wizardSetup|#1/[Pane]Specify the directory where supporting files (such as spreadsheets or Word documents) are stored:|$pageUnitSettings|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(SpecifyTheDirectoryWherePANE);

            MostUnitsbasedPropertiesArePANE = new Pane()
            {
                Tag = "[Pane]$m_wizardSetup|#1/[Pane]Specify the directory where supporting files (such as spreadsheets or Word documents) are stored:|$pageUnitSettings|#1/[Pane]Most units-based properties are reported in millimeters*|$m_mixedUnitsPnl|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(MostUnitsbasedPropertiesArePANE);

            ReportNominalDiametersOfST = new StaticText()
            {
                Tag = "[Pane]$m_wizardSetup|#1/[Pane]Specify the directory where supporting files (such as spreadsheets or Word documents) are stored:|$pageUnitSettings|#1/[Pane]Most units-based properties are reported in millimeters*|$m_mixedUnitsPnl|#1/[StaticText]Report nominal diameters of imperial content in:|$m_nomialDiaUnitslbl|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ReportNominalDiametersOfST);

            ReportNominalDiametersOf1RB = new RadioButton()
            {
                Tag = "[Pane]$m_wizardSetup|#1/[Pane]Specify the directory where supporting files (such as spreadsheets or Word documents) are stored:|$pageUnitSettings|#1/[Pane]Most units-based properties are reported in millimeters*|$m_mixedUnitsPnl|#1/[RadioButton]Report nominal diameters of imperial content in:[1]|$m_inchRadioBtn|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ReportNominalDiametersOf1RB);

            ReportNominalDiametersOf2RB = new RadioButton()
            {
                Tag = "[Pane]$m_wizardSetup|#1/[Pane]Specify the directory where supporting files (such as spreadsheets or Word documents) are stored:|$pageUnitSettings|#1/[Pane]Most units-based properties are reported in millimeters*|$m_mixedUnitsPnl|#1/[RadioButton]Report nominal diameters of imperial content in:[2]|$m_mmRadioBtn|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ReportNominalDiametersOf2RB);

            MostUnitsbasedPropertiesAreST = new StaticText()
            {
                Tag = "[Pane]$m_wizardSetup|#1/[Pane]Specify the directory where supporting files (such as spreadsheets or Word documents) are stored:|$pageUnitSettings|#1/[StaticText]Most units-based properties are reported in millimeters*|$m_metricLbl|#3",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(MostUnitsbasedPropertiesAreST);

            SpecifyTheBaseUnit1RB = new RadioButton()
            {
                Tag = "[Pane]$m_wizardSetup|#1/[Pane]Specify the directory where supporting files (such as spreadsheets or Word documents) are stored:|$pageUnitSettings|#1/[RadioButton]Specify the base unit for project drawings:[1]|$m_metricRadioBtn|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(SpecifyTheBaseUnit1RB);

            AllUnitsbasedPropertiesAreST = new StaticText()
            {
                Tag = "[Pane]$m_wizardSetup|#1/[Pane]Specify the directory where supporting files (such as spreadsheets or Word documents) are stored:|$pageUnitSettings|#1/[StaticText]All units-based properties are reported in inches*|$m_imperailLbl|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(AllUnitsbasedPropertiesAreST);

            SpecifyTheBaseUnit2RB = new RadioButton()
            {
                Tag = "[Pane]$m_wizardSetup|#1/[Pane]Specify the directory where supporting files (such as spreadsheets or Word documents) are stored:|$pageUnitSettings|#1/[RadioButton]Specify the base unit for project drawings:[2]|$m_imperialRadioBtn|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(SpecifyTheBaseUnit2RB);

            SpecifyTheBaseUnitST = new StaticText()
            {
                Tag = "[Pane]$m_wizardSetup|#1/[Pane]Specify the directory where supporting files (such as spreadsheets or Word documents) are stored:|$pageUnitSettings|#1/[StaticText]Specify the base unit for project drawings:|$m_unitsTitleLbl|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(SpecifyTheBaseUnitST);

            M_buttonNext = new PushButton()
            {
                Tag = "[Pane]$m_wizardSetup|#1/[PushButton]Next;|$m_buttonNext|#2",
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
                Tag = "[TitleBar]Project Setup Wizard (Page 2 of 6)|$TitleBar|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ProjectSetupWizardPageCTL);

            SystemMenuBarWIN = new CustomWin()
            {
                Tag = "[TitleBar]Project Setup Wizard (Page 2 of 6)|$TitleBar|#1/[CustomWin]System Menu Bar|$CreateProjectWizard|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(SystemMenuBarWIN);

            SystemMI = new MenuItem()
            {
                Tag = "[TitleBar]Project Setup Wizard (Page 2 of 6)|$TitleBar|#1/[CustomWin]System Menu Bar|$CreateProjectWizard|#1/[MenuItem]System|$Item 1|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(SystemMI);

            ClosePB = new PushButton()
            {
                Tag = "[TitleBar]Project Setup Wizard (Page 2 of 6)|$TitleBar|#1/[PushButton]Close|$Close|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ClosePB);
        }
    }
}
