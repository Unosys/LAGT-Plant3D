// This file is auto-generated - do not hand edit this file.

using Autodesk.GUIHarness;
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{

    [UIElement(Tag = "[Pane]$ControlAxSourcingSite", Parent = typeof(CustomWin), GUIType = GuiType.UIA)]
    public partial class PlantCustomParts : Autodesk.GUIHarness.AutoCAD.AcDialogBox
    {
        public  Pane Pane1PANE;
        public  CustomWin CustomWin1WIN;
        public  CustomWin CustomWin2WIN;
        public  StaticText PartType1ST;
        public  StaticText PartType2ST;
        public  ComboBox PartTypeCB;
        public  GroupBox GraphicsGB;
        public  StaticText GraphicsST;
        public  PageList PageListPG;
        public  Window Plant3DShapeWIN;
        public  StaticText Plant3DShapeST;
        public  Image Image1IMG;
        public  PushButton ShapeBrowserPB;
        public  Window AutoCADBlockWIN;
        public  StaticText AutoCADBlockST;
        public  Pane Pane2PANE;
        public  StaticText PartPropertiesST;
        public  Image Image2IMG;
        public  Pane Pane3PANE;
        public  StaticText CustomPartType1ST;
        public  StaticText CustomPartType2ST;
        public  ComboBox CustomPartTypeCB;
        public  StaticText Unit1ST;
        public  StaticText Unit2ST;
        public  ComboBox UnitCB;
        public  StaticText Size1ST;
        public  StaticText Size2ST;
        public  ComboBox SizeCB;
        public  StaticText Spec1ST;
        public  StaticText Spec2ST;
        public  ComboBox SpecCB;
        public  StaticText Tag1ST;
        public  StaticText Tag2ST;
        public  ComboBox TagCB;
        public  StaticText IsoSymbolSKEY1ST;
        public  StaticText IsoSymbolSKEY2ST;
        public  TextField IsoSymbolSKEYTF;
        public  Pane Pane4PANE;
        public  StaticText IsoSymbolType1ST;
        public  StaticText IsoSymbolType2ST;
        public  TextField IsoSymbolTypeTF;
        public  Pane Pane5PANE;
        public  StaticText PortPropertiesST;
        public  Image Image3IMG;
        public  Pane Pane6PANE;
        public  StaticText NumberOfPorts1ST;
        public  StaticText NumberOfPorts2ST;
        public  ComboBox NumberOfPortsCB;
        public  StaticText AllPortsAreThe1ST;
        public  StaticText AllPortsAreThe2ST;
        public  CheckBox CheckBoxCK;
        public  StaticText PortName1ST;
        public  StaticText PortName2ST;
        public  ComboBox PortNameCB;
        public  StaticText NominalDiameter1ST;
        public  StaticText NominalDiameter2ST;
        public  ComboBox NominalDiameterCB;
        public  StaticText EndType1ST;
        public  StaticText EndType2ST;
        public  ComboBox EndTypeCB;
        public  StaticText EngagementLength1ST;
        public  StaticText EngagementLength2ST;
        public  TextField EngagementLengthTF;
        public  Pane Pane7PANE;
        public  StaticText Facing1ST;
        public  StaticText Facing2ST;
        public  TextField FacingTF;
        public  Pane Pane8PANE;
        public  StaticText FlangeThickness1ST;
        public  StaticText FlangeThickness2ST;
        public  TextField FlangeThicknessTF;
        public  Pane Pane9PANE;
        public  StaticText PressureClass1ST;
        public  StaticText PressureClass2ST;
        public  TextField PressureClassTF;
        public  Pane Pane10PANE;
        public  StaticText Schedule1ST;
        public  StaticText Schedule2ST;
        public  TextField ScheduleTF;
        public  Pane Pane11PANE;
        public  StaticText WallThickness1ST;
        public  StaticText WallThickness2ST;
        public  TextField WallThicknessTF;
        public  Pane Pane12PANE;
        public  StaticText DimensionsST;
        public  Image Image4IMG;
        public  Pane Pane13PANE;
        public  StaticText D11ST;
        public  StaticText D12ST;
        public  TextField D1TF;
        public  Pane Pane14PANE;
        public  StaticText D21ST;
        public  StaticText D22ST;
        public  TextField D2TF;
        public  Pane Pane15PANE;
        public  StaticText L1ST;
        public  StaticText L2ST;
        public  TextField LTF;
        public  Pane Pane16PANE;
        public  StaticText LS1ST;
        public  StaticText LS2ST;
        public  TextField LSTF;
        public  Pane Pane17PANE;
        public  StaticText H11ST;
        public  StaticText H12ST;
        public  TextField H1TF;
        public  Pane Pane18PANE;
        public  StaticText H21ST;
        public  StaticText H22ST;
        public  TextField H2TF;
        public  Pane Pane19PANE;
        public  StaticText W11ST;
        public  StaticText W12ST;
        public  TextField W1TF;
        public  Pane Pane20PANE;
        public  StaticText W21ST;
        public  StaticText W22ST;
        public  TextField W2TF;
        public  Pane Pane21PANE;
        public  StaticText OF1ST;
        public  StaticText OF2ST;
        public  TextField OFTF;
        public  Pane Pane22PANE;
        public  StaticText B11ST;
        public  StaticText B12ST;
        public  TextField B1TF;
        public  Pane Pane23PANE;
        public  StaticText B21ST;
        public  StaticText B22ST;
        public  TextField B2TF;
        public  Pane Pane24PANE;
        public  StaticText ValveOperatorST;
        public  Image Image5IMG;
        public  Pane Pane25PANE;
        public  StaticText Operator1ST;
        public  StaticText Operator2ST;
        public  ComboBox OperatorCB;
        public  PushButton PushButtonPB;
        public  ScrollBar ScrollBar1SB;
        public  ScrollBar ScrollBar2SB;
        public  PushButton InsertInModelPB;

        partial void OnInitialize();

        public PlantCustomParts()
        {
            InitializeComponent();
            OnInitialize();
        }

        private void InitializeComponent()
        {

            Pane1PANE = new Pane()
            {
                Tag = "[Pane]#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Pane1PANE);

            CustomWin1WIN = new CustomWin()
            {
                Tag = "[Pane]#1/[CustomWin]#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(CustomWin1WIN);

            CustomWin2WIN = new CustomWin()
            {
                Tag = "[Pane]#1/[CustomWin]#1/[CustomWin]$Window_1|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(CustomWin2WIN);

            PartType1ST = new StaticText()
            {
                Tag = "[Pane]#1/[CustomWin]#1/[CustomWin]$Window_1|#1/[StaticText]Part Type:|$dlb_PartClassComboBox|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(PartType1ST);

            PartType2ST = new StaticText()
            {
                Tag = "[Pane]#1/[CustomWin]#1/[CustomWin]$Window_1|#1/[StaticText]Part Type:|$dlb_PartClassComboBox|#1/[StaticText]_Part Type:|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(PartType2ST);

            PartTypeCB = new ComboBox()
            {
                Tag = "[Pane]#1/[CustomWin]#1/[CustomWin]$Window_1|#1/[ComboBox]Part Type:|$dcb_PartClassComboBox|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(PartTypeCB);

            GraphicsGB = new GroupBox()
            {
                Tag = "[Pane]#1/[CustomWin]#1/[CustomWin]$Window_1|#1/[GroupBox]Graphics|$dgb_GeometryType|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(GraphicsGB);

            GraphicsST = new StaticText()
            {
                Tag = "[Pane]#1/[CustomWin]#1/[CustomWin]$Window_1|#1/[GroupBox]Graphics|$dgb_GeometryType|#1/[StaticText]Graphics|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(GraphicsST);

            PageListPG = new PageList()
            {
                Tag = "[Pane]#1/[CustomWin]#1/[CustomWin]$Window_1|#1/[GroupBox]Graphics|$dgb_GeometryType|#1/[PageList]$dtc_GeometryType|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(PageListPG);

            Plant3DShapeWIN = new Window()
            {
                Tag = "[Pane]#1/[CustomWin]#1/[CustomWin]$Window_1|#1/[GroupBox]Graphics|$dgb_GeometryType|#1/[PageList]$dtc_GeometryType|#1/[Window]Plant 3D Shape|$dti_GeometryType_Shape|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Plant3DShapeWIN);

            Plant3DShapeST = new StaticText()
            {
                Tag = "[Pane]#1/[CustomWin]#1/[CustomWin]$Window_1|#1/[GroupBox]Graphics|$dgb_GeometryType|#1/[PageList]$dtc_GeometryType|#1/[Window]Plant 3D Shape|$dti_GeometryType_Shape|#1/[StaticText]Plant _3D Shape|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Plant3DShapeST);

            Image1IMG = new Image()
            {
                Tag = "[Pane]#1/[CustomWin]#1/[CustomWin]$Window_1|#1/[GroupBox]Graphics|$dgb_GeometryType|#1/[PageList]$dtc_GeometryType|#1/[Window]Plant 3D Shape|$dti_GeometryType_Shape|#1/[Image]$dim_Preview_Shape|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Image1IMG);

            ShapeBrowserPB = new PushButton()
            {
                Tag = "[Pane]#1/[CustomWin]#1/[CustomWin]$Window_1|#1/[GroupBox]Graphics|$dgb_GeometryType|#1/[PageList]$dtc_GeometryType|#1/[Window]Plant 3D Shape|$dti_GeometryType_Shape|#1/[PushButton]Shape Browser*|$dbt_ShapeBrowser|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ShapeBrowserPB);

            AutoCADBlockWIN = new Window()
            {
                Tag = "[Pane]#1/[CustomWin]#1/[CustomWin]$Window_1|#1/[GroupBox]Graphics|$dgb_GeometryType|#1/[PageList]$dtc_GeometryType|#1/[Window]AutoCAD Block|$dti_GeometryType_Block|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(AutoCADBlockWIN);

            AutoCADBlockST = new StaticText()
            {
                Tag = "[Pane]#1/[CustomWin]#1/[CustomWin]$Window_1|#1/[GroupBox]Graphics|$dgb_GeometryType|#1/[PageList]$dtc_GeometryType|#1/[Window]AutoCAD Block|$dti_GeometryType_Block|#2/[StaticText]_AutoCAD Block|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(AutoCADBlockST);

            Pane2PANE = new Pane()
            {
                Tag = "[Pane]#1/[CustomWin]#1/[CustomWin]$Window_1|#1/[Pane]$dsv_MiddleRight|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Pane2PANE);

            PartPropertiesST = new StaticText()
            {
                Tag = "[Pane]#1/[CustomWin]#1/[CustomWin]$Window_1|#1/[Pane]$dsv_MiddleRight|#1/[StaticText]Part Properties|$m_Title|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(PartPropertiesST);

            Image2IMG = new Image()
            {
                Tag = "[Pane]#1/[CustomWin]#1/[CustomWin]$Window_1|#1/[Pane]$dsv_MiddleRight|#1/[Image]$m_Image|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Image2IMG);

            Pane3PANE = new Pane()
            {
                Tag = "[Pane]#1/[CustomWin]#1/[CustomWin]$Window_1|#1/[Pane]$dsv_MiddleRight|#1/[Pane]$ScrollViewer_9|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Pane3PANE);

            CustomPartType1ST = new StaticText()
            {
                Tag = "[Pane]#1/[CustomWin]#1/[CustomWin]$Window_1|#1/[Pane]$dsv_MiddleRight|#1/[Pane]$ScrollViewer_9|#1/[StaticText]Custom Part Type|$dlb_pp_CustomPartType|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(CustomPartType1ST);

            CustomPartType2ST = new StaticText()
            {
                Tag = "[Pane]#1/[CustomWin]#1/[CustomWin]$Window_1|#1/[Pane]$dsv_MiddleRight|#1/[Pane]$ScrollViewer_9|#1/[StaticText]Custom Part Type|$dlb_pp_CustomPartType|#1/[StaticText]Custom Part Type|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(CustomPartType2ST);

            CustomPartTypeCB = new ComboBox()
            {
                Tag = "[Pane]#1/[CustomWin]#1/[CustomWin]$Window_1|#1/[Pane]$dsv_MiddleRight|#1/[Pane]$ScrollViewer_9|#1/[ComboBox]Custom Part Type|$dcb_pp_CustomPartType|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(CustomPartTypeCB);

            Unit1ST = new StaticText()
            {
                Tag = "[Pane]#1/[CustomWin]#1/[CustomWin]$Window_1|#1/[Pane]$dsv_MiddleRight|#1/[Pane]$ScrollViewer_9|#1/[StaticText]Unit|$dlb_pp_shapeGeoUnit|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Unit1ST);

            Unit2ST = new StaticText()
            {
                Tag = "[Pane]#1/[CustomWin]#1/[CustomWin]$Window_1|#1/[Pane]$dsv_MiddleRight|#1/[Pane]$ScrollViewer_9|#1/[StaticText]Unit|$dlb_pp_shapeGeoUnit|#2/[StaticText]Unit|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Unit2ST);

            UnitCB = new ComboBox()
            {
                Tag = "[Pane]#1/[CustomWin]#1/[CustomWin]$Window_1|#1/[Pane]$dsv_MiddleRight|#1/[Pane]$ScrollViewer_9|#1/[ComboBox]Unit|$dcb_pp_shapeGeoUnit|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(UnitCB);

            Size1ST = new StaticText()
            {
                Tag = "[Pane]#1/[CustomWin]#1/[CustomWin]$Window_1|#1/[Pane]$dsv_MiddleRight|#1/[Pane]$ScrollViewer_9|#1/[StaticText]Size|$dlb_pp_shapeSize|#3",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Size1ST);

            Size2ST = new StaticText()
            {
                Tag = "[Pane]#1/[CustomWin]#1/[CustomWin]$Window_1|#1/[Pane]$dsv_MiddleRight|#1/[Pane]$ScrollViewer_9|#1/[StaticText]Size|$dlb_pp_shapeSize|#3/[StaticText]Size|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Size2ST);

            SizeCB = new ComboBox()
            {
                Tag = "[Pane]#1/[CustomWin]#1/[CustomWin]$Window_1|#1/[Pane]$dsv_MiddleRight|#1/[Pane]$ScrollViewer_9|#1/[ComboBox]Size|$dcb_pp_shapeSize|#3",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(SizeCB);

            Spec1ST = new StaticText()
            {
                Tag = "[Pane]#1/[CustomWin]#1/[CustomWin]$Window_1|#1/[Pane]$dsv_MiddleRight|#1/[Pane]$ScrollViewer_9|#1/[StaticText]Spec|$dlb_pp_RequiredSpecList|#4",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Spec1ST);

            Spec2ST = new StaticText()
            {
                Tag = "[Pane]#1/[CustomWin]#1/[CustomWin]$Window_1|#1/[Pane]$dsv_MiddleRight|#1/[Pane]$ScrollViewer_9|#1/[StaticText]Spec|$dlb_pp_RequiredSpecList|#4/[StaticText]Spec|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Spec2ST);

            SpecCB = new ComboBox()
            {
                Tag = "[Pane]#1/[CustomWin]#1/[CustomWin]$Window_1|#1/[Pane]$dsv_MiddleRight|#1/[Pane]$ScrollViewer_9|#1/[ComboBox]Spec|$dcb_pp_RequiredSpecList|#4",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(SpecCB);

            Tag1ST = new StaticText()
            {
                Tag = "[Pane]#1/[CustomWin]#1/[CustomWin]$Window_1|#1/[Pane]$dsv_MiddleRight|#1/[Pane]$ScrollViewer_9|#1/[StaticText]Tag|$dlb_pp_shapeTag|#5",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Tag1ST);

            Tag2ST = new StaticText()
            {
                Tag = "[Pane]#1/[CustomWin]#1/[CustomWin]$Window_1|#1/[Pane]$dsv_MiddleRight|#1/[Pane]$ScrollViewer_9|#1/[StaticText]Tag|$dlb_pp_shapeTag|#5/[StaticText]Tag|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Tag2ST);

            TagCB = new ComboBox()
            {
                Tag = "[Pane]#1/[CustomWin]#1/[CustomWin]$Window_1|#1/[Pane]$dsv_MiddleRight|#1/[Pane]$ScrollViewer_9|#1/[ComboBox]Tag|$dcb_pp_shapeTag|#5",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(TagCB);

            IsoSymbolSKEY1ST = new StaticText()
            {
                Tag = "[Pane]#1/[CustomWin]#1/[CustomWin]$Window_1|#1/[Pane]$dsv_MiddleRight|#1/[Pane]$ScrollViewer_9|#1/[StaticText]Iso Symbol SKEY|$dlb_pp_isoSkey|#6",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(IsoSymbolSKEY1ST);

            IsoSymbolSKEY2ST = new StaticText()
            {
                Tag = "[Pane]#1/[CustomWin]#1/[CustomWin]$Window_1|#1/[Pane]$dsv_MiddleRight|#1/[Pane]$ScrollViewer_9|#1/[StaticText]Iso Symbol SKEY|$dlb_pp_isoSkey|#6/[StaticText]Iso Symbol SKEY|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(IsoSymbolSKEY2ST);

            IsoSymbolSKEYTF = new TextField()
            {
                Tag = "[Pane]#1/[CustomWin]#1/[CustomWin]$Window_1|#1/[Pane]$dsv_MiddleRight|#1/[Pane]$ScrollViewer_9|#1/[TextField]Iso Symbol SKEY|$dcb_pp_isoSkey|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(IsoSymbolSKEYTF);

            Pane4PANE = new Pane()
            {
                Tag = "[Pane]#1/[CustomWin]#1/[CustomWin]$Window_1|#1/[Pane]$dsv_MiddleRight|#1/[Pane]$ScrollViewer_9|#1/[TextField]Iso Symbol SKEY|$dcb_pp_isoSkey|#1/[Pane]$PART_ContentHost|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Pane4PANE);

            IsoSymbolType1ST = new StaticText()
            {
                Tag = "[Pane]#1/[CustomWin]#1/[CustomWin]$Window_1|#1/[Pane]$dsv_MiddleRight|#1/[Pane]$ScrollViewer_9|#1/[StaticText]Iso Symbol Type|$dlb_pp_isoType|#7",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(IsoSymbolType1ST);

            IsoSymbolType2ST = new StaticText()
            {
                Tag = "[Pane]#1/[CustomWin]#1/[CustomWin]$Window_1|#1/[Pane]$dsv_MiddleRight|#1/[Pane]$ScrollViewer_9|#1/[StaticText]Iso Symbol Type|$dlb_pp_isoType|#7/[StaticText]Iso Symbol Type|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(IsoSymbolType2ST);

            IsoSymbolTypeTF = new TextField()
            {
                Tag = "[Pane]#1/[CustomWin]#1/[CustomWin]$Window_1|#1/[Pane]$dsv_MiddleRight|#1/[Pane]$ScrollViewer_9|#1/[TextField]Iso Symbol Type|$dcb_pp_isoType|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(IsoSymbolTypeTF);

            Pane5PANE = new Pane()
            {
                Tag = "[Pane]#1/[CustomWin]#1/[CustomWin]$Window_1|#1/[Pane]$dsv_MiddleRight|#1/[Pane]$ScrollViewer_9|#1/[TextField]Iso Symbol Type|$dcb_pp_isoType|#2/[Pane]$PART_ContentHost|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Pane5PANE);

            PortPropertiesST = new StaticText()
            {
                Tag = "[Pane]#1/[CustomWin]#1/[CustomWin]$Window_1|#1/[Pane]$dsv_MiddleRight|#1/[StaticText]Port Properties|$m_Title|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(PortPropertiesST);

            Image3IMG = new Image()
            {
                Tag = "[Pane]#1/[CustomWin]#1/[CustomWin]$Window_1|#1/[Pane]$dsv_MiddleRight|#1/[Image]$m_Image|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Image3IMG);

            Pane6PANE = new Pane()
            {
                Tag = "[Pane]#1/[CustomWin]#1/[CustomWin]$Window_1|#1/[Pane]$dsv_MiddleRight|#1/[Pane]$ScrollViewer_9|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Pane6PANE);

            NumberOfPorts1ST = new StaticText()
            {
                Tag = "[Pane]#1/[CustomWin]#1/[CustomWin]$Window_1|#1/[Pane]$dsv_MiddleRight|#1/[Pane]$ScrollViewer_9|#2/[StaticText]Number of ports|$dlb_pp_NumberOfPorts|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(NumberOfPorts1ST);

            NumberOfPorts2ST = new StaticText()
            {
                Tag = "[Pane]#1/[CustomWin]#1/[CustomWin]$Window_1|#1/[Pane]$dsv_MiddleRight|#1/[Pane]$ScrollViewer_9|#2/[StaticText]Number of ports|$dlb_pp_NumberOfPorts|#1/[StaticText]Number of ports|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(NumberOfPorts2ST);

            NumberOfPortsCB = new ComboBox()
            {
                Tag = "[Pane]#1/[CustomWin]#1/[CustomWin]$Window_1|#1/[Pane]$dsv_MiddleRight|#1/[Pane]$ScrollViewer_9|#2/[ComboBox]Number of ports|$dcb_pp_NumberOfPorts|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(NumberOfPortsCB);

            AllPortsAreThe1ST = new StaticText()
            {
                Tag = "[Pane]#1/[CustomWin]#1/[CustomWin]$Window_1|#1/[Pane]$dsv_MiddleRight|#1/[Pane]$ScrollViewer_9|#2/[StaticText]All Ports are the same|$dlb_pp_SetAllSame|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(AllPortsAreThe1ST);

            AllPortsAreThe2ST = new StaticText()
            {
                Tag = "[Pane]#1/[CustomWin]#1/[CustomWin]$Window_1|#1/[Pane]$dsv_MiddleRight|#1/[Pane]$ScrollViewer_9|#2/[StaticText]All Ports are the same|$dlb_pp_SetAllSame|#2/[StaticText]All Ports are the same|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(AllPortsAreThe2ST);

            CheckBoxCK = new CheckBox()
            {
                Tag = "[Pane]#1/[CustomWin]#1/[CustomWin]$Window_1|#1/[Pane]$dsv_MiddleRight|#1/[Pane]$ScrollViewer_9|#2/[CheckBox]$dcp_pp_SetAllSame|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(CheckBoxCK);

            PortName1ST = new StaticText()
            {
                Tag = "[Pane]#1/[CustomWin]#1/[CustomWin]$Window_1|#1/[Pane]$dsv_MiddleRight|#1/[Pane]$ScrollViewer_9|#2/[StaticText]Port Name|$dlb_pp_PortName|#3",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(PortName1ST);

            PortName2ST = new StaticText()
            {
                Tag = "[Pane]#1/[CustomWin]#1/[CustomWin]$Window_1|#1/[Pane]$dsv_MiddleRight|#1/[Pane]$ScrollViewer_9|#2/[StaticText]Port Name|$dlb_pp_PortName|#3/[StaticText]Port Name|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(PortName2ST);

            PortNameCB = new ComboBox()
            {
                Tag = "[Pane]#1/[CustomWin]#1/[CustomWin]$Window_1|#1/[Pane]$dsv_MiddleRight|#1/[Pane]$ScrollViewer_9|#2/[ComboBox]Port Name|$dcb_pp_PortName|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(PortNameCB);

            NominalDiameter1ST = new StaticText()
            {
                Tag = "[Pane]#1/[CustomWin]#1/[CustomWin]$Window_1|#1/[Pane]$dsv_MiddleRight|#1/[Pane]$ScrollViewer_9|#2/[StaticText]Nominal Diameter|$dlb_pp_portNominalDiameter|#4",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(NominalDiameter1ST);

            NominalDiameter2ST = new StaticText()
            {
                Tag = "[Pane]#1/[CustomWin]#1/[CustomWin]$Window_1|#1/[Pane]$dsv_MiddleRight|#1/[Pane]$ScrollViewer_9|#2/[StaticText]Nominal Diameter|$dlb_pp_portNominalDiameter|#4/[StaticText]Nominal Diameter|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(NominalDiameter2ST);

            NominalDiameterCB = new ComboBox()
            {
                Tag = "[Pane]#1/[CustomWin]#1/[CustomWin]$Window_1|#1/[Pane]$dsv_MiddleRight|#1/[Pane]$ScrollViewer_9|#2/[ComboBox]Nominal Diameter|$dcb_pp_portNominalDiameter|#3",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(NominalDiameterCB);

            EndType1ST = new StaticText()
            {
                Tag = "[Pane]#1/[CustomWin]#1/[CustomWin]$Window_1|#1/[Pane]$dsv_MiddleRight|#1/[Pane]$ScrollViewer_9|#2/[StaticText]End Type|$dlb_pp_portEndType|#5",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(EndType1ST);

            EndType2ST = new StaticText()
            {
                Tag = "[Pane]#1/[CustomWin]#1/[CustomWin]$Window_1|#1/[Pane]$dsv_MiddleRight|#1/[Pane]$ScrollViewer_9|#2/[StaticText]End Type|$dlb_pp_portEndType|#5/[StaticText]End Type|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(EndType2ST);

            EndTypeCB = new ComboBox()
            {
                Tag = "[Pane]#1/[CustomWin]#1/[CustomWin]$Window_1|#1/[Pane]$dsv_MiddleRight|#1/[Pane]$ScrollViewer_9|#2/[ComboBox]End Type|$dcb_pp_portEndType|#4",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(EndTypeCB);

            EngagementLength1ST = new StaticText()
            {
                Tag = "[Pane]#1/[CustomWin]#1/[CustomWin]$Window_1|#1/[Pane]$dsv_MiddleRight|#1/[Pane]$ScrollViewer_9|#2/[StaticText]Engagement Length|$dlb_pp_portEngagementLength|#6",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(EngagementLength1ST);

            EngagementLength2ST = new StaticText()
            {
                Tag = "[Pane]#1/[CustomWin]#1/[CustomWin]$Window_1|#1/[Pane]$dsv_MiddleRight|#1/[Pane]$ScrollViewer_9|#2/[StaticText]Engagement Length|$dlb_pp_portEngagementLength|#6/[StaticText]Engagement Length|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(EngagementLength2ST);

            EngagementLengthTF = new TextField()
            {
                Tag = "[Pane]#1/[CustomWin]#1/[CustomWin]$Window_1|#1/[Pane]$dsv_MiddleRight|#1/[Pane]$ScrollViewer_9|#2/[TextField]Engagement Length|$dtb_pp_portEngagementLength|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(EngagementLengthTF);

            Pane7PANE = new Pane()
            {
                Tag = "[Pane]#1/[CustomWin]#1/[CustomWin]$Window_1|#1/[Pane]$dsv_MiddleRight|#1/[Pane]$ScrollViewer_9|#2/[TextField]Engagement Length|$dtb_pp_portEngagementLength|#1/[Pane]$PART_ContentHost|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Pane7PANE);

            Facing1ST = new StaticText()
            {
                Tag = "[Pane]#1/[CustomWin]#1/[CustomWin]$Window_1|#1/[Pane]$dsv_MiddleRight|#1/[Pane]$ScrollViewer_9|#2/[StaticText]Facing|$dlb_pp_portFacing|#7",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Facing1ST);

            Facing2ST = new StaticText()
            {
                Tag = "[Pane]#1/[CustomWin]#1/[CustomWin]$Window_1|#1/[Pane]$dsv_MiddleRight|#1/[Pane]$ScrollViewer_9|#2/[StaticText]Facing|$dlb_pp_portFacing|#7/[StaticText]Facing|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Facing2ST);

            FacingTF = new TextField()
            {
                Tag = "[Pane]#1/[CustomWin]#1/[CustomWin]$Window_1|#1/[Pane]$dsv_MiddleRight|#1/[Pane]$ScrollViewer_9|#2/[TextField]Facing|$dtb_pp_portFacing|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(FacingTF);

            Pane8PANE = new Pane()
            {
                Tag = "[Pane]#1/[CustomWin]#1/[CustomWin]$Window_1|#1/[Pane]$dsv_MiddleRight|#1/[Pane]$ScrollViewer_9|#2/[TextField]Facing|$dtb_pp_portFacing|#2/[Pane]$PART_ContentHost|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Pane8PANE);

            FlangeThickness1ST = new StaticText()
            {
                Tag = "[Pane]#1/[CustomWin]#1/[CustomWin]$Window_1|#1/[Pane]$dsv_MiddleRight|#1/[Pane]$ScrollViewer_9|#2/[StaticText]Flange Thickness|$dlb_pp_portFlangeThickness|#8",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(FlangeThickness1ST);

            FlangeThickness2ST = new StaticText()
            {
                Tag = "[Pane]#1/[CustomWin]#1/[CustomWin]$Window_1|#1/[Pane]$dsv_MiddleRight|#1/[Pane]$ScrollViewer_9|#2/[StaticText]Flange Thickness|$dlb_pp_portFlangeThickness|#8/[StaticText]Flange Thickness|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(FlangeThickness2ST);

            FlangeThicknessTF = new TextField()
            {
                Tag = "[Pane]#1/[CustomWin]#1/[CustomWin]$Window_1|#1/[Pane]$dsv_MiddleRight|#1/[Pane]$ScrollViewer_9|#2/[TextField]Flange Thickness|$dtb_pp_portFlangeThickness|#3",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(FlangeThicknessTF);

            Pane9PANE = new Pane()
            {
                Tag = "[Pane]#1/[CustomWin]#1/[CustomWin]$Window_1|#1/[Pane]$dsv_MiddleRight|#1/[Pane]$ScrollViewer_9|#2/[TextField]Flange Thickness|$dtb_pp_portFlangeThickness|#3/[Pane]$PART_ContentHost|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Pane9PANE);

            PressureClass1ST = new StaticText()
            {
                Tag = "[Pane]#1/[CustomWin]#1/[CustomWin]$Window_1|#1/[Pane]$dsv_MiddleRight|#1/[Pane]$ScrollViewer_9|#2/[StaticText]Pressure Class|$dlb_pp_portPressureClass|#9",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(PressureClass1ST);

            PressureClass2ST = new StaticText()
            {
                Tag = "[Pane]#1/[CustomWin]#1/[CustomWin]$Window_1|#1/[Pane]$dsv_MiddleRight|#1/[Pane]$ScrollViewer_9|#2/[StaticText]Pressure Class|$dlb_pp_portPressureClass|#9/[StaticText]Pressure Class|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(PressureClass2ST);

            PressureClassTF = new TextField()
            {
                Tag = "[Pane]#1/[CustomWin]#1/[CustomWin]$Window_1|#1/[Pane]$dsv_MiddleRight|#1/[Pane]$ScrollViewer_9|#2/[TextField]Pressure Class|$dtb_pp_portPressureClass|#4",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(PressureClassTF);

            Pane10PANE = new Pane()
            {
                Tag = "[Pane]#1/[CustomWin]#1/[CustomWin]$Window_1|#1/[Pane]$dsv_MiddleRight|#1/[Pane]$ScrollViewer_9|#2/[TextField]Pressure Class|$dtb_pp_portPressureClass|#4/[Pane]$PART_ContentHost|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Pane10PANE);

            Schedule1ST = new StaticText()
            {
                Tag = "[Pane]#1/[CustomWin]#1/[CustomWin]$Window_1|#1/[Pane]$dsv_MiddleRight|#1/[Pane]$ScrollViewer_9|#2/[StaticText]Schedule|$dlb_pp_portSchedule|#10",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Schedule1ST);

            Schedule2ST = new StaticText()
            {
                Tag = "[Pane]#1/[CustomWin]#1/[CustomWin]$Window_1|#1/[Pane]$dsv_MiddleRight|#1/[Pane]$ScrollViewer_9|#2/[StaticText]Schedule|$dlb_pp_portSchedule|#10/[StaticText]Schedule|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Schedule2ST);

            ScheduleTF = new TextField()
            {
                Tag = "[Pane]#1/[CustomWin]#1/[CustomWin]$Window_1|#1/[Pane]$dsv_MiddleRight|#1/[Pane]$ScrollViewer_9|#2/[TextField]Schedule|$dtb_pp_portSchedule|#5",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ScheduleTF);

            Pane11PANE = new Pane()
            {
                Tag = "[Pane]#1/[CustomWin]#1/[CustomWin]$Window_1|#1/[Pane]$dsv_MiddleRight|#1/[Pane]$ScrollViewer_9|#2/[TextField]Schedule|$dtb_pp_portSchedule|#5/[Pane]$PART_ContentHost|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Pane11PANE);

            WallThickness1ST = new StaticText()
            {
                Tag = "[Pane]#1/[CustomWin]#1/[CustomWin]$Window_1|#1/[Pane]$dsv_MiddleRight|#1/[Pane]$ScrollViewer_9|#2/[StaticText]Wall Thickness|$dlb_pp_portWallThickness|#11",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(WallThickness1ST);

            WallThickness2ST = new StaticText()
            {
                Tag = "[Pane]#1/[CustomWin]#1/[CustomWin]$Window_1|#1/[Pane]$dsv_MiddleRight|#1/[Pane]$ScrollViewer_9|#2/[StaticText]Wall Thickness|$dlb_pp_portWallThickness|#11/[StaticText]Wall Thickness|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(WallThickness2ST);

            WallThicknessTF = new TextField()
            {
                Tag = "[Pane]#1/[CustomWin]#1/[CustomWin]$Window_1|#1/[Pane]$dsv_MiddleRight|#1/[Pane]$ScrollViewer_9|#2/[TextField]Wall Thickness|$dtb_pp_portWallThickness|#6",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(WallThicknessTF);

            Pane12PANE = new Pane()
            {
                Tag = "[Pane]#1/[CustomWin]#1/[CustomWin]$Window_1|#1/[Pane]$dsv_MiddleRight|#1/[Pane]$ScrollViewer_9|#2/[TextField]Wall Thickness|$dtb_pp_portWallThickness|#6/[Pane]$PART_ContentHost|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Pane12PANE);

            DimensionsST = new StaticText()
            {
                Tag = "[Pane]#1/[CustomWin]#1/[CustomWin]$Window_1|#1/[Pane]$dsv_MiddleRight|#1/[StaticText]Dimensions|$m_Title|#3",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(DimensionsST);

            Image4IMG = new Image()
            {
                Tag = "[Pane]#1/[CustomWin]#1/[CustomWin]$Window_1|#1/[Pane]$dsv_MiddleRight|#1/[Image]$m_Image|#3",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Image4IMG);

            Pane13PANE = new Pane()
            {
                Tag = "[Pane]#1/[CustomWin]#1/[CustomWin]$Window_1|#1/[Pane]$dsv_MiddleRight|#1/[Pane]$ScrollViewer_9|#3",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Pane13PANE);

            D11ST = new StaticText()
            {
                Tag = "[Pane]#1/[CustomWin]#1/[CustomWin]$Window_1|#1/[Pane]$dsv_MiddleRight|#1/[Pane]$ScrollViewer_9|#3/[StaticText]D1|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(D11ST);

            D12ST = new StaticText()
            {
                Tag = "[Pane]#1/[CustomWin]#1/[CustomWin]$Window_1|#1/[Pane]$dsv_MiddleRight|#1/[Pane]$ScrollViewer_9|#3/[StaticText]D1|#1/[StaticText]D1|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(D12ST);

            D1TF = new TextField()
            {
                Tag = "[Pane]#1/[CustomWin]#1/[CustomWin]$Window_1|#1/[Pane]$dsv_MiddleRight|#1/[Pane]$ScrollViewer_9|#3/[TextField]D1|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(D1TF);

            Pane14PANE = new Pane()
            {
                Tag = "[Pane]#1/[CustomWin]#1/[CustomWin]$Window_1|#1/[Pane]$dsv_MiddleRight|#1/[Pane]$ScrollViewer_9|#3/[TextField]D1|#1/[Pane]$PART_ContentHost|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Pane14PANE);

            D21ST = new StaticText()
            {
                Tag = "[Pane]#1/[CustomWin]#1/[CustomWin]$Window_1|#1/[Pane]$dsv_MiddleRight|#1/[Pane]$ScrollViewer_9|#3/[StaticText]D2|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(D21ST);

            D22ST = new StaticText()
            {
                Tag = "[Pane]#1/[CustomWin]#1/[CustomWin]$Window_1|#1/[Pane]$dsv_MiddleRight|#1/[Pane]$ScrollViewer_9|#3/[StaticText]D2|#2/[StaticText]D2|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(D22ST);

            D2TF = new TextField()
            {
                Tag = "[Pane]#1/[CustomWin]#1/[CustomWin]$Window_1|#1/[Pane]$dsv_MiddleRight|#1/[Pane]$ScrollViewer_9|#3/[TextField]D2|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(D2TF);

            Pane15PANE = new Pane()
            {
                Tag = "[Pane]#1/[CustomWin]#1/[CustomWin]$Window_1|#1/[Pane]$dsv_MiddleRight|#1/[Pane]$ScrollViewer_9|#3/[TextField]D2|#2/[Pane]$PART_ContentHost|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Pane15PANE);

            L1ST = new StaticText()
            {
                Tag = "[Pane]#1/[CustomWin]#1/[CustomWin]$Window_1|#1/[Pane]$dsv_MiddleRight|#1/[Pane]$ScrollViewer_9|#3/[StaticText]L|#3",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(L1ST);

            L2ST = new StaticText()
            {
                Tag = "[Pane]#1/[CustomWin]#1/[CustomWin]$Window_1|#1/[Pane]$dsv_MiddleRight|#1/[Pane]$ScrollViewer_9|#3/[StaticText]L|#3/[StaticText]L|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(L2ST);

            LTF = new TextField()
            {
                Tag = "[Pane]#1/[CustomWin]#1/[CustomWin]$Window_1|#1/[Pane]$dsv_MiddleRight|#1/[Pane]$ScrollViewer_9|#3/[TextField]L|#3",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(LTF);

            Pane16PANE = new Pane()
            {
                Tag = "[Pane]#1/[CustomWin]#1/[CustomWin]$Window_1|#1/[Pane]$dsv_MiddleRight|#1/[Pane]$ScrollViewer_9|#3/[TextField]L|#3/[Pane]$PART_ContentHost|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Pane16PANE);

            LS1ST = new StaticText()
            {
                Tag = "[Pane]#1/[CustomWin]#1/[CustomWin]$Window_1|#1/[Pane]$dsv_MiddleRight|#1/[Pane]$ScrollViewer_9|#3/[StaticText]LS|#4",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(LS1ST);

            LS2ST = new StaticText()
            {
                Tag = "[Pane]#1/[CustomWin]#1/[CustomWin]$Window_1|#1/[Pane]$dsv_MiddleRight|#1/[Pane]$ScrollViewer_9|#3/[StaticText]LS|#4/[StaticText]LS|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(LS2ST);

            LSTF = new TextField()
            {
                Tag = "[Pane]#1/[CustomWin]#1/[CustomWin]$Window_1|#1/[Pane]$dsv_MiddleRight|#1/[Pane]$ScrollViewer_9|#3/[TextField]LS|#4",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(LSTF);

            Pane17PANE = new Pane()
            {
                Tag = "[Pane]#1/[CustomWin]#1/[CustomWin]$Window_1|#1/[Pane]$dsv_MiddleRight|#1/[Pane]$ScrollViewer_9|#3/[TextField]LS|#4/[Pane]$PART_ContentHost|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Pane17PANE);

            H11ST = new StaticText()
            {
                Tag = "[Pane]#1/[CustomWin]#1/[CustomWin]$Window_1|#1/[Pane]$dsv_MiddleRight|#1/[Pane]$ScrollViewer_9|#3/[StaticText]H1|#5",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(H11ST);

            H12ST = new StaticText()
            {
                Tag = "[Pane]#1/[CustomWin]#1/[CustomWin]$Window_1|#1/[Pane]$dsv_MiddleRight|#1/[Pane]$ScrollViewer_9|#3/[StaticText]H1|#5/[StaticText]H1|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(H12ST);

            H1TF = new TextField()
            {
                Tag = "[Pane]#1/[CustomWin]#1/[CustomWin]$Window_1|#1/[Pane]$dsv_MiddleRight|#1/[Pane]$ScrollViewer_9|#3/[TextField]H1|#5",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(H1TF);

            Pane18PANE = new Pane()
            {
                Tag = "[Pane]#1/[CustomWin]#1/[CustomWin]$Window_1|#1/[Pane]$dsv_MiddleRight|#1/[Pane]$ScrollViewer_9|#3/[TextField]H1|#5/[Pane]$PART_ContentHost|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Pane18PANE);

            H21ST = new StaticText()
            {
                Tag = "[Pane]#1/[CustomWin]#1/[CustomWin]$Window_1|#1/[Pane]$dsv_MiddleRight|#1/[Pane]$ScrollViewer_9|#3/[StaticText]H2|#6",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(H21ST);

            H22ST = new StaticText()
            {
                Tag = "[Pane]#1/[CustomWin]#1/[CustomWin]$Window_1|#1/[Pane]$dsv_MiddleRight|#1/[Pane]$ScrollViewer_9|#3/[StaticText]H2|#6/[StaticText]H2|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(H22ST);

            H2TF = new TextField()
            {
                Tag = "[Pane]#1/[CustomWin]#1/[CustomWin]$Window_1|#1/[Pane]$dsv_MiddleRight|#1/[Pane]$ScrollViewer_9|#3/[TextField]H2|#6",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(H2TF);

            Pane19PANE = new Pane()
            {
                Tag = "[Pane]#1/[CustomWin]#1/[CustomWin]$Window_1|#1/[Pane]$dsv_MiddleRight|#1/[Pane]$ScrollViewer_9|#3/[TextField]H2|#6/[Pane]$PART_ContentHost|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Pane19PANE);

            W11ST = new StaticText()
            {
                Tag = "[Pane]#1/[CustomWin]#1/[CustomWin]$Window_1|#1/[Pane]$dsv_MiddleRight|#1/[Pane]$ScrollViewer_9|#3/[StaticText]W1|#7",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(W11ST);

            W12ST = new StaticText()
            {
                Tag = "[Pane]#1/[CustomWin]#1/[CustomWin]$Window_1|#1/[Pane]$dsv_MiddleRight|#1/[Pane]$ScrollViewer_9|#3/[StaticText]W1|#7/[StaticText]W1|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(W12ST);

            W1TF = new TextField()
            {
                Tag = "[Pane]#1/[CustomWin]#1/[CustomWin]$Window_1|#1/[Pane]$dsv_MiddleRight|#1/[Pane]$ScrollViewer_9|#3/[TextField]W1|#7",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(W1TF);

            Pane20PANE = new Pane()
            {
                Tag = "[Pane]#1/[CustomWin]#1/[CustomWin]$Window_1|#1/[Pane]$dsv_MiddleRight|#1/[Pane]$ScrollViewer_9|#3/[TextField]W1|#7/[Pane]$PART_ContentHost|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Pane20PANE);

            W21ST = new StaticText()
            {
                Tag = "[Pane]#1/[CustomWin]#1/[CustomWin]$Window_1|#1/[Pane]$dsv_MiddleRight|#1/[Pane]$ScrollViewer_9|#3/[StaticText]W2|#8",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(W21ST);

            W22ST = new StaticText()
            {
                Tag = "[Pane]#1/[CustomWin]#1/[CustomWin]$Window_1|#1/[Pane]$dsv_MiddleRight|#1/[Pane]$ScrollViewer_9|#3/[StaticText]W2|#8/[StaticText]W2|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(W22ST);

            W2TF = new TextField()
            {
                Tag = "[Pane]#1/[CustomWin]#1/[CustomWin]$Window_1|#1/[Pane]$dsv_MiddleRight|#1/[Pane]$ScrollViewer_9|#3/[TextField]W2|#8",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(W2TF);

            Pane21PANE = new Pane()
            {
                Tag = "[Pane]#1/[CustomWin]#1/[CustomWin]$Window_1|#1/[Pane]$dsv_MiddleRight|#1/[Pane]$ScrollViewer_9|#3/[TextField]W2|#8/[Pane]$PART_ContentHost|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Pane21PANE);

            OF1ST = new StaticText()
            {
                Tag = "[Pane]#1/[CustomWin]#1/[CustomWin]$Window_1|#1/[Pane]$dsv_MiddleRight|#1/[Pane]$ScrollViewer_9|#3/[StaticText]OF|#9",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(OF1ST);

            OF2ST = new StaticText()
            {
                Tag = "[Pane]#1/[CustomWin]#1/[CustomWin]$Window_1|#1/[Pane]$dsv_MiddleRight|#1/[Pane]$ScrollViewer_9|#3/[StaticText]OF|#9/[StaticText]OF|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(OF2ST);

            OFTF = new TextField()
            {
                Tag = "[Pane]#1/[CustomWin]#1/[CustomWin]$Window_1|#1/[Pane]$dsv_MiddleRight|#1/[Pane]$ScrollViewer_9|#3/[TextField]OF|#9",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(OFTF);

            Pane22PANE = new Pane()
            {
                Tag = "[Pane]#1/[CustomWin]#1/[CustomWin]$Window_1|#1/[Pane]$dsv_MiddleRight|#1/[Pane]$ScrollViewer_9|#3/[TextField]OF|#9/[Pane]$PART_ContentHost|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Pane22PANE);

            B11ST = new StaticText()
            {
                Tag = "[Pane]#1/[CustomWin]#1/[CustomWin]$Window_1|#1/[Pane]$dsv_MiddleRight|#1/[Pane]$ScrollViewer_9|#3/[StaticText]B1|#10",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(B11ST);

            B12ST = new StaticText()
            {
                Tag = "[Pane]#1/[CustomWin]#1/[CustomWin]$Window_1|#1/[Pane]$dsv_MiddleRight|#1/[Pane]$ScrollViewer_9|#3/[StaticText]B1|#10/[StaticText]B1|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(B12ST);

            B1TF = new TextField()
            {
                Tag = "[Pane]#1/[CustomWin]#1/[CustomWin]$Window_1|#1/[Pane]$dsv_MiddleRight|#1/[Pane]$ScrollViewer_9|#3/[TextField]B1|#10",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(B1TF);

            Pane23PANE = new Pane()
            {
                Tag = "[Pane]#1/[CustomWin]#1/[CustomWin]$Window_1|#1/[Pane]$dsv_MiddleRight|#1/[Pane]$ScrollViewer_9|#3/[TextField]B1|#10/[Pane]$PART_ContentHost|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Pane23PANE);

            B21ST = new StaticText()
            {
                Tag = "[Pane]#1/[CustomWin]#1/[CustomWin]$Window_1|#1/[Pane]$dsv_MiddleRight|#1/[Pane]$ScrollViewer_9|#3/[StaticText]B2|#11",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(B21ST);

            B22ST = new StaticText()
            {
                Tag = "[Pane]#1/[CustomWin]#1/[CustomWin]$Window_1|#1/[Pane]$dsv_MiddleRight|#1/[Pane]$ScrollViewer_9|#3/[StaticText]B2|#11/[StaticText]B2|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(B22ST);

            B2TF = new TextField()
            {
                Tag = "[Pane]#1/[CustomWin]#1/[CustomWin]$Window_1|#1/[Pane]$dsv_MiddleRight|#1/[Pane]$ScrollViewer_9|#3/[TextField]B2|#11",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(B2TF);

            Pane24PANE = new Pane()
            {
                Tag = "[Pane]#1/[CustomWin]#1/[CustomWin]$Window_1|#1/[Pane]$dsv_MiddleRight|#1/[Pane]$ScrollViewer_9|#3/[TextField]B2|#11/[Pane]$PART_ContentHost|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Pane24PANE);

            ValveOperatorST = new StaticText()
            {
                Tag = "[Pane]#1/[CustomWin]#1/[CustomWin]$Window_1|#1/[Pane]$dsv_MiddleRight|#1/[StaticText]Valve Operator|$m_Title|#4",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ValveOperatorST);

            Image5IMG = new Image()
            {
                Tag = "[Pane]#1/[CustomWin]#1/[CustomWin]$Window_1|#1/[Pane]$dsv_MiddleRight|#1/[Image]$m_Image|#4",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Image5IMG);

            Pane25PANE = new Pane()
            {
                Tag = "[Pane]#1/[CustomWin]#1/[CustomWin]$Window_1|#1/[Pane]$dsv_MiddleRight|#1/[Pane]$ScrollViewer_9|#4",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Pane25PANE);

            Operator1ST = new StaticText()
            {
                Tag = "[Pane]#1/[CustomWin]#1/[CustomWin]$Window_1|#1/[Pane]$dsv_MiddleRight|#1/[Pane]$ScrollViewer_9|#4/[StaticText]Operator|$dlb_pp_ValveOperator|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Operator1ST);

            Operator2ST = new StaticText()
            {
                Tag = "[Pane]#1/[CustomWin]#1/[CustomWin]$Window_1|#1/[Pane]$dsv_MiddleRight|#1/[Pane]$ScrollViewer_9|#4/[StaticText]Operator|$dlb_pp_ValveOperator|#1/[StaticText]Operator|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Operator2ST);

            OperatorCB = new ComboBox()
            {
                Tag = "[Pane]#1/[CustomWin]#1/[CustomWin]$Window_1|#1/[Pane]$dsv_MiddleRight|#1/[Pane]$ScrollViewer_9|#4/[ComboBox]Operator|$dcb_pp_ValveOperator|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(OperatorCB);

            PushButtonPB = new PushButton()
            {
                Tag = "[Pane]#1/[CustomWin]#1/[CustomWin]$Window_1|#1/[Pane]$dsv_MiddleRight|#1/[Pane]$ScrollViewer_9|#4/[PushButton]$dbt_pp_ValveOperator|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(PushButtonPB);

            ScrollBar1SB = new ScrollBar()
            {
                Tag = "[Pane]#1/[CustomWin]#1/[CustomWin]$Window_1|#1/[Pane]$dsv_MiddleRight|#1/[ScrollBar]$VerticalScrollBar|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ScrollBar1SB);

            ScrollBar2SB = new ScrollBar()
            {
                Tag = "[Pane]#1/[CustomWin]#1/[CustomWin]$Window_1|#1/[Pane]$dsv_MiddleRight|#1/[ScrollBar]$HorizontalScrollBar|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ScrollBar2SB);

            InsertInModelPB = new PushButton()
            {
                Tag = "[Pane]#1/[CustomWin]#1/[CustomWin]$Window_1|#1/[PushButton]Insert in Model|$dbt_PartInsertPart|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(InsertInModelPB);
        }
    }
}
