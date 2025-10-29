// This file is auto-generated - do not hand edit this file.

using Autodesk.GUIHarness;
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{

    [UIElement(Tag = "[DialogBox]Vault Project Workspace Folder", Parent = typeof(Pane), GUIType = GuiType.UIA)]
    public partial class VaultProjectWorkspaceFolderDLG : Autodesk.GUIHarness.AutoCAD.AcDialogBox
    {
        public  Pane VaultProjectWorkspaceFolderPANE;
        public  Pane Pane1PANE;
        public  Pane Pane2PANE;
        public  Image MainInstructionIconIMG;
        public  StaticText NonlocalWorkspaceFolderST;
        public  StaticText TheFolderuno13pcFFS1IsST;
        public  PushButton YesPB;
        public  PushButton NoPB;
        public  TitleBar VaultProjectWorkspaceFolderCTL;

        partial void OnInitialize();

        public VaultProjectWorkspaceFolderDLG()
        {
            InitializeComponent();
            OnInitialize();
        }

        private void InitializeComponent()
        {

            VaultProjectWorkspaceFolderPANE = new Pane()
            {
                Tag = "[Pane]Vault Project Workspace Folder|$Window|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(VaultProjectWorkspaceFolderPANE);

            Pane1PANE = new Pane()
            {
                Tag = "[Pane]Vault Project Workspace Folder|$Window|#1/[Pane]#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Pane1PANE);

            Pane2PANE = new Pane()
            {
                Tag = "[Pane]Vault Project Workspace Folder|$Window|#1/[Pane]#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Pane2PANE);

            MainInstructionIconIMG = new Image()
            {
                Tag = "[Pane]Vault Project Workspace Folder|$Window|#1/[Image]MainInstructionIcon|$MainIcon|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(MainInstructionIconIMG);

            NonlocalWorkspaceFolderST = new StaticText()
            {
                Tag = "[Pane]Vault Project Workspace Folder|$Window|#1/[StaticText]Non-local Workspace Folder|$MainInstruction|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(NonlocalWorkspaceFolderST);

            TheFolderuno13pcFFS1IsST = new StaticText()
            {
                Tag = "[Pane]Vault Project Workspace Folder|$Window|#1/[StaticText]The folder *|$ContentText|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(TheFolderuno13pcFFS1IsST);

            YesPB = new PushButton()
            {
                Tag = "[Pane]Vault Project Workspace Folder|$Window|#1/[PushButton]Yes|$CommandButton_6|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(YesPB);

            NoPB = new PushButton()
            {
                Tag = "[Pane]Vault Project Workspace Folder|$Window|#1/[PushButton]No|$CommandButton_7|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(NoPB);

            VaultProjectWorkspaceFolderCTL = new TitleBar()
            {
                Tag = "[TitleBar]Vault Project Workspace Folder|$TitleBar|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(VaultProjectWorkspaceFolderCTL);
        }
    }
}
