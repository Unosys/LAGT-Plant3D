// This file is auto-generated - do not hand edit this file.

using Autodesk.GUIHarness;
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{

    [UIElement(Tag = "[DialogBox]Sharing Project to the Cloud|#1", Parent = typeof(Window), GUIType = GuiType.UIA)]
    public partial class SharingProjectToTheCloudDLG : Autodesk.GUIHarness.AutoCAD.AcDialogBox
    {
        public  Pane SharingProjectToThePANE;
        public  Pane Pane1PANE;
        public  Pane Pane2PANE;
        public  Pane Pane3PANE;
        public  Image MainInstructionIconIMG;
        public  StaticText WeAreCurrentlySharingST;
        public  StaticText StoppingThisProcessWillST;
        public  PushButton ContinueSharingMyProjectPB;
        public  PushButton StopSharingMyProjectPB;
        public  PushButton CancelPB;
        public  TitleBar SharingProjectToTheCTL;
        public  PushButton ClosePB;

        partial void OnInitialize();

        public SharingProjectToTheCloudDLG()
        {
            InitializeComponent();
            OnInitialize();
        }

        private void InitializeComponent()
        {

            SharingProjectToThePANE = new Pane()
            {
                Tag = "[Pane]Sharing Project to the Cloud|$Window|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(SharingProjectToThePANE);

            Pane1PANE = new Pane()
            {
                Tag = "[Pane]Sharing Project to the Cloud|$Window|#1/[Pane]#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Pane1PANE);

            Pane2PANE = new Pane()
            {
                Tag = "[Pane]Sharing Project to the Cloud|$Window|#1/[Pane]#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Pane2PANE);

            Pane3PANE = new Pane()
            {
                Tag = "[Pane]Sharing Project to the Cloud|$Window|#1/[Pane]#3",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Pane3PANE);

            MainInstructionIconIMG = new Image()
            {
                Tag = "[Pane]Sharing Project to the Cloud|$Window|#1/[Image]MainInstructionIcon|$MainIcon|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(MainInstructionIconIMG);

            WeAreCurrentlySharingST = new StaticText()
            {
                Tag = "[Pane]Sharing Project to the Cloud|$Window|#1/[StaticText]We are currently sharing your project to the cloud*|$MainInstruction|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(WeAreCurrentlySharingST);

            StoppingThisProcessWillST = new StaticText()
            {
                Tag = "[Pane]Sharing Project to the Cloud|$Window|#1/[StaticText]Stopping this process will make your new Collaboration project in the cloud incomplete, and you should not use it*|$ContentText|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(StoppingThisProcessWillST);

            ContinueSharingMyProjectPB = new PushButton()
            {
                Tag = "[Pane]Sharing Project to the Cloud|$Window|#1/[PushButton]Continue Sharing my Project|$CommandLink_1001|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ContinueSharingMyProjectPB);

            StopSharingMyProjectPB = new PushButton()
            {
                Tag = "[Pane]Sharing Project to the Cloud|$Window|#1/[PushButton]Stop Sharing my Project|$CommandLink_1002|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(StopSharingMyProjectPB);

            CancelPB = new PushButton()
            {
                Tag = "[Pane]Sharing Project to the Cloud|$Window|#1/[PushButton]Cancel|$CommandButton_2|#3",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(CancelPB);

            SharingProjectToTheCTL = new TitleBar()
            {
                Tag = "[TitleBar]Sharing Project to the Cloud|$TitleBar|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(SharingProjectToTheCTL);

            ClosePB = new PushButton()
            {
                Tag = "[TitleBar]Sharing Project to the Cloud|$TitleBar|#1/[PushButton]Close|$Close|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ClosePB);
        }
    }
}
