// This file is auto-generated - do not hand edit this file.

using Autodesk.GUIHarness;
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{

    [UIElement(Tag = "[Pane]*/$AnnotationCollectionEditorForm")]
    public partial class AnnotationCollectionEditorDLG : Pane
    {
        public  Table TableTBL;
        public  CustomWin DataPanelWIN;
        public  CustomWin CustomWinWIN;
        public  StaticText StaticTextST;
        public  PushButton ClosePB;
        public  PushButton RemovePB;
        public  PushButton AddPB;
        public  PushButton PushButton1PB;
        public  PushButton PushButton2PB;
        public  ListBox ListBoxLB;
        public  TitleBar AnnotationCollectionEditorCTL;

        partial void OnInitialize();

        public AnnotationCollectionEditorDLG()
        {
            InitializeComponent();
            OnInitialize();
        }

        private void InitializeComponent()
        {

            TableTBL = new Table()
            {
                Tag = "[Table]$propertyGrid|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(TableTBL);

            DataPanelWIN = new CustomWin()
            {
                Tag = "[Table]$propertyGrid|#1/[CustomWin]Data Panel|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(DataPanelWIN);

            CustomWinWIN = new CustomWin()
            {
                Tag = "[Table]$propertyGrid|#1/[CustomWin]Data Panel|#1/[CustomWin]#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(CustomWinWIN);

            StaticTextST = new StaticText()
            {
                Tag = "[StaticText]$labelControl1|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(StaticTextST);

            ClosePB = new PushButton()
            {
                Tag = "[PushButton]Close|$btnClose|#5",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ClosePB);

            RemovePB = new PushButton()
            {
                Tag = "[PushButton]*Remove*|$btnRemove|#4",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(RemovePB);

            AddPB = new PushButton()
            {
                Tag = "[PushButton]*Add*|$btnAdd|#3",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(AddPB);

            PushButton1PB = new PushButton()
            {
                Tag = "[PushButton]$btnDown|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(PushButton1PB);

            PushButton2PB = new PushButton()
            {
                Tag = "[PushButton]$btnUp|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(PushButton2PB);

            ListBoxLB = new ListBox()
            {
                Tag = "[ListBox]$fListBox|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ListBoxLB);

            AnnotationCollectionEditorCTL = new TitleBar()
            {
                Tag = "[TitleBar]Annotation Collection Editor|$TitleBar|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(AnnotationCollectionEditorCTL);
        }
    }
}
