// This file is auto-generated - do not hand edit this file.

using Autodesk.GUIHarness;
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{

    [UIElement(Tag = "[Pane]Insert Title Block Attributes|$IsometricTitleBlockAttributeSetupFrm", Parent = typeof(Plant3D), GUIType = GuiType.UIA)]
    public partial class InsertTitleBlockAttributes_RequiredExelDLG : Pane
    {
        public  Pane AddAttributesPANE;
        public  PopupList AttributeCategoryPL;
        public  PushButton M_closeButton;

        partial void OnInitialize();

        public InsertTitleBlockAttributes_RequiredExelDLG()
        {
            InitializeComponent();
            OnInitialize();
        }

        private void InitializeComponent()
        {

            AddAttributesPANE = new Pane()
            {
                Tag = "[PageList]$m_tabControl|#1/[Pane]$m_addAttributesTab|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(AddAttributesPANE);

            AttributeCategoryPL = new PopupList()
            {
                Tag = "[PageList]$m_tabControl|#1/[Pane]Add Attributes|$m_addAttributesTab|#1/[PopupList]Attribute category:|$m_attributeCategoryComboBox|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(AttributeCategoryPL);

            M_closeButton = new PushButton()
            {
                Tag = "[PushButton]Close|$m_closeButton|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_closeButton);
        }
    }
}
