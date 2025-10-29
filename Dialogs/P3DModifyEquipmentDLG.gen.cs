// This file is auto-generated - do not hand edit this file.

using Autodesk.GUIHarness;
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{

    [UIElement(Tag = "[Pane]$EquBaseDlg", Parent = typeof(Plant3D))]
    public partial class P3DModifyEquipmentDLG : Autodesk.GUIHarness.AutoCAD.AcDialogBox
    {
        public  ListBoxItem CylinderLBI;
        public  PushButton M_BtnModCancel;
        public  PushButton AddTrimPB;
        public  Pane EquipmentPANE;
        public  Pane PropertiesPANE;

        partial void OnInitialize();

        public P3DModifyEquipmentDLG()
        {
            InitializeComponent();
            OnInitialize();
        }

        private void InitializeComponent()
        {

            CylinderLBI = new ListBoxItem()
            {
                Tag = "[Pane]$m_MainTableLayout|#1/[Pane]$m_WorkPanel|#1/[PageList]$m_Tabs|#1/[Window]Equipment|#1/[Pane]Equipment|$m_TabEquipment|#1/[Pane]$m_EquTableLayout|#1/[Pane]$m_EquPrimitiveListPanel|#2/[ListBox] Shapes|$m_EquPrimitiveList|#1/[ListBoxItem]Cylinder|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(CylinderLBI);

            M_BtnModCancel = new PushButton()
            {
                Tag = "[PushButton]Cancel|$m_BtnModCancel",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_BtnModCancel);

            AddTrimPB = new PushButton()
            {
                Tag = "[Pane]$m_MainTableLayout/[Pane]$m_WorkPanel/[PageList]$m_Tabs/[Window]Equipment|#1/[Pane]Equipment|$m_TabEquipment/[Pane]$m_EquTableLayout/[Pane]$m_EquPrimitiveListPanel/[PushButton]$m_EquPrimitiveAccessory",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(AddTrimPB);

            EquipmentPANE = new Pane()
            {
                Tag = "[Pane]$m_MainTableLayout|#1/[Pane]$m_WorkPanel|#1/[PageList]$m_Tabs|#1/[Window]Equipment|#1/[Pane]Equipment|$m_TabEquipment|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(EquipmentPANE);

            PropertiesPANE = new Pane()
            {
                Tag = "[Pane]$m_MainTableLayout|#1/[Pane]$m_WorkPanel|#1/[PageList]$m_Tabs|#1/[Pane]Properties|$m_TabData|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(PropertiesPANE);
        }
    }
}
