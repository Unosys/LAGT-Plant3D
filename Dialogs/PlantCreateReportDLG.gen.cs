// This file is auto-generated - do not hand edit this file.

using Autodesk.GUIHarness;
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{

    [UIElement(Tag = "[Pane]Create Report|$ReportGenerator|#1", Parent = typeof(Plant3D), GUIType = GuiType.UIA)]
    public partial class PlantCreateReportDLG : Pane
    {
        public  PopupList M_comboBox_ReportType;
        public  PushButton DropDownButton1PB;
        public  PopupList M_comboBox_BasedOn;
        public  PushButton DropDownButton2PB;
        public  PushButton M_btn_Help;
        public  PushButton M_btn_Cancel;
        public  PushButton CreatePB;
        public  Pane PanePANE;
        public  StaticText PoweredByAutoCADPlantST;
        public  PushButton PreviewPB;
        public  GroupBox OutputSettingsGB;
        public  PopupList M_comboBox_FileFormat;
        public  PushButton DropDownButton3PB;
        public  StaticText FileFormatST;
        public  PushButton M_btn_SelectReportsDirectory;
        public  StaticText CUsersAdministratorW7EN1ENUx64VM7AppDataRoamingAutodeskAST;
        public  StaticText FileLocationST;
        public  TextField M_textBox_FileName;
        public  StaticText FileNameST;
        public  StaticText BasedOnST;
        public  StaticText ReportTypeST;
        public  TitleBar CreateReportCTL;
        public  CustomWin SystemMenuBarWIN;
        public  MenuItem SystemMI;
        public  PushButton ClosePB;

        partial void OnInitialize();

        public PlantCreateReportDLG()
        {
            InitializeComponent();
            OnInitialize();
        }

        private void InitializeComponent()
        {

            M_comboBox_ReportType = new PopupList()
            {
                Tag = "[PopupList]Report type:|$m_comboBox_ReportType|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_comboBox_ReportType);

            DropDownButton1PB = new PushButton()
            {
                Tag = "[PopupList]Report type:|$m_comboBox_ReportType|#1/[PushButton]Drop Down Button|$DropDown|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(DropDownButton1PB);

            M_comboBox_BasedOn = new PopupList()
            {
                Tag = "[PopupList]Based on:|$m_comboBox_BasedOn|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_comboBox_BasedOn);

            DropDownButton2PB = new PushButton()
            {
                Tag = "[PopupList]Based on:|$m_comboBox_BasedOn|#2/[PushButton]Drop Down Button|$DropDown|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(DropDownButton2PB);

            M_btn_Help = new PushButton()
            {
                Tag = "[PushButton]Help|$m_btn_Help|#4",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_btn_Help);

            M_btn_Cancel = new PushButton()
            {
                Tag = "[PushButton]Cancel|$m_btn_Cancel|#3",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_btn_Cancel);

            CreatePB = new PushButton()
            {
                Tag = "[PushButton]Create|$m_btn_Create|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(CreatePB);

            PanePANE = new Pane()
            {
                Tag = "[Pane]$panel2|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(PanePANE);

            PoweredByAutoCADPlantST = new StaticText()
            {
                Tag = "[Pane]$panel2|#1/[StaticText]Powered by AutoCAD Plant Report Creator|$label1|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(PoweredByAutoCADPlantST);

            PreviewPB = new PushButton()
            {
                Tag = "[PushButton]Preview|$m_btn_Preview|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(PreviewPB);

            OutputSettingsGB = new GroupBox()
            {
                Tag = "[GroupBox]Output settings|$groupBox1|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(OutputSettingsGB);

            M_comboBox_FileFormat = new PopupList()
            {
                Tag = "[GroupBox]Output settings|$groupBox1|#1/[PopupList]File format:|$m_comboBox_FileFormat|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_comboBox_FileFormat);

            DropDownButton3PB = new PushButton()
            {
                Tag = "[GroupBox]Output settings|$groupBox1|#1/[PopupList]File format:|$m_comboBox_FileFormat|#1/[PushButton]Drop Down Button|$DropDown|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(DropDownButton3PB);

            FileFormatST = new StaticText()
            {
                Tag = "[GroupBox]Output settings|$groupBox1|#1/[StaticText]File format:|$label7|#4",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(FileFormatST);

            M_btn_SelectReportsDirectory = new PushButton()
            {
                Tag = "[GroupBox]Output settings|$groupBox1|#1/[PushButton]**|$m_btn_SelectReportsDirectory|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_btn_SelectReportsDirectory);

            CUsersAdministratorW7EN1ENUx64VM7AppDataRoamingAutodeskAST = new StaticText()
            {
                Tag = "[GroupBox]Output settings|$groupBox1|#1/[StaticText]C:*|$m_label_FileLocation|#3",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(CUsersAdministratorW7EN1ENUx64VM7AppDataRoamingAutodeskAST);

            FileLocationST = new StaticText()
            {
                Tag = "[GroupBox]Output settings|$groupBox1|#1/[StaticText]File location:|$label5|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(FileLocationST);

            M_textBox_FileName = new TextField()
            {
                Tag = "[GroupBox]Output settings|$groupBox1|#1/[TextField]File name:|$m_textBox_FileName|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_textBox_FileName);

            FileNameST = new StaticText()
            {
                Tag = "[GroupBox]Output settings|$groupBox1|#1/[StaticText]File name:|$label4|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(FileNameST);

            BasedOnST = new StaticText()
            {
                Tag = "[StaticText]Based on:|$label3|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(BasedOnST);

            ReportTypeST = new StaticText()
            {
                Tag = "[StaticText]Report type:|$label2|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ReportTypeST);

            CreateReportCTL = new TitleBar()
            {
                Tag = "[TitleBar]Create Report|$TitleBar|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(CreateReportCTL);

            SystemMenuBarWIN = new CustomWin()
            {
                Tag = "[TitleBar]Create Report|$TitleBar|#1/[CustomWin]System Menu Bar|$ReportGenerator|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(SystemMenuBarWIN);

            SystemMI = new MenuItem()
            {
                Tag = "[TitleBar]Create Report|$TitleBar|#1/[CustomWin]System Menu Bar|$ReportGenerator|#1/[MenuItem]System|$Item 1|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(SystemMI);

            ClosePB = new PushButton()
            {
                Tag = "[TitleBar]Create Report|$TitleBar|#1/[PushButton]Close|$Close|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ClosePB);
        }
    }
}
