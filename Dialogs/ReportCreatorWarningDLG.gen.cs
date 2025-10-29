// This file is auto-generated - do not hand edit this file.

using Autodesk.GUIHarness;
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{

    [UIElement(Tag = "[MainWin]$MainForm", Parent = typeof(Desktop), GUIType = GuiType.UIA)]
    public partial class ReportCreatorWarningDLG : Autodesk.GUIHarness.MainWin
    {
        public  StaticText ClickToConvertSelectedST;

        partial void OnInitialize();

        public ReportCreatorWarningDLG()
        {
            InitializeComponent();
            OnInitialize();
        }

        private void InitializeComponent()
        {

            ClickToConvertSelectedST = new StaticText()
            {
                Tag = "[Pane]$m_mainTableLayoutPanel|#1/[StaticText]$Migrator_Description",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ClickToConvertSelectedST);
        }
    }
}
