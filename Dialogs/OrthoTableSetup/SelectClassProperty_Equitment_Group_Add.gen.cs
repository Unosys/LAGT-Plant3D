// This file is auto-generated - do not hand edit this file.

using Autodesk.GUIHarness;
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{

    [UIElement(Tag = "[Pane]$SelectClassPropertyDlg", Parent = typeof(Window), GUIType = GuiType.UIA)]
    public partial class SelectClassProperty_Equitment_Group_Add : Pane
    {
        public  PushButton CancelPB;
        public  PushButton OKPB;

        partial void OnInitialize();

        public SelectClassProperty_Equitment_Group_Add()
        {
            InitializeComponent();
            OnInitialize();
        }

        private void InitializeComponent()
        {

            CancelPB = new PushButton()
            {
                Tag = "[PushButton]Cancel|$m_btnCancel|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(CancelPB);

            OKPB = new PushButton()
            {
                Tag = "[PushButton]OK|$m_btnOK|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(OKPB);
        }
    }
}
