// This file is auto-generated - do not hand edit this file.

using Autodesk.GUIHarness;
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{

    [UIElement(Tag = "[Pane]$PnPMapPropertyValuesDlg")]
    public partial class P3DMapPropertyValuesDLG : Pane
    {
        public  StaticText Label1;
        public  PushButton M_btCancel;
        public  PushButton M_btHelp;
        public  PushButton M_btOK;
        public  Table M_dataGridView;

        partial void OnInitialize();

        public P3DMapPropertyValuesDLG()
        {
            InitializeComponent();
            OnInitialize();
        }

        private void InitializeComponent()
        {

            Label1 = new StaticText()
            {
                Tag = "[StaticText]$label1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Label1);

            M_btCancel = new PushButton()
            {
                Tag = "[PushButton]$m_btCancel",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_btCancel);

            M_btHelp = new PushButton()
            {
                Tag = "[PushButton]$m_btHelp",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_btHelp);

            M_btOK = new PushButton()
            {
                Tag = "[PushButton]$m_btOK",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_btOK);

            M_dataGridView = new Table()
            {
                Tag = "[Table]$m_dataGridView",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_dataGridView);
        }
    }
}
