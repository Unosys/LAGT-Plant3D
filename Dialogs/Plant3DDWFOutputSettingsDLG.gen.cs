// This file is auto-generated - do not hand edit this file.

using Autodesk.GUIHarness;
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{

    [UIElement(Tag = "[Pane]$DWFOutputSettingsDlg")]
    public partial class Plant3DDWFOutputSettingsDLG : Pane
    {
        public  PushButton RestoreToDefaultPB;
        public  PushButton CancelBtn;
        public  PushButton OKPB;
        public  CustomizedPagelist PageListPG;
        public  CheckBox ShowClassesWithItemsCK;

        partial void OnInitialize();

        public Plant3DDWFOutputSettingsDLG()
        {
            InitializeComponent();
            OnInitialize();
        }

        private void InitializeComponent()
        {

            RestoreToDefaultPB = new PushButton()
            {
                Tag = "[PushButton]Restore to Default|$restoreToDefaultButton|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(RestoreToDefaultPB);

            CancelBtn = new PushButton()
            {
                Tag = "[PushButton]Cancel|$cancelBtn|#3",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(CancelBtn);

            OKPB = new PushButton()
            {
                Tag = "[PushButton]OK|$okBtn|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(OKPB);

            PageListPG = new CustomizedPagelist()
            {
                Tag = "[PageList]$propTabControl|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(PageListPG);

            ShowClassesWithItemsCK = new CheckBox()
            {
                Tag = "[PageList]$propTabControl|#1/[Window]#1/[Pane]$objPropPage|#1/[Pane]$objPropSettingsCtrl|#1/[CheckBox]$showItemsOnlyCheckBox|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ShowClassesWithItemsCK);
        }
    }
}
