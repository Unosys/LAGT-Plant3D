// This file is auto-generated - do not hand edit this file.

using Autodesk.GUIHarness;
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{

    [UIElement(Tag = "[Pane]Create Equipment|$EquBaseDlg", Parent = typeof(Plant3D), GUIType = GuiType.UIA)]
    public partial class EquipmentSaddleDLG : Autodesk.GUIHarness.AutoCAD.AcDialogBox
    {
        public  Pane EquipmentPANE;

        partial void OnInitialize();

        public EquipmentSaddleDLG()
        {
            InitializeComponent();
            OnInitialize();
        }

        private void InitializeComponent()
        {

            EquipmentPANE = new Pane()
            {
                Tag = "[Pane]$m_MainTableLayout|#1/[Pane]$m_WorkPanel|#1/[PageList]$m_Tabs|#1/[Pane]Equipment|$m_TabEquipment|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(EquipmentPANE);
        }
    }
}
