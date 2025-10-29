// This file is auto-generated - do not hand edit this file.

using Autodesk.GUIHarness;
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{

    [UIElement(Tag = "[DialogBox]Choose Which Settings are Synced", Parent = typeof(MainWin), GUIType = GuiType.WIN32)]
    public partial class ChooseWhichSettingsAreSyncedForPlant3DDLG : DialogBox
    {
        public  StaticText IncludeTheFollowingSettingsST;
        public  PushButton OKPB;
        public  PushButton CancelPB;
        public  PushButton HelpPB;
        public  CheckBox OptionsCK;
        public  CheckBox CustomizationFilesCK;
        public  CheckBox PrinterSupportFilesCK;
        public  CheckBox CustomHatchPatternsCK;
        public  CheckBox ToolPalettesCK;
        public  CheckBox DrawingTemplateFilesCK;
        public  StaticText SettingsThatRequireAST;
        public  CheckBox CustomFontsShapesAndCK;

        partial void OnInitialize();

        public ChooseWhichSettingsAreSyncedForPlant3DDLG()
        {
            InitializeComponent();
            OnInitialize();
        }

        private void InitializeComponent()
        {

            IncludeTheFollowingSettingsST = new StaticText()
            {
                Tag = "[StaticText]Include the following settings:|$39990|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(IncludeTheFollowingSettingsST);

            OKPB = new PushButton()
            {
                Tag = "[PushButton]OK|$1|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(OKPB);

            CancelPB = new PushButton()
            {
                Tag = "[PushButton]Cancel|$2|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(CancelPB);

            HelpPB = new PushButton()
            {
                Tag = "[PushButton]Help|$57670|#3",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(HelpPB);

            OptionsCK = new CheckBox()
            {
                Tag = "[CheckBox]Options|$38762|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(OptionsCK);

            CustomizationFilesCK = new CheckBox()
            {
                Tag = "[CheckBox]Customization files|$38763|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(CustomizationFilesCK);

            PrinterSupportFilesCK = new CheckBox()
            {
                Tag = "[CheckBox]Printer support files|$38764|#3",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(PrinterSupportFilesCK);

            CustomHatchPatternsCK = new CheckBox()
            {
                Tag = "[CheckBox]Custom hatch patterns|$38765|#4",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(CustomHatchPatternsCK);

            ToolPalettesCK = new CheckBox()
            {
                Tag = "[CheckBox]Tool palettes|$38766|#5",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ToolPalettesCK);

            DrawingTemplateFilesCK = new CheckBox()
            {
                Tag = "[CheckBox]Drawing template files|$38767|#6",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(DrawingTemplateFilesCK);

            SettingsThatRequireAST = new StaticText()
            {
                Tag = "[StaticText]Settings that require a restart of the application:|$14539|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(SettingsThatRequireAST);

            CustomFontsShapesAndCK = new CheckBox()
            {
                Tag = "[CheckBox]Custom fonts, shapes and linetypes|$38768|#7",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(CustomFontsShapesAndCK);
        }
    }
}
