// This file is auto-generated - do not hand edit this file.

using Autodesk.GUIHarness;
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{

    [UIElement(Tag = "[Pane]Data Source Wizard|$WizardView", Parent = typeof(Pane), GUIType = GuiType.UIA)]
    public partial class DataSourceWizardDLG_SelectADataConnectionType : Autodesk.GUIHarness.AutoCAD.AcDialogBox
    {
        public  TextField TextField1TF;
        public  TextField TextField2TF;
        public  ListBox ListBox1LB;
        public  Pane Pane5PANE;
        public  ScrollBar VerticalSB;
        public  ListBox ListBox2LB;
        public  ListBoxItem ItemLBI;
        public  Pane LayoutGroupContentPANE;
        public  PushButton PushButtonPB;
        public  PushButton NextPB;
        public  PushButton FinishPB;
        public  PushButton ClosePB;

        partial void OnInitialize();

        public DataSourceWizardDLG_SelectADataConnectionType()
        {
            InitializeComponent();
            OnInitialize();
        }

        private void InitializeComponent()
        {

            TextField1TF = new TextField()
            {
                Tag = "[Pane]$ChooseDataProviderPageView|#1/[Pane]$layoutControlBase|#1/[Pane]$panelBaseContent|#2/[Pane]$layoutControlContent|#1/[TextField]$searchControl1|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(TextField1TF);

            TextField2TF = new TextField()
            {
                Tag = "[Pane]$ChooseDataProviderPageView|#1/[Pane]$layoutControlBase|#1/[Pane]$panelBaseContent|#2/[Pane]$layoutControlContent|#1/[TextField]$searchControl1|#1/[TextField]#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(TextField2TF);

            ListBox1LB = new ListBox()
            {
                Tag = "[Pane]$ChooseDataProviderPageView|#1/[Pane]$layoutControlBase|#1/[Pane]$panelBaseContent|#2/[Pane]$layoutControlContent|#1/[ListBox]$galleryDataSourceProviderType|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ListBox1LB);

            Pane5PANE = new Pane()
            {
                Tag = "[Pane]$ChooseDataProviderPageView|#1/[Pane]$layoutControlBase|#1/[Pane]$panelBaseContent|#2/[Pane]$layoutControlContent|#1/[ListBox]$galleryDataSourceProviderType|#1/[Pane]$724202|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Pane5PANE);

            VerticalSB = new ScrollBar()
            {
                Tag = "[Pane]$ChooseDataProviderPageView|#1/[Pane]$layoutControlBase|#1/[Pane]$panelBaseContent|#2/[Pane]$layoutControlContent|#1/[ListBox]$galleryDataSourceProviderType|#1/[ScrollBar]Vertical|$265874|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(VerticalSB);

            ListBox2LB = new ListBox()
            {
                Tag = "[Pane]$ChooseDataProviderPageView|#1/[Pane]$layoutControlBase|#1/[Pane]$panelBaseContent|#2/[Pane]$layoutControlContent|#1/[ListBox]$galleryDataSourceProviderType|#1/[ListBox]#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ListBox2LB);

            ItemLBI = new ListBoxItem()
            {
                Tag = "[Pane]$ChooseDataProviderPageView|#1/[Pane]$layoutControlBase|#1/[Pane]$panelBaseContent|#2/[Pane]$layoutControlContent|#1/[ListBox]$galleryDataSourceProviderType|#1/[ListBox]#1/[ListBoxItem]Entity Framework|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ItemLBI);

            LayoutGroupContentPANE = new Pane()
            {
                Tag = "[Pane]$ChooseDataProviderPageView|#1/[Pane]$layoutControlBase|#1/[Pane]$panelBaseContent|#2/[Pane]$layoutControlContent|#1/[Pane]layoutGroupContent|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(LayoutGroupContentPANE);

            PushButtonPB = new PushButton()
            {
                Tag = "[Pane]$ChooseDataProviderPageView|#1/[Pane]$layoutControlBase|#1/[PushButton]$buttonPrevious|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(PushButtonPB);

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

            ClosePB = new PushButton()
            {
                Tag = "[TitleBar]Data Source Wizard|$TitleBar|#1/[PushButton]Close|$Close|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ClosePB);
        }
    }
}
