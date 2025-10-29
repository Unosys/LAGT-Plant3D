// This file is auto-generated - do not hand edit this file.

using Autodesk.GUIHarness;
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{

    [UIElement(Tag = "[Pane]Assign Tag|$TaggingDlg", GUIType = GuiType.UIA)]
    public partial class AssignTagDLG : Autodesk.GUIHarness.AutoCAD.AcDialogBox
    {
        public  CheckBox M_annotationCheckBox;
        public  ComboBox M_annotationComboBox;
        public  GroupBox M_annotationGroupBox;
        public  StaticText M_annotationTextLabel;
        public  GroupBox M_Bottom_Panel;
        public  PushButton M_btnCancel;
        public  PushButton M_btnHelp;
        public  PushButton M_btnOK;
        public  PushButton AssignPB;
        public  ComboBox M_cbType;
        public  ComboBox M_cbType2;
        public  ComboBox M_cbType3;
        public  TextField M_cbTypeTextField;
        public  TextField M_cbTypeTextField2;
        public  TextField M_cbTypeTextField3;
        public  CustomWin M_CollapsibleButton;
        public  StaticText M_lblClassName;
        public  StaticText M_lblClassText;
        public  StaticText M_lblTagFormatText;
        public  GroupBox M_LowerPanel;
        public  StaticText M_TagFormatName_Label;
        public  GroupBox M_TagPanel;
        public  TextField Number;
        public  TextField M_tbTagName;
        public  TextField M_tbTagName2;
        public  TextField M_tbTagName3;
        public  TextField M_tbTagName4;
        public  TextField M_tbTagName5;
        public  TextField M_tbTagValue;
        public  TextField M_tbTagValue2;
        public  TextField M_tbTagValue3;
        public  TextField M_tbTagValue4;
        public  TextField M_tbTagValue5;
        public  TextField M_tbTagValueMirror;
        public  TextField M_tbTagValueMirror2;
        public  GroupBox M_UserControlPanel;
        public  CustomWin M_UserCtrTagValue;
        public  GroupBox Panel1;
        public  GroupBox Panel12;
        public  GroupBox Panel13;
        public  GroupBox Panel14;
        public  GroupBox Panel15;
        public  GroupBox Panel_top;
        public  CustomWin TagComboUserControl;
        public  CustomWin TagComboUserControl2;
        public  CustomWin TagComboUserControl3;
        public  CustomWin TagUserControl;

        partial void OnInitialize();

        public AssignTagDLG()
        {
            InitializeComponent();
            OnInitialize();
        }

        private void InitializeComponent()
        {

            M_annotationCheckBox = new CheckBox()
            {
                Tag = "[CheckBox]$m_annotationCheckBox",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_annotationCheckBox);

            M_annotationComboBox = new ComboBox()
            {
                Tag = "[ComboBox]$m_annotationComboBox",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_annotationComboBox);

            M_annotationGroupBox = new GroupBox()
            {
                Tag = "[GroupBox]$m_annotationGroupBox",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_annotationGroupBox);

            M_annotationTextLabel = new StaticText()
            {
                Tag = "[StaticText]$m_annotationTextLabel",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_annotationTextLabel);

            M_Bottom_Panel = new GroupBox()
            {
                Tag = "[GroupBox]$m_Bottom_Panel",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_Bottom_Panel);

            M_btnCancel = new PushButton()
            {
                Tag = "[PushButton]$m_btnCancel",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_btnCancel);

            M_btnHelp = new PushButton()
            {
                Tag = "[PushButton]$m_btnHelp",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_btnHelp);

            M_btnOK = new PushButton()
            {
                Tag = "[PushButton]$m_btnOK",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_btnOK);

            AssignPB = new PushButton()
            {
                Tag = "[Pane]$m_Bottom_Panel|#2/[PushButton]Assign|$m_btnOK|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(AssignPB);

            M_cbType = new ComboBox()
            {
                Tag = "[ComboBox]$m_UserControlPanel",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_cbType);

            M_cbType2 = new ComboBox()
            {
                Tag = "[ComboBox]$m_UserControlPanel",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_cbType2);

            M_cbType3 = new ComboBox()
            {
                Tag = "[ComboBox]$m_UserControlPanel",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_cbType3);

            M_cbTypeTextField = new TextField()
            {
                Tag = "[TextField]$m_UserControlPanel",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_cbTypeTextField);

            M_cbTypeTextField2 = new TextField()
            {
                Tag = "[TextField]$m_UserControlPanel",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_cbTypeTextField2);

            M_cbTypeTextField3 = new TextField()
            {
                Tag = "[TextField]$m_UserControlPanel",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_cbTypeTextField3);

            M_CollapsibleButton = new CustomWin()
            {
                Tag = "[CustomWin]$m_CollapsibleButton",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_CollapsibleButton);

            M_lblClassName = new StaticText()
            {
                Tag = "[StaticText]$m_lblClassName",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_lblClassName);

            M_lblClassText = new StaticText()
            {
                Tag = "[StaticText]$m_lblClassText",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_lblClassText);

            M_lblTagFormatText = new StaticText()
            {
                Tag = "[StaticText]$m_lblTagFormatText",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_lblTagFormatText);

            M_LowerPanel = new GroupBox()
            {
                Tag = "[GroupBox]$m_LowerPanel",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_LowerPanel);

            M_TagFormatName_Label = new StaticText()
            {
                Tag = "[StaticText]$m_TagFormatName_Label",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_TagFormatName_Label);

            M_TagPanel = new GroupBox()
            {
                Tag = "[GroupBox]$m_TagPanel",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_TagPanel);

            Number = new TextField()
            {
                Tag = "[Pane]$panel_top|#1/[Pane]Line Number|$m_UserControlPanel|#2/[Pane]$TagUserControl|#1/[Pane]$panel1/[TextField]$m_tbTagValue",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Number);

            M_tbTagName = new TextField()
            {
                Tag = "[TextField]$m_UserControlPanel",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_tbTagName);

            M_tbTagName2 = new TextField()
            {
                Tag = "[TextField]$m_UserControlPanel",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_tbTagName2);

            M_tbTagName3 = new TextField()
            {
                Tag = "[TextField]$m_UserControlPanel",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_tbTagName3);

            M_tbTagName4 = new TextField()
            {
                Tag = "[TextField]$TagUserControl",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_tbTagName4);

            M_tbTagName5 = new TextField()
            {
                Tag = "[TextField]$m_UserCtrTagValue",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_tbTagName5);

            M_tbTagValue = new TextField()
            {
                Tag = "[TextField]$m_UserControlPanel",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_tbTagValue);

            M_tbTagValue2 = new TextField()
            {
                Tag = "[TextField]$m_UserControlPanel",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_tbTagValue2);

            M_tbTagValue3 = new TextField()
            {
                Tag = "[TextField]$m_UserControlPanel",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_tbTagValue3);

            M_tbTagValue4 = new TextField()
            {
                Tag = "[TextField]$TagUserControl",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_tbTagValue4);

            M_tbTagValue5 = new TextField()
            {
                Tag = "[TextField]$m_UserCtrTagValue",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_tbTagValue5);

            M_tbTagValueMirror = new TextField()
            {
                Tag = "[TextField]$TagUserControl",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_tbTagValueMirror);

            M_tbTagValueMirror2 = new TextField()
            {
                Tag = "[TextField]$m_UserCtrTagValue",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_tbTagValueMirror2);

            M_UserControlPanel = new GroupBox()
            {
                Tag = "[GroupBox]$m_UserControlPanel",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_UserControlPanel);

            M_UserCtrTagValue = new CustomWin()
            {
                Tag = "[CustomWin]$m_UserCtrTagValue",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_UserCtrTagValue);

            Panel1 = new GroupBox()
            {
                Tag = "[GroupBox]$m_UserControlPanel",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Panel1);

            Panel12 = new GroupBox()
            {
                Tag = "[GroupBox]$m_UserControlPanel",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Panel12);

            Panel13 = new GroupBox()
            {
                Tag = "[GroupBox]$m_UserControlPanel",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Panel13);

            Panel14 = new GroupBox()
            {
                Tag = "[GroupBox]$TagUserControl",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Panel14);

            Panel15 = new GroupBox()
            {
                Tag = "[GroupBox]$m_UserCtrTagValue",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Panel15);

            Panel_top = new GroupBox()
            {
                Tag = "[GroupBox]$panel_top",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Panel_top);

            TagComboUserControl = new CustomWin()
            {
                Tag = "[CustomWin]$m_UserControlPanel",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(TagComboUserControl);

            TagComboUserControl2 = new CustomWin()
            {
                Tag = "[CustomWin]$m_UserControlPanel",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(TagComboUserControl2);

            TagComboUserControl3 = new CustomWin()
            {
                Tag = "[CustomWin]$m_UserControlPanel",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(TagComboUserControl3);

            TagUserControl = new CustomWin()
            {
                Tag = "[CustomWin]$TagUserControl",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(TagUserControl);
        }
    }
}
