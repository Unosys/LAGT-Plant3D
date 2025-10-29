// This file is auto-generated - do not hand edit this file.

using Autodesk.GUIHarness;
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{

    [UIElement(Tag = "[DialogBox]Publish*", Parent = typeof(DialogBox))]
    public partial class PandIDPublishSaveSheetListTaskDLG : Autodesk.GUIHarness.AutoCAD.AcDialogBox
    {
        public  Pane PublishSaveSheetPANE;
        public  Pane Pane1PANE;
        public  Pane Pane2PANE;
        public  Pane Pane3PANE;
        public  Image MainInstructionIconIMG;
        public  StaticText DoYouWantToST;
        public  CheckBox AlwaysPerformMyCurrentCK;
        public  PushButton YesPB;
        public  PushButton NoPB;
        public  PushButton CancelPB;

        partial void OnInitialize();

        public PandIDPublishSaveSheetListTaskDLG()
        {
            InitializeComponent();
            OnInitialize();
        }

        private void InitializeComponent()
        {

            PublishSaveSheetPANE = new Pane()
            {
                Tag = "[Pane]Publish - Save Sheet List|$Window|#1",
                ParentType = this.GetType(),
                Parent = this,
                GUIType = GuiType.UIA,
            };
            DeclaredChildren.Add(PublishSaveSheetPANE);

            Pane1PANE = new Pane()
            {
                Tag = "[Pane]Publish - Save Sheet List|$Window|#1/[Pane]#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Pane1PANE);

            Pane2PANE = new Pane()
            {
                Tag = "[Pane]Publish - Save Sheet List|$Window|#1/[Pane]#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Pane2PANE);

            Pane3PANE = new Pane()
            {
                Tag = "[Pane]Publish - Save Sheet List|$Window|#1/[Pane]#3",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Pane3PANE);

            MainInstructionIconIMG = new Image()
            {
                Tag = "[Pane]Publish - Save Sheet List|$Window|#1/[Image]MainInstructionIcon|$MainIcon|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(MainInstructionIconIMG);

            DoYouWantToST = new StaticText()
            {
                Tag = "[Pane]Publish - Save Sheet List|$Window|#1/[StaticText]Do you want to save the current list of sheets?|$MainInstruction|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(DoYouWantToST);

            AlwaysPerformMyCurrentCK = new CheckBox()
            {
                Tag = "[Pane]Publish - Save Sheet List|$Window|#1/[CheckBox]Always perform my current choice|$VerificationCheckBox|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(AlwaysPerformMyCurrentCK);

            YesPB = new PushButton()
            {
                Tag = "[Pane]Publish - Save Sheet List|$Window|#1/[PushButton]Yes|$CommandButton_6|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(YesPB);

            NoPB = new PushButton()
            {
                Tag = "[Pane]Publish - Save Sheet List|$Window|#1/[PushButton]No|$CommandButton_7|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(NoPB);

            CancelPB = new PushButton()
            {
                Tag = "[Pane]Publish - Save Sheet List|$Window|#1/[PushButton]Cancel|$CommandButton_2|#3",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(CancelPB);
        }
    }
}
