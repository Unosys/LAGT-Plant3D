// This file is auto-generated - do not hand edit this file.

using Autodesk.GUIHarness;
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{

    [UIElement(Tag = "[Pane]Add Endcode|$AddAndModifyEndcodeDlg")]
    public partial class AddEndcodeDLG : Autodesk.GUIHarness.AutoCAD.AcDialogBox
    {
        public  PushButton CancelPB;
        public  PushButton BtnOK;
        public  TextField TxtboxDesc;
        public  StaticText LblDescription;
        public  TextField TxtboxEndcode;
        public  StaticText LblEndcode;
        public  TitleBar AddEndcodeCTL;
        public  CustomWin SystemMenuBarWIN;
        public  MenuItem SystemMI;
        public  PushButton ClosePB;

        partial void OnInitialize();

        public AddEndcodeDLG()
        {
            InitializeComponent();
            OnInitialize();
        }

        private void InitializeComponent()
        {

            CancelPB = new PushButton()
            {
                Tag = "[PushButton]Cancel|$btnCancel",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(CancelPB);

            BtnOK = new PushButton()
            {
                Tag = "[PushButton]OK|$btnOK",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(BtnOK);

            TxtboxDesc = new TextField()
            {
                Tag = "[TextField]Description:|$txtboxDesc|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(TxtboxDesc);

            LblDescription = new StaticText()
            {
                Tag = "[StaticText]Description:|$lblDescription|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(LblDescription);

            TxtboxEndcode = new TextField()
            {
                Tag = "[TextField]Endcode name:|$txtboxEndcode|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(TxtboxEndcode);

            LblEndcode = new StaticText()
            {
                Tag = "[StaticText]Endcode name:|$lblEndcode|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(LblEndcode);

            AddEndcodeCTL = new TitleBar()
            {
                Tag = "[TitleBar]Add Endcode|$TitleBar|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(AddEndcodeCTL);

            SystemMenuBarWIN = new CustomWin()
            {
                Tag = "[TitleBar]Add Endcode|$TitleBar|#1/[CustomWin]System Menu Bar|$AddAndModifyEndcodeDlg|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(SystemMenuBarWIN);

            SystemMI = new MenuItem()
            {
                Tag = "[TitleBar]Add Endcode|$TitleBar|#1/[CustomWin]System Menu Bar|$AddAndModifyEndcodeDlg|#1/[MenuItem]System|$Item 1|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(SystemMI);

            ClosePB = new PushButton()
            {
                Tag = "[TitleBar]Add Endcode|$TitleBar|#1/[PushButton]Close|$Close|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ClosePB);
        }
    }
}
