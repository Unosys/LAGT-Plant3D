// This file is auto-generated - do not hand edit this file.

using Autodesk.GUIHarness;
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{

    [UIElement(Tag = "[Window]Ortho Table Setup|$Window_BOMSetup", Parent = typeof(MainWin), GUIType = GuiType.UIA)]
    public partial class OrthoTableSetupSettingsDLG : Window
    {
        public  ListBox ListBoxLB;
        public  Window SettingsWIN;
        public  StaticText SettingsST;
        public  CustomWin CustomWinWIN;
        public  PushButton Add1PB;
        public  PushButton Remove1PB;
        public  PushButton Add2PB;
        public  PushButton Remove2PB;
        public  PopupList DescriptionsPL;
        public  PushButton CancelPB;
        public  PushButton OKPB;
        public  PushButton BrowsePB;

        partial void OnInitialize();

        public OrthoTableSetupSettingsDLG()
        {
            InitializeComponent();
            OnInitialize();
        }

        private void InitializeComponent()
        {

            ListBoxLB = new ListBox()
            {
                Tag = "[ListBox]$ListView_TableTypes|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ListBoxLB);

            SettingsWIN = new Window()
            {
                Tag = "[PageList]$TabControl_Table|#1/[Window]$TabItem_Settings|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(SettingsWIN);

            SettingsST = new StaticText()
            {
                Tag = "[PageList]$TabControl_Table|#1/[Window]$TabItem_Settings|#2/[StaticText]Settings|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(SettingsST);

            CustomWinWIN = new CustomWin()
            {
                Tag = "[PageList]$TabControl_Table|#1/[Window]$TabItem_Settings|#2/[CustomWin]$UserControl_BOMSetupSetting|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(CustomWinWIN);

            Add1PB = new PushButton()
            {
                Tag = "[PageList]$TabControl_Table|#1/[Window]$TabItem_Settings|#2/[CustomWin]$UserControl_BOMSetupSetting|#1/[PushButton]Add|$Button_GroupByAdd|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Add1PB);

            Remove1PB = new PushButton()
            {
                Tag = "[PageList]$TabControl_Table|#1/[Window]$TabItem_Settings|#2/[CustomWin]$UserControl_BOMSetupSetting|#1/[PushButton]Remove|$Button_GroupByRemove|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Remove1PB);

            Add2PB = new PushButton()
            {
                Tag = "[PageList]$TabControl_Table|#1/[Window]$TabItem_Settings|#2/[CustomWin]$UserControl_BOMSetupSetting|#1/[PushButton]$Button_SortByAdd",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Add2PB);

            Remove2PB = new PushButton()
            {
                Tag = "[PageList]$TabControl_Table|#1/[Window]$TabItem_Settings|#2/[CustomWin]$UserControl_BOMSetupSetting|#1/[PushButton]Remove|$Button_SortByRemove|#4",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Remove2PB);

            DescriptionsPL = new PopupList()
            {
                Tag = "[PageList]$TabControl_Table|#1/[Window]$TabItem_Settings|#2/[CustomWin]$UserControl_BOMSetupSetting|#1/[PopupList]$ComboBox_Descriptions",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(DescriptionsPL);

            CancelPB = new PushButton()
            {
                Tag = "[PushButton]Cancel|$Button_Cancel|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(CancelPB);

            OKPB = new PushButton()
            {
                Tag = "[PushButton]OK|$Button_OK|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(OKPB);

            BrowsePB = new PushButton()
            {
                Tag = "[PageList]$TabControl_Table|#1/[Window]$TabItem_Settings|#2/[CustomWin]$UserControl_BOMSetupSetting|#1/[PushButton]$Button_BrowseCustomDescription",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(BrowsePB);
        }
    }
}
