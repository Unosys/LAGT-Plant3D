// This file is auto-generated - do not hand edit this file.

using Autodesk.GUIHarness;
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{

    [UIElement(Tag = "[Pane]Data Source Wizard|$WizardView")]
    public partial class DataSourceWizardDLG : Autodesk.GUIHarness.AutoCAD.AcDialogBox
    {
        public  RadioButton NoRB;
        public  RadioButton YesRB;
        public  PushButton ClosePB;
        public  PushButton PreviousPB;
        public  PushButton NextPB;
        public  PushButton FinishPB;
        public  ListBox ListBox2LB;
        public  ListBoxItem EntityFrameworkLBI;
        public  ListBoxItem ObjectLBI;
        public  ListBoxItem ExcelFileLBI;
        public  ListBoxItem JSONLBI;
        public  ListBoxItem DataFederationLBI;
        public  ListBoxItem MicrosoftSQLServerLBI;
        public  ListBoxItem MicrosoftAccess97LBI;
        public  ListBoxItem MicrosoftAccess2007LBI;
        public  ListBoxItem MicrosoftSQLServerCELBI;
        public  ListBoxItem OracleLBI;
        public  ListBoxItem AmazonRedshiftLBI;
        public  ListBoxItem GoogleBigQueryLBI;
        public  ListBoxItem TeradataLBI;
        public  ListBoxItem FirebirdLBI;
        public  ListBoxItem IBMDB2LBI;
        public  ListBoxItem MySQLLBI;
        public  ListBoxItem PervasivePSQLLBI;
        public  ListBoxItem PostgreSQLLBI;
        public  ListBoxItem SAPHANALBI;
        public  ListBoxItem SAPSybaseAdvantageLBI;
        public  ListBoxItem SAPSybaseASELBI;

        partial void OnInitialize();

        public DataSourceWizardDLG()
        {
            InitializeComponent();
            OnInitialize();
        }

        private void InitializeComponent()
        {

            NoRB = new RadioButton()
            {
                Tag = "[Pane]$ChooseJsonConnectionPageView|#1/[Pane]$layoutControlBase|#1/[Pane]$panelBaseContent|#2/[Pane]$layoutControlContent|#1/[ListBox]$radioGroupCreateNewConnection|#1/[RadioButton]#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(NoRB);

            YesRB = new RadioButton()
            {
                Tag = "[Pane]$ChooseJsonConnectionPageView|#1/[Pane]$layoutControlBase|#1/[Pane]$panelBaseContent|#2/[Pane]$layoutControlContent|#1/[ListBox]$radioGroupCreateNewConnection|#1/[RadioButton]#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(YesRB);

            ClosePB = new PushButton()
            {
                Tag = "[TitleBar]Data Source Wizard|$TitleBar|#1/[PushButton]Close|$Close|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ClosePB);

            PreviousPB = new PushButton()
            {
                Tag = "[Pane]$ChooseDataProviderPageView|#1/[Pane]$layoutControlBase|#1/[PushButton]$buttonPrevious|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(PreviousPB);

            NextPB = new PushButton()
            {
                Tag = "[Pane]$ChooseDataProviderPageView|#1/[Pane]$layoutControlBase|#1/[PushButton]Next|$buttonNext|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(NextPB);

            FinishPB = new PushButton()
            {
                Tag = "[Pane]$ChooseDataProviderPageView|#1/[Pane]$layoutControlBase|#1/[PushButton]Finish|$buttonFinish|#3",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(FinishPB);

            ListBox2LB = new ListBox()
            {
                Tag = "[Pane]$ChooseDataProviderPageView|#1/[Pane]$layoutControlBase|#1/[Pane]$panelBaseContent|#2/[Pane]$layoutControlContent|#1/[ListBox]$galleryDataSourceProviderType|#1/[ListBox]#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ListBox2LB);

            EntityFrameworkLBI = new ListBoxItem()
            {
                Tag = "[Pane]$ChooseDataProviderPageView|#1/[Pane]$layoutControlBase|#1/[Pane]$panelBaseContent|#2/[Pane]$layoutControlContent|#1/[ListBox]$galleryDataSourceProviderType|#1/[ListBox]#1/[ListBoxItem]Entity Framework|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(EntityFrameworkLBI);

            ObjectLBI = new ListBoxItem()
            {
                Tag = "[Pane]$ChooseDataProviderPageView|#1/[Pane]$layoutControlBase|#1/[Pane]$panelBaseContent|#2/[Pane]$layoutControlContent|#1/[ListBox]$galleryDataSourceProviderType|#1/[ListBox]#1/[ListBoxItem]Object|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ObjectLBI);

            ExcelFileLBI = new ListBoxItem()
            {
                Tag = "[Pane]$ChooseDataProviderPageView|#1/[Pane]$layoutControlBase|#1/[Pane]$panelBaseContent|#2/[Pane]$layoutControlContent|#1/[ListBox]$galleryDataSourceProviderType|#1/[ListBox]#1/[ListBoxItem]Excel File|#3",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ExcelFileLBI);

            JSONLBI = new ListBoxItem()
            {
                Tag = "[Pane]$ChooseDataProviderPageView|#1/[Pane]$layoutControlBase|#1/[Pane]$panelBaseContent|#2/[Pane]$layoutControlContent|#1/[ListBox]$galleryDataSourceProviderType|#1/[ListBox]#1/[ListBoxItem]JSON|#4",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(JSONLBI);

            DataFederationLBI = new ListBoxItem()
            {
                Tag = "[Pane]$ChooseDataProviderPageView|#1/[Pane]$layoutControlBase|#1/[Pane]$panelBaseContent|#2/[Pane]$layoutControlContent|#1/[ListBox]$galleryDataSourceProviderType|#1/[ListBox]#1/[ListBoxItem]Data Federation|#5",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(DataFederationLBI);

            MicrosoftSQLServerLBI = new ListBoxItem()
            {
                Tag = "[Pane]$ChooseDataProviderPageView|#1/[Pane]$layoutControlBase|#1/[Pane]$panelBaseContent|#2/[Pane]$layoutControlContent|#1/[ListBox]$galleryDataSourceProviderType|#1/[ListBox]#1/[ListBoxItem]Microsoft SQL Server|#6",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(MicrosoftSQLServerLBI);

            MicrosoftAccess97LBI = new ListBoxItem()
            {
                Tag = "[Pane]$ChooseDataProviderPageView|#1/[Pane]$layoutControlBase|#1/[Pane]$panelBaseContent|#2/[Pane]$layoutControlContent|#1/[ListBox]$galleryDataSourceProviderType|#1/[ListBox]#1/[ListBoxItem]Microsoft Access 97|#7",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(MicrosoftAccess97LBI);

            MicrosoftAccess2007LBI = new ListBoxItem()
            {
                Tag = "[Pane]$ChooseDataProviderPageView|#1/[Pane]$layoutControlBase|#1/[Pane]$panelBaseContent|#2/[Pane]$layoutControlContent|#1/[ListBox]$galleryDataSourceProviderType|#1/[ListBox]#1/[ListBoxItem]Microsoft Access 2007|#8",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(MicrosoftAccess2007LBI);

            MicrosoftSQLServerCELBI = new ListBoxItem()
            {
                Tag = "[Pane]$ChooseDataProviderPageView|#1/[Pane]$layoutControlBase|#1/[Pane]$panelBaseContent|#2/[Pane]$layoutControlContent|#1/[ListBox]$galleryDataSourceProviderType|#1/[ListBox]#1/[ListBoxItem]Microsoft SQL Server CE|#9",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(MicrosoftSQLServerCELBI);

            OracleLBI = new ListBoxItem()
            {
                Tag = "[Pane]$ChooseDataProviderPageView|#1/[Pane]$layoutControlBase|#1/[Pane]$panelBaseContent|#2/[Pane]$layoutControlContent|#1/[ListBox]$galleryDataSourceProviderType|#1/[ListBox]#1/[ListBoxItem]Oracle|#10",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(OracleLBI);

            AmazonRedshiftLBI = new ListBoxItem()
            {
                Tag = "[Pane]$ChooseDataProviderPageView|#1/[Pane]$layoutControlBase|#1/[Pane]$panelBaseContent|#2/[Pane]$layoutControlContent|#1/[ListBox]$galleryDataSourceProviderType|#1/[ListBox]#1/[ListBoxItem]Amazon Redshift|#11",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(AmazonRedshiftLBI);

            GoogleBigQueryLBI = new ListBoxItem()
            {
                Tag = "[Pane]$ChooseDataProviderPageView|#1/[Pane]$layoutControlBase|#1/[Pane]$panelBaseContent|#2/[Pane]$layoutControlContent|#1/[ListBox]$galleryDataSourceProviderType|#1/[ListBox]#1/[ListBoxItem]Google BigQuery|#12",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(GoogleBigQueryLBI);

            TeradataLBI = new ListBoxItem()
            {
                Tag = "[Pane]$ChooseDataProviderPageView|#1/[Pane]$layoutControlBase|#1/[Pane]$panelBaseContent|#2/[Pane]$layoutControlContent|#1/[ListBox]$galleryDataSourceProviderType|#1/[ListBox]#1/[ListBoxItem]Teradata|#13",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(TeradataLBI);

            FirebirdLBI = new ListBoxItem()
            {
                Tag = "[Pane]$ChooseDataProviderPageView|#1/[Pane]$layoutControlBase|#1/[Pane]$panelBaseContent|#2/[Pane]$layoutControlContent|#1/[ListBox]$galleryDataSourceProviderType|#1/[ListBox]#1/[ListBoxItem]Firebird|#14",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(FirebirdLBI);

            IBMDB2LBI = new ListBoxItem()
            {
                Tag = "[Pane]$ChooseDataProviderPageView|#1/[Pane]$layoutControlBase|#1/[Pane]$panelBaseContent|#2/[Pane]$layoutControlContent|#1/[ListBox]$galleryDataSourceProviderType|#1/[ListBox]#1/[ListBoxItem]IBM DB2|#15",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(IBMDB2LBI);

            MySQLLBI = new ListBoxItem()
            {
                Tag = "[Pane]$ChooseDataProviderPageView|#1/[Pane]$layoutControlBase|#1/[Pane]$panelBaseContent|#2/[Pane]$layoutControlContent|#1/[ListBox]$galleryDataSourceProviderType|#1/[ListBox]#1/[ListBoxItem]MySQL|#16",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(MySQLLBI);

            PervasivePSQLLBI = new ListBoxItem()
            {
                Tag = "[Pane]$ChooseDataProviderPageView|#1/[Pane]$layoutControlBase|#1/[Pane]$panelBaseContent|#2/[Pane]$layoutControlContent|#1/[ListBox]$galleryDataSourceProviderType|#1/[ListBox]#1/[ListBoxItem]Pervasive PSQL|#17",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(PervasivePSQLLBI);

            PostgreSQLLBI = new ListBoxItem()
            {
                Tag = "[Pane]$ChooseDataProviderPageView|#1/[Pane]$layoutControlBase|#1/[Pane]$panelBaseContent|#2/[Pane]$layoutControlContent|#1/[ListBox]$galleryDataSourceProviderType|#1/[ListBox]#1/[ListBoxItem]PostgreSQL|#18",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(PostgreSQLLBI);

            SAPHANALBI = new ListBoxItem()
            {
                Tag = "[Pane]$ChooseDataProviderPageView|#1/[Pane]$layoutControlBase|#1/[Pane]$panelBaseContent|#2/[Pane]$layoutControlContent|#1/[ListBox]$galleryDataSourceProviderType|#1/[ListBox]#1/[ListBoxItem]SAP HANA|#19",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(SAPHANALBI);

            SAPSybaseAdvantageLBI = new ListBoxItem()
            {
                Tag = "[Pane]$ChooseDataProviderPageView|#1/[Pane]$layoutControlBase|#1/[Pane]$panelBaseContent|#2/[Pane]$layoutControlContent|#1/[ListBox]$galleryDataSourceProviderType|#1/[ListBox]#1/[ListBoxItem]SAP Sybase Advantage|#20",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(SAPSybaseAdvantageLBI);

            SAPSybaseASELBI = new ListBoxItem()
            {
                Tag = "[Pane]$ChooseDataProviderPageView|#1/[Pane]$layoutControlBase|#1/[Pane]$panelBaseContent|#2/[Pane]$layoutControlContent|#1/[ListBox]$galleryDataSourceProviderType|#1/[ListBox]#1/[ListBoxItem]SAP Sybase ASE|#21",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(SAPSybaseASELBI);
        }
    }
}
