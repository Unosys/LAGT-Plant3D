// This file is auto-generated - do not hand edit this file.

using Autodesk.GUIHarness;
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{

    [UIElement(Tag = "[Pane]XLSX Export Options|$LinesForm", Parent = typeof(PreviewDLG), GUIType = GuiType.UIA)]
    public partial class XLSXExportOptionsDLG : Pane
    {
        public  PushButton CancelPB;
        public  PushButton OKPB;
        public  Pane PnlButtonsPANE;
        public  PushButton BtnCancel;
        public  PushButton BtnOK;
        public  Pane Pane1PANE;
        public  Pane Pane2PANE;
        public  StaticText ExportModeST;
        public  PopupList ExportModePL;
        public  StaticText SingleFileST;
        public  PushButton Open1PB;
        public  ListBox ListBox1LB;
        public  ListBoxItem SingleFileLBI;
        public  ListBoxItem SingleFilePagebypageLBI;
        public  ListBoxItem DifferentFilesLBI;
        public  Pane Pane3PANE;
        public  StaticText PageRangeST;
        public  PopupList PageRangePL;
        public  StaticText StaticText1ST;
        public  ListBox ListBox2LB;
        public  Pane Pane4PANE;
        public  StaticText StaticText2ST;
        public  Pane Pane5PANE;
        public  StaticText SheetNameST;
        public  ComboBox SheetNameCB;
        public  Pane Pane6PANE;
        public  StaticText TextExportModeST;
        public  PopupList TextExportModePL;
        public  StaticText ValueST;
        public  PushButton Open2PB;
        public  ListBox ListBox3LB;
        public  ListBoxItem ValueLBI;
        public  ListBoxItem TextLBI;
        public  Pane Pane7PANE;
        public  CheckBox ShowGridLinesCK;
        public  Pane Pane8PANE;
        public  CheckBox ExportHyperlinksCK;
        public  Pane Pane9PANE;
        public  CheckBox RawDataModeCK;
        public  Pane Pane10PANE;
        public  StaticText StaticText3ST;
        public  TitleBar XLSXExportOptionsCTL;
        public  PushButton ClosePB;

        partial void OnInitialize();

        public XLSXExportOptionsDLG()
        {
            InitializeComponent();
            OnInitialize();
        }

        private void InitializeComponent()
        {

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

            PnlButtonsPANE = new Pane()
            {
                Tag = "[Pane]pnlButtons|$pnlButtons|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(PnlButtonsPANE);

            BtnCancel = new PushButton()
            {
                Tag = "[Pane]pnlButtons|$pnlButtons/[PushButton]Cancel|$btnCancel",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(BtnCancel);

            BtnOK = new PushButton()
            {
                Tag = "[Pane]pnlButtons|$pnlButtons/[PushButton]OK|$btnOK",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(BtnOK);

            Pane1PANE = new Pane()
            {
                Tag = "[Pane]$7999496|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Pane1PANE);

            Pane2PANE = new Pane()
            {
                Tag = "[Pane]$7999496|#1/[Pane]$39193722|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Pane2PANE);

            ExportModeST = new StaticText()
            {
                Tag = "[Pane]$7999496|#1/[Pane]$39193722|#1/[StaticText]Export mode:|$7081622|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ExportModeST);

            ExportModePL = new PopupList()
            {
                Tag = "[Pane]$7999496|#1/[Pane]$39193722|#1/[PopupList]Export mode:|$6623562|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ExportModePL);

            SingleFileST = new StaticText()
            {
                Tag = "[Pane]$7999496|#1/[Pane]$39193722|#1/[PopupList]Export mode:|$6623562|#1/[StaticText]Single file|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(SingleFileST);

            Open1PB = new PushButton()
            {
                Tag = "[Pane]$7999496|#1/[Pane]$39193722|#1/[PopupList]Export mode:|$6623562|#1/[PushButton]Open|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Open1PB);

            ListBox1LB = new ListBox()
            {
                Tag = "[Pane]$7999496|#1/[Pane]$39193722|#1/[PopupList]Export mode:|$6623562|#1/[ListBox]#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ListBox1LB);

            SingleFileLBI = new ListBoxItem()
            {
                Tag = "[Pane]$7999496|#1/[Pane]$39193722|#1/[PopupList]Export mode:|$6623562|#1/[ListBox]#1/[ListBoxItem]Single file|#3",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(SingleFileLBI);

            SingleFilePagebypageLBI = new ListBoxItem()
            {
                Tag = "[Pane]$7999496|#1/[Pane]$39193722|#1/[PopupList]Export mode:|$6623562|#1/[ListBox]#1/[ListBoxItem]Single file page-by-page|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(SingleFilePagebypageLBI);

            DifferentFilesLBI = new ListBoxItem()
            {
                Tag = "[Pane]$7999496|#1/[Pane]$39193722|#1/[PopupList]Export mode:|$6623562|#1/[ListBox]#1/[ListBoxItem]Different files|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(DifferentFilesLBI);

            Pane3PANE = new Pane()
            {
                Tag = "[Pane]$7999496|#1/[Pane]$6884912|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Pane3PANE);

            PageRangeST = new StaticText()
            {
                Tag = "[Pane]$7999496|#1/[Pane]$6884912|#2/[StaticText]Page range:|$7540946|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(PageRangeST);

            PageRangePL = new PopupList()
            {
                Tag = "[Pane]$7999496|#1/[Pane]$6884912|#2/[PopupList]Page range:|$26477584|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(PageRangePL);

            StaticText1ST = new StaticText()
            {
                Tag = "[Pane]$7999496|#1/[Pane]$6884912|#2/[PopupList]Page range:|$26477584|#1/[StaticText]#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(StaticText1ST);

            ListBox2LB = new ListBox()
            {
                Tag = "[Pane]$7999496|#1/[Pane]$6884912|#2/[PopupList]Page range:|$26477584|#1/[ListBox]#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ListBox2LB);

            Pane4PANE = new Pane()
            {
                Tag = "[Pane]$7999496|#1/[Pane]$6426996|#3",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Pane4PANE);

            StaticText2ST = new StaticText()
            {
                Tag = "[Pane]$7999496|#1/[Pane]$6426996|#3/[StaticText]$7212624|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(StaticText2ST);

            Pane5PANE = new Pane()
            {
                Tag = "[Pane]$7999496|#1/[Pane]$20318778|#4",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Pane5PANE);

            SheetNameST = new StaticText()
            {
                Tag = "[Pane]$7999496|#1/[Pane]$20318778|#4/[StaticText]Sheet name:|$24185704|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(SheetNameST);

            SheetNameCB = new ComboBox()
            {
                Tag = "[Pane]$7999496|#1/[Pane]$20318778|#4/[ComboBox]Sheet name:|$30213832|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(SheetNameCB);

            Pane6PANE = new Pane()
            {
                Tag = "[Pane]$7999496|#1/[Pane]$8524276|#5",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Pane6PANE);

            TextExportModeST = new StaticText()
            {
                Tag = "[Pane]$7999496|#1/[Pane]$8524276|#5/[StaticText]Text export mode:|$9441292|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(TextExportModeST);

            TextExportModePL = new PopupList()
            {
                Tag = "[Pane]$7999496|#1/[Pane]$8524276|#5/[PopupList]Text export mode:|$7082340|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(TextExportModePL);

            ValueST = new StaticText()
            {
                Tag = "[Pane]$7999496|#1/[Pane]$8524276|#5/[PopupList]Text export mode:|$7082340|#1/[StaticText]Value|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ValueST);

            Open2PB = new PushButton()
            {
                Tag = "[Pane]$7999496|#1/[Pane]$8524276|#5/[PopupList]Text export mode:|$7082340|#1/[PushButton]Open|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Open2PB);

            ListBox3LB = new ListBox()
            {
                Tag = "[Pane]$7999496|#1/[Pane]$8524276|#5/[PopupList]Text export mode:|$7082340|#1/[ListBox]#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ListBox3LB);

            ValueLBI = new ListBoxItem()
            {
                Tag = "[Pane]$7999496|#1/[Pane]$8524276|#5/[PopupList]Text export mode:|$7082340|#1/[ListBox]#1/[ListBoxItem]Value|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ValueLBI);

            TextLBI = new ListBoxItem()
            {
                Tag = "[Pane]$7999496|#1/[Pane]$8524276|#5/[PopupList]Text export mode:|$7082340|#1/[ListBox]#1/[ListBoxItem]Text|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(TextLBI);

            Pane7PANE = new Pane()
            {
                Tag = "[Pane]$7999496|#1/[Pane]$34277804|#6",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Pane7PANE);

            ShowGridLinesCK = new CheckBox()
            {
                Tag = "[Pane]$7999496|#1/[Pane]$34277804|#6/[CheckBox]Show grid lines|$53677630|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ShowGridLinesCK);

            Pane8PANE = new Pane()
            {
                Tag = "[Pane]$7999496|#1/[Pane]$7802674|#7",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Pane8PANE);

            ExportHyperlinksCK = new CheckBox()
            {
                Tag = "[Pane]$7999496|#1/[Pane]$7802674|#7/[CheckBox]Export hyperlinks|$9440798|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ExportHyperlinksCK);

            Pane9PANE = new Pane()
            {
                Tag = "[Pane]$7999496|#1/[Pane]$6360620|#8",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Pane9PANE);

            RawDataModeCK = new CheckBox()
            {
                Tag = "[Pane]$7999496|#1/[Pane]$6360620|#8/[CheckBox]Raw data mode|$6754494|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(RawDataModeCK);

            Pane10PANE = new Pane()
            {
                Tag = "[Pane]$7999496|#1/[Pane]$10226542|#9",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Pane10PANE);

            StaticText3ST = new StaticText()
            {
                Tag = "[Pane]$7999496|#1/[Pane]$10226542|#9/[StaticText]$37752054|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(StaticText3ST);

            XLSXExportOptionsCTL = new TitleBar()
            {
                Tag = "[TitleBar]XLSX Export Options|$TitleBar|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(XLSXExportOptionsCTL);

            ClosePB = new PushButton()
            {
                Tag = "[TitleBar]XLSX Export Options|$TitleBar|#1/[PushButton]Close|$Close|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ClosePB);
        }
    }
}
