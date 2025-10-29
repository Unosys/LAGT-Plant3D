// This file is auto-generated - do not hand edit this file.

using Autodesk.GUIHarness;
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{

    [UIElement(Tag = "[Pane]$EditProjectSettingsDlg", Parent = typeof(Plant3D))]
    public partial class P3DLineGroupDLG : Pane
    {
        public  PushButton M_btnAddAnn;
        public  PushButton M_btnAddProperty;
        public  PushButton M_btnCancel;
        public  PushButton MapPB;

        partial void OnInitialize();

        public P3DLineGroupDLG()
        {
            InitializeComponent();
            OnInitialize();
        }

        private void InitializeComponent()
        {

            M_btnAddAnn = new PushButton()
            {
                Tag = "[PushButton]$m_btnAddAnn",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_btnAddAnn);

            M_btnAddProperty = new PushButton()
            {
                Tag = "[PushButton]$m_btnAddProperty",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_btnAddProperty);

            M_btnCancel = new PushButton()
            {
                Tag = "[PushButton]$m_btnCancel",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_btnCancel);

            MapPB = new PushButton()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]#1/[Pane]$m_splitVert|#1/[Pane]*/[Pane]$m_class3dPropertySettingsUserCtrl|#1/[GroupBox]$m_groupBox|#1/[GroupBox]$m_groupBoxProperties|#2/[PushButton]$m_btnMapProperties",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(MapPB);
        }
    }
}
