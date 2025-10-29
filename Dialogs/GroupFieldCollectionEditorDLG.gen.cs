// This file is auto-generated - do not hand edit this file.

using Autodesk.GUIHarness;
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{

    [UIElement(Tag = "[Pane]$GroupFieldCollectionEditorForm", Parent = typeof(ReportDesignerApplicationDLG))]
    public partial class GroupFieldCollectionEditorDLG : Pane
    {
        public  Pane TheXtraLayoutControl1PANE;
        public  PushButton CancelPB;
        public  PushButton OKPB;
        public  StaticText StaticTextST;
        public  Pane Pane1PANE;
        public  Pane TheXtraLayoutControl2PANE;
        public  PushButton PushButton1PB;
        public  PushButton AddPB;
        public  PushButton RemovePB;
        public  PushButton PushButton2PB;
        public  Pane Pane2PANE;
        public  Pane TheXtraLayoutControl3PANE;
        public  Table TableTBL;
        public  CustomWin DataPanel1WIN;
        public  CustomWin Record0WIN;
        public  Pane Pane3PANE;
        public  GroupBox DockTopGB;
        public  ToolBar ToolsTB;
        public  PushButton CategorizedPB;
        public  PushButton AlphabeticalPB;
        public  TreeView TreeViewTV;
        public  CustomWin HeaderPanelWIN;
        public  Header HeaderCTL;
        public  CustomWin DataPanel2WIN;
        public  TitleBar GroupFieldCollectionEditorCTL;

        partial void OnInitialize();

        public GroupFieldCollectionEditorDLG()
        {
            InitializeComponent();
            OnInitialize();
        }

        private void InitializeComponent()
        {

            TheXtraLayoutControl1PANE = new Pane()
            {
                Tag = "[Pane]$layoutControl1|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(TheXtraLayoutControl1PANE);

            CancelPB = new PushButton()
            {
                Tag = "[Pane]$layoutControl1|#1/[PushButton]$btnCancel|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(CancelPB);

            OKPB = new PushButton()
            {
                Tag = "[Pane]$layoutControl1|#1/[PushButton]*OK*|$btnOk|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(OKPB);

            StaticTextST = new StaticText()
            {
                Tag = "[Pane]$layoutControl1|#1/[StaticText]$bottomLine|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(StaticTextST);

            Pane1PANE = new Pane()
            {
                Tag = "[Pane]$layoutControl1|#1/[Pane]$collectionEditorContent|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Pane1PANE);

            TheXtraLayoutControl2PANE = new Pane()
            {
                Tag = "[Pane]$layoutControl1|#1/[Pane]$collectionEditorContent|#1/[Pane]$layoutControl1|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(TheXtraLayoutControl2PANE);

            PushButton1PB = new PushButton()
            {
                Tag = "[Pane]$layoutControl1|#1/[Pane]$collectionEditorContent|#1/[Pane]$layoutControl1|#1/[PushButton]$buttonDown|#4",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(PushButton1PB);

            AddPB = new PushButton()
            {
                Tag = "[Pane]$layoutControl1|#1/[Pane]$collectionEditorContent|#1/[Pane]$layoutControl1|#1/[PushButton]*Add*|$buttonAdd|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(AddPB);

            RemovePB = new PushButton()
            {
                Tag = "[Pane]$layoutControl1|#1/[Pane]$collectionEditorContent|#1/[Pane]$layoutControl1|#1/[PushButton]*Remove*|$buttonRemove|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(RemovePB);

            PushButton2PB = new PushButton()
            {
                Tag = "[Pane]$layoutControl1|#1/[Pane]$collectionEditorContent|#1/[Pane]$layoutControl1|#1/[PushButton]$buttonUp|#3",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(PushButton2PB);

            Pane2PANE = new Pane()
            {
                Tag = "[Pane]$layoutControl1|#1/[Pane]$collectionEditorContent|#1/[Pane]$layoutControl1|#1/[Pane]$propertyGrid|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Pane2PANE);

            TheXtraLayoutControl3PANE = new Pane()
            {
                Tag = "[Pane]$layoutControl1|#1/[Pane]$collectionEditorContent|#1/[Pane]$layoutControl1|#1/[Pane]$propertyGrid|#1/[Pane]$layoutControl|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(TheXtraLayoutControl3PANE);

            TableTBL = new Table()
            {
                Tag = "[Pane]$layoutControl1|#1/[Pane]$collectionEditorContent|#1/[Pane]$layoutControl1|#1/[Pane]$propertyGrid|#1/[Pane]$layoutControl|#1/[Table]$propertyGridControl|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(TableTBL);

            DataPanel1WIN = new CustomWin()
            {
                Tag = "[Pane]$layoutControl1|#1/[Pane]$collectionEditorContent|#1/[Pane]$layoutControl1|#1/[Pane]$propertyGrid|#1/[Pane]$layoutControl|#1/[Table]$propertyGridControl|#1/[CustomWin]Data Panel|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(DataPanel1WIN);

            Record0WIN = new CustomWin()
            {
                Tag = "[Pane]$layoutControl1|#1/[Pane]$collectionEditorContent|#1/[Pane]$layoutControl1|#1/[Pane]$propertyGrid|#1/[Pane]$layoutControl|#1/[Table]$propertyGridControl|#1/[CustomWin]Data Panel|#1/[CustomWin]Record 0|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Record0WIN);

            Pane3PANE = new Pane()
            {
                Tag = "[Pane]$layoutControl1|#1/[Pane]$collectionEditorContent|#1/[Pane]$layoutControl1|#1/[Pane]$propertyGrid|#1/[Pane]$layoutControl|#1/[Pane]$propertyDescriptionControl|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Pane3PANE);

            DockTopGB = new GroupBox()
            {
                Tag = "[Pane]$layoutControl1|#1/[Pane]$collectionEditorContent|#1/[Pane]$layoutControl1|#1/[Pane]$propertyGrid|#1/[GroupBox]Dock Top|$15142380|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(DockTopGB);

            ToolsTB = new ToolBar()
            {
                Tag = "[Pane]$layoutControl1|#1/[Pane]$collectionEditorContent|#1/[Pane]$layoutControl1|#1/[Pane]$propertyGrid|#1/[GroupBox]Dock Top|$15142380|#1/[ToolBar]Tools|$32638482|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ToolsTB);

            CategorizedPB = new PushButton()
            {
                Tag = "[Pane]$layoutControl1|#1/[Pane]$collectionEditorContent|#1/[Pane]$layoutControl1|#1/[Pane]$propertyGrid|#1/[GroupBox]Dock Top|$15142380|#1/[ToolBar]Tools|$32638482|#1/[PushButton]Categorized|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(CategorizedPB);

            AlphabeticalPB = new PushButton()
            {
                Tag = "[Pane]$layoutControl1|#1/[Pane]$collectionEditorContent|#1/[Pane]$layoutControl1|#1/[Pane]$propertyGrid|#1/[GroupBox]Dock Top|$15142380|#1/[ToolBar]Tools|$32638482|#1/[PushButton]Alphabetical|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(AlphabeticalPB);

            TreeViewTV = new TreeView()
            {
                Tag = "[Pane]$layoutControl1|#1/[Pane]$collectionEditorContent|#1/[Pane]$layoutControl1|#1/[TreeView]$tv|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(TreeViewTV);

            HeaderPanelWIN = new CustomWin()
            {
                Tag = "[Pane]$layoutControl1|#1/[Pane]$collectionEditorContent|#1/[Pane]$layoutControl1|#1/[TreeView]$tv|#1/[CustomWin]Header Panel|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(HeaderPanelWIN);

            HeaderCTL = new Header()
            {
                Tag = "[Pane]$layoutControl1|#1/[Pane]$collectionEditorContent|#1/[Pane]$layoutControl1|#1/[TreeView]$tv|#1/[CustomWin]Header Panel|#2/[Header]#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(HeaderCTL);

            DataPanel2WIN = new CustomWin()
            {
                Tag = "[Pane]$layoutControl1|#1/[Pane]$collectionEditorContent|#1/[Pane]$layoutControl1|#1/[TreeView]$tv|#1/[CustomWin]Data Panel|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(DataPanel2WIN);

            GroupFieldCollectionEditorCTL = new TitleBar()
            {
                Tag = "[TitleBar]Group Field Collection Editor|$TitleBar|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(GroupFieldCollectionEditorCTL);
        }
    }
}
