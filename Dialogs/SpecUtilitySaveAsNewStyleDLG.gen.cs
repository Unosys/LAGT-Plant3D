// This file is auto-generated - do not hand edit this file.

using Autodesk.GUIHarness;
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{

    [UIElement(Tag = "[Window]Save As New Style|$TextInputDialog", Parent = typeof(Window), GUIType = GuiType.UIA)]
    public partial class SpecUtilitySaveAsNewStyleDLG : Autodesk.GUIHarness.AutoCAD.AcDialogBox
    {
        public  TitleBar SaveAsNewStyleCTL;
        public  CustomWin SystemMenuBarWIN;
        public  MenuItem SystemMI;
        public  PushButton ClosePB;
        public  PushButton CreatePB;
        public  StaticText CreateST;
        public  PushButton CancelPB;
        public  StaticText CancelST;
        public  StaticText StyleName1ST;
        public  StaticText StyleName2ST;
        public  TextField StyleNameTF;
        public  Pane PanePANE;
        public  StaticText StaticTextST;

        partial void OnInitialize();

        public SpecUtilitySaveAsNewStyleDLG()
        {
            InitializeComponent();
            OnInitialize();
        }

        private void InitializeComponent()
        {

            SaveAsNewStyleCTL = new TitleBar()
            {
                Tag = "[TitleBar]Save As New Style|$TitleBar|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(SaveAsNewStyleCTL);

            SystemMenuBarWIN = new CustomWin()
            {
                Tag = "[TitleBar]Save As New Style|$TitleBar|#1/[CustomWin]System Menu Bar|$SystemMenuBar|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(SystemMenuBarWIN);

            SystemMI = new MenuItem()
            {
                Tag = "[TitleBar]Save As New Style|$TitleBar|#1/[CustomWin]System Menu Bar|$SystemMenuBar|#1/[MenuItem]System|$Item 1|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(SystemMI);

            ClosePB = new PushButton()
            {
                Tag = "[TitleBar]Save As New Style|$TitleBar|#1/[PushButton]Close|$Close|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ClosePB);

            CreatePB = new PushButton()
            {
                Tag = "[PushButton]Create|$SaveButton|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(CreatePB);

            CreateST = new StaticText()
            {
                Tag = "[PushButton]Create|$SaveButton|#1/[StaticText]Create|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(CreateST);

            CancelPB = new PushButton()
            {
                Tag = "[PushButton]Cancel|$CancelButton|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(CancelPB);

            CancelST = new StaticText()
            {
                Tag = "[PushButton]Cancel|$CancelButton|#2/[StaticText]Cancel|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(CancelST);

            StyleName1ST = new StaticText()
            {
                Tag = "[StaticText]Style name: |$TextBoxLabel|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(StyleName1ST);

            StyleName2ST = new StaticText()
            {
                Tag = "[StaticText]Style name: |$TextBoxLabel|#1/[StaticText]Style name: |#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(StyleName2ST);

            StyleNameTF = new TextField()
            {
                Tag = "[TextField]Style name: |$TextInputTextBox|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(StyleNameTF);

            PanePANE = new Pane()
            {
                Tag = "[TextField]Style name: |$TextInputTextBox|#1/[Pane]$PART_ContentHost|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(PanePANE);

            StaticTextST = new StaticText()
            {
                Tag = "[StaticText]$TextInputEchoText|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(StaticTextST);
        }
    }
}
