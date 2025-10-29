// This file is auto-generated - do not hand edit this file.

using Autodesk.GUIHarness;
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{

    [UIElement(Tag = "[Window]Override Valve Operators|$ModifyValveOperatorMappingWindow", Parent = typeof(MainWin), GUIType = GuiType.UIA)]
    public partial class SpecEditorEditValveOperatorsDLG : Autodesk.GUIHarness.AutoCAD.AcDialogBox
    {
        public  CheckBox OverrideCatalogValveOperatorCK;
        public  PushButton ValveOperatorShapeBrowserPB;
        public  TreeViewItem BallValveTVI;
        public  PushButton CancelPB;
        public  ListView DefaultValveOperatorsLV;
        public  ListViewItem SystemDataDataRowView1LVI;

        partial void OnInitialize();

        public SpecEditorEditValveOperatorsDLG()
        {
            InitializeComponent();
            OnInitialize();
        }

        private void InitializeComponent()
        {

            OverrideCatalogValveOperatorCK = new CheckBox()
            {
                Tag = "[GroupBox]$GroupBox_1|#1/[CheckBox]$OverrideCheckBox|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(OverrideCatalogValveOperatorCK);

            ValveOperatorShapeBrowserPB = new PushButton()
            {
                Tag = "[GroupBox]$GroupBox_1|#1/[PushButton]$ValveOperatorShapeBrowser|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ValveOperatorShapeBrowserPB);

            BallValveTVI = new TreeViewItem()
            {
                Tag = "[GroupBox]Valve Operator Assignments|$GroupBox_1|#1/[TreeView]$ValveTypeTreeView|#1/[TreeViewItem]Ball Valve|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(BallValveTVI);

            CancelPB = new PushButton()
            {
                Tag = "[PushButton]Cancel|$CancelButton|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(CancelPB);

            DefaultValveOperatorsLV = new ListView()
            {
                Tag = "[GroupBox]$GroupBox_1|#1/[ListView]$SizeRecordGridView|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(DefaultValveOperatorsLV);

            SystemDataDataRowView1LVI = new ListViewItem()
            {
                Tag = "[GroupBox]$GroupBox_1|#1/[ListView]$SizeRecordGridView|#1/[ListViewItem]|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(SystemDataDataRowView1LVI);
        }
    }
}
