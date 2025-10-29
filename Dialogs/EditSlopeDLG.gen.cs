// This file is auto-generated - do not hand edit this file.

using Autodesk.GUIHarness;
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{

    [UIElement(Tag = "[Pane]Edit Slope|$PipeSlopeToolDlg|#1", Parent = typeof(Plant3D), GUIType = GuiType.UIA)]
    public partial class EditSlopeDLG : Pane
    {
        public  StaticText StartAndEndPointsST;
        public  StaticText one5000000ST;
        public  PushButton M_bt_help;
        public  StaticText LengthST;
        public  PushButton M_bt_Cancel;
        public  PushButton M_bt_OK;
        public  GroupBox ElevationSettingsGB;
        public  TextField SlopedegreesTF;
        public  TextField RunTF;
        public  TextField RiseTF;
        public  TextField EndElevationTF;
        public  TextField StartElevationTF;
        public  PopupList CalculationPL;
        public  PushButton DropDownButtonPB;
        public  StaticText SlopedegreesST;
        public  StaticText RunST;
        public  StaticText RiseST;
        public  StaticText EndElevationST;
        public  StaticText StartElevationST;
        public  StaticText CalculationST;
        public  Pane LengthPANE;
        public  PushButton M_bt_EndPt;
        public  PushButton M_bt_StaPt;
        public  TitleBar EditSlopeCTL;
        public  CustomWin SystemMenuBarWIN;
        public  MenuItem SystemMI;
        public  PushButton ClosePB;

        partial void OnInitialize();

        public EditSlopeDLG()
        {
            InitializeComponent();
            OnInitialize();
        }

        private void InitializeComponent()
        {

            StartAndEndPointsST = new StaticText()
            {
                Tag = "[StaticText]Start and End Points:|$m_lb_Instruction|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(StartAndEndPointsST);

            one5000000ST = new StaticText()
            {
                Tag = "[StaticText]1500*|$m_lb_length|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(one5000000ST);

            M_bt_help = new PushButton()
            {
                Tag = "[PushButton]Help|$m_bt_help|#5",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_bt_help);

            LengthST = new StaticText()
            {
                Tag = "[StaticText]Length:|$m_lb_Len|#3",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(LengthST);

            M_bt_Cancel = new PushButton()
            {
                Tag = "[PushButton]Cancel|$m_bt_Cancel|#4",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_bt_Cancel);

            M_bt_OK = new PushButton()
            {
                Tag = "[PushButton]OK|$m_bt_OK|#3",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_bt_OK);

            ElevationSettingsGB = new GroupBox()
            {
                Tag = "[GroupBox]Elevation Settings|$m_gb_Elv_Set|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ElevationSettingsGB);

            SlopedegreesTF = new TextField()
            {
                Tag = "[GroupBox]Elevation Settings|$m_gb_Elv_Set|#1/[TextField]Slope(degrees):|$m_tb_Slope|#5",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(SlopedegreesTF);

            RunTF = new TextField()
            {
                Tag = "[GroupBox]Elevation Settings|$m_gb_Elv_Set|#1/[TextField]Run:|$m_tb_Run|#4",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(RunTF);

            RiseTF = new TextField()
            {
                Tag = "[GroupBox]Elevation Settings|$m_gb_Elv_Set|#1/[TextField]Rise:|$m_tb_Rise|#3",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(RiseTF);

            EndElevationTF = new TextField()
            {
                Tag = "[GroupBox]Elevation Settings|$m_gb_Elv_Set|#1/[TextField]End Elevation:|$m_tb_End_Elv|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(EndElevationTF);

            StartElevationTF = new TextField()
            {
                Tag = "[GroupBox]Elevation Settings|$m_gb_Elv_Set|#1/[TextField]Start Elevation:|$m_tb_Sta_Elv|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(StartElevationTF);

            CalculationPL = new PopupList()
            {
                Tag = "[GroupBox]Elevation Settings|$m_gb_Elv_Set|#1/[PopupList]Calculation:|$m_cb_Calculation|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(CalculationPL);

            DropDownButtonPB = new PushButton()
            {
                Tag = "[GroupBox]Elevation Settings|$m_gb_Elv_Set|#1/[PopupList]Calculation:|$m_cb_Calculation|#1/[PushButton]Drop Down Button|$DropDown|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(DropDownButtonPB);

            SlopedegreesST = new StaticText()
            {
                Tag = "[GroupBox]Elevation Settings|$m_gb_Elv_Set|#1/[StaticText]Slope(degrees):|$label6|#6",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(SlopedegreesST);

            RunST = new StaticText()
            {
                Tag = "[GroupBox]Elevation Settings|$m_gb_Elv_Set|#1/[StaticText]Run:|$label5|#5",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(RunST);

            RiseST = new StaticText()
            {
                Tag = "[GroupBox]Elevation Settings|$m_gb_Elv_Set|#1/[StaticText]Rise:|$label4|#4",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(RiseST);

            EndElevationST = new StaticText()
            {
                Tag = "[GroupBox]Elevation Settings|$m_gb_Elv_Set|#1/[StaticText]End Elevation:|$label3|#3",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(EndElevationST);

            StartElevationST = new StaticText()
            {
                Tag = "[GroupBox]Elevation Settings|$m_gb_Elv_Set|#1/[StaticText]Start Elevation:|$label2|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(StartElevationST);

            CalculationST = new StaticText()
            {
                Tag = "[GroupBox]Elevation Settings|$m_gb_Elv_Set|#1/[StaticText]Calculation:|$label1|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(CalculationST);

            LengthPANE = new Pane()
            {
                Tag = "[Pane]Length:|$m_pb_EffectPic|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(LengthPANE);

            M_bt_EndPt = new PushButton()
            {
                Tag = "[PushButton]Length:[1]|$m_bt_EndPt|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_bt_EndPt);

            M_bt_StaPt = new PushButton()
            {
                Tag = "[PushButton]Length:[2]|$m_bt_StaPt|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_bt_StaPt);

            EditSlopeCTL = new TitleBar()
            {
                Tag = "[TitleBar]Edit Slope|$TitleBar|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(EditSlopeCTL);

            SystemMenuBarWIN = new CustomWin()
            {
                Tag = "[TitleBar]Edit Slope|$TitleBar|#1/[CustomWin]System Menu Bar|$PipeSlopeToolDlg|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(SystemMenuBarWIN);

            SystemMI = new MenuItem()
            {
                Tag = "[TitleBar]Edit Slope|$TitleBar|#1/[CustomWin]System Menu Bar|$PipeSlopeToolDlg|#1/[MenuItem]System|$Item 1|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(SystemMI);

            ClosePB = new PushButton()
            {
                Tag = "[TitleBar]Edit Slope|$TitleBar|#1/[PushButton]Close|$Close|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ClosePB);
        }
    }
}
