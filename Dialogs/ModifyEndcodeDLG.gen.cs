// This file is auto-generated - do not hand edit this file.

using Autodesk.GUIHarness;
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{

    [UIElement(Tag = "[Pane]Modify Endcode|$AddAndModifyEndcodeDlg")]
    public partial class ModifyEndcodeDLG : Pane
    {
        public  PushButton BtnCancel;
        public  PushButton BtnOK;
        public  TextField EndcodeNameTF;
        public  MenuItem SystemMI;
        public  PushButton ClosePB;

        partial void OnInitialize();

        public ModifyEndcodeDLG()
        {
            InitializeComponent();
            OnInitialize();
        }

        private void InitializeComponent()
        {

            BtnCancel = new PushButton()
            {
                Tag = "[PushButton]Cancel|$btnCancel|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(BtnCancel);

            BtnOK = new PushButton()
            {
                Tag = "[PushButton]OK|$btnOK|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(BtnOK);

            EndcodeNameTF = new TextField()
            {
                Tag = "[TextField]Endcode name:|$txtboxEndcode|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(EndcodeNameTF);

            SystemMI = new MenuItem()
            {
                Tag = "[TitleBar]Modify Endcode|$TitleBar|#1/[CustomWin]System Menu Bar|$AddAndModifyEndcodeDlg|#1/[MenuItem]System|$Item 1|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(SystemMI);

            ClosePB = new PushButton()
            {
                Tag = "[TitleBar]Modify Endcode|$TitleBar|#1/[PushButton]Close|$Close|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ClosePB);
        }
    }
}
