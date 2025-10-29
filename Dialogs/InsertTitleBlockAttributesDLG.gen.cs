// This file is auto-generated - do not hand edit this file.

using Autodesk.GUIHarness;
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{

    [UIElement(Tag = "[Pane]$IsometricTitleBlockAttributeSetupFrm")]
    public partial class InsertTitleBlockAttributesDLG : Pane
    {
        public  PushButton M_closeButton;
        public  PushButton PushButtonPB;
        public  Pane AddAttributesPANE;
        public  PushButton MapAttributesPB;

        partial void OnInitialize();

        public InsertTitleBlockAttributesDLG()
        {
            InitializeComponent();
            OnInitialize();
        }

        private void InitializeComponent()
        {

            M_closeButton = new PushButton()
            {
                Tag = "[PushButton]Close|$m_closeButton|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_closeButton);

            PushButtonPB = new PushButton()
            {
                Tag = "[PageList]$m_tabControl|#1/[Pane]$m_LDTSetupTab|#1/[PushButton]$m_selectLDTFileBtn",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(PushButtonPB);

            AddAttributesPANE = new Pane()
            {
                Tag = "[PageList]$m_tabControl|#1/[Pane]$m_addAttributesTab|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(AddAttributesPANE);

            MapAttributesPB = new PushButton()
            {
                Tag = "[PageList]$m_tabControl|#1/[Pane]Add Attributes|$m_addAttributesTab|#1/[PushButton]Map attributes*|$m_mapATRBtn|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(MapAttributesPB);
        }
    }
}
