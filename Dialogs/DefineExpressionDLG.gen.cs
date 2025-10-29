// This file is auto-generated - do not hand edit this file.

using Autodesk.GUIHarness;
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{

    [UIElement(Tag = "[DialogBox]$DefineExpressionDlg", Parent = typeof(Plant3D))]
    public partial class DefineExpressionDLG : Autodesk.GUIHarness.AutoCAD.AcDialogBox
    {
        public  CheckBox M_autogenerateCheckBox;
        public  GroupBox M_autogenerateGroup;
        public  PushButton M_cancelButton;
        public  PushButton M_drawingFieldButton;
        public  RadioButton M_drawingFieldRadioButton;
        public  TextField M_drawingFieldTextBox;
        public  GroupBox M_expressionGroup;
        public  CheckBox M_fixedCharacterLengthCheckBox;
        public  UpDown M_fixedCharacterLengthUpDown;
        public  CustomWin M_fixedCharacterLengthUpDownControl;
        public  CheckBox M_fixedNumberLengthCheckBox;
        public  UpDown M_fixedNumberLengthUpDown;
        public  CustomWin M_fixedNumberLengthUpDownControl;
        public  PushButton M_helpButton;
        public  CheckBox M_manuallyDefineCheckBox;
        public  TextField M_manuallyDefinedExpressionTextBox;
        public  CheckBox M_noExpressioncheckBox;
        public  RadioButton M_numbersRadioButton;
        public  PushButton M_okButton;
        public  PushButton M_projectFieldButton;
        public  RadioButton M_projectFieldRadioButton;
        public  TextField M_projectFieldTextBox;
        public  GroupBox M_resultGroup;
        public  RadioButton M_textCharactersRadioButton;
        public  CheckBox M_uppercaseCheckBox;

        partial void OnInitialize();

        public DefineExpressionDLG()
        {
            InitializeComponent();
            OnInitialize();
        }

        private void InitializeComponent()
        {

            M_autogenerateCheckBox = new CheckBox()
            {
                Tag = "[CheckBox]$m_autogenerateCheckBox",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_autogenerateCheckBox);

            M_autogenerateGroup = new GroupBox()
            {
                Tag = "[GroupBox]$m_autogenerateGroup",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_autogenerateGroup);

            M_cancelButton = new PushButton()
            {
                Tag = "[PushButton]$m_cancelButton",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_cancelButton);

            M_drawingFieldButton = new PushButton()
            {
                Tag = "[PushButton]$m_drawingFieldButton",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_drawingFieldButton);

            M_drawingFieldRadioButton = new RadioButton()
            {
                Tag = "[RadioButton]$m_drawingFieldRadioButton",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_drawingFieldRadioButton);

            M_drawingFieldTextBox = new TextField()
            {
                Tag = "[TextField]$m_drawingFieldTextBox",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_drawingFieldTextBox);

            M_expressionGroup = new GroupBox()
            {
                Tag = "[GroupBox]$m_expressionGroup",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_expressionGroup);

            M_fixedCharacterLengthCheckBox = new CheckBox()
            {
                Tag = "[CheckBox]$m_fixedCharacterLengthCheckBox",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_fixedCharacterLengthCheckBox);

            M_fixedCharacterLengthUpDown = new UpDown()
            {
                Tag = "[UpDown]$m_fixedCharacterLengthUpDown",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_fixedCharacterLengthUpDown);

            M_fixedCharacterLengthUpDownControl = new CustomWin()
            {
                Tag = "[CustomWin]$m_fixedCharacterLengthUpDown",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_fixedCharacterLengthUpDownControl);

            M_fixedNumberLengthCheckBox = new CheckBox()
            {
                Tag = "[CheckBox]$m_fixedNumberLengthCheckBox",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_fixedNumberLengthCheckBox);

            M_fixedNumberLengthUpDown = new UpDown()
            {
                Tag = "[UpDown]$m_fixedNumberLengthUpDown",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_fixedNumberLengthUpDown);

            M_fixedNumberLengthUpDownControl = new CustomWin()
            {
                Tag = "[CustomWin]$m_fixedNumberLengthUpDown",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_fixedNumberLengthUpDownControl);

            M_helpButton = new PushButton()
            {
                Tag = "[PushButton]$m_helpButton",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_helpButton);

            M_manuallyDefineCheckBox = new CheckBox()
            {
                Tag = "[CheckBox]$m_manuallyDefineCheckBox",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_manuallyDefineCheckBox);

            M_manuallyDefinedExpressionTextBox = new TextField()
            {
                Tag = "[TextField]$m_manuallyDefinedExpressionTextBox",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_manuallyDefinedExpressionTextBox);

            M_noExpressioncheckBox = new CheckBox()
            {
                Tag = "[CheckBox]$m_noExpressioncheckBox",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_noExpressioncheckBox);

            M_numbersRadioButton = new RadioButton()
            {
                Tag = "[RadioButton]$m_numbersRadioButton",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_numbersRadioButton);

            M_okButton = new PushButton()
            {
                Tag = "[PushButton]$m_okButton",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_okButton);

            M_projectFieldButton = new PushButton()
            {
                Tag = "[PushButton]$m_projectFieldButton",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_projectFieldButton);

            M_projectFieldRadioButton = new RadioButton()
            {
                Tag = "[RadioButton]$m_projectFieldRadioButton",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_projectFieldRadioButton);

            M_projectFieldTextBox = new TextField()
            {
                Tag = "[TextField]$m_projectFieldTextBox",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_projectFieldTextBox);

            M_resultGroup = new GroupBox()
            {
                Tag = "[GroupBox]$m_resultGroup",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_resultGroup);

            M_textCharactersRadioButton = new RadioButton()
            {
                Tag = "[RadioButton]$m_textCharactersRadioButton",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_textCharactersRadioButton);

            M_uppercaseCheckBox = new CheckBox()
            {
                Tag = "[CheckBox]$m_uppercaseCheckBox",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_uppercaseCheckBox);
        }
    }
}
