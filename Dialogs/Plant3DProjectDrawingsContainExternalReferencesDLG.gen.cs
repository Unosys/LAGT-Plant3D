// This file is auto-generated - do not hand edit this file.

using Autodesk.GUIHarness;
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{

    [UIElement(Tag = "[DialogBox]Plant 3D Project - Drawing(s) Contain External References", Parent = typeof(CustomWin), GUIType = GuiType.WIN32)]
    public partial class Plant3DProjectDrawingsContainExternalReferencesDLG : Autodesk.GUIHarness.AutoCAD.AcDialogBox
    {
        public  Pane Plant3DProjectPANE;
        public  Pane Pane1PANE;
        public  Pane Pane2PANE;
        public  Pane Pane3PANE;
        public  Pane Pane4PANE;
        public  Image MainInstructionIconIMG;
        public  StaticText TheDrawingsYouAreST;
        public  PushButton AddExternalReferencesToPB;
        public  PushButton CopyExternalReferencesToPB;
        public  PushButton RemoveExternalReferencesPB;
        public  PushButton Cancel;

        partial void OnInitialize();

        public Plant3DProjectDrawingsContainExternalReferencesDLG()
        {
            InitializeComponent();
            OnInitialize();
        }

        private void InitializeComponent()
        {

            Plant3DProjectPANE = new Pane()
            {
                Tag = "[Pane]Plant 3D Project - Drawing(s) Contain External References|$Window",
                ParentType = this.GetType(),
                Parent = this,
                GUIType = GuiType.UIA,
            };
            DeclaredChildren.Add(Plant3DProjectPANE);

            Pane1PANE = new Pane()
            {
                Tag = "[Pane]Plant 3D Project - Drawing(s) Contain External References|$Window/[Pane]#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Pane1PANE);

            Pane2PANE = new Pane()
            {
                Tag = "[Pane]Plant 3D Project - Drawing(s) Contain External References|$Window/[Pane]#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Pane2PANE);

            Pane3PANE = new Pane()
            {
                Tag = "[Pane]Plant 3D Project - Drawing(s) Contain External References|$Window/[Pane]#3",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Pane3PANE);

            Pane4PANE = new Pane()
            {
                Tag = "[Pane]Plant 3D Project - Drawing(s) Contain External References|$Window/[Pane]#4",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Pane4PANE);

            MainInstructionIconIMG = new Image()
            {
                Tag = "[Pane]Plant 3D Project - Drawing(s) Contain External References|$Window/[Image]MainInstructionIcon|$MainIcon",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(MainInstructionIconIMG);

            TheDrawingsYouAreST = new StaticText()
            {
                Tag = "[Pane]Plant 3D Project - Drawing(s) Contain External References|$Window/[StaticText]The drawing(s) you are adding contain external references that must either be added to the current project or removed*|$MainInstruction",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(TheDrawingsYouAreST);

            AddExternalReferencesToPB = new PushButton()
            {
                Tag = "[Pane]Plant 3D Project - Drawing(s) Contain External References|$Window/[PushButton]Add external references to the project|$CommandLink_1001",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(AddExternalReferencesToPB);

            CopyExternalReferencesToPB = new PushButton()
            {
                Tag = "[Pane]Plant 3D Project - Drawing(s) Contain External References|$Window/[PushButton]Copy external references to the project|$CommandLink_1002",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(CopyExternalReferencesToPB);

            RemoveExternalReferencesPB = new PushButton()
            {
                Tag = "[Pane]Plant 3D Project - Drawing(s) Contain External References|$Window/[PushButton]Remove external references|$CommandLink_1003",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(RemoveExternalReferencesPB);

            Cancel = new PushButton()
            {
                Tag = "[Pane]Plant 3D Project - Drawing(s) Contain External References|$Window/[PushButton]Cancel|$CommandButton_2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Cancel);
        }
    }
}
