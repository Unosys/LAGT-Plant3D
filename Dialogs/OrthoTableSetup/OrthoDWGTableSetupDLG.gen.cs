// This file is auto-generated - do not hand edit this file.

using Autodesk.GUIHarness;
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{

    [UIElement(Tag = "[Window]Ortho Table Setup|$Window_BOMSetup", Parent = typeof(MainWin), GUIType = GuiType.UIA)]
    public partial class OrthoDWGTableSetupDLG : Autodesk.GUIHarness.AutoCAD.AcDialogBox
    {
        public  Window SettingsWIN;
        public  StaticText SettingsST;
        public  Window TableLayoutWIN;
        public  StaticText TableLayoutST;
        public  CustomWin CustomWinWIN;
        public  PushButton Add1PB;
        public  PushButton Remove1PB;
        public  PushButton CancelPB;
        public  PushButton OKPB;

        partial void OnInitialize();

        public OrthoDWGTableSetupDLG()
        {
            InitializeComponent();
            OnInitialize();
        }

        private void InitializeComponent()
        {

            SettingsWIN = new Window()
            {
                Tag = "[PageList]$TabControl_Table|#1/[Window]Settings|$TabItem_Settings|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(SettingsWIN);

            SettingsST = new StaticText()
            {
                Tag = "[PageList]$TabControl_Table|#1/[Window]Settings|$TabItem_Settings|#2/[StaticText]Settings|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(SettingsST);

            TableLayoutWIN = new Window()
            {
                Tag = "[PageList]$TabControl_Table|#1/[Window]Table Layout|$TabItem_TableLayout|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(TableLayoutWIN);

            TableLayoutST = new StaticText()
            {
                Tag = "[PageList]$TabControl_Table|#1/[Window]Table Layout|$TabItem_TableLayout|#1/[StaticText]Table Layout|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(TableLayoutST);

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
        }
    }
}
