// This file is auto-generated - do not hand edit this file.

using Autodesk.GUIHarness;
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{

    [UIElement(Tag = "[Pane]Create Iso from PCF|$PCFtoIsoDlg", Parent = typeof(Plant3D), GUIType = GuiType.UIA)]
    public partial class CreateIsoFromPCFDLG : Pane
    {
        public  GroupBox GroupBox_DisplayLines;
        public  PushButton Button_RemovePCF;
        public  PushButton Button_AddPCF;
        public  ListBox ListBox_PCFfilenames;
        public  StaticText Label_PCFfiles;
        public  GroupBox M_groupBoxOutputSettings;
        public  TextField TextBox_OutputDirectory;
        public  PushButton Button_OutputDirectory;
        public  PushButton Button_Options;
        public  StaticText M_labelIsosCreateIn;
        public  CheckBox CheckBox_OverwriteExisting;
        public  CheckBox CheckBox_CreateDWF;
        public  StaticText M_isoTypeLabel;
        public  PopupList IsoTypePL;
        public  PushButton ComboBox_IsoType;
        public  PushButton Button_Help;
        public  PushButton Button_Cancel;
        public  PushButton Button_Create;
        public  TitleBar CreateIsoFromPCFCTL;
        public  CustomWin SystemMenuBarWIN;
        public  MenuItem SystemMI;
        public  PushButton ClosePB;

        partial void OnInitialize();

        public CreateIsoFromPCFDLG()
        {
            InitializeComponent();
            OnInitialize();
        }

        private void InitializeComponent()
        {

            GroupBox_DisplayLines = new GroupBox()
            {
                Tag = "[GroupBox]Display lines|$groupBox_DisplayLines|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(GroupBox_DisplayLines);

            Button_RemovePCF = new PushButton()
            {
                Tag = "[GroupBox]Display lines|$groupBox_DisplayLines|#1/[PushButton]Remove|$button_RemovePCF|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Button_RemovePCF);

            Button_AddPCF = new PushButton()
            {
                Tag = "[GroupBox]Display lines|$groupBox_DisplayLines|#1/[PushButton]Add*|$button_AddPCF|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Button_AddPCF);

            ListBox_PCFfilenames = new ListBox()
            {
                Tag = "[GroupBox]Display lines|$groupBox_DisplayLines|#1/[ListBox]PCF files:|$listBox_PCFfilenames|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ListBox_PCFfilenames);

            Label_PCFfiles = new StaticText()
            {
                Tag = "[GroupBox]Display lines|$groupBox_DisplayLines|#1/[StaticText]PCF files:|$label_PCFfiles|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Label_PCFfiles);

            M_groupBoxOutputSettings = new GroupBox()
            {
                Tag = "[GroupBox]Output settings|$m_groupBoxOutputSettings|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_groupBoxOutputSettings);

            TextBox_OutputDirectory = new TextField()
            {
                Tag = "[GroupBox]Output settings|$m_groupBoxOutputSettings|#2/[TextField]Save Isos to:|$textBox_OutputDirectory|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(TextBox_OutputDirectory);

            Button_OutputDirectory = new PushButton()
            {
                Tag = "[GroupBox]Output settings|$m_groupBoxOutputSettings|#2/[PushButton]**|$button_OutputDirectory|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Button_OutputDirectory);

            Button_Options = new PushButton()
            {
                Tag = "[GroupBox]Output settings|$m_groupBoxOutputSettings|#2/[PushButton]Advanced*|$button_Options|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Button_Options);

            M_labelIsosCreateIn = new StaticText()
            {
                Tag = "[GroupBox]Output settings|$m_groupBoxOutputSettings|#2/[StaticText]Save Isos to:|$m_labelIsosCreateIn|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_labelIsosCreateIn);

            CheckBox_OverwriteExisting = new CheckBox()
            {
                Tag = "[GroupBox]Output settings|$m_groupBoxOutputSettings|#2/[CheckBox]Overwrite if existing|$checkBox_OverwriteExisting|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(CheckBox_OverwriteExisting);

            CheckBox_CreateDWF = new CheckBox()
            {
                Tag = "[GroupBox]Output settings|$m_groupBoxOutputSettings|#2/[CheckBox]Create DWF|$checkBox_CreateDWF|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(CheckBox_CreateDWF);

            M_isoTypeLabel = new StaticText()
            {
                Tag = "[GroupBox]Output settings|$m_groupBoxOutputSettings|#2/[StaticText]Iso Type:|$m_isoTypeLabel|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_isoTypeLabel);

            IsoTypePL = new PopupList()
            {
                Tag = "[GroupBox]Output settings|$m_groupBoxOutputSettings|#2/[PopupList]Iso Type:|$comboBox_IsoType|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(IsoTypePL);

            ComboBox_IsoType = new PushButton()
            {
                Tag = "[GroupBox]Output settings|$m_groupBoxOutputSettings|#2/[PopupList]Iso Type:|$comboBox_IsoType|#1/[PushButton]Drop Down Button|$DropDown|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ComboBox_IsoType);

            Button_Help = new PushButton()
            {
                Tag = "[PushButton]Help|$button_Help|#3",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Button_Help);

            Button_Cancel = new PushButton()
            {
                Tag = "[PushButton]Cancel|$button_Cancel|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Button_Cancel);

            Button_Create = new PushButton()
            {
                Tag = "[PushButton]Create|$button_Create|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Button_Create);

            CreateIsoFromPCFCTL = new TitleBar()
            {
                Tag = "[TitleBar]Create Iso from PCF|$TitleBar|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(CreateIsoFromPCFCTL);

            SystemMenuBarWIN = new CustomWin()
            {
                Tag = "[TitleBar]Create Iso from PCF|$TitleBar|#1/[CustomWin]System Menu Bar|$PCFtoIsoDlg|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(SystemMenuBarWIN);

            SystemMI = new MenuItem()
            {
                Tag = "[TitleBar]Create Iso from PCF|$TitleBar|#1/[CustomWin]System Menu Bar|$PCFtoIsoDlg|#1/[MenuItem]System|$Item 1|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(SystemMI);

            ClosePB = new PushButton()
            {
                Tag = "[TitleBar]Create Iso from PCF|$TitleBar|#1/[PushButton]Close|$Close|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ClosePB);
        }
    }
}
