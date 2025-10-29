// This file is auto-generated - do not hand edit this file.

using Autodesk.GUIHarness;
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{

    [UIElement(Tag = "[DialogBox]Select Quick Iso Directory|#1", Parent = typeof(CreateQuickIsoDLG), GUIType = GuiType.UIA)]
    public partial class SelectQuickIsoDirectoryDLG : Autodesk.GUIHarness.AutoCAD.AcDialogBox
    {
        public  CustomWin CustomWinWIN;
        public  ListView ListViewLV;
        public  Header HeaderCTL;
        public  CustomWin NameWIN;
        public  CustomWin DateModifiedWIN;
        public  CustomWin TypeWIN;
        public  ScrollBar HorizontalScrollBarSB;
        public  ListViewItem AutodeskApplicationManagerLVI;
        public  TextField TextField1TF;
        public  TextField TextField2TF;
        public  TextField TextField3TF;
        public  ListViewItem InventorServerSDKACADLVI;
        public  TextField TextField4TF;
        public  TextField TextField5TF;
        public  TextField TextField6TF;
        public  PushButton PreviousFolderAlt1PB;
        public  PushButton UpOneLevelAlt2PB;
        public  PushButton SearchTheWebAlt3PB;
        public  PushButton DeleteDelPB;
        public  PushButton CreateNewFolderAlt5PB;
        public  PushButton ViewsPB;
        public  PushButton ToolsPB;
        public  PushButton Open;
        public  PushButton Cancel;
        public  ListBox LookInLB;
        public  StaticText LookInST;
        public  PopupList LookInPL;
        public  PushButton DropDownButtonPB;
        public  TitleBar SelectQuickIsoDirectoryCTL;
        public  CustomWin SystemMenuBarWIN;
        public  MenuItem SystemMI;
        public  PushButton ClosePB;

        partial void OnInitialize();

        public SelectQuickIsoDirectoryDLG()
        {
            InitializeComponent();
            OnInitialize();
        }

        private void InitializeComponent()
        {

            CustomWinWIN = new CustomWin()
            {
                Tag = "[CustomWin]#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(CustomWinWIN);

            ListViewLV = new ListView()
            {
                Tag = "[CustomWin]#1/[ListView]$1|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ListViewLV);

            HeaderCTL = new Header()
            {
                Tag = "[CustomWin]#1/[ListView]$1|#1/[Header]Header|$Header|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(HeaderCTL);

            NameWIN = new CustomWin()
            {
                Tag = "[CustomWin]#1/[ListView]$1|#1/[Header]Header|$Header|#1/[CustomWin]Name|$HeaderItem 0|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(NameWIN);

            DateModifiedWIN = new CustomWin()
            {
                Tag = "[CustomWin]#1/[ListView]$1|#1/[Header]Header|$Header|#1/[CustomWin]Date modified|$HeaderItem 1|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(DateModifiedWIN);

            TypeWIN = new CustomWin()
            {
                Tag = "[CustomWin]#1/[ListView]$1|#1/[Header]Header|$Header|#1/[CustomWin]Type|$HeaderItem 2|#3",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(TypeWIN);

            HorizontalScrollBarSB = new ScrollBar()
            {
                Tag = "[CustomWin]#1/[ListView]$1|#1/[ScrollBar]Horizontal Scroll Bar|$Horizontal ScrollBar|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(HorizontalScrollBarSB);

            AutodeskApplicationManagerLVI = new ListViewItem()
            {
                Tag = "[CustomWin]#1/[ListView]$1|#1/[ListViewItem]Autodesk Application Manager|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(AutodeskApplicationManagerLVI);

            TextField1TF = new TextField()
            {
                Tag = "[CustomWin]#1/[ListView]$1|#1/[ListViewItem]Autodesk Application Manager|#1/[TextField]#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(TextField1TF);

            TextField2TF = new TextField()
            {
                Tag = "[CustomWin]#1/[ListView]$1|#1/[ListViewItem]Autodesk Application Manager|#1/[TextField]#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(TextField2TF);

            TextField3TF = new TextField()
            {
                Tag = "[CustomWin]#1/[ListView]$1|#1/[ListViewItem]Autodesk Application Manager|#1/[TextField]#3",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(TextField3TF);

            InventorServerSDKACADLVI = new ListViewItem()
            {
                Tag = "[CustomWin]#1/[ListView]$1|#1/[ListViewItem]Inventor Server SDK ACAD 2016|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(InventorServerSDKACADLVI);

            TextField4TF = new TextField()
            {
                Tag = "[CustomWin]#1/[ListView]$1|#1/[ListViewItem]Inventor Server SDK ACAD 2016|#2/[TextField]#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(TextField4TF);

            TextField5TF = new TextField()
            {
                Tag = "[CustomWin]#1/[ListView]$1|#1/[ListViewItem]Inventor Server SDK ACAD 2016|#2/[TextField]#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(TextField5TF);

            TextField6TF = new TextField()
            {
                Tag = "[CustomWin]#1/[ListView]$1|#1/[ListViewItem]Inventor Server SDK ACAD 2016|#2/[TextField]#3",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(TextField6TF);

            PreviousFolderAlt1PB = new PushButton()
            {
                Tag = "[PushButton]Previous folder(Alt+1)|$13011|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(PreviousFolderAlt1PB);

            UpOneLevelAlt2PB = new PushButton()
            {
                Tag = "[PushButton]Up one level (Alt+2)|$13003|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(UpOneLevelAlt2PB);

            SearchTheWebAlt3PB = new PushButton()
            {
                Tag = "[PushButton]Search the Web (Alt+3)|$13004|#3",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(SearchTheWebAlt3PB);

            DeleteDelPB = new PushButton()
            {
                Tag = "[PushButton]Delete (Del)|$13014|#4",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(DeleteDelPB);

            CreateNewFolderAlt5PB = new PushButton()
            {
                Tag = "[PushButton]Create New Folder (Alt+5)|$13013|#5",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(CreateNewFolderAlt5PB);

            ViewsPB = new PushButton()
            {
                Tag = "[PushButton]Views|$13012|#6",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ViewsPB);

            ToolsPB = new PushButton()
            {
                Tag = "[PushButton]Tools|$13005|#7",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ToolsPB);

            Open = new PushButton()
            {
                Tag = "[PushButton]Open|$1|#8",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Open);

            Cancel = new PushButton()
            {
                Tag = "[PushButton]Cancel|$2|#9",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Cancel);

            LookInLB = new ListBox()
            {
                Tag = "[ListBox]Look in:|$13000|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(LookInLB);

            LookInST = new StaticText()
            {
                Tag = "[StaticText]Look in:|$13007|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(LookInST);

            LookInPL = new PopupList()
            {
                Tag = "[PopupList]Look in:|$13001|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(LookInPL);

            DropDownButtonPB = new PushButton()
            {
                Tag = "[PopupList]Look in:|$13001|#1/[PushButton]Drop Down Button|$DropDown|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(DropDownButtonPB);

            SelectQuickIsoDirectoryCTL = new TitleBar()
            {
                Tag = "[TitleBar]Select Quick Iso Directory|$TitleBar|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(SelectQuickIsoDirectoryCTL);

            SystemMenuBarWIN = new CustomWin()
            {
                Tag = "[TitleBar]Select Quick Iso Directory|$TitleBar|#1/[CustomWin]System Menu Bar|$SystemMenuBar|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(SystemMenuBarWIN);

            SystemMI = new MenuItem()
            {
                Tag = "[TitleBar]Select Quick Iso Directory|$TitleBar|#1/[CustomWin]System Menu Bar|$SystemMenuBar|#1/[MenuItem]System|$Item 1|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(SystemMI);

            ClosePB = new PushButton()
            {
                Tag = "[TitleBar]Select Quick Iso Directory|$TitleBar|#1/[PushButton]Close|$Close|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ClosePB);
        }
    }
}
