// This file is auto-generated - do not hand edit this file.

using Autodesk.GUIHarness;
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{

    [UIElement(Tag = "[Pane]$NewAutomationSchemeDlg")]
    public partial class NewAutomationSchemeDLG : Pane
    {
        public  PushButton CancelPB;
        public  PushButton OKPB;
        public  TextField NameTF;

        partial void OnInitialize();

        public NewAutomationSchemeDLG()
        {
            InitializeComponent();
            OnInitialize();
        }

        private void InitializeComponent()
        {

            CancelPB = new PushButton()
            {
                Tag = "[PushButton]Cancel|$m_bt_Cancel|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(CancelPB);

            OKPB = new PushButton()
            {
                Tag = "[PushButton]OK|$m_bt_OK|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(OKPB);

            NameTF = new TextField()
            {
                Tag = "[TextField]Name:|$m_tb_name|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(NameTF);
        }
    }
}
