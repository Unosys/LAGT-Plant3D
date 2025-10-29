// This file is auto-generated - do not hand edit this file.

using Autodesk.GUIHarness;
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{

    [UIElement(Tag = "[Pane]Assign Tag|$TaggingDlg|#1", Parent = typeof(Plant3D), GUIType = GuiType.UIA)]
    public partial class AssignTag : Pane
    {
        public  Pane Pane1PANE;
        public  PushButton AssignPB;
        public  PushButton CancelPB;
        public  PushButton HelpPB;
        public  Pane Pane2PANE;
        public  Pane Pane3PANE;
        public  Pane Pane4PANE;
        public  StaticText TagFormatST;
        public  StaticText LineNumberST;
        public  Pane LineNumberPANE;
        public  Pane Pane5PANE;
        public  Pane Pane6PANE;
        public  TextField TextField1TF;
        public  TextField TextField2TF;
        public  TextField TextField3TF;
        public  TextField TextField8TF;
        public  TextField TextField9TF;
        public  TextField TextField10TF;
        public  StaticText StaticTextST;
        public  Pane Pane7PANE;
        public  Pane Pane8PANE;
        public  TextField TextField4TF;
        public  TextField TextField5TF;
        public  PopupList PopupList1PL;
        public  PushButton DropDownButton1PB;
        public  Pane Pane9PANE;
        public  Pane Pane10PANE;
        public  TextField TextField6TF;
        public  TextField TextField7TF;
        public  PopupList PopupList2PL;
        public  PushButton DropDownButton2PB;
        public  StaticText P3dLineGroupST;
        public  Pane Class1PANE;
        public  Pane Class2PANE;
        public  Pane Pane11PANE;
        public  StaticText ClassST;
        public  TitleBar AssignTagCTL;
        public  CustomWin SystemMenuBarWIN;
        public  MenuItem SystemMI;
        public  PushButton ClosePB;

        partial void OnInitialize();

        public AssignTag()
        {
            InitializeComponent();
            OnInitialize();
        }

        private void InitializeComponent()
        {

            Pane1PANE = new Pane()
            {
                Tag = "[Pane]$m_Bottom_Panel|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Pane1PANE);

            AssignPB = new PushButton()
            {
                Tag = "[Pane]$m_Bottom_Panel|#2/[PushButton]Assign|$m_btnOK|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(AssignPB);

            CancelPB = new PushButton()
            {
                Tag = "[Pane]$m_Bottom_Panel|#2/[PushButton]Cancel|$m_btnCancel|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(CancelPB);

            HelpPB = new PushButton()
            {
                Tag = "[Pane]$m_Bottom_Panel|#2/[PushButton]Help|$m_btnHelp|#3",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(HelpPB);

            Pane2PANE = new Pane()
            {
                Tag = "[Pane]$m_LowerPanel|#3",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Pane2PANE);

            Pane3PANE = new Pane()
            {
                Tag = "[Pane]$m_LowerPanel|#3/[Pane]$m_CollapsibleButton|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Pane3PANE);

            Pane4PANE = new Pane()
            {
                Tag = "[Pane]$panel_top|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Pane4PANE);

            TagFormatST = new StaticText()
            {
                Tag = "[Pane]$panel_top|#1/[StaticText]Tag Format:|$m_lblTagFormatText|#4",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(TagFormatST);

            LineNumberST = new StaticText()
            {
                Tag = "[Pane]$panel_top|#1/[StaticText]Line Number|$m_TagFormatName_Label|#3",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(LineNumberST);

            LineNumberPANE = new Pane()
            {
                Tag = "[Pane]$panel_top|#1/[Pane]Line Number|$m_UserControlPanel|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(LineNumberPANE);

            Pane5PANE = new Pane()
            {
                Tag = "[Pane]$panel_top|#1/[Pane]Line Number|$m_UserControlPanel|#2/[Pane]$TagUserControl|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Pane5PANE);

            Pane6PANE = new Pane()
            {
                Tag = "[Pane]$panel_top|#1/[Pane]Line Number|$m_UserControlPanel|#2/[Pane]$TagUserControl|#1/[Pane]$panel1|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Pane6PANE);

            TextField1TF = new TextField()
            {
                Tag = "[Pane]$panel_top|#1/[Pane]Line Number|$m_UserControlPanel|#2/[Pane]$TagUserControl|#1/[Pane]$panel1|#1/[TextField]$m_tbTagValue",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(TextField1TF);

            TextField2TF = new TextField()
            {
                Tag = "[Pane]$panel_top|#1/[Pane]Line Number|$m_UserControlPanel|#2/[Pane]$TagUserControl|#1/[Pane]$panel1|#1/[TextField]$m_tbTagValueMirror",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(TextField2TF);

            TextField3TF = new TextField()
            {
                Tag = "[Pane]$panel_top|#1/[Pane]Line Number|$m_UserControlPanel|#2/[Pane]$TagUserControl|#1/[Pane]$panel1|#1/[TextField]$m_tbTagName",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(TextField3TF);

            TextField8TF = new TextField()
            {
                Tag = "[Pane]$panel_top|#1/[Pane]Class:|$m_TagPanel|#1/[Pane]Class:|$m_UserCtrTagValue|#1/[Pane]$panel1|#1/[TextField]$m_tbTagName",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(TextField8TF);

            TextField9TF = new TextField()
            {
                Tag = "[Pane]$panel_top|#1/[Pane]Class:|$m_TagPanel|#1/[Pane]Class:|$m_UserCtrTagValue|#1/[Pane]$panel1|#1/[TextField]$m_tbTagValue",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(TextField9TF);

            TextField10TF = new TextField()
            {
                Tag = "[Pane]$panel_top|#1/[Pane]Class:|$m_TagPanel|#1/[Pane]Class:|$m_UserCtrTagValue|#1/[Pane]$panel1|#1/[TextField]$m_tbTagValueMirror",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(TextField10TF);

            StaticTextST = new StaticText()
            {
                Tag = "[Pane]$panel_top|#1/[Pane]Line Number|$m_UserControlPanel|#2/[StaticText]$263176|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(StaticTextST);

            Pane7PANE = new Pane()
            {
                Tag = "[Pane]$panel_top|#1/[Pane]Line Number|$m_UserControlPanel|#2/[Pane]$TagComboUserControl|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Pane7PANE);

            Pane8PANE = new Pane()
            {
                Tag = "[Pane]$panel_top|#1/[Pane]Line Number|$m_UserControlPanel|#2/[Pane]$TagComboUserControl|#2/[Pane]$panel1|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Pane8PANE);

            TextField4TF = new TextField()
            {
                Tag = "[Pane]$panel_top|#1/[Pane]Line Number|$m_UserControlPanel|#2/[Pane]$TagComboUserControl|#2/[Pane]$panel1|#1/[TextField]$m_tbTagValue|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(TextField4TF);

            TextField5TF = new TextField()
            {
                Tag = "[Pane]$panel_top|#1/[Pane]Line Number|$m_UserControlPanel|#2/[Pane]$TagComboUserControl|#2/[Pane]$panel1|#1/[TextField]$m_tbTagName|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(TextField5TF);

            PopupList1PL = new PopupList()
            {
                Tag = "[Pane]$panel_top|#1/[Pane]Line Number|$m_UserControlPanel|#2/[Pane]$TagComboUserControl|#2/[Pane]$panel1|#1/[PopupList]$m_cbType|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(PopupList1PL);

            DropDownButton1PB = new PushButton()
            {
                Tag = "[Pane]$panel_top|#1/[Pane]Line Number|$m_UserControlPanel|#2/[Pane]$TagComboUserControl|#2/[Pane]$panel1|#1/[PopupList]$m_cbType|#1/[PushButton]Drop Down Button|$DropDown|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(DropDownButton1PB);

            Pane9PANE = new Pane()
            {
                Tag = "[Pane]$panel_top|#1/[Pane]Line Number|$m_UserControlPanel|#2/[Pane]$TagComboUserControl|#3",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Pane9PANE);

            Pane10PANE = new Pane()
            {
                Tag = "[Pane]$panel_top|#1/[Pane]Line Number|$m_UserControlPanel|#2/[Pane]$TagComboUserControl|#3/[Pane]$panel1|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Pane10PANE);

            TextField6TF = new TextField()
            {
                Tag = "[Pane]$panel_top|#1/[Pane]Line Number|$m_UserControlPanel|#2/[Pane]$TagComboUserControl|#3/[Pane]$panel1|#1/[TextField]$m_tbTagValue|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(TextField6TF);

            TextField7TF = new TextField()
            {
                Tag = "[Pane]$panel_top|#1/[Pane]Line Number|$m_UserControlPanel|#2/[Pane]$TagComboUserControl|#3/[Pane]$panel1|#1/[TextField]$m_tbTagName|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(TextField7TF);

            PopupList2PL = new PopupList()
            {
                Tag = "[Pane]$panel_top|#1/[Pane]Line Number|$m_UserControlPanel|#2/[Pane]$TagComboUserControl|#3/[Pane]$panel1|#1/[PopupList]$m_cbType|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(PopupList2PL);

            DropDownButton2PB = new PushButton()
            {
                Tag = "[Pane]$panel_top|#1/[Pane]Line Number|$m_UserControlPanel|#2/[Pane]$TagComboUserControl|#3/[Pane]$panel1|#1/[PopupList]$m_cbType|#1/[PushButton]Drop Down Button|$DropDown|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(DropDownButton2PB);

            P3dLineGroupST = new StaticText()
            {
                Tag = "[Pane]$panel_top|#1/[StaticText]P3d Line Group|$m_lblClassName|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(P3dLineGroupST);

            Class1PANE = new Pane()
            {
                Tag = "[Pane]$panel_top|#1/[Pane]Class:|$m_TagPanel|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Class1PANE);

            Class2PANE = new Pane()
            {
                Tag = "[Pane]$panel_top|#1/[Pane]Class:|$m_TagPanel|#1/[Pane]Class:|$m_UserCtrTagValue|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Class2PANE);

            Pane11PANE = new Pane()
            {
                Tag = "[Pane]$panel_top|#1/[Pane]Class:|$m_TagPanel|#1/[Pane]Class:|$m_UserCtrTagValue|#1/[Pane]$panel1|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Pane11PANE);

            ClassST = new StaticText()
            {
                Tag = "[Pane]$panel_top|#1/[StaticText]Class:|$m_lblClassText|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ClassST);

            AssignTagCTL = new TitleBar()
            {
                Tag = "[TitleBar]Assign Tag|$TitleBar|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(AssignTagCTL);

            SystemMenuBarWIN = new CustomWin()
            {
                Tag = "[TitleBar]Assign Tag|$TitleBar|#1/[CustomWin]System Menu Bar|$TaggingDlg|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(SystemMenuBarWIN);

            SystemMI = new MenuItem()
            {
                Tag = "[TitleBar]Assign Tag|$TitleBar|#1/[CustomWin]System Menu Bar|$TaggingDlg|#1/[MenuItem]System|$Item 1|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(SystemMI);

            ClosePB = new PushButton()
            {
                Tag = "[TitleBar]Assign Tag|$TitleBar|#1/[PushButton]Close|$Close|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ClosePB);
        }
    }
}
