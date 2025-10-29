// This file is auto-generated - do not hand edit this file.

using Autodesk.GUIHarness;
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{

    [UIElement(Tag = "[DialogBox]Open", Parent = typeof(OpenPreviewDocumentDLG), GUIType = GuiType.UIA)]
    public partial class PreviewInvalidXMLDataErrorDLG : Autodesk.GUIHarness.AutoCAD.AcDialogBox
    {
        public  Pane OpenPANE;
        public  Pane PanePANE;
        public  Image MainInstructionIconIMG;
        public  StaticText PRNXprnxFileNotFoundST;
        public  PushButton OKPB;
        public  TitleBar OpenCTL;
        public  PushButton ClosePB;

        partial void OnInitialize();

        public PreviewInvalidXMLDataErrorDLG()
        {
            InitializeComponent();
            OnInitialize();
        }

        private void InitializeComponent()
        {

            OpenPANE = new Pane()
            {
                Tag = "[Pane]Open|$Window|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(OpenPANE);

            PanePANE = new Pane()
            {
                Tag = "[Pane]Open|$Window|#1/[Pane]#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(PanePANE);

            MainInstructionIconIMG = new Image()
            {
                Tag = "[Pane]Open|$Window|#1/[Image]MainInstructionIcon|$MainIcon|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(MainInstructionIconIMG);

            PRNXprnxFileNotFoundST = new StaticText()
            {
                Tag = "[Pane]Open|$Window|#1/[StaticText]PRNX*|$ContentText|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(PRNXprnxFileNotFoundST);

            OKPB = new PushButton()
            {
                Tag = "[Pane]Open|$Window|#1/[PushButton]OK|$CommandButton_1|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(OKPB);

            OpenCTL = new TitleBar()
            {
                Tag = "[TitleBar]Open|$TitleBar|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(OpenCTL);

            ClosePB = new PushButton()
            {
                Tag = "[TitleBar]Open|$TitleBar|#1/[PushButton]Close|$Close|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ClosePB);
        }
    }
}
