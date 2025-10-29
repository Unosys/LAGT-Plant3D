// This file is auto-generated - do not hand edit this file.

using Autodesk.GUIHarness;
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{

    [UIElement(Tag = "[DialogBox]#1", Parent = typeof(Plant3D), GUIType = GuiType.WIN32)]
    public partial class BlockChangesNotSavedDLG2 : Autodesk.GUIHarness.AutoCAD.AcDialogBox
    {
        public  Pane BlockChangesNotPANE;
        public  Pane Pane1PANE;
        public  Pane Pane2PANE;
        public  Pane Pane3PANE;
        public  Image MainInstructionIconIMG;
        public  StaticText TheChangesYouMadeST;
        public  PushButton SaveTheChangesToPB;
        public  PushButton DiscardTheChangesAndPB;
        public  PushButton CancelPB;

        partial void OnInitialize();

        public BlockChangesNotSavedDLG2()
        {
            InitializeComponent();
            OnInitialize();
        }

        private void InitializeComponent()
        {

            BlockChangesNotPANE = new Pane()
            {
                Tag = "[Pane]Block - Changes Not Saved|$Window",
                ParentType = this.GetType(),
                Parent = this,
                GUIType = GuiType.UIA,
            };
            DeclaredChildren.Add(BlockChangesNotPANE);

            Pane1PANE = new Pane()
            {
                Tag = "[Pane]Block - Changes Not Saved|$Window/[Pane]#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Pane1PANE);

            Pane2PANE = new Pane()
            {
                Tag = "[Pane]Block - Changes Not Saved|$Window/[Pane]#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Pane2PANE);

            Pane3PANE = new Pane()
            {
                Tag = "[Pane]Block - Changes Not Saved|$Window/[Pane]#3",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Pane3PANE);

            MainInstructionIconIMG = new Image()
            {
                Tag = "[Pane]Block - Changes Not Saved|$Window/[Image]MainInstructionIcon|$MainIcon",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(MainInstructionIconIMG);

            TheChangesYouMadeST = new StaticText()
            {
                Tag = "[Pane]Block - Changes Not Saved|$Window/[StaticText]The changes you made have not been saved*|$MainInstruction",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(TheChangesYouMadeST);

            SaveTheChangesToPB = new PushButton()
            {
                Tag = "[Pane]Block - Changes Not Saved|$Window/[PushButton]Save the changes to Title Block|$CommandLink_1001",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(SaveTheChangesToPB);

            DiscardTheChangesAndPB = new PushButton()
            {
                Tag = "[Pane]Block - Changes Not Saved|$Window/[PushButton]Discard the changes and close the Block Editor|$CommandLink_1002",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(DiscardTheChangesAndPB);

            CancelPB = new PushButton()
            {
                Tag = "[Pane]Block - Changes Not Saved|$Window/[PushButton]Cancel|$CommandButton_2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(CancelPB);
        }
    }
}
