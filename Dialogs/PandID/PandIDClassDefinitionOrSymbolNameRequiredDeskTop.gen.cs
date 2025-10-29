// This file is auto-generated - do not hand edit this file.

using Autodesk.GUIHarness;
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{

    [UIElement(Tag = "[Pane]$SymbolSettingErrorMessageDlg")]
    public partial class PandIDClassDefinitionOrSymbolNameRequiredDeskTop : Autodesk.GUIHarness.AutoCAD.AcDialogBox
    {
        public  RadioButton RadioButton1RB;
        public  RadioButton RadioButton2RB;
        public  PushButton CancelPB;
        public  PushButton OKPB;
        public  PushButton ClosePB;

        partial void OnInitialize();

        public PandIDClassDefinitionOrSymbolNameRequiredDeskTop()
        {
            InitializeComponent();
            OnInitialize();
        }

        private void InitializeComponent()
        {

            RadioButton1RB = new RadioButton()
            {
                Tag = "[Pane]$panel1|#1/[RadioButton]$continueAddRadioBtn|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(RadioButton1RB);

            RadioButton2RB = new RadioButton()
            {
                Tag = "[Pane]$panel1|#1/[RadioButton]$resolveRadioBtn|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(RadioButton2RB);

            CancelPB = new PushButton()
            {
                Tag = "[Pane]$panel1|#1/[PushButton]Cancel |$cancelBtn|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(CancelPB);

            OKPB = new PushButton()
            {
                Tag = "[Pane]$panel1|#1/[PushButton]OK|$okBtn|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(OKPB);

            ClosePB = new PushButton()
            {
                Tag = "[TitleBar]Class Definition or Symbol Name Required|$TitleBar|#1/[PushButton]Close|$Close|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ClosePB);
        }
    }
}
