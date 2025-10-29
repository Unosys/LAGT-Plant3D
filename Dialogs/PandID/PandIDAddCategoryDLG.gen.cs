// This file is auto-generated - do not hand edit this file.

using Autodesk.GUIHarness;
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{

    [UIElement(Tag = "[Pane]$AddListCategoryDlg", Parent = typeof(ProjectSetupProjectDetailsDLG))]
    public partial class PandIDAddCategoryDLG : Autodesk.GUIHarness.AutoCAD.AcDialogBox
    {
        public  PushButton M_btnCancel;
        public  PushButton M_btnOk;
        public  StaticText M_label;
        public  TextField M_picklistTextbox;

        partial void OnInitialize();

        public PandIDAddCategoryDLG()
        {
            InitializeComponent();
            OnInitialize();
        }

        private void InitializeComponent()
        {

            M_btnCancel = new PushButton()
            {
                Tag = "[PushButton]$m_btnCancel",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_btnCancel);

            M_btnOk = new PushButton()
            {
                Tag = "[PushButton]$m_btnOk",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_btnOk);

            M_label = new StaticText()
            {
                Tag = "[StaticText]$m_label",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_label);

            M_picklistTextbox = new TextField()
            {
                Tag = "[TextField]$m_picklistTextbox",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_picklistTextbox);
        }
    }
}
