// This file is auto-generated - do not hand edit this file.

using Autodesk.GUIHarness;
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{

    [UIElement(Tag = "[Window]$Window_1", Parent = typeof(Desktop), GUIType = GuiType.UIA)]
    public partial class SelectExcelFilesValidatingDLG : Window
    {
        public  DialogBox DialogBoxDLG;
        public  PushButton OKPB;
        public  StaticText NoExcelInstallationWasST;
        public  TitleBar TitleBarCTL;
        public  PushButton ClosePB;
        public  StaticText ValidatingST;
        public  CustomWin CustomWinWIN;
        public  StaticText StaticTextST;

        partial void OnInitialize();

        public SelectExcelFilesValidatingDLG()
        {
            InitializeComponent();
            OnInitialize();
        }

        private void InitializeComponent()
        {

            DialogBoxDLG = new DialogBox()
            {
                Tag = "[DialogBox]#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(DialogBoxDLG);

            OKPB = new PushButton()
            {
                Tag = "[DialogBox]#1/[PushButton]OK|$2|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(OKPB);

            NoExcelInstallationWasST = new StaticText()
            {
                Tag = "[DialogBox]#1/[StaticText]No Excel installation was found|$65535|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(NoExcelInstallationWasST);

            TitleBarCTL = new TitleBar()
            {
                Tag = "[DialogBox]#1/[TitleBar]$TitleBar|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(TitleBarCTL);

            ClosePB = new PushButton()
            {
                Tag = "[DialogBox]#1/[TitleBar]$TitleBar|#1/[PushButton]Close|$Close|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ClosePB);

            ValidatingST = new StaticText()
            {
                Tag = "[StaticText]Validating|$MainText|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ValidatingST);

            CustomWinWIN = new CustomWin()
            {
                Tag = "[CustomWin]$MainProgessBar|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(CustomWinWIN);

            StaticTextST = new StaticText()
            {
                Tag = "[StaticText]$CurrentOperationText|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(StaticTextST);
        }
    }
}
