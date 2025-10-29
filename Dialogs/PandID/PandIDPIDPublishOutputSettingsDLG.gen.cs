// This file is auto-generated - do not hand edit this file.

using Autodesk.GUIHarness;
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{

    [UIElement(Tag = "[DialogBox]$DWFOutputSettingsDlg")]
    public partial class PandIDPIDPublishOutputSettingsDLG : Autodesk.GUIHarness.AutoCAD.AcDialogBox
    {
        public  PushButton CancelBtn;
        public  PushButton ClearAllBtn;
        public  PushButton HelpBtn;
        public  TreeView M_classTreeView;
        public  Table M_detailedPropsDataGridView;
        public  GroupBox ObjPropPage;
        public  PushButton OkBtn;
        public  GroupBox PropDetailsGroupBox;
        public  PushButton RestoreToDefaultButton;
        public  PushButton SelectAllBtn;
        public  Pane ObjectPropertiesPANE;
        public  CheckBox ShowItemsOnlyCheckBox;

        partial void OnInitialize();

        public PandIDPIDPublishOutputSettingsDLG()
        {
            InitializeComponent();
            OnInitialize();
        }

        private void InitializeComponent()
        {

            CancelBtn = new PushButton()
            {
                Tag = "[PushButton]$cancelBtn",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(CancelBtn);

            ClearAllBtn = new PushButton()
            {
                Tag = "[PushButton]$clearAllBtn",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ClearAllBtn);

            HelpBtn = new PushButton()
            {
                Tag = "[PushButton]$helpBtn",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(HelpBtn);

            M_classTreeView = new TreeView()
            {
                Tag = "[TreeView]$m_classTreeView",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_classTreeView);

            M_detailedPropsDataGridView = new Table()
            {
                Tag = "[Table]$m_detailedPropsDataGridView",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_detailedPropsDataGridView);

            ObjPropPage = new GroupBox()
            {
                Tag = "[GroupBox]$objPropPage",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ObjPropPage);

            OkBtn = new PushButton()
            {
                Tag = "[PushButton]$okBtn",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(OkBtn);

            PropDetailsGroupBox = new GroupBox()
            {
                Tag = "[GroupBox]$propDetailsGroupBox",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(PropDetailsGroupBox);

            RestoreToDefaultButton = new PushButton()
            {
                Tag = "[PushButton]$restoreToDefaultButton",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(RestoreToDefaultButton);

            SelectAllBtn = new PushButton()
            {
                Tag = "[PushButton]$selectAllBtn",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(SelectAllBtn);

            ObjectPropertiesPANE = new Pane()
            {
                Tag = "[PageList]$propTabControl|#1/[Pane]Object Properties|$objPropPage|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ObjectPropertiesPANE);

            ShowItemsOnlyCheckBox = new CheckBox()
            {
                Tag = "[CheckBox]$showItemsOnlyCheckBox",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ShowItemsOnlyCheckBox);
        }
    }
}
