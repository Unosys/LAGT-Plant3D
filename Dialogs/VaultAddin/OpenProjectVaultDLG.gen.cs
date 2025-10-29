// This file is auto-generated - do not hand edit this file.

using Autodesk.GUIHarness;
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{

    [UIElement(Tag = "[DialogBox]$frmOpenFromVault", Parent = typeof(Plant3D))]
    public partial class OpenProjectVaultDLG : Autodesk.GUIHarness.AutoCAD.AcDialogBox
    {
        public  ScrollBar HorizontalScrollBar;
        public  PushButton M_btnCancel;
        public  PushButton M_btnChange;
        public  PushButton M_btnOpen;
        public  StaticText M_labelLocalWS;
        public  StaticText M_labelServer;
        public  ListView M_listViewProjects;
        public  Header M_listViewProjectsHeader;
        public  TextField M_textBoxLocalWS;

        partial void OnInitialize();

        public OpenProjectVaultDLG()
        {
            InitializeComponent();
            OnInitialize();
        }

        private void InitializeComponent()
        {

            HorizontalScrollBar = new ScrollBar()
            {
                Tag = "[ScrollBar]$m_listViewProjects",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(HorizontalScrollBar);

            M_btnCancel = new PushButton()
            {
                Tag = "[PushButton]$m_btnCancel",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_btnCancel);

            M_btnChange = new PushButton()
            {
                Tag = "[PushButton]$m_btnChange",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_btnChange);

            M_btnOpen = new PushButton()
            {
                Tag = "[PushButton]$m_btnOpen",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_btnOpen);

            M_labelLocalWS = new StaticText()
            {
                Tag = "[StaticText]$m_labelLocalWS",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_labelLocalWS);

            M_labelServer = new StaticText()
            {
                Tag = "[StaticText]$m_labelServer",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_labelServer);

            M_listViewProjects = new ListView()
            {
                Tag = "[ListViewEx]$m_listViewProjects",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_listViewProjects);

            M_listViewProjectsHeader = new Header()
            {
                Tag = "[HeaderEx]$m_listViewProjects",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_listViewProjectsHeader);

            M_textBoxLocalWS = new TextField()
            {
                Tag = "[TextField]$m_textBoxLocalWS",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_textBoxLocalWS);
        }
    }
}
