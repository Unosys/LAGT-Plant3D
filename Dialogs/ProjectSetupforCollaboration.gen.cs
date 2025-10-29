// This file is auto-generated - do not hand edit this file.

using Autodesk.GUIHarness;
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{

    [UIElement(Tag = "[Pane]Project Setup|$EditProjectSettingsDlg", Parent = typeof(MainWin), GUIType = GuiType.UIA)]
    public partial class ProjectSetupforCollaboration : Autodesk.GUIHarness.AutoCAD.AcDialogBox
    {
        public  PushButton CheckOutPB;
        public  PushButton CancelPB;
        public  PushButton OKPB;
        public  PushButton ApplyPB;
        public  PushButton UndoCheckOutPB;

        partial void OnInitialize();

        public ProjectSetupforCollaboration()
        {
            InitializeComponent();
            OnInitialize();
        }

        private void InitializeComponent()
        {

            CheckOutPB = new PushButton()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]#2/[PushButton]Check Out|$m_btnCheckOut|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(CheckOutPB);

            CancelPB = new PushButton()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]#2/[PushButton]Cancel|$m_btnCancel|#4",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(CancelPB);

            OKPB = new PushButton()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]#2/[PushButton]OK|$m_btnOk|#3",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(OKPB);

            ApplyPB = new PushButton()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]#2/[PushButton]Apply|$m_btnSave|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ApplyPB);

            UndoCheckOutPB = new PushButton()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]#2/[PushButton]$m_btnCheckOut|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(UndoCheckOutPB);
        }
    }
}
