// This file is auto-generated - do not hand edit this file.

using Autodesk.GUIHarness;
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{

    [UIElement(Tag = "[Pane]Report Wizard|#2", Parent = typeof(ReportWizardDLG), GUIType = GuiType.UIA)]
    public partial class ReportWizardSelectFieldsDLG : Pane
    {
        public  PushButton OKPB;
        public  TitleBar ReportWizardCTL;
        public  PushButton ClosePB;
        public  Image ReportWizardIMG;
        public  StaticText YouMustSelectFieldsST;

        partial void OnInitialize();

        public ReportWizardSelectFieldsDLG()
        {
            InitializeComponent();
            OnInitialize();
        }

        private void InitializeComponent()
        {

            OKPB = new PushButton()
            {
                Tag = "[PushButton]*OK*|$7541188|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(OKPB);

            ReportWizardCTL = new TitleBar()
            {
                Tag = "[TitleBar]Report Wizard|$TitleBar|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ReportWizardCTL);

            ClosePB = new PushButton()
            {
                Tag = "[TitleBar]Report Wizard|$TitleBar|#1/[PushButton]Close|$Close|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ClosePB);

            ReportWizardIMG = new Image()
            {
                Tag = "[Image]Report Wizard|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ReportWizardIMG);

            YouMustSelectFieldsST = new StaticText()
            {
                Tag = "[StaticText]You must select fields for the report before you continue|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(YouMustSelectFieldsST);
        }
    }
}
