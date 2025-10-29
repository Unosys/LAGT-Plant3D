// This file is auto-generated - do not hand edit this file.

using Autodesk.GUIHarness;
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{

    [UIElement(Tag = "[Pane]$frmVaultDataMerged", Parent = typeof(Plant3D))]
    public partial class ProjectDataMergedVaultDLG : Autodesk.GUIHarness.AutoCAD.AcDialogBox
    {
        public  PushButton BtnHelp;
        public  PushButton BtnOk;
        public  StaticText M_LblIssuesFound;
        public  StaticText M_LblMainInstruction;
        public  Link M_LinkLblLog;
        public  TextField M_TextBoxIssuesFound;
        public  ScrollBar VerticalScrollBar;

        partial void OnInitialize();

        public ProjectDataMergedVaultDLG()
        {
            InitializeComponent();
            OnInitialize();
        }

        private void InitializeComponent()
        {

            BtnHelp = new PushButton()
            {
                Tag = "[PushButton]$btnHelp",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(BtnHelp);

            BtnOk = new PushButton()
            {
                Tag = "[PushButton]$btnOk",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(BtnOk);

            M_LblIssuesFound = new StaticText()
            {
                Tag = "[StaticText]$m_LblIssuesFound",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_LblIssuesFound);

            M_LblMainInstruction = new StaticText()
            {
                Tag = "[StaticText]$m_LblMainInstruction",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_LblMainInstruction);

            M_LinkLblLog = new Link()
            {
                Tag = "[Link]$m_LinkLblLog",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_LinkLblLog);

            M_TextBoxIssuesFound = new TextField()
            {
                Tag = "[TextField]$m_TextBoxIssuesFound",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_TextBoxIssuesFound);

            VerticalScrollBar = new ScrollBar()
            {
                Tag = "[ScrollBar]$m_TextBoxIssuesFound",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(VerticalScrollBar);
        }
    }
}
