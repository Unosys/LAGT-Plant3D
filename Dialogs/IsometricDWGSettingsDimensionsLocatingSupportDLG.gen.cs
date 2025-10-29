// This file is auto-generated - do not hand edit this file.

using Autodesk.GUIHarness;
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{

    [UIElement(Tag = "[Pane]Project Setup|$EditProjectSettingsDlg", Parent = typeof(Plant3D), GUIType = GuiType.UIA)]
    public partial class IsometricDWGSettingsDimensionsLocatingSupportDLG : Autodesk.GUIHarness.AutoCAD.AcDialogBox
    {
        public  PopupList HowToDimensionEndPointsPL;
        public  PushButton CancelPB;
        public  PushButton OKPB;
        public  PushButton ClosePB;

        partial void OnInitialize();

        public IsometricDWGSettingsDimensionsLocatingSupportDLG()
        {
            InitializeComponent();
            OnInitialize();
        }

        private void InitializeComponent()
        {

            HowToDimensionEndPointsPL = new PopupList()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]*/[Pane]$m_splitVert|#1/[Pane]*/[Pane]*/[Pane]#1/[CustomWin]#1/[CustomWin]$UserControl_1|#1/[PageList]$TabControl_1|#1/[Window]#4/[CustomWin]$UserControl_1|#1/[PopupList]$ImageCombobox",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(HowToDimensionEndPointsPL);

            CancelPB = new PushButton()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]*/[PushButton]$m_btnCancel",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(CancelPB);

            OKPB = new PushButton()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]*/[PushButton]OK|$m_btnOk|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(OKPB);

            ClosePB = new PushButton()
            {
                Tag = "[TitleBar]Project Setup|$TitleBar|#1/[PushButton]Close|$Close|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ClosePB);
        }
    }
}
