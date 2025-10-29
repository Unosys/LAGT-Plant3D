// This file is auto-generated - do not hand edit this file.

using Autodesk.GUIHarness;
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{

    [UIElement(Tag = "[Pane]Autodesk Connection Point Editor|$AttributeEditor", Parent = typeof(MainWin), GUIType = GuiType.UIA)]
    public partial class AutodeskConnectionPointEditorDLG : Autodesk.GUIHarness.AutoCAD.AcDialogBox
    {
        public  Pane PanePANE;
        public  Table DataGridViewTBL;
        public  CustomWin TopRowWIN;
        public  Header PropertyNameCTL;
        public  Header ValueCTL;
        public  CustomWin Row0WIN;
        public  CustomWin PropertyNameRow0WIN;
        public  CustomWin ValueRow0WIN;
        public  StaticText ConnectionPointPropertiesST;
        public  Pane ConnectionPointPropertiesPANE;
        public  StaticText AdvancedST;
        public  PushButton AdvancedPB;
        public  PushButton HelpPB;
        public  PushButton CancelPB;
        public  PushButton OKPB;
        public  TitleBar AutodeskConnectionPointEditorCTL;
        public  CustomWin SystemMenuBarWIN;
        public  MenuItem SystemMI;
        public  PushButton ClosePB;

        partial void OnInitialize();

        public AutodeskConnectionPointEditorDLG()
        {
            InitializeComponent();
            OnInitialize();
        }

        private void InitializeComponent()
        {

            PanePANE = new Pane()
            {
                Tag = "[Pane]$LayerOut|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(PanePANE);

            DataGridViewTBL = new Table()
            {
                Tag = "[Pane]$LayerOut|#1/[Table]DataGridView|$_myDataGridView|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(DataGridViewTBL);

            TopRowWIN = new CustomWin()
            {
                Tag = "[Pane]$LayerOut|#1/[Table]DataGridView|$_myDataGridView|#1/[CustomWin]Top Row|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(TopRowWIN);

            PropertyNameCTL = new Header()
            {
                Tag = "[Pane]$LayerOut|#1/[Table]DataGridView|$_myDataGridView|#1/[CustomWin]Top Row|#1/[Header]Property Name|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(PropertyNameCTL);

            ValueCTL = new Header()
            {
                Tag = "[Pane]$LayerOut|#1/[Table]DataGridView|$_myDataGridView|#1/[CustomWin]Top Row|#1/[Header]Value|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ValueCTL);

            Row0WIN = new CustomWin()
            {
                Tag = "[Pane]$LayerOut|#1/[Table]DataGridView|$_myDataGridView|#1/[CustomWin]Row 0|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Row0WIN);

            PropertyNameRow0WIN = new CustomWin()
            {
                Tag = "[Pane]$LayerOut|#1/[Table]DataGridView|$_myDataGridView|#1/[CustomWin]Row 0|#2/[CustomWin]Property Name Row 0|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(PropertyNameRow0WIN);

            ValueRow0WIN = new CustomWin()
            {
                Tag = "[Pane]$LayerOut|#1/[Table]DataGridView|$_myDataGridView|#1/[CustomWin]Row 0|#2/[CustomWin]Value Row 0|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ValueRow0WIN);

            ConnectionPointPropertiesST = new StaticText()
            {
                Tag = "[Pane]$LayerOut|#1/[StaticText]Connection Point Properties:|$label1|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ConnectionPointPropertiesST);

            ConnectionPointPropertiesPANE = new Pane()
            {
                Tag = "[Pane]$LayerOut|#1/[Pane]Connection Point Properties:|$panel1|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ConnectionPointPropertiesPANE);

            AdvancedST = new StaticText()
            {
                Tag = "[Pane]$LayerOut|#1/[Pane]Connection Point Properties:|$panel1|#1/[StaticText]Advanced|$label2|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(AdvancedST);

            AdvancedPB = new PushButton()
            {
                Tag = "[Pane]$LayerOut|#1/[Pane]Connection Point Properties:|$panel1|#1/[PushButton]Advanced|$AdvancedBtn|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(AdvancedPB);

            HelpPB = new PushButton()
            {
                Tag = "[PushButton]Help|$buttonHelp|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(HelpPB);

            CancelPB = new PushButton()
            {
                Tag = "[PushButton]Cancel|$buttonCancel|#3",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(CancelPB);

            OKPB = new PushButton()
            {
                Tag = "[PushButton]OK|$buttonOK|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(OKPB);

            AutodeskConnectionPointEditorCTL = new TitleBar()
            {
                Tag = "[TitleBar]Autodesk Connection Point Editor|$TitleBar|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(AutodeskConnectionPointEditorCTL);

            SystemMenuBarWIN = new CustomWin()
            {
                Tag = "[TitleBar]Autodesk Connection Point Editor|$TitleBar|#1/[CustomWin]System Menu Bar|$AttributeEditor|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(SystemMenuBarWIN);

            SystemMI = new MenuItem()
            {
                Tag = "[TitleBar]Autodesk Connection Point Editor|$TitleBar|#1/[CustomWin]System Menu Bar|$AttributeEditor|#1/[MenuItem]System|$Item 1|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(SystemMI);

            ClosePB = new PushButton()
            {
                Tag = "[TitleBar]Autodesk Connection Point Editor|$TitleBar|#1/[PushButton]Close|$Close|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ClosePB);
        }
    }
}
