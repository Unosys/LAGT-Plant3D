// This file is auto-generated - do not hand edit this file.

using Autodesk.GUIHarness;
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{

    [UIElement(Tag = "[DialogBox]ExceptionInPnp3dpipeuiDllADLG", Parent = typeof(Plant3D))]
    public partial class ExceptionInPnp3dpipeuiDllADLG : Autodesk.GUIHarness.AutoCAD.AcDialogBox
    {
        public  PushButton OK;
        public  CustomWin Icon1;
        public  StaticText UnhandledExceptionC0000005;

        partial void OnInitialize();

        public ExceptionInPnp3dpipeuiDllADLG()
        {
            InitializeComponent();
            OnInitialize();
        }

        private void InitializeComponent()
        {

            OK = new PushButton()
            {
                Tag = "[PushButton]OK|$2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(OK);

            Icon1 = new CustomWin()
            {
                Tag = "[Icon]$20",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Icon1);

            UnhandledExceptionC0000005 = new StaticText()
            {
                Tag = "[StaticText]Unhandled Exception C0000005 (Access Violation Reading 0x14a4) at address 4E00B6h|$65535",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(UnhandledExceptionC0000005);
        }
    }
}
