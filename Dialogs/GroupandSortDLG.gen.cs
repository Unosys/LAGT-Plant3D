// This file is auto-generated - do not hand edit this file.

using Autodesk.GUIHarness;
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{

    [UIElement(Tag = "[Pane]Group and Sort|$groupAndSortDockPanel1", Parent = typeof(Pane), GUIType = GuiType.UIA)]
    public partial class GroupandSortDLG : Pane
    {
        public  Pane Pane1PANE;
        public  Pane Pane2PANE;
        public  TreeView TreeViewTV;
        public  ScrollBar ScrollBarSB;
        public  CustomWin HeaderPanelWIN;
        public  Header FieldNameCTL;
        public  Header SortOrderCTL;
        public  Header ShowHeaderCTL;
        public  Header ShowFooterCTL;
        public  CustomWin DataPanelWIN;
        public  GroupBox DockTopGB;
        public  ToolBar ToolsTB;
        public  PushButton AddAGroupPB;
        public  PushButton AddASortPB;
        public  PushButton DeletePB;
        public  PushButton MoveUpPB;
        public  PushButton MoveDownPB;
        public  MenuItem ItemMI;
        public  PushButton ClosePB;

        partial void OnInitialize();

        public GroupandSortDLG()
        {
            InitializeComponent();
            OnInitialize();
        }

        private void InitializeComponent()
        {

            Pane1PANE = new Pane()
            {
                Tag = "[Pane]$groupAndSortDockPanel1_Container|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Pane1PANE);

            Pane2PANE = new Pane()
            {
                Tag = "[Pane]$groupAndSortDockPanel1_Container|#1/[Pane]$20451112|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Pane2PANE);

            TreeViewTV = new TreeView()
            {
                Tag = "[Pane]$groupAndSortDockPanel1_Container|#1/[Pane]$20451112|#1/[TreeView]$4000830|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(TreeViewTV);

            ScrollBarSB = new ScrollBar()
            {
                Tag = "[Pane]$groupAndSortDockPanel1_Container|#1/[Pane]$20451112|#1/[TreeView]$4000830|#1/[ScrollBar]scroll bar|$38604110|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ScrollBarSB);

            HeaderPanelWIN = new CustomWin()
            {
                Tag = "[Pane]$groupAndSortDockPanel1_Container|#1/[Pane]$20451112|#1/[TreeView]$4000830|#1/[CustomWin]Header Panel|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(HeaderPanelWIN);

            FieldNameCTL = new Header()
            {
                Tag = "[Pane]$groupAndSortDockPanel1_Container|#1/[Pane]$20451112|#1/[TreeView]$4000830|#1/[CustomWin]Header Panel|#2/[Header]Field Name|#4",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(FieldNameCTL);

            SortOrderCTL = new Header()
            {
                Tag = "[Pane]$groupAndSortDockPanel1_Container|#1/[Pane]$20451112|#1/[TreeView]$4000830|#1/[CustomWin]Header Panel|#2/[Header]Sort Order|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(SortOrderCTL);

            ShowHeaderCTL = new Header()
            {
                Tag = "[Pane]$groupAndSortDockPanel1_Container|#1/[Pane]$20451112|#1/[TreeView]$4000830|#1/[CustomWin]Header Panel|#2/[Header]Show Header|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ShowHeaderCTL);

            ShowFooterCTL = new Header()
            {
                Tag = "[Pane]$groupAndSortDockPanel1_Container|#1/[Pane]$20451112|#1/[TreeView]$4000830|#1/[CustomWin]Header Panel|#2/[Header]Show Footer|#3",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ShowFooterCTL);

            DataPanelWIN = new CustomWin()
            {
                Tag = "[Pane]$groupAndSortDockPanel1_Container|#1/[Pane]$20451112|#1/[TreeView]$4000830|#1/[CustomWin]Data Panel|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(DataPanelWIN);

            DockTopGB = new GroupBox()
            {
                Tag = "[Pane]$groupAndSortDockPanel1_Container|#1/[Pane]$20451112|#1/[GroupBox]Dock Top|$3804370|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(DockTopGB);

            ToolsTB = new ToolBar()
            {
                Tag = "[Pane]$groupAndSortDockPanel1_Container|#1/[Pane]$20451112|#1/[GroupBox]Dock Top|$3804370|#1/[ToolBar]Tools|$3673210|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ToolsTB);

            AddAGroupPB = new PushButton()
            {
                Tag = "[Pane]$groupAndSortDockPanel1_Container|#1/[Pane]$20451112|#1/[GroupBox]Dock Top|$3804370|#1/[ToolBar]Tools|$3673210|#1/[PushButton]Add a Group|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(AddAGroupPB);

            AddASortPB = new PushButton()
            {
                Tag = "[Pane]$groupAndSortDockPanel1_Container|#1/[Pane]$20451112|#1/[GroupBox]Dock Top|$3804370|#1/[ToolBar]Tools|$3673210|#1/[PushButton]Add a Sort|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(AddASortPB);

            DeletePB = new PushButton()
            {
                Tag = "[Pane]$groupAndSortDockPanel1_Container|#1/[Pane]$20451112|#1/[GroupBox]Dock Top|$3804370|#1/[ToolBar]Tools|$3673210|#1/[PushButton]Delete|#3",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(DeletePB);

            MoveUpPB = new PushButton()
            {
                Tag = "[Pane]$groupAndSortDockPanel1_Container|#1/[Pane]$20451112|#1/[GroupBox]Dock Top|$3804370|#1/[ToolBar]Tools|$3673210|#1/[PushButton]Move Up|#4",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(MoveUpPB);

            MoveDownPB = new PushButton()
            {
                Tag = "[Pane]$groupAndSortDockPanel1_Container|#1/[Pane]$20451112|#1/[GroupBox]Dock Top|$3804370|#1/[ToolBar]Tools|$3673210|#1/[PushButton]Move Down|#5",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(MoveDownPB);

            ItemMI = new MenuItem()
            {
                Tag = "[Pane]$groupAndSortDockPanel1_Container|#1/[Pane]$20451112|#1/[GroupBox]Dock Top|$3804370|#1/[ToolBar]Tools|$3673210|#1/[MenuItem]Item|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ItemMI);

            ClosePB = new PushButton()
            {
                Tag = "[TitleBar]Group and Sort|#1/[PushButton]Close|#4",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ClosePB);
        }
    }
}
