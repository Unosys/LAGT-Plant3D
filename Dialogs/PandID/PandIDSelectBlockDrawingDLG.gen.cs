// This file is auto-generated - do not hand edit this file.

using Autodesk.GUIHarness;
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{

    [UIElement(Tag = "[DialogBox]Select Block Drawing", Parent = typeof(Pane))]
    public partial class PandIDSelectBlockDrawingDLG : Autodesk.GUIHarness.AutoCAD.AcDialogBox
    {
        public  CustomWin CustomWinWIN;
        public  ListView ListViewLV;
        public  Header HeaderCTL;
        public  CustomWin NameWIN;
        public  ScrollBar HorizontalScrollBarSB;
        public  ListViewItem NetworkPathLVI;
        public  TextField TextField1TF;
        public  ListViewItem Project1HadrianLVI;
        public  TextField TextField2TF;
        public  ListViewItem oneA11001dwgLVI;
        public  TextField TextField3TF;
        public  ListViewItem oneA11002dwgLVI;
        public  TextField TextField4TF;
        public  ListViewItem ConnectorPointdwgLVI;
        public  TextField TextField5TF;
        public  ListViewItem DrawingCheckerdwgLVI;
        public  TextField TextField6TF;
        public  ListViewItem EditAnnotationdwgLVI;
        public  TextField TextField7TF;
        public  ListViewItem OffPageConectordwgLVI;
        public  TextField TextField8TF;
        public  ListViewItem OffPageConector1dwgLVI;
        public  TextField TextField9TF;
        public  ListViewItem OrthoViewPortdwgLVI;
        public  TextField TextField10TF;
        public  ListViewItem PID2008dwgLVI;
        public  TextField TextField11TF;
        public  ListViewItem PID2009dwgLVI;
        public  TextField TextField12TF;
        public  ListViewItem PIDEditBlockDwgLVI;
        public  TextField TextField13TF;
        public  ListViewItem ProjSymbolStyledwgLVI;
        public  TextField TextField14TF;
        public  ListViewItem SampleDrawingdwgLVI;
        public  TextField TextField15TF;
        public  ListViewItem TagEquipmentdwgLVI;
        public  TextField TextField16TF;
        public  StaticText FileNameST;
        public  ComboBox FileNameCB;
        public  StaticText FilesOfTypeST;
        public  PopupList FilesOfTypePL;
        public  PushButton DropDownButton1PB;
        public  PushButton PreviousFolderAlt1PB;
        public  PushButton UpOneLevelAlt2PB;
        public  PushButton SearchTheWebAlt3PB;
        public  PushButton DeleteDelPB;
        public  PushButton CreateNewFolderAlt5PB;
        public  PushButton ViewsPB;
        public  PushButton ToolsPB;
        public  PushButton OpenPB;
        public  PushButton CancelPB;
        public  ListBox LookInLB;
        public  ListBoxItem HistoryLBI;
        public  ListBoxItem DocumentsLBI;
        public  ListBoxItem FavoritesLBI;
        public  ListBoxItem DesktopLBI;
        public  StaticText LookInST;
        public  PopupList LookInPL;
        public  PushButton DropDownButton2PB;
        public  GroupBox PreviewGB;
        public  PushButton PreviewPB;
        public  TitleBar SelectBlockDrawingCTL;
        public  CustomWin SystemMenuBarWIN;
        public  MenuItem SystemMI;
        public  PushButton ClosePB;

        partial void OnInitialize();

        public PandIDSelectBlockDrawingDLG()
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

            HorizontalScrollBarSB = new ScrollBar()
            {
                Tag = "[CustomWin]#1/[ListView]$1|#1/[ScrollBar]Horizontal Scroll Bar|$Horizontal ScrollBar|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(HorizontalScrollBarSB);

            NetworkPathLVI = new ListViewItem()
            {
                Tag = "[CustomWin]#1/[ListView]$1|#1/[ListViewItem]NetworkPath|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(NetworkPathLVI);

            TextField1TF = new TextField()
            {
                Tag = "[CustomWin]#1/[ListView]$1|#1/[ListViewItem]NetworkPath|#1/[TextField]#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(TextField1TF);

            Project1HadrianLVI = new ListViewItem()
            {
                Tag = "[CustomWin]#1/[ListView]$1|#1/[ListViewItem]Project1-Hadrian|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Project1HadrianLVI);

            TextField2TF = new TextField()
            {
                Tag = "[CustomWin]#1/[ListView]$1|#1/[ListViewItem]Project1-Hadrian|#2/[TextField]#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(TextField2TF);

            oneA11001dwgLVI = new ListViewItem()
            {
                Tag = "[CustomWin]#1/[ListView]$1|#1/[ListViewItem]1-A1-1001*|#3",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(oneA11001dwgLVI);

            TextField3TF = new TextField()
            {
                Tag = "[CustomWin]#1/[ListView]$1|#1/[ListViewItem]1-A1-1001*|#3/[TextField]#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(TextField3TF);

            oneA11002dwgLVI = new ListViewItem()
            {
                Tag = "[CustomWin]#1/[ListView]$1|#1/[ListViewItem]1-A1-1002*|#4",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(oneA11002dwgLVI);

            TextField4TF = new TextField()
            {
                Tag = "[CustomWin]#1/[ListView]$1|#1/[ListViewItem]1-A1-1002*|#4/[TextField]#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(TextField4TF);

            ConnectorPointdwgLVI = new ListViewItem()
            {
                Tag = "[CustomWin]#1/[ListView]$1|#1/[ListViewItem]ConnectorPoint*|#5",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ConnectorPointdwgLVI);

            TextField5TF = new TextField()
            {
                Tag = "[CustomWin]#1/[ListView]$1|#1/[ListViewItem]ConnectorPoint*|#5/[TextField]#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(TextField5TF);

            DrawingCheckerdwgLVI = new ListViewItem()
            {
                Tag = "[CustomWin]#1/[ListView]$1|#1/[ListViewItem]DrawingChecker*|#6",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(DrawingCheckerdwgLVI);

            TextField6TF = new TextField()
            {
                Tag = "[CustomWin]#1/[ListView]$1|#1/[ListViewItem]DrawingChecker*|#6/[TextField]#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(TextField6TF);

            EditAnnotationdwgLVI = new ListViewItem()
            {
                Tag = "[CustomWin]#1/[ListView]$1|#1/[ListViewItem]EditAnnotation*|#7",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(EditAnnotationdwgLVI);

            TextField7TF = new TextField()
            {
                Tag = "[CustomWin]#1/[ListView]$1|#1/[ListViewItem]EditAnnotation*|#7/[TextField]#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(TextField7TF);

            OffPageConectordwgLVI = new ListViewItem()
            {
                Tag = "[CustomWin]#1/[ListView]$1|#1/[ListViewItem]OffPageConector*|#8",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(OffPageConectordwgLVI);

            TextField8TF = new TextField()
            {
                Tag = "[CustomWin]#1/[ListView]$1|#1/[ListViewItem]OffPageConector*|#8/[TextField]#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(TextField8TF);

            OffPageConector1dwgLVI = new ListViewItem()
            {
                Tag = "[CustomWin]#1/[ListView]$1|#1/[ListViewItem]OffPageConector1*|#9",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(OffPageConector1dwgLVI);

            TextField9TF = new TextField()
            {
                Tag = "[CustomWin]#1/[ListView]$1|#1/[ListViewItem]OffPageConector1*|#9/[TextField]#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(TextField9TF);

            OrthoViewPortdwgLVI = new ListViewItem()
            {
                Tag = "[CustomWin]#1/[ListView]$1|#1/[ListViewItem]OrthoViewPort*|#10",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(OrthoViewPortdwgLVI);

            TextField10TF = new TextField()
            {
                Tag = "[CustomWin]#1/[ListView]$1|#1/[ListViewItem]OrthoViewPort*|#10/[TextField]#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(TextField10TF);

            PID2008dwgLVI = new ListViewItem()
            {
                Tag = "[CustomWin]#1/[ListView]$1|#1/[ListViewItem]PID_2008*|#11",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(PID2008dwgLVI);

            TextField11TF = new TextField()
            {
                Tag = "[CustomWin]#1/[ListView]$1|#1/[ListViewItem]PID_2008*|#11/[TextField]#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(TextField11TF);

            PID2009dwgLVI = new ListViewItem()
            {
                Tag = "[CustomWin]#1/[ListView]$1|#1/[ListViewItem]PID_2009*|#12",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(PID2009dwgLVI);

            TextField12TF = new TextField()
            {
                Tag = "[CustomWin]#1/[ListView]$1|#1/[ListViewItem]PID_2009*|#12/[TextField]#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(TextField12TF);

            PIDEditBlockDwgLVI = new ListViewItem()
            {
                Tag = "[CustomWin]#1/[ListView]$1|#1/[ListViewItem]PIDEditBlock*|#13",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(PIDEditBlockDwgLVI);

            TextField13TF = new TextField()
            {
                Tag = "[CustomWin]#1/[ListView]$1|#1/[ListViewItem]PIDEditBlock*|#13/[TextField]#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(TextField13TF);

            ProjSymbolStyledwgLVI = new ListViewItem()
            {
                Tag = "[CustomWin]#1/[ListView]$1|#1/[ListViewItem]projSymbolStyle*|#14",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ProjSymbolStyledwgLVI);

            TextField14TF = new TextField()
            {
                Tag = "[CustomWin]#1/[ListView]$1|#1/[ListViewItem]projSymbolStyle*|#14/[TextField]#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(TextField14TF);

            SampleDrawingdwgLVI = new ListViewItem()
            {
                Tag = "[CustomWin]#1/[ListView]$1|#1/[ListViewItem]SampleDrawing*|#15",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(SampleDrawingdwgLVI);

            TextField15TF = new TextField()
            {
                Tag = "[CustomWin]#1/[ListView]$1|#1/[ListViewItem]SampleDrawing*|#15/[TextField]#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(TextField15TF);

            TagEquipmentdwgLVI = new ListViewItem()
            {
                Tag = "[CustomWin]#1/[ListView]$1|#1/[ListViewItem]TagEquipment*|#16",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(TagEquipmentdwgLVI);

            TextField16TF = new TextField()
            {
                Tag = "[CustomWin]#1/[ListView]$1|#1/[ListViewItem]TagEquipment*|#16/[TextField]#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(TextField16TF);

            FileNameST = new StaticText()
            {
                Tag = "[StaticText]File name:|$13008|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(FileNameST);

            FileNameCB = new ComboBox()
            {
                Tag = "[ComboBox]File name:|$13006|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(FileNameCB);

            FilesOfTypeST = new StaticText()
            {
                Tag = "[StaticText]Files of type:|$13009|#3",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(FilesOfTypeST);

            FilesOfTypePL = new PopupList()
            {
                Tag = "[PopupList]Files of type:|$13002|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(FilesOfTypePL);

            DropDownButton1PB = new PushButton()
            {
                Tag = "[PopupList]Files of type:|$13002|#2/[PushButton]Drop Down Button|$DropDown|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(DropDownButton1PB);

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

            OpenPB = new PushButton()
            {
                Tag = "[PushButton]Open|$1|#9",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(OpenPB);

            CancelPB = new PushButton()
            {
                Tag = "[PushButton]Cancel|$2|#10",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(CancelPB);

            LookInLB = new ListBox()
            {
                Tag = "[ListBox]Look in:|$13000|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(LookInLB);

            HistoryLBI = new ListBoxItem()
            {
                Tag = "[ListBox]Look in:|$13000|#1/[ListBoxItem]History|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(HistoryLBI);

            DocumentsLBI = new ListBoxItem()
            {
                Tag = "[ListBox]Look in:|$13000|#1/[ListBoxItem]Documents|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(DocumentsLBI);

            FavoritesLBI = new ListBoxItem()
            {
                Tag = "[ListBox]Look in:|$13000|#1/[ListBoxItem]Favorites|#3",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(FavoritesLBI);

            DesktopLBI = new ListBoxItem()
            {
                Tag = "[ListBox]Look in:|$13000|#1/[ListBoxItem]Desktop|#4",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(DesktopLBI);

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

            DropDownButton2PB = new PushButton()
            {
                Tag = "[PopupList]Look in:|$13001|#1/[PushButton]Drop Down Button|$DropDown|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(DropDownButton2PB);

            PreviewGB = new GroupBox()
            {
                Tag = "[GroupBox]Preview|$13100|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(PreviewGB);

            PreviewPB = new PushButton()
            {
                Tag = "[PushButton]Preview|$13101|#8",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(PreviewPB);

            SelectBlockDrawingCTL = new TitleBar()
            {
                Tag = "[TitleBar]Select Block Drawing|$TitleBar|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(SelectBlockDrawingCTL);

            SystemMenuBarWIN = new CustomWin()
            {
                Tag = "[TitleBar]Select Block Drawing|$TitleBar|#1/[CustomWin]System Menu Bar|$SystemMenuBar|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(SystemMenuBarWIN);

            SystemMI = new MenuItem()
            {
                Tag = "[TitleBar]Select Block Drawing|$TitleBar|#1/[CustomWin]System Menu Bar|$SystemMenuBar|#1/[MenuItem]System|$Item 1|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(SystemMI);

            ClosePB = new PushButton()
            {
                Tag = "[TitleBar]Select Block Drawing|$TitleBar|#1/[PushButton]Close|$Close|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ClosePB);
        }
    }
}
