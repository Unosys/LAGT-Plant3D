// This file is auto-generated - do not hand edit this file.

using Autodesk.GUIHarness;
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{

    [UIElement(Tag = "[Pane]Create Quick Iso|$QuickIsoCreate|#1", Parent = typeof(Plant3D), GUIType = GuiType.UIA)]
    public partial class CreateQuickIsoDLG : Autodesk.GUIHarness.AutoCAD.AcDialogBox
    {
        public  PushButton Button_Help;
        public  PushButton Button_Cancel;
        public  PushButton Button_Create;
        public  GroupBox GroupBoxOutputSettings;
        public  StaticText SaveIsosToST;
        public  StaticText IsoStyleST;
        public  StaticText RevisionNumberST;
        public  TextField TextBox_RevisionNumber;
        public  CheckBox CheckBox_OverwriteExisting;
        public  PopupList ComboBox_IsoType;
        public  PushButton DropDownButtonPB;
        public  TextField TextBox_OutputDirectory;
        public  PushButton Button_Options;
        public  CheckBox CheckBox_CreateRollupDWF;
        public  PushButton Button_OutputDirectory;
        public  GroupBox GroupBox_SelectedLines;
        public  PushButton Button_Reselect;
        public  StaticText WindowedSelectionSetST;
        public  TitleBar CreateQuickIsoCTL;
        public  CustomWin SystemMenuBarWIN;
        public  MenuItem SystemMI;
        public  PushButton ClosePB;
        public  ListBox LineNumbersLB;
        public  ListBoxItem one02LBI;
        public  ListBoxItem one04LBI;
        public  ListBoxItem one05LBI;

        partial void OnInitialize();

        public CreateQuickIsoDLG()
        {
            InitializeComponent();
            OnInitialize();
        }

        private void InitializeComponent()
        {

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

            GroupBoxOutputSettings = new GroupBox()
            {
                Tag = "[GroupBox]Output Settings|$groupBoxOutputSettings|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(GroupBoxOutputSettings);

            SaveIsosToST = new StaticText()
            {
                Tag = "[GroupBox]Output Settings|$groupBoxOutputSettings|#2/[StaticText]Save Isos to:|$label2|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(SaveIsosToST);

            IsoStyleST = new StaticText()
            {
                Tag = "[GroupBox]Output Settings|$groupBoxOutputSettings|#2/[StaticText]Iso Style:|$m_isoTypeLabel|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(IsoStyleST);

            RevisionNumberST = new StaticText()
            {
                Tag = "[GroupBox]Output Settings|$groupBoxOutputSettings|#2/[StaticText]Revision number:|$label_RevisionNumber|#3",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(RevisionNumberST);

            TextBox_RevisionNumber = new TextField()
            {
                Tag = "[GroupBox]Output Settings|$groupBoxOutputSettings|#2/[TextField]Revision number:|$textBox_RevisionNumber|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(TextBox_RevisionNumber);

            CheckBox_OverwriteExisting = new CheckBox()
            {
                Tag = "[GroupBox]Output Settings|$groupBoxOutputSettings|#2/[CheckBox]Overwrite if existing|$checkBox_OverwriteExisting|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(CheckBox_OverwriteExisting);

            ComboBox_IsoType = new PopupList()
            {
                Tag = "[GroupBox]Output Settings|$groupBoxOutputSettings|#2/[PopupList]Iso Style:|$comboBox_IsoType|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ComboBox_IsoType);

            DropDownButtonPB = new PushButton()
            {
                Tag = "[GroupBox]Output Settings|$groupBoxOutputSettings|#2/[PopupList]Iso Style:|$comboBox_IsoType|#1/[PushButton]Drop Down Button|$DropDown|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(DropDownButtonPB);

            TextBox_OutputDirectory = new TextField()
            {
                Tag = "[GroupBox]Output Settings|$groupBoxOutputSettings|#2/[TextField]Save Isos to:|$textBox_OutputDirectory|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(TextBox_OutputDirectory);

            Button_Options = new PushButton()
            {
                Tag = "[GroupBox]Output Settings|$groupBoxOutputSettings|#2/[PushButton]Advanced*|$button_Options|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Button_Options);

            CheckBox_CreateRollupDWF = new CheckBox()
            {
                Tag = "[GroupBox]Output Settings|$groupBoxOutputSettings|#2/[CheckBox]Create DWF|$checkBox_CreateRollupDWF|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(CheckBox_CreateRollupDWF);

            Button_OutputDirectory = new PushButton()
            {
                Tag = "[GroupBox]Output Settings|$groupBoxOutputSettings|#2/[PushButton]**|$button_OutputDirectory|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Button_OutputDirectory);

            GroupBox_SelectedLines = new GroupBox()
            {
                Tag = "[GroupBox]Selection to Iso|$groupBox_SelectedLines|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(GroupBox_SelectedLines);

            Button_Reselect = new PushButton()
            {
                Tag = "[GroupBox]Selection to Iso|$groupBox_SelectedLines|#1/[PushButton]Reselect*|$button_Reselect|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Button_Reselect);

            WindowedSelectionSetST = new StaticText()
            {
                Tag = "[GroupBox]Selection to Iso|$groupBox_SelectedLines|#1/[StaticText]Windowed selection set|$label_SelectedLines|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(WindowedSelectionSetST);

            CreateQuickIsoCTL = new TitleBar()
            {
                Tag = "[TitleBar]Create Quick Iso|$TitleBar|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(CreateQuickIsoCTL);

            SystemMenuBarWIN = new CustomWin()
            {
                Tag = "[TitleBar]Create Quick Iso|$TitleBar|#1/[CustomWin]System Menu Bar|$QuickIsoCreate|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(SystemMenuBarWIN);

            SystemMI = new MenuItem()
            {
                Tag = "[TitleBar]Create Quick Iso|$TitleBar|#1/[CustomWin]System Menu Bar|$QuickIsoCreate|#1/[MenuItem]System|$Item 1|#1",
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

            LineNumbersLB = new ListBox()
            {
                Tag = "[GroupBox]$groupBox_DisplayLines|#1/[ListBox]$checkedListBox_Lines|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(LineNumbersLB);

            one02LBI = new ListBoxItem()
            {
                Tag = "[GroupBox]$groupBox_DisplayLines|#1/[ListBox]$checkedListBox_Lines|#1/[ListBoxItem]102|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(one02LBI);

            one04LBI = new ListBoxItem()
            {
                Tag = "[GroupBox]$groupBox_DisplayLines|#1/[ListBox]$checkedListBox_Lines|#1/[ListBoxItem]104?|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(one04LBI);

            one05LBI = new ListBoxItem()
            {
                Tag = "[GroupBox]$groupBox_DisplayLines|#1/[ListBox]$checkedListBox_Lines|#1/[ListBoxItem]105?|#3",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(one05LBI);
        }
    }
}
