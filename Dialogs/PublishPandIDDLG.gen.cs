// This file is auto-generated - do not hand edit this file.

using Autodesk.GUIHarness;
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{

    [UIElement(Tag = "[DialogBox]Publish|#1", Parent = typeof(MainWin), GUIType = GuiType.WIN32)]
    public partial class PublishPandIDDLG : Autodesk.GUIHarness.AutoCAD.AcDialogBox
    {
        public  StaticText SheetListText;
        public  PopupList SheetList;
        public  PushButton LoadSheetList;
        public  PushButton SaveSheetList;
        public  StaticText PublishToText;
        public  PopupList PublishTo1;
        public  CheckBox AutomaticallyLoadAllOpenDr;
        public  PushButton AddSheets;
        public  PushButton RemoveSheets;
        public  PushButton MoveSheetUp;
        public  PushButton MoveSheetDown;
        public  PushButton Preview;
        public  PushButton PublishOptions;
        public  ListView PublishOptionsInformation;
        public  Header Header111;
        public  PushButton SheetName;
        public  PushButton N3DDWF;
        public  PushButton PageSetup;
        public  PushButton Status;
        public  CheckBox CheckBox1;
        public  CheckBox CheckBox2;
        public  ListView PublishTo2;
        public  Header Header1;
        public  PushButton PushButton1;
        public  PushButton PushButton2;
        public  CustomWin PublishTo3;
        public  StaticText NumberOfCopiesText;
        public  TextField NumberOfCopies1;
        public  UpDown NumberOfCopies2;
        public  StaticText PrecisionText;
        public  PopupList Precision;
        public  CheckBox IncludePlotStamp;
        public  CheckBox PublishInBackground;
        public  CheckBox OpenInViewerWhenDone;
        public  PushButton PlotStampSettings;
        public  PushButton CurrentlyPublishingInDefaul;
        public  PushButton Static;
        public  PushButton Publish;
        public  PushButton Cancel;
        public  PushButton Help;
        public  StaticText PublishOutputText;
        public  StaticText PublishOptionsInformationTex;
        public  StaticText LocationText;
        public  StaticText FileTypeText;
        public  StaticText NamingText;
        public  StaticText LayerInformationText;
        public  StaticText MergeControlText;
        public  StaticText CDocumentsAndSettingsNsar;
        public  StaticText SingleSheetFileText;
        public  StaticText NAText;
        public  StaticText DonTIncludeText;
        public  StaticText LinesOverwriteText;

        partial void OnInitialize();

        public PublishPandIDDLG()
        {
            InitializeComponent();
            OnInitialize();
        }

        private void InitializeComponent()
        {

            SheetListText = new StaticText()
            {
                Tag = "[StaticText]Sheet List:|#1|$6032",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(SheetListText);

            SheetList = new PopupList()
            {
                Tag = "[PopupList]Sheet List:|#1|$6039",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(SheetList);

            LoadSheetList = new PushButton()
            {
                Tag = "[PushButton]Load Sheet List|#1|$4557",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(LoadSheetList);

            SaveSheetList = new PushButton()
            {
                Tag = "[PushButton]Save Sheet List|#2|$4558",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(SaveSheetList);

            PublishToText = new StaticText()
            {
                Tag = "[StaticText]Publish to:|#5|$6033",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(PublishToText);

            PublishTo1 = new PopupList()
            {
                Tag = "[PopupList]Publish to:|#2|$6040",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(PublishTo1);

            AutomaticallyLoadAllOpenDr = new CheckBox()
            {
                Tag = "[CheckBox]Automatically load all open drawings|#1|$5159",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(AutomaticallyLoadAllOpenDr);

            AddSheets = new PushButton()
            {
                Tag = "[PushButton]Add Sheets|#4|$4553",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(AddSheets);

            RemoveSheets = new PushButton()
            {
                Tag = "[PushButton]Remove Sheets|#5|$4554",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(RemoveSheets);

            MoveSheetUp = new PushButton()
            {
                Tag = "[PushButton]Move Sheet Up|#6|$4555",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(MoveSheetUp);

            MoveSheetDown = new PushButton()
            {
                Tag = "[PushButton]Move Sheet Down|#7|$4556",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(MoveSheetDown);

            Preview = new PushButton()
            {
                Tag = "[PushButton]Preview|#8|$4552",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Preview);

            PublishOptions = new PushButton()
            {
                Tag = "[PushButton]Publish Options*|$4568|#3",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(PublishOptions);

            PublishOptionsInformation = new ListView()
            {
                Tag = "[ListView]Publish Options Information|#1|$4551",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(PublishOptionsInformation);

            Header111 = new Header()
            {
                Tag = "[Header]#1|$0",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Header111);

            SheetName = new PushButton()
            {
                Tag = "[PushButton]Sheet Name|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(SheetName);

            N3DDWF = new PushButton()
            {
                Tag = "[PushButton]3D DWF|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(N3DDWF);

            PageSetup = new PushButton()
            {
                Tag = "[PushButton]Page Setup|#3",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(PageSetup);

            Status = new PushButton()
            {
                Tag = "[PushButton]Status|#4",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Status);

            CheckBox1 = new CheckBox()
            {
                Tag = "[CheckBox]#1|$-5",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(CheckBox1);

            CheckBox2 = new CheckBox()
            {
                Tag = "[CheckBox]#2|$-6",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(CheckBox2);

            PublishTo2 = new ListView()
            {
                Tag = "[ListView]Publish to:|#2|$5167",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(PublishTo2);

            Header1 = new Header()
            {
                Tag = "[Header]#1|$0",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Header1);

            PushButton1 = new PushButton()
            {
                Tag = "#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(PushButton1);

            PushButton2 = new PushButton()
            {
                Tag = "#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(PushButton2);

            PublishTo3 = new CustomWin()
            {
                Tag = "[CustomWin][GrayFrame]Publish to:|[GrayFrame]#1|[GrayFrame]$4209",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(PublishTo3);

            NumberOfCopiesText = new StaticText()
            {
                Tag = "[StaticText]Number of copies:|#15|$4559",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(NumberOfCopiesText);

            NumberOfCopies1 = new TextField()
            {
                Tag = "[TextField]Number of copies:|#1|$4560",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(NumberOfCopies1);

            NumberOfCopies2 = new UpDown()
            {
                Tag = "[UpDown]Number of copies:|#1|$4561",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(NumberOfCopies2);

            PrecisionText = new StaticText()
            {
                Tag = "[StaticText]Precision:|#16|$4203",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(PrecisionText);

            Precision = new PopupList()
            {
                Tag = "[PopupList]Precision:|#3|$5158",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Precision);

            IncludePlotStamp = new CheckBox()
            {
                Tag = "[CheckBox]Include plot stamp|#2|$4579",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(IncludePlotStamp);

            PublishInBackground = new CheckBox()
            {
                Tag = "[CheckBox]Publish in background|#3|$13347",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(PublishInBackground);

            OpenInViewerWhenDone = new CheckBox()
            {
                Tag = "[CheckBox]Open in viewer when done|#4|$5160",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(OpenInViewerWhenDone);

            PlotStampSettings = new PushButton()
            {
                Tag = "[PushButton]Plot Stamp Settings|#9|$4582",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(PlotStampSettings);

            CurrentlyPublishingInDefaul = new PushButton()
            {
                Tag = "[PushButton]Currently publishing in default order.?Click to publish in reverse order.|#10|$4644",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(CurrentlyPublishingInDefaul);

            Static = new PushButton()
            {
                Tag = "[PushButton]Static|#11|$4569",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Static);

            Publish = new PushButton()
            {
                Tag = "[PushButton]Publish|#12|$4570",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Publish);

            Cancel = new PushButton()
            {
                Tag = "[PushButton]Cancel|#13|$2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Cancel);

            Help = new PushButton()
            {
                Tag = "[PushButton]Help|#14|$9",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Help);

            PublishOutputText = new StaticText()
            {
                Tag = "[StaticText]Publish Output|#14|$4550",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(PublishOutputText);

            PublishOptionsInformationTex = new StaticText()
            {
                Tag = "[StaticText]Publish Options Information|#2|$4204",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(PublishOptionsInformationTex);

            LocationText = new StaticText()
            {
                Tag = "[StaticText]Location:|#3|$13348",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(LocationText);

            FileTypeText = new StaticText()
            {
                Tag = "[StaticText]File type:|#6|$13349",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(FileTypeText);

            NamingText = new StaticText()
            {
                Tag = "[StaticText]Naming:|#8|$13351",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(NamingText);

            LayerInformationText = new StaticText()
            {
                Tag = "[StaticText]Layer information:|#10|$13352",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(LayerInformationText);

            MergeControlText = new StaticText()
            {
                Tag = "[StaticText]Merge control:|#12|$13353",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(MergeControlText);

            CDocumentsAndSettingsNsar = new StaticText()
            {
                Tag = "[StaticText]C:\\Documents and Settings\\nsarch\\my documents\\|#4|$13350",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(CDocumentsAndSettingsNsar);

            SingleSheetFileText = new StaticText()
            {
                Tag = "[StaticText]Single-sheet file|#7|$13354",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(SingleSheetFileText);

            NAText = new StaticText()
            {
                Tag = "[StaticText]N?A|#9|$13355",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(NAText);

            DonTIncludeText = new StaticText()
            {
                Tag = "[StaticText]Don't include|#11|$13356",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(DonTIncludeText);

            LinesOverwriteText = new StaticText()
            {
                Tag = "[StaticText]Lines overwrite|#13|$13357",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(LinesOverwriteText);
        }
    }
}
