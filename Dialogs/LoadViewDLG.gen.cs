// This file is auto-generated - do not hand edit this file.

using Autodesk.GUIHarness;
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{

    [UIElement(Tag = "[Pane]Load View|$frmLoadViewDetails", Parent = typeof(Plant3D), GUIType = GuiType.UIA)]
    public partial class LoadViewDLG : Pane
    {
        public  ListBox ViewList;
        public  PushButton Help;
        public  PushButton Cancel;
        public  PushButton OK;
        public  PushButton Delete;
        public  Table Scale3;
        public  Pane PanePANE;
        public  TextField Scale;
        public  TextField OrthographicView;
        public  StaticText OrthographicViewText;
        public  PushButton ClosePB;

        partial void OnInitialize();

        public LoadViewDLG()
        {
            InitializeComponent();
            OnInitialize();
        }

        private void InitializeComponent()
        {

            ViewList = new ListBox()
            {
                Tag = "[ListBox]View List:|$m_viewListBox",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ViewList);

            Help = new PushButton()
            {
                Tag = "[PushButton]Help|$m_helpBtn",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Help);

            Cancel = new PushButton()
            {
                Tag = "[PushButton]Cancel|$m_cancelBtn",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Cancel);

            OK = new PushButton()
            {
                Tag = "[PushButton]OK|$m_OKBtn",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(OK);

            Delete = new PushButton()
            {
                Tag = "[PushButton]Delete|$m_deleteBtn",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Delete);

            Scale3 = new Table()
            {
                Tag = "[GroupBox]View Details|$mViewDetailsGrpBox/[Table]DataGridView|$m_dataGridView_geomInfo",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Scale3);

            PanePANE = new Pane()
            {
                Tag = "[GroupBox]View Details|$mViewDetailsGrpBox/[Pane]$m_collapsiblePanel_geomInfo",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(PanePANE);

            Scale = new TextField()
            {
                Tag = "[GroupBox]View Details|$mViewDetailsGrpBox/[TextField]Scale:|$m_scaleTextBox",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Scale);

            OrthographicView = new TextField()
            {
                Tag = "[GroupBox]View Details|$mViewDetailsGrpBox/[TextField]Orthographic View:|$m_orthoViewNameTextBox",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(OrthographicView);

            OrthographicViewText = new StaticText()
            {
                Tag = "[GroupBox]View Details|$mViewDetailsGrpBox/[StaticText]Orthographic View:|$mViewLbl",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(OrthographicViewText);

            ClosePB = new PushButton()
            {
                Tag = "[TitleBar]Load View|$TitleBar/[PushButton]Close|$Close",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ClosePB);
        }
    }
}
