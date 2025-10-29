// This file is auto-generated - do not hand edit this file.

using Autodesk.GUIHarness;
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{

    [UIElement(Tag = "[MainWin]Block*Changes Not Saved|#1", Parent = typeof(Desktop), GUIType = GuiType.WIN32)]
    public partial class BlockChangesNotSavedDLG : MainWin
    {
        public  Pane BlockChangesNotSavedPANE;
        public  Pane Pane1PANE;
        public  Pane Pane2PANE;
        public  Pane Pane3PANE;
        public  Image MainInstructionIconIMG;
        public  StaticText TheChangesYouMadeST;
        public  PushButton SaveTheChangesToPB;
        public  PushButton DiscardTheChangesAndPB;
        public  PushButton CancelPB;

        partial void OnInitialize();

        public BlockChangesNotSavedDLG()
        {
            InitializeComponent();
            OnInitialize();
        }

        private void InitializeComponent()
        {

            BlockChangesNotSavedPANE = new Pane()
            {
                Tag = "[Pane]Block-Changes Not Saved|$Window|#1",
                ParentType = this.GetType(),
                Parent = this,
                GUIType = GuiType.UIA,
            };
            DeclaredChildren.Add(BlockChangesNotSavedPANE);

            Pane1PANE = new Pane()
            {
                Tag = "[Pane]Block-Changes Not Saved|$Window|#1/[Pane]#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Pane1PANE);

            Pane2PANE = new Pane()
            {
                Tag = "[Pane]Block-Changes Not Saved|$Window|#1/[Pane]#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Pane2PANE);

            Pane3PANE = new Pane()
            {
                Tag = "[Pane]Block-Changes Not Saved|$Window|#1/[Pane]#3",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Pane3PANE);

            MainInstructionIconIMG = new Image()
            {
                Tag = "[Pane]Block-Changes Not Saved|$Window|#1/[Image]MainInstructionIcon|$MainIcon|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(MainInstructionIconIMG);

            TheChangesYouMadeST = new StaticText()
            {
                Tag = "[Pane]Block-Changes Not Saved|$Window|#1/[StaticText]The changes you made have not been saved*|$MainInstruction|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(TheChangesYouMadeST);

            SaveTheChangesToPB = new PushButton()
            {
                Tag = "[Pane]Block-Changes Not Saved|$Window|#1/[PushButton]Save the changes to \"Iso*|$CommandLink_1001|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(SaveTheChangesToPB);

            DiscardTheChangesAndPB = new PushButton()
            {
                Tag = "[Pane]Block-Changes Not Saved|$Window|#1/[PushButton]Discard the changes and close the Iso Title Block Editor|$CommandLink_1002|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(DiscardTheChangesAndPB);

            CancelPB = new PushButton()
            {
                Tag = "[Pane]Block-Changes Not Saved|$Window|#1/[PushButton]Cancel|$CommandButton_2|#3",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(CancelPB);
        }
    }
}
