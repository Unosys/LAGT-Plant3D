// This file is auto-generated - do not hand edit this file.

using Autodesk.GUIHarness;
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{

    [UIElement(Tag = "[Pane]Create Equipment|$EquBaseDlg|#2", Parent = typeof(Plant3D), GUIType = GuiType.UIA)]
    public partial class EquipmentLugDLG : Pane
    {
        public  PushButton VesselVerticalVesselPB;
        public  Window EquipmentWIN;
        public  Pane EquipmentPANE;
        public  PushButton TemplatesPB;
        public  PushButton CreatePB;
        public  PushButton CancelPB;

        partial void OnInitialize();

        public EquipmentLugDLG()
        {
            InitializeComponent();
            OnInitialize();
        }

        private void InitializeComponent()
        {

            VesselVerticalVesselPB = new PushButton()
            {
                Tag = "[Pane]$m_MainTableLayout|#1/[Pane]$m_WorkPanel|#1/[PushButton]Vessel - Vertical Vessel|$m_TypeSel|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(VesselVerticalVesselPB);

            EquipmentWIN = new Window()
            {
                Tag = "[Pane]$m_MainTableLayout|#1/[Pane]$m_WorkPanel|#1/[PageList]$m_Tabs|#1/[Window]Equipment|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(EquipmentWIN);

            EquipmentPANE = new Pane()
            {
                Tag = "[Pane]$m_MainTableLayout|#1/[Pane]$m_WorkPanel|#1/[PageList]$m_Tabs|#1/[Window]Equipment|#1/[Pane]Equipment|$m_TabEquipment|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(EquipmentPANE);

            TemplatesPB = new PushButton()
            {
                Tag = "[PushButton]Templates|$m_BtnSnapshot|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(TemplatesPB);

            CreatePB = new PushButton()
            {
                Tag = "[PushButton]Create|$m_BtnCreCreate|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(CreatePB);

            CancelPB = new PushButton()
            {
                Tag = "[PushButton]Cancel|$m_BtnCreCancel|#3",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(CancelPB);
        }
    }
}
