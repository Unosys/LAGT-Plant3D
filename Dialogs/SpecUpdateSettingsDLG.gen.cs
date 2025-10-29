// This file is auto-generated - do not hand edit this file.

using Autodesk.GUIHarness;
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{

    [UIElement(Tag = "[Pane]Spec Update Settings|$SpecUpdateSettingDlg|#1", Parent = typeof(Plant3D), GUIType = GuiType.UIA)]
    public partial class SpecUpdateSettingsDLG : Pane
    {
        public  PushButton CancelPB;
        public  PushButton OKPB;
        public  GroupBox PipeSpecUpdatesGB;
        public  StaticText CheckForUpdatesST;
        public  PopupList CheckForUpdatesPL;
        public  PushButton DropDownButtonPB;
        public  PushButton CheckNowPB;
        public  CheckBox AskMeBeforeApplyingCK;
        public  TitleBar SpecUpdateSettingsCTL;
        public  CustomWin SystemMenuBarWIN;
        public  MenuItem SystemMI;
        public  PushButton ClosePB;

        partial void OnInitialize();

        public SpecUpdateSettingsDLG()
        {
            InitializeComponent();
            OnInitialize();
        }

        private void InitializeComponent()
        {

            CancelPB = new PushButton()
            {
                Tag = "[PushButton]Cancel|$m_btnClose|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(CancelPB);

            OKPB = new PushButton()
            {
                Tag = "[PushButton]OK|$m_btnApply|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(OKPB);

            PipeSpecUpdatesGB = new GroupBox()
            {
                Tag = "[GroupBox]Pipe Spec Updates|$groupBox1|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(PipeSpecUpdatesGB);

            CheckForUpdatesST = new StaticText()
            {
                Tag = "[GroupBox]Pipe Spec Updates|$groupBox1|#1/[StaticText]Check for updates:|$m_lableHours|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(CheckForUpdatesST);

            CheckForUpdatesPL = new PopupList()
            {
                Tag = "[GroupBox]Pipe Spec Updates|$groupBox1|#1/[PopupList]Check for updates:|$m_comboBoxHours|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(CheckForUpdatesPL);

            DropDownButtonPB = new PushButton()
            {
                Tag = "[GroupBox]Pipe Spec Updates|$groupBox1|#1/[PopupList]Check for updates:|$m_comboBoxHours|#1/[PushButton]Drop Down Button|$DropDown|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(DropDownButtonPB);

            CheckNowPB = new PushButton()
            {
                Tag = "[GroupBox]Pipe Spec Updates|$groupBox1|#1/[PushButton]Check Now*|$m_btnCheckUpdate|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(CheckNowPB);

            AskMeBeforeApplyingCK = new CheckBox()
            {
                Tag = "[GroupBox]Pipe Spec Updates|$groupBox1|#1/[CheckBox]Ask me before applying updates|$m_chkAutomatic|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(AskMeBeforeApplyingCK);

            SpecUpdateSettingsCTL = new TitleBar()
            {
                Tag = "[TitleBar]Spec Update Settings|$TitleBar|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(SpecUpdateSettingsCTL);

            SystemMenuBarWIN = new CustomWin()
            {
                Tag = "[TitleBar]Spec Update Settings|$TitleBar|#1/[CustomWin]System Menu Bar|$SpecUpdateSettingDlg|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(SystemMenuBarWIN);

            SystemMI = new MenuItem()
            {
                Tag = "[TitleBar]Spec Update Settings|$TitleBar|#1/[CustomWin]System Menu Bar|$SpecUpdateSettingDlg|#1/[MenuItem]System|$Item 1|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(SystemMI);

            ClosePB = new PushButton()
            {
                Tag = "[TitleBar]Spec Update Settings|$TitleBar|#1/[PushButton]Close|$Close|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ClosePB);
        }
    }
}
