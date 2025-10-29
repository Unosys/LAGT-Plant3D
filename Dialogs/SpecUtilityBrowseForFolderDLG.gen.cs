// This file is auto-generated - do not hand edit this file.

using Autodesk.GUIHarness;
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{

    [UIElement(Tag = "[DialogBox]Browse For Folder|Select Folder", Parent = typeof(ConvertAutoPLANTSpecsAndCatalogsDLG))]
    public partial class SpecUtilityBrowseForFolderDLG : Autodesk.GUIHarness.AutoCAD.AcDialogBox
    {
        public  PushButton Cancel;
        public  PushButton MakeNewFolder;
        public  PushButton OK;
        public  TextField FolderTF;
        public  PushButton SelectFolderPB;

        partial void OnInitialize();

        public SpecUtilityBrowseForFolderDLG()
        {
            InitializeComponent();
            OnInitialize();
        }

        private void InitializeComponent()
        {

            Cancel = new PushButton()
            {
                Tag = "[PushButton]$2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Cancel);

            MakeNewFolder = new PushButton()
            {
                Tag = "[PushButton]$",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(MakeNewFolder);

            OK = new PushButton()
            {
                Tag = "[PushButton]$",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(OK);

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
        }
    }
}
