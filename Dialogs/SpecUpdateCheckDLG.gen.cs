// This file is auto-generated - do not hand edit this file.

using Autodesk.GUIHarness;
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{

    [UIElement(Tag = "[Pane]$SpecUpdateSettingDlg", Parent = typeof(MainWin), GUIType = GuiType.UIA)]
    public partial class SpecUpdateCheckDLG : Pane
    {
        public  PushButton M_btnClose;
        public  PopupList M_comboBoxHoursPL;

        partial void OnInitialize();

        public SpecUpdateCheckDLG()
        {
            InitializeComponent();
            OnInitialize();
        }

        private void InitializeComponent()
        {

            M_btnClose = new PushButton()
            {
                Tag = "[PushButton]$m_btnClose",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_btnClose);

            M_comboBoxHoursPL = new PopupList()
            {
                Tag = "[GroupBox]$groupBox1|#1/[PopupList]$m_comboBoxHours",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_comboBoxHoursPL);
        }
    }
}
