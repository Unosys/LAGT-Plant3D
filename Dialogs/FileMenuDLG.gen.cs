// This file is auto-generated - do not hand edit this file.

using Autodesk.GUIHarness;
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{

    [UIElement(Tag = "[DialogBox]FileMenuDLG", Parent = typeof(Plant3D))]
    public partial class FileMenuDLG : Autodesk.GUIHarness.AutoCAD.AcDialogBox
    {
        public  CustomWin DevExpressXtraBarsControlsS;
        public  PushButton PageSetup;
        public  PushButton Print1;
        public  PushButton Print2;
        public  PushButton ExportDocument;
        public  PushButton PDFFile;
        public  PushButton HTMLFile;
        public  PushButton MHTFile;
        public  PushButton RTFFile;
        public  PushButton XLSFile;
        public  PushButton XLSXFile;
        public  PushButton CSVFile;
        public  PushButton TextFile;
        public  PushButton ImageFile;
        public  PushButton SendViaEMail;
        public  PushButton Exit;

        partial void OnInitialize();

        public FileMenuDLG()
        {
            InitializeComponent();
            OnInitialize();
        }

        private void InitializeComponent()
        {

            DevExpressXtraBarsControlsS = new CustomWin()
            {
                Tag = "[DevExpress.XtraBars.Controls.SubMenuBarControl]#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(DevExpressXtraBarsControlsS);

            PageSetup = new PushButton()
            {
                Tag = "[PushButton]Page Setup|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(PageSetup);

            Print1 = new PushButton()
            {
                Tag = "[PushButton]Print[1]|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Print1);

            Print2 = new PushButton()
            {
                Tag = "[PushButton]Print[2]|#3",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Print2);

            ExportDocument = new PushButton()
            {
                Tag = "[PushButton]Export Document|#4",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ExportDocument);

            PDFFile = new PushButton()
            {
                Tag = "[PushButton]PDF File|#7",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(PDFFile);

            HTMLFile = new PushButton()
            {
                Tag = "[PushButton]HTML File|#6",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(HTMLFile);

            MHTFile = new PushButton()
            {
                Tag = "[PushButton]MHT File|#9",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(MHTFile);

            RTFFile = new PushButton()
            {
                Tag = "[PushButton]RTF File|#8",
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
                Tag = "[PushButton]XLSX File|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(XLSXFile);

            CSVFile = new PushButton()
            {
                Tag = "[PushButton]CSV File|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(CSVFile);

            TextFile = new PushButton()
            {
                Tag = "[PushButton]Text File|#4",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(TextFile);

            ImageFile = new PushButton()
            {
                Tag = "[PushButton]Image File|#3",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ImageFile);

            SendViaEMail = new PushButton()
            {
                Tag = "[PushButton]Send via E-Mail|#5",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(SendViaEMail);

            Exit = new PushButton()
            {
                Tag = "[PushButton]Exit|#6",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Exit);
        }
    }
}
