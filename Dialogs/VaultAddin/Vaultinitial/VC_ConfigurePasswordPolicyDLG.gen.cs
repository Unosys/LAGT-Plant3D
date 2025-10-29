// This file is auto-generated - do not hand edit this file.

using Autodesk.GUIHarness;
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{

    [UIElement(Tag = "[Pane]$ConfigurePasswordPolicyForm", Parent = typeof(VM_GlobalSettingsDLG))]
    public partial class VC_ConfigurePasswordPolicyDLG : Pane
    {
        public  PushButton HelpPB;
        public  PushButton CancelPB;
        public  PushButton OKPB;
        public  CheckBox MinimumPasswordLengthCK;
        public  CheckBox LowercaseCharactersCK;
        public  CheckBox UppercaseCharactersCK;
        public  CheckBox NumbersCK;
        public  CheckBox SpecialCharactersCK;
        public  CustomWin SpinWIN;
        public  PushButton ForwardPB;
        public  PushButton BackwardPB;

        partial void OnInitialize();

        public VC_ConfigurePasswordPolicyDLG()
        {
            InitializeComponent();
            OnInitialize();
        }

        private void InitializeComponent()
        {

            HelpPB = new PushButton()
            {
                Tag = "[PushButton]$m_helpButton",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(HelpPB);

            CancelPB = new PushButton()
            {
                Tag = "[PushButton]$m_cancelButton",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(CancelPB);

            OKPB = new PushButton()
            {
                Tag = "[PushButton]$m_okButton",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(OKPB);

            MinimumPasswordLengthCK = new CheckBox()
            {
                Tag = "[CheckBox]$m_minimumLengthCheckBox",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(MinimumPasswordLengthCK);

            LowercaseCharactersCK = new CheckBox()
            {
                Tag = "[CheckBox]$m_lowerCaseCheckBox",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(LowercaseCharactersCK);

            UppercaseCharactersCK = new CheckBox()
            {
                Tag = "[CheckBox]$m_upperCaseCheckBox",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(UppercaseCharactersCK);

            NumbersCK = new CheckBox()
            {
                Tag = "[CheckBox]$m_numberCheckBox",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(NumbersCK);

            SpecialCharactersCK = new CheckBox()
            {
                Tag = "[CheckBox]$m_specialCharCheckBox",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(SpecialCharactersCK);

            SpinWIN = new CustomWin()
            {
                Tag = "[CustomWin]$m_minimumLengthSpinEdit",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(SpinWIN);

            ForwardPB = new PushButton()
            {
                Tag = "[CustomWin]$m_minimumLengthSpinEdit/[PushButton]$SmallIncrement",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ForwardPB);

            BackwardPB = new PushButton()
            {
                Tag = "[CustomWin]$m_minimumLengthSpinEdit/[PushButton]$SmallDecrement",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(BackwardPB);
        }
    }
}
