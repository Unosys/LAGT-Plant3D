// This file is auto-generated - do not hand edit this file.

using Autodesk.GUIHarness;
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{

    [UIElement(Tag = "[Pane]$DefineExpressionDlg")]
    public partial class P3DAnnotationDefineExpressionDLG : Pane
    {
        public  PushButton HelpPB;
        public  PushButton M_cancelButton;
        public  PushButton OKPB;
        public  GroupBox AutogenerateGB;
        public  TextField TextField1TF;
        public  PushButton M_drawingFieldButton;
        public  RadioButton M_drawingFieldRadioButton;
        public  TextField TextField2TF;
        public  PushButton M_projectFieldButton;
        public  RadioButton M_projectFieldRadioButton;
        public  CheckBox M_autogenerateCheckBox;
        public  GroupBox ResultGB;
        public  CheckBox M_noExpressioncheckBox;
        public  TextField TextField3TF;
        public  CheckBox ManuallyDefineExpressionCK;
        public  GroupBox ExpressionGB;
        public  CustomWin CustomWin1WIN;
        public  CustomWin Spinner1WIN;
        public  PushButton Forward1PB;
        public  PushButton Backward1PB;
        public  CustomWin one1WIN;
        public  CustomWin CustomWin2WIN;
        public  CustomWin Spinner2WIN;
        public  PushButton Forward2PB;
        public  PushButton Backward2PB;
        public  CustomWin one2WIN;
        public  CheckBox FixedLength1CK;
        public  CheckBox FixedLength2CK;
        public  CheckBox UppercaseCK;
        public  RadioButton RadioButton3RB;
        public  RadioButton RadioButton4RB;
        public  TitleBar DefineExpressionCTL;
        public  CustomWin SystemMenuBarWIN;
        public  MenuItem SystemMI;
        public  PushButton ClosePB;

        partial void OnInitialize();

        public P3DAnnotationDefineExpressionDLG()
        {
            InitializeComponent();
            OnInitialize();
        }

        private void InitializeComponent()
        {

            HelpPB = new PushButton()
            {
                Tag = "[PushButton]Help|$m_helpButton|#3",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(HelpPB);

            M_cancelButton = new PushButton()
            {
                Tag = "[PushButton]Cancel|$m_cancelButton|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_cancelButton);

            OKPB = new PushButton()
            {
                Tag = "[PushButton]OK|$m_okButton|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(OKPB);

            AutogenerateGB = new GroupBox()
            {
                Tag = "[GroupBox]Autogenerate|$m_autogenerateGroup|#3",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(AutogenerateGB);

            TextField1TF = new TextField()
            {
                Tag = "[GroupBox]Autogenerate|$m_autogenerateGroup|#3/[TextField]$m_drawingFieldTextBox|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(TextField1TF);

            M_drawingFieldButton = new PushButton()
            {
                Tag = "[GroupBox]Autogenerate|$m_autogenerateGroup|#3/[PushButton]$m_drawingFieldButton|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_drawingFieldButton);

            M_drawingFieldRadioButton = new RadioButton()
            {
                Tag = "[GroupBox]Autogenerate|$m_autogenerateGroup|#3/[RadioButton]$m_drawingFieldRadioButton|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_drawingFieldRadioButton);

            TextField2TF = new TextField()
            {
                Tag = "[GroupBox]Autogenerate|$m_autogenerateGroup|#3/[TextField]$m_projectFieldTextBox|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(TextField2TF);

            M_projectFieldButton = new PushButton()
            {
                Tag = "[GroupBox]Autogenerate|$m_autogenerateGroup|#3/[PushButton]$m_projectFieldButton|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_projectFieldButton);

            M_projectFieldRadioButton = new RadioButton()
            {
                Tag = "[GroupBox]Autogenerate|$m_autogenerateGroup|#3/[RadioButton]$m_projectFieldRadioButton|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_projectFieldRadioButton);

            M_autogenerateCheckBox = new CheckBox()
            {
                Tag = "[GroupBox]Autogenerate|$m_autogenerateGroup|#3/[CheckBox]Autogenerate expression|$m_autogenerateCheckBox|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_autogenerateCheckBox);

            ResultGB = new GroupBox()
            {
                Tag = "[GroupBox]Result|$m_resultGroup|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ResultGB);

            M_noExpressioncheckBox = new CheckBox()
            {
                Tag = "[GroupBox]Result|$m_resultGroup|#2/[CheckBox]No expression (free style value)|$m_noExpressioncheckBox|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_noExpressioncheckBox);

            TextField3TF = new TextField()
            {
                Tag = "[GroupBox]Result|$m_resultGroup|#2/[TextField]$m_manuallyDefinedExpressionTextBox|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(TextField3TF);

            ManuallyDefineExpressionCK = new CheckBox()
            {
                Tag = "[GroupBox]Result|$m_resultGroup|#2/[CheckBox]Manually define expression|$m_manuallyDefineCheckBox|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ManuallyDefineExpressionCK);

            ExpressionGB = new GroupBox()
            {
                Tag = "[GroupBox]Expression|$m_expressionGroup|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ExpressionGB);

            CustomWin1WIN = new CustomWin()
            {
                Tag = "[GroupBox]Expression|$m_expressionGroup|#1/[CustomWin]$m_fixedNumberLengthNumericUpDown|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(CustomWin1WIN);

            Spinner1WIN = new CustomWin()
            {
                Tag = "[GroupBox]Expression|$m_expressionGroup|#1/[CustomWin]$m_fixedNumberLengthNumericUpDown|#2/[CustomWin]Spinner|$7410058|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Spinner1WIN);

            Forward1PB = new PushButton()
            {
                Tag = "[GroupBox]Expression|$m_expressionGroup|#1/[CustomWin]$m_fixedNumberLengthNumericUpDown|#2/[CustomWin]Spinner|$7410058|#2/[PushButton]Forward|$SmallIncrement|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Forward1PB);

            Backward1PB = new PushButton()
            {
                Tag = "[GroupBox]Expression|$m_expressionGroup|#1/[CustomWin]$m_fixedNumberLengthNumericUpDown|#2/[CustomWin]Spinner|$7410058|#2/[PushButton]Backward|$SmallDecrement|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Backward1PB);

            one1WIN = new CustomWin()
            {
                Tag = "[GroupBox]Expression|$m_expressionGroup|#1/[CustomWin]$m_fixedNumberLengthNumericUpDown|#2/[CustomWin]1|$m_fixedNumberLengthNumericUpDown|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(one1WIN);

            CustomWin2WIN = new CustomWin()
            {
                Tag = "[GroupBox]Expression|$m_expressionGroup|#1/[CustomWin]$m_fixedCharacterLengthNumericUpDown|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(CustomWin2WIN);

            Spinner2WIN = new CustomWin()
            {
                Tag = "[GroupBox]Expression|$m_expressionGroup|#1/[CustomWin]$m_fixedCharacterLengthNumericUpDown|#1/[CustomWin]Spinner|$12259318|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Spinner2WIN);

            Forward2PB = new PushButton()
            {
                Tag = "[GroupBox]Expression|$m_expressionGroup|#1/[CustomWin]$m_fixedCharacterLengthNumericUpDown|#1/[CustomWin]Spinner|$12259318|#2/[PushButton]Forward|$SmallIncrement|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Forward2PB);

            Backward2PB = new PushButton()
            {
                Tag = "[GroupBox]Expression|$m_expressionGroup|#1/[CustomWin]$m_fixedCharacterLengthNumericUpDown|#1/[CustomWin]Spinner|$12259318|#2/[PushButton]Backward|$SmallDecrement|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Backward2PB);

            one2WIN = new CustomWin()
            {
                Tag = "[GroupBox]Expression|$m_expressionGroup|#1/[CustomWin]$m_fixedCharacterLengthNumericUpDown|#1/[CustomWin]1|$m_fixedCharacterLengthNumericUpDown|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(one2WIN);

            FixedLength1CK = new CheckBox()
            {
                Tag = "[GroupBox]Expression|$m_expressionGroup|#1/[CheckBox]Fixed Length[1]|$m_fixedNumberLengthCheckBox|#3",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(FixedLength1CK);

            FixedLength2CK = new CheckBox()
            {
                Tag = "[GroupBox]Expression|$m_expressionGroup|#1/[CheckBox]Fixed Length[2]|$m_fixedCharacterLengthCheckBox|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(FixedLength2CK);

            UppercaseCK = new CheckBox()
            {
                Tag = "[GroupBox]Expression|$m_expressionGroup|#1/[CheckBox]Uppercase|$m_uppercaseCheckBox|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(UppercaseCK);

            RadioButton3RB = new RadioButton()
            {
                Tag = "[GroupBox]Expression|$m_expressionGroup|#1/[RadioButton]$m_numbersRadioButton|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(RadioButton3RB);

            RadioButton4RB = new RadioButton()
            {
                Tag = "[GroupBox]Expression|$m_expressionGroup|#1/[RadioButton]$m_textCharactersRadioButton|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(RadioButton4RB);

            DefineExpressionCTL = new TitleBar()
            {
                Tag = "[TitleBar]Define Expression|$TitleBar|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(DefineExpressionCTL);

            SystemMenuBarWIN = new CustomWin()
            {
                Tag = "[TitleBar]Define Expression|$TitleBar|#1/[CustomWin]System Menu Bar|$DefineExpressionDlg|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(SystemMenuBarWIN);

            SystemMI = new MenuItem()
            {
                Tag = "[TitleBar]Define Expression|$TitleBar|#1/[CustomWin]System Menu Bar|$DefineExpressionDlg|#1/[MenuItem]System|$Item 1|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(SystemMI);

            ClosePB = new PushButton()
            {
                Tag = "[TitleBar]Define Expression|$TitleBar|#1/[PushButton]Close|$Close|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ClosePB);
        }
    }
}
