// This file is auto-generated - do not hand edit this file.

using Autodesk.GUIHarness;
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{

    [UIElement(Tag = "[Pane]Create Production Iso|$ProductionIsoCreate|#1", Parent = typeof(Plant3D), GUIType = GuiType.UIA)]
    public partial class CreateProductionIsoDLG : Pane
    {
        public  GroupBox DisplayLinesGB;
        public  CheckBox CheckBox_DrawingLines;
        public  CheckBox CheckBox_ProjectLines;
        public  CheckBox CheckBox_filter;
        public  StaticText LineNumbersST;
        public  ListBox LineNumbersLB;
        public  PushButton Button_filteractive;
        public  TextField TextFieldTF;
        public  GroupBox OutputSettingsGB;
        public  StaticText RevisionNumberST;
        public  TextField RevisionNumberTF;
        public  PushButton Button_Options;
        public  StaticText SaveIsosToST;
        public  StaticText CUsersAdministratorAppDataRoamingAutodeskAutodeskAutoCADPlant3DST;
        public  CheckBox CheckBox_OverwriteExisting;
        public  CheckBox CheckBox_CreateDWF;
        public  StaticText IsoStyleST;
        public  PopupList IsoStylePL;
        public  PushButton DropDownButtonPB;
        public  PushButton M_buttonCancel;
        public  PushButton M_buttonCreate;
        public  PushButton M_buttonHelp;
        public  TitleBar CreateProductionIsoCTL;
        public  CustomWin SystemMenuBarWIN;
        public  MenuItem SystemMI;
        public  PushButton ClosePB;

        partial void OnInitialize();

        public CreateProductionIsoDLG()
        {
            InitializeComponent();
            OnInitialize();
        }

        private void InitializeComponent()
        {

            DisplayLinesGB = new GroupBox()
            {
                Tag = "[GroupBox]Display lines|$groupBox_DisplayLines|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(DisplayLinesGB);

            CheckBox_DrawingLines = new CheckBox()
            {
                Tag = "[GroupBox]Display lines|$groupBox_DisplayLines|#1/[CheckBox]`|$checkBox_DrawingLines|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(CheckBox_DrawingLines);

            CheckBox_ProjectLines = new CheckBox()
            {
                Tag = "[GroupBox]Display lines|$groupBox_DisplayLines|#1/[CheckBox]$checkBox_ProjectLines|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(CheckBox_ProjectLines);

            CheckBox_filter = new CheckBox()
            {
                Tag = "[GroupBox]Display lines|$groupBox_DisplayLines|#1/[CheckBox]$checkBox_filter|#3",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(CheckBox_filter);

            LineNumbersST = new StaticText()
            {
                Tag = "[GroupBox]Display lines|$groupBox_DisplayLines|#1/[StaticText]Line Numbers:|$label_CreateFromLines|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(LineNumbersST);

            LineNumbersLB = new ListBox()
            {
                Tag = "[GroupBox]Display lines|$groupBox_DisplayLines|#1/[ListBox]Line Numbers:|$checkedListBox_Lines|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(LineNumbersLB);

            Button_filteractive = new PushButton()
            {
                Tag = "[GroupBox]Display lines|$groupBox_DisplayLines|#1/[PushButton]Line Numbers:|$button_filteractive|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Button_filteractive);

            TextFieldTF = new TextField()
            {
                Tag = "[GroupBox]Display lines|$groupBox_DisplayLines|#1/[TextField]$textBox_Filter|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(TextFieldTF);

            OutputSettingsGB = new GroupBox()
            {
                Tag = "[GroupBox]Output settings|$m_groupBoxOutputSettings|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(OutputSettingsGB);

            RevisionNumberST = new StaticText()
            {
                Tag = "[GroupBox]Output settings|$m_groupBoxOutputSettings|#2/[StaticText]Revision number:|$label_RevisionNumber|#4",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(RevisionNumberST);

            RevisionNumberTF = new TextField()
            {
                Tag = "[GroupBox]Output settings|$m_groupBoxOutputSettings|#2/[TextField]Revision number:|$textBox_RevisionNumber|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(RevisionNumberTF);

            Button_Options = new PushButton()
            {
                Tag = "[GroupBox]Output settings|$m_groupBoxOutputSettings|#2/[PushButton]Advanced*|$button_Options|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Button_Options);

            SaveIsosToST = new StaticText()
            {
                Tag = "[GroupBox]Output settings|$m_groupBoxOutputSettings|#2/[StaticText]Save Isos to:|$m_labelIsosCreateIn|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(SaveIsosToST);

            CUsersAdministratorAppDataRoamingAutodeskAutodeskAutoCADPlant3DST = new StaticText()
            {
                Tag = "[GroupBox]Output settings|$m_groupBoxOutputSettings|#2/[StaticText]C:*|$m_labelIsometricsPath|#3",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(CUsersAdministratorAppDataRoamingAutodeskAutodeskAutoCADPlant3DST);

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

            IsoStyleST = new StaticText()
            {
                Tag = "[GroupBox]Output settings|$m_groupBoxOutputSettings|#2/[StaticText]Iso Style:|$m_isoTypeLabel|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(IsoStyleST);

            IsoStylePL = new PopupList()
            {
                Tag = "[GroupBox]Output settings|$m_groupBoxOutputSettings|#2/[PopupList]Iso Style:|$comboBox_IsoType|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(IsoStylePL);

            DropDownButtonPB = new PushButton()
            {
                Tag = "[GroupBox]Output settings|$m_groupBoxOutputSettings|#2/[PopupList]Iso Style:|$comboBox_IsoType|#1/[PushButton]Drop Down Button|$DropDown|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(DropDownButtonPB);

            M_buttonCancel = new PushButton()
            {
                Tag = "[PushButton]Cancel|$m_buttonCancel|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_buttonCancel);

            M_buttonCreate = new PushButton()
            {
                Tag = "[PushButton]Create|$m_buttonCreate|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_buttonCreate);

            M_buttonHelp = new PushButton()
            {
                Tag = "[PushButton]Help|$m_buttonHelp|#3",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_buttonHelp);

            CreateProductionIsoCTL = new TitleBar()
            {
                Tag = "[TitleBar]Create Production Iso|$TitleBar|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(CreateProductionIsoCTL);

            SystemMenuBarWIN = new CustomWin()
            {
                Tag = "[TitleBar]Create Production Iso|$TitleBar|#1/[CustomWin]System Menu Bar|$ProductionIsoCreate|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(SystemMenuBarWIN);

            SystemMI = new MenuItem()
            {
                Tag = "[TitleBar]Create Production Iso|$TitleBar|#1/[CustomWin]System Menu Bar|$ProductionIsoCreate|#1/[MenuItem]System|$Item 1|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(SystemMI);

            ClosePB = new PushButton()
            {
                Tag = "[TitleBar]Create Production Iso|$TitleBar|#1/[PushButton]Close|$Close|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ClosePB);
        }
    }
}
