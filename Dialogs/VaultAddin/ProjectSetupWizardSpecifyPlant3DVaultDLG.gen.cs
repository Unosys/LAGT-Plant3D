// This file is auto-generated - do not hand edit this file.

using Autodesk.GUIHarness;
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{

    [UIElement(Tag = "[Pane]$CreateProjectWizard", Parent = typeof(Plant3D))]
    public partial class ProjectSetupWizardSpecifyPlant3DVaultDLG : Autodesk.GUIHarness.AutoCAD.AcDialogBox
    {
        public  GroupBox Page3DSettings;
        public  Pane PanePANE;
        public  Pane TheWizardHasCollectedPANE;
        public  StaticText SpecifyTheDirectoryWhereST;
        public  TextField SpecifyTheDirectoryWhereTF;
        public  PushButton PushButton1PB;
        public  TextField Plant3DModelDWGTF;
        public  PushButton PushButton2PB;
        public  PushButton PushButton3PB;
        public  TextField SpecSheetsDirectoryTF;
        public  StaticText OrthographicOutputDirectoryST;
        public  TextField OrthographicOutputDirectoryTF;
        public  PushButton PushButton4PB;
        public  StaticText SpecSheetsDirectoryST;
        public  StaticText Plant3DModelDWGST;
        public  PushButton CancelPB;
        public  PushButton M_buttonNext;
        public  PushButton BackPB;
        public  TitleBar ProjectSetupWizardPageCTL;
        public  CustomWin SystemMenuBarWIN;
        public  MenuItem SystemMI;
        public  PushButton ClosePB;

        partial void OnInitialize();

        public ProjectSetupWizardSpecifyPlant3DVaultDLG()
        {
            InitializeComponent();
            OnInitialize();
        }

        private void InitializeComponent()
        {

            Page3DSettings = new GroupBox()
            {
                Tag = "[GroupBox]$page3DSettings",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Page3DSettings);

            PanePANE = new Pane()
            {
                Tag = "[Pane]$m_wizardSetup|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(PanePANE);

            TheWizardHasCollectedPANE = new Pane()
            {
                Tag = "[Pane]$m_wizardSetup|#1/[Pane]The wizard has collected enough information to create your project*|$page3DSettings|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(TheWizardHasCollectedPANE);

            SpecifyTheDirectoryWhereST = new StaticText()
            {
                Tag = "[Pane]$m_wizardSetup|#1/[Pane]The wizard has collected enough information to create your project*|$page3DSettings|#1/[StaticText]Specify the directory where supporting files (such as spreadsheets or Word documents) are stored:|$m_relFilesLbl|#4",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(SpecifyTheDirectoryWhereST);

            SpecifyTheDirectoryWhereTF = new TextField()
            {
                Tag = "[Pane]$m_wizardSetup|#1/[Pane]The wizard has collected enough information to create your project*|$page3DSettings|#1/[TextField]Specify the directory where supporting files (such as spreadsheets or Word documents) are stored:|$m_editRelFilesDir|#4",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(SpecifyTheDirectoryWhereTF);

            PushButton1PB = new PushButton()
            {
                Tag = "[Pane]$m_wizardSetup|#1/[Pane]The wizard has collected enough information to create your project*|$page3DSettings|#1/[PushButton]**[1]|$m_btnRelFilesDir|#4",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(PushButton1PB);

            Plant3DModelDWGTF = new TextField()
            {
                Tag = "[Pane]$m_wizardSetup|#1/[Pane]The wizard has collected enough information to create your project*|$page3DSettings|#1/[TextField]Plant 3D model DWG file directory:|$m_edit3DDwgDir|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Plant3DModelDWGTF);

            PushButton2PB = new PushButton()
            {
                Tag = "[Pane]$m_wizardSetup|#1/[Pane]The wizard has collected enough information to create your project*|$page3DSettings|#1/[PushButton]**[2]|$m_btn3DDwgDir|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(PushButton2PB);

            PushButton3PB = new PushButton()
            {
                Tag = "[Pane]$m_wizardSetup|#1/[Pane]The wizard has collected enough information to create your project*|$page3DSettings|#1/[PushButton]**[3]|$m_btn3DSheetsDir|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(PushButton3PB);

            SpecSheetsDirectoryTF = new TextField()
            {
                Tag = "[Pane]$m_wizardSetup|#1/[Pane]The wizard has collected enough information to create your project*|$page3DSettings|#1/[TextField]Spec sheets directory:|$m_edit3DSheetsDir|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(SpecSheetsDirectoryTF);

            OrthographicOutputDirectoryST = new StaticText()
            {
                Tag = "[Pane]$m_wizardSetup|#1/[Pane]The wizard has collected enough information to create your project*|$page3DSettings|#1/[StaticText]Orthographic output directory:|$m_orthoDirLbl|#3",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(OrthographicOutputDirectoryST);

            OrthographicOutputDirectoryTF = new TextField()
            {
                Tag = "[Pane]$m_wizardSetup|#1/[Pane]The wizard has collected enough information to create your project*|$page3DSettings|#1/[TextField]Orthographic output directory:|$m_editOrthoDir|#3",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(OrthographicOutputDirectoryTF);

            PushButton4PB = new PushButton()
            {
                Tag = "[Pane]$m_wizardSetup|#1/[Pane]The wizard has collected enough information to create your project*|$page3DSettings|#1/[PushButton]**[4]|$m_btnOrthoDir|#3",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(PushButton4PB);

            SpecSheetsDirectoryST = new StaticText()
            {
                Tag = "[Pane]$m_wizardSetup|#1/[Pane]The wizard has collected enough information to create your project*|$page3DSettings|#1/[StaticText]Spec sheets directory:|$m_SpecSheetsDirLbl|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(SpecSheetsDirectoryST);

            Plant3DModelDWGST = new StaticText()
            {
                Tag = "[Pane]$m_wizardSetup|#1/[Pane]The wizard has collected enough information to create your project*|$page3DSettings|#1/[StaticText]Plant 3D model DWG file directory:|$m_PipingDwgsDirLbl|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Plant3DModelDWGST);

            CancelPB = new PushButton()
            {
                Tag = "[Pane]$m_wizardSetup|#1/[PushButton]Cancel|$m_buttonCancel|#3",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(CancelPB);

            M_buttonNext = new PushButton()
            {
                Tag = "[Pane]$m_wizardSetup|#1/[PushButton]Next|$m_buttonNext|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_buttonNext);

            BackPB = new PushButton()
            {
                Tag = "[Pane]$m_wizardSetup|#1/[PushButton]<< Back|$m_buttonBack|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(BackPB);

            ProjectSetupWizardPageCTL = new TitleBar()
            {
                Tag = "[TitleBar]Project Setup Wizard (Page 4 of 6)|$TitleBar|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ProjectSetupWizardPageCTL);

            SystemMenuBarWIN = new CustomWin()
            {
                Tag = "[TitleBar]Project Setup Wizard (Page 4 of 6)|$TitleBar|#1/[CustomWin]System Menu Bar|$CreateProjectWizard|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(SystemMenuBarWIN);

            SystemMI = new MenuItem()
            {
                Tag = "[TitleBar]Project Setup Wizard (Page 4 of 6)|$TitleBar|#1/[CustomWin]System Menu Bar|$CreateProjectWizard|#1/[MenuItem]System|$Item 1|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(SystemMI);

            ClosePB = new PushButton()
            {
                Tag = "[TitleBar]Project Setup Wizard (Page 4 of 6)|$TitleBar|#1/[PushButton]Close|$Close|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ClosePB);
        }
    }
}
