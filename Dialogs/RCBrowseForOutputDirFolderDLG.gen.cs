// This file is auto-generated - do not hand edit this file.

using Autodesk.GUIHarness;
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{

    [UIElement(Tag = "[DialogBox]Browse For Folder|#1", Parent = typeof(ReportConfigurationDLG), GUIType = GuiType.UIA)]
    public partial class RCBrowseForOutputDirFolderDLG : Autodesk.GUIHarness.AutoCAD.AcDialogBox
    {
        public  StaticText SelectOutputDirectoryST;
        public  Pane SelectOutputDirectoryPANE;
        public  TreeView SelectOutputDirectoryTV;
        public  TreeViewItem DesktopTVI;
        public  TreeViewItem LibrariesTVI;
        public  TreeViewItem AdministratorTVI;
        public  TreeViewItem ComputerTVI;
        public  TreeViewItem NetworkTVI;
        public  TreeViewItem ControlPanelTVI;
        public  TreeViewItem RecycleBinTVI;
        public  PushButton MakeNewFolder;
        public  PushButton OK;
        public  PushButton Cancel;
        public  Pane PanePANE;
        public  TitleBar BrowseForFolderCTL;
        public  PushButton ClosePB;

        partial void OnInitialize();

        public RCBrowseForOutputDirFolderDLG()
        {
            InitializeComponent();
            OnInitialize();
        }

        private void InitializeComponent()
        {

            SelectOutputDirectoryST = new StaticText()
            {
                Tag = "[StaticText]Select output directory*|$14146|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(SelectOutputDirectoryST);

            SelectOutputDirectoryPANE = new Pane()
            {
                Tag = "[Pane]Select output directory*|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(SelectOutputDirectoryPANE);

            SelectOutputDirectoryTV = new TreeView()
            {
                Tag = "[Pane]Select output directory*|#1/[TreeView]Select output directory*|$100|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(SelectOutputDirectoryTV);

            DesktopTVI = new TreeViewItem()
            {
                Tag = "[Pane]Select output directory*|#1/[TreeView]Select output directory*|$100|#1/[TreeViewItem]Desktop|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(DesktopTVI);

            LibrariesTVI = new TreeViewItem()
            {
                Tag = "[Pane]Select output directory*|#1/[TreeView]Select output directory*|$100|#1/[TreeViewItem]Desktop|#1/[TreeViewItem]Libraries|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(LibrariesTVI);

            AdministratorTVI = new TreeViewItem()
            {
                Tag = "[Pane]Select output directory*|#1/[TreeView]Select output directory*|$100|#1/[TreeViewItem]Desktop|#1/[TreeViewItem]Administrator|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(AdministratorTVI);

            ComputerTVI = new TreeViewItem()
            {
                Tag = "[Pane]Select output directory*|#1/[TreeView]Select output directory*|$100|#1/[TreeViewItem]Desktop|#1/[TreeViewItem]Computer|#3",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ComputerTVI);

            NetworkTVI = new TreeViewItem()
            {
                Tag = "[Pane]Select output directory*|#1/[TreeView]Select output directory*|$100|#1/[TreeViewItem]Desktop|#1/[TreeViewItem]Network|#4",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(NetworkTVI);

            ControlPanelTVI = new TreeViewItem()
            {
                Tag = "[Pane]Select output directory*|#1/[TreeView]Select output directory*|$100|#1/[TreeViewItem]Desktop|#1/[TreeViewItem]Control Panel|#5",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ControlPanelTVI);

            RecycleBinTVI = new TreeViewItem()
            {
                Tag = "[Pane]Select output directory*|#1/[TreeView]Select output directory*|$100|#1/[TreeViewItem]Desktop|#1/[TreeViewItem]Recycle Bin|#6",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(RecycleBinTVI);

            MakeNewFolder = new PushButton()
            {
                Tag = "[PushButton]Make New Folder|$14150|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(MakeNewFolder);

            OK = new PushButton()
            {
                Tag = "[PushButton]OK|$1|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(OK);

            Cancel = new PushButton()
            {
                Tag = "[PushButton]Cancel|$2|#3",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Cancel);

            PanePANE = new Pane()
            {
                Tag = "[Pane]$14151|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(PanePANE);

            BrowseForFolderCTL = new TitleBar()
            {
                Tag = "[TitleBar]Browse For Folder|$TitleBar|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(BrowseForFolderCTL);

            ClosePB = new PushButton()
            {
                Tag = "[TitleBar]Browse For Folder|$TitleBar|#1/[PushButton]Close|$Close|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ClosePB);
        }
    }
}
