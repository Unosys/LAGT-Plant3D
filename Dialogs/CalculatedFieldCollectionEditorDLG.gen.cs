// This file is auto-generated - do not hand edit this file.

using Autodesk.GUIHarness;
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{

    [UIElement(Tag = "[Pane]$CalculatedFieldCollectionEditorForm", Parent = typeof(Pane), GUIType = GuiType.UIA)]
    public partial class CalculatedFieldCollectionEditorDLG : Autodesk.GUIHarness.AutoCAD.AcDialogBox
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
        public  Pane PropertyGridControlPanelPANE;
        public  Table TableTBL;
        public  CustomWin HeaderPanel1WIN;
        public  Header BehaviorCTL;
        public  Header ScriptsCTL;
        public  Header DataCTL;
        public  Header DataMemberCTL;
        public  Header DataSourceCTL;
        public  Header ExpressionCTL;
        public  Header FieldTypeCTL;
        public  Header DesignCTL;
        public  Header NameCTL;
        public  Header DisplayNameCTL;
        public  CustomWin DataPanel1WIN;
        public  CustomWin CustomWinWIN;
        public  CustomWin BehaviorWIN;
        public  CustomWin ScriptsWIN;
        public  CustomWin DataWIN;
        public  CustomWin DataMemberWIN;
        public  CustomWin DataSourceWIN;
        public  CustomWin ExpressionWIN;
        public  CustomWin FieldTypeWIN;
        public  CustomWin DesignWIN;
        public  CustomWin NameWIN;
        public  CustomWin DisplayNameWIN;
        public  Pane Pane3PANE;
        public  GroupBox DockTopGB;
        public  ToolBar ToolsTB;
        public  PushButton CategorizedPB;
        public  PushButton AlphabeticalPB;
        public  TreeView TreeViewTV;
        public  CustomWin HeaderPanel2WIN;
        public  Header Column1CTL;
        public  CustomWin DataPanel2WIN;
        public  TreeViewItem Node0TVI;
        public  CustomWin Column1Row0WIN;
        public  TreeViewItem Node1TVI;
        public  CustomWin Column1Row1WIN;
        public  TreeViewItem Node2TVI;
        public  CustomWin Column1Row2WIN;
        public  TreeViewItem Node3TVI;
        public  CustomWin Column1Row3WIN;
        public  TreeViewItem Node4TVI;
        public  CustomWin Column1Row4WIN;
        public  TitleBar CalculatedFieldCollectionEditorCTL;
        public  PushButton ClosePB;

        partial void OnInitialize();

        public CalculatedFieldCollectionEditorDLG()
        {
            InitializeComponent();
            OnInitialize();
        }

        private void InitializeComponent()
        {

            TheXtraLayoutControl1PANE = new Pane()
            {
                Tag = "[Pane]The XtraLayoutControl|$layoutControl1|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(TheXtraLayoutControl1PANE);

            CancelPB = new PushButton()
            {
                Tag = "[Pane]The XtraLayoutControl|$layoutControl1|#1/[PushButton]*Cancel*|$btnCancel|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(CancelPB);

            OKPB = new PushButton()
            {
                Tag = "[Pane]The XtraLayoutControl|$layoutControl1|#1/[PushButton]*OK*|$btnOk|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(OKPB);

            StaticTextST = new StaticText()
            {
                Tag = "[Pane]The XtraLayoutControl|$layoutControl1|#1/[StaticText]$bottomLine|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(StaticTextST);

            Pane1PANE = new Pane()
            {
                Tag = "[Pane]The XtraLayoutControl|$layoutControl1|#1/[Pane]$collectionEditorContent|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Pane1PANE);

            TheXtraLayoutControl2PANE = new Pane()
            {
                Tag = "[Pane]The XtraLayoutControl|$layoutControl1|#1/[Pane]$collectionEditorContent|#1/[Pane]The XtraLayoutControl|$layoutControl1|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(TheXtraLayoutControl2PANE);

            PushButton1PB = new PushButton()
            {
                Tag = "[Pane]The XtraLayoutControl|$layoutControl1|#1/[Pane]$collectionEditorContent|#1/[Pane]The XtraLayoutControl|$layoutControl1|#1/[PushButton]$buttonDown|#4",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(PushButton1PB);

            AddPB = new PushButton()
            {
                Tag = "[Pane]The XtraLayoutControl|$layoutControl1|#1/[Pane]$collectionEditorContent|#1/[Pane]The XtraLayoutControl|$layoutControl1|#1/[PushButton]*Add*|$buttonAdd|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(AddPB);

            RemovePB = new PushButton()
            {
                Tag = "[Pane]The XtraLayoutControl|$layoutControl1|#1/[Pane]$collectionEditorContent|#1/[Pane]The XtraLayoutControl|$layoutControl1|#1/[PushButton]*Remove*|$buttonRemove|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(RemovePB);

            PushButton2PB = new PushButton()
            {
                Tag = "[Pane]The XtraLayoutControl|$layoutControl1|#1/[Pane]$collectionEditorContent|#1/[Pane]The XtraLayoutControl|$layoutControl1|#1/[PushButton]$buttonUp|#3",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(PushButton2PB);

            Pane2PANE = new Pane()
            {
                Tag = "[Pane]The XtraLayoutControl|$layoutControl1|#1/[Pane]$collectionEditorContent|#1/[Pane]The XtraLayoutControl|$layoutControl1|#1/[Pane]$propertyGrid|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Pane2PANE);

            TheXtraLayoutControl3PANE = new Pane()
            {
                Tag = "[Pane]The XtraLayoutControl|$layoutControl1|#1/[Pane]$collectionEditorContent|#1/[Pane]The XtraLayoutControl|$layoutControl1|#1/[Pane]$propertyGrid|#1/[Pane]The XtraLayoutControl|$layoutControl|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(TheXtraLayoutControl3PANE);

            PropertyGridControlPanelPANE = new Pane()
            {
                Tag = "[Pane]The XtraLayoutControl|$layoutControl1|#1/[Pane]$collectionEditorContent|#1/[Pane]The XtraLayoutControl|$layoutControl1|#1/[Pane]$propertyGrid|#1/[Pane]The XtraLayoutControl|$layoutControl|#1/[Pane]propertyGridControlPanel|$propertyGridControlPanel|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(PropertyGridControlPanelPANE);

            TableTBL = new Table()
            {
                Tag = "[Pane]The XtraLayoutControl|$layoutControl1|#1/[Pane]$collectionEditorContent|#1/[Pane]The XtraLayoutControl|$layoutControl1|#1/[Pane]$propertyGrid|#1/[Pane]The XtraLayoutControl|$layoutControl|#1/[Pane]propertyGridControlPanel|$propertyGridControlPanel|#1/[Table]$propertyGridControl|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(TableTBL);

            HeaderPanel1WIN = new CustomWin()
            {
                Tag = "[Pane]The XtraLayoutControl|$layoutControl1|#1/[Pane]$collectionEditorContent|#1/[Pane]The XtraLayoutControl|$layoutControl1|#1/[Pane]$propertyGrid|#1/[Pane]The XtraLayoutControl|$layoutControl|#1/[Pane]propertyGridControlPanel|$propertyGridControlPanel|#1/[Table]$propertyGridControl|#1/[CustomWin]Header Panel|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(HeaderPanel1WIN);

            BehaviorCTL = new Header()
            {
                Tag = "[Pane]The XtraLayoutControl|$layoutControl1|#1/[Pane]$collectionEditorContent|#1/[Pane]The XtraLayoutControl|$layoutControl1|#1/[Pane]$propertyGrid|#1/[Pane]The XtraLayoutControl|$layoutControl|#1/[Pane]propertyGridControlPanel|$propertyGridControlPanel|#1/[Table]$propertyGridControl|#1/[CustomWin]Header Panel|#2/[Header]Behavior|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(BehaviorCTL);

            ScriptsCTL = new Header()
            {
                Tag = "[Pane]The XtraLayoutControl|$layoutControl1|#1/[Pane]$collectionEditorContent|#1/[Pane]The XtraLayoutControl|$layoutControl1|#1/[Pane]$propertyGrid|#1/[Pane]The XtraLayoutControl|$layoutControl|#1/[Pane]propertyGridControlPanel|$propertyGridControlPanel|#1/[Table]$propertyGridControl|#1/[CustomWin]Header Panel|#2/[Header]Scripts|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ScriptsCTL);

            DataCTL = new Header()
            {
                Tag = "[Pane]The XtraLayoutControl|$layoutControl1|#1/[Pane]$collectionEditorContent|#1/[Pane]The XtraLayoutControl|$layoutControl1|#1/[Pane]$propertyGrid|#1/[Pane]The XtraLayoutControl|$layoutControl|#1/[Pane]propertyGridControlPanel|$propertyGridControlPanel|#1/[Table]$propertyGridControl|#1/[CustomWin]Header Panel|#2/[Header]Data|#3",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(DataCTL);

            DataMemberCTL = new Header()
            {
                Tag = "[Pane]The XtraLayoutControl|$layoutControl1|#1/[Pane]$collectionEditorContent|#1/[Pane]The XtraLayoutControl|$layoutControl1|#1/[Pane]$propertyGrid|#1/[Pane]The XtraLayoutControl|$layoutControl|#1/[Pane]propertyGridControlPanel|$propertyGridControlPanel|#1/[Table]$propertyGridControl|#1/[CustomWin]Header Panel|#2/[Header]Data Member|#4",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(DataMemberCTL);

            DataSourceCTL = new Header()
            {
                Tag = "[Pane]The XtraLayoutControl|$layoutControl1|#1/[Pane]$collectionEditorContent|#1/[Pane]The XtraLayoutControl|$layoutControl1|#1/[Pane]$propertyGrid|#1/[Pane]The XtraLayoutControl|$layoutControl|#1/[Pane]propertyGridControlPanel|$propertyGridControlPanel|#1/[Table]$propertyGridControl|#1/[CustomWin]Header Panel|#2/[Header]Data Source|#5",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(DataSourceCTL);

            ExpressionCTL = new Header()
            {
                Tag = "[Pane]The XtraLayoutControl|$layoutControl1|#1/[Pane]$collectionEditorContent|#1/[Pane]The XtraLayoutControl|$layoutControl1|#1/[Pane]$propertyGrid|#1/[Pane]The XtraLayoutControl|$layoutControl|#1/[Pane]propertyGridControlPanel|$propertyGridControlPanel|#1/[Table]$propertyGridControl|#1/[CustomWin]Header Panel|#2/[Header]Expression|#6",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ExpressionCTL);

            FieldTypeCTL = new Header()
            {
                Tag = "[Pane]The XtraLayoutControl|$layoutControl1|#1/[Pane]$collectionEditorContent|#1/[Pane]The XtraLayoutControl|$layoutControl1|#1/[Pane]$propertyGrid|#1/[Pane]The XtraLayoutControl|$layoutControl|#1/[Pane]propertyGridControlPanel|$propertyGridControlPanel|#1/[Table]$propertyGridControl|#1/[CustomWin]Header Panel|#2/[Header]Field Type|#7",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(FieldTypeCTL);

            DesignCTL = new Header()
            {
                Tag = "[Pane]The XtraLayoutControl|$layoutControl1|#1/[Pane]$collectionEditorContent|#1/[Pane]The XtraLayoutControl|$layoutControl1|#1/[Pane]$propertyGrid|#1/[Pane]The XtraLayoutControl|$layoutControl|#1/[Pane]propertyGridControlPanel|$propertyGridControlPanel|#1/[Table]$propertyGridControl|#1/[CustomWin]Header Panel|#2/[Header]Design|#8",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(DesignCTL);

            NameCTL = new Header()
            {
                Tag = "[Pane]The XtraLayoutControl|$layoutControl1|#1/[Pane]$collectionEditorContent|#1/[Pane]The XtraLayoutControl|$layoutControl1|#1/[Pane]$propertyGrid|#1/[Pane]The XtraLayoutControl|$layoutControl|#1/[Pane]propertyGridControlPanel|$propertyGridControlPanel|#1/[Table]$propertyGridControl|#1/[CustomWin]Header Panel|#2/[Header](Name)|#9",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(NameCTL);

            DisplayNameCTL = new Header()
            {
                Tag = "[Pane]The XtraLayoutControl|$layoutControl1|#1/[Pane]$collectionEditorContent|#1/[Pane]The XtraLayoutControl|$layoutControl1|#1/[Pane]$propertyGrid|#1/[Pane]The XtraLayoutControl|$layoutControl|#1/[Pane]propertyGridControlPanel|$propertyGridControlPanel|#1/[Table]$propertyGridControl|#1/[CustomWin]Header Panel|#2/[Header]Display Name|#10",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(DisplayNameCTL);

            DataPanel1WIN = new CustomWin()
            {
                Tag = "[Pane]The XtraLayoutControl|$layoutControl1|#1/[Pane]$collectionEditorContent|#1/[Pane]The XtraLayoutControl|$layoutControl1|#1/[Pane]$propertyGrid|#1/[Pane]The XtraLayoutControl|$layoutControl|#1/[Pane]propertyGridControlPanel|$propertyGridControlPanel|#1/[Table]$propertyGridControl|#1/[CustomWin]Data Panel|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(DataPanel1WIN);

            CustomWinWIN = new CustomWin()
            {
                Tag = "[Pane]The XtraLayoutControl|$layoutControl1|#1/[Pane]$collectionEditorContent|#1/[Pane]The XtraLayoutControl|$layoutControl1|#1/[Pane]$propertyGrid|#1/[Pane]The XtraLayoutControl|$layoutControl|#1/[Pane]propertyGridControlPanel|$propertyGridControlPanel|#1/[Table]$propertyGridControl|#1/[CustomWin]Data Panel|#1/[CustomWin]#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(CustomWinWIN);

            BehaviorWIN = new CustomWin()
            {
                Tag = "[Pane]The XtraLayoutControl|$layoutControl1|#1/[Pane]$collectionEditorContent|#1/[Pane]The XtraLayoutControl|$layoutControl1|#1/[Pane]$propertyGrid|#1/[Pane]The XtraLayoutControl|$layoutControl|#1/[Pane]propertyGridControlPanel|$propertyGridControlPanel|#1/[Table]$propertyGridControl|#1/[CustomWin]Data Panel|#1/[CustomWin]#1/[CustomWin]Behavior|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(BehaviorWIN);

            ScriptsWIN = new CustomWin()
            {
                Tag = "[Pane]The XtraLayoutControl|$layoutControl1|#1/[Pane]$collectionEditorContent|#1/[Pane]The XtraLayoutControl|$layoutControl1|#1/[Pane]$propertyGrid|#1/[Pane]The XtraLayoutControl|$layoutControl|#1/[Pane]propertyGridControlPanel|$propertyGridControlPanel|#1/[Table]$propertyGridControl|#1/[CustomWin]Data Panel|#1/[CustomWin]#1/[CustomWin]Scripts|#4",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ScriptsWIN);

            DataWIN = new CustomWin()
            {
                Tag = "[Pane]The XtraLayoutControl|$layoutControl1|#1/[Pane]$collectionEditorContent|#1/[Pane]The XtraLayoutControl|$layoutControl1|#1/[Pane]$propertyGrid|#1/[Pane]The XtraLayoutControl|$layoutControl|#1/[Pane]propertyGridControlPanel|$propertyGridControlPanel|#1/[Table]$propertyGridControl|#1/[CustomWin]Data Panel|#1/[CustomWin]#1/[CustomWin]Data|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(DataWIN);

            DataMemberWIN = new CustomWin()
            {
                Tag = "[Pane]The XtraLayoutControl|$layoutControl1|#1/[Pane]$collectionEditorContent|#1/[Pane]The XtraLayoutControl|$layoutControl1|#1/[Pane]$propertyGrid|#1/[Pane]The XtraLayoutControl|$layoutControl|#1/[Pane]propertyGridControlPanel|$propertyGridControlPanel|#1/[Table]$propertyGridControl|#1/[CustomWin]Data Panel|#1/[CustomWin]#1/[CustomWin]Data Member|#5",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(DataMemberWIN);

            DataSourceWIN = new CustomWin()
            {
                Tag = "[Pane]The XtraLayoutControl|$layoutControl1|#1/[Pane]$collectionEditorContent|#1/[Pane]The XtraLayoutControl|$layoutControl1|#1/[Pane]$propertyGrid|#1/[Pane]The XtraLayoutControl|$layoutControl|#1/[Pane]propertyGridControlPanel|$propertyGridControlPanel|#1/[Table]$propertyGridControl|#1/[CustomWin]Data Panel|#1/[CustomWin]#1/[CustomWin]Data Source|#6",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(DataSourceWIN);

            ExpressionWIN = new CustomWin()
            {
                Tag = "[Pane]The XtraLayoutControl|$layoutControl1|#1/[Pane]$collectionEditorContent|#1/[Pane]The XtraLayoutControl|$layoutControl1|#1/[Pane]$propertyGrid|#1/[Pane]The XtraLayoutControl|$layoutControl|#1/[Pane]propertyGridControlPanel|$propertyGridControlPanel|#1/[Table]$propertyGridControl|#1/[CustomWin]Data Panel|#1/[CustomWin]#1/[CustomWin]Expression|#7",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ExpressionWIN);

            FieldTypeWIN = new CustomWin()
            {
                Tag = "[Pane]The XtraLayoutControl|$layoutControl1|#1/[Pane]$collectionEditorContent|#1/[Pane]The XtraLayoutControl|$layoutControl1|#1/[Pane]$propertyGrid|#1/[Pane]The XtraLayoutControl|$layoutControl|#1/[Pane]propertyGridControlPanel|$propertyGridControlPanel|#1/[Table]$propertyGridControl|#1/[CustomWin]Data Panel|#1/[CustomWin]#1/[CustomWin]Field Type|#8",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(FieldTypeWIN);

            DesignWIN = new CustomWin()
            {
                Tag = "[Pane]The XtraLayoutControl|$layoutControl1|#1/[Pane]$collectionEditorContent|#1/[Pane]The XtraLayoutControl|$layoutControl1|#1/[Pane]$propertyGrid|#1/[Pane]The XtraLayoutControl|$layoutControl|#1/[Pane]propertyGridControlPanel|$propertyGridControlPanel|#1/[Table]$propertyGridControl|#1/[CustomWin]Data Panel|#1/[CustomWin]#1/[CustomWin]Design|#3",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(DesignWIN);

            NameWIN = new CustomWin()
            {
                Tag = "[Pane]The XtraLayoutControl|$layoutControl1|#1/[Pane]$collectionEditorContent|#1/[Pane]The XtraLayoutControl|$layoutControl1|#1/[Pane]$propertyGrid|#1/[Pane]The XtraLayoutControl|$layoutControl|#1/[Pane]propertyGridControlPanel|$propertyGridControlPanel|#1/[Table]$propertyGridControl|#1/[CustomWin]Data Panel|#1/[CustomWin]#1/[CustomWin](Name)|#9",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(NameWIN);

            DisplayNameWIN = new CustomWin()
            {
                Tag = "[Pane]The XtraLayoutControl|$layoutControl1|#1/[Pane]$collectionEditorContent|#1/[Pane]The XtraLayoutControl|$layoutControl1|#1/[Pane]$propertyGrid|#1/[Pane]The XtraLayoutControl|$layoutControl|#1/[Pane]propertyGridControlPanel|$propertyGridControlPanel|#1/[Table]$propertyGridControl|#1/[CustomWin]Data Panel|#1/[CustomWin]#1/[CustomWin]Display Name|#10",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(DisplayNameWIN);

            Pane3PANE = new Pane()
            {
                Tag = "[Pane]The XtraLayoutControl|$layoutControl1|#1/[Pane]$collectionEditorContent|#1/[Pane]The XtraLayoutControl|$layoutControl1|#1/[Pane]$propertyGrid|#1/[Pane]The XtraLayoutControl|$layoutControl|#1/[Pane]$propertyDescriptionControl|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Pane3PANE);

            DockTopGB = new GroupBox()
            {
                Tag = "[Pane]The XtraLayoutControl|$layoutControl1|#1/[Pane]$collectionEditorContent|#1/[Pane]The XtraLayoutControl|$layoutControl1|#1/[Pane]$propertyGrid|#1/[GroupBox]Dock Top|$2493054|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(DockTopGB);

            ToolsTB = new ToolBar()
            {
                Tag = "[Pane]The XtraLayoutControl|$layoutControl1|#1/[Pane]$collectionEditorContent|#1/[Pane]The XtraLayoutControl|$layoutControl1|#1/[Pane]$propertyGrid|#1/[GroupBox]Dock Top|$2493054|#1/[ToolBar]Tools|$396206|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ToolsTB);

            CategorizedPB = new PushButton()
            {
                Tag = "[Pane]The XtraLayoutControl|$layoutControl1|#1/[Pane]$collectionEditorContent|#1/[Pane]The XtraLayoutControl|$layoutControl1|#1/[Pane]$propertyGrid|#1/[GroupBox]Dock Top|$2493054|#1/[ToolBar]Tools|$396206|#1/[PushButton]Categorized|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(CategorizedPB);

            AlphabeticalPB = new PushButton()
            {
                Tag = "[Pane]The XtraLayoutControl|$layoutControl1|#1/[Pane]$collectionEditorContent|#1/[Pane]The XtraLayoutControl|$layoutControl1|#1/[Pane]$propertyGrid|#1/[GroupBox]Dock Top|$2493054|#1/[ToolBar]Tools|$396206|#1/[PushButton]Alphabetical|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(AlphabeticalPB);

            TreeViewTV = new TreeView()
            {
                Tag = "[Pane]The XtraLayoutControl|$layoutControl1|#1/[Pane]$collectionEditorContent|#1/[Pane]The XtraLayoutControl|$layoutControl1|#1/[TreeView]$tv|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(TreeViewTV);

            HeaderPanel2WIN = new CustomWin()
            {
                Tag = "[Pane]The XtraLayoutControl|$layoutControl1|#1/[Pane]$collectionEditorContent|#1/[Pane]The XtraLayoutControl|$layoutControl1|#1/[TreeView]$tv|#1/[CustomWin]Header Panel|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(HeaderPanel2WIN);

            Column1CTL = new Header()
            {
                Tag = "[Pane]The XtraLayoutControl|$layoutControl1|#1/[Pane]$collectionEditorContent|#1/[Pane]The XtraLayoutControl|$layoutControl1|#1/[TreeView]$tv|#1/[CustomWin]Header Panel|#1/[Header]column1|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Column1CTL);

            DataPanel2WIN = new CustomWin()
            {
                Tag = "[Pane]The XtraLayoutControl|$layoutControl1|#1/[Pane]$collectionEditorContent|#1/[Pane]The XtraLayoutControl|$layoutControl1|#1/[TreeView]$tv|#1/[CustomWin]Data Panel|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(DataPanel2WIN);

            Node0TVI = new TreeViewItem()
            {
                Tag = "[Pane]The XtraLayoutControl|$layoutControl1|#1/[Pane]$collectionEditorContent|#1/[Pane]The XtraLayoutControl|$layoutControl1|#1/[TreeView]$tv|#1/[CustomWin]Data Panel|#2/[TreeViewItem]Node0|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Node0TVI);

            Column1Row0WIN = new CustomWin()
            {
                Tag = "[Pane]The XtraLayoutControl|$layoutControl1|#1/[Pane]$collectionEditorContent|#1/[Pane]The XtraLayoutControl|$layoutControl1|#1/[TreeView]$tv|#1/[CustomWin]Data Panel|#2/[TreeViewItem]Node0|#1/[CustomWin]column1 row 0|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Column1Row0WIN);

            Node1TVI = new TreeViewItem()
            {
                Tag = "[Pane]The XtraLayoutControl|$layoutControl1|#1/[Pane]$collectionEditorContent|#1/[Pane]The XtraLayoutControl|$layoutControl1|#1/[TreeView]$tv|#1/[CustomWin]Data Panel|#2/[TreeViewItem]Node1|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Node1TVI);

            Column1Row1WIN = new CustomWin()
            {
                Tag = "[Pane]The XtraLayoutControl|$layoutControl1|#1/[Pane]$collectionEditorContent|#1/[Pane]The XtraLayoutControl|$layoutControl1|#1/[TreeView]$tv|#1/[CustomWin]Data Panel|#2/[TreeViewItem]Node1|#2/[CustomWin]column1 row 1|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Column1Row1WIN);

            Node2TVI = new TreeViewItem()
            {
                Tag = "[Pane]The XtraLayoutControl|$layoutControl1|#1/[Pane]$collectionEditorContent|#1/[Pane]The XtraLayoutControl|$layoutControl1|#1/[TreeView]$tv|#1/[CustomWin]Data Panel|#2/[TreeViewItem]Node2|#3",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Node2TVI);

            Column1Row2WIN = new CustomWin()
            {
                Tag = "[Pane]The XtraLayoutControl|$layoutControl1|#1/[Pane]$collectionEditorContent|#1/[Pane]The XtraLayoutControl|$layoutControl1|#1/[TreeView]$tv|#1/[CustomWin]Data Panel|#2/[TreeViewItem]Node2|#3/[CustomWin]column1 row 2|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Column1Row2WIN);

            Node3TVI = new TreeViewItem()
            {
                Tag = "[Pane]The XtraLayoutControl|$layoutControl1|#1/[Pane]$collectionEditorContent|#1/[Pane]The XtraLayoutControl|$layoutControl1|#1/[TreeView]$tv|#1/[CustomWin]Data Panel|#2/[TreeViewItem]Node3|#4",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Node3TVI);

            Column1Row3WIN = new CustomWin()
            {
                Tag = "[Pane]The XtraLayoutControl|$layoutControl1|#1/[Pane]$collectionEditorContent|#1/[Pane]The XtraLayoutControl|$layoutControl1|#1/[TreeView]$tv|#1/[CustomWin]Data Panel|#2/[TreeViewItem]Node3|#4/[CustomWin]column1 row 3|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Column1Row3WIN);

            Node4TVI = new TreeViewItem()
            {
                Tag = "[Pane]The XtraLayoutControl|$layoutControl1|#1/[Pane]$collectionEditorContent|#1/[Pane]The XtraLayoutControl|$layoutControl1|#1/[TreeView]$tv|#1/[CustomWin]Data Panel|#2/[TreeViewItem]Node4|#5",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Node4TVI);

            Column1Row4WIN = new CustomWin()
            {
                Tag = "[Pane]The XtraLayoutControl|$layoutControl1|#1/[Pane]$collectionEditorContent|#1/[Pane]The XtraLayoutControl|$layoutControl1|#1/[TreeView]$tv|#1/[CustomWin]Data Panel|#2/[TreeViewItem]Node4|#5/[CustomWin]column1 row 4|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Column1Row4WIN);

            CalculatedFieldCollectionEditorCTL = new TitleBar()
            {
                Tag = "[TitleBar]Calculated Field Collection Editor|$TitleBar|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(CalculatedFieldCollectionEditorCTL);

            ClosePB = new PushButton()
            {
                Tag = "[TitleBar]Calculated Field Collection Editor|$TitleBar|#1/[PushButton]Close|$Close|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ClosePB);
        }
    }
}
