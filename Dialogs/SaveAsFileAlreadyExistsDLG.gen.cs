// This file is auto-generated - do not hand edit this file.

using Autodesk.GUIHarness;
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{

    [UIElement(Tag = "[DialogBox]Save As", Parent = typeof(Plant3D))]
    public partial class SaveAsFileAlreadyExistsDLG : Autodesk.GUIHarness.AutoCAD.AcDialogBox
    {
        public  PushButton Yes;
        public  PushButton No;
        public  CustomWin Icon1;
        public  StaticText FileEImagesXtraReportTempl;

        partial void OnInitialize();

        public SaveAsFileAlreadyExistsDLG()
        {
            InitializeComponent();
            OnInitialize();
        }

        private void InitializeComponent()
        {

            Yes = new PushButton()
            {
                Tag = "[PushButton]Yes|#1|$6",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Yes);

            No = new PushButton()
            {
                Tag = "[PushButton]No|#2|$7",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(No);

            Icon1 = new CustomWin()
            {
                Tag = "[CustomWin][Icon]#1|[Icon]$20",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Icon1);

            FileEImagesXtraReportTempl = new StaticText()
            {
                Tag = "[StaticText]File E:\\images\\xtraReportTemplate1.pdf already exists.??Do you want to replace it?|#1|$65535",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(FileEImagesXtraReportTempl);
        }
    }
}
