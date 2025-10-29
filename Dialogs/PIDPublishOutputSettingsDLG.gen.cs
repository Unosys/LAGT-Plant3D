// This file is auto-generated - do not hand edit this file.

using Autodesk.GUIHarness;
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{

    [UIElement(Tag = "[DialogBox]$DWFOutputSettingsDlg", Parent = typeof(Plant3D))]
    public partial class PIDPublishOutputSettingsDLG : Autodesk.GUIHarness.AutoCAD.AcDialogBox
    {
        public  PushButton CancelBtn;
        public  PushButton ClearAllBtn;
        public  PushButton HelpBtn;
        public  TreeView M_classTreeView;
        public  Table M_detailedPropsDataGridView;
        public  GroupBox ObjPropPage;
        public  CustomWin ObjPropSettingsCtrl;
        public  PushButton OkBtn;
        public  GroupBox PropDetailsGroupBox;
        public  PageList PropTabControl;
        public  PushButton RestoreToDefaultButton;
        public  PushButton SelectAllBtn;
        public  CheckBox ShowItemsOnlyCheckBox;

        partial void OnInitialize();

        public PIDPublishOutputSettingsDLG()
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

            ObjPropSettingsCtrl = new CustomWin()
            {
                Tag = "[CustomWin]$objPropSettingsCtrl",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ObjPropSettingsCtrl);

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

            PropTabControl = new PageList()
            {
                Tag = "[PageList]$propTabControl",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(PropTabControl);

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
