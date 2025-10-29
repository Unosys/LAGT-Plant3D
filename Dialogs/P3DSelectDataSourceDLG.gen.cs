// This file is auto-generated - do not hand edit this file.

using Autodesk.GUIHarness;
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{

    [UIElement(Tag = "[Pane]$SelectDataSource", Parent = typeof(P3DAddPropertyDLG))]
    public partial class P3DSelectDataSourceDLG : Pane
    {
        public  PushButton M_cancelBtn;
        public  PushButton OKPB;
        public  Pane Pane1;

        partial void OnInitialize();

        public P3DSelectDataSourceDLG()
        {
            InitializeComponent();
            OnInitialize();
        }

        private void InitializeComponent()
        {

            M_cancelBtn = new PushButton()
            {
                Tag = "[PushButton]Cancel|$m_cancelBtn|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_cancelBtn);

            OKPB = new PushButton()
            {
                Tag = "[PushButton]OK|$m_OKBtn|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(OKPB);

            Pane1 = new Pane()
            {
                Tag = "[PageList]$m_propertyTabs|#1/[Pane]$m_objectTabPage|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Pane1);
        }
    }
}
