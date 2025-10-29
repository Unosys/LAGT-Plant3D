// This file is auto-generated - do not hand edit this file.

using Autodesk.GUIHarness;
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{

    [UIElement(Tag = "[DialogBox]Select Template File|#1", Parent = typeof(Pane), GUIType = GuiType.UIA)]
    public partial class PandIDP3DSelectTemplateFileDLG : Autodesk.GUIHarness.AutoCAD.AcDialogBox
    {
        public  CustomWin CustomWinWIN;
        public  ListView ListViewLV;
        public  Header HeaderCTL;
        public  CustomWin NameWIN;
        public  ScrollBar HorizontalScrollBarSB;
        public  ScrollBar VerticalScrollBarSB;
        public  ListViewItem PTWTemplatesLVI;
        public  TextField TextField1TF;
        public  ListViewItem SheetSetsLVI;
        public  TextField TextField2TF;
        public  ListViewItem AcadNamedPlotStylesdwtLVI;
        public  TextField TextField3TF;
        public  ListViewItem AcadNamedPlotStyles3DdwtLVI;
        public  TextField TextField4TF;
        public  ListViewItem AcaddwtLVI;
        public  TextField TextField5TF;
        public  ListViewItem Acad3DdwtLVI;
        public  TextField TextField6TF;
        public  ListViewItem AcadISONamedPlotStylesdwtLVI;
        public  TextField TextField7TF;
        public  ListViewItem AcadISONamedPlotStyles3DdwtLVI;
        public  TextField TextField8TF;
        public  ListViewItem AcadisodwtLVI;
        public  TextField TextField9TF;
        public  ListViewItem Acadiso3DdwtLVI;
        public  TextField TextField10TF;
        public  ListViewItem OrthoTempdwtLVI;
        public  TextField TextField11TF;
        public  ListViewItem PIDANSIDColorLVI;
        public  TextField TextField12TF;
        public  ListViewItem PIDANSIDNamedLVI;
        public  TextField TextField13TF;
        public  ListViewItem PIDANSIELVI;
        public  TextField TextField14TF;
        public  ListViewItem PIDANSIEColorLVI;
        public  TextField TextField15TF;
        public  ListViewItem PIDISOA0ColorLVI;
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
        public  TitleBar SelectTemplateFileCTL;
        public  CustomWin SystemMenuBarWIN;
        public  MenuItem SystemMI;
        public  PushButton ClosePB;

        partial void OnInitialize();

        public PandIDP3DSelectTemplateFileDLG()
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
                Tag = "[CustomWin]#1/[ListView]$1|#1/[ScrollBar]Horizontal Scroll Bar|$Horizontal ScrollBar|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(HorizontalScrollBarSB);

            VerticalScrollBarSB = new ScrollBar()
            {
                Tag = "[CustomWin]#1/[ListView]$1|#1/[ScrollBar]Vertical Scroll Bar|$Vertical ScrollBar|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(VerticalScrollBarSB);

            PTWTemplatesLVI = new ListViewItem()
            {
                Tag = "[CustomWin]#1/[ListView]$1|#1/[ListViewItem]PTWTemplates|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(PTWTemplatesLVI);

            TextField1TF = new TextField()
            {
                Tag = "[CustomWin]#1/[ListView]$1|#1/[ListViewItem]PTWTemplates|#1/[TextField]#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(TextField1TF);

            SheetSetsLVI = new ListViewItem()
            {
                Tag = "[CustomWin]#1/[ListView]$1|#1/[ListViewItem]SheetSets|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(SheetSetsLVI);

            TextField2TF = new TextField()
            {
                Tag = "[CustomWin]#1/[ListView]$1|#1/[ListViewItem]SheetSets|#2/[TextField]#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(TextField2TF);

            AcadNamedPlotStylesdwtLVI = new ListViewItem()
            {
                Tag = "[CustomWin]#1/[ListView]$1|#1/[ListViewItem]acad -Named Plot Styles*|#3",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(AcadNamedPlotStylesdwtLVI);

            TextField3TF = new TextField()
            {
                Tag = "[CustomWin]#1/[ListView]$1|#1/[ListViewItem]acad -Named Plot Styles*|#3/[TextField]#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(TextField3TF);

            AcadNamedPlotStyles3DdwtLVI = new ListViewItem()
            {
                Tag = "[CustomWin]#1/[ListView]$1|#1/[ListViewItem]acad -Named Plot Styles3D*|#4",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(AcadNamedPlotStyles3DdwtLVI);

            TextField4TF = new TextField()
            {
                Tag = "[CustomWin]#1/[ListView]$1|#1/[ListViewItem]acad -Named Plot Styles3D*|#4/[TextField]#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(TextField4TF);

            AcaddwtLVI = new ListViewItem()
            {
                Tag = "[CustomWin]#1/[ListView]$1|#1/[ListViewItem]acad*|#5",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(AcaddwtLVI);

            TextField5TF = new TextField()
            {
                Tag = "[CustomWin]#1/[ListView]$1|#1/[ListViewItem]acad*|#5/[TextField]#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(TextField5TF);

            Acad3DdwtLVI = new ListViewItem()
            {
                Tag = "[CustomWin]#1/[ListView]$1|#1/[ListViewItem]acad3D*|#6",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Acad3DdwtLVI);

            TextField6TF = new TextField()
            {
                Tag = "[CustomWin]#1/[ListView]$1|#1/[ListViewItem]acad3D*|#6/[TextField]#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(TextField6TF);

            AcadISONamedPlotStylesdwtLVI = new ListViewItem()
            {
                Tag = "[CustomWin]#1/[ListView]$1|#1/[ListViewItem]acadISO -Named Plot Styles*|#7",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(AcadISONamedPlotStylesdwtLVI);

            TextField7TF = new TextField()
            {
                Tag = "[CustomWin]#1/[ListView]$1|#1/[ListViewItem]acadISO -Named Plot Styles*|#7/[TextField]#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(TextField7TF);

            AcadISONamedPlotStyles3DdwtLVI = new ListViewItem()
            {
                Tag = "[CustomWin]#1/[ListView]$1|#1/[ListViewItem]acadISO -Named Plot Styles3D*|#8",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(AcadISONamedPlotStyles3DdwtLVI);

            TextField8TF = new TextField()
            {
                Tag = "[CustomWin]#1/[ListView]$1|#1/[ListViewItem]acadISO -Named Plot Styles3D*|#8/[TextField]#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(TextField8TF);

            AcadisodwtLVI = new ListViewItem()
            {
                Tag = "[CustomWin]#1/[ListView]$1|#1/[ListViewItem]acadiso*|#9",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(AcadisodwtLVI);

            TextField9TF = new TextField()
            {
                Tag = "[CustomWin]#1/[ListView]$1|#1/[ListViewItem]acadiso*|#9/[TextField]#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(TextField9TF);

            Acadiso3DdwtLVI = new ListViewItem()
            {
                Tag = "[CustomWin]#1/[ListView]$1|#1/[ListViewItem]acadiso3D*|#10",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Acadiso3DdwtLVI);

            TextField10TF = new TextField()
            {
                Tag = "[CustomWin]#1/[ListView]$1|#1/[ListViewItem]acadiso3D*|#10/[TextField]#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(TextField10TF);

            OrthoTempdwtLVI = new ListViewItem()
            {
                Tag = "[CustomWin]#1/[ListView]$1|#1/[ListViewItem]OrthoTemp*|#11",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(OrthoTempdwtLVI);

            TextField11TF = new TextField()
            {
                Tag = "[CustomWin]#1/[ListView]$1|#1/[ListViewItem]OrthoTemp*|#11/[TextField]#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(TextField11TF);

            PIDANSIDColorLVI = new ListViewItem()
            {
                Tag = "[CustomWin]#1/[ListView]$1|#1/[ListViewItem]PID ANSI D -Color Dependent Plot Styles*|#12",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(PIDANSIDColorLVI);

            TextField12TF = new TextField()
            {
                Tag = "[CustomWin]#1/[ListView]$1|#1/[ListViewItem]PID ANSI D -Color Dependent Plot Styles*|#12/[TextField]#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(TextField12TF);

            PIDANSIDNamedLVI = new ListViewItem()
            {
                Tag = "[CustomWin]#1/[ListView]$1|#1/[ListViewItem]PID ANSI D -Named Plot Styles*|#13",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(PIDANSIDNamedLVI);

            TextField13TF = new TextField()
            {
                Tag = "[CustomWin]#1/[ListView]$1|#1/[ListViewItem]PID ANSI D -Named Plot Styles*|#13/[TextField]#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(TextField13TF);

            PIDANSIELVI = new ListViewItem()
            {
                Tag = "[CustomWin]#1/[ListView]$1|#1/[ListViewItem]PID ANSI E - Named Plot Styles*|#14",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(PIDANSIELVI);

            TextField14TF = new TextField()
            {
                Tag = "[CustomWin]#1/[ListView]$1|#1/[ListViewItem]PID ANSI E - Named Plot Styles*|#14/[TextField]#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(TextField14TF);

            PIDANSIEColorLVI = new ListViewItem()
            {
                Tag = "[CustomWin]#1/[ListView]$1|#1/[ListViewItem]PID ANSI E -Color Dependent Plot Styles*|#15",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(PIDANSIEColorLVI);

            TextField15TF = new TextField()
            {
                Tag = "[CustomWin]#1/[ListView]$1|#1/[ListViewItem]PID ANSI E -Color Dependent Plot Styles*|#15/[TextField]#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(TextField15TF);

            PIDISOA0ColorLVI = new ListViewItem()
            {
                Tag = "[CustomWin]#1/[ListView]$1|#1/[ListViewItem]PID ISO A0 -Color Dependent Plot Styles*|#16",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(PIDISOA0ColorLVI);

            TextField16TF = new TextField()
            {
                Tag = "[CustomWin]#1/[ListView]$1|#1/[ListViewItem]PID ISO A0 -Color Dependent Plot Styles*|#16/[TextField]#1",
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

            SelectTemplateFileCTL = new TitleBar()
            {
                Tag = "[TitleBar]Select Template File|$TitleBar|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(SelectTemplateFileCTL);

            SystemMenuBarWIN = new CustomWin()
            {
                Tag = "[TitleBar]Select Template File|$TitleBar|#1/[CustomWin]System Menu Bar|$SystemMenuBar|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(SystemMenuBarWIN);

            SystemMI = new MenuItem()
            {
                Tag = "[TitleBar]Select Template File|$TitleBar|#1/[CustomWin]System Menu Bar|$SystemMenuBar|#1/[MenuItem]System|$Item 1|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(SystemMI);

            ClosePB = new PushButton()
            {
                Tag = "[TitleBar]Select Template File|$TitleBar|#1/[PushButton]Close|$Close|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ClosePB);
        }
    }
}
