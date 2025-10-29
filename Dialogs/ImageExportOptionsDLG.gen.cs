// This file is auto-generated - do not hand edit this file.

using Autodesk.GUIHarness;
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{

    [UIElement(Tag = "[Pane]Image Export Options|$LinesForm|#1", GUIType = GuiType.UIA)]
    public partial class ImageExportOptionsDLG : Pane
    {
        public  Pane PnlButtonsPANE;
        public  PushButton CancelPB;
        public  PushButton OKPB;
        public  Pane Pane1PANE;
        public  Pane Pane2PANE;
        public  StaticText ImageFormatST;
        public  PopupList ImageFormatPL;
        public  StaticText PNGST;
        public  PushButton Open1PB;
        public  ListBox PNGLB;
        public  ListBoxItem BMPLBI;
        public  ListBoxItem EMFLBI;
        public  ListBoxItem WMFLBI;
        public  ListBoxItem GIFLBI;
        public  ListBoxItem JPEGLBI;
        public  ListBoxItem PNGLBI;
        public  ListBoxItem TIFFLBI;
        public  Pane Pane3PANE;
        public  StaticText ResolutiondpiST;
        public  TextField ResolutiondpiTF;
        public  TextField TextField1TF;
        public  TextField TextField2TF;
        public  CustomWin Spinner1WIN;
        public  PushButton Up1PB;
        public  PushButton Down1PB;
        public  Pane Pane4PANE;
        public  StaticText StaticText1ST;
        public  Pane Pane5PANE;
        public  StaticText ExportModeST;
        public  PopupList ExportModePL;
        public  StaticText SingleFileST;
        public  PushButton Open2PB;
        public  ListBox SingleFileLB;
        public  ListBoxItem SingleFileLBI;
        public  ListBoxItem SingleFilePagebypageLBI;
        public  ListBoxItem DifferentFilesLBI;
        public  Pane Pane6PANE;
        public  StaticText PageRangeST;
        public  PopupList PageRangePL;
        public  StaticText StaticText2ST;
        public  ListBox ListBoxLB;
        public  Pane Pane7PANE;
        public  Pane Pane8PANE;
        public  StaticText PageBorderColorST;
        public  TextField PageBorderColorTF;
        public  StaticText BlackST;
        public  PushButton BlackPB;
        public  Pane Pane9PANE;
        public  StaticText PageBorderWidthST;
        public  TextField PageBorderWidthTF;
        public  StaticText oneST;
        public  CustomWin Spinner2WIN;
        public  PushButton Up2PB;
        public  PushButton Down2PB;
        public  Pane Pane10PANE;
        public  StaticText StaticText3ST;
        public  TitleBar ImageExportOptionsCTL;
        public  PushButton ClosePB;

        partial void OnInitialize();

        public ImageExportOptionsDLG()
        {
            InitializeComponent();
            OnInitialize();
        }

        private void InitializeComponent()
        {

            PnlButtonsPANE = new Pane()
            {
                Tag = "[Pane]pnlButtons|$pnlButtons|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(PnlButtonsPANE);

            CancelPB = new PushButton()
            {
                Tag = "[Pane]The XtraLayoutControl|$layoutControl1|#1/[PushButton]Cancel|$btnCancel|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(CancelPB);

            OKPB = new PushButton()
            {
                Tag = "[Pane]The XtraLayoutControl|$layoutControl1|#1/[PushButton]OK|$btnOK|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(OKPB);

            Pane1PANE = new Pane()
            {
                Tag = "[Pane]$5637166|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Pane1PANE);

            Pane2PANE = new Pane()
            {
                Tag = "[Pane]$5637166|#1/[Pane]$2360862|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Pane2PANE);

            ImageFormatST = new StaticText()
            {
                Tag = "[Pane]$5637166|#1/[Pane]$2360862|#1/[StaticText]Image format:|$4785084|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ImageFormatST);

            ImageFormatPL = new PopupList()
            {
                Tag = "[Pane]$5637166|#1/[Pane]$2360862|#1/[PopupList]Image format:|$3474984|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ImageFormatPL);

            PNGST = new StaticText()
            {
                Tag = "[Pane]$5637166|#1/[Pane]$2360862|#1/[PopupList]Image format:|$3474984|#1/[StaticText]PNG|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(PNGST);

            Open1PB = new PushButton()
            {
                Tag = "[Pane]$5637166|#1/[Pane]$2360862|#1/[PopupList]Image format:|$3474984|#1/[PushButton]Open|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Open1PB);

            PNGLB = new ListBox()
            {
                Tag = "[Pane]$5637166|#1/[Pane]$2360862|#1/[PopupList]Image format:|$3474984|#1/[ListBox]PNG|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(PNGLB);

            BMPLBI = new ListBoxItem()
            {
                Tag = "[Pane]$5637166|#1/[Pane]$2360862|#1/[PopupList]Image format:|$3474984|#1/[ListBox]PNG|#1/[ListBoxItem]BMP|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(BMPLBI);

            EMFLBI = new ListBoxItem()
            {
                Tag = "[Pane]$5637166|#1/[Pane]$2360862|#1/[PopupList]Image format:|$3474984|#1/[ListBox]PNG|#1/[ListBoxItem]EMF|#6",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(EMFLBI);

            WMFLBI = new ListBoxItem()
            {
                Tag = "[Pane]$5637166|#1/[Pane]$2360862|#1/[PopupList]Image format:|$3474984|#1/[ListBox]PNG|#1/[ListBoxItem]WMF|#5",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(WMFLBI);

            GIFLBI = new ListBoxItem()
            {
                Tag = "[Pane]$5637166|#1/[Pane]$2360862|#1/[PopupList]Image format:|$3474984|#1/[ListBox]PNG|#1/[ListBoxItem]GIF|#4",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(GIFLBI);

            JPEGLBI = new ListBoxItem()
            {
                Tag = "[Pane]$5637166|#1/[Pane]$2360862|#1/[PopupList]Image format:|$3474984|#1/[ListBox]PNG|#1/[ListBoxItem]JPEG|#3",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(JPEGLBI);

            PNGLBI = new ListBoxItem()
            {
                Tag = "[Pane]$5637166|#1/[Pane]$2360862|#1/[PopupList]Image format:|$3474984|#1/[ListBox]PNG|#1/[ListBoxItem]PNG|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(PNGLBI);

            TIFFLBI = new ListBoxItem()
            {
                Tag = "[Pane]$5637166|#1/[Pane]$2360862|#1/[PopupList]Image format:|$3474984|#1/[ListBox]PNG|#1/[ListBoxItem]TIFF|#7",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(TIFFLBI);

            Pane3PANE = new Pane()
            {
                Tag = "[Pane]$5637166|#1/[Pane]$5636622|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Pane3PANE);

            ResolutiondpiST = new StaticText()
            {
                Tag = "[Pane]$5637166|#1/[Pane]$5636622|#2/[StaticText]Resolution (dpi):|$6751622|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ResolutiondpiST);

            ResolutiondpiTF = new TextField()
            {
                Tag = "[Pane]$5637166|#1/[Pane]$5636622|#2/[TextField]Resolution (dpi):|$4850742|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ResolutiondpiTF);

            TextField1TF = new TextField()
            {
                Tag = "[Pane]$5637166|#1/[Pane]$5636622|#2/[TextField]Resolution (dpi):|$4850742|#1/[TextField]$5046776|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(TextField1TF);

            TextField2TF = new TextField()
            {
                Tag = "[Pane]$5637166|#1/[Pane]$5636622|#2/[TextField]Resolution (dpi):|$4850742|#1/[TextField]#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(TextField2TF);

            Spinner1WIN = new CustomWin()
            {
                Tag = "[Pane]$5637166|#1/[Pane]$5636622|#2/[TextField]Resolution (dpi):|$4850742|#1/[CustomWin]Spinner|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Spinner1WIN);

            Up1PB = new PushButton()
            {
                Tag = "[Pane]$5637166|#1/[Pane]$5636622|#2/[TextField]Resolution (dpi):|$4850742|#1/[CustomWin]Spinner|#1/[PushButton]Up|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Up1PB);

            Down1PB = new PushButton()
            {
                Tag = "[Pane]$5637166|#1/[Pane]$5636622|#2/[TextField]Resolution (dpi):|$4850742|#1/[CustomWin]Spinner|#1/[PushButton]Down|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Down1PB);

            Pane4PANE = new Pane()
            {
                Tag = "[Pane]$5637166|#1/[Pane]$4654462|#3",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Pane4PANE);

            StaticText1ST = new StaticText()
            {
                Tag = "[Pane]$5637166|#1/[Pane]$4654462|#3/[StaticText]$6227170|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(StaticText1ST);

            Pane5PANE = new Pane()
            {
                Tag = "[Pane]$5637166|#1/[Pane]$3802508|#4",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Pane5PANE);

            ExportModeST = new StaticText()
            {
                Tag = "[Pane]$5637166|#1/[Pane]$3802508|#4/[StaticText]Export mode:|$5046862|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ExportModeST);

            ExportModePL = new PopupList()
            {
                Tag = "[Pane]$5637166|#1/[Pane]$3802508|#4/[PopupList]Export mode:|$5506818|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ExportModePL);

            SingleFileST = new StaticText()
            {
                Tag = "[Pane]$5637166|#1/[Pane]$3802508|#4/[PopupList]Export mode:|$5506818|#1/[StaticText]Single file|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(SingleFileST);

            Open2PB = new PushButton()
            {
                Tag = "[Pane]$5637166|#1/[Pane]$3802508|#4/[PopupList]Export mode:|$5506818|#1/[PushButton]Open|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Open2PB);

            SingleFileLB = new ListBox()
            {
                Tag = "[Pane]$5637166|#1/[Pane]$3802508|#4/[PopupList]Export mode:|$5506818|#1/[ListBox]Single file|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(SingleFileLB);

            SingleFileLBI = new ListBoxItem()
            {
                Tag = "[Pane]$5637166|#1/[Pane]$3802508|#4/[PopupList]Export mode:|$5506818|#1/[ListBox]Single file|#1/[ListBoxItem]Single file|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(SingleFileLBI);

            SingleFilePagebypageLBI = new ListBoxItem()
            {
                Tag = "[Pane]$5637166|#1/[Pane]$3802508|#4/[PopupList]Export mode:|$5506818|#1/[ListBox]Single file|#1/[ListBoxItem]Single file page-by-page|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(SingleFilePagebypageLBI);

            DifferentFilesLBI = new ListBoxItem()
            {
                Tag = "[Pane]$5637166|#1/[Pane]$3802508|#4/[PopupList]Export mode:|$5506818|#1/[ListBox]Single file|#1/[ListBoxItem]Different files|#3",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(DifferentFilesLBI);

            Pane6PANE = new Pane()
            {
                Tag = "[Pane]$5637166|#1/[Pane]$3606082|#5",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Pane6PANE);

            PageRangeST = new StaticText()
            {
                Tag = "[Pane]$5637166|#1/[Pane]$3606082|#5/[StaticText]Page range:|$2426648|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(PageRangeST);

            PageRangePL = new PopupList()
            {
                Tag = "[Pane]$5637166|#1/[Pane]$3606082|#5/[PopupList]Page range:|$3146346|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(PageRangePL);

            StaticText2ST = new StaticText()
            {
                Tag = "[Pane]$5637166|#1/[Pane]$3606082|#5/[PopupList]Page range:|$3146346|#1/[StaticText]#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(StaticText2ST);

            ListBoxLB = new ListBox()
            {
                Tag = "[Pane]$5637166|#1/[Pane]$3606082|#5/[PopupList]Page range:|$3146346|#1/[ListBox]#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ListBoxLB);

            Pane7PANE = new Pane()
            {
                Tag = "[Pane]$5637166|#1/[Pane]$4130116|#6",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Pane7PANE);

            Pane8PANE = new Pane()
            {
                Tag = "[Pane]$5637166|#1/[Pane]$4653810|#7",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Pane8PANE);

            PageBorderColorST = new StaticText()
            {
                Tag = "[Pane]$5637166|#1/[Pane]$4653810|#7/[StaticText]Page border color:|$4785314|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(PageBorderColorST);

            PageBorderColorTF = new TextField()
            {
                Tag = "[Pane]$5637166|#1/[Pane]$4653810|#7/[TextField]Page border color:|$4916206|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(PageBorderColorTF);

            BlackST = new StaticText()
            {
                Tag = "[Pane]$5637166|#1/[Pane]$4653810|#7/[TextField]Page border color:|$4916206|#1/[StaticText]Black|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(BlackST);

            BlackPB = new PushButton()
            {
                Tag = "[Pane]$5637166|#1/[Pane]$4653810|#7/[TextField]Page border color:|$4916206|#1/[PushButton]Black|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(BlackPB);

            Pane9PANE = new Pane()
            {
                Tag = "[Pane]$5637166|#1/[Pane]$2819292|#8",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Pane9PANE);

            PageBorderWidthST = new StaticText()
            {
                Tag = "[Pane]$5637166|#1/[Pane]$2819292|#8/[StaticText]Page border width:|$4326222|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(PageBorderWidthST);

            PageBorderWidthTF = new TextField()
            {
                Tag = "[Pane]$5637166|#1/[Pane]$2819292|#8/[TextField]Page border width:|$5047088|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(PageBorderWidthTF);

            oneST = new StaticText()
            {
                Tag = "[Pane]$5637166|#1/[Pane]$2819292|#8/[TextField]Page border width:|$5047088|#1/[StaticText]1|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(oneST);

            Spinner2WIN = new CustomWin()
            {
                Tag = "[Pane]$5637166|#1/[Pane]$2819292|#8/[TextField]Page border width:|$5047088|#1/[CustomWin]Spinner|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Spinner2WIN);

            Up2PB = new PushButton()
            {
                Tag = "[Pane]$5637166|#1/[Pane]$2819292|#8/[TextField]Page border width:|$5047088|#1/[CustomWin]Spinner|#1/[PushButton]Up|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Up2PB);

            Down2PB = new PushButton()
            {
                Tag = "[Pane]$5637166|#1/[Pane]$2819292|#8/[TextField]Page border width:|$5047088|#1/[CustomWin]Spinner|#1/[PushButton]Down|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Down2PB);

            Pane10PANE = new Pane()
            {
                Tag = "[Pane]$5637166|#1/[Pane]$5833394|#9",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Pane10PANE);

            StaticText3ST = new StaticText()
            {
                Tag = "[Pane]$5637166|#1/[Pane]$5833394|#9/[StaticText]$3474718|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(StaticText3ST);

            ImageExportOptionsCTL = new TitleBar()
            {
                Tag = "[TitleBar]Image Export Options|$TitleBar|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ImageExportOptionsCTL);

            ClosePB = new PushButton()
            {
                Tag = "[TitleBar]Image Export Options|$TitleBar|#1/[PushButton]Close|$Close|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ClosePB);
        }
    }
}
