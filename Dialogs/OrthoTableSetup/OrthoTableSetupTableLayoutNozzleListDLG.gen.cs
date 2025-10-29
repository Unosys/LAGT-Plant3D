// This file is auto-generated - do not hand edit this file.

using Autodesk.GUIHarness;
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{

    [UIElement(Tag = "[Window]Ortho Table Setup|$Window_BOMSetup", Parent = typeof(MainWin), GUIType = GuiType.UIA)]
    public partial class OrthoTableSetupTableLayoutNozzleListDLG : Window
    {
        public  PushButton AddColumnPB;

        partial void OnInitialize();

        public OrthoTableSetupTableLayoutNozzleListDLG()
        {
            InitializeComponent();
            OnInitialize();
        }

        private void InitializeComponent()
        {

            AddColumnPB = new PushButton()
            {
                Tag = "[PageList]$TabControl_Table|#1/[Window]Table Layout|$TabItem_TableLayout|#1/[CustomWin]$UserControl_BOMSetupTabs|#1/[CustomWin]$UserControl_BOMSetupTable|#2/[PushButton]$Button_AddColumn",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(AddColumnPB);
        }
    }
}
