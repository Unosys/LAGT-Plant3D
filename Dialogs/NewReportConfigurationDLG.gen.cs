// This file is auto-generated - do not hand edit this file.

using Autodesk.GUIHarness;
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{

    [UIElement(Tag = "[Pane]New Report Configuration|$NewReportForm|#2", Parent = typeof(ReportCreatorDLG), GUIType = GuiType.UIA)]
    public partial class NewReportConfigurationDLG : Pane
    {
        public  PushButton M_cancelBtn;
        public  Pane M_mainTableLayoutPanel;
        public  RadioButton M_blankReportRadioBtn;
        public  RadioButton M_templateReportRadioBtn;
        public  PopupList M_repConfigCmbBox;
        public  PushButton DropDownButtonPB;
        public  StaticText M_chooseReportTypeLbl;
        public  PushButton M_okBtn;
        public  TitleBar NewReportConfigurationCTL;
        public  PushButton ClosePB;

        partial void OnInitialize();

        public NewReportConfigurationDLG()
        {
            InitializeComponent();
            OnInitialize();
        }

        private void InitializeComponent()
        {

            M_cancelBtn = new PushButton()
            {
                Tag = "[PushButton]Cancel|$m_cancelBtn|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_cancelBtn);

            M_mainTableLayoutPanel = new Pane()
            {
                Tag = "[Pane]$m_mainTableLayoutPanel|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_mainTableLayoutPanel);

            M_blankReportRadioBtn = new RadioButton()
            {
                Tag = "[Pane]$m_mainTableLayoutPanel|#1/[RadioButton]Choose report type:[1]|$m_blankReportRadioBtn|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_blankReportRadioBtn);

            M_templateReportRadioBtn = new RadioButton()
            {
                Tag = "[Pane]$m_mainTableLayoutPanel|#1/[RadioButton]Choose report type:[2]|$m_templateReportRadioBtn|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_templateReportRadioBtn);

            M_repConfigCmbBox = new PopupList()
            {
                Tag = "[Pane]$m_mainTableLayoutPanel|#1/[PopupList]Choose report type:|$m_repConfigCmbBox|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_repConfigCmbBox);

            DropDownButtonPB = new PushButton()
            {
                Tag = "[Pane]$m_mainTableLayoutPanel|#1/[PopupList]Choose report type:|$m_repConfigCmbBox|#1/[PushButton]Drop Down Button|$DropDown|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(DropDownButtonPB);

            M_chooseReportTypeLbl = new StaticText()
            {
                Tag = "[Pane]$m_mainTableLayoutPanel|#1/[StaticText]Choose report type:|$m_chooseReportTypeLbl|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_chooseReportTypeLbl);

            M_okBtn = new PushButton()
            {
                Tag = "[PushButton]OK|$m_okBtn|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_okBtn);

            NewReportConfigurationCTL = new TitleBar()
            {
                Tag = "[TitleBar]New Report Configuration|$TitleBar|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(NewReportConfigurationCTL);

            ClosePB = new PushButton()
            {
                Tag = "[TitleBar]New Report Configuration|$TitleBar|#1/[PushButton]Close|$Close|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ClosePB);
        }
    }
}
