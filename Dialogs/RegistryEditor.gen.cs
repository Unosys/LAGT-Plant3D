// This file is auto-generated - do not hand edit this file.

using Autodesk.GUIHarness;
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{

    [UIElement(Tag = "[MainWin]Registry Editor", Parent = typeof(Desktop), GUIType = GuiType.WIN32)]
    public partial class RegistryEditor : Autodesk.GUIHarness.AutoCAD.AcDialogBox
    {
        public  Pane RegistryEditorPANE;
        public  Pane Pane1PANE;
        public  Pane Pane2PANE;
        public  Image MainInstructionIconIMG;
        public  StaticText AddingInformationCanUnintentionallyST;
        public  PushButton YesPB;
        public  PushButton NoPB;
        public  PushButton OKPB;

        partial void OnInitialize();

        public RegistryEditor()
        {
            InitializeComponent();
            OnInitialize();
        }

        private void InitializeComponent()
        {

            RegistryEditorPANE = new Pane()
            {
                Tag = "[Pane]Registry Editor|$Window|#1",
                ParentType = this.GetType(),
                Parent = this,
                GUIType = GuiType.UIA,
            };
            DeclaredChildren.Add(RegistryEditorPANE);

            Pane1PANE = new Pane()
            {
                Tag = "[Pane]Registry Editor|$Window|#1/[Pane]#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Pane1PANE);

            Pane2PANE = new Pane()
            {
                Tag = "[Pane]Registry Editor|$Window|#1/[Pane]#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Pane2PANE);

            MainInstructionIconIMG = new Image()
            {
                Tag = "[Pane]Registry Editor|$Window|#1/[Image]MainInstructionIcon|$MainIcon|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(MainInstructionIconIMG);

            AddingInformationCanUnintentionallyST = new StaticText()
            {
                Tag = "[Pane]Registry Editor|$Window|#1/[StaticText]Adding information can unintentionally change or delete values and cause components to stop working correctly*|$ContentText|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(AddingInformationCanUnintentionallyST);

            YesPB = new PushButton()
            {
                Tag = "[Pane]Registry Editor|$Window|#1/[PushButton]Yes|$CommandButton_6|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(YesPB);

            NoPB = new PushButton()
            {
                Tag = "[Pane]Registry Editor|$Window|#1/[PushButton]No|$CommandButton_7|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(NoPB);

            OKPB = new PushButton()
            {
                Tag = "[Pane]Registry Editor|#1/[Pane]#1/[PushButton]OK|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(OKPB);
        }
    }
}
