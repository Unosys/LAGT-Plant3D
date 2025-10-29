// This file is auto-generated - do not hand edit this file.

using Autodesk.GUIHarness;
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{

    [UIElement(Tag = "[DialogBox]Browse For Folder", Parent = typeof(CreateCatalogTemplateDLG))]
    public partial class Plant3DCatalogBuilderBrowseForFolderDLG : Autodesk.GUIHarness.AutoCAD.AcDialogBox
    {
        public  StaticText SpecifyTheDirectoryToHold1;
        public  CustomWin SpecifyTheDirectoryToHold2;
        public  TreeView TreeView1;
        public  PushButton MakeNewFolderPB;
        public  PushButton OK;
        public  PushButton Cancel;
        public  ScrollBar ScrollBar1;

        partial void OnInitialize();

        public Plant3DCatalogBuilderBrowseForFolderDLG()
        {
            InitializeComponent();
            OnInitialize();
        }

        private void InitializeComponent()
        {

            SpecifyTheDirectoryToHold1 = new StaticText()
            {
                Tag = "$14146",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(SpecifyTheDirectoryToHold1);

            SpecifyTheDirectoryToHold2 = new CustomWin()
            {
                Tag = "[SHBrowseForFolder ShellNameSpace Control]$0",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(SpecifyTheDirectoryToHold2);

            TreeView1 = new TreeView()
            {
                Tag = "$100",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(TreeView1);

            MakeNewFolderPB = new PushButton()
            {
                Tag = "$14150",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(MakeNewFolderPB);

            OK = new PushButton()
            {
                Tag = "$1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(OK);

            Cancel = new PushButton()
            {
                Tag = "$2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Cancel);

            ScrollBar1 = new ScrollBar()
            {
                Tag = "$14151",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ScrollBar1);
        }
    }
}
