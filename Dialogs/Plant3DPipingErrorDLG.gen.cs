// This file is auto-generated - do not hand edit this file.

using Autodesk.GUIHarness;
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{

    [UIElement(Tag = "[Pane]Plant 3D Piping Errors|$AcPp3dErrorDlg|#1", Parent = typeof(Plant3D), GUIType = GuiType.UIA)]
    public partial class Plant3DPipingErrorDLG : Pane
    {
        public  Pane OneOrMoreItems1PANE;
        public  Table DataGridViewTBL;
        public  CustomWin TopRowWIN;
        public  Header ErrorCTL;
        public  CustomWin Row0WIN;
        public  CustomWin ErrorRow0WIN;
        public  PushButton Close1PB;
        public  StaticText OneOrMoreItemsST;
        public  Pane OneOrMoreItems2PANE;
        public  TitleBar Plant3DPipingErrorsCTL;
        public  PushButton BtnClose;

        partial void OnInitialize();

        public Plant3DPipingErrorDLG()
        {
            InitializeComponent();
            OnInitialize();
        }

        private void InitializeComponent()
        {

            OneOrMoreItems1PANE = new Pane()
            {
                Tag = "[Pane]One or more items have caused an error*[1]|$panel1|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(OneOrMoreItems1PANE);

            DataGridViewTBL = new Table()
            {
                Tag = "[Pane]One or more items have caused an error*[1]|$panel1|#2/[Table]DataGridView|$GridView|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(DataGridViewTBL);

            TopRowWIN = new CustomWin()
            {
                Tag = "[Pane]One or more items have caused an error*[1]|$panel1|#2/[Table]DataGridView|$GridView|#1/[CustomWin]Top Row|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(TopRowWIN);

            ErrorCTL = new Header()
            {
                Tag = "[Pane]One or more items have caused an error*[1]|$panel1|#2/[Table]DataGridView|$GridView|#1/[CustomWin]Top Row|#1/[Header]Error|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ErrorCTL);

            Row0WIN = new CustomWin()
            {
                Tag = "[Pane]One or more items have caused an error*[1]|$panel1|#2/[Table]DataGridView|$GridView|#1/[CustomWin]Row 0|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Row0WIN);

            ErrorRow0WIN = new CustomWin()
            {
                Tag = "[Pane]One or more items have caused an error*[1]|$panel1|#2/[Table]DataGridView|$GridView|#1/[CustomWin]Row 0|#2/[CustomWin]Error Row 0|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ErrorRow0WIN);

            Close1PB = new PushButton()
            {
                Tag = "[Pane]One or more items have caused an error*[1]|$panel1|#2/[PushButton]Close|$BtnClose|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Close1PB);

            OneOrMoreItemsST = new StaticText()
            {
                Tag = "[StaticText]One or more items have caused an error*|$LabelText|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(OneOrMoreItemsST);

            OneOrMoreItems2PANE = new Pane()
            {
                Tag = "[Pane]One or more items have caused an error*[2]|$IconPicBox|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(OneOrMoreItems2PANE);

            Plant3DPipingErrorsCTL = new TitleBar()
            {
                Tag = "[TitleBar]Plant 3D Piping Errors|$TitleBar|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Plant3DPipingErrorsCTL);

            BtnClose = new PushButton()
            {
                Tag = "[TitleBar]Plant 3D Piping Errors|$TitleBar|#1/[PushButton]Close|$Close|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(BtnClose);
        }
    }
}
