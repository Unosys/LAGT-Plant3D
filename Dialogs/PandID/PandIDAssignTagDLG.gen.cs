// This file is auto-generated - do not hand edit this file.

using Autodesk.GUIHarness;
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{

    [UIElement(Tag = "[Pane]Assign Tag|$TaggingDlg", Parent = typeof(MainWin))]
    public partial class PandIDAssignTagDLG : Pane
    {
        public  Pane Pane1PANE;
        public  GroupBox GroupBoxGB;
        public  PopupList AnnotationStylePL;
        public  PushButton DropDownButtonPB;
        public  StaticText AnnotationStyleST;
        public  CheckBox PlaceAnnotationAfterAssigningCK;
        public  PushButton AssignPB;
        public  PushButton CancelPB;
        public  PushButton HelpPB;
        public  Pane Pane2PANE;
        public  Pane Pane3PANE;
        public  Pane Pane4PANE;
        public  StaticText TagFormatST;
        public  StaticText EquipmentTagTypeNumberST;
        public  Pane EquipmentTagTypeNumberPANE;
        public  Pane Pane5PANE;
        public  Pane Pane6PANE;
        public  TextField TextField1TF;
        public  TextField TextField2TF;
        public  ComboBox ComboBoxCB;
        public  Pane Pane7PANE;
        public  Pane Pane8PANE;
        public  PushButton PushButtonPB;
        public  TextField TextField3TF;
        public  TextField TextField4TF;
        public  TextField TextField5TF;
        public  StaticText PumpsST;
        public  Pane Class1PANE;
        public  Pane Class2PANE;
        public  Pane Pane9PANE;
        public  TextField TextField6TF;
        public  TextField TextField7TF;
        public  TextField TextField8TF;
        public  StaticText ClassST;
        public  TitleBar AssignTagCTL;
        public  CustomWin SystemMenuBarWIN;
        public  MenuItem SystemMI;
        public  PushButton ClosePB;

        partial void OnInitialize();

        public PandIDAssignTagDLG()
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

            GroupBoxGB = new GroupBox()
            {
                Tag = "[Pane]$m_Bottom_Panel|#2/[GroupBox]$m_annotationGroupBox|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(GroupBoxGB);

            AnnotationStylePL = new PopupList()
            {
                Tag = "[Pane]$m_Bottom_Panel|#2/[GroupBox]$m_annotationGroupBox|#1/[PopupList]Annotation style:|$m_annotationComboBox|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(AnnotationStylePL);

            DropDownButtonPB = new PushButton()
            {
                Tag = "[Pane]$m_Bottom_Panel|#2/[GroupBox]$m_annotationGroupBox|#1/[PopupList]Annotation style:|$m_annotationComboBox|#1/[PushButton]Drop Down Button|$DropDown|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(DropDownButtonPB);

            AnnotationStyleST = new StaticText()
            {
                Tag = "[Pane]$m_Bottom_Panel|#2/[GroupBox]$m_annotationGroupBox|#1/[StaticText]Annotation style:|$m_annotationTextLabel|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(AnnotationStyleST);

            PlaceAnnotationAfterAssigningCK = new CheckBox()
            {
                Tag = "[Pane]$m_Bottom_Panel|#2/[GroupBox]$m_annotationGroupBox|#1/[CheckBox]Place annotation after assigning tag|$m_annotationCheckBox|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(PlaceAnnotationAfterAssigningCK);

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

            EquipmentTagTypeNumberST = new StaticText()
            {
                Tag = "[Pane]$panel_top|#1/[StaticText]Equipment Tag *|$m_TagFormatName_Label|#3",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(EquipmentTagTypeNumberST);

            EquipmentTagTypeNumberPANE = new Pane()
            {
                Tag = "[Pane]$panel_top|#1/[Pane]Equipment Tag *|$m_UserControlPanel|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(EquipmentTagTypeNumberPANE);

            Pane5PANE = new Pane()
            {
                Tag = "[Pane]$panel_top|#1/[Pane]Equipment Tag *|$m_UserControlPanel|#2/[Pane]$TagComboUserControl|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Pane5PANE);

            Pane6PANE = new Pane()
            {
                Tag = "[Pane]$panel_top|#1/[Pane]Equipment Tag *|$m_UserControlPanel|#2/[Pane]$TagComboUserControl|#1/[Pane]$panel1|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Pane6PANE);

            TextField1TF = new TextField()
            {
                Tag = "[Pane]$panel_top|#1/[Pane]Equipment Tag *|$m_UserControlPanel|#2/[Pane]$TagComboUserControl|#1/[Pane]$panel1|#1/[TextField]$m_tbTagValue|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(TextField1TF);

            TextField2TF = new TextField()
            {
                Tag = "[Pane]$panel_top|#1/[Pane]Equipment Tag *|$m_UserControlPanel|#2/[Pane]$TagComboUserControl|#1/[Pane]$panel1|#1/[TextField]$m_tbTagName|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(TextField2TF);

            ComboBoxCB = new ComboBox()
            {
                Tag = "[Pane]$panel_top|#1/[Pane]Equipment Tag *|$m_UserControlPanel|#2/[Pane]$TagComboUserControl|#1/[Pane]$panel1|#1/[ComboBox]$m_cbType|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ComboBoxCB);

            Pane7PANE = new Pane()
            {
                Tag = "[Pane]$panel_top|#1/[Pane]Equipment Tag *|$m_UserControlPanel|#2/[Pane]$TagUserControl|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Pane7PANE);

            Pane8PANE = new Pane()
            {
                Tag = "[Pane]$panel_top|#1/[Pane]Equipment Tag *|$m_UserControlPanel|#2/[Pane]$TagUserControl|#2/[Pane]$panel1|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Pane8PANE);

            PushButtonPB = new PushButton()
            {
                Tag = "[Pane]$panel_top|#1/[Pane]Equipment Tag *|$m_UserControlPanel|#2/[Pane]$TagUserControl|#2/[Pane]$panel1|#1/[PushButton]$m_btnControl|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(PushButtonPB);

            TextField3TF = new TextField()
            {
                Tag = "[Pane]$panel_top|#1/[Pane]Equipment Tag *|$m_UserControlPanel|#2/[Pane]$TagUserControl|#2/[Pane]$panel1|#1/[TextField]$m_tbTagValue|#3",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(TextField3TF);

            TextField4TF = new TextField()
            {
                Tag = "[Pane]$panel_top|#1/[Pane]Equipment Tag *|$m_UserControlPanel|#2/[Pane]$TagUserControl|#2/[Pane]$panel1|#1/[TextField]$m_tbTagValueMirror|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(TextField4TF);

            TextField5TF = new TextField()
            {
                Tag = "[Pane]$panel_top|#1/[Pane]Equipment Tag *|$m_UserControlPanel|#2/[Pane]$TagUserControl|#2/[Pane]$panel1|#1/[TextField]$m_tbTagName|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(TextField5TF);

            PumpsST = new StaticText()
            {
                Tag = "[Pane]$panel_top|#1/[StaticText]Pumps|$m_lblClassName|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(PumpsST);

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

            Pane9PANE = new Pane()
            {
                Tag = "[Pane]$panel_top|#1/[Pane]Class:|$m_TagPanel|#1/[Pane]Class:|$m_UserCtrTagValue|#1/[Pane]$panel1|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Pane9PANE);

            TextField6TF = new TextField()
            {
                Tag = "[Pane]$panel_top|#1/[Pane]Class:|$m_TagPanel|#1/[Pane]Class:|$m_UserCtrTagValue|#1/[Pane]$panel1|#1/[TextField]$m_tbTagName|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(TextField6TF);

            TextField7TF = new TextField()
            {
                Tag = "[Pane]$panel_top|#1/[Pane]Class:|$m_TagPanel|#1/[Pane]Class:|$m_UserCtrTagValue|#1/[Pane]$panel1|#1/[TextField]$m_tbTagValue|#3",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(TextField7TF);

            TextField8TF = new TextField()
            {
                Tag = "[Pane]$panel_top|#1/[Pane]Class:|$m_TagPanel|#1/[Pane]Class:|$m_UserCtrTagValue|#1/[Pane]$panel1|#1/[TextField]$m_tbTagValueMirror|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(TextField8TF);

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
