// This file is auto-generated - do not hand edit this file.

using Autodesk.GUIHarness;
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{

    [UIElement(Tag = "[Pane]$IsometricResultsDetail", Parent = typeof(Plant3D))]
    public partial class IsometricCreationResultsDLG : Autodesk.GUIHarness.AutoCAD.AcDialogBox
    {
        public  PushButton ConvertSplitPointsPB;
        public  TreeView TreeViewTV;
        public  ScrollBar HorizontalScrollBarSB;
        public  ScrollBar VerticalScrollBarSB;
        public  PushButton OpenLogFilePB;
        public  PushButton CopyToClipboardPB;
        public  PushButton HelpPB;
        public  PushButton Close1PB;
        public  PopupList ViewPL;
        public  PushButton DropDownButtonPB;
        public  StaticText ViewST;
        public  TitleBar IsometricCreationResultsCTL;
        public  CustomWin SystemMenuBarWIN;
        public  MenuItem SystemMI;
        public  PushButton Close2PB;

        partial void OnInitialize();

        public IsometricCreationResultsDLG()
        {
            InitializeComponent();
            OnInitialize();
        }

        private void InitializeComponent()
        {

            ConvertSplitPointsPB = new PushButton()
            {
                Tag = "[PushButton]Convert Split Points|$button_ImportSplitPoints|#3",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ConvertSplitPointsPB);

            TreeViewTV = new TreeView()
            {
                Tag = "[TreeView]$treeView_Messages|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(TreeViewTV);

            HorizontalScrollBarSB = new ScrollBar()
            {
                Tag = "[TreeView]$treeView_Messages|#1/[ScrollBar]Horizontal Scroll Bar|$Horizontal ScrollBar|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(HorizontalScrollBarSB);

            VerticalScrollBarSB = new ScrollBar()
            {
                Tag = "[TreeView]$treeView_Messages|#1/[ScrollBar]Vertical Scroll Bar|$Vertical ScrollBar|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(VerticalScrollBarSB);

            OpenLogFilePB = new PushButton()
            {
                Tag = "[PushButton]Open log file|$button_OpenMessageFile|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(OpenLogFilePB);

            CopyToClipboardPB = new PushButton()
            {
                Tag = "[PushButton]Copy to Clipboard|$button_CopyToClipboard|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(CopyToClipboardPB);

            HelpPB = new PushButton()
            {
                Tag = "[PushButton]Help|$button_Help|#5",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(HelpPB);

            Close1PB = new PushButton()
            {
                Tag = "[PushButton]Close|$button_Close|#4",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Close1PB);

            ViewPL = new PopupList()
            {
                Tag = "[PopupList]View:|$comboBox_View|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ViewPL);

            DropDownButtonPB = new PushButton()
            {
                Tag = "[PopupList]View:|$comboBox_View|#1/[PushButton]Drop Down Button|$DropDown|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(DropDownButtonPB);

            ViewST = new StaticText()
            {
                Tag = "[StaticText]View:|$label_View|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ViewST);

            IsometricCreationResultsCTL = new TitleBar()
            {
                Tag = "[TitleBar]Isometric Creation Results|$TitleBar|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(IsometricCreationResultsCTL);

            SystemMenuBarWIN = new CustomWin()
            {
                Tag = "[TitleBar]Isometric Creation Results|$TitleBar|#1/[CustomWin]System Menu Bar|$IsometricResultsDetail|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(SystemMenuBarWIN);

            SystemMI = new MenuItem()
            {
                Tag = "[TitleBar]Isometric Creation Results|$TitleBar|#1/[CustomWin]System Menu Bar|$IsometricResultsDetail|#1/[MenuItem]System|$Item 1|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(SystemMI);

            Close2PB = new PushButton()
            {
                Tag = "[TitleBar]Isometric Creation Results|$TitleBar|#1/[PushButton]Close|$Close|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Close2PB);
        }
    }
}
