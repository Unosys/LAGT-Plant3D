// This file is auto-generated - do not hand edit this file.

using Autodesk.GUIHarness;
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{

    [UIElement(Tag = "[Pane]PivotGrid Field List|#2", Parent = typeof(PropertyEditorFieldsDLG))]
    public partial class PivotGridFieldListDLG : Pane
    {
        public  CustomWin AddTo;
        public  CustomWin DevExpressXtraEditorsComboBoxEdit;
        public  CustomWin DevExpressXtraEditorsPanelControl;
        public  CustomWin DevExpressXtraPivotGridCustomi;
        public  CustomWin DevExpressXtraPivotGridCustomi2;
        public  GroupBox DevExpressXtraPivotGridCustomiGroup;
        public  CustomWin DragItemsToThePivotGrid;
        public  CustomWin DragItemsToThePivotGrid5;
        public  StaticText DragItemsToThePivotGridLabel;
        public  GroupBox Group;

        partial void OnInitialize();

        public PivotGridFieldListDLG()
        {
            InitializeComponent();
            OnInitialize();
        }

        private void InitializeComponent()
        {

            AddTo = new CustomWin()
            {
                Tag = "[CustomWin]$",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(AddTo);

            DevExpressXtraEditorsComboBoxEdit = new CustomWin()
            {
                Tag = "[CustomWin]$DevExpress.XtraEditors.ComboBoxEdit",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(DevExpressXtraEditorsComboBoxEdit);

            DevExpressXtraEditorsPanelControl = new CustomWin()
            {
                Tag = "[CustomWin]$DevExpress.XtraEditors.PanelControl",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(DevExpressXtraEditorsPanelControl);

            DevExpressXtraPivotGridCustomi = new CustomWin()
            {
                Tag = "[CustomWin]$DevExpress.XtraPivotGrid.Customization.CustomizationFormSplitContainerControl",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(DevExpressXtraPivotGridCustomi);

            DevExpressXtraPivotGridCustomi2 = new CustomWin()
            {
                Tag = "[CustomWin]$DevExpress.XtraPivotGrid.Customization.FieldCustomizationTreeBox",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(DevExpressXtraPivotGridCustomi2);

            DevExpressXtraPivotGridCustomiGroup = new GroupBox()
            {
                Tag = "[GroupBox]$DevExpress.XtraPivotGrid.Customization.SimpleCustomizationFormBottomPanel",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(DevExpressXtraPivotGridCustomiGroup);

            DragItemsToThePivotGrid = new CustomWin()
            {
                Tag = "[CustomWin]$Drag Items to the PivotGrid",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(DragItemsToThePivotGrid);

            DragItemsToThePivotGrid5 = new CustomWin()
            {
                Tag = "[CustomWin]$Drag Items to the PivotGrid",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(DragItemsToThePivotGrid5);

            DragItemsToThePivotGridLabel = new StaticText()
            {
                Tag = "[StaticText]$",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(DragItemsToThePivotGridLabel);

            Group = new GroupBox()
            {
                Tag = "[GroupBox]$",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Group);
        }
    }
}
