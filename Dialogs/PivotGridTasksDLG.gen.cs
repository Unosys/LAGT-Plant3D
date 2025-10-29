// This file is auto-generated - do not hand edit this file.

using Autodesk.GUIHarness;
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{

    [UIElement(Tag = "[Pane]PivotGridTasksDLG|#1", Parent = typeof(Pane))]
    public partial class PivotGridTasksDLG : Pane
    {
        public  CustomWin RunDesigner;
        public  CustomWin DevExpressXtraPrintingNative;

        partial void OnInitialize();

        public PivotGridTasksDLG()
        {
            InitializeComponent();
            OnInitialize();
        }

        private void InitializeComponent()
        {

            RunDesigner = new CustomWin()
            {
                Tag = "[CustomWin]$DevExpress.XtraReports.Design.LinkLine",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(RunDesigner);

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
