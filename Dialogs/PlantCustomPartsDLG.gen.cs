// This file is auto-generated - do not hand edit this file.

using Autodesk.GUIHarness;
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{

    [UIElement(Tag = "[CustomWin]#3", Parent = typeof(Plant3D), GUIType = GuiType.WIN32)]
    public partial class PlantCustomPartsDLG : Autodesk.GUIHarness.AutoCAD.AcDialogBox
    {
        public  Window AutoCADBlockWIN;
        public  PushButton OperatorPB;

        partial void OnInitialize();

        public PlantCustomPartsDLG()
        {
            InitializeComponent();
            OnInitialize();
        }

        private void InitializeComponent()
        {

            AutoCADBlockWIN = new Window()
            {
                Tag = "[CustomWin]$59423|#1/[CustomWin]$16722|#1/[CustomWin]Custom Parts Builder|$11|#1/[Pane]$ControlAxSourcingSite|#1/[Pane]#1/[CustomWin]#1/[CustomWin]$Window_1|#1/[GroupBox]Graphics|$dgb_GeometryType|#1/[PageList]$dtc_GeometryType|#1/[Window]AutoCAD Block|$dti_GeometryType_Block|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(AutoCADBlockWIN);

            OperatorPB = new PushButton()
            {
                Tag = "[CustomWin]$59423|#1/[CustomWin]$16722|#1/[CustomWin]$15|#1/[Pane]$ControlAxSourcingSite|#1/[Pane]#1/[CustomWin]#1/[CustomWin]$Window_1|#1/[Pane]$dsv_MiddleRight|#1/[Pane]$ScrollViewer_9|#4/[PushButton]$dbt_pp_ValveOperator|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(OperatorPB);
        }
    }
}
