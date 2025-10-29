// This file is auto-generated - do not hand edit this file.

using Autodesk.GUIHarness;
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{

    [UIElement(Tag = "[Pane]$DefineExpressionDlg")]
    public partial class P3DTagDefineExpressionDLG : Pane
    {
        public  PushButton M_cancelButton;
        public  PushButton OKPB;
        public  CheckBox M_autogenerateCheckBox;
        public  RadioButton M_drawingFieldRadioButton;
        public  PushButton M_projectFieldButton;
        public  RadioButton M_projectFieldRadioButton;
        public  PushButton M_drawingFieldButton;

        partial void OnInitialize();

        public P3DTagDefineExpressionDLG()
        {
            InitializeComponent();
            OnInitialize();
        }

        private void InitializeComponent()
        {

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

            M_autogenerateCheckBox = new CheckBox()
            {
                Tag = "[GroupBox]Autogenerate|$m_autogenerateGroup|#3/[CheckBox]Autogenerate expression|$m_autogenerateCheckBox|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_autogenerateCheckBox);

            M_drawingFieldRadioButton = new RadioButton()
            {
                Tag = "[GroupBox]Autogenerate|$m_autogenerateGroup|#3/[RadioButton]$m_drawingFieldRadioButton|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_drawingFieldRadioButton);

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

            M_drawingFieldButton = new PushButton()
            {
                Tag = "[GroupBox]Autogenerate|$m_autogenerateGroup|#3/[PushButton]$m_drawingFieldButton|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_drawingFieldButton);
        }
    }
}
