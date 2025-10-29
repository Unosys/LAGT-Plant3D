// This file is auto-generated - do not hand edit this file.

using Autodesk.GUIHarness;
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{

    [UIElement(Tag = "[DialogBox]$DwgOffLineEditsNotification", Parent = typeof(Plant3D))]
    public partial class ProjectDataMergedDLG : Autodesk.GUIHarness.AutoCAD.AcDialogBox
    {
        public  PushButton BtnHelp;
        public  PushButton BtnOk;
        public  Link LblViewLink;
        public  StaticText M_LblContent;

        partial void OnInitialize();

        public ProjectDataMergedDLG()
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

            LblViewLink = new Link()
            {
                Tag = "[Link]$lblViewLink",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(LblViewLink);

            M_LblContent = new StaticText()
            {
                Tag = "[StaticText]$m_LblContent",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_LblContent);
        }
    }
}
