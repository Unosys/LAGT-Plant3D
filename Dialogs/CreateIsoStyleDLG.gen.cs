// This file is auto-generated - do not hand edit this file.

using Autodesk.GUIHarness;
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{

    [UIElement(Tag = "[Pane]Create Iso Style|$CreateNewIsoType", Parent = typeof(IsometricDWGSettingsIsoStyleSetupDLG), GUIType = GuiType.UIA)]
    public partial class CreateIsoStyleDLG : Autodesk.GUIHarness.AutoCAD.AcDialogBox
    {
        public  RadioButton NewStyleName1RB;
        public  RadioButton NewStyleName2RB;
        public  CheckBox SpoolFormatCK;
        public  PushButton HelpPB;
        public  PushButton CancelPB;
        public  PushButton CreatePB;
        public  PopupList SelectAnExistingStylePL;
        public  PushButton DropDownButtonPB;
        public  StaticText SelectAnExistingStyleST;
        public  TextField NewStyleNameTF;
        public  StaticText NewStyleNameST;
        public  TitleBar CreateIsoStyleCTL;
        public  CustomWin SystemMenuBarWIN;
        public  MenuItem SystemMI;
        public  PushButton ClosePB;

        partial void OnInitialize();

        public CreateIsoStyleDLG()
        {
            InitializeComponent();
            OnInitialize();
        }

        private void InitializeComponent()
        {

            NewStyleName1RB = new RadioButton()
            {
                Tag = "[RadioButton]New style name:[1]|$radioButton_CopyStyle|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(NewStyleName1RB);

            NewStyleName2RB = new RadioButton()
            {
                Tag = "[RadioButton]New style name:[2]|$radioButton_CreateNewStyle|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(NewStyleName2RB);

            SpoolFormatCK = new CheckBox()
            {
                Tag = "[CheckBox]Spool format|$checkBox_SpoolFormat|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(SpoolFormatCK);

            HelpPB = new PushButton()
            {
                Tag = "[PushButton]Help|$button_Help",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(HelpPB);

            CancelPB = new PushButton()
            {
                Tag = "[PushButton]Cancel|$button_Cancel",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(CancelPB);

            CreatePB = new PushButton()
            {
                Tag = "[PushButton]Create|$button_Create",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(CreatePB);

            SelectAnExistingStylePL = new PopupList()
            {
                Tag = "[PopupList]Select an existing style:|$comboBox_IsoType|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(SelectAnExistingStylePL);

            DropDownButtonPB = new PushButton()
            {
                Tag = "[PopupList]Select an existing style:|$comboBox_IsoType|#1/[PushButton]Drop Down Button|$DropDown|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(DropDownButtonPB);

            SelectAnExistingStyleST = new StaticText()
            {
                Tag = "[StaticText]Select an existing style:|$label_ExistingType|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(SelectAnExistingStyleST);

            NewStyleNameTF = new TextField()
            {
                Tag = "[TextField]$textBox_WSName|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(NewStyleNameTF);

            NewStyleNameST = new StaticText()
            {
                Tag = "[StaticText]$label_NewName|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(NewStyleNameST);

            CreateIsoStyleCTL = new TitleBar()
            {
                Tag = "[TitleBar]Create Iso Style|$TitleBar|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(CreateIsoStyleCTL);

            SystemMenuBarWIN = new CustomWin()
            {
                Tag = "[TitleBar]Create Iso Style|$TitleBar|#1/[CustomWin]System Menu Bar|$CreateNewIsoType|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(SystemMenuBarWIN);

            SystemMI = new MenuItem()
            {
                Tag = "[TitleBar]Create Iso Style|$TitleBar|#1/[CustomWin]System Menu Bar|$CreateNewIsoType|#1/[MenuItem]System|$Item 1|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(SystemMI);

            ClosePB = new PushButton()
            {
                Tag = "[TitleBar]Create Iso Style|$TitleBar|#1/[PushButton]Close|$Close|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ClosePB);
        }
    }
}
