// This file is auto-generated - do not hand edit this file.

using Autodesk.GUIHarness;
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{

    [UIElement(Tag = "[Pane]Add Row|$AddItemDlg")]
    public partial class P3DAddRowDLG : Pane
    {
        public  PushButton CancelPB;
        public  PushButton OKPB;
        public  TextField DescriptionTF;
        public  TextField ValueTF;

        partial void OnInitialize();

        public P3DAddRowDLG()
        {
            InitializeComponent();
            OnInitialize();
        }

        private void InitializeComponent()
        {

            CancelPB = new PushButton()
            {
                Tag = "[PushButton]Cancel|$m_btnCancel|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(CancelPB);

            OKPB = new PushButton()
            {
                Tag = "[PushButton]OK|$m_btnOk|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(OKPB);

            DescriptionTF = new TextField()
            {
                Tag = "[TextField]Description:|$m_textBoxDesc|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(DescriptionTF);

            ValueTF = new TextField()
            {
                Tag = "[TextField]Value:|$m_textBoxName|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ValueTF);
        }
    }
}
