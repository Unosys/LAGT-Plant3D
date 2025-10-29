// This file is auto-generated - do not hand edit this file.

using Autodesk.GUIHarness;
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{

    [UIElement(Tag = "[Pane]Project Setup Wizard (Page 2 of 6)|$CreateProjectWizard", Parent = typeof(Plant3D), GUIType = GuiType.UIA)]
    public partial class ProjectSetupWizardSpecifyUnitSettingsDLG : Pane
    {
        public  RadioButton M_inchRadioBtn;
        public  RadioButton M_mmRadioBtn;
        public  RadioButton M_metricRadioBtn;
        public  RadioButton M_imperialRadioBtn;
        public  PushButton M_buttonCancel;
        public  PushButton M_buttonNext;
        public  PushButton M_buttonBack;
        public  PushButton ClosePB;

        partial void OnInitialize();

        public ProjectSetupWizardSpecifyUnitSettingsDLG()
        {
            InitializeComponent();
            OnInitialize();
        }

        private void InitializeComponent()
        {

            M_inchRadioBtn = new RadioButton()
            {
                Tag = "[Pane]$m_wizardSetup/[Pane]Specify the directory where supporting files (such as spreadsheets or Word documents) are stored:|$pageUnitSettings/[Pane]Most units-based properties are reported in millimeters*|$m_mixedUnitsPnl/[RadioButton]Report nominal diameters of imperial content in:[1]|$m_inchRadioBtn",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_inchRadioBtn);

            M_mmRadioBtn = new RadioButton()
            {
                Tag = "[Pane]$m_wizardSetup/[Pane]Specify the directory where supporting files (such as spreadsheets or Word documents) are stored:|$pageUnitSettings/[Pane]Most units-based properties are reported in millimeters*|$m_mixedUnitsPnl/[RadioButton]Report nominal diameters of imperial content in:[2]|$m_mmRadioBtn",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_mmRadioBtn);

            M_metricRadioBtn = new RadioButton()
            {
                Tag = "[Pane]$m_wizardSetup/[Pane]Specify the directory where supporting files (such as spreadsheets or Word documents) are stored:|$pageUnitSettings/[RadioButton]Specify the base unit for project drawings:[1]|$m_metricRadioBtn",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_metricRadioBtn);

            M_imperialRadioBtn = new RadioButton()
            {
                Tag = "[Pane]$m_wizardSetup/[Pane]Specify the directory where supporting files (such as spreadsheets or Word documents) are stored:|$pageUnitSettings/[RadioButton]Specify the base unit for project drawings:[2]|$m_imperialRadioBtn",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_imperialRadioBtn);

            M_buttonCancel = new PushButton()
            {
                Tag = "[Pane]$m_wizardSetup/[PushButton]Cancel|$m_buttonCancel",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_buttonCancel);

            M_buttonNext = new PushButton()
            {
                Tag = "[Pane]$m_wizardSetup/[PushButton]Next >>|$m_buttonNext",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_buttonNext);

            M_buttonBack = new PushButton()
            {
                Tag = "[Pane]$m_wizardSetup/[PushButton]<< Back|$m_buttonBack",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_buttonBack);

            ClosePB = new PushButton()
            {
                Tag = "[TitleBar]Project Setup Wizard (Page 2 of 6)|$TitleBar/[PushButton]Close|$Close",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ClosePB);
        }
    }
}
