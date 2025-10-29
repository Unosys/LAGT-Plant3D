// This file is auto-generated - do not hand edit this file.

using Autodesk.GUIHarness;
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{

    [UIElement(Tag = "[MainWin] AutoCAD Error Report", Parent = typeof(Desktop), GUIType = GuiType.WIN32)]
    public partial class ErrorReport : MainWin
    {
        public  StaticText EmailAddressST;
        public  TextField EmailAddressTF;
        public  StaticText DetailsST;
        public  TextField ProvidingAStepbystepDescriptionTF;
        public  PushButton ViewReportDetailsPB;
        public  PushButton SendReportPB;
        public  StaticText LearnMoreAboutHowST;
        public  StaticText ReadPrivacyPolicyST;
        public  StaticText ExampleDescriptionST;
        public  StaticText StaticTextST;
        public  StaticText ASoftwareProblemHasST;
        public  StaticText WeApologizeForTheST;
        public  StaticText ProvidingAStepbystepDescriptionST;
        public  StaticText QuicklyChecksForAST;
        public  StaticText DetailsYouProvideBelowST;
        public  StaticText IfYouIncludeYourST;
        public  StaticText BenefitsST;
        public  StaticText NoteDataGatheredWillST;

        partial void OnInitialize();

        public ErrorReport()
        {
            InitializeComponent();
            OnInitialize();
        }

        private void InitializeComponent()
        {

            EmailAddressST = new StaticText()
            {
                Tag = "[StaticText]Email Address:|$1016|#9",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(EmailAddressST);

            EmailAddressTF = new TextField()
            {
                Tag = "[TextField]Email Address:|$1017|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(EmailAddressTF);

            DetailsST = new StaticText()
            {
                Tag = "[StaticText]Details|$1010|#12",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(DetailsST);

            ProvidingAStepbystepDescriptionTF = new TextField()
            {
                Tag = "[TextField]Providing a step-by-step description of what you were doing when the problem occurred will help us resolve the issue:|$1012|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ProvidingAStepbystepDescriptionTF);

            ViewReportDetailsPB = new PushButton()
            {
                Tag = "[PushButton]View Report Details|$1031|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ViewReportDetailsPB);

            SendReportPB = new PushButton()
            {
                Tag = "[PushButton]Send Report|$1|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(SendReportPB);

            LearnMoreAboutHowST = new StaticText()
            {
                Tag = "[StaticText]Learn more about how error reports are used|$1038|#4",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(LearnMoreAboutHowST);

            ReadPrivacyPolicyST = new StaticText()
            {
                Tag = "[StaticText]Read Privacy Policy|$1029|#11",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ReadPrivacyPolicyST);

            ExampleDescriptionST = new StaticText()
            {
                Tag = "[StaticText]Example description|$1048|#14",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ExampleDescriptionST);

            StaticTextST = new StaticText()
            {
                Tag = "[StaticText]$1032|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(StaticTextST);

            ASoftwareProblemHasST = new StaticText()
            {
                Tag = "[StaticText]A software problem has caused AutoCAD Mechanical to close unexpectedly*|$1001|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ASoftwareProblemHasST);

            WeApologizeForTheST = new StaticText()
            {
                Tag = "[StaticText]We apologize for the inconvenience*|$1024|#3",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(WeApologizeForTheST);

            ProvidingAStepbystepDescriptionST = new StaticText()
            {
                Tag = "[StaticText]Providing a step-by-step description of what you were doing when the problem occurred will help us resolve the issue:|$1044|#13",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ProvidingAStepbystepDescriptionST);

            QuicklyChecksForAST = new StaticText()
            {
                Tag = "[StaticText]Quickly checks for a solution to the problem*|$1045|#6",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(QuicklyChecksForAST);

            DetailsYouProvideBelowST = new StaticText()
            {
                Tag = "[StaticText]Details you provide below may help us analyze and resolve the issue*|$1046|#7",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(DetailsYouProvideBelowST);

            IfYouIncludeYourST = new StaticText()
            {
                Tag = "[StaticText]If you include your email address, Autodesk may notify you when a solution becomes available or contact you regarding your error report*|$1047|#8",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(IfYouIncludeYourST);

            BenefitsST = new StaticText()
            {
                Tag = "[StaticText]Benefits|$1009|#5",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(BenefitsST);

            NoteDataGatheredWillST = new StaticText()
            {
                Tag = "[StaticText]Note: Data gathered will be used in accordance with the Autodesk Privacy Policy*|$-1|#10",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(NoteDataGatheredWillST);
        }
    }
}
