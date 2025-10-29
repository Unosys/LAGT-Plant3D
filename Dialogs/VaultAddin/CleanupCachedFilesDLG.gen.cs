// This file is auto-generated - do not hand edit this file.

using Autodesk.GUIHarness;
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{

    [UIElement(Tag = "[DialogBox]Cleanup Cached Files", Parent = typeof(CustomWin), GUIType = GuiType.WIN32)]
    public partial class CleanupCachedFilesDLG : Autodesk.GUIHarness.AutoCAD.AcDialogBox
    {
        public  Pane CleanupCachedFilesPANE;
        public  Pane Pane1PANE;
        public  Pane Pane2PANE;
        public  Image MainInstructionIconIMG;
        public  StaticText CleanupLocallyCachedFilesST;
        public  StaticText FilesThatAreNotST;
        public  CheckBox AlwaysCleanupLocallyCachedCK;
        public  PushButton DeleteFilesPB;
        public  PushButton CancelPB;

        partial void OnInitialize();

        public CleanupCachedFilesDLG()
        {
            InitializeComponent();
            OnInitialize();
        }

        private void InitializeComponent()
        {

            CleanupCachedFilesPANE = new Pane()
            {
                Tag = "[Pane]Cleanup Cached Files|$Window|#1",
                ParentType = this.GetType(),
                Parent = this,
                GUIType = GuiType.UIA,
            };
            DeclaredChildren.Add(CleanupCachedFilesPANE);

            Pane1PANE = new Pane()
            {
                Tag = "[Pane]Cleanup Cached Files|$Window|#1/[Pane]#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Pane1PANE);

            Pane2PANE = new Pane()
            {
                Tag = "[Pane]Cleanup Cached Files|$Window|#1/[Pane]#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Pane2PANE);

            MainInstructionIconIMG = new Image()
            {
                Tag = "[Pane]Cleanup Cached Files|$Window|#1/[Image]MainInstructionIcon|$MainIcon|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(MainInstructionIconIMG);

            CleanupLocallyCachedFilesST = new StaticText()
            {
                Tag = "[Pane]Cleanup Cached Files|$Window|#1/[StaticText]Cleanup Locally Cached Files|$MainInstruction|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(CleanupLocallyCachedFilesST);

            FilesThatAreNotST = new StaticText()
            {
                Tag = "[Pane]Cleanup Cached Files|$Window|#1/[StaticText]Files that are not checked-out will be removed from the local workspace*|$ContentText|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(FilesThatAreNotST);

            AlwaysCleanupLocallyCachedCK = new CheckBox()
            {
                Tag = "[Pane]Cleanup Cached Files|$Window|#1/[CheckBox]Always cleanup locally cached files*|$VerificationCheckBox|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(AlwaysCleanupLocallyCachedCK);

            DeleteFilesPB = new PushButton()
            {
                Tag = "[Pane]Cleanup Cached Files|$Window|#1/[PushButton]Delete Files|$CommandButton_1001|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(DeleteFilesPB);

            CancelPB = new PushButton()
            {
                Tag = "[Pane]Cleanup Cached Files|$Window|#1/[PushButton]Cancel|$CommandButton_2|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(CancelPB);
        }
    }
}
