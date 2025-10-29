// This file is auto-generated - do not hand edit this file.

using Autodesk.GUIHarness;
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{

    [UIElement(Tag = "[DialogBox]Invalid File", Parent = typeof(SpecEditorDLG))]
    public partial class SpecUtilityInvalidFileDLG : Autodesk.GUIHarness.AutoCAD.AcDialogBox
    {
        public  PushButton OkPB;

        partial void OnInitialize();

        public SpecUtilityInvalidFileDLG()
        {
            InitializeComponent();
            OnInitialize();
        }

        private void InitializeComponent()
        {

            OkPB = new PushButton()
            {
                Tag = "[PushButton]$2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(OkPB);
        }
    }
}
