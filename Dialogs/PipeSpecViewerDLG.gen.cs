// This file is auto-generated - do not hand edit this file.

using Autodesk.GUIHarness;
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{

    [UIElement(Tag = "[CustomWin]#5|#3", Parent = typeof(Plant3D), GUIType = GuiType.WIN32)]
    public partial class PipeSpecViewerDLG : Autodesk.GUIHarness.AutoCAD.AcDialogBox
    {
        public  ListViewItem Row1LVI;

        partial void OnInitialize();

        public PipeSpecViewerDLG()
        {
            InitializeComponent();
            OnInitialize();
        }

        private void InitializeComponent()
        {

            Row1LVI = new ListViewItem()
            {
                Tag = "[CustomWin]$59423|#1/[CustomWin]$16722|#1/[CustomWin]P$15|#1/[Pane]$ControlAxSourcingSite|#1/[Pane]$m_SplitContainer|#1/[Pane]#1/[Pane]$m_Panel_Top|#2/[Pane]#1/[Pane]#1/[CustomWin]#1/[CustomWin]$UserControl_SpecListView|#1/[ListView]$SpecSheetListView|#1/[ListViewItem]#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Row1LVI);
        }
    }
}
