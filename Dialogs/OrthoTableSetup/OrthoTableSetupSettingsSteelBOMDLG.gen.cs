// This file is auto-generated - do not hand edit this file.

using Autodesk.GUIHarness;
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{

    [UIElement(Tag = "[Window]Ortho Table Setup|$Window_BOMSetup", Parent = typeof(MainWin), GUIType = GuiType.UIA)]
    public partial class OrthoTableSetupSettingsSteelBOMDLG : Window
    {
        public  PushButton Add1PB;
        public  PushButton Add2PB;
        public  PushButton BrowsePB;
        public  PopupList DescriptionsPL;

        partial void OnInitialize();

        public OrthoTableSetupSettingsSteelBOMDLG()
        {
            InitializeComponent();
            OnInitialize();
        }

        private void InitializeComponent()
        {

            Add1PB = new PushButton()
            {
                Tag = "[PageList]$TabControl_Table|#1/[Window]$TabItem_Settings|#2/[CustomWin]$UserControl_BOMSetupSetting|#1/[PushButton]$Button_GroupByAdd",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Add1PB);

            Add2PB = new PushButton()
            {
                Tag = "[PageList]$TabControl_Table|#1/[Window]$TabItem_Settings|#2/[CustomWin]$UserControl_BOMSetupSetting|#1/[PushButton]$Button_SortByAdd",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Add2PB);

            BrowsePB = new PushButton()
            {
                Tag = "[PageList]$TabControl_Table|#1/[Window]$TabItem_Settings|#2/[CustomWin]$UserControl_BOMSetupSetting|#1/[PushButton]$Button_BrowseCustomDescription",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(BrowsePB);

            DescriptionsPL = new PopupList()
            {
                Tag = "[PageList]$TabControl_Table|#1/[Window]$TabItem_Settings|#2/[CustomWin]$UserControl_BOMSetupSetting|#1/[PopupList]$ComboBox_Descriptions",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(DescriptionsPL);
        }
    }
}
