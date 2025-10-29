// This file is auto-generated - do not hand edit this file.

using Autodesk.GUIHarness;
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{

    [UIElement(Tag = "[DialogBox]$PropertyMismatchDlg", Parent = typeof(Plant3D))]
    public partial class PropertyMismatchDLG : Autodesk.GUIHarness.AutoCAD.AcDialogBox
    {
        public  PushButton Continue;

        partial void OnInitialize();

        public PropertyMismatchDLG()
        {
            InitializeComponent();
            OnInitialize();
        }

        private void InitializeComponent()
        {

            Continue = new PushButton()
            {
                Tag = "[PushButton]$btnContinue",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Continue);
        }
    }
}
