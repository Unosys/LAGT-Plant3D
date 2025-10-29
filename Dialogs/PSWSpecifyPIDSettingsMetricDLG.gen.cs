// This file is auto-generated - do not hand edit this file.

using Autodesk.GUIHarness;
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{

    [UIElement(Tag = "[DialogBox]Project Setup Wizard (Page 3 of 6)", Parent = typeof(Plant3D))]
    public partial class PSWSpecifyPIDSettingsMetricDLG : Autodesk.GUIHarness.AutoCAD.AcDialogBox
    {
        public  CustomWin M_wizardSetup;
        public  CustomWin PagePIDSettings;
        public  ListBox SelectTheStandardForPIDT1;
        public  StaticText SelectTheStandardForPIDT2;
        public  PushButton M_btnPIDDwgDir;
        public  TextField SpecifyTheDirectoryWhereP1;
        public  StaticText SpecifyTheDirectoryWhereP2;
        public  PushButton Cancel;
        public  PushButton Next;
        public  PushButton Back;

        partial void OnInitialize();

        public PSWSpecifyPIDSettingsMetricDLG()
        {
            InitializeComponent();
            OnInitialize();
        }

        private void InitializeComponent()
        {

            M_wizardSetup = new CustomWin()
            {
                Tag = "[CustomWin][Autodesk.ProcessPower.PnPProjectSetup.GenericWizard]$m_wizardSetup|[Autodesk.ProcessPower.PnPProjectSetup.GenericWizard]@(319,225)",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_wizardSetup);

            PagePIDSettings = new CustomWin()
            {
                Tag = "[CustomWin][Autodesk.ProcessPower.PnPProjectSetup.GenericWizardPage]$pagePIDSettings|[Autodesk.ProcessPower.PnPProjectSetup.GenericWizardPage]@(319,201)",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(PagePIDSettings);

            SelectTheStandardForPIDT1 = new ListBox()
            {
                Tag = "[ListBox]Select the standard for P&ID tool Palette content:|$m_listboxTemplate|@(263,216)",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(SelectTheStandardForPIDT1);

            SelectTheStandardForPIDT2 = new StaticText()
            {
                Tag = "[StaticText]Select the standard for P&ID tool Palette content:|$m_PIDStandardsLbl|@(141,161)",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(SelectTheStandardForPIDT2);

            M_btnPIDDwgDir = new PushButton()
            {
                Tag = "[PushButton]$m_btnPIDDwgDir|@(556,117)",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_btnPIDDwgDir);

            SpecifyTheDirectoryWhereP1 = new TextField()
            {
                Tag = "[TextField]Specify the directory where P&ID drawings are stored:|$m_editPIDDwgDir|@(261,116)",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(SpecifyTheDirectoryWhereP1);

            SpecifyTheDirectoryWhereP2 = new StaticText()
            {
                Tag = "[StaticText]Specify the directory where P&ID drawings are stored:|$m_PIDDwgsDirLbl|@(150,98)",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(SpecifyTheDirectoryWhereP2);

            Cancel = new PushButton()
            {
                Tag = "[PushButton]Cancel|$m_buttonCancel|@(591,425)",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Cancel);

            Next = new PushButton()
            {
                Tag = "[PushButton]Next >>|$m_buttonNext|@(507,425)",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Next);

            Back = new PushButton()
            {
                Tag = "[PushButton]<< Back|$m_buttonBack|@(431,425)",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Back);
        }
    }
}
