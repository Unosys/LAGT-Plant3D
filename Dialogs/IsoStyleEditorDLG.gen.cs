// This file is auto-generated - do not hand edit this file.

using Autodesk.GUIHarness;
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{

    [UIElement(Tag = "[MainWin]Iso Style Edito*|$Window_1", Parent = typeof(Desktop), GUIType = GuiType.UIA)]
    public partial class IsoStyleEditorDLG : Autodesk.GUIHarness.AutoCAD.AcDialogBox
    {
        public  TitleBar IsoStyleEditorCTL;
        public  CustomWin SystemMenuBarWIN;
        public  MenuItem SystemMI;
        public  PushButton MinimizePB;
        public  PushButton MaximizePB;
        public  PushButton ClosePB;
        public  Menu MenuMNU;
        public  MenuItem FileMI;
        public  StaticText FileST;
        public  MenuItem EditMI;
        public  StaticText EditST;
        public  MenuItem ViewMI;
        public  StaticText View1ST;
        public  MenuItem HelpMI;
        public  StaticText HelpST;
        public  StaticText IsoconfigST;
        public  TextField IsoconfigTF;
        public  Pane Pane1PANE;
        public  PushButton PushButton1PB;
        public  TreeView TreeViewTV;
        public  TreeViewItem OutputTVI;
        public  StaticText Output1ST;
        public  TreeViewItem FilesTVI;
        public  StaticText FilesST;
        public  TreeViewItem AdvancedDefaultTVI;
        public  PushButton PushButton2PB;
        public  StaticText AdvancedDefaultST;
        public  TreeViewItem FileNameFormatTVI;
        public  PushButton PushButton3PB;
        public  StaticText FileNameFormatST;
        public  TreeViewItem DrawingNameFormatTVI;
        public  PushButton PushButton4PB;
        public  StaticText DrawingNameFormatST;
        public  TreeViewItem ViewTVI;
        public  PushButton PushButton5PB;
        public  StaticText View2ST;
        public  TreeViewItem GeometryTVI;
        public  StaticText GeometryST;
        public  TreeViewItem UnitsTVI;
        public  PushButton PushButton6PB;
        public  StaticText UnitsST;
        public  TreeViewItem SkewTVI;
        public  PushButton PushButton7PB;
        public  StaticText SkewST;
        public  TreeViewItem SplitTVI;
        public  PushButton PushButton8PB;
        public  StaticText SplitST;
        public  TreeViewItem DataTVI;
        public  PushButton PushButton9PB;
        public  StaticText DataST;
        public  TreeViewItem TableTVI;
        public  PushButton PushButton10PB;
        public  StaticText Table1ST;
        public  TreeViewItem LoggingTVI;
        public  StaticText LoggingST;
        public  TreeViewItem TitleBlockTVI;
        public  PushButton PushButton11PB;
        public  StaticText TitleBlockST;
        public  TreeViewItem LayoutOptimizationTVI;
        public  PushButton PushButton12PB;
        public  StaticText LayoutOptimizationST;
        public  TreeViewItem ThemesTVI;
        public  PushButton PushButton13PB;
        public  StaticText ThemesST;
        public  TreeViewItem FiltersTVI;
        public  PushButton PushButton14PB;
        public  StaticText FiltersST;
        public  Thumb Thumb1CTL;
        public  Window TableWIN;
        public  StaticText Table2ST;
        public  Pane Pane2PANE;
        public  TextField TextFieldTF;
        public  StaticText BOMReportFLPLengthST;
        public  CheckBox CheckBox1CK;
        public  StaticText EnablePCFPerDrawingST;
        public  CheckBox CheckBox2CK;
        public  StaticText ForceUpcaseST;
        public  CheckBox CheckBox3CK;
        public  StaticText OverwriteST;
        public  CheckBox CheckBox4CK;
        public  Thumb Thumb2CTL;
        public  PushButton PushButton15PB;
        public  Image ImageIMG;
        public  Window CodeWIN;
        public  StaticText CodeST;
        public  StaticText Output2ST;

        partial void OnInitialize();

        public IsoStyleEditorDLG()
        {
            InitializeComponent();
            OnInitialize();
        }

        private void InitializeComponent()
        {

            IsoStyleEditorCTL = new TitleBar()
            {
                Tag = "[TitleBar]$TitleBar|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(IsoStyleEditorCTL);

            SystemMenuBarWIN = new CustomWin()
            {
                Tag = "[TitleBar]$TitleBar|#1/[CustomWin]System Menu Bar|$SystemMenuBar|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(SystemMenuBarWIN);

            SystemMI = new MenuItem()
            {
                Tag = "[TitleBar]$TitleBar|#1/[CustomWin]System Menu Bar|$SystemMenuBar|#1/[MenuItem]System|$Item 1|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(SystemMI);

            MinimizePB = new PushButton()
            {
                Tag = "[TitleBar]$TitleBar|#1/[PushButton]Minimize|$Minimize|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(MinimizePB);

            MaximizePB = new PushButton()
            {
                Tag = "[TitleBar]$TitleBar|#1/[PushButton]Maximize|$Maximize|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(MaximizePB);

            ClosePB = new PushButton()
            {
                Tag = "[TitleBar]$TitleBar|#1/[PushButton]Close|$Close|#3",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ClosePB);

            MenuMNU = new Menu()
            {
                Tag = "[Menu]#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(MenuMNU);

            FileMI = new MenuItem()
            {
                Tag = "[Menu]#1/[MenuItem]File|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(FileMI);

            FileST = new StaticText()
            {
                Tag = "[Menu]#1/[MenuItem]File|#1/[StaticText]_File|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(FileST);

            EditMI = new MenuItem()
            {
                Tag = "[Menu]#1/[MenuItem]Edit|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(EditMI);

            EditST = new StaticText()
            {
                Tag = "[Menu]#1/[MenuItem]Edit|#2/[StaticText]_Edit|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(EditST);

            ViewMI = new MenuItem()
            {
                Tag = "[Menu]#1/[MenuItem]View|#3",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ViewMI);

            View1ST = new StaticText()
            {
                Tag = "[Menu]#1/[MenuItem]View|#3/[StaticText]_View|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(View1ST);

            HelpMI = new MenuItem()
            {
                Tag = "[Menu]#1/[MenuItem]Help|#4",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(HelpMI);

            HelpST = new StaticText()
            {
                Tag = "[Menu]#1/[MenuItem]Help|#4/[StaticText]_Help|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(HelpST);

            IsoconfigST = new StaticText()
            {
                Tag = "[StaticText]isoconfig|$txtBlk_FileName|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(IsoconfigST);

            IsoconfigTF = new TextField()
            {
                Tag = "[TextField]isoconfig|$txtBx_Search|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(IsoconfigTF);

            Pane1PANE = new Pane()
            {
                Tag = "[TextField]isoconfig|$txtBx_Search|#1/[Pane]$PART_ContentHost|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Pane1PANE);

            PushButton1PB = new PushButton()
            {
                Tag = "[PushButton]#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(PushButton1PB);

            TreeViewTV = new TreeView()
            {
                Tag = "[TreeView]$tv_IsoConfig|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(TreeViewTV);

            OutputTVI = new TreeViewItem()
            {
                Tag = "[TreeView]$tv_IsoConfig|#1/[TreeViewItem]Output|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(OutputTVI);

            Output1ST = new StaticText()
            {
                Tag = "[TreeView]$tv_IsoConfig|#1/[TreeViewItem]Output|#1/[StaticText]Output|$TxtBlk|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Output1ST);

            FilesTVI = new TreeViewItem()
            {
                Tag = "[TreeView]$tv_IsoConfig|#1/[TreeViewItem]Files|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(FilesTVI);

            FilesST = new StaticText()
            {
                Tag = "[TreeView]$tv_IsoConfig|#1/[TreeViewItem]Files|#2/[StaticText]Files|$TxtBlk|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(FilesST);

            AdvancedDefaultTVI = new TreeViewItem()
            {
                Tag = "[TreeView]$tv_IsoConfig|#1/[TreeViewItem]AdvancedDefault|#3",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(AdvancedDefaultTVI);

            PushButton2PB = new PushButton()
            {
                Tag = "[TreeView]$tv_IsoConfig|#1/[TreeViewItem]AdvancedDefault|#3/[PushButton]$Expander|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(PushButton2PB);

            AdvancedDefaultST = new StaticText()
            {
                Tag = "[TreeView]$tv_IsoConfig|#1/[TreeViewItem]AdvancedDefault|#3/[StaticText]AdvancedDefault|$TxtBlk|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(AdvancedDefaultST);

            FileNameFormatTVI = new TreeViewItem()
            {
                Tag = "[TreeView]$tv_IsoConfig|#1/[TreeViewItem]FileNameFormat|#4",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(FileNameFormatTVI);

            PushButton3PB = new PushButton()
            {
                Tag = "[TreeView]$tv_IsoConfig|#1/[TreeViewItem]FileNameFormat|#4/[PushButton]$Expander|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(PushButton3PB);

            FileNameFormatST = new StaticText()
            {
                Tag = "[TreeView]$tv_IsoConfig|#1/[TreeViewItem]FileNameFormat|#4/[StaticText]FileNameFormat|$TxtBlk|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(FileNameFormatST);

            DrawingNameFormatTVI = new TreeViewItem()
            {
                Tag = "[TreeView]$tv_IsoConfig|#1/[TreeViewItem]DrawingNameFormat|#5",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(DrawingNameFormatTVI);

            PushButton4PB = new PushButton()
            {
                Tag = "[TreeView]$tv_IsoConfig|#1/[TreeViewItem]DrawingNameFormat|#5/[PushButton]$Expander|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(PushButton4PB);

            DrawingNameFormatST = new StaticText()
            {
                Tag = "[TreeView]$tv_IsoConfig|#1/[TreeViewItem]DrawingNameFormat|#5/[StaticText]DrawingNameFormat|$TxtBlk|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(DrawingNameFormatST);

            ViewTVI = new TreeViewItem()
            {
                Tag = "[TreeView]$tv_IsoConfig|#1/[TreeViewItem]View|#6",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ViewTVI);

            PushButton5PB = new PushButton()
            {
                Tag = "[TreeView]$tv_IsoConfig|#1/[TreeViewItem]View|#6/[PushButton]$Expander|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(PushButton5PB);

            View2ST = new StaticText()
            {
                Tag = "[TreeView]$tv_IsoConfig|#1/[TreeViewItem]View|#6/[StaticText]View|$TxtBlk|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(View2ST);

            GeometryTVI = new TreeViewItem()
            {
                Tag = "[TreeView]$tv_IsoConfig|#1/[TreeViewItem]Geometry|#7",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(GeometryTVI);

            GeometryST = new StaticText()
            {
                Tag = "[TreeView]$tv_IsoConfig|#1/[TreeViewItem]Geometry|#7/[StaticText]Geometry|$TxtBlk|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(GeometryST);

            UnitsTVI = new TreeViewItem()
            {
                Tag = "[TreeView]$tv_IsoConfig|#1/[TreeViewItem]Units|#8",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(UnitsTVI);

            PushButton6PB = new PushButton()
            {
                Tag = "[TreeView]$tv_IsoConfig|#1/[TreeViewItem]Units|#8/[PushButton]$Expander|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(PushButton6PB);

            UnitsST = new StaticText()
            {
                Tag = "[TreeView]$tv_IsoConfig|#1/[TreeViewItem]Units|#8/[StaticText]Units|$TxtBlk|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(UnitsST);

            SkewTVI = new TreeViewItem()
            {
                Tag = "[TreeView]$tv_IsoConfig|#1/[TreeViewItem]Skew|#9",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(SkewTVI);

            PushButton7PB = new PushButton()
            {
                Tag = "[TreeView]$tv_IsoConfig|#1/[TreeViewItem]Skew|#9/[PushButton]$Expander|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(PushButton7PB);

            SkewST = new StaticText()
            {
                Tag = "[TreeView]$tv_IsoConfig|#1/[TreeViewItem]Skew|#9/[StaticText]Skew|$TxtBlk|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(SkewST);

            SplitTVI = new TreeViewItem()
            {
                Tag = "[TreeView]$tv_IsoConfig|#1/[TreeViewItem]Split|#10",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(SplitTVI);

            PushButton8PB = new PushButton()
            {
                Tag = "[TreeView]$tv_IsoConfig|#1/[TreeViewItem]Split|#10/[PushButton]$Expander|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(PushButton8PB);

            SplitST = new StaticText()
            {
                Tag = "[TreeView]$tv_IsoConfig|#1/[TreeViewItem]Split|#10/[StaticText]Split|$TxtBlk|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(SplitST);

            DataTVI = new TreeViewItem()
            {
                Tag = "[TreeView]$tv_IsoConfig|#1/[TreeViewItem]Data|#11",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(DataTVI);

            PushButton9PB = new PushButton()
            {
                Tag = "[TreeView]$tv_IsoConfig|#1/[TreeViewItem]Data|#11/[PushButton]$Expander|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(PushButton9PB);

            DataST = new StaticText()
            {
                Tag = "[TreeView]$tv_IsoConfig|#1/[TreeViewItem]Data|#11/[StaticText]Data|$TxtBlk|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(DataST);

            TableTVI = new TreeViewItem()
            {
                Tag = "[TreeView]$tv_IsoConfig|#1/[TreeViewItem]Table|#12",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(TableTVI);

            PushButton10PB = new PushButton()
            {
                Tag = "[TreeView]$tv_IsoConfig|#1/[TreeViewItem]Table|#12/[PushButton]$Expander|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(PushButton10PB);

            Table1ST = new StaticText()
            {
                Tag = "[TreeView]$tv_IsoConfig|#1/[TreeViewItem]Table|#12/[StaticText]Table|$TxtBlk|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Table1ST);

            LoggingTVI = new TreeViewItem()
            {
                Tag = "[TreeView]$tv_IsoConfig|#1/[TreeViewItem]Logging|#13",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(LoggingTVI);

            LoggingST = new StaticText()
            {
                Tag = "[TreeView]$tv_IsoConfig|#1/[TreeViewItem]Logging|#13/[StaticText]Logging|$TxtBlk|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(LoggingST);

            TitleBlockTVI = new TreeViewItem()
            {
                Tag = "[TreeView]$tv_IsoConfig|#1/[TreeViewItem]TitleBlock|#14",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(TitleBlockTVI);

            PushButton11PB = new PushButton()
            {
                Tag = "[TreeView]$tv_IsoConfig|#1/[TreeViewItem]TitleBlock|#14/[PushButton]$Expander|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(PushButton11PB);

            TitleBlockST = new StaticText()
            {
                Tag = "[TreeView]$tv_IsoConfig|#1/[TreeViewItem]TitleBlock|#14/[StaticText]TitleBlock|$TxtBlk|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(TitleBlockST);

            LayoutOptimizationTVI = new TreeViewItem()
            {
                Tag = "[TreeView]$tv_IsoConfig|#1/[TreeViewItem]LayoutOptimization|#15",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(LayoutOptimizationTVI);

            PushButton12PB = new PushButton()
            {
                Tag = "[TreeView]$tv_IsoConfig|#1/[TreeViewItem]LayoutOptimization|#15/[PushButton]$Expander|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(PushButton12PB);

            LayoutOptimizationST = new StaticText()
            {
                Tag = "[TreeView]$tv_IsoConfig|#1/[TreeViewItem]LayoutOptimization|#15/[StaticText]LayoutOptimization|$TxtBlk|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(LayoutOptimizationST);

            ThemesTVI = new TreeViewItem()
            {
                Tag = "[TreeView]$tv_IsoConfig|#1/[TreeViewItem]Themes|#16",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ThemesTVI);

            PushButton13PB = new PushButton()
            {
                Tag = "[TreeView]$tv_IsoConfig|#1/[TreeViewItem]Themes|#16/[PushButton]$Expander|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(PushButton13PB);

            ThemesST = new StaticText()
            {
                Tag = "[TreeView]$tv_IsoConfig|#1/[TreeViewItem]Themes|#16/[StaticText]Themes|$TxtBlk|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ThemesST);

            FiltersTVI = new TreeViewItem()
            {
                Tag = "[TreeView]$tv_IsoConfig|#1/[TreeViewItem]Filters|#17",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(FiltersTVI);

            PushButton14PB = new PushButton()
            {
                Tag = "[TreeView]$tv_IsoConfig|#1/[TreeViewItem]Filters|#17/[PushButton]$Expander|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(PushButton14PB);

            FiltersST = new StaticText()
            {
                Tag = "[TreeView]$tv_IsoConfig|#1/[TreeViewItem]Filters|#17/[StaticText]Filters|$TxtBlk|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(FiltersST);

            Thumb1CTL = new Thumb()
            {
                Tag = "[Thumb]#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Thumb1CTL);

            TableWIN = new Window()
            {
                Tag = "[PageList]$TBCntrl|#1/[Window]#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(TableWIN);

            Table2ST = new StaticText()
            {
                Tag = "[PageList]$TBCntrl|#1/[Window]*/[StaticText]Table|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Table2ST);

            Pane2PANE = new Pane()
            {
                Tag = "[PageList]$TBCntrl|#1/[Window]*/[Pane]$ScrollView|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Pane2PANE);

            TextFieldTF = new TextField()
            {
                Tag = "[PageList]$TBCntrl|#1/[Window]*/[Pane]$ScrollView|#1/[TextField]#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(TextFieldTF);

            BOMReportFLPLengthST = new StaticText()
            {
                Tag = "[PageList]$TBCntrl|#1/[Window]*/[Pane]$ScrollView|#1/[StaticText]BOMReportFLPLength|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(BOMReportFLPLengthST);

            CheckBox1CK = new CheckBox()
            {
                Tag = "[PageList]$TBCntrl|#1/[Window]*/[Pane]$ScrollView|#1/[CheckBox]#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(CheckBox1CK);

            EnablePCFPerDrawingST = new StaticText()
            {
                Tag = "[PageList]$TBCntrl|#1/[Window]*/[Pane]$ScrollView|#1/[StaticText]EnablePCFPerDrawing|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(EnablePCFPerDrawingST);

            CheckBox2CK = new CheckBox()
            {
                Tag = "[PageList]$TBCntrl|#1/[Window]*/[Pane]$ScrollView|#1/[CheckBox]#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(CheckBox2CK);

            ForceUpcaseST = new StaticText()
            {
                Tag = "[PageList]$TBCntrl|#1/[Window]*/[Pane]$ScrollView|#1/[StaticText]ForceUpcase|#3",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ForceUpcaseST);

            CheckBox3CK = new CheckBox()
            {
                Tag = "[PageList]$TBCntrl|#1/[Window]*/[Pane]$ScrollView|#1/[CheckBox]#3",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(CheckBox3CK);

            OverwriteST = new StaticText()
            {
                Tag = "[PageList]$TBCntrl|#1/[Window]*/[Pane]$ScrollView|#1/[StaticText]Overwrite|#4",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(OverwriteST);

            CheckBox4CK = new CheckBox()
            {
                Tag = "[PageList]$TBCntrl|#1/[Window]*/[Pane]$ScrollView|#1/[CheckBox]#4",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(CheckBox4CK);

            Thumb2CTL = new Thumb()
            {
                Tag = "[PageList]$TBCntrl|#1/[Window]*/[Pane]$ScrollView|#1/[Thumb]#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Thumb2CTL);

            PushButton15PB = new PushButton()
            {
                Tag = "[PageList]$TBCntrl|#1/[Window]*/[PushButton]$btn_HideComment|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(PushButton15PB);

            ImageIMG = new Image()
            {
                Tag = "[PageList]$TBCntrl|#1/[Window]*/[PushButton]$btn_HideComment|#1/[Image]#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ImageIMG);

            CodeWIN = new Window()
            {
                Tag = "[PageList]$TBCntrl|#1/[Window]#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(CodeWIN);

            CodeST = new StaticText()
            {
                Tag = "[PageList]$TBCntrl|#1/[Window]Code|#2/[StaticText]Code|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(CodeST);

            Output2ST = new StaticText()
            {
                Tag = "[StaticText]Output|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Output2ST);
        }
    }
}
