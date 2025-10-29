// This file is auto-generated - do not hand edit this file.

using Autodesk.GUIHarness;
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{

    [UIElement(Tag = "[Pane]Properties|$propertyGridDockPanel1", Parent = typeof(Pane), GUIType = GuiType.UIA)]
    public partial class ReportDesignerPropertiesDLG : Autodesk.GUIHarness.AutoCAD.AcDialogBox
    {
        public  Pane Pane1PANE;
        public  Pane Pane2PANE;
        public  Pane Pane3PANE;
        public  Pane TheXtraLayoutControlPANE;
        public  Pane PropertyGridControlPanelPANE;
        public  Table TableTBL;
        public  CustomWin HeaderPanelWIN;
        public  Header DataMemberCTL;
        public  Header DataSourceCTL;
        public  Header FilterStringCTL;
        public  Header MeasureUnitsCTL;
        public  Header ReportPrintOptionsCTL;
        public  Header StyleSheetCTL;
        public  Header WatermarkCTL;
        public  Pane Pane4PANE;
        public  Pane Pane5PANE;
        public  Pane Pane6PANE;
        public  PopupList PopupListPL;
        public  StaticText XtraReportTemplateReportST;
        public  PushButton OpenPB;
        public  ListBox ListBoxLB;
        public  ListBoxItem ClientInformationCompanyNameParameterLBI;
        public  ListBoxItem ClientInformationPrimaryContactParameterLBI;
        public  ListBoxItem DataTableDictionary1AutodeskProcessPowerReportCreatorReportingFacadeDataTableDictionaryLBI;
        public  ListBoxItem DetailDetailLBI;
        public  ListBoxItem GeneralProjectDescriptionParameterLBI;
        public  ListBoxItem GeneralProjectNameParameterLBI;
        public  ListBoxItem GeneralProjectNumberParameterLBI;
        public  ListBoxItem GeneralProjectStandardParameterLBI;
        public  ListBoxItem GeneralToolPaletteGroupNameParameterLBI;
        public  ListBoxItem GeneralToolPaletteGroupNameForPipingParameterLBI;
        public  ListBoxItem GeneralVersionParameterLBI;
        public  ListBoxItem PageFooterPageFooterLBI;
        public  ListBoxItem PageHeaderPageHeaderLBI;
        public  ListBoxItem ProjectDataAddressParameterLBI;
        public  ListBoxItem ProjectDataCityParameterLBI;
        public  ListBoxItem ProjectDataProjectManagerParameterLBI;
        public  ListBoxItem ProjectDataStateParameterLBI;
        public  ListBoxItem ProjectDataTelephoneParameterLBI;
        public  ListBoxItem ProjectDataZipParameterLBI;
        public  ListBoxItem ReportHeaderReportHeaderLBI;
        public  ListBoxItem XtraReportTemplateReportLBI;
        public  CustomWin CalculatedFieldsWIN;
        public  CustomWin FilterStringWIN;
        public  CustomWin FilterStringWINDEU;
        public  CustomWin FilterStringWINFRA;
        public  CustomWin FilterStringWINRUS;
        public  CustomWin FilterStringWINCHS;
        public  CustomWin FilterStringWINJPN;
        public  CustomWin FilterStringWINKOR;
        public  CustomWin ImageResourcesWIN;
        public  CustomWin XMLDataPathWIN;
        public  CustomWin ParametersWIN;
        public  PushButton ClosePB;
        public  CustomWin StyleSheetWIN;
        public  CustomWin StyleSheetsPathWIN;
        public  CustomWin Watermark2WIN;
        public  CustomWin StyleSheetJPNWIN;
        public  CustomWin StyleSheetRUSWIN;
        public  CustomWin StyleSheetDEUWIN;
        public  CustomWin StyleSheetFRAWIN;
        public  CustomWin StyleSheetCHSWIN;
        public  CustomWin StyleSheetKORWIN;
        public  CustomWin Summary2WIN;
        public  CustomWin Summary2WINJPN;
        public  CustomWin Summary2WINDEU;
        public  CustomWin Summary2WINRUS;
        public  CustomWin Summary2WINCHS;
        public  CustomWin Summary2WINKOR;
        public  CustomWin TextFormatStringWIN;
        public  CustomWin TextFormatStringWINJPN;
        public  CustomWin TextFormatStringWINDEU;
        public  CustomWin TextFormatStringWINFRA;
        public  CustomWin TextFormatStringWINCHS;
        public  CustomWin TextFormatStringWINRUS;
        public  CustomWin TextFormatStringWINKOR;
        public  CustomWin SortFieldsWIN;
        public  CustomWin SortFieldsWINJPN;
        public  CustomWin SortFieldsWINFRA;
        public  CustomWin ImageSourceWINDEU;
        public  CustomWin ImageSourceWINRUS;
        public  CustomWin ImageSourceWINFRA;
        public  CustomWin ImageSourceWIN;
        public  CustomWin ImageURLWIN;
        public  CustomWin BackgroundImage2WIN;
        public  CustomWin ImageWIN;
        public  CustomWin BackgroundImage2WINJPN;
        public  CustomWin ImageWINJPN;
        public  CustomWin BackgroundImage2WINDEU;
        public  CustomWin ImageWINDEU;
        public  CustomWin BackgroundImage2WINFRA;
        public  CustomWin ImageWINFRA;
        public  CustomWin BackgroundImage2WINRUS;
        public  CustomWin ImageWINRUS;
        public  CustomWin AnnotationRepositoryWIN;
        public  CustomWin AnnotationsWIN;
        public  CustomWin AnnotationsWINJPN;
        public  CustomWin FormattingRuleSheetWIN;
        public  CustomWin FormattingRulesWIN;
        public  CustomWin FormattingRulesWINJPN;
        public  CustomWin FormattingRulesWINRUS;
        public  CustomWin FormattingRulesWINCHS;
        public  CustomWin FormattingRulesWINKOR;
        public  CustomWin FormattingRulesWINFRA;
        public  CustomWin FormattingRulesWINDEU;
        public  TextField TextField1TF;
        public  TextField TextField2TF;
        public  TextField TextField3TF;
        public  PushButton ClearPB;
        public  CustomWin BackgroundImage2WINsearch;
        public  CustomWin ImageWINSearch;
        public  CustomWin ImageWINSearchKOR;
        public  CustomWin ImageWINSearchCHS;
        public  CustomWin ImageWINSearchDEU;

        partial void OnInitialize();

        public ReportDesignerPropertiesDLG()
        {
            InitializeComponent();
            OnInitialize();
        }

        private void InitializeComponent()
        {

            Pane1PANE = new Pane()
            {
                Tag = "[Pane]$propertyGridDockPanel1_Container|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Pane1PANE);

            Pane2PANE = new Pane()
            {
                Tag = "[Pane]$propertyGridDockPanel1_Container|#1/[Pane]$XRDesignPropertyGrid|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Pane2PANE);

            Pane3PANE = new Pane()
            {
                Tag = "[Pane]$propertyGridDockPanel1_Container|#1/[Pane]$XRDesignPropertyGrid|#1/[Pane]$PropertyGridUserControl|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Pane3PANE);

            TheXtraLayoutControlPANE = new Pane()
            {
                Tag = "[Pane]$propertyGridDockPanel1_Container|#1/[Pane]$XRDesignPropertyGrid|#1/[Pane]$PropertyGridUserControl|#2/[Pane]$layoutControl|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(TheXtraLayoutControlPANE);

            PropertyGridControlPanelPANE = new Pane()
            {
                Tag = "[Pane]$propertyGridDockPanel1_Container|#1/[Pane]$XRDesignPropertyGrid|#1/[Pane]$PropertyGridUserControl|#2/[Pane]$layoutControl|#1/[Pane]$propertyGridControlPanel|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(PropertyGridControlPanelPANE);

            TableTBL = new Table()
            {
                Tag = "[Pane]$propertyGridDockPanel1_Container|#1/[Pane]$XRDesignPropertyGrid|#1/[Pane]$PropertyGridUserControl|#2/[Pane]$layoutControl|#1/[Pane]$propertyGridControlPanel|#1/[Table]$propertyGridControl|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(TableTBL);

            HeaderPanelWIN = new CustomWin()
            {
                Tag = "[Pane]$propertyGridDockPanel1_Container|#1/[Pane]$XRDesignPropertyGrid|#1/[Pane]$PropertyGridUserControl|#2/[Pane]$layoutControl|#1/[Pane]$propertyGridControlPanel|#1/[Table]$propertyGridControl|#1/[CustomWin]Header Panel|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(HeaderPanelWIN);

            DataMemberCTL = new Header()
            {
                Tag = "[Pane]$propertyGridDockPanel1_Container|#1/[Pane]$XRDesignPropertyGrid|#1/[Pane]$PropertyGridUserControl|#2/[Pane]$layoutControl|#1/[Pane]$propertyGridControlPanel|#1/[Table]$propertyGridControl|#1/[CustomWin]Header Panel|#2/[Header]Data Member|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(DataMemberCTL);

            DataSourceCTL = new Header()
            {
                Tag = "[Pane]$propertyGridDockPanel1_Container|#1/[Pane]$XRDesignPropertyGrid|#1/[Pane]$PropertyGridUserControl|#2/[Pane]$layoutControl|#1/[Pane]$propertyGridControlPanel|#1/[Table]$propertyGridControl|#1/[CustomWin]Header Panel|#2/[Header]Data Source|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(DataSourceCTL);

            FilterStringCTL = new Header()
            {
                Tag = "[Pane]$propertyGridDockPanel1_Container|#1/[Pane]$XRDesignPropertyGrid|#1/[Pane]$PropertyGridUserControl|#2/[Pane]$layoutControl|#1/[Pane]$propertyGridControlPanel|#1/[Table]$propertyGridControl|#1/[CustomWin]Header Panel|#2/[Header]Filter String|#3",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(FilterStringCTL);

            MeasureUnitsCTL = new Header()
            {
                Tag = "[Pane]$propertyGridDockPanel1_Container|#1/[Pane]$XRDesignPropertyGrid|#1/[Pane]$PropertyGridUserControl|#2/[Pane]$layoutControl|#1/[Pane]$propertyGridControlPanel|#1/[Table]$propertyGridControl|#1/[CustomWin]Header Panel|#2/[Header]Measure Units|#4",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(MeasureUnitsCTL);

            ReportPrintOptionsCTL = new Header()
            {
                Tag = "[Pane]$propertyGridDockPanel1_Container|#1/[Pane]$XRDesignPropertyGrid|#1/[Pane]$PropertyGridUserControl|#2/[Pane]$layoutControl|#1/[Pane]$propertyGridControlPanel|#1/[Table]$propertyGridControl|#1/[CustomWin]Header Panel|#2/[Header]Report Print Options|#5",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ReportPrintOptionsCTL);

            StyleSheetCTL = new Header()
            {
                Tag = "[Pane]$propertyGridDockPanel1_Container|#1/[Pane]$XRDesignPropertyGrid|#1/[Pane]$PropertyGridUserControl|#2/[Pane]$layoutControl|#1/[Pane]$propertyGridControlPanel|#1/[Table]$propertyGridControl|#1/[CustomWin]Header Panel|#2/[Header]Style Sheet|#6",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(StyleSheetCTL);

            WatermarkCTL = new Header()
            {
                Tag = "[Pane]$propertyGridDockPanel1_Container|#1/[Pane]$XRDesignPropertyGrid|#1/[Pane]$PropertyGridUserControl|#2/[Pane]$layoutControl|#1/[Pane]$propertyGridControlPanel|#1/[Table]$propertyGridControl|#1/[CustomWin]Header Panel|#2/[Header]Watermark|#7",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(WatermarkCTL);

            Pane4PANE = new Pane()
            {
                Tag = "[Pane]$propertyGridDockPanel1_Container|#1/[Pane]$XRDesignPropertyGrid|#1/[Pane]$PropertyGridUserControl|#2/[Pane]$layoutControl|#1/[Pane]$propertyGridControlPanel|#1/[Pane]$borderControl|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Pane4PANE);

            Pane5PANE = new Pane()
            {
                Tag = "[Pane]$propertyGridDockPanel1_Container|#1/[Pane]$XRDesignPropertyGrid|#1/[Pane]$PropertyGridUserControl|#2/[Pane]$layoutControl|#1/[Pane]$propertyDescriptionControl|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Pane5PANE);

            Pane6PANE = new Pane()
            {
                Tag = "[Pane]$propertyGridDockPanel1_Container|#1/[Pane]$XRDesignPropertyGrid|#1/[Pane]$3672852|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Pane6PANE);

            PopupListPL = new PopupList()
            {
                Tag = "[Pane]$propertyGridDockPanel1_Container|#1/[Pane]$XRDesignPropertyGrid|#1/[Pane]$3672852|#1/[PopupList]$primarySelection|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(PopupListPL);

            XtraReportTemplateReportST = new StaticText()
            {
                Tag = "[Pane]$propertyGridDockPanel1_Container|#1/[Pane]$XRDesignPropertyGrid|#1/[Pane]$3672852|#1/[PopupList]$primarySelection|#1/[StaticText]XtraReportTemplate   Report|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(XtraReportTemplateReportST);

            OpenPB = new PushButton()
            {
                Tag = "[Pane]$propertyGridDockPanel1_Container|#1/[Pane]$XRDesignPropertyGrid|#1/[Pane]$3672852|#1/[PopupList]$primarySelection|#1/[PushButton]Open|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(OpenPB);

            ListBoxLB = new ListBox()
            {
                Tag = "[Pane]$propertyGridDockPanel1_Container|#1/[Pane]$XRDesignPropertyGrid|#1/[Pane]$3672852|#1/[PopupList]$primarySelection|#1/[ListBox]#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ListBoxLB);

            ClientInformationCompanyNameParameterLBI = new ListBoxItem()
            {
                Tag = "[Pane]$propertyGridDockPanel1_Container|#1/[Pane]$XRDesignPropertyGrid|#1/[Pane]$3672852|#1/[PopupList]$primarySelection|#1/[ListBox]#1/[ListBoxItem]Client_Information_Company_Name   Parameter|#21",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ClientInformationCompanyNameParameterLBI);

            ClientInformationPrimaryContactParameterLBI = new ListBoxItem()
            {
                Tag = "[Pane]$propertyGridDockPanel1_Container|#1/[Pane]$XRDesignPropertyGrid|#1/[Pane]$3672852|#1/[PopupList]$primarySelection|#1/[ListBox]#1/[ListBoxItem]Client_Information_Primary_Contact   Parameter|#19",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ClientInformationPrimaryContactParameterLBI);

            DataTableDictionary1AutodeskProcessPowerReportCreatorReportingFacadeDataTableDictionaryLBI = new ListBoxItem()
            {
                Tag = "[Pane]$propertyGridDockPanel1_Container|#1/[Pane]$XRDesignPropertyGrid|#1/[Pane]$3672852|#1/[PopupList]$primarySelection|#1/[ListBox]#1/[ListBoxItem]dataTableDictionary1   Autodesk*|#18",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(DataTableDictionary1AutodeskProcessPowerReportCreatorReportingFacadeDataTableDictionaryLBI);

            DetailDetailLBI = new ListBoxItem()
            {
                Tag = "[Pane]$propertyGridDockPanel1_Container|#1/[Pane]$XRDesignPropertyGrid|#1/[Pane]$3672852|#1/[PopupList]$primarySelection|#1/[ListBox]#1/[ListBoxItem]Detail   Detail|#17",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(DetailDetailLBI);

            GeneralProjectDescriptionParameterLBI = new ListBoxItem()
            {
                Tag = "[Pane]$propertyGridDockPanel1_Container|#1/[Pane]$XRDesignPropertyGrid|#1/[Pane]$3672852|#1/[PopupList]$primarySelection|#1/[ListBox]#1/[ListBoxItem]General_Project_Description   Parameter|#16",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(GeneralProjectDescriptionParameterLBI);

            GeneralProjectNameParameterLBI = new ListBoxItem()
            {
                Tag = "[Pane]$propertyGridDockPanel1_Container|#1/[Pane]$XRDesignPropertyGrid|#1/[Pane]$3672852|#1/[PopupList]$primarySelection|#1/[ListBox]#1/[ListBoxItem]General_Project_Name   Parameter|#15",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(GeneralProjectNameParameterLBI);

            GeneralProjectNumberParameterLBI = new ListBoxItem()
            {
                Tag = "[Pane]$propertyGridDockPanel1_Container|#1/[Pane]$XRDesignPropertyGrid|#1/[Pane]$3672852|#1/[PopupList]$primarySelection|#1/[ListBox]#1/[ListBoxItem]General_Project_Number   Parameter|#14",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(GeneralProjectNumberParameterLBI);

            GeneralProjectStandardParameterLBI = new ListBoxItem()
            {
                Tag = "[Pane]$propertyGridDockPanel1_Container|#1/[Pane]$XRDesignPropertyGrid|#1/[Pane]$3672852|#1/[PopupList]$primarySelection|#1/[ListBox]#1/[ListBoxItem]General_Project_Standard   Parameter|#13",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(GeneralProjectStandardParameterLBI);

            GeneralToolPaletteGroupNameParameterLBI = new ListBoxItem()
            {
                Tag = "[Pane]$propertyGridDockPanel1_Container|#1/[Pane]$XRDesignPropertyGrid|#1/[Pane]$3672852|#1/[PopupList]$primarySelection|#1/[ListBox]#1/[ListBoxItem]General_ToolPaletteGroupName   Parameter|#12",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(GeneralToolPaletteGroupNameParameterLBI);

            GeneralToolPaletteGroupNameForPipingParameterLBI = new ListBoxItem()
            {
                Tag = "[Pane]$propertyGridDockPanel1_Container|#1/[Pane]$XRDesignPropertyGrid|#1/[Pane]$3672852|#1/[PopupList]$primarySelection|#1/[ListBox]#1/[ListBoxItem]General_ToolPaletteGroupNameForPiping   Parameter|#20",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(GeneralToolPaletteGroupNameForPipingParameterLBI);

            GeneralVersionParameterLBI = new ListBoxItem()
            {
                Tag = "[Pane]$propertyGridDockPanel1_Container|#1/[Pane]$XRDesignPropertyGrid|#1/[Pane]$3672852|#1/[PopupList]$primarySelection|#1/[ListBox]#1/[ListBoxItem]General_Version   Parameter|#11",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(GeneralVersionParameterLBI);

            PageFooterPageFooterLBI = new ListBoxItem()
            {
                Tag = "[Pane]$propertyGridDockPanel1_Container|#1/[Pane]$XRDesignPropertyGrid|#1/[Pane]$3672852|#1/[PopupList]$primarySelection|#1/[ListBox]#1/[ListBoxItem]PageFooter   Page Footer|#9",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(PageFooterPageFooterLBI);

            PageHeaderPageHeaderLBI = new ListBoxItem()
            {
                Tag = "[Pane]$propertyGridDockPanel1_Container|#1/[Pane]$XRDesignPropertyGrid|#1/[Pane]$3672852|#1/[PopupList]$primarySelection|#1/[ListBox]#1/[ListBoxItem]PageHeader   Page Header|#8",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(PageHeaderPageHeaderLBI);

            ProjectDataAddressParameterLBI = new ListBoxItem()
            {
                Tag = "[Pane]$propertyGridDockPanel1_Container|#1/[Pane]$XRDesignPropertyGrid|#1/[Pane]$3672852|#1/[PopupList]$primarySelection|#1/[ListBox]#1/[ListBoxItem]Project_Data_Address   Parameter|#7",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ProjectDataAddressParameterLBI);

            ProjectDataCityParameterLBI = new ListBoxItem()
            {
                Tag = "[Pane]$propertyGridDockPanel1_Container|#1/[Pane]$XRDesignPropertyGrid|#1/[Pane]$3672852|#1/[PopupList]$primarySelection|#1/[ListBox]#1/[ListBoxItem]Project_Data_City   Parameter|#6",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ProjectDataCityParameterLBI);

            ProjectDataProjectManagerParameterLBI = new ListBoxItem()
            {
                Tag = "[Pane]$propertyGridDockPanel1_Container|#1/[Pane]$XRDesignPropertyGrid|#1/[Pane]$3672852|#1/[PopupList]$primarySelection|#1/[ListBox]#1/[ListBoxItem]Project_Data_Project_Manager   Parameter|#5",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ProjectDataProjectManagerParameterLBI);

            ProjectDataStateParameterLBI = new ListBoxItem()
            {
                Tag = "[Pane]$propertyGridDockPanel1_Container|#1/[Pane]$XRDesignPropertyGrid|#1/[Pane]$3672852|#1/[PopupList]$primarySelection|#1/[ListBox]#1/[ListBoxItem]Project_Data_State   Parameter|#4",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ProjectDataStateParameterLBI);

            ProjectDataTelephoneParameterLBI = new ListBoxItem()
            {
                Tag = "[Pane]$propertyGridDockPanel1_Container|#1/[Pane]$XRDesignPropertyGrid|#1/[Pane]$3672852|#1/[PopupList]$primarySelection|#1/[ListBox]#1/[ListBoxItem]Project_Data_Telephone   Parameter|#3",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ProjectDataTelephoneParameterLBI);

            ProjectDataZipParameterLBI = new ListBoxItem()
            {
                Tag = "[Pane]$propertyGridDockPanel1_Container|#1/[Pane]$XRDesignPropertyGrid|#1/[Pane]$3672852|#1/[PopupList]$primarySelection|#1/[ListBox]#1/[ListBoxItem]Project_Data_Zip   Parameter|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ProjectDataZipParameterLBI);

            ReportHeaderReportHeaderLBI = new ListBoxItem()
            {
                Tag = "[Pane]$propertyGridDockPanel1_Container|#1/[Pane]$XRDesignPropertyGrid|#1/[Pane]$3672852|#1/[PopupList]$primarySelection|#1/[ListBox]#1/[ListBoxItem]ReportHeader   Report Header|#10",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ReportHeaderReportHeaderLBI);

            XtraReportTemplateReportLBI = new ListBoxItem()
            {
                Tag = "[Pane]$propertyGridDockPanel1_Container|#1/[Pane]$XRDesignPropertyGrid|#1/[Pane]$3672852|#1/[PopupList]$primarySelection|#1/[ListBox]#1/[ListBoxItem]XtraReportTemplate   Report|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(XtraReportTemplateReportLBI);

            CalculatedFieldsWIN = new CustomWin()
            {
                Tag = "[Pane]$propertyGridDockPanel1_Container/[Pane]$XRDesignPropertyGrid|#1/[Pane]$PropertyGridUserControl|#2/[Pane]$layoutControl|#1/[Pane]$propertyGridControlPanel|#1/[Table]$propertyGridControl|#1/[CustomWin]*/[CustomWin]#1/[CustomWin]#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(CalculatedFieldsWIN);

            FilterStringWIN = new CustomWin()
            {
                Tag = "[Pane]$propertyGridDockPanel1_Container/[Pane]$XRDesignPropertyGrid|#1/[Pane]$PropertyGridUserControl|#2/[Pane]$layoutControl|#1/[Pane]$propertyGridControlPanel|#1/[Table]$propertyGridControl|#1/[CustomWin]*/[CustomWin]#1/[CustomWin]#5",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(FilterStringWIN);

            FilterStringWINDEU = new CustomWin()
            {
                Tag = "[Pane]$propertyGridDockPanel1_Container/[Pane]$XRDesignPropertyGrid|#1/[Pane]$PropertyGridUserControl|#2/[Pane]$layoutControl|#1/[Pane]$propertyGridControlPanel|#1/[Table]$propertyGridControl|#1/[CustomWin]*/[CustomWin]#1/[CustomWin]#5",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(FilterStringWINDEU);

            FilterStringWINFRA = new CustomWin()
            {
                Tag = "[Pane]$propertyGridDockPanel1_Container/[Pane]$XRDesignPropertyGrid|#1/[Pane]$PropertyGridUserControl|#2/[Pane]$layoutControl|#1/[Pane]$propertyGridControlPanel|#1/[Table]$propertyGridControl|#1/[CustomWin]*/[CustomWin]#1/[CustomWin]#3",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(FilterStringWINFRA);

            FilterStringWINRUS = new CustomWin()
            {
                Tag = "[Pane]$propertyGridDockPanel1_Container/[Pane]$XRDesignPropertyGrid|#1/[Pane]$PropertyGridUserControl|#2/[Pane]$layoutControl|#1/[Pane]$propertyGridControlPanel|#1/[Table]$propertyGridControl|#1/[CustomWin]*/[CustomWin]#1/[CustomWin]#7",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(FilterStringWINRUS);

            FilterStringWINCHS = new CustomWin()
            {
                Tag = "[Pane]$propertyGridDockPanel1_Container/[Pane]$XRDesignPropertyGrid|#1/[Pane]$PropertyGridUserControl|#2/[Pane]$layoutControl|#1/[Pane]$propertyGridControlPanel|#1/[Table]$propertyGridControl|#1/[CustomWin]*/[CustomWin]#1/[CustomWin]#4",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(FilterStringWINCHS);

            FilterStringWINJPN = new CustomWin()
            {
                Tag = "[Pane]$propertyGridDockPanel1_Container/[Pane]$XRDesignPropertyGrid|#1/[Pane]$PropertyGridUserControl|#2/[Pane]$layoutControl|#1/[Pane]$propertyGridControlPanel|#1/[Table]$propertyGridControl|#1/[CustomWin]*/[CustomWin]#1/[CustomWin]#7",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(FilterStringWINJPN);

            FilterStringWINKOR = new CustomWin()
            {
                Tag = "[Pane]$propertyGridDockPanel1_Container/[Pane]$XRDesignPropertyGrid|#1/[Pane]$PropertyGridUserControl|#2/[Pane]$layoutControl|#1/[Pane]$propertyGridControlPanel|#1/[Table]$propertyGridControl|#1/[CustomWin]*/[CustomWin]#1/[CustomWin]#8",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(FilterStringWINKOR);

            ImageResourcesWIN = new CustomWin()
            {
                Tag = "[Pane]$propertyGridDockPanel1_Container/[Pane]$XRDesignPropertyGrid|#1/[Pane]$PropertyGridUserControl|#2/[Pane]$layoutControl|#1/[Pane]$propertyGridControlPanel|#1/[Table]$propertyGridControl|#1/[CustomWin]*/[CustomWin]#1/[CustomWin]#6",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ImageResourcesWIN);

            XMLDataPathWIN = new CustomWin()
            {
                Tag = "[Pane]$propertyGridDockPanel1_Container/[Pane]$XRDesignPropertyGrid|#1/[Pane]$PropertyGridUserControl|#2/[Pane]$layoutControl|#1/[Pane]$propertyGridControlPanel|#1/[Table]$propertyGridControl|#1/[CustomWin]*/[CustomWin]#1/[CustomWin]#8",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(XMLDataPathWIN);

            ParametersWIN = new CustomWin()
            {
                Tag = "[Pane]$propertyGridDockPanel1_Container/[Pane]$XRDesignPropertyGrid|#1/[Pane]$PropertyGridUserControl|#2/[Pane]$layoutControl|#1/[Pane]$propertyGridControlPanel|#1/[Table]$propertyGridControl|#1/[CustomWin]*/[CustomWin]#1/[CustomWin]#9",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ParametersWIN);

            ClosePB = new PushButton()
            {
                Tag = "[TitleBar]Properties|#1/[PushButton]Close|#4",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ClosePB);

            StyleSheetWIN = new CustomWin()
            {
                Tag = "[Pane]$propertyGridDockPanel1_Container/[Pane]$XRDesignPropertyGrid|#1/[Pane]$PropertyGridUserControl|#2/[Pane]$layoutControl|#1/[Pane]$propertyGridControlPanel|#1/[Table]$propertyGridControl|#1/[CustomWin]#1/[CustomWin]#1/[CustomWin]#10",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(StyleSheetWIN);

            StyleSheetsPathWIN = new CustomWin()
            {
                Tag = "[Pane]$propertyGridDockPanel1_Container/[Pane]$XRDesignPropertyGrid|#1/[Pane]$PropertyGridUserControl|#2/[Pane]$layoutControl|#1/[Pane]$propertyGridControlPanel|#1/[Table]$propertyGridControl|#1/[CustomWin]#1/[CustomWin]#1/[CustomWin]#11",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(StyleSheetsPathWIN);

            Watermark2WIN = new CustomWin()
            {
                Tag = "[Pane]$propertyGridDockPanel1_Container[Pane]$XRDesignPropertyGrid|#1/[Pane]$PropertyGridUserControl|#2/[Pane]$layoutControl|#1/[Pane]$propertyGridControlPanel|#1/[Table]$propertyGridControl|#1/[CustomWin]#1/[CustomWin]#1/[CustomWin]#13",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Watermark2WIN);

            StyleSheetJPNWIN = new CustomWin()
            {
                Tag = "[Pane]$propertyGridDockPanel1_Container/[Pane]$XRDesignPropertyGrid|#1/[Pane]$PropertyGridUserControl|#2/[Pane]$layoutControl|#1/[Pane]$propertyGridControlPanel|#1/[Table]$propertyGridControl|#1/[CustomWin]#1/[CustomWin]#1/[CustomWin]#3",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(StyleSheetJPNWIN);

            StyleSheetRUSWIN = new CustomWin()
            {
                Tag = "[Pane]$propertyGridDockPanel1_Container/[Pane]$XRDesignPropertyGrid|#1/[Pane]$PropertyGridUserControl|#2/[Pane]$layoutControl|#1/[Pane]$propertyGridControlPanel|#1/[Table]$propertyGridControl|#1/[CustomWin]#1/[CustomWin]#1/[CustomWin]#7",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(StyleSheetRUSWIN);

            StyleSheetDEUWIN = new CustomWin()
            {
                Tag = "[Pane]$propertyGridDockPanel1_Container/[Pane]$XRDesignPropertyGrid|#1/[Pane]$PropertyGridUserControl|#2/[Pane]$layoutControl|#1/[Pane]$propertyGridControlPanel|#1/[Table]$propertyGridControl|#1/[CustomWin]#1/[CustomWin]#1/[CustomWin]#10",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(StyleSheetDEUWIN);

            StyleSheetFRAWIN = new CustomWin()
            {
                Tag = "[Pane]$propertyGridDockPanel1_Container/[Pane]$XRDesignPropertyGrid|#1/[Pane]$PropertyGridUserControl|#2/[Pane]$layoutControl|#1/[Pane]$propertyGridControlPanel|#1/[Table]$propertyGridControl|#1/[CustomWin]#1/[CustomWin]#1/[CustomWin]#8",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(StyleSheetFRAWIN);

            StyleSheetCHSWIN = new CustomWin()
            {
                Tag = "[Pane]$propertyGridDockPanel1_Container/[Pane]$XRDesignPropertyGrid|#1/[Pane]$PropertyGridUserControl|#2/[Pane]$layoutControl|#1/[Pane]$propertyGridControlPanel|#1/[Table]$propertyGridControl|#1/[CustomWin]#1/[CustomWin]#1/[CustomWin]#12",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(StyleSheetCHSWIN);

            StyleSheetKORWIN = new CustomWin()
            {
                Tag = "[Pane]$propertyGridDockPanel1_Container/[Pane]$XRDesignPropertyGrid|#1/[Pane]$PropertyGridUserControl|#2/[Pane]$layoutControl|#1/[Pane]$propertyGridControlPanel|#1/[Table]$propertyGridControl|#1/[CustomWin]#1/[CustomWin]#1/[CustomWin]#8",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(StyleSheetKORWIN);

            Summary2WIN = new CustomWin()
            {
                Tag = "[Pane]$propertyGridDockPanel1_Container|#1/[Pane]$XRDesignPropertyGrid|#1/[Pane]$PropertyGridUserControl|#2/[Pane]$layoutControl|#1/[Pane]$propertyGridControlPanel|#1/[Table]$propertyGridControl|#1/[CustomWin]#1/[CustomWin]#1/[CustomWin]#3",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Summary2WIN);

            Summary2WINJPN = new CustomWin()
            {
                Tag = "[Pane]$propertyGridDockPanel1_Container|#1/[Pane]$XRDesignPropertyGrid|#1/[Pane]$PropertyGridUserControl|#2/[Pane]$layoutControl|#1/[Pane]$propertyGridControlPanel|#1/[Table]$propertyGridControl|#1/[CustomWin]#1/[CustomWin]#1/[CustomWin]#4",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Summary2WINJPN);

            Summary2WINDEU = new CustomWin()
            {
                Tag = "[Pane]$propertyGridDockPanel1_Container|#1/[Pane]$XRDesignPropertyGrid|#1/[Pane]$PropertyGridUserControl|#2/[Pane]$layoutControl|#1/[Pane]$propertyGridControlPanel|#1/[Table]$propertyGridControl|#1/[CustomWin]#1/[CustomWin]#1/[CustomWin]#7",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Summary2WINDEU);

            Summary2WINRUS = new CustomWin()
            {
                Tag = "[Pane]$propertyGridDockPanel1_Container|#1/[Pane]$XRDesignPropertyGrid|#1/[Pane]$PropertyGridUserControl|#2/[Pane]$layoutControl|#1/[Pane]$propertyGridControlPanel|#1/[Table]$propertyGridControl|#1/[CustomWin]#1/[CustomWin]#1/[CustomWin]#3",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Summary2WINRUS);

            Summary2WINCHS = new CustomWin()
            {
                Tag = "[Pane]$propertyGridDockPanel1_Container|#1/[Pane]$XRDesignPropertyGrid|#1/[Pane]$PropertyGridUserControl|#2/[Pane]$layoutControl|#1/[Pane]$propertyGridControlPanel|#1/[Table]$propertyGridControl|#1/[CustomWin]#1/[CustomWin]#1/[CustomWin]#3",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Summary2WINCHS);

            Summary2WINKOR = new CustomWin()
            {
                Tag = "[Pane]$propertyGridDockPanel1_Container|#1/[Pane]$XRDesignPropertyGrid|#1/[Pane]$PropertyGridUserControl|#2/[Pane]$layoutControl|#1/[Pane]$propertyGridControlPanel|#1/[Table]$propertyGridControl|#1/[CustomWin]#1/[CustomWin]#1/[CustomWin]#6",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Summary2WINKOR);

            TextFormatStringWIN = new CustomWin()
            {
                Tag = "[Pane]$propertyGridDockPanel1_Container|#1/[Pane]$XRDesignPropertyGrid|#1/[Pane]$PropertyGridUserControl|#2/[Pane]$layoutControl|#1/[Pane]$propertyGridControlPanel|#1/[Table]$propertyGridControl|#1/[CustomWin]#1/[CustomWin]#1/[CustomWin]#6",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(TextFormatStringWIN);

            TextFormatStringWINJPN = new CustomWin()
            {
                Tag = "[Pane]$propertyGridDockPanel1_Container|#1/[Pane]$XRDesignPropertyGrid|#1/[Pane]$PropertyGridUserControl|#2/[Pane]$layoutControl|#1/[Pane]$propertyGridControlPanel|#1/[Table]$propertyGridControl|#1/[CustomWin]#1/[CustomWin]#1/[CustomWin]#7",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(TextFormatStringWINJPN);

            TextFormatStringWINDEU = new CustomWin()
            {
                Tag = "[Pane]$propertyGridDockPanel1_Container|#1/[Pane]$XRDesignPropertyGrid|#1/[Pane]$PropertyGridUserControl|#2/[Pane]$layoutControl|#1/[Pane]$propertyGridControlPanel|#1/[Table]$propertyGridControl|#1/[CustomWin]#1/[CustomWin]#1/[CustomWin]#4",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(TextFormatStringWINDEU);

            TextFormatStringWINFRA = new CustomWin()
            {
                Tag = "[Pane]$propertyGridDockPanel1_Container|#1/[Pane]$XRDesignPropertyGrid|#1/[Pane]$PropertyGridUserControl|#2/[Pane]$layoutControl|#1/[Pane]$propertyGridControlPanel|#1/[Table]$propertyGridControl|#1/[CustomWin]#1/[CustomWin]#1/[CustomWin]#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(TextFormatStringWINFRA);

            TextFormatStringWINCHS = new CustomWin()
            {
                Tag = "[Pane]$propertyGridDockPanel1_Container|#1/[Pane]$XRDesignPropertyGrid|#1/[Pane]$PropertyGridUserControl|#2/[Pane]$layoutControl|#1/[Pane]$propertyGridControlPanel|#1/[Table]$propertyGridControl|#1/[CustomWin]#1/[CustomWin]#1/[CustomWin]#7",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(TextFormatStringWINCHS);

            TextFormatStringWINRUS = new CustomWin()
            {
                Tag = "[Pane]$propertyGridDockPanel1_Container|#1/[Pane]$XRDesignPropertyGrid|#1/[Pane]$PropertyGridUserControl|#2/[Pane]$layoutControl|#1/[Pane]$propertyGridControlPanel|#1/[Table]$propertyGridControl|#1/[CustomWin]#1/[CustomWin]#1/[CustomWin]#6",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(TextFormatStringWINRUS);

            TextFormatStringWINKOR = new CustomWin()
            {
                Tag = "[Pane]$propertyGridDockPanel1_Container|#1/[Pane]$XRDesignPropertyGrid|#1/[Pane]$PropertyGridUserControl|#2/[Pane]$layoutControl|#1/[Pane]$propertyGridControlPanel|#1/[Table]$propertyGridControl|#1/[CustomWin]#1/[CustomWin]#1/[CustomWin]#4",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(TextFormatStringWINKOR);

            SortFieldsWIN = new CustomWin()
            {
                Tag = "[Pane]$propertyGridDockPanel1_Container|#1/[Pane]$XRDesignPropertyGrid|#1/[Pane]$PropertyGridUserControl|#2/[Pane]$layoutControl|#1/[Pane]$propertyGridControlPanel|#1/[Table]$propertyGridControl|#1/[CustomWin]#1/[CustomWin]#1/[CustomWin]#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(SortFieldsWIN);

            SortFieldsWINJPN = new CustomWin()
            {
                Tag = "[Pane]$propertyGridDockPanel1_Container|#1/[Pane]$XRDesignPropertyGrid|#1/[Pane]$PropertyGridUserControl|#2/[Pane]$layoutControl|#1/[Pane]$propertyGridControlPanel|#1/[Table]$propertyGridControl|#1/[CustomWin]#1/[CustomWin]#1/[CustomWin]#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(SortFieldsWINJPN);

            SortFieldsWINFRA = new CustomWin()
            {
                Tag = "[Pane]$propertyGridDockPanel1_Container|#1/[Pane]$XRDesignPropertyGrid|#1/[Pane]$PropertyGridUserControl|#2/[Pane]$layoutControl|#1/[Pane]$propertyGridControlPanel|#1/[Table]$propertyGridControl|#1/[CustomWin]#1/[CustomWin]#1/[CustomWin]#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(SortFieldsWINFRA);

            ImageSourceWINDEU = new CustomWin()
            {
                Tag = "[Pane]$propertyGridDockPanel1_Container|#1/[Pane]$XRDesignPropertyGrid|#1/[Pane]$PropertyGridUserControl|#2/[Pane]$layoutControl|#1/[Pane]$propertyGridControlPanel|#1/[Table]$propertyGridControl|#1/[CustomWin]#1/[CustomWin]#1/[CustomWin]#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ImageSourceWINDEU);

            ImageSourceWINRUS = new CustomWin()
            {
                Tag = "[Pane]$propertyGridDockPanel1_Container|#1/[Pane]$XRDesignPropertyGrid|#1/[Pane]$PropertyGridUserControl|#2/[Pane]$layoutControl|#1/[Pane]$propertyGridControlPanel|#1/[Table]$propertyGridControl|#1/[CustomWin]#1/[CustomWin]#1/[CustomWin]#4",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ImageSourceWINRUS);

            ImageSourceWINFRA = new CustomWin()
            {
                Tag = "[Pane]$propertyGridDockPanel1_Container|#1/[Pane]$XRDesignPropertyGrid|#1/[Pane]$PropertyGridUserControl|#2/[Pane]$layoutControl|#1/[Pane]$propertyGridControlPanel|#1/[Table]$propertyGridControl|#1/[CustomWin]#1/[CustomWin]#1/[CustomWin]#3",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ImageSourceWINFRA);

            ImageSourceWIN = new CustomWin()
            {
                Tag = "[Pane]$propertyGridDockPanel1_Container|#1/[Pane]$XRDesignPropertyGrid|#1/[Pane]$PropertyGridUserControl|#2/[Pane]$layoutControl|#1/[Pane]$propertyGridControlPanel|#1/[Table]$propertyGridControl|#1/[CustomWin]#1/[CustomWin]#1/[CustomWin]#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ImageSourceWIN);

            ImageURLWIN = new CustomWin()
            {
                Tag = "[Pane]$propertyGridDockPanel1_Container|#1/[Pane]$XRDesignPropertyGrid|#1/[Pane]$PropertyGridUserControl|#2/[Pane]$layoutControl|#1/[Pane]$propertyGridControlPanel|#1/[Table]$propertyGridControl|#1/[CustomWin]#1/[CustomWin]#1/[CustomWin]#3",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ImageURLWIN);

            BackgroundImage2WIN = new CustomWin()
            {
                Tag = "[Pane]$propertyGridDockPanel1_Container|#1/[Pane]$XRDesignPropertyGrid|#1/[Pane]$PropertyGridUserControl|#2/[Pane]$layoutControl|#1/[Pane]$propertyGridControlPanel|#1/[Table]$propertyGridControl|#1/[CustomWin]#1/[CustomWin]#1/[CustomWin]#9",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(BackgroundImage2WIN);

            ImageWIN = new CustomWin()
            {
                Tag = "[Pane]$propertyGridDockPanel1_Container|#1/[Pane]$XRDesignPropertyGrid|#1/[Pane]$PropertyGridUserControl|#2/[Pane]$layoutControl|#1/[Pane]$propertyGridControlPanel|#1/[Table]$propertyGridControl|#1/[CustomWin]#1/[CustomWin]#1/[CustomWin]#13",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ImageWIN);

            BackgroundImage2WINJPN = new CustomWin()
            {
                Tag = "[Pane]$propertyGridDockPanel1_Container|#1/[Pane]$XRDesignPropertyGrid|#1/[Pane]$PropertyGridUserControl|#2/[Pane]$layoutControl|#1/[Pane]$propertyGridControlPanel|#1/[Table]$propertyGridControl|#1/[CustomWin]#1/[CustomWin]#1/[CustomWin]#22",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(BackgroundImage2WINJPN);

            ImageWINJPN = new CustomWin()
            {
                Tag = "[Pane]$propertyGridDockPanel1_Container|#1/[Pane]$XRDesignPropertyGrid|#1/[Pane]$PropertyGridUserControl|#2/[Pane]$layoutControl|#1/[Pane]$propertyGridControlPanel|#1/[Table]$propertyGridControl|#1/[CustomWin]#1/[CustomWin]#1/[CustomWin]#25",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ImageWINJPN);

            BackgroundImage2WINDEU = new CustomWin()
            {
                Tag = "[Pane]$propertyGridDockPanel1_Container|#1/[Pane]$XRDesignPropertyGrid|#1/[Pane]$PropertyGridUserControl|#2/[Pane]$layoutControl|#1/[Pane]$propertyGridControlPanel|#1/[Table]$propertyGridControl|#1/[CustomWin]#1/[CustomWin]#1/[CustomWin]#13",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(BackgroundImage2WINDEU);

            ImageWINDEU = new CustomWin()
            {
                Tag = "[Pane]$propertyGridDockPanel1_Container|#1/[Pane]$XRDesignPropertyGrid|#1/[Pane]$PropertyGridUserControl|#2/[Pane]$layoutControl|#1/[Pane]$propertyGridControlPanel|#1/[Table]$propertyGridControl|#1/[CustomWin]#1/[CustomWin]#1/[CustomWin]#22",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ImageWINDEU);

            BackgroundImage2WINFRA = new CustomWin()
            {
                Tag = "[Pane]$propertyGridDockPanel1_Container|#1/[Pane]$XRDesignPropertyGrid|#1/[Pane]$PropertyGridUserControl|#2/[Pane]$layoutControl|#1/[Pane]$propertyGridControlPanel|#1/[Table]$propertyGridControl|#1/[CustomWin]#1/[CustomWin]#1/[CustomWin]#13",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(BackgroundImage2WINFRA);

            ImageWINFRA = new CustomWin()
            {
                Tag = "[Pane]$propertyGridDockPanel1_Container|#1/[Pane]$XRDesignPropertyGrid|#1/[Pane]$PropertyGridUserControl|#2/[Pane]$layoutControl|#1/[Pane]$propertyGridControlPanel|#1/[Table]$propertyGridControl|#1/[CustomWin]#1/[CustomWin]#1/[CustomWin]#17",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ImageWINFRA);

            BackgroundImage2WINRUS = new CustomWin()
            {
                Tag = "[Pane]$propertyGridDockPanel1_Container|#1/[Pane]$XRDesignPropertyGrid|#1/[Pane]$PropertyGridUserControl|#2/[Pane]$layoutControl|#1/[Pane]$propertyGridControlPanel|#1/[Table]$propertyGridControl|#1/[CustomWin]#1/[CustomWin]#1/[CustomWin]#5",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(BackgroundImage2WINRUS);

            ImageWINRUS = new CustomWin()
            {
                Tag = "[Pane]$propertyGridDockPanel1_Container|#1/[Pane]$XRDesignPropertyGrid|#1/[Pane]$PropertyGridUserControl|#2/[Pane]$layoutControl|#1/[Pane]$propertyGridControlPanel|#1/[Table]$propertyGridControl|#1/[CustomWin]#1/[CustomWin]#1/[CustomWin]#17",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ImageWINRUS);

            AnnotationRepositoryWIN = new CustomWin()
            {
                Tag = "[Pane]$propertyGridDockPanel1_Container|#1/[Pane]$XRDesignPropertyGrid|#1/[Pane]$PropertyGridUserControl|#2/[Pane]$layoutControl|#1/[Pane]$propertyGridControlPanel|#1/[Table]$propertyGridControl|#1/[CustomWin]Data Panel|#1/[CustomWin]#1/[CustomWin]#9",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(AnnotationRepositoryWIN);

            AnnotationsWIN = new CustomWin()
            {
                Tag = "[Pane]$propertyGridDockPanel1_Container|#1/[Pane]$XRDesignPropertyGrid|#1/[Pane]$PropertyGridUserControl|#2/[Pane]$layoutControl|#1/[Pane]$propertyGridControlPanel|#1/[Table]$propertyGridControl|#1/[CustomWin]Data Panel|#1/[CustomWin]#1/[CustomWin]#21",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(AnnotationsWIN);

            AnnotationsWINJPN = new CustomWin()
            {
                Tag = "[Pane]$propertyGridDockPanel1_Container|#1/[Pane]$XRDesignPropertyGrid|#1/[Pane]$PropertyGridUserControl|#2/[Pane]$layoutControl|#1/[Pane]$propertyGridControlPanel|#1/[Table]$propertyGridControl|#1/[CustomWin]Data Panel|#1/[CustomWin]#1/[CustomWin]#26",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(AnnotationsWINJPN);

            FormattingRuleSheetWIN = new CustomWin()
            {
                Tag = "[Pane]$propertyGridDockPanel1_Container|#1/[Pane]$XRDesignPropertyGrid|#1/[Pane]$PropertyGridUserControl|#2/[Pane]$layoutControl|#1/[Pane]$propertyGridControlPanel|#1/[Table]$propertyGridControl|#1/[CustomWin]#1/[CustomWin]#1/[CustomWin]#8",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(FormattingRuleSheetWIN);

            FormattingRulesWIN = new CustomWin()
            {
                Tag = "[Pane]$propertyGridDockPanel1_Container|#1/[Pane]$XRDesignPropertyGrid|#1/[Pane]$PropertyGridUserControl|#2/[Pane]$layoutControl|#1/[Pane]$propertyGridControlPanel|#1/[Table]$propertyGridControl|#1/[CustomWin]#1/[CustomWin]#1/[CustomWin]#9",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(FormattingRulesWIN);

            FormattingRulesWINJPN = new CustomWin()
            {
                Tag = "[Pane]$propertyGridDockPanel1_Container|#1/[Pane]$XRDesignPropertyGrid|#1/[Pane]$PropertyGridUserControl|#2/[Pane]$layoutControl|#1/[Pane]$propertyGridControlPanel|#1/[Table]$propertyGridControl|#1/[CustomWin]#1/[CustomWin]#1/[CustomWin]#7",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(FormattingRulesWINJPN);

            FormattingRulesWINRUS = new CustomWin()
            {
                Tag = "[Pane]$propertyGridDockPanel1_Container|#1/[Pane]$XRDesignPropertyGrid|#1/[Pane]$PropertyGridUserControl|#2/[Pane]$layoutControl|#1/[Pane]$propertyGridControlPanel|#1/[Table]$propertyGridControl|#1/[CustomWin]#1/[CustomWin]#1/[CustomWin]#6",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(FormattingRulesWINRUS);

            FormattingRulesWINCHS = new CustomWin()
            {
                Tag = "[Pane]$propertyGridDockPanel1_Container|#1/[Pane]$XRDesignPropertyGrid|#1/[Pane]$PropertyGridUserControl|#2/[Pane]$layoutControl|#1/[Pane]$propertyGridControlPanel|#1/[Table]$propertyGridControl|#1/[CustomWin]#1/[CustomWin]#1/[CustomWin]#8",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(FormattingRulesWINCHS);

            FormattingRulesWINKOR = new CustomWin()
            {
                Tag = "[Pane]$propertyGridDockPanel1_Container|#1/[Pane]$XRDesignPropertyGrid|#1/[Pane]$PropertyGridUserControl|#2/[Pane]$layoutControl|#1/[Pane]$propertyGridControlPanel|#1/[Table]$propertyGridControl|#1/[CustomWin]#1/[CustomWin]#1/[CustomWin]#14",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(FormattingRulesWINKOR);

            FormattingRulesWINFRA = new CustomWin()
            {
                Tag = "[Pane]$propertyGridDockPanel1_Container|#1/[Pane]$XRDesignPropertyGrid|#1/[Pane]$PropertyGridUserControl|#2/[Pane]$layoutControl|#1/[Pane]$propertyGridControlPanel|#1/[Table]$propertyGridControl|#1/[CustomWin]#1/[CustomWin]#1/[CustomWin]#13",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(FormattingRulesWINFRA);

            FormattingRulesWINDEU = new CustomWin()
            {
                Tag = "[Pane]$propertyGridDockPanel1_Container|#1/[Pane]$XRDesignPropertyGrid|#1/[Pane]$PropertyGridUserControl|#2/[Pane]$layoutControl|#1/[Pane]$propertyGridControlPanel|#1/[Table]$propertyGridControl|#1/[CustomWin]#1/[CustomWin]#1/[CustomWin]#3",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(FormattingRulesWINDEU);

            TextField1TF = new TextField()
            {
                Tag = "[Pane]$propertyGridDockPanel1_Container|#1/[Pane]$XRDesignPropertyGrid|#1/[Pane]$PropertyGridUserControl|#2/[Pane]The XtraLayoutControl|$layoutControl|#1/[Pane]propertyGridControlPanel|$propertyGridControlPanel|#1/[Table]$propertyGridControl|#1/[Pane]$FindControlCore|#1/[Pane]Find Panel|$rootLayout|#1/[Pane]Find Panel|$findLayoutControl|#1/[TextField]$teFind|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(TextField1TF);

            TextField2TF = new TextField()
            {
                Tag = "[Pane]$propertyGridDockPanel1_Container|#1/[Pane]$XRDesignPropertyGrid|#1/[Pane]$PropertyGridUserControl|#2/[Pane]The XtraLayoutControl|$layoutControl|#1/[Pane]propertyGridControlPanel|$propertyGridControlPanel|#1/[Table]$propertyGridControl|#1/[Pane]$FindControlCore|#1/[Pane]Find Panel|$rootLayout|#1/[Pane]Find Panel|$findLayoutControl|#1/[TextField]$teFind|#1/[TextField]$134630|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(TextField2TF);

            TextField3TF = new TextField()
            {
                Tag = "[Pane]$propertyGridDockPanel1_Container|#1/[Pane]$XRDesignPropertyGrid|#1/[Pane]$PropertyGridUserControl|#2/[Pane]The XtraLayoutControl|$layoutControl|#1/[Pane]propertyGridControlPanel|$propertyGridControlPanel|#1/[Table]$propertyGridControl|#1/[Pane]$FindControlCore|#1/[Pane]Find Panel|$rootLayout|#1/[Pane]Find Panel|$findLayoutControl|#1/[TextField]$teFind|#1/[TextField]#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(TextField3TF);

            ClearPB = new PushButton()
            {
                Tag = "[Pane]$propertyGridDockPanel1_Container|#1/[Pane]$XRDesignPropertyGrid|#1/[Pane]$PropertyGridUserControl|#2/[Pane]The XtraLayoutControl|$layoutControl|#1/[Pane]propertyGridControlPanel|$propertyGridControlPanel|#1/[Table]$propertyGridControl|#1/[Pane]$FindControlCore|#1/[Pane]Find Panel|$rootLayout|#1/[Pane]Find Panel|$findLayoutControl|#1/[TextField]$teFind|#1/[PushButton]Clear|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ClearPB);

            BackgroundImage2WINsearch = new CustomWin()
            {
                Tag = "[Pane]$propertyGridDockPanel1_Container|#1/[Pane]$XRDesignPropertyGrid|#1/[Pane]$PropertyGridUserControl|#2/[Pane]The XtraLayoutControl|$layoutControl|#1/[Pane]propertyGridControlPanel|$propertyGridControlPanel|#1/[Table]$propertyGridControl|#1/[CustomWin]Data Panel|#1/[CustomWin]#1/[CustomWin]Background Image|#3",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(BackgroundImage2WINsearch);

            ImageWINSearch = new CustomWin()
            {
                Tag = "[Pane]$propertyGridDockPanel1_Container|#1/[Pane]$XRDesignPropertyGrid|#1/[Pane]$PropertyGridUserControl|#2/[Pane]The XtraLayoutControl|$layoutControl|#1/[Pane]propertyGridControlPanel|$propertyGridControlPanel|#1/[Table]$propertyGridControl|#1/[CustomWin]Data Panel|#1/[CustomWin]#1/[CustomWin]Image|#4",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ImageWINSearch);

            ImageWINSearchKOR = new CustomWin()
            {
                Tag = "[Pane]$propertyGridDockPanel1_Container|#1/[Pane]$XRDesignPropertyGrid|#1/[Pane]$PropertyGridUserControl|#2/[Pane]$layoutControl|#1/[Pane]$propertyGridControlPanel|#1/[Table]$propertyGridControl|#1/[CustomWin]#1/[CustomWin]#1/[CustomWin]#5",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ImageWINSearchKOR);

            ImageWINSearchCHS = new CustomWin()
            {
                Tag = "[Pane]$propertyGridDockPanel1_Container|#1/[Pane]$XRDesignPropertyGrid|#1/[Pane]$PropertyGridUserControl|#2/[Pane]$layoutControl|#1/[Pane]$propertyGridControlPanel|#1/[Table]$propertyGridControl|#1/[CustomWin]#1/[CustomWin]#1/[CustomWin]#6",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ImageWINSearchCHS);

            ImageWINSearchDEU = new CustomWin()
            {
                Tag = "[Pane]$propertyGridDockPanel1_Container|#1/[Pane]$XRDesignPropertyGrid|#1/[Pane]$PropertyGridUserControl|#2/[Pane]$layoutControl|#1/[Pane]$propertyGridControlPanel|#1/[Table]$propertyGridControl|#1/[CustomWin]#1/[CustomWin]#1/[CustomWin]#5",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ImageWINSearchDEU);
        }
    }
}
