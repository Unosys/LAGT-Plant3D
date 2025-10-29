// This file is auto-generated - do not hand edit this file.

using Autodesk.GUIHarness;
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{

    [UIElement(Tag = "[Window]Ortho Table Setup|$Window_BOMSetup", Parent = typeof(MainWin), GUIType = GuiType.UIA)]
    public partial class OrthoTableSetupTableLayoutEquipmentBOMDLG : Window
    {
        public  PushButton ManageComponentsPB;
        public  PushButton AddColumnPB;

        partial void OnInitialize();

        public OrthoTableSetupTableLayoutEquipmentBOMDLG()
        {
            InitializeComponent();
            OnInitialize();
        }

        private void InitializeComponent()
        {

            ManageComponentsPB = new PushButton()
            {
                Tag = "[PageList]$TabControl_Table|#1/[Window]$TabItem_TableLayout|#1/[CustomWin]$UserControl_BOMSetupTabs|#1/[CustomWin]$UserControl_BOMSetupTable|#2/[PushButton]$Button_ManageComponents",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ManageComponentsPB);

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
