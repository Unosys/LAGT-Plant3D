// This file is auto-generated - do not hand edit this file.

using Autodesk.GUIHarness;
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{

    [UIElement(Tag = "[Pane]New Folder|$frmProjectFolderProperties", Parent = typeof(CustomWin), GUIType = GuiType.UIA)]
    public partial class PandIDProjectFolderPropertiesDLG : Autodesk.GUIHarness.AutoCAD.AcDialogBox
    {
        public  PushButton PushButton1PB;
        public  PushButton PushButton2PB;
        public  TextField DWGCreationTemplateForTF;
        public  TextField FolderNameTF;
        public  PushButton CancelPB;
        public  PushButton OKPB;
        public  PushButton ClosePB;

        partial void OnInitialize();

        public PandIDProjectFolderPropertiesDLG()
        {
            InitializeComponent();
            OnInitialize();
        }

        private void InitializeComponent()
        {

            PushButton1PB = new PushButton()
            {
                Tag = "[PushButton]$btnLocation|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(PushButton1PB);

            PushButton2PB = new PushButton()
            {
                Tag = "[PushButton]$btnTemplate|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(PushButton2PB);

            DWGCreationTemplateForTF = new TextField()
            {
                Tag = "[TextField]$txtTemplate|#3",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(DWGCreationTemplateForTF);

            FolderNameTF = new TextField()
            {
                Tag = "[TextField]$txtFolderName|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(FolderNameTF);

            CancelPB = new PushButton()
            {
                Tag = "[PushButton]Cancel|$btnCancel|#4",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(CancelPB);

            OKPB = new PushButton()
            {
                Tag = "[PushButton]OK|$btnOK|#3",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(OKPB);

            ClosePB = new PushButton()
            {
                Tag = "[TitleBar]New Folder|$TitleBar|#1/[PushButton]Close|$Close|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ClosePB);
        }
    }
}
