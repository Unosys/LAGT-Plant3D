// This file is auto-generated - do not hand edit this file.

using Autodesk.GUIHarness;
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{

    [UIElement(Tag = "[Pane]Create Equipment|$EquBaseDlg", Parent = typeof(Plant3D), GUIType = GuiType.UIA)]
    public partial class P3DCreateEquipmentDLG : Autodesk.GUIHarness.AutoCAD.AcDialogBox
    {
        public  Menu DropDownMNU;
        public  MenuItem StiffeningRingMI;
        public  MenuItem SkirtMI;
        public  MenuItem PlatformMI;
        public  MenuItem LugMI;
        public  MenuItem BodyFlangeMI;
        public  Pane Pane1PANE;
        public  Pane Pane2PANE;
        public  PushButton VesselVerticalVesselPB;
        public  Pane EquipmentPANE;
        public  Pane Pane3PANE;
        public  Pane Pane4PANE;
        public  PushButton AddTrimPB;
        public  StaticText ShapesST;
        public  PushButton Shapes1PB;
        public  PushButton Shapes2PB;
        public  PushButton RemovePB;
        public  PushButton AddShapePB;
        public  ListBox ShapesLB;
        public  ListBoxItem TorisphericHead1LBI;
        public  ListBoxItem CylinderLBI;
        public  ListBoxItem TorisphericHead2LBI;
        public  Pane Pane5PANE;
        public  Window EquipmentWIN;
        public  Table DataGridView1TBL;
        public  CustomWin Row01WIN;
        public  CustomWin Row02WIN;
        public  CustomWin Row03WIN;
        public  CustomWin Row11WIN;
        public  CustomWin Row12WIN;
        public  CustomWin Row13WIN;
        public  CustomWin Row2WIN;
        public  StaticText GeneralST;
        public  Pane Pane6PANE;
        public  Table DataGridView2TBL;
        public  Window PropertiesWIN;
        public  Pane DataPANE;
        public  PushButton TemplatesPB;
        public  PushButton M_BtnCreCreate;
        public  PushButton CancelPB;
        public  TitleBar CreateEquipmentCTL;
        public  CustomWin SystemMenuBarWIN;
        public  MenuItem SystemMI;
        public  PushButton ClosePB;
        public  Pane PropertiesPANE;
        public  CustomWin Row04WIN;
        public  CustomWin NameRow0WIN;
        public  CustomWin ValueRow0WIN;
        public  StaticText DimensionsST;
        public  Pane EditingControlPANE;
        public  TextField TextFieldTF;
        public  PushButton DimEditPB;

        partial void OnInitialize();

        public P3DCreateEquipmentDLG()
        {
            InitializeComponent();
            OnInitialize();
        }

        private void InitializeComponent()
        {

            DropDownMNU = new Menu()
            {
                Tag = "[Menu]DropDown|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(DropDownMNU);

            StiffeningRingMI = new MenuItem()
            {
                Tag = "[Menu]DropDown|#1/[MenuItem]Stiffening Ring|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(StiffeningRingMI);

            SkirtMI = new MenuItem()
            {
                Tag = "[Menu]DropDown|#1/[MenuItem]Skirt|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(SkirtMI);

            PlatformMI = new MenuItem()
            {
                Tag = "[Menu]DropDown|#1/[MenuItem]Platform|#3",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(PlatformMI);

            LugMI = new MenuItem()
            {
                Tag = "[Menu]DropDown|#1/[MenuItem]Lug|#4",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(LugMI);

            BodyFlangeMI = new MenuItem()
            {
                Tag = "[Menu]DropDown|#1/[MenuItem]Body Flange|#5",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(BodyFlangeMI);

            Pane1PANE = new Pane()
            {
                Tag = "[Pane]$m_MainTableLayout|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Pane1PANE);

            Pane2PANE = new Pane()
            {
                Tag = "[Pane]$m_MainTableLayout|#1/[Pane]$m_WorkPanel|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Pane2PANE);

            VesselVerticalVesselPB = new PushButton()
            {
                Tag = "[Pane]$m_MainTableLayout|#1/[Pane]$m_WorkPanel|#1/[PushButton]Vessel - Vertical Vessel|$m_TypeSel|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(VesselVerticalVesselPB);

            EquipmentPANE = new Pane()
            {
                Tag = "[Pane]$m_MainTableLayout|#1/[Pane]$m_WorkPanel|#1/[PageList]$m_Tabs|#1/[Pane]$m_TabEquipment",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(EquipmentPANE);

            Pane3PANE = new Pane()
            {
                Tag = "[Pane]$m_MainTableLayout|#1/[Pane]$m_WorkPanel|#1/[PageList]$m_Tabs|#1/[Pane]Equipment|$m_TabEquipment|#1/[Pane]$m_EquTableLayout|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Pane3PANE);

            Pane4PANE = new Pane()
            {
                Tag = "[Pane]$m_MainTableLayout|#1/[Pane]$m_WorkPanel|#1/[PageList]$m_Tabs|#1/[Pane]Equipment|$m_TabEquipment|#1/[Pane]$m_EquTableLayout|#1/[Pane]$m_EquPrimitiveListPanel|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Pane4PANE);

            AddTrimPB = new PushButton()
            {
                Tag = "[Pane]$m_MainTableLayout|#1/[Pane]$m_WorkPanel|#1/[PageList]$m_Tabs|#1/[Pane]Equipment|$m_TabEquipment|#1/[Pane]$m_EquTableLayout|#1/[Pane]$m_EquPrimitiveListPanel|#2/[PushButton]     Add Trim|$m_EquPrimitiveAccessory|#4",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(AddTrimPB);

            ShapesST = new StaticText()
            {
                Tag = "[Pane]$m_MainTableLayout|#1/[Pane]$m_WorkPanel|#1/[PageList]$m_Tabs|#1/[Pane]Equipment|$m_TabEquipment|#1/[Pane]$m_EquTableLayout|#1/[Pane]$m_EquPrimitiveListPanel|#2/[StaticText] Shapes|$label5|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ShapesST);

            Shapes1PB = new PushButton()
            {
                Tag = "[Pane]$m_MainTableLayout|#1/[Pane]$m_WorkPanel|#1/[PageList]$m_Tabs|#1/[Pane]Equipment|$m_TabEquipment|#1/[Pane]$m_EquTableLayout|#1/[Pane]$m_EquPrimitiveListPanel|#2/[PushButton]Shapes|$m_EquPrimitiveDown|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Shapes1PB);

            Shapes2PB = new PushButton()
            {
                Tag = "[Pane]$m_MainTableLayout|#1/[Pane]$m_WorkPanel|#1/[PageList]$m_Tabs|#1/[Pane]Equipment|$m_TabEquipment|#1/[Pane]$m_EquTableLayout|#1/[Pane]$m_EquPrimitiveListPanel|#2/[PushButton]Shapes|$m_EquPrimitiveUp|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Shapes2PB);

            RemovePB = new PushButton()
            {
                Tag = "[Pane]$m_MainTableLayout|#1/[Pane]$m_WorkPanel|#1/[PageList]$m_Tabs|#1/[Pane]Equipment|$m_TabEquipment|#1/[Pane]$m_EquTableLayout|#1/[Pane]$m_EquPrimitiveListPanel|#2/[PushButton]      Remove|$m_EquPrimitiveRemove|#5",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(RemovePB);

            AddShapePB = new PushButton()
            {
                Tag = "[Pane]$m_MainTableLayout|#1/[Pane]$m_WorkPanel|#1/[PageList]$m_Tabs|#1/[Pane]Equipment|$m_TabEquipment|#1/[Pane]$m_EquTableLayout|#1/[Pane]$m_EquPrimitiveListPanel|#2/[PushButton]  Add Shape|$m_EquPrimitiveAdd|#3",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(AddShapePB);

            ShapesLB = new ListBox()
            {
                Tag = "[Pane]$m_MainTableLayout|#1/[Pane]$m_WorkPanel|#1/[PageList]$m_Tabs|#1/[Pane]Equipment|$m_TabEquipment|#1/[Pane]$m_EquTableLayout|#1/[Pane]$m_EquPrimitiveListPanel|#2/[ListBox] Shapes|$m_EquPrimitiveList|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ShapesLB);

            TorisphericHead1LBI = new ListBoxItem()
            {
                Tag = "[Pane]$m_MainTableLayout|#1/[Pane]$m_WorkPanel|#1/[PageList]$m_Tabs|#1/[Pane]Equipment|$m_TabEquipment|#1/[Pane]$m_EquTableLayout|#1/[Pane]$m_EquPrimitiveListPanel|#2/[ListBox] Shapes|$m_EquPrimitiveList|#1/[ListBoxItem]Torispheric Head|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(TorisphericHead1LBI);

            CylinderLBI = new ListBoxItem()
            {
                Tag = "[Pane]$m_MainTableLayout|#1/[Pane]$m_WorkPanel|#1/[PageList]$m_Tabs|#1/[Pane]Equipment|$m_TabEquipment|#1/[Pane]$m_EquTableLayout|#1/[Pane]$m_EquPrimitiveListPanel|#2/[ListBox] Shapes|$m_EquPrimitiveList|#1/[ListBoxItem]Cylinder|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(CylinderLBI);

            TorisphericHead2LBI = new ListBoxItem()
            {
                Tag = "[Pane]$m_MainTableLayout|#1/[Pane]$m_WorkPanel|#1/[PageList]$m_Tabs|#1/[Pane]Equipment|$m_TabEquipment|#1/[Pane]$m_EquTableLayout|#1/[Pane]$m_EquPrimitiveListPanel|#2/[ListBox] Shapes|$m_EquPrimitiveList|#1/[ListBoxItem]Torispheric Head|#3",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(TorisphericHead2LBI);

            Pane5PANE = new Pane()
            {
                Tag = "[Pane]$m_MainTableLayout|#1/[Pane]$m_WorkPanel|#1/[PageList]$m_Tabs|#1/[Pane]Equipment|$m_TabEquipment|#1/[Pane]$m_EquTableLayout|#1/[Pane]$m_EquPartPropertiesPanel|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Pane5PANE);

            EquipmentWIN = new Window()
            {
                Tag = "[Pane]$m_MainTableLayout|#1/[Pane]$m_WorkPanel|#1/[PageList]$m_Tabs|#1/[Window]Equipment|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(EquipmentWIN);

            DataGridView1TBL = new Table()
            {
                Tag = "[Pane]$m_MainTableLayout|#1/[Pane]$m_WorkPanel|#1/[PageList]$m_Tabs|#1/[Window]Equipment|#1/[Pane]Equipment|$m_TabEquipment|#1/[Pane]$m_EquTableLayout|#1/[Pane]$m_EquPartPropertiesPanel|#1/[Table]DataGridView|$m_EquPartProperties|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(DataGridView1TBL);

            Row01WIN = new CustomWin()
            {
                Tag = "[Pane]$m_MainTableLayout|#1/[Pane]$m_WorkPanel|#1/[PageList]$m_Tabs|#1/[Window]Equipment|#1/[Pane]Equipment|$m_TabEquipment|#1/[Pane]$m_EquTableLayout|#1/[Pane]$m_EquPartPropertiesPanel|#1/[Table]DataGridView|$m_EquPartProperties|#1/[CustomWin]Row 0|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Row01WIN);

            Row02WIN = new CustomWin()
            {
                Tag = "[Pane]$m_MainTableLayout|#1/[Pane]$m_WorkPanel|#1/[PageList]$m_Tabs|#1/[Window]Equipment|#1/[Pane]Equipment|$m_TabEquipment|#1/[Pane]$m_EquTableLayout|#1/[Pane]$m_EquPartPropertiesPanel|#1/[Table]DataGridView|$m_EquPartProperties|#1/[CustomWin]Row 0|#1/[CustomWin] Row 0[1]|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Row02WIN);

            Row03WIN = new CustomWin()
            {
                Tag = "[Pane]$m_MainTableLayout|#1/[Pane]$m_WorkPanel|#1/[PageList]$m_Tabs|#1/[Window]Equipment|#1/[Pane]Equipment|$m_TabEquipment|#1/[Pane]$m_EquTableLayout|#1/[Pane]$m_EquPartPropertiesPanel|#1/[Table]DataGridView|$m_EquPartProperties|#1/[CustomWin]Row 0|#1/[CustomWin] Row 0[2]|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Row03WIN);

            Row11WIN = new CustomWin()
            {
                Tag = "[Pane]$m_MainTableLayout|#1/[Pane]$m_WorkPanel|#1/[PageList]$m_Tabs|#1/[Window]Equipment|#1/[Pane]Equipment|$m_TabEquipment|#1/[Pane]$m_EquTableLayout|#1/[Pane]$m_EquPartPropertiesPanel|#1/[Table]DataGridView|$m_EquPartProperties|#1/[CustomWin]Row 1|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Row11WIN);

            Row12WIN = new CustomWin()
            {
                Tag = "[Pane]$m_MainTableLayout|#1/[Pane]$m_WorkPanel|#1/[PageList]$m_Tabs|#1/[Window]Equipment|#1/[Pane]Equipment|$m_TabEquipment|#1/[Pane]$m_EquTableLayout|#1/[Pane]$m_EquPartPropertiesPanel|#1/[Table]DataGridView|$m_EquPartProperties|#1/[CustomWin]Row 1|#2/[CustomWin] Row 1[1]|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Row12WIN);

            Row13WIN = new CustomWin()
            {
                Tag = "[Pane]$m_MainTableLayout|#1/[Pane]$m_WorkPanel|#1/[PageList]$m_Tabs|#1/[Window]Equipment|#1/[Pane]Equipment|$m_TabEquipment|#1/[Pane]$m_EquTableLayout|#1/[Pane]$m_EquPartPropertiesPanel|#1/[Table]DataGridView|$m_EquPartProperties|#1/[CustomWin]Row 1|#2/[CustomWin] Row 1[2]|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Row13WIN);

            Row2WIN = new CustomWin()
            {
                Tag = "[Pane]$m_MainTableLayout|#1/[Pane]$m_WorkPanel|#1/[PageList]$m_Tabs|#1/[Window]Equipment|#1/[Pane]Equipment|$m_TabEquipment|#1/[Pane]$m_EquTableLayout|#1/[Pane]$m_EquPartPropertiesPanel|#1/[Table]DataGridView|$m_EquPartProperties|#1/[CustomWin]Row 2|#3",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Row2WIN);

            GeneralST = new StaticText()
            {
                Tag = "[Pane]$m_MainTableLayout|#1/[Pane]$m_WorkPanel|#1/[PageList]$m_Tabs|#1/[Window]Equipment|#1/[Pane]Equipment|$m_TabEquipment|#1/[Pane]$m_EquTableLayout|#1/[Pane]$m_EquPartPropertiesPanel|#1/[StaticText] General|$label6|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(GeneralST);

            Pane6PANE = new Pane()
            {
                Tag = "[Pane]$m_MainTableLayout|#1/[Pane]$m_WorkPanel|#1/[PageList]$m_Tabs|#1/[Window]Equipment|#1/[Pane]Equipment|$m_TabEquipment|#1/[Pane]$m_EquTableLayout|#1/[Pane]$m_EquParametersPanel|#3",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Pane6PANE);

            DataGridView2TBL = new Table()
            {
                Tag = "[Pane]$m_MainTableLayout|#1/[Pane]$m_WorkPanel|#1/[PageList]$m_Tabs|#1/[Window]Equipment|#1/[Pane]Equipment|$m_TabEquipment|#1/[Pane]$m_EquTableLayout|#1/[Pane]$m_EquParametersPanel|#3/[Table]DataGridView|$m_EquParameters|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(DataGridView2TBL);

            PropertiesWIN = new Window()
            {
                Tag = "[Pane]$m_MainTableLayout|#1/[Pane]$m_WorkPanel|#1/[PageList]$m_Tabs|#1/[Window]Properties|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(PropertiesWIN);

            DataPANE = new Pane()
            {
                Tag = "[Pane]$m_MainTableLayout|#1/[Pane]$m_WorkPanel|#1/[Pane]Data|$m_Preview|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(DataPANE);

            TemplatesPB = new PushButton()
            {
                Tag = "[PushButton]Templates|$m_BtnSnapshot",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(TemplatesPB);

            M_BtnCreCreate = new PushButton()
            {
                Tag = "[PushButton]Create|$m_BtnCreCreate",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_BtnCreCreate);

            CancelPB = new PushButton()
            {
                Tag = "[PushButton]Cancel|$m_BtnCreCancel",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(CancelPB);

            CreateEquipmentCTL = new TitleBar()
            {
                Tag = "[TitleBar]$TitleBar",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(CreateEquipmentCTL);

            SystemMenuBarWIN = new CustomWin()
            {
                Tag = "[TitleBar]Create Equipment|$TitleBar|#1/[CustomWin]System Menu Bar|$EquBaseDlg|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(SystemMenuBarWIN);

            SystemMI = new MenuItem()
            {
                Tag = "[TitleBar]Create Equipment|$TitleBar|#1/[CustomWin]System Menu Bar|$EquBaseDlg|#1/[MenuItem]System|$Item 1|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(SystemMI);

            ClosePB = new PushButton()
            {
                Tag = "[TitleBar]Create Equipment|$TitleBar|#1/[PushButton]Close|$Close|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ClosePB);

            PropertiesPANE = new Pane()
            {
                Tag = "[Pane]$m_MainTableLayout|#1/[Pane]$m_WorkPanel|#1/[PageList]$m_Tabs|#1/[Pane]$m_TabData|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(PropertiesPANE);

            Row04WIN = new CustomWin()
            {
                Tag = "[Pane]$m_MainTableLayout/[Pane]$m_WorkPanel/[PageList]$m_Tabs/[Window]Equipment/[Pane]Equipment|$m_TabEquipment/[Pane]$m_EquTableLayout/[Pane]$m_EquParametersPanel/[Table]DataGridView|$m_EquParameters/[CustomWin]Row 0",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Row04WIN);

            NameRow0WIN = new CustomWin()
            {
                Tag = "[Pane]$m_MainTableLayout/[Pane]$m_WorkPanel/[PageList]$m_Tabs/[Window]Equipment/[Pane]Equipment|$m_TabEquipment/[Pane]$m_EquTableLayout/[Pane]$m_EquParametersPanel/[Table]DataGridView|$m_EquParameters/[CustomWin]Row 0/[CustomWin]Name Row 0",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(NameRow0WIN);

            ValueRow0WIN = new CustomWin()
            {
                Tag = "[Pane]$m_MainTableLayout/[Pane]$m_WorkPanel/[PageList]$m_Tabs/[Window]Equipment/[Pane]Equipment|$m_TabEquipment/[Pane]$m_EquTableLayout/[Pane]$m_EquParametersPanel/[Table]DataGridView|$m_EquParameters/[CustomWin]Row 0/[CustomWin]Value Row 0",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ValueRow0WIN);

            DimensionsST = new StaticText()
            {
                Tag = "[Pane]$m_MainTableLayout/[Pane]$m_WorkPanel/[PageList]$m_Tabs/[Window]Equipment/[Pane]Equipment|$m_TabEquipment/[Pane]$m_EquTableLayout/[Pane]$m_EquParametersPanel/[StaticText] Dimensions|$label7",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(DimensionsST);

            EditingControlPANE = new Pane()
            {
                Tag = "[Pane]$m_MainTableLayout/[Pane]$m_WorkPanel/[PageList]$m_Tabs/[Window]Equipment/[Pane]Equipment|$m_TabEquipment/[Pane]$m_EquTableLayout/[Pane]$m_EquParametersPanel/[Table]DataGridView|$m_EquParameters/[Pane]Editing Panel|$3605522/[Pane]Editing Control|$1508434",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(EditingControlPANE);

            TextFieldTF = new TextField()
            {
                Tag = "[Pane]$m_MainTableLayout/[Pane]$m_WorkPanel/[PageList]$m_Tabs/[Window]Equipment/[Pane]Equipment|$m_TabEquipment/[Pane]$m_EquTableLayout/[Pane]$m_EquParametersPanel/[Table]DataGridView|$m_EquParameters/[Pane]Editing Panel|$3605522/[Pane]Editing Control|$1508434/[TextField]$1573968",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(TextFieldTF);

            DimEditPB = new PushButton()
            {
                Tag = "[Pane]$m_MainTableLayout/[Pane]$m_WorkPanel/[PageList]$m_Tabs/[Window]Equipment/[Pane]Equipment|$m_TabEquipment/[Pane]$m_EquTableLayout/[Pane]$m_EquParametersPanel/[Table]DataGridView|$m_EquParameters/[Pane]Editing Panel|$3605522/[Pane]Editing Control|$1508434/[PushButton]$787588",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(DimEditPB);
        }
    }
}
