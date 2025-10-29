// This file is auto-generated - do not hand edit this file.

using Autodesk.GUIHarness;
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{

    [UIElement(Tag = "[Pane]XLS Export Options|$LinesForm|#1", GUIType = GuiType.UIA)]
    public partial class XLSExportOptionsDLG : Pane
    {
        public  Pane PnlButtonsPANE;
        public  PushButton CancelPB;
        public  PushButton OKPB;
        public  Pane Pane1PANE;
        public  Pane Pane2PANE;
        public  StaticText ExportModeST;
        public  PopupList ExportModePL;
        public  StaticText SingleFileST;
        public  PushButton Open1PB;
        public  ListBox SingleFileLB;
        public  ListBoxItem SingleFileLBI;
        public  ListBoxItem DifferentFilesLBI;
        public  Pane Pane3PANE;
        public  StaticText PageRangeST;
        public  PopupList PageRangePL;
        public  StaticText StaticText1ST;
        public  ListBox ListBoxLB;
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
        public  ListBox ValueLB;
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
        public  TitleBar XLSExportOptionsCTL;
        public  PushButton ClosePB;

        partial void OnInitialize();

        public XLSExportOptionsDLG()
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
                Tag = "[Pane]$4457404|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Pane1PANE);

            Pane2PANE = new Pane()
            {
                Tag = "[Pane]$4457404|#1/[Pane]$4391666|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Pane2PANE);

            ExportModeST = new StaticText()
            {
                Tag = "[Pane]$4457404|#1/[Pane]$4391666|#1/[StaticText]Export mode:|$2884202|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ExportModeST);

            ExportModePL = new PopupList()
            {
                Tag = "[Pane]$4457404|#1/[Pane]$4391666|#1/[PopupList]Export mode:|$3343938|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ExportModePL);

            SingleFileST = new StaticText()
            {
                Tag = "[Pane]$4457404|#1/[Pane]$4391666|#1/[PopupList]Export mode:|$3343938|#1/[StaticText]Single file|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(SingleFileST);

            Open1PB = new PushButton()
            {
                Tag = "[Pane]$4457404|#1/[Pane]$4391666|#1/[PopupList]Export mode:|$3343938|#1/[PushButton]Open|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Open1PB);

            SingleFileLB = new ListBox()
            {
                Tag = "[Pane]$4457404|#1/[Pane]$4391666|#1/[PopupList]Export mode:|$3343938|#1/[ListBox]Single file|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(SingleFileLB);

            SingleFileLBI = new ListBoxItem()
            {
                Tag = "[Pane]$4457404|#1/[Pane]$4391666|#1/[PopupList]Export mode:|$3343938|#1/[ListBox]Single file|#1/[ListBoxItem]Single file|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(SingleFileLBI);

            DifferentFilesLBI = new ListBoxItem()
            {
                Tag = "[Pane]$4457404|#1/[Pane]$4391666|#1/[PopupList]Export mode:|$3343938|#1/[ListBox]Single file|#1/[ListBoxItem]Different files|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(DifferentFilesLBI);

            Pane3PANE = new Pane()
            {
                Tag = "[Pane]$4457404|#1/[Pane]$2557148|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Pane3PANE);

            PageRangeST = new StaticText()
            {
                Tag = "[Pane]$4457404|#1/[Pane]$2557148|#2/[StaticText]Page range:|$4654062|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(PageRangeST);

            PageRangePL = new PopupList()
            {
                Tag = "[Pane]$4457404|#1/[Pane]$2557148|#2/[PopupList]Page range:|$3867972|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(PageRangePL);

            StaticText1ST = new StaticText()
            {
                Tag = "[Pane]$4457404|#1/[Pane]$2557148|#2/[PopupList]Page range:|$3867972|#1/[StaticText]#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(StaticText1ST);

            ListBoxLB = new ListBox()
            {
                Tag = "[Pane]$4457404|#1/[Pane]$2557148|#2/[PopupList]Page range:|$3867972|#1/[ListBox]#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ListBoxLB);

            Pane4PANE = new Pane()
            {
                Tag = "[Pane]$4457404|#1/[Pane]$4784944|#3",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Pane4PANE);

            StaticText2ST = new StaticText()
            {
                Tag = "[Pane]$4457404|#1/[Pane]$4784944|#3/[StaticText]$5571250|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(StaticText2ST);

            Pane5PANE = new Pane()
            {
                Tag = "[Pane]$4457404|#1/[Pane]$2228988|#4",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Pane5PANE);

            SheetNameST = new StaticText()
            {
                Tag = "[Pane]$4457404|#1/[Pane]$2228988|#4/[StaticText]Sheet name:|$3212574|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(SheetNameST);

            SheetNameCB = new ComboBox()
            {
                Tag = "[Pane]$4457404|#1/[Pane]$2228988|#4/[ComboBox]Sheet name:|$4194830|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(SheetNameCB);

            Pane6PANE = new Pane()
            {
                Tag = "[Pane]$4457404|#1/[Pane]$2885160|#5",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Pane6PANE);

            TextExportModeST = new StaticText()
            {
                Tag = "[Pane]$4457404|#1/[Pane]$2885160|#5/[StaticText]Text export mode:|$2164254|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(TextExportModeST);

            TextExportModePL = new PopupList()
            {
                Tag = "[Pane]$4457404|#1/[Pane]$2885160|#5/[PopupList]Text export mode:|$5440558|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(TextExportModePL);

            ValueST = new StaticText()
            {
                Tag = "[Pane]$4457404|#1/[Pane]$2885160|#5/[PopupList]Text export mode:|$5440558|#1/[StaticText]Value|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ValueST);

            Open2PB = new PushButton()
            {
                Tag = "[Pane]$4457404|#1/[Pane]$2885160|#5/[PopupList]Text export mode:|$5440558|#1/[PushButton]Open|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Open2PB);

            ValueLB = new ListBox()
            {
                Tag = "[Pane]$4457404|#1/[Pane]$2885160|#5/[PopupList]Text export mode:|$5440558|#1/[ListBox]Value|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ValueLB);

            ValueLBI = new ListBoxItem()
            {
                Tag = "[Pane]$4457404|#1/[Pane]$2885160|#5/[PopupList]Text export mode:|$5440558|#1/[ListBox]Value|#1/[ListBoxItem]Value|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ValueLBI);

            TextLBI = new ListBoxItem()
            {
                Tag = "[Pane]$4457404|#1/[Pane]$2885160|#5/[PopupList]Text export mode:|$5440558|#1/[ListBox]Value|#1/[ListBoxItem]Text|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(TextLBI);

            Pane7PANE = new Pane()
            {
                Tag = "[Pane]$4457404|#1/[Pane]$4850458|#6",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Pane7PANE);

            ShowGridLinesCK = new CheckBox()
            {
                Tag = "[Pane]$4457404|#1/[Pane]$4850458|#6/[CheckBox]Show grid lines|$3933536|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ShowGridLinesCK);

            Pane8PANE = new Pane()
            {
                Tag = "[Pane]$4457404|#1/[Pane]$4129614|#7",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Pane8PANE);

            ExportHyperlinksCK = new CheckBox()
            {
                Tag = "[Pane]$4457404|#1/[Pane]$4129614|#7/[CheckBox]Export hyperlinks|$2753872|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ExportHyperlinksCK);

            Pane9PANE = new Pane()
            {
                Tag = "[Pane]$4457404|#1/[Pane]$5571116|#8",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Pane9PANE);

            RawDataModeCK = new CheckBox()
            {
                Tag = "[Pane]$4457404|#1/[Pane]$5571116|#8/[CheckBox]Raw data mode|$5505946|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(RawDataModeCK);

            Pane10PANE = new Pane()
            {
                Tag = "[Pane]$4457404|#1/[Pane]$2230040|#9",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Pane10PANE);

            StaticText3ST = new StaticText()
            {
                Tag = "[Pane]$4457404|#1/[Pane]$2230040|#9/[StaticText]$4588706|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(StaticText3ST);

            XLSExportOptionsCTL = new TitleBar()
            {
                Tag = "[TitleBar]XLS Export Options|$TitleBar|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(XLSExportOptionsCTL);

            ClosePB = new PushButton()
            {
                Tag = "[TitleBar]XLS Export Options|$TitleBar|#1/[PushButton]Close|$Close|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ClosePB);
        }
    }
}
