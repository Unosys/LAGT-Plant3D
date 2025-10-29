// This file is auto-generated - do not hand edit this file.

using Autodesk.GUIHarness;
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{

    [UIElement(Tag = "[Pane]Project Setup|$EditProjectSettingsDlg|#1", Parent = typeof(MainWin), GUIType = GuiType.UIA)]
    public partial class ProjectSetupPulledPipeBendDLG : Autodesk.GUIHarness.AutoCAD.AcDialogBox
    {
        public  PushButton CancelPB;

        partial void OnInitialize();

        public ProjectSetupPulledPipeBendDLG()
        {
            InitializeComponent();
            OnInitialize();
        }

        private void InitializeComponent()
        {

            CancelPB = new PushButton()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]#2/[PushButton]Cancel|$m_btnCancel|#3",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(CancelPB);
        }
    }
}
