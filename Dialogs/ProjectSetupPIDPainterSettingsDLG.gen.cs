// This file is auto-generated - do not hand edit this file.

using Autodesk.GUIHarness;
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{

    [UIElement(Tag = "[Pane]Project Setup|$EditProjectSettingsDlg", Parent = typeof(MainWin), GUIType = GuiType.UIA)]
    public partial class ProjectSetupPIDPainterSettingsDLG : Autodesk.GUIHarness.AutoCAD.AcDialogBox
    {
        public  Link WhyLINK;
        public  PushButton Preview2PB;
        public  StaticText ServiceST;
        public  Pane PreviewPANE;
        public  Table DataGridView1TBL;
        public  Pane VerticalScrollBarPANE;
        public  CustomWin TopRowWIN;
        public  Header ServiceCTL;
        public  Header ColorCTL;
        public  Header ColorFadingCTL;
        public  StaticText ColorSettingsST;
        public  PushButton ServicePB;
        public  StaticText AssignColorByST;
        public  PushButton DeletePB;
        public  PushButton AddPB;
        public  PushButton CancelPB;
        public  PushButton OKPB;
        public  PushButton ApplyPB;
        public  PushButton ClosePB;

        partial void OnInitialize();

        public ProjectSetupPIDPainterSettingsDLG()
        {
            InitializeComponent();
            OnInitialize();
        }

        private void InitializeComponent()
        {

            WhyLINK = new Link()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]#1/[Pane]$m_splitVert|#1/[Pane]#2/[Pane]$m_painterSettingsUserCtrl|#1/[GroupBox]P*|$groupBox_PainterSettings|#1/[StaticText]Why?|$m_linkLabelBlockWhy|#3/[Link]Why?|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(WhyLINK);

            Preview2PB = new PushButton()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$3739434|#1/[Pane]$m_splitVert|#1/[Pane]$15535034|#2/[Pane]$m_painterSettingsUserCtrl|#1/[GroupBox]P*|$groupBox_PainterSettings|#1/[GroupBox]Painter Style Settings|$groupBox_PainterStyleSettings|#1/[PushButton]preview|$m_btnBlackBackGround|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Preview2PB);

            ServiceST = new StaticText()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$3739434|#1/[Pane]$m_splitVert|#1/[Pane]$15535034|#2/[Pane]$m_painterSettingsUserCtrl|#1/[GroupBox]P*|$groupBox_PainterSettings|#1/[GroupBox]Painter Style Settings|$groupBox_PainterStyleSettings|#1/[StaticText]Service|$m_labelColorBy|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ServiceST);

            PreviewPANE = new Pane()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$3739434|#1/[Pane]$m_splitVert|#1/[Pane]$15535034|#2/[Pane]$m_painterSettingsUserCtrl|#1/[GroupBox]P*|$groupBox_PainterSettings|#1/[GroupBox]Painter Style Settings|$groupBox_PainterStyleSettings|#1/[Pane]preview|$pictureBox_Preview|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(PreviewPANE);

            DataGridView1TBL = new Table()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$3739434|#1/[Pane]$m_splitVert|#1/[Pane]$15535034|#2/[Pane]$m_painterSettingsUserCtrl|#1/[GroupBox]P*|$groupBox_PainterSettings|#1/[GroupBox]Painter Style Settings|$groupBox_PainterStyleSettings|#1/[Table]DataGridView|$dataGridView_ColorSettings|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(DataGridView1TBL);

            VerticalScrollBarPANE = new Pane()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$3739434|#1/[Pane]$m_splitVert|#1/[Pane]$15535034|#2/[Pane]$m_painterSettingsUserCtrl|#1/[GroupBox]P*|$groupBox_PainterSettings|#1/[GroupBox]Painter Style Settings|$groupBox_PainterStyleSettings|#1/[Table]DataGridView|$dataGridView_ColorSettings|#1/[Pane]Vertical Scroll Bar|$7082528|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(VerticalScrollBarPANE);

            TopRowWIN = new CustomWin()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$3739434|#1/[Pane]$m_splitVert|#1/[Pane]$15535034|#2/[Pane]$m_painterSettingsUserCtrl|#1/[GroupBox]P*|$groupBox_PainterSettings|#1/[GroupBox]Painter Style Settings|$groupBox_PainterStyleSettings|#1/[Table]DataGridView|$dataGridView_ColorSettings|#1/[CustomWin]Top Row|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(TopRowWIN);

            ServiceCTL = new Header()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$3739434|#1/[Pane]$m_splitVert|#1/[Pane]$15535034|#2/[Pane]$m_painterSettingsUserCtrl|#1/[GroupBox]P*|$groupBox_PainterSettings|#1/[GroupBox]Painter Style Settings|$groupBox_PainterStyleSettings|#1/[Table]DataGridView|$dataGridView_ColorSettings|#1/[CustomWin]Top Row|#1/[Header]Service|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ServiceCTL);

            ColorCTL = new Header()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$3739434|#1/[Pane]$m_splitVert|#1/[Pane]$15535034|#2/[Pane]$m_painterSettingsUserCtrl|#1/[GroupBox]P*|$groupBox_PainterSettings|#1/[GroupBox]Painter Style Settings|$groupBox_PainterStyleSettings|#1/[Table]DataGridView|$dataGridView_ColorSettings|#1/[CustomWin]Top Row|#1/[Header]Color|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ColorCTL);

            ColorFadingCTL = new Header()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$3739434|#1/[Pane]$m_splitVert|#1/[Pane]$15535034|#2/[Pane]$m_painterSettingsUserCtrl|#1/[GroupBox]P*|$groupBox_PainterSettings|#1/[GroupBox]Painter Style Settings|$groupBox_PainterStyleSettings|#1/[Table]DataGridView|$dataGridView_ColorSettings|#1/[CustomWin]Top Row|#1/[Header]Color Fading|#3",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ColorFadingCTL);

            ColorSettingsST = new StaticText()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$3739434|#1/[Pane]$m_splitVert|#1/[Pane]$15535034|#2/[Pane]$m_painterSettingsUserCtrl|#1/[GroupBox]P*|$groupBox_PainterSettings|#1/[GroupBox]Painter Style Settings|$groupBox_PainterStyleSettings|#1/[StaticText]Color Settings:|$label3|#4",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ColorSettingsST);

            ServicePB = new PushButton()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$3739434|#1/[Pane]$m_splitVert|#1/[Pane]$15535034|#2/[Pane]$m_painterSettingsUserCtrl|#1/[GroupBox]P*|$groupBox_PainterSettings|#1/[GroupBox]Painter Style Settings|$groupBox_PainterStyleSettings|#1/[PushButton]Service|$btn_propertySelection|#3",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ServicePB);

            AssignColorByST = new StaticText()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$3739434|#1/[Pane]$m_splitVert|#1/[Pane]$15535034|#2/[Pane]$m_painterSettingsUserCtrl|#1/[GroupBox]P*|$groupBox_PainterSettings|#1/[GroupBox]Painter Style Settings|$groupBox_PainterStyleSettings|#1/[StaticText]Assign color by :|$label2|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(AssignColorByST);

            DeletePB = new PushButton()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$3739434|#1/[Pane]$m_splitVert|#1/[Pane]$15535034|#2/[Pane]$m_painterSettingsUserCtrl|#1/[GroupBox]P*|$groupBox_PainterSettings|#1/[PushButton]Delete|$btn_DeletePainterStyle",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(DeletePB);

            AddPB = new PushButton()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$3739434|#1/[Pane]$m_splitVert|#1/[Pane]$15535034|#2/[Pane]$m_painterSettingsUserCtrl|#1/[GroupBox]P*|$groupBox_PainterSettings|#1/[PushButton]Add|$btn_AddPainterStyle",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(AddPB);

            CancelPB = new PushButton()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$15929054|#2/[PushButton]Cancel|$m_btnCancel|#3",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(CancelPB);

            OKPB = new PushButton()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$15929054|#2/[PushButton]OK|$m_btnOk|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(OKPB);

            ApplyPB = new PushButton()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$15929054|#2/[PushButton]Apply|$m_btnSave|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ApplyPB);

            ClosePB = new PushButton()
            {
                Tag = "[TitleBar]Project Setup|$TitleBar|#1/[PushButton]Close|$Close|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ClosePB);
        }
    }
}
