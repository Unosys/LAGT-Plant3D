// This file is auto-generated - do not hand edit this file.

using Autodesk.GUIHarness;
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{

    [UIElement(Tag = "[Pane]HTML Export Options|$LinesForm|#1", GUIType = GuiType.UIA)]
    public partial class HTMLExportOptionsDLG : Pane
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
        public  ListBoxItem SingleFilePagebypageLBI;
        public  ListBoxItem DifferentFilesLBI;
        public  Pane Pane3PANE;
        public  StaticText PageRangeST;
        public  PopupList PageRangePL;
        public  StaticText StaticText1ST;
        public  ListBox ListBoxLB;
        public  Pane Pane4PANE;
        public  Pane Pane5PANE;
        public  StaticText PageBorderColorST;
        public  TextField PageBorderColorTF;
        public  StaticText BlackST;
        public  PushButton BlackPB;
        public  Pane Pane6PANE;
        public  StaticText PageBorderWidthST;
        public  TextField PageBorderWidthTF;
        public  StaticText oneST;
        public  CustomWin SpinnerWIN;
        public  PushButton UpPB;
        public  PushButton DownPB;
        public  Pane Pane7PANE;
        public  Pane Pane8PANE;
        public  StaticText TitleST;
        public  ComboBox TitleCB;
        public  Pane Pane9PANE;
        public  StaticText CharacterSetST;
        public  PopupList CharacterSetPL;
        public  StaticText UnicodeUTF8ST;
        public  PushButton Open2PB;
        public  ListBox UnicodeUTF8LB;
        public  ListBoxItem ArabicWindowsLBI;
        public  ListBoxItem BalticISOLBI;
        public  ListBoxItem BalticWindowsLBI;
        public  ListBoxItem CentralEuropeanISOLBI;
        public  ListBoxItem CentralEuropeanWindowsLBI;
        public  ListBoxItem CyrillicISOLBI;
        public  ListBoxItem CyrillicKOI8RLBI;
        public  ListBoxItem CyrillicWindowsLBI;
        public  ListBoxItem Latin9ISOLBI;
        public  ListBoxItem UnicodeUTF7LBI;
        public  ListBoxItem UnicodeUTF8LBI;
        public  ListBoxItem WesternEuropeanISOLBI;
        public  ListBoxItem WesternEuropeanWindowsLBI;
        public  Pane Pane10PANE;
        public  Pane Pane11PANE;
        public  CheckBox RemoveCarriageReturnsCK;
        public  Pane Pane12PANE;
        public  CheckBox TableLayoutCK;
        public  Pane Pane13PANE;
        public  CheckBox EmbedImagesInHTMLCK;
        public  Pane Pane14PANE;
        public  StaticText StaticText2ST;
        public  TitleBar HTMLExportOptionsCTL;
        public  PushButton ClosePB;

        partial void OnInitialize();

        public HTMLExportOptionsDLG()
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
                Tag = "[Pane]$4064310|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Pane1PANE);

            Pane2PANE = new Pane()
            {
                Tag = "[Pane]$4064310|#1/[Pane]$5046962|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Pane2PANE);

            ExportModeST = new StaticText()
            {
                Tag = "[Pane]$4064310|#1/[Pane]$5046962|#1/[StaticText]Export mode:|$2490986|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ExportModeST);

            ExportModePL = new PopupList()
            {
                Tag = "[Pane]$4064310|#1/[Pane]$5046962|#1/[PopupList]Export mode:|$4326192|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ExportModePL);

            SingleFileST = new StaticText()
            {
                Tag = "[Pane]$4064310|#1/[Pane]$5046962|#1/[PopupList]Export mode:|$4326192|#1/[StaticText]Single file|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(SingleFileST);

            Open1PB = new PushButton()
            {
                Tag = "[Pane]$4064310|#1/[Pane]$5046962|#1/[PopupList]Export mode:|$4326192|#1/[PushButton]Open|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Open1PB);

            SingleFileLB = new ListBox()
            {
                Tag = "[Pane]$4064310|#1/[Pane]$5046962|#1/[PopupList]Export mode:|$4326192|#1/[ListBox]Single file|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(SingleFileLB);

            SingleFileLBI = new ListBoxItem()
            {
                Tag = "[Pane]$4064310|#1/[Pane]$5046962|#1/[PopupList]Export mode:|$4326192|#1/[ListBox]Single file|#1/[ListBoxItem]Single file|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(SingleFileLBI);

            SingleFilePagebypageLBI = new ListBoxItem()
            {
                Tag = "[Pane]$4064310|#1/[Pane]$5046962|#1/[PopupList]Export mode:|$4326192|#1/[ListBox]Single file|#1/[ListBoxItem]Single file page-by-page|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(SingleFilePagebypageLBI);

            DifferentFilesLBI = new ListBoxItem()
            {
                Tag = "[Pane]$4064310|#1/[Pane]$5046962|#1/[PopupList]Export mode:|$4326192|#1/[ListBox]Single file|#1/[ListBoxItem]Different files|#3",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(DifferentFilesLBI);

            Pane3PANE = new Pane()
            {
                Tag = "[Pane]$4064310|#1/[Pane]$2688286|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Pane3PANE);

            PageRangeST = new StaticText()
            {
                Tag = "[Pane]$4064310|#1/[Pane]$2688286|#2/[StaticText]Page range:|$1704700|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(PageRangeST);

            PageRangePL = new PopupList()
            {
                Tag = "[Pane]$4064310|#1/[Pane]$2688286|#2/[PopupList]Page range:|$3343684|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(PageRangePL);

            StaticText1ST = new StaticText()
            {
                Tag = "[Pane]$4064310|#1/[Pane]$2688286|#2/[PopupList]Page range:|$3343684|#1/[StaticText]#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(StaticText1ST);

            ListBoxLB = new ListBox()
            {
                Tag = "[Pane]$4064310|#1/[Pane]$2688286|#2/[PopupList]Page range:|$3343684|#1/[ListBox]#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ListBoxLB);

            Pane4PANE = new Pane()
            {
                Tag = "[Pane]$4064310|#1/[Pane]$3670542|#3",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Pane4PANE);

            Pane5PANE = new Pane()
            {
                Tag = "[Pane]$4064310|#1/[Pane]$4260430|#4",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Pane5PANE);

            PageBorderColorST = new StaticText()
            {
                Tag = "[Pane]$4064310|#1/[Pane]$4260430|#4/[StaticText]Page border color:|$4260344|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(PageBorderColorST);

            PageBorderColorTF = new TextField()
            {
                Tag = "[Pane]$4064310|#1/[Pane]$4260430|#4/[TextField]Page border color:|$2295336|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(PageBorderColorTF);

            BlackST = new StaticText()
            {
                Tag = "[Pane]$4064310|#1/[Pane]$4260430|#4/[TextField]Page border color:|$2295336|#1/[StaticText]Black|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(BlackST);

            BlackPB = new PushButton()
            {
                Tag = "[Pane]$4064310|#1/[Pane]$4260430|#4/[TextField]Page border color:|$2295336|#1/[PushButton]Black|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(BlackPB);

            Pane6PANE = new Pane()
            {
                Tag = "[Pane]$4064310|#1/[Pane]$3868030|#5",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Pane6PANE);

            PageBorderWidthST = new StaticText()
            {
                Tag = "[Pane]$4064310|#1/[Pane]$3868030|#5/[StaticText]Page border width:|$3933116|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(PageBorderWidthST);

            PageBorderWidthTF = new TextField()
            {
                Tag = "[Pane]$4064310|#1/[Pane]$3868030|#5/[TextField]Page border width:|$4064302|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(PageBorderWidthTF);

            oneST = new StaticText()
            {
                Tag = "[Pane]$4064310|#1/[Pane]$3868030|#5/[TextField]Page border width:|$4064302|#1/[StaticText]1|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(oneST);

            SpinnerWIN = new CustomWin()
            {
                Tag = "[Pane]$4064310|#1/[Pane]$3868030|#5/[TextField]Page border width:|$4064302|#1/[CustomWin]Spinner|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(SpinnerWIN);

            UpPB = new PushButton()
            {
                Tag = "[Pane]$4064310|#1/[Pane]$3868030|#5/[TextField]Page border width:|$4064302|#1/[CustomWin]Spinner|#1/[PushButton]Up|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(UpPB);

            DownPB = new PushButton()
            {
                Tag = "[Pane]$4064310|#1/[Pane]$3868030|#5/[TextField]Page border width:|$4064302|#1/[CustomWin]Spinner|#1/[PushButton]Down|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(DownPB);

            Pane7PANE = new Pane()
            {
                Tag = "[Pane]$4064310|#1/[Pane]$3998882|#6",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Pane7PANE);

            Pane8PANE = new Pane()
            {
                Tag = "[Pane]$4064310|#1/[Pane]$3539790|#7",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Pane8PANE);

            TitleST = new StaticText()
            {
                Tag = "[Pane]$4064310|#1/[Pane]$3539790|#7/[StaticText]Title:|$5440738|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(TitleST);

            TitleCB = new ComboBox()
            {
                Tag = "[Pane]$4064310|#1/[Pane]$3539790|#7/[ComboBox]Title:|$1640216|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(TitleCB);

            Pane9PANE = new Pane()
            {
                Tag = "[Pane]$4064310|#1/[Pane]$3867378|#8",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Pane9PANE);

            CharacterSetST = new StaticText()
            {
                Tag = "[Pane]$4064310|#1/[Pane]$3867378|#8/[StaticText]Character set:|$2950540|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(CharacterSetST);

            CharacterSetPL = new PopupList()
            {
                Tag = "[Pane]$4064310|#1/[Pane]$3867378|#8/[PopupList]Character set:|$4981292|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(CharacterSetPL);

            UnicodeUTF8ST = new StaticText()
            {
                Tag = "[Pane]$4064310|#1/[Pane]$3867378|#8/[PopupList]Character set:|$4981292|#1/[StaticText]Unicode (UTF-8)|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(UnicodeUTF8ST);

            Open2PB = new PushButton()
            {
                Tag = "[Pane]$4064310|#1/[Pane]$3867378|#8/[PopupList]Character set:|$4981292|#1/[PushButton]Open|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Open2PB);

            UnicodeUTF8LB = new ListBox()
            {
                Tag = "[Pane]$4064310|#1/[Pane]$3867378|#8/[PopupList]Character set:|$4981292|#1/[ListBox]Unicode (UTF-8)|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(UnicodeUTF8LB);

            ArabicWindowsLBI = new ListBoxItem()
            {
                Tag = "[Pane]$4064310|#1/[Pane]$3867378|#8/[PopupList]Character set:|$4981292|#1/[ListBox]Unicode (UTF-8)|#1/[ListBoxItem]Arabic (Windows)|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ArabicWindowsLBI);

            BalticISOLBI = new ListBoxItem()
            {
                Tag = "[Pane]$4064310|#1/[Pane]$3867378|#8/[PopupList]Character set:|$4981292|#1/[ListBox]Unicode (UTF-8)|#1/[ListBoxItem]Baltic (ISO)|#9",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(BalticISOLBI);

            BalticWindowsLBI = new ListBoxItem()
            {
                Tag = "[Pane]$4064310|#1/[Pane]$3867378|#8/[PopupList]Character set:|$4981292|#1/[ListBox]Unicode (UTF-8)|#1/[ListBoxItem]Baltic (Windows)|#10",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(BalticWindowsLBI);

            CentralEuropeanISOLBI = new ListBoxItem()
            {
                Tag = "[Pane]$4064310|#1/[Pane]$3867378|#8/[PopupList]Character set:|$4981292|#1/[ListBox]Unicode (UTF-8)|#1/[ListBoxItem]Central European (ISO)|#11",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(CentralEuropeanISOLBI);

            CentralEuropeanWindowsLBI = new ListBoxItem()
            {
                Tag = "[Pane]$4064310|#1/[Pane]$3867378|#8/[PopupList]Character set:|$4981292|#1/[ListBox]Unicode (UTF-8)|#1/[ListBoxItem]Central European (Windows)|#12",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(CentralEuropeanWindowsLBI);

            CyrillicISOLBI = new ListBoxItem()
            {
                Tag = "[Pane]$4064310|#1/[Pane]$3867378|#8/[PopupList]Character set:|$4981292|#1/[ListBox]Unicode (UTF-8)|#1/[ListBoxItem]Cyrillic (ISO)|#8",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(CyrillicISOLBI);

            CyrillicKOI8RLBI = new ListBoxItem()
            {
                Tag = "[Pane]$4064310|#1/[Pane]$3867378|#8/[PopupList]Character set:|$4981292|#1/[ListBox]Unicode (UTF-8)|#1/[ListBoxItem]Cyrillic (KOI8-R)|#7",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(CyrillicKOI8RLBI);

            CyrillicWindowsLBI = new ListBoxItem()
            {
                Tag = "[Pane]$4064310|#1/[Pane]$3867378|#8/[PopupList]Character set:|$4981292|#1/[ListBox]Unicode (UTF-8)|#1/[ListBoxItem]Cyrillic (Windows)|#6",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(CyrillicWindowsLBI);

            Latin9ISOLBI = new ListBoxItem()
            {
                Tag = "[Pane]$4064310|#1/[Pane]$3867378|#8/[PopupList]Character set:|$4981292|#1/[ListBox]Unicode (UTF-8)|#1/[ListBoxItem]Latin 9 (ISO)|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Latin9ISOLBI);

            UnicodeUTF7LBI = new ListBoxItem()
            {
                Tag = "[Pane]$4064310|#1/[Pane]$3867378|#8/[PopupList]Character set:|$4981292|#1/[ListBox]Unicode (UTF-8)|#1/[ListBoxItem]Unicode (UTF-7)|#3",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(UnicodeUTF7LBI);

            UnicodeUTF8LBI = new ListBoxItem()
            {
                Tag = "[Pane]$4064310|#1/[Pane]$3867378|#8/[PopupList]Character set:|$4981292|#1/[ListBox]Unicode (UTF-8)|#1/[ListBoxItem]Unicode (UTF-8)|#4",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(UnicodeUTF8LBI);

            WesternEuropeanISOLBI = new ListBoxItem()
            {
                Tag = "[Pane]$4064310|#1/[Pane]$3867378|#8/[PopupList]Character set:|$4981292|#1/[ListBox]Unicode (UTF-8)|#1/[ListBoxItem]Western European (ISO)|#5",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(WesternEuropeanISOLBI);

            WesternEuropeanWindowsLBI = new ListBoxItem()
            {
                Tag = "[Pane]$4064310|#1/[Pane]$3867378|#8/[PopupList]Character set:|$4981292|#1/[ListBox]Unicode (UTF-8)|#1/[ListBoxItem]Western European (Windows)|#13",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(WesternEuropeanWindowsLBI);

            Pane10PANE = new Pane()
            {
                Tag = "[Pane]$4064310|#1/[Pane]$4260634|#9",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Pane10PANE);

            Pane11PANE = new Pane()
            {
                Tag = "[Pane]$4064310|#1/[Pane]$3409188|#10",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Pane11PANE);

            RemoveCarriageReturnsCK = new CheckBox()
            {
                Tag = "[Pane]$4064310|#1/[Pane]$3409188|#10/[CheckBox]Remove carriage returns|$6096024|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(RemoveCarriageReturnsCK);

            Pane12PANE = new Pane()
            {
                Tag = "[Pane]$4064310|#1/[Pane]$2950496|#11",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Pane12PANE);

            TableLayoutCK = new CheckBox()
            {
                Tag = "[Pane]$4064310|#1/[Pane]$2950496|#11/[CheckBox]Table layout|$1771296|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(TableLayoutCK);

            Pane13PANE = new Pane()
            {
                Tag = "[Pane]$4064310|#1/[Pane]$1705180|#12",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Pane13PANE);

            EmbedImagesInHTMLCK = new CheckBox()
            {
                Tag = "[Pane]$4064310|#1/[Pane]$1705180|#12/[CheckBox]Embed images in HTML|$5375366|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(EmbedImagesInHTMLCK);

            Pane14PANE = new Pane()
            {
                Tag = "[Pane]$4064310|#1/[Pane]$4720386|#13",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Pane14PANE);

            StaticText2ST = new StaticText()
            {
                Tag = "[Pane]$4064310|#1/[Pane]$4720386|#13/[StaticText]$1639966|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(StaticText2ST);

            HTMLExportOptionsCTL = new TitleBar()
            {
                Tag = "[TitleBar]HTML Export Options|$TitleBar|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(HTMLExportOptionsCTL);

            ClosePB = new PushButton()
            {
                Tag = "[TitleBar]HTML Export Options|$TitleBar|#1/[PushButton]Close|$Close|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ClosePB);
        }
    }
}
