// This file is auto-generated - do not hand edit this file.

using Autodesk.GUIHarness;
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{

    [UIElement(Tag = "[DialogBox]Select Folder|[DialogBox]Browse For Folder", Parent = typeof(ReportConfigurationDLG))]
    public partial class BrowseForFolderDLG : Autodesk.GUIHarness.AutoCAD.AcDialogBox
    {
        public  PushButton OKPB;
        public  PushButton Cancel;
        public  TextField FolderTF;
        public  PushButton SelectFolderPB;
        public  PushButton ClosePB;

        partial void OnInitialize();

        public BrowseForFolderDLG()
        {
            InitializeComponent();
            OnInitialize();
        }

        private void InitializeComponent()
        {

            OKPB = new PushButton()
            {
                Tag = "[PushButton]OK|$1|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(OKPB);

            Cancel = new PushButton()
            {
                Tag = "[PushButton]Cancel|$2|#3",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Cancel);

            FolderTF = new TextField()
            {
                Tag = "[TextField]Folder:|$1152|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(FolderTF);

            SelectFolderPB = new PushButton()
            {
                Tag = "[PushButton]Select Folder|$1|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(SelectFolderPB);

            ClosePB = new PushButton()
            {
                Tag = "[TitleBar]Select Folder|$TitleBar|#1/[PushButton]Close|$Close|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ClosePB);
        }
    }
}
