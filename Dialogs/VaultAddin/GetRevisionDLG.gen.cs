// This file is auto-generated - do not hand edit this file.

using Autodesk.GUIHarness;
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{

    [UIElement(Tag = "[DialogBox]$frmVaultGetRevision", Parent = typeof(Plant3D))]
    public partial class GetRevisionDLG : Autodesk.GUIHarness.AutoCAD.AcDialogBox
    {
        public  GroupBox M_BottomPanel;
        public  PushButton M_BtnCancel;
        public  PushButton M_BtnComment;
        public  PushButton M_BtnDownload;
        public  PushButton M_BtnDownloadAndCheckOut;
        public  ComboBox M_ComboBoxSelectRevision;
        public  StaticText M_LblSelectRevision;
        public  GroupBox M_TopPanel;

        partial void OnInitialize();

        public GetRevisionDLG()
        {
            InitializeComponent();
            OnInitialize();
        }

        private void InitializeComponent()
        {

            M_BottomPanel = new GroupBox()
            {
                Tag = "[GroupBox]$m_BottomPanel",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_BottomPanel);

            M_BtnCancel = new PushButton()
            {
                Tag = "[PushButton]$m_BtnCancel",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_BtnCancel);

            M_BtnComment = new PushButton()
            {
                Tag = "[PushButton]$m_BtnComment",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_BtnComment);

            M_BtnDownload = new PushButton()
            {
                Tag = "[PushButton]$m_BtnDownload",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_BtnDownload);

            M_BtnDownloadAndCheckOut = new PushButton()
            {
                Tag = "[PushButton]$m_BtnDownloadAndCheckOut",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_BtnDownloadAndCheckOut);

            M_ComboBoxSelectRevision = new ComboBox()
            {
                Tag = "[ComboBox]$m_ComboBoxSelectRevision",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_ComboBoxSelectRevision);

            M_LblSelectRevision = new StaticText()
            {
                Tag = "[StaticText]$m_LblSelectRevision",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_LblSelectRevision);

            M_TopPanel = new GroupBox()
            {
                Tag = "[GroupBox]$m_TopPanel",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_TopPanel);
        }
    }
}
