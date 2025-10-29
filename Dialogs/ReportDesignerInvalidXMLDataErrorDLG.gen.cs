// This file is auto-generated - do not hand edit this file.

using Autodesk.GUIHarness;
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{

    [UIElement(Tag = "[DialogBox]Report Designer Invalid XML Data Error", Parent = typeof(Plant3D))]
    public partial class ReportDesignerInvalidXMLDataErrorDLG : Autodesk.GUIHarness.AutoCAD.AcDialogBox
    {
        public  CustomWin OK;

        partial void OnInitialize();

        public ReportDesignerInvalidXMLDataErrorDLG()
        {
            InitializeComponent();
            OnInitialize();
        }

        private void InitializeComponent()
        {

            OK = new CustomWin()
            {
                Tag = "[CustomWin]$DevExpress.XtraEditors.SimpleButton",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(OK);
        }
    }
}
