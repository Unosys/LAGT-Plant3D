// This file is auto-generated - do not hand edit this file.

using Autodesk.GUIHarness;
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{

    [UIElement(Tag = "[DialogBox]$ModifyPipeSupportDlg", Parent = typeof(Plant3D))]
    public partial class ModifyPipeSupportDLG : Autodesk.GUIHarness.AutoCAD.AcDialogBox
    {
        public  PushButton OK;
        public  CustomWin M_MainTableLayout;
        public  CustomWin M_WorkPanel;
        public  CustomWin Preview1;
        public  CustomWin Panel1;
        public  Table DimensionalProperties;
        public  StaticText DimensionalPropertiesText;
        public  CustomWin Panel9;
        public  Table M_PipeProperties;
        public  ScrollBar VerticalScrollBar;
        public  CustomWin Panel2;
        public  PushButton M_BtnSelectPipe;
        public  StaticText PipePropertiesText;
        public  CustomWin Panel8;
        public  Table SupportProperties;
        public  ScrollBar VerticalScrollBar1;
        public  StaticText SupportPropertiesText;
        public  PushButton SimplePipeSupport;
        public  StaticText PreviewText;
        public  CustomWin Preview2;
        public  PushButton Help;
        public  PushButton Cancel;

        partial void OnInitialize();

        public ModifyPipeSupportDLG()
        {
            InitializeComponent();
            OnInitialize();
        }

        private void InitializeComponent()
        {

            OK = new PushButton()
            {
                Tag = "[PushButton]OK|$m_BtnOK",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(OK);

            M_MainTableLayout = new CustomWin()
            {
                Tag = "[System.Windows.Forms.TableLayoutPanel]$m_MainTableLayout",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_MainTableLayout);

            M_WorkPanel = new CustomWin()
            {
                Tag = "[System.Windows.Forms.Panel]$m_WorkPanel",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_WorkPanel);

            Preview1 = new CustomWin()
            {
                Tag = "[CustomWin][System.Windows.Forms.TableLayoutPanel]Preview|[System.Windows.Forms.TableLayoutPanel]$m_PropsTableLayout",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Preview1);

            Panel1 = new CustomWin()
            {
                Tag = "[System.Windows.Forms.Panel]$panel1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Panel1);

            DimensionalProperties = new Table()
            {
                Tag = "[Table]Dimensional Properties|$m_SupportParameters",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(DimensionalProperties);

            DimensionalPropertiesText = new StaticText()
            {
                Tag = "[StaticText]Dimensional Properties|$label1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(DimensionalPropertiesText);

            Panel9 = new CustomWin()
            {
                Tag = "[System.Windows.Forms.Panel]$panel9",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Panel9);

            M_PipeProperties = new Table()
            {
                Tag = "$m_PipeProperties",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_PipeProperties);

            VerticalScrollBar = new ScrollBar()
            {
                Tag = "[ScrollBar]Vertical Scroll Bar|$VerticalScrollBar",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(VerticalScrollBar);

            Panel2 = new CustomWin()
            {
                Tag = "[System.Windows.Forms.Panel]$panel2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Panel2);

            M_BtnSelectPipe = new PushButton()
            {
                Tag = "$m_BtnSelectPipe",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_BtnSelectPipe);

            PipePropertiesText = new StaticText()
            {
                Tag = "[StaticText]Pipe Properties|$label6",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(PipePropertiesText);

            Panel8 = new CustomWin()
            {
                Tag = "[System.Windows.Forms.Panel]$panel8",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Panel8);

            SupportProperties = new Table()
            {
                Tag = "[Table]Support Properties|$m_SupportProperties",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(SupportProperties);

            VerticalScrollBar1 = new ScrollBar()
            {
                Tag = "[ScrollBar]Vertical Scroll Bar|$VerticalScrollBar",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(VerticalScrollBar1);

            SupportPropertiesText = new StaticText()
            {
                Tag = "[StaticText]Support Properties|$label7",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(SupportPropertiesText);

            SimplePipeSupport = new PushButton()
            {
                Tag = "[PushButton]Simple Pipe Support|$m_Type",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(SimplePipeSupport);

            PreviewText = new StaticText()
            {
                Tag = "[StaticText]Preview|$m_PreviewLabel",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(PreviewText);

            Preview2 = new CustomWin()
            {
                Tag = "[CustomWin][System.Windows.Forms.PictureBox]Preview|[System.Windows.Forms.PictureBox]$m_Preview",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Preview2);

            Help = new PushButton()
            {
                Tag = "[PushButton]Help|$m_BtnHelp",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Help);

            Cancel = new PushButton()
            {
                Tag = "[PushButton]Cancel|$m_BtnCancel",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Cancel);
        }
    }
}
