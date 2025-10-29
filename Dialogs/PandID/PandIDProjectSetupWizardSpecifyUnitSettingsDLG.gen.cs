// This file is auto-generated - do not hand edit this file.

using Autodesk.GUIHarness;
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{

    [UIElement(Tag = "[DialogBox]$CreateProjectWizard", Parent = typeof(Plant3D))]
    public partial class PandIDProjectSetupWizardSpecifyUnitSettingsDLG : Autodesk.GUIHarness.AutoCAD.AcDialogBox
    {
        public  PushButton M_buttonBack;
        public  PushButton M_buttonCancel;
        public  PushButton M_buttonNext;
        public  StaticText M_imperailLbl;
        public  RadioButton M_imperialRadioBtn;
        public  RadioButton M_inchRadioBtn;
        public  StaticText M_metricLbl;
        public  RadioButton M_metricRadioBtn;
        public  GroupBox M_mixedUnitsPnl;
        public  RadioButton M_mmRadioBtn;
        public  StaticText M_nomialDiaUnitslbl;
        public  StaticText M_unitsTitleLbl;
        public  CustomWin M_wizardSetup;
        public  GroupBox PageUnitSettings;

        partial void OnInitialize();

        public PandIDProjectSetupWizardSpecifyUnitSettingsDLG()
        {
            InitializeComponent();
            OnInitialize();
        }

        private void InitializeComponent()
        {

            M_buttonBack = new PushButton()
            {
                Tag = "[PushButton]$m_buttonBack",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_buttonBack);

            M_buttonCancel = new PushButton()
            {
                Tag = "[PushButton]$m_buttonCancel",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_buttonCancel);

            M_buttonNext = new PushButton()
            {
                Tag = "[Pane]$m_wizardSetup|#1/[PushButton]$m_buttonNext|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_buttonNext);

            M_imperailLbl = new StaticText()
            {
                Tag = "[StaticText]$m_imperailLbl",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_imperailLbl);

            M_imperialRadioBtn = new RadioButton()
            {
                Tag = "[RadioButton]$m_imperialRadioBtn",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_imperialRadioBtn);

            M_inchRadioBtn = new RadioButton()
            {
                Tag = "[RadioButton]$m_inchRadioBtn",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_inchRadioBtn);

            M_metricLbl = new StaticText()
            {
                Tag = "[StaticText]$m_metricLbl",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_metricLbl);

            M_metricRadioBtn = new RadioButton()
            {
                Tag = "[Pane]$m_wizardSetup|#1/[Pane]Specify the directory where supporting files (such as spreadsheets or Word documents) are stored:|$pageUnitSettings|#1/[RadioButton]Specify the base unit for project drawings:[1]|$m_metricRadioBtn|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_metricRadioBtn);

            M_mixedUnitsPnl = new GroupBox()
            {
                Tag = "[GroupBox]$m_mixedUnitsPnl",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_mixedUnitsPnl);

            M_mmRadioBtn = new RadioButton()
            {
                Tag = "[RadioButton]$m_mmRadioBtn",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_mmRadioBtn);

            M_nomialDiaUnitslbl = new StaticText()
            {
                Tag = "[StaticText]$m_nomialDiaUnitslbl",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_nomialDiaUnitslbl);

            M_unitsTitleLbl = new StaticText()
            {
                Tag = "[StaticText]$m_unitsTitleLbl",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_unitsTitleLbl);

            M_wizardSetup = new CustomWin()
            {
                Tag = "[CustomWin]$m_wizardSetup",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_wizardSetup);

            PageUnitSettings = new GroupBox()
            {
                Tag = "[GroupBox]$pageUnitSettings",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(PageUnitSettings);
        }
    }
}
