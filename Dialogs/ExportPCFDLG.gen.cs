// This file is auto-generated - do not hand edit this file.

using Autodesk.GUIHarness;
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{

    [UIElement(Tag = "[Pane]Export PCF|$ExportPCF", Parent = typeof(Plant3D), GUIType = GuiType.UIA)]
    public partial class ExportPCFDLG : Pane
    {
        public  TextField SavePCFFilesToTF;
        public  PushButton Button_Browse;
        public  StaticText SavePCFFilesToST;
        public  GroupBox DisplayLinesGB;
        public  ListBox LineNumbersLB;
        public  CheckBox CheckBox1CK;
        public  CheckBox CheckBox2CK;
        public  CheckBox CheckBox3CK;
        public  StaticText LineNumbersST;
        public  PushButton LineNumbersPB;
        public  TextField TextFieldTF;
        public  PushButton CancelPB;
        public  PushButton CreatePB;
        public  PushButton HelpPB;
        public  TitleBar ExportPCFCTL;
        public  CustomWin SystemMenuBarWIN;
        public  MenuItem SystemMI;
        public  PushButton ClosePB;

        partial void OnInitialize();

        public ExportPCFDLG()
        {
            InitializeComponent();
            OnInitialize();
        }

        private void InitializeComponent()
        {

            SavePCFFilesToTF = new TextField()
            {
                Tag = "[TextField]Save PCF files to:|$textBox_OutputDir|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(SavePCFFilesToTF);

            Button_Browse = new PushButton()
            {
                Tag = "[PushButton]$button_Browse",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Button_Browse);

            SavePCFFilesToST = new StaticText()
            {
                Tag = "[StaticText]Save PCF files to:|$label1|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(SavePCFFilesToST);

            DisplayLinesGB = new GroupBox()
            {
                Tag = "[GroupBox]Display lines|$groupBox_DisplayLines|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(DisplayLinesGB);

            LineNumbersLB = new ListBox()
            {
                Tag = "[GroupBox]Display lines|$groupBox_DisplayLines|#1/[ListBox]Line Numbers:|$checkedListBox_Lines|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(LineNumbersLB);

            CheckBox1CK = new CheckBox()
            {
                Tag = "[GroupBox]Display lines|$groupBox_DisplayLines|#1/[CheckBox]`|$checkBox_DrawingLines|#3",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(CheckBox1CK);

            CheckBox2CK = new CheckBox()
            {
                Tag = "[GroupBox]Display lines|$groupBox_DisplayLines|#1/[CheckBox]$checkBox_ProjectLines|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(CheckBox2CK);

            CheckBox3CK = new CheckBox()
            {
                Tag = "[GroupBox]Display lines|$groupBox_DisplayLines|#1/[CheckBox]$checkBox_filter|#2",
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

            CancelPB = new PushButton()
            {
                Tag = "[PushButton]Cancel|$m_buttonCancel|#3",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(CancelPB);

            CreatePB = new PushButton()
            {
                Tag = "[PushButton]Create|$m_buttonCreate|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(CreatePB);

            HelpPB = new PushButton()
            {
                Tag = "[PushButton]Help|$m_buttonHelp|#4",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(HelpPB);

            ExportPCFCTL = new TitleBar()
            {
                Tag = "[TitleBar]Export PCF|$TitleBar|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ExportPCFCTL);

            SystemMenuBarWIN = new CustomWin()
            {
                Tag = "[TitleBar]Export PCF|$TitleBar|#1/[CustomWin]System Menu Bar|$ExportPCF|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(SystemMenuBarWIN);

            SystemMI = new MenuItem()
            {
                Tag = "[TitleBar]Export PCF|$TitleBar|#1/[CustomWin]System Menu Bar|$ExportPCF|#1/[MenuItem]System|$Item 1|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(SystemMI);

            ClosePB = new PushButton()
            {
                Tag = "[TitleBar]Export PCF|$TitleBar|#1/[PushButton]Close|$Close|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ClosePB);
        }
    }
}
