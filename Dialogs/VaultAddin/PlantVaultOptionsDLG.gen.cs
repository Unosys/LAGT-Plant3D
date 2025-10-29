// This file is auto-generated - do not hand edit this file.

using Autodesk.GUIHarness;
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{

    [UIElement(Tag = "[Pane]Plant Vault Options|$frmVaultOptions|#1", Parent = typeof(Plant3D), GUIType = GuiType.UIA)]
    public partial class PlantVaultOptionsDLG : Autodesk.GUIHarness.AutoCAD.AcDialogBox
    {
        public  GroupBox VisualizationAttachmentOptionsGB;
        public  CheckBox ApplyToAllFilesCK;
        public  PopupList PopupListPL;
        public  PushButton DropDownButton1PB;
        public  CheckBox CreateVisualizationAttachmentCK;
        public  StaticText IncludeST;
        public  PushButton HelpPB;
        public  PushButton CancelPB;
        public  PushButton OKPB;
        public  GroupBox SynchronizeGB;
        public  PopupList CheckForUpdatesPL;
        public  PushButton DropDownButton2PB;
        public  StaticText CheckForUpdatesST;
        public  RadioButton RadioButton1RB;
        public  RadioButton RadioButton2RB;
        public  RadioButton RadioButton3RB;
        public  TitleBar PlantVaultOptionsCTL;
        public  CustomWin SystemMenuBarWIN;
        public  MenuItem SystemMI;
        public  PushButton ClosePB;

        partial void OnInitialize();

        public PlantVaultOptionsDLG()
        {
            InitializeComponent();
            OnInitialize();
        }

        private void InitializeComponent()
        {

            VisualizationAttachmentOptionsGB = new GroupBox()
            {
                Tag = "[GroupBox]Visualization Attachment Options|$groupBox1|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(VisualizationAttachmentOptionsGB);

            ApplyToAllFilesCK = new CheckBox()
            {
                Tag = "[GroupBox]Visualization Attachment Options|$groupBox1|#2/[CheckBox]Apply to all files|$chkboxApplyToAllFiles|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ApplyToAllFilesCK);

            PopupListPL = new PopupList()
            {
                Tag = "[GroupBox]Visualization Attachment Options|$groupBox1|#2/[PopupList]$comboViz|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(PopupListPL);

            DropDownButton1PB = new PushButton()
            {
                Tag = "[GroupBox]Visualization Attachment Options|$groupBox1|#2/[PopupList]$comboViz|#1/[PushButton]Drop Down Button|$DropDown|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(DropDownButton1PB);

            CreateVisualizationAttachmentCK = new CheckBox()
            {
                Tag = "[GroupBox]Visualization Attachment Options|$groupBox1|#2/[CheckBox]Create visualization attachment|$chkboxVisualAttachment|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(CreateVisualizationAttachmentCK);

            IncludeST = new StaticText()
            {
                Tag = "[GroupBox]Visualization Attachment Options|$groupBox1|#2/[StaticText]Include:|$label2|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(IncludeST);

            HelpPB = new PushButton()
            {
                Tag = "[PushButton]Help|$m_btnHelp|#3",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(HelpPB);

            CancelPB = new PushButton()
            {
                Tag = "[PushButton]Cancel|$m_btnCancel|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(CancelPB);

            OKPB = new PushButton()
            {
                Tag = "[PushButton]OK|$m_btnOK|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(OKPB);

            SynchronizeGB = new GroupBox()
            {
                Tag = "[GroupBox]Synchronize|$groupSynchronize|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(SynchronizeGB);

            CheckForUpdatesPL = new PopupList()
            {
                Tag = "[GroupBox]Synchronize|$groupSynchronize|#1/[PopupList]Check for updates:|$m_cmbCheckInterval|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(CheckForUpdatesPL);

            DropDownButton2PB = new PushButton()
            {
                Tag = "[GroupBox]Synchronize|$groupSynchronize|#1/[PopupList]Check for updates:|$m_cmbCheckInterval|#1/[PushButton]Drop Down Button|$DropDown|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(DropDownButton2PB);

            CheckForUpdatesST = new StaticText()
            {
                Tag = "[GroupBox]Synchronize|$groupSynchronize|#1/[StaticText]Check for updates:|$label1|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(CheckForUpdatesST);

            RadioButton1RB = new RadioButton()
            {
                Tag = "[GroupBox]Synchronize|$groupSynchronize|#1/[RadioButton]$m_radioNoSync|#3",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(RadioButton1RB);

            RadioButton2RB = new RadioButton()
            {
                Tag = "[GroupBox]Synchronize|$groupSynchronize|#1/[RadioButton]$m_radioXref|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(RadioButton2RB);

            RadioButton3RB = new RadioButton()
            {
                Tag = "[GroupBox]Synchronize|$groupSynchronize|#1/[RadioButton]$m_radioWorkspace|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(RadioButton3RB);

            PlantVaultOptionsCTL = new TitleBar()
            {
                Tag = "[TitleBar]Plant Vault Options|$TitleBar|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(PlantVaultOptionsCTL);

            SystemMenuBarWIN = new CustomWin()
            {
                Tag = "[TitleBar]Plant Vault Options|$TitleBar|#1/[CustomWin]System Menu Bar|$frmVaultOptions|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(SystemMenuBarWIN);

            SystemMI = new MenuItem()
            {
                Tag = "[TitleBar]Plant Vault Options|$TitleBar|#1/[CustomWin]System Menu Bar|$frmVaultOptions|#1/[MenuItem]System|$Item 1|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(SystemMI);

            ClosePB = new PushButton()
            {
                Tag = "[TitleBar]Plant Vault Options|$TitleBar|#1/[PushButton]Close|$Close|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ClosePB);
        }
    }
}
