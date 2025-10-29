// This file is auto-generated - do not hand edit this file.

using Autodesk.GUIHarness;
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{

    [UIElement(Tag = "[Pane]External Database Reference Manager|$XDbReferenceManagerDialog", Parent = typeof(MainWin), GUIType = GuiType.UIA)]
    public partial class ExternalDatabaseReferenceManager : Autodesk.GUIHarness.AutoCAD.AcDialogBox
    {
        public  Pane DataSourcesPANE;
        public  PushButton Close2PB;

        partial void OnInitialize();

        public ExternalDatabaseReferenceManager()
        {
            InitializeComponent();
            OnInitialize();
        }

        private void InitializeComponent()
        {

            DataSourcesPANE = new Pane()
            {
                Tag = "[PageList]$m_tabCtrlPrjParts|#1/[Pane]#1/[Pane]$m_xDbReferenceManagerControl|#1/[Pane]$splitContainer|#1/[Pane]#1/[PageList]$m_tabCtrlSelection|#1/[Pane]$m_tabDataSources|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(DataSourcesPANE);

            Close2PB = new PushButton()
            {
                Tag = "[TitleBar]External Database Reference Manager|$TitleBar|#1/[PushButton]Close|$Close|#3",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Close2PB);
        }
    }
}
