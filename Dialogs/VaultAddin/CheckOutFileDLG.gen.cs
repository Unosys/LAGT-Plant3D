// This file is auto-generated - do not hand edit this file.

using Autodesk.GUIHarness;
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{

    [UIElement(Tag = "[DialogBox]$frmVaultCheckoutFile", Parent = typeof(Plant3D))]
    public partial class CheckOutFileDLG : Autodesk.GUIHarness.AutoCAD.AcDialogBox
    {
        public  PushButton M_btnHelp;
        public  PushButton M_cancelBtn;
        public  PushButton M_commentBtn;
        public  CheckBox M_downloadLatestCB;
        public  PushButton M_okBtn;
        public  GroupBox Panel1;
        public  GroupBox Panel2;

        partial void OnInitialize();

        public CheckOutFileDLG()
        {
            InitializeComponent();
            OnInitialize();
        }

        private void InitializeComponent()
        {

            M_btnHelp = new PushButton()
            {
                Tag = "[PushButton]$m_btnHelp",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_btnHelp);

            M_cancelBtn = new PushButton()
            {
                Tag = "[PushButton]$m_cancelBtn",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_cancelBtn);

            M_commentBtn = new PushButton()
            {
                Tag = "[PushButton]$m_commentBtn",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_commentBtn);

            M_downloadLatestCB = new CheckBox()
            {
                Tag = "[CheckBox]$m_downloadLatestCB",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_downloadLatestCB);

            M_okBtn = new PushButton()
            {
                Tag = "[PushButton]$m_okBtn",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_okBtn);

            Panel1 = new GroupBox()
            {
                Tag = "[GroupBox]$panel1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Panel1);

            Panel2 = new GroupBox()
            {
                Tag = "[GroupBox]$panel2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Panel2);
        }
    }
}
