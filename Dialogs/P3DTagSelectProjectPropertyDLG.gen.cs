// This file is auto-generated - do not hand edit this file.

using Autodesk.GUIHarness;
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{

    [UIElement(Tag = "[Pane]$SelectProjectPropertyDlg")]
    public partial class P3DTagSelectProjectPropertyDLG : Pane
    {
        public  Pane Pane1PANE;
        public  Pane Pane2PANE;
        public  StaticText CategoryST;
        public  ListBox CategoryLB;
        public  ListBoxItem GeneralLBI;
        public  Pane Pane3PANE;
        public  ListBox DrawingPropertiesLB;
        public  StaticText DrawingPropertiesST;
        public  PushButton HelpPB;
        public  PushButton M_btnCancel;
        public  PushButton OKPB;
        public  TitleBar SelectDrawingPropertyCTL;
        public  CustomWin SystemMenuBarWIN;
        public  MenuItem SystemMI;
        public  PushButton ClosePB;

        partial void OnInitialize();

        public P3DTagSelectProjectPropertyDLG()
        {
            InitializeComponent();
            OnInitialize();
        }

        private void InitializeComponent()
        {

            Pane1PANE = new Pane()
            {
                Tag = "[Pane]$splitContainer1|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Pane1PANE);

            Pane2PANE = new Pane()
            {
                Tag = "[Pane]$splitContainer1|#1/[Pane]$1839340|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Pane2PANE);

            CategoryST = new StaticText()
            {
                Tag = "[Pane]$splitContainer1|#1/[Pane]$1839340|#1/[StaticText]Category:|$m_lblCategory|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(CategoryST);

            CategoryLB = new ListBox()
            {
                Tag = "[Pane]$splitContainer1|#1/[Pane]$1839340|#1/[ListBox]Category:|$m_listBoxCategory|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(CategoryLB);

            GeneralLBI = new ListBoxItem()
            {
                Tag = "[Pane]$splitContainer1|#1/[Pane]$1839340|#1/[ListBox]Category:|$m_listBoxCategory|#1/[ListBoxItem]General|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(GeneralLBI);

            Pane3PANE = new Pane()
            {
                Tag = "[Pane]$splitContainer1|#1/[Pane]$3149820|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Pane3PANE);

            DrawingPropertiesLB = new ListBox()
            {
                Tag = "[Pane]$splitContainer1|#1/[Pane]$3149820|#2/[ListBox]Drawing Properties:|$m_listBoxDrawingProperty|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(DrawingPropertiesLB);

            DrawingPropertiesST = new StaticText()
            {
                Tag = "[Pane]$splitContainer1|#1/[Pane]$3149820|#2/[StaticText]Drawing Properties:|$m_lblDrawingText|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(DrawingPropertiesST);

            HelpPB = new PushButton()
            {
                Tag = "[PushButton]Help|$m_btnHelp|#3",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(HelpPB);

            M_btnCancel = new PushButton()
            {
                Tag = "[PushButton]Cancel|$m_btnCancel|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_btnCancel);

            OKPB = new PushButton()
            {
                Tag = "[PushButton]OK|$m_btnOK|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(OKPB);

            SelectDrawingPropertyCTL = new TitleBar()
            {
                Tag = "[TitleBar]Select Drawing Property|$TitleBar|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(SelectDrawingPropertyCTL);

            SystemMenuBarWIN = new CustomWin()
            {
                Tag = "[TitleBar]Select Drawing Property|$TitleBar|#1/[CustomWin]System Menu Bar|$SelectDrawingPropertyDlg|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(SystemMenuBarWIN);

            SystemMI = new MenuItem()
            {
                Tag = "[TitleBar]Select Drawing Property|$TitleBar|#1/[CustomWin]System Menu Bar|$SelectDrawingPropertyDlg|#1/[MenuItem]System|$Item 1|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(SystemMI);

            ClosePB = new PushButton()
            {
                Tag = "[TitleBar]Select Drawing Property|$TitleBar|#1/[PushButton]Close|$Close|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ClosePB);
        }
    }
}
