// This file is auto-generated - do not hand edit this file.

using Autodesk.GUIHarness;
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{

    [UIElement(Tag = "[DialogBox]ExportDocumentMenuDLG", Parent = typeof(Plant3D))]
    public partial class ExportDocumentMenuDLG : Autodesk.GUIHarness.AutoCAD.AcDialogBox
    {
        public  CustomWin DevExpressXtraBarsControlsP;
        public  CustomWin CustomWin1;
        public  PushButton PDFFile;
        public  PushButton HTMLFile;
        public  PushButton MHTFile;
        public  PushButton RTFFile;
        public  PushButton XLSFile;
        public  PushButton XLSXFile;
        public  PushButton CSVFile;
        public  PushButton TextFile;
        public  PushButton ImageFile;

        partial void OnInitialize();

        public ExportDocumentMenuDLG()
        {
            InitializeComponent();
            OnInitialize();
        }

        private void InitializeComponent()
        {

            DevExpressXtraBarsControlsP = new CustomWin()
            {
                Tag = "[DevExpress.XtraBars.Controls.PopupMenuBarControl]#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(DevExpressXtraBarsControlsP);

            CustomWin1 = new CustomWin()
            {
                Tag = "#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(CustomWin1);

            PDFFile = new PushButton()
            {
                Tag = "[PushButton]PDF File|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(PDFFile);

            HTMLFile = new PushButton()
            {
                Tag = "[PushButton]HTML File|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(HTMLFile);

            MHTFile = new PushButton()
            {
                Tag = "[PushButton]MHT File|#3",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(MHTFile);

            RTFFile = new PushButton()
            {
                Tag = "[PushButton]RTF File|#4",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(RTFFile);

            XLSFile = new PushButton()
            {
                Tag = "[PushButton]XLS File|#5",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(XLSFile);

            XLSXFile = new PushButton()
            {
                Tag = "[PushButton]XLSX File|#6",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(XLSXFile);

            CSVFile = new PushButton()
            {
                Tag = "[PushButton]CSV File|#7",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(CSVFile);

            TextFile = new PushButton()
            {
                Tag = "[PushButton]Text File|#8",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(TextFile);

            ImageFile = new PushButton()
            {
                Tag = "[PushButton]Image File|#9",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ImageFile);
        }
    }
}
