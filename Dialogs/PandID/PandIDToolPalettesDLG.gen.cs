// This file is auto-generated - do not hand edit this file.

using Autodesk.GUIHarness;
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{

    [UIElement(Tag = "[CustomWin]Tool Palettes|#6", Parent = typeof(Plant3D), GUIType = GuiType.WIN32)]
    public partial class PandIDToolPalettesDLG : CustomWin
    {
        public  CustomWin ToolPalettes1WIN;
        public  CustomWin ToolPalettes2WIN;
        public  CustomWin ValvesWIN;
        public  CustomWin CustomWinWIN;

        partial void OnInitialize();

        public PandIDToolPalettesDLG()
        {
            InitializeComponent();
            OnInitialize();
        }

        private void InitializeComponent()
        {

            ToolPalettes1WIN = new CustomWin()
            {
                Tag = "[CustomWin]Tool Palettes|$59423|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ToolPalettes1WIN);

            ToolPalettes2WIN = new CustomWin()
            {
                Tag = "[CustomWin]Tool Palettes|$59423|#1/[CustomWin]Tool Palettes|$16718|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ToolPalettes2WIN);

            ValvesWIN = new CustomWin()
            {
                Tag = "[CustomWin]Tool Palettes|$59423|#1/[CustomWin]Tool Palettes|$16718|#1/[CustomWin]Valves|$5|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ValvesWIN);

            CustomWinWIN = new CustomWin()
            {
                Tag = "[CustomWin]Tool Palettes|$59423|#1/[CustomWin]Tool Palettes|$16718|#1/[CustomWin]Valves|$5|#1/[CustomWin]$65535|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(CustomWinWIN);
        }
    }
}
