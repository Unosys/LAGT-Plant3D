// This file is auto-generated - do not hand edit this file.

using Autodesk.GUIHarness;
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{

    [UIElement(Tag = "[Pane]Customization|$CustomizationForm", Parent = typeof(Pane), GUIType = GuiType.UIA)]
    public partial class CustomizationDLG : Pane
    {
        public  Pane ToolbarsPANE;
        public  PushButton RenamePB;
        public  PushButton ResetPB;
        public  PushButton DeletePB;
        public  PushButton NewPB;
        public  StaticText ToolbarsST;
        public  ListBox ToolbarsLB;
        public  CheckBox ToolbarCK;
        public  CheckBox StatusBarCK;
        public  CheckBox MainMenuCK;
        public  Window ToolbarsWIN;
        public  Window CommandsWIN;
        public  Window OptionsWIN;
        public  PushButton Close1PB;
        public  TitleBar CustomizationCTL;
        public  CustomWin SystemMenuBarWIN;
        public  MenuItem SystemMI;
        public  PushButton Close2PB;

        partial void OnInitialize();

        public CustomizationDLG()
        {
            InitializeComponent();
            OnInitialize();
        }

        private void InitializeComponent()
        {

            ToolbarsPANE = new Pane()
            {
                Tag = "[Pane]$localizationManager|#2/[PageList]$tabControl|#1/[Pane]$tpToolbars|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ToolbarsPANE);

            RenamePB = new PushButton()
            {
                Tag = "[Pane]$localizationManager|#2/[PageList]$tabControl|#1/[Pane]$tpToolbars|#1/[PushButton]Rename|$btRenameBar|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(RenamePB);

            ResetPB = new PushButton()
            {
                Tag = "[Pane]$localizationManager|#2/[PageList]$tabControl|#1/[Pane]$tpToolbars|#1/[PushButton]Reset|$btResetBar|#4",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ResetPB);

            DeletePB = new PushButton()
            {
                Tag = "[Pane]$localizationManager|#2/[PageList]$tabControl|#1/[Pane]$tpToolbars|#1/[PushButton]Delete|$btDeleteBar|#3",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(DeletePB);

            NewPB = new PushButton()
            {
                Tag = "[Pane]$localizationManager|#2/[PageList]$tabControl|#1/[Pane]$tpToolbars|#1/[PushButton]New|$btNewBar|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(NewPB);

            ToolbarsST = new StaticText()
            {
                Tag = "[Pane]$localizationManager|#2/[PageList]$tabControl|#1/[Pane]$tpToolbars|#1/[StaticText]Toolbars:|$lbToolbarCaption|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ToolbarsST);

            ToolbarsLB = new ListBox()
            {
                Tag = "[Pane]$localizationManager|#2/[PageList]$tabControl|#1/[Pane]$tpToolbars|#1/[ListBox]Toolbars:|$toolBarsList|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ToolbarsLB);

            ToolbarCK = new CheckBox()
            {
                Tag = "[Pane]$localizationManager|#2/[PageList]$tabControl|#1/[Pane]$tpToolbars|#1/[ListBox]Toolbars:|$toolBarsList|#1/[CheckBox]Toolbar|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ToolbarCK);

            StatusBarCK = new CheckBox()
            {
                Tag = "[Pane]$localizationManager|#2/[PageList]$tabControl|#1/[Pane]$tpToolbars|#1/[ListBox]Toolbars:|$toolBarsList|#1/[CheckBox]Status Bar|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(StatusBarCK);

            MainMenuCK = new CheckBox()
            {
                Tag = "[Pane]$localizationManager|#2/[PageList]$tabControl|#1/[Pane]$tpToolbars|#1/[ListBox]Toolbars:|$toolBarsList|#1/[CheckBox]Main Menu|#3",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(MainMenuCK);

            ToolbarsWIN = new Window()
            {
                Tag = "[Pane]$localizationManager|#2/[PageList]$tabControl|#1/[Window]Toolbars|#3",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ToolbarsWIN);

            CommandsWIN = new Window()
            {
                Tag = "[Pane]$localizationManager|#2/[PageList]$tabControl|#1/[Window]Commands|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(CommandsWIN);

            OptionsWIN = new Window()
            {
                Tag = "[Pane]$localizationManager|#2/[PageList]$tabControl|#1/[Window]Options|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(OptionsWIN);

            Close1PB = new PushButton()
            {
                Tag = "[Pane]$localizationManager|#2/[PushButton]Close|$btClose|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Close1PB);

            CustomizationCTL = new TitleBar()
            {
                Tag = "[TitleBar]Customization|$TitleBar|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(CustomizationCTL);

            SystemMenuBarWIN = new CustomWin()
            {
                Tag = "[TitleBar]Customization|$TitleBar|#1/[CustomWin]System Menu Bar|$CustomizationForm|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(SystemMenuBarWIN);

            SystemMI = new MenuItem()
            {
                Tag = "[TitleBar]Customization|$TitleBar|#1/[CustomWin]System Menu Bar|$CustomizationForm|#1/[MenuItem]System|$Item 1|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(SystemMI);

            Close2PB = new PushButton()
            {
                Tag = "[TitleBar]Customization|$TitleBar|#1/[PushButton]Close|$Close|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Close2PB);
        }
    }
}
