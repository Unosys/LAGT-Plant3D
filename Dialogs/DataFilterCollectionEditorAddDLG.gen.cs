// This file is auto-generated - do not hand edit this file.

using Autodesk.GUIHarness;
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{

    [UIElement(Tag = "[Pane]$DataFilterCollectionForm", Parent = typeof(ChartWizardChartDLG))]
    public partial class DataFilterCollectionEditorAddDLG : Pane
    {
        public  CustomWin BtnAdd;
        public  CustomWin BtnClose;
        public  CustomWin BtnRemove;
        public  CustomWin LbFilters;
        public  CustomWin LblSplitter;
        public  CustomWin PropertyGrid;
        public  CustomWin PropertyGridView;
        public  CustomWin RgConjunction;

        partial void OnInitialize();

        public DataFilterCollectionEditorAddDLG()
        {
            InitializeComponent();
            OnInitialize();
        }

        private void InitializeComponent()
        {

            BtnAdd = new CustomWin()
            {
                Tag = "[CustomWin]$btnAdd",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(BtnAdd);

            BtnClose = new CustomWin()
            {
                Tag = "[CustomWin]$btnClose",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(BtnClose);

            BtnRemove = new CustomWin()
            {
                Tag = "[CustomWin]$btnRemove",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(BtnRemove);

            LbFilters = new CustomWin()
            {
                Tag = "[CustomWin]$lbFilters",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(LbFilters);

            LblSplitter = new CustomWin()
            {
                Tag = "[CustomWin]$lblSplitter",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(LblSplitter);

            PropertyGrid = new CustomWin()
            {
                Tag = "[CustomWin]$propertyGrid",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(PropertyGrid);

            PropertyGridView = new CustomWin()
            {
                Tag = "[CustomWin]$propertyGrid",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(PropertyGridView);

            RgConjunction = new CustomWin()
            {
                Tag = "[CustomWin]$rgConjunction",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(RgConjunction);
        }
    }
}
