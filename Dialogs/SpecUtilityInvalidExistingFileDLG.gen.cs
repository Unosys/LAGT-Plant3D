// This file is auto-generated - do not hand edit this file.

using Autodesk.GUIHarness;
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{

    [UIElement(Tag = "[DialogBox]Invalid Existing File", Parent = typeof(CreateSpecFromExistingSpecDLG1))]
    public partial class SpecUtilityInvalidExistingFileDLG : Autodesk.GUIHarness.AutoCAD.AcDialogBox
    {
        public  PushButton OkPB;

        partial void OnInitialize();

        public SpecUtilityInvalidExistingFileDLG()
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
