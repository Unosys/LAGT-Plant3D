// This file is auto-generated - do not hand edit this file.

using Autodesk.GUIHarness;
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{

    [UIElement(Tag = "[Pane]$SelectEquipmentTypeDlg", Parent = typeof(Plant3D))]
    public partial class P3DConvertToEquipmentDLG : Pane
    {
        public  StaticText Label1;
        public  PushButton M_Cancel;
        public  PushButton M_Select;
        public  TreeView M_TypeTree;

        partial void OnInitialize();

        public P3DConvertToEquipmentDLG()
        {
            InitializeComponent();
            OnInitialize();
        }

        private void InitializeComponent()
        {

            Label1 = new StaticText()
            {
                Tag = "[StaticText]$label1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Label1);

            M_Cancel = new PushButton()
            {
                Tag = "[PushButton]$m_Cancel",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_Cancel);

            M_Select = new PushButton()
            {
                Tag = "[PushButton]$m_Select",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_Select);

            M_TypeTree = new TreeView()
            {
                Tag = "[TreeView]$m_TypeTree",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_TypeTree);
        }
    }
}
