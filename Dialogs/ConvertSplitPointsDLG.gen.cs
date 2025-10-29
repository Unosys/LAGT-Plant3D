// This file is auto-generated - do not hand edit this file.

using Autodesk.GUIHarness;
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{

    [UIElement(Tag = "[Pane]Convert Split Points|$IsoImportSplitPoints|#1", Parent = typeof(Pane), GUIType = GuiType.UIA)]
    public partial class ConvertSplitPointsDLG : Autodesk.GUIHarness.AutoCAD.AcDialogBox
    {
        public  PopupList PopupListPL;
        public  PushButton DropDownButtonPB;
        public  Table DataGridViewTBL;
        public  CustomWin TopRowWIN;
        public  Header LinesAvailableCTL;
        public  Header PlaceStartPointCTL;
        public  Header ReplaceBreakPointsCTL;
        public  PushButton ConvertPB;
        public  PushButton CancelPB;
        public  PushButton HelpPB;
        public  TitleBar ConvertSplitPointsCTL;
        public  CustomWin SystemMenuBarWIN;
        public  MenuItem SystemMI;
        public  PushButton ClosePB;

        partial void OnInitialize();

        public ConvertSplitPointsDLG()
        {
            InitializeComponent();
            OnInitialize();
        }

        private void InitializeComponent()
        {

            PopupListPL = new PopupList()
            {
                Tag = "[PopupList]$comboBox_IsoStyle|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(PopupListPL);

            DropDownButtonPB = new PushButton()
            {
                Tag = "[PopupList]$comboBox_IsoStyle|#1/[PushButton]Drop Down Button|$DropDown|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(DropDownButtonPB);

            DataGridViewTBL = new Table()
            {
                Tag = "[Table]DataGridView|$dataGridView_Lines|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(DataGridViewTBL);

            TopRowWIN = new CustomWin()
            {
                Tag = "[Table]DataGridView|$dataGridView_Lines|#1/[CustomWin]Top Row|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(TopRowWIN);

            LinesAvailableCTL = new Header()
            {
                Tag = "[Table]DataGridView|$dataGridView_Lines|#1/[CustomWin]Top Row|#1/[Header]Lines available|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(LinesAvailableCTL);

            PlaceStartPointCTL = new Header()
            {
                Tag = "[Table]DataGridView|$dataGridView_Lines|#1/[CustomWin]Top Row|#1/[Header]Place start point|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(PlaceStartPointCTL);

            ReplaceBreakPointsCTL = new Header()
            {
                Tag = "[Table]DataGridView|$dataGridView_Lines|#1/[CustomWin]Top Row|#1/[Header]Replace break points|#3",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ReplaceBreakPointsCTL);

            ConvertPB = new PushButton()
            {
                Tag = "[PushButton]Convert|$m_btn_Convert|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ConvertPB);

            CancelPB = new PushButton()
            {
                Tag = "[PushButton]Cancel|$m_btn_Cancel|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(CancelPB);

            HelpPB = new PushButton()
            {
                Tag = "[PushButton]Help|$m_bt_Help|#3",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(HelpPB);

            ConvertSplitPointsCTL = new TitleBar()
            {
                Tag = "[TitleBar]Convert Split Points|$TitleBar|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ConvertSplitPointsCTL);

            SystemMenuBarWIN = new CustomWin()
            {
                Tag = "[TitleBar]Convert Split Points|$TitleBar|#1/[CustomWin]System Menu Bar|$IsoImportSplitPoints|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(SystemMenuBarWIN);

            SystemMI = new MenuItem()
            {
                Tag = "[TitleBar]Convert Split Points|$TitleBar|#1/[CustomWin]System Menu Bar|$IsoImportSplitPoints|#1/[MenuItem]System|$Item 1|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(SystemMI);

            ClosePB = new PushButton()
            {
                Tag = "[TitleBar]Convert Split Points|$TitleBar|#1/[PushButton]Close|$Close|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ClosePB);
        }
    }
}
