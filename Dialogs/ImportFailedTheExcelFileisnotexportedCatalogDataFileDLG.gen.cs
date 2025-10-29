// This file is auto-generated - do not hand edit this file.

using Autodesk.GUIHarness;
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{

    [UIElement(Tag = "[DialogBox]*/Import Failed|#1")]
    public partial class ImportFailedTheExcelFileisnotexportedCatalogDataFileDLG : Autodesk.GUIHarness.AutoCAD.AcDialogBox
    {
        public  PushButton OkPB;
        public  CustomWin Icon1;
        public  StaticText TheExcelFileIsNotAnExpor;

        partial void OnInitialize();

        public ImportFailedTheExcelFileisnotexportedCatalogDataFileDLG()
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

            Icon1 = new CustomWin()
            {
                Tag = "[Icon]$20",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Icon1);

            TheExcelFileIsNotAnExpor = new StaticText()
            {
                Tag = "$65535",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(TheExcelFileIsNotAnExpor);
        }
    }
}
