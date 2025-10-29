// This file is auto-generated - do not hand edit this file.

using Autodesk.GUIHarness;
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{

    [UIElement(Tag = "[Window]Rename Pipe Spec|$Window_1|#1", Parent = typeof(Plant3D), GUIType = GuiType.UIA)]
    public partial class RenamePipeSpecDLG : Window
    {
        public  TitleBar RenamePipeSpecCTL;
        public  CustomWin SystemMenuBarWIN;
        public  MenuItem SystemMI;
        public  PushButton ClosePB;
        public  PushButton CancelPB;
        public  StaticText CancelST;
        public  PushButton OKPB;
        public  StaticText OKST;
        public  StaticText PipeSpecFileNameST;
        public  TextField PipeSpecFileNameTF;
        public  Pane PanePANE;
        public  StaticText RenamingWillCauseAllST;

        partial void OnInitialize();

        public RenamePipeSpecDLG()
        {
            InitializeComponent();
            OnInitialize();
        }

        private void InitializeComponent()
        {

            RenamePipeSpecCTL = new TitleBar()
            {
                Tag = "[TitleBar]Rename Pipe Spec|$TitleBar|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(RenamePipeSpecCTL);

            SystemMenuBarWIN = new CustomWin()
            {
                Tag = "[TitleBar]Rename Pipe Spec|$TitleBar|#1/[CustomWin]System Menu Bar|$SystemMenuBar|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(SystemMenuBarWIN);

            SystemMI = new MenuItem()
            {
                Tag = "[TitleBar]Rename Pipe Spec|$TitleBar|#1/[CustomWin]System Menu Bar|$SystemMenuBar|#1/[MenuItem]System|$Item 1|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(SystemMI);

            ClosePB = new PushButton()
            {
                Tag = "[TitleBar]Rename Pipe Spec|$TitleBar|#1/[PushButton]Close|$Close|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ClosePB);

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

            OKPB = new PushButton()
            {
                Tag = "[PushButton]OK|$OKButton|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(OKPB);

            OKST = new StaticText()
            {
                Tag = "[PushButton]OK|$OKButton|#1/[StaticText]OK|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(OKST);

            PipeSpecFileNameST = new StaticText()
            {
                Tag = "[StaticText]Pipe Spec file name:|$TextBlock_3|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(PipeSpecFileNameST);

            PipeSpecFileNameTF = new TextField()
            {
                Tag = "[TextField]Pipe Spec file name:|$NewSpecNameTextBox|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(PipeSpecFileNameTF);

            PanePANE = new Pane()
            {
                Tag = "[TextField]Pipe Spec file name:|$NewSpecNameTextBox|#1/[Pane]$PART_ContentHost|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(PanePANE);

            RenamingWillCauseAllST = new StaticText()
            {
                Tag = "[StaticText]Renaming will cause all piping references to this spec to be broken*|$TextBlock_2|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(RenamingWillCauseAllST);
        }
    }
}
