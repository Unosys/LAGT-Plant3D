// This file is auto-generated - do not hand edit this file.

using Autodesk.GUIHarness;
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{

    [UIElement(Tag = "[Pane]$DataFilterCollectionForm", Parent = typeof(ChartWizardChartDLG))]
    public partial class DataFilterCollectionEditorDLG : Pane
    {
        public  Table TableTBL;
        public  CustomWin DataPanelWIN;
        public  CustomWin Record0WIN;
        public  StaticText StaticTextST;
        public  PushButton ClosePB;
        public  PushButton RemovePB;
        public  PushButton AddPB;
        public  ListBox ListBox1LB;
        public  ListBox ListBox2LB;
        public  RadioButton RadioButton1RB;
        public  RadioButton RadioButton2RB;
        public  TitleBar DataFilterCollectionEditorCTL;

        partial void OnInitialize();

        public DataFilterCollectionEditorDLG()
        {
            InitializeComponent();
            OnInitialize();
        }

        private void InitializeComponent()
        {

            TableTBL = new Table()
            {
                Tag = "[Table]$propertyGridControl|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(TableTBL);

            DataPanelWIN = new CustomWin()
            {
                Tag = "[Table]$propertyGridControl|#1/[CustomWin]Data Panel|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(DataPanelWIN);

            Record0WIN = new CustomWin()
            {
                Tag = "[Table]$propertyGridControl|#1/[CustomWin]Data Panel|#1/[CustomWin]Record 0|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Record0WIN);

            StaticTextST = new StaticText()
            {
                Tag = "[StaticText]$lblSplitter|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(StaticTextST);

            ClosePB = new PushButton()
            {
                Tag = "[PushButton]Close|$btnClose|#3",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ClosePB);

            RemovePB = new PushButton()
            {
                Tag = "[PushButton]Remove|$btnRemove|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(RemovePB);

            AddPB = new PushButton()
            {
                Tag = "[PushButton]*Add*|$btnAdd|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(AddPB);

            ListBox1LB = new ListBox()
            {
                Tag = "[ListBox]$lbFilters|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ListBox1LB);

            ListBox2LB = new ListBox()
            {
                Tag = "[ListBox]$rgConjunction|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ListBox2LB);

            RadioButton1RB = new RadioButton()
            {
                Tag = "[ListBox]$rgConjunction|#1/[RadioButton]#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(RadioButton1RB);

            RadioButton2RB = new RadioButton()
            {
                Tag = "[ListBox]$rgConjunction|#1/[RadioButton]#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(RadioButton2RB);

            DataFilterCollectionEditorCTL = new TitleBar()
            {
                Tag = "[TitleBar]Data Filter Collection Editor|$TitleBar|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(DataFilterCollectionEditorCTL);
        }
    }
}
