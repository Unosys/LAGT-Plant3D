// This file is auto-generated - do not hand edit this file.

using Autodesk.GUIHarness;
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{

    [UIElement(Tag = "[Pane]Text Export Options|$LinesForm|#1", GUIType = GuiType.UIA)]
    public partial class TextExportOptionsDLG : Pane
    {
        public  Pane PnlButtonsPANE;
        public  PushButton CancelPB;
        public  PushButton OKPB;
        public  Pane Pane1PANE;
        public  Pane Pane2PANE;
        public  StaticText EncodingST;
        public  PopupList EncodingPL;
        public  StaticText Windows1252ST;
        public  PushButton Open1PB;
        public  ListBox Windows1252LB;
        public  ListBoxItem Windows1252LBI;
        public  ListBoxItem UsasciiLBI;
        public  ListBoxItem Utf16LBI;
        public  ListBoxItem Utf16BELBI;
        public  ListBoxItem Utf7LBI;
        public  ListBoxItem Utf8LBI;
        public  ListBoxItem Utf32LBI;
        public  Pane Pane3PANE;
        public  StaticText TextExportModeST;
        public  PopupList TextExportModePL;
        public  StaticText TextST;
        public  PushButton Open2PB;
        public  ListBox TextLB;
        public  ListBoxItem ValueLBI;
        public  ListBoxItem TextLBI;
        public  Pane Pane4PANE;
        public  StaticText TextSeparatorST;
        public  ComboBox TextSeparatorCB;
        public  Pane Pane5PANE;
        public  CheckBox QuoteStringsWithSeparatorsCK;
        public  Pane Pane6PANE;
        public  StaticText StaticTextST;
        public  TitleBar TextExportOptionsCTL;
        public  PushButton ClosePB;

        partial void OnInitialize();

        public TextExportOptionsDLG()
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
                Tag = "[Pane]$3867470|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Pane1PANE);

            Pane2PANE = new Pane()
            {
                Tag = "[Pane]$3867470|#1/[Pane]$4326562|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Pane2PANE);

            EncodingST = new StaticText()
            {
                Tag = "[Pane]$3867470|#1/[Pane]$4326562|#1/[StaticText]Encoding:|$5703046|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(EncodingST);

            EncodingPL = new PopupList()
            {
                Tag = "[Pane]$3867470|#1/[Pane]$4326562|#1/[PopupList]Encoding:|$4391990|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(EncodingPL);

            Windows1252ST = new StaticText()
            {
                Tag = "[Pane]$3867470|#1/[Pane]$4326562|#1/[PopupList]Encoding:|$4391990|#1/[StaticText]Windows-1252|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Windows1252ST);

            Open1PB = new PushButton()
            {
                Tag = "[Pane]$3867470|#1/[Pane]$4326562|#1/[PopupList]Encoding:|$4391990|#1/[PushButton]Open|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Open1PB);

            Windows1252LB = new ListBox()
            {
                Tag = "[Pane]$3867470|#1/[Pane]$4326562|#1/[PopupList]Encoding:|$4391990|#1/[ListBox]Windows-1252|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Windows1252LB);

            Windows1252LBI = new ListBoxItem()
            {
                Tag = "[Pane]$3867470|#1/[Pane]$4326562|#1/[PopupList]Encoding:|$4391990|#1/[ListBox]Windows-1252|#1/[ListBoxItem]Windows-1252|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Windows1252LBI);

            UsasciiLBI = new ListBoxItem()
            {
                Tag = "[Pane]$3867470|#1/[Pane]$4326562|#1/[PopupList]Encoding:|$4391990|#1/[ListBox]Windows-1252|#1/[ListBoxItem]us-ascii|#6",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(UsasciiLBI);

            Utf16LBI = new ListBoxItem()
            {
                Tag = "[Pane]$3867470|#1/[Pane]$4326562|#1/[PopupList]Encoding:|$4391990|#1/[ListBox]Windows-1252|#1/[ListBoxItem]utf-16|#5",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Utf16LBI);

            Utf16BELBI = new ListBoxItem()
            {
                Tag = "[Pane]$3867470|#1/[Pane]$4326562|#1/[PopupList]Encoding:|$4391990|#1/[ListBox]Windows-1252|#1/[ListBoxItem]utf-16BE|#4",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Utf16BELBI);

            Utf7LBI = new ListBoxItem()
            {
                Tag = "[Pane]$3867470|#1/[Pane]$4326562|#1/[PopupList]Encoding:|$4391990|#1/[ListBox]Windows-1252|#1/[ListBoxItem]utf-7|#3",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Utf7LBI);

            Utf8LBI = new ListBoxItem()
            {
                Tag = "[Pane]$3867470|#1/[Pane]$4326562|#1/[PopupList]Encoding:|$4391990|#1/[ListBox]Windows-1252|#1/[ListBoxItem]utf-8|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Utf8LBI);

            Utf32LBI = new ListBoxItem()
            {
                Tag = "[Pane]$3867470|#1/[Pane]$4326562|#1/[PopupList]Encoding:|$4391990|#1/[ListBox]Windows-1252|#1/[ListBoxItem]utf-32|#7",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Utf32LBI);

            Pane3PANE = new Pane()
            {
                Tag = "[Pane]$3867470|#1/[Pane]$3278220|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Pane3PANE);

            TextExportModeST = new StaticText()
            {
                Tag = "[Pane]$3867470|#1/[Pane]$3278220|#2/[StaticText]Text export mode:|$2032860|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(TextExportModeST);

            TextExportModePL = new PopupList()
            {
                Tag = "[Pane]$3867470|#1/[Pane]$3278220|#2/[PopupList]Text export mode:|$2885186|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(TextExportModePL);

            TextST = new StaticText()
            {
                Tag = "[Pane]$3867470|#1/[Pane]$3278220|#2/[PopupList]Text export mode:|$2885186|#1/[StaticText]Text|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(TextST);

            Open2PB = new PushButton()
            {
                Tag = "[Pane]$3867470|#1/[Pane]$3278220|#2/[PopupList]Text export mode:|$2885186|#1/[PushButton]Open|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Open2PB);

            TextLB = new ListBox()
            {
                Tag = "[Pane]$3867470|#1/[Pane]$3278220|#2/[PopupList]Text export mode:|$2885186|#1/[ListBox]Text|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(TextLB);

            ValueLBI = new ListBoxItem()
            {
                Tag = "[Pane]$3867470|#1/[Pane]$3278220|#2/[PopupList]Text export mode:|$2885186|#1/[ListBox]Text|#1/[ListBoxItem]Value|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ValueLBI);

            TextLBI = new ListBoxItem()
            {
                Tag = "[Pane]$3867470|#1/[Pane]$3278220|#2/[PopupList]Text export mode:|$2885186|#1/[ListBox]Text|#1/[ListBoxItem]Text|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(TextLBI);

            Pane4PANE = new Pane()
            {
                Tag = "[Pane]$3867470|#1/[Pane]$5048066|#3",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Pane4PANE);

            TextSeparatorST = new StaticText()
            {
                Tag = "[Pane]$3867470|#1/[Pane]$5048066|#3/[StaticText]Text separator:|$4195058|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(TextSeparatorST);

            TextSeparatorCB = new ComboBox()
            {
                Tag = "[Pane]$3867470|#1/[Pane]$5048066|#3/[ComboBox]Text separator:|$4260796|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(TextSeparatorCB);

            Pane5PANE = new Pane()
            {
                Tag = "[Pane]$3867470|#1/[Pane]$4588110|#4",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Pane5PANE);

            QuoteStringsWithSeparatorsCK = new CheckBox()
            {
                Tag = "[Pane]$3867470|#1/[Pane]$4588110|#4/[CheckBox]Quote strings with separators|$4195710|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(QuoteStringsWithSeparatorsCK);

            Pane6PANE = new Pane()
            {
                Tag = "[Pane]$3867470|#1/[Pane]$1967646|#5",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Pane6PANE);

            StaticTextST = new StaticText()
            {
                Tag = "[Pane]$3867470|#1/[Pane]$1967646|#5/[StaticText]$4588024|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(StaticTextST);

            TextExportOptionsCTL = new TitleBar()
            {
                Tag = "[TitleBar]Text Export Options|$TitleBar|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(TextExportOptionsCTL);

            ClosePB = new PushButton()
            {
                Tag = "[TitleBar]Text Export Options|$TitleBar|#1/[PushButton]Close|$Close|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ClosePB);
        }
    }
}
