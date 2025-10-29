// This file is auto-generated - do not hand edit this file.

using Autodesk.GUIHarness;
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{

    [UIElement(Tag = "[Pane]CheckBox|#1", Parent = typeof(Pane))]
    public partial class CheckBoxTasksDLG : Pane
    {
        public  CustomWin DevExpressXtraPrintingNative;

        partial void OnInitialize();

        public CheckBoxTasksDLG()
        {
            InitializeComponent();
            OnInitialize();
        }

        private void InitializeComponent()
        {

            DevExpressXtraPrintingNative = new CustomWin()
            {
                Tag = "[CustomWin]$DevExpress.XtraPrinting.Native.Lines.EditorPropertyLine+DropDownEdit",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(DevExpressXtraPrintingNative);
        }
    }
}
