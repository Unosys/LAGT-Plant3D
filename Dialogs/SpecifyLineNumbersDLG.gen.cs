// This file is auto-generated - do not hand edit this file.

using Autodesk.GUIHarness;
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{

    [UIElement(Tag = "[Window]Specify Line Numbers|$Window_SingleLineNumbers|#1", Parent = typeof(MainWin), GUIType = GuiType.UIA)]
    public partial class SpecifyLineNumbersDLG : Autodesk.GUIHarness.AutoCAD.AcDialogBox
    {
        public  PushButton ClosePB;
        public  StaticText LineNumbersST;
        public  PushButton PushButton1PB;
        public  CheckBox CheckBox1CK;
        public  PushButton PushButton2PB;
        public  Image ImageIMG;
        public  Pane Pane2PANE;
        public  CheckBox CheckBox2CK;
        public  PushButton CancelPB;
        public  PushButton OKPB;

        partial void OnInitialize();

        public SpecifyLineNumbersDLG()
        {
            InitializeComponent();
            OnInitialize();
        }

        private void InitializeComponent()
        {

            ClosePB = new PushButton()
            {
                Tag = "[TitleBar]Specify Line Numbers|$TitleBar|#1/[PushButton]Close|$Close|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ClosePB);

            LineNumbersST = new StaticText()
            {
                Tag = "[StaticText]Line Numbers:|$TextBlock_LineNumbers|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(LineNumbersST);

            PushButton1PB = new PushButton()
            {
                Tag = "[PushButton]$Button_SelectAllNone|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(PushButton1PB);

            CheckBox1CK = new CheckBox()
            {
                Tag = "[CheckBox]$CheckBox_ShowSelected|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(CheckBox1CK);

            PushButton2PB = new PushButton()
            {
                Tag = "[PushButton]$Button_ManualSelect|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(PushButton2PB);

            ImageIMG = new Image()
            {
                Tag = "[PushButton]$Button_ManualSelect|#1/[Image]$buttonImage|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ImageIMG);

            Pane2PANE = new Pane()
            {
                Tag = "[Pane]$ScrollViewer_LineNumbers|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Pane2PANE);

            CheckBox2CK = new CheckBox()
            {
                Tag = "[Pane]$ScrollViewer_LineNumbers|#1/[CheckBox]$CheckBox_LineNumber|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(CheckBox2CK);

            CancelPB = new PushButton()
            {
                Tag = "[PushButton]Cancel|$CancelButton|#4",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(CancelPB);

            OKPB = new PushButton()
            {
                Tag = "[PushButton]OK|$OKButton|#3",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(OKPB);
        }
    }
}
