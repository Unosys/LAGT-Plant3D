// This file is auto-generated - do not hand edit this file.

using Autodesk.GUIHarness;
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{

    [UIElement(Tag = "[Pane]Report Wizard|$WizardView", Parent = typeof(Pane), GUIType = GuiType.UIA)]
    public partial class ReportLayoutWizardDLG : Pane
    {
        public  CustomWin BackButton;
        public  PushButton CancelButton;
        public  CustomWin ChkAdjustFields;
        public  CustomWin FinishButton;
        public  CustomWin GrpLayout;
        public  CustomWin GrpOrientation;
        public  GroupBox HeaderPanel;
        public  CustomWin HeaderPicture;
        public  GroupBox HeaderSeparator;
        public  CustomWin NextButton;
        public  CustomWin PicOrientation;
        public  CustomWin PicPreview;
        public  CustomWin RgrpLayout;
        public  CustomWin RgrpOrientation;
        public  GroupBox Separator;
        public  StaticText SubtitleLabel;
        public  StaticText TitleLabel;
        public  CustomWin WizPageGroupedLayout;

        partial void OnInitialize();

        public ReportLayoutWizardDLG()
        {
            InitializeComponent();
            OnInitialize();
        }

        private void InitializeComponent()
        {

            BackButton = new CustomWin()
            {
                Tag = "[CustomWin]$backButton",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(BackButton);

            CancelButton = new PushButton()
            {
                Tag = "[PushButton] Cancel |$cancelButton|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(CancelButton);

            ChkAdjustFields = new CustomWin()
            {
                Tag = "[CustomWin]$chkAdjustFields",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ChkAdjustFields);

            FinishButton = new CustomWin()
            {
                Tag = "[CustomWin]$finishButton",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(FinishButton);

            GrpLayout = new CustomWin()
            {
                Tag = "[CustomWin]$grpLayout",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(GrpLayout);

            GrpOrientation = new CustomWin()
            {
                Tag = "[CustomWin]$grpOrientation",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(GrpOrientation);

            HeaderPanel = new GroupBox()
            {
                Tag = "[GroupBox]$headerPanel",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(HeaderPanel);

            HeaderPicture = new CustomWin()
            {
                Tag = "[CustomWin]$headerPicture",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(HeaderPicture);

            HeaderSeparator = new GroupBox()
            {
                Tag = "[GroupBox]$headerSeparator",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(HeaderSeparator);

            NextButton = new CustomWin()
            {
                Tag = "[CustomWin]$nextButton",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(NextButton);

            PicOrientation = new CustomWin()
            {
                Tag = "[CustomWin]$picOrientation",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(PicOrientation);

            PicPreview = new CustomWin()
            {
                Tag = "[CustomWin]$picPreview",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(PicPreview);

            RgrpLayout = new CustomWin()
            {
                Tag = "[CustomWin]$rgrpLayout",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(RgrpLayout);

            RgrpOrientation = new CustomWin()
            {
                Tag = "[CustomWin]$rgrpOrientation",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(RgrpOrientation);

            Separator = new GroupBox()
            {
                Tag = "[GroupBox]$separator",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Separator);

            SubtitleLabel = new StaticText()
            {
                Tag = "[StaticText]$subtitleLabel",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(SubtitleLabel);

            TitleLabel = new StaticText()
            {
                Tag = "[StaticText]$titleLabel",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(TitleLabel);

            WizPageGroupedLayout = new CustomWin()
            {
                Tag = "[CustomWin]$WizPageGroupedLayout",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(WizPageGroupedLayout);
        }
    }
}
