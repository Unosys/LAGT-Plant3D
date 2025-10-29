// This file is auto-generated - do not hand edit this file.

using Autodesk.GUIHarness;
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{

    [UIElement(Tag = "[Pane]$ResolveExcelImportChanges")]
    public partial class ResolveExcelImportChangesDLG : Autodesk.GUIHarness.Pane
    {
        public  PushButton CancelPB;

        partial void OnInitialize();

        public ResolveExcelImportChangesDLG()
        {
            InitializeComponent();
            OnInitialize();
        }

        private void InitializeComponent()
        {

            CancelPB = new PushButton()
            {
                Tag = "[Pane]$m_Panel_Bottom|#3/[PushButton]Cancel|$m_btn_Cancel|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(CancelPB);
        }
    }
}
