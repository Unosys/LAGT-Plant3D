// This file is auto-generated - do not hand edit this file.

using Autodesk.GUIHarness;
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{

    [UIElement(Tag = "[DialogBox]Equipment - Congruent Nozzle Ports", Parent = typeof(Plant3D), GUIType = GuiType.WIN32)]
    public partial class EquipmentCongruentNozzlePortsTaskDLG : Autodesk.GUIHarness.AutoCAD.AcDialogBox
    {
        public  PushButton ShowDetailsPB;
        public  CheckBox DoNotShowThisCK;
        public  PushButton ClosePB;

        partial void OnInitialize();

        public EquipmentCongruentNozzlePortsTaskDLG()
        {
            InitializeComponent();
            OnInitialize();
        }

        private void InitializeComponent()
        {

            ShowDetailsPB = new PushButton()
            {
                Tag = "[Pane]Equipment - Congruent Nozzle Ports|$Window/[PushButton]Show details|$ExpandoButton",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ShowDetailsPB);

            DoNotShowThisCK = new CheckBox()
            {
                Tag = "[Pane]Equipment - Congruent Nozzle Ports|$Window/[CheckBox]Do not show this message again|$VerificationCheckBox",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(DoNotShowThisCK);

            ClosePB = new PushButton()
            {
                Tag = "[Pane]Equipment - Congruent Nozzle Ports|$Window/[PushButton]Close|$CommandButton_8",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ClosePB);
        }
    }
}
