// This file is auto-generated - do not hand edit this file.

using Autodesk.GUIHarness;
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{

    [UIElement(Tag = "[CustomWin]", Parent = typeof(Plant3D), GUIType = GuiType.WIN32)]
    public partial class ValidationSummaryDLG : CustomWin
    {
        public  CustomWin CustomWin1WIN;
        public  CustomWin CustomWin2WIN;
        public  CustomWin ValidationSummaryWIN;
        public  Pane Pane1PANE;
        public  Pane CurrentProjectDefaultProjectPANE;
        public  Pane Pane2PANE;
        public  CheckBox DontDisplayErrorsMarkedCK;
        public  Pane Pane3PANE;
        public  TreeView TreeViewTV;
        public  ScrollBar HorizontalScrollBarSB;
        public  ScrollBar VerticalScrollBar1SB;
        public  Pane Pane4PANE;
        public  Pane Pane5PANE;
        public  TextField TextFieldTF;
        public  ScrollBar VerticalScrollBar2SB;
        public  Table DataGridViewTBL;
        public  CustomWin Row01WIN;
        public  CustomWin Row02WIN;
        public  CustomWin Row03WIN;
        public  CustomWin Row21WIN;
        public  CustomWin Row22WIN;
        public  CustomWin Row23WIN;
        public  PushButton PushButton1PB;
        public  PushButton PushButton2PB;
        public  StaticText CurrentProjectDefaultProjectST;

        partial void OnInitialize();

        public ValidationSummaryDLG()
        {
            InitializeComponent();
            OnInitialize();
        }

        private void InitializeComponent()
        {

            CustomWin1WIN = new CustomWin()
            {
                Tag = "[CustomWin]$59423",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(CustomWin1WIN);

            CustomWin2WIN = new CustomWin()
            {
                Tag = "[CustomWin]$59423/[CustomWin]$16720",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(CustomWin2WIN);

            ValidationSummaryWIN = new CustomWin()
            {
                Tag = "[CustomWin]$59423/[CustomWin]$16720/[CustomWin]Validation Summary|$10",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ValidationSummaryWIN);

            Pane1PANE = new Pane()
            {
                Tag = "[CustomWin]$59423/[CustomWin]$16720/[CustomWin]Validation Summary|$10/[Pane]$ControlAxSourcingSite",
                ParentType = this.GetType(),
                Parent = this,
                GUIType = GuiType.UIA,
            };
            DeclaredChildren.Add(Pane1PANE);

            CurrentProjectDefaultProjectPANE = new Pane()
            {
                Tag = "[CustomWin]$59423/[CustomWin]$16720/[CustomWin]Validation Summary|$10/[Pane]$ControlAxSourcingSite/[Pane]Current project: DefaultProject|$m_splitContainer",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(CurrentProjectDefaultProjectPANE);

            Pane2PANE = new Pane()
            {
                Tag = "[CustomWin]$59423/[CustomWin]$16720/[CustomWin]Validation Summary|$10/[Pane]$ControlAxSourcingSite/[Pane]Current project: DefaultProject|$m_splitContainer/[Pane]$1051674",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Pane2PANE);

            DontDisplayErrorsMarkedCK = new CheckBox()
            {
                Tag = "[CustomWin]$59423/[CustomWin]$16720/[CustomWin]Validation Summary|$10/[Pane]$ControlAxSourcingSite/[Pane]Current project: DefaultProject|$m_splitContainer/[Pane]$1051674/[CheckBox]Don?t display errors marked as ignored|$m_chkHideIgnored",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(DontDisplayErrorsMarkedCK);

            Pane3PANE = new Pane()
            {
                Tag = "[CustomWin]$59423/[CustomWin]$16720/[CustomWin]Validation Summary|$10/[Pane]$ControlAxSourcingSite/[Pane]Current project: DefaultProject|$m_splitContainer/[Pane]$1051674/[Pane]$m_detailsCollapsibleButton",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Pane3PANE);

            TreeViewTV = new TreeView()
            {
                Tag = "[CustomWin]$59423/[CustomWin]$16720/[CustomWin]Validation Summary|$10/[Pane]$ControlAxSourcingSite/[Pane]Current project: DefaultProject|$m_splitContainer/[Pane]$1051674/[TreeView]$m_errorValidationTree",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(TreeViewTV);

            HorizontalScrollBarSB = new ScrollBar()
            {
                Tag = "[CustomWin]$59423/[CustomWin]$16720/[CustomWin]Validation Summary|$10/[Pane]$ControlAxSourcingSite/[Pane]Current project: DefaultProject|$m_splitContainer/[Pane]$1051674/[TreeView]$m_errorValidationTree/[ScrollBar]Horizontal Scroll Bar|$Horizontal ScrollBar",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(HorizontalScrollBarSB);

            VerticalScrollBar1SB = new ScrollBar()
            {
                Tag = "[CustomWin]$59423/[CustomWin]$16720/[CustomWin]Validation Summary|$10/[Pane]$ControlAxSourcingSite/[Pane]Current project: DefaultProject|$m_splitContainer/[Pane]$1051674/[TreeView]$m_errorValidationTree/[ScrollBar]Vertical Scroll Bar|$Vertical ScrollBar",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(VerticalScrollBar1SB);

            Pane4PANE = new Pane()
            {
                Tag = "[CustomWin]$59423/[CustomWin]$16720/[CustomWin]Validation Summary|$10/[Pane]$ControlAxSourcingSite/[Pane]Current project: DefaultProject|$m_splitContainer/[Pane]$1312690",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Pane4PANE);

            Pane5PANE = new Pane()
            {
                Tag = "[CustomWin]$59423/[CustomWin]$16720/[CustomWin]Validation Summary|$10/[Pane]$ControlAxSourcingSite/[Pane]Current project: DefaultProject|$m_splitContainer/[Pane]$1312690/[Pane]$m_errorDetailsGrid",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Pane5PANE);

            TextFieldTF = new TextField()
            {
                Tag = "[CustomWin]$59423/[CustomWin]$16720/[CustomWin]Validation Summary|$10/[Pane]$ControlAxSourcingSite/[Pane]Current project: DefaultProject|$m_splitContainer/[Pane]$1312690/[Pane]$m_errorDetailsGrid/[TextField]$m_detailDescription",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(TextFieldTF);

            VerticalScrollBar2SB = new ScrollBar()
            {
                Tag = "[CustomWin]$59423/[CustomWin]$16720/[CustomWin]Validation Summary|$10/[Pane]$ControlAxSourcingSite/[Pane]Current project: DefaultProject|$m_splitContainer/[Pane]$1312690/[Pane]$m_errorDetailsGrid/[TextField]$m_detailDescription/[ScrollBar]Vertical Scroll Bar|$Vertical ScrollBar",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(VerticalScrollBar2SB);

            DataGridViewTBL = new Table()
            {
                Tag = "[CustomWin]$59423/[CustomWin]$16720/[CustomWin]Validation Summary|$10/[Pane]$ControlAxSourcingSite/[Pane]Current project: DefaultProject|$m_splitContainer/[Pane]$1312690/[Pane]$m_errorDetailsGrid/[Table]DataGridView|$m_errorDetailsGridView",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(DataGridViewTBL);

            Row01WIN = new CustomWin()
            {
                Tag = "[CustomWin]$59423/[CustomWin]$16720/[CustomWin]Validation Summary|$10/[Pane]$ControlAxSourcingSite/[Pane]Current project: DefaultProject|$m_splitContainer/[Pane]$1312690/[Pane]$m_errorDetailsGrid/[Table]DataGridView|$m_errorDetailsGridView/[CustomWin]Row 0",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Row01WIN);

            Row02WIN = new CustomWin()
            {
                Tag = "[CustomWin]$59423/[CustomWin]$16720/[CustomWin]Validation Summary|$10/[Pane]$ControlAxSourcingSite/[Pane]Current project: DefaultProject|$m_splitContainer/[Pane]$1312690/[Pane]$m_errorDetailsGrid/[Table]DataGridView|$m_errorDetailsGridView/[CustomWin]Row 0/[CustomWin] Row 0[1]",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Row02WIN);

            Row03WIN = new CustomWin()
            {
                Tag = "[CustomWin]$59423/[CustomWin]$16720/[CustomWin]Validation Summary|$10/[Pane]$ControlAxSourcingSite/[Pane]Current project: DefaultProject|$m_splitContainer/[Pane]$1312690/[Pane]$m_errorDetailsGrid/[Table]DataGridView|$m_errorDetailsGridView/[CustomWin]Row 0/[CustomWin] Row 0[2]",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Row03WIN);

            Row21WIN = new CustomWin()
            {
                Tag = "[CustomWin]$59423/[CustomWin]$16720/[CustomWin]Validation Summary|$10/[Pane]$ControlAxSourcingSite/[Pane]Current project: DefaultProject|$m_splitContainer/[Pane]$1312690/[Pane]$m_errorDetailsGrid/[Table]DataGridView|$m_errorDetailsGridView/[CustomWin]Row 2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Row21WIN);

            Row22WIN = new CustomWin()
            {
                Tag = "[CustomWin]$59423/[CustomWin]$16720/[CustomWin]Validation Summary|$10/[Pane]$ControlAxSourcingSite/[Pane]Current project: DefaultProject|$m_splitContainer/[Pane]$1312690/[Pane]$m_errorDetailsGrid/[Table]DataGridView|$m_errorDetailsGridView/[CustomWin]Row 2/[CustomWin] Row 2[1]",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Row22WIN);

            Row23WIN = new CustomWin()
            {
                Tag = "[CustomWin]$59423/[CustomWin]$16720/[CustomWin]Validation Summary|$10/[Pane]$ControlAxSourcingSite/[Pane]Current project: DefaultProject|$m_splitContainer/[Pane]$1312690/[Pane]$m_errorDetailsGrid/[Table]DataGridView|$m_errorDetailsGridView/[CustomWin]Row 2/[CustomWin] Row 2[2]",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Row23WIN);

            PushButton1PB = new PushButton()
            {
                Tag = "[CustomWin]$59423/[CustomWin]$16720/[CustomWin]Validation Summary|$10/[Pane]$ControlAxSourcingSite/[PushButton]$m_refreshButton",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(PushButton1PB);

            PushButton2PB = new PushButton()
            {
                Tag = "[CustomWin]$59423/[CustomWin]$16720/[CustomWin]Validation Summary|$10/[Pane]$ControlAxSourcingSite/[PushButton]$m_valSettingButton",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(PushButton2PB);

            CurrentProjectDefaultProjectST = new StaticText()
            {
                Tag = "[CustomWin]$59423/[CustomWin]$16720/[CustomWin]Validation Summary|$10/[Pane]$ControlAxSourcingSite/[StaticText]Current project: DefaultProject|$m_errorValidationLabel",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(CurrentProjectDefaultProjectST);
        }
    }
}
