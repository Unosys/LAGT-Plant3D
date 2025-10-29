// This file is auto-generated - do not hand edit this file.

using Autodesk.GUIHarness;
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{

    [UIElement(Tag = "[Pane]$SelectQuickIso", Parent = typeof(Plant3D), GUIType = GuiType.UIA)]
    public partial class SelectQuickIsoDLG : Autodesk.GUIHarness.AutoCAD.AcDialogBox
    {
        public  GroupBox OutputSettingsGB;
        public  StaticText RevisionNumberST;
        public  TextField RevisionNumberTF;
        public  CheckBox OverwriteIfExistingCK;
        public  PopupList IsoStylePL;
        public  PushButton DropDownButtonPB;
        public  StaticText IsoStyleST;
        public  StaticText SaveIsosToST;
        public  TextField SaveIsosToTF;
        public  PushButton AdvancedPB;
        public  CheckBox CreateDWFCK;
        public  PushButton PushButtonPB;
        public  GroupBox DisplayLinesGB;
        public  CheckBox CheckBox1CK;
        public  CheckBox CheckBox2CK;
        public  CheckBox CheckBox3CK;
        public  StaticText LineNumbersST;
        public  ListBox LineNumbersLB;
        public  ListBoxItem one02LBI;
        public  ListBoxItem one04LBI;
        public  ListBoxItem one05LBI;
        public  PushButton LineNumbersPB;
        public  TextField TextFieldTF;
        public  StaticText FilterST;
        public  PushButton CancelPB;
        public  PushButton CreatePB;
        public  PushButton HelpPB;
        public  TitleBar CreateQuickIsoCTL;
        public  CustomWin SystemMenuBarWIN;
        public  MenuItem SystemMI;
        public  PushButton ClosePB;

        partial void OnInitialize();

        public SelectQuickIsoDLG()
        {
            InitializeComponent();
            OnInitialize();
        }

        private void InitializeComponent()
        {

            OutputSettingsGB = new GroupBox()
            {
                Tag = "[GroupBox]Output settings|$groupBoxOutputSettings|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(OutputSettingsGB);

            RevisionNumberST = new StaticText()
            {
                Tag = "[GroupBox]Output settings|$groupBoxOutputSettings|#2/[StaticText]Revision number:|$label_RevisionNumber|#3",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(RevisionNumberST);

            RevisionNumberTF = new TextField()
            {
                Tag = "[GroupBox]Output settings|$groupBoxOutputSettings|#2/[TextField]Revision number:|$textBox_RevisionNumber|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(RevisionNumberTF);

            OverwriteIfExistingCK = new CheckBox()
            {
                Tag = "[GroupBox]Output settings|$groupBoxOutputSettings|#2/[CheckBox]Overwrite if existing|$checkBox_OverwriteExisting|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(OverwriteIfExistingCK);

            IsoStylePL = new PopupList()
            {
                Tag = "[GroupBox]Output settings|$groupBoxOutputSettings|#2/[PopupList]Iso Style:|$comboBox_IsoType|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(IsoStylePL);

            DropDownButtonPB = new PushButton()
            {
                Tag = "[GroupBox]Output settings|$groupBoxOutputSettings|#2/[PopupList]Iso Style:|$comboBox_IsoType|#1/[PushButton]Drop Down Button|$DropDown|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(DropDownButtonPB);

            IsoStyleST = new StaticText()
            {
                Tag = "[GroupBox]Output settings|$groupBoxOutputSettings|#2/[StaticText]Iso Style:|$label1|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(IsoStyleST);

            SaveIsosToST = new StaticText()
            {
                Tag = "[GroupBox]Output settings|$groupBoxOutputSettings|#2/[StaticText]Save Isos to:|$label2|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(SaveIsosToST);

            SaveIsosToTF = new TextField()
            {
                Tag = "[GroupBox]Output settings|$groupBoxOutputSettings|#2/[TextField]Save Isos to:|$textBox_OutputDirectory|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(SaveIsosToTF);

            AdvancedPB = new PushButton()
            {
                Tag = "[GroupBox]Output settings|$groupBoxOutputSettings|#2/[PushButton]Advanced*|$button_Options|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(AdvancedPB);

            CreateDWFCK = new CheckBox()
            {
                Tag = "[GroupBox]Output settings|$groupBoxOutputSettings|#2/[CheckBox]Create DWF|$checkBox_CreateRollupDWF|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(CreateDWFCK);

            PushButtonPB = new PushButton()
            {
                Tag = "[GroupBox]Output settings|$groupBoxOutputSettings|#2/[PushButton]**|$button_OutputDirectory|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(PushButtonPB);

            DisplayLinesGB = new GroupBox()
            {
                Tag = "[GroupBox]Display lines|$groupBox_DisplayLines|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(DisplayLinesGB);

            CheckBox1CK = new CheckBox()
            {
                Tag = "[GroupBox]Display lines|$groupBox_DisplayLines|#1/[CheckBox]`|$checkBox_DrawingLines|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(CheckBox1CK);

            CheckBox2CK = new CheckBox()
            {
                Tag = "[GroupBox]Display lines|$groupBox_DisplayLines|#1/[CheckBox]$checkBox_ProjectLines|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(CheckBox2CK);

            CheckBox3CK = new CheckBox()
            {
                Tag = "[GroupBox]Display lines|$groupBox_DisplayLines|#1/[CheckBox]$checkBox_filter|#3",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(CheckBox3CK);

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

            one02LBI = new ListBoxItem()
            {
                Tag = "[GroupBox]Display lines|$groupBox_DisplayLines|#1/[ListBox]Line Numbers:|$checkedListBox_Lines|#1/[ListBoxItem]102|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(one02LBI);

            one04LBI = new ListBoxItem()
            {
                Tag = "[GroupBox]Display lines|$groupBox_DisplayLines|#1/[ListBox]Line Numbers:|$checkedListBox_Lines|#1/[ListBoxItem]104?|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(one04LBI);

            one05LBI = new ListBoxItem()
            {
                Tag = "[GroupBox]Display lines|$groupBox_DisplayLines|#1/[ListBox]Line Numbers:|$checkedListBox_Lines|#1/[ListBoxItem]105?|#3",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(one05LBI);

            LineNumbersPB = new PushButton()
            {
                Tag = "[GroupBox]Display lines|$groupBox_DisplayLines|#1/[PushButton]Line Numbers:|$button_filteractive|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(LineNumbersPB);

            TextFieldTF = new TextField()
            {
                Tag = "[GroupBox]Display lines|$groupBox_DisplayLines|#1/[TextField]$textBox_Filter|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(TextFieldTF);

            FilterST = new StaticText()
            {
                Tag = "[StaticText]Filter:|$label_Filter|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(FilterST);

            CancelPB = new PushButton()
            {
                Tag = "[PushButton]Cancel|$button_Cancel|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(CancelPB);

            CreatePB = new PushButton()
            {
                Tag = "[PushButton]Create|$button_Create|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(CreatePB);

            HelpPB = new PushButton()
            {
                Tag = "[PushButton]Help|$button_Help|#3",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(HelpPB);

            CreateQuickIsoCTL = new TitleBar()
            {
                Tag = "[TitleBar]Create Quick Iso|$TitleBar|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(CreateQuickIsoCTL);

            SystemMenuBarWIN = new CustomWin()
            {
                Tag = "[TitleBar]Create Quick Iso|$TitleBar|#1/[CustomWin]System Menu Bar|$SelectQuickIso|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(SystemMenuBarWIN);

            SystemMI = new MenuItem()
            {
                Tag = "[TitleBar]Create Quick Iso|$TitleBar|#1/[CustomWin]System Menu Bar|$SelectQuickIso|#1/[MenuItem]System|$Item 1|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(SystemMI);

            ClosePB = new PushButton()
            {
                Tag = "[TitleBar]Create Quick Iso|$TitleBar|#1/[PushButton]Close|$Close|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ClosePB);
        }
    }
}
