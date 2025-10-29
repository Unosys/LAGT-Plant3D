// This file is auto-generated - do not hand edit this file.

using Autodesk.GUIHarness;
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{

    [UIElement(Tag = "[DialogBox]Data collection and use", Parent = typeof(MainWin), GUIType = GuiType.WIN32)]
    public partial class DataCollectionAndUseDLG : Autodesk.GUIHarness.AutoCAD.AcDialogBox
    {
        public  PushButton OKPB;
        public  StaticText DataCollectionAndUseST;
        public  StaticText AutodeskAnalyticsProgramsHelpST;
        public  CheckBox IAgreeToDataCK;
        public  Link LearnMoreLINK;
        public  Link Link1LINK;
        public  Link AutodesksPrivacyStatementLINK;
        public  Link Link2LINK;

        partial void OnInitialize();

        public DataCollectionAndUseDLG()
        {
            InitializeComponent();
            OnInitialize();
        }

        private void InitializeComponent()
        {

            OKPB = new PushButton()
            {
                Tag = "[PushButton]OK|$1|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(OKPB);

            DataCollectionAndUseST = new StaticText()
            {
                Tag = "[StaticText]Data collection and use|$1002|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(DataCollectionAndUseST);

            AutodeskAnalyticsProgramsHelpST = new StaticText()
            {
                Tag = "[StaticText]Autodesk analytics programs help us understand how our customers use our products and services so we can personalize your experience and build better online, mobile, and desktop applications*|$1003|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(AutodeskAnalyticsProgramsHelpST);

            IAgreeToDataCK = new CheckBox()
            {
                Tag = "[CheckBox]I agree to data collection in desktop products for Autodesk analytics programs*|$1004|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(IAgreeToDataCK);

            LearnMoreLINK = new Link()
            {
                Tag = "[Link]Learn more|$1005|#1",
                ParentType = this.GetType(),
                Parent = this,
                GUIType = GuiType.UIA,
            };
            DeclaredChildren.Add(LearnMoreLINK);

            Link1LINK = new Link()
            {
                Tag = "[Link]Learn more|$1005|#1/[Link]#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Link1LINK);

            AutodesksPrivacyStatementLINK = new Link()
            {
                Tag = "[Link]Autodesk's Privacy Statement|$1006|#2",
                ParentType = this.GetType(),
                Parent = this,
                GUIType = GuiType.UIA,
            };
            DeclaredChildren.Add(AutodesksPrivacyStatementLINK);

            Link2LINK = new Link()
            {
                Tag = "[Link]Autodesk's Privacy Statement|$1006|#2/[Link]#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Link2LINK);
        }
    }
}
