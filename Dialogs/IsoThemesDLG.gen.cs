// This file is auto-generated - do not hand edit this file.

using Autodesk.GUIHarness;
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{

    [UIElement(Tag = "[Pane]$IsoThemesDlg", Parent = typeof(Plant3D))]
    public partial class IsoThemesDLG : Autodesk.GUIHarness.AutoCAD.AcDialogBox
    {
        public  PushButton BtnCancel;
        public  Pane DefaultThemePANE;

        partial void OnInitialize();

        public IsoThemesDLG()
        {
            InitializeComponent();
            OnInitialize();
        }

        private void InitializeComponent()
        {

            BtnCancel = new PushButton()
            {
                Tag = "[PushButton]$btnCancel",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(BtnCancel);

            DefaultThemePANE = new Pane()
            {
                Tag = "[PageList]$tabThemes|#1/[Pane]$tabDefault|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(DefaultThemePANE);
        }
    }
}
