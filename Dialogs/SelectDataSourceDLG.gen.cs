// This file is auto-generated - do not hand edit this file.

using Autodesk.GUIHarness;
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{

    [UIElement(Tag = "[Pane]$SelectDataSource", Parent = typeof(AddPropertyDLG))]
    public partial class SelectDataSourceDLG : Pane
    {
        public  PushButton HelpPB;
        public  PushButton M_cancelBtn;
        public  PushButton OKPB;
        public  PageList PageListPG;
        public  Window ClassPropertiesWIN;
        public  Pane ClassPropertiesPANE;
        public  Pane Pane1PANE;
        public  Pane Pane2PANE;
        public  TreeView CategoriesTV;
        public  ScrollBar Categories1SB;
        public  ScrollBar Categories2SB;
        public  StaticText CategoriesST;
        public  Pane Pane3PANE;
        public  ListBox PropertiesLB;
        public  ListBoxItem ClassNameLBI;
        public  ListBoxItem DescriptionLBI;
        public  ListBoxItem ManufacturerLBI;
        public  ListBoxItem ModelNumberLBI;
        public  ListBoxItem SupplierLBI;
        public  ListBoxItem CommentLBI;
        public  StaticText PropertiesST;
        public  Window ProjectPropertiesWIN;
        public  Window DrawingPropertiesWIN;
        public  TitleBar SelectDataSourceCTL;
        public  CustomWin SystemMenuBarWIN;
        public  MenuItem SystemMI;
        public  PushButton ClosePB;

        partial void OnInitialize();

        public SelectDataSourceDLG()
        {
            InitializeComponent();
            OnInitialize();
        }

        private void InitializeComponent()
        {

            HelpPB = new PushButton()
            {
                Tag = "[PushButton]Help|$m_helpBtn|#3",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(HelpPB);

            M_cancelBtn = new PushButton()
            {
                Tag = "[PushButton]Cancel|$m_cancelBtn|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_cancelBtn);

            OKPB = new PushButton()
            {
                Tag = "[PushButton]OK|$m_OKBtn|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(OKPB);

            PageListPG = new PageList()
            {
                Tag = "[PageList]$m_propertyTabs|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(PageListPG);

            ClassPropertiesWIN = new Window()
            {
                Tag = "[PageList]$m_propertyTabs|#1/[Window]Class Properties|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ClassPropertiesWIN);

            ClassPropertiesPANE = new Pane()
            {
                Tag = "[PageList]$m_propertyTabs|#1/[Window]Class Properties|#1/[Pane]Class Properties|$m_objectTabPage|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ClassPropertiesPANE);

            Pane1PANE = new Pane()
            {
                Tag = "[PageList]$m_propertyTabs|#1/[Window]Class Properties|#1/[Pane]Class Properties|$m_objectTabPage|#1/[Pane]$splitContainer1|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Pane1PANE);

            Pane2PANE = new Pane()
            {
                Tag = "[PageList]$m_propertyTabs|#1/[Window]Class Properties|#1/[Pane]Class Properties|$m_objectTabPage|#1/[Pane]$splitContainer1|#1/[Pane]$13373774|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Pane2PANE);

            CategoriesTV = new TreeView()
            {
                Tag = "[PageList]$m_propertyTabs|#1/[Window]Class Properties|#1/[Pane]Class Properties|$m_objectTabPage|#1/[Pane]$splitContainer1|#1/[Pane]$13373774|#1/[TreeView]Categories:|$m_objectDefinitionTreeView|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(CategoriesTV);

            Categories1SB = new ScrollBar()
            {
                Tag = "[PageList]$m_propertyTabs|#1/[Window]Class Properties|#1/[Pane]Class Properties|$m_objectTabPage|#1/[Pane]$splitContainer1|#1/[Pane]$13373774|#1/[TreeView]Categories:|$m_objectDefinitionTreeView|#1/[ScrollBar]Categories:[1]|$Horizontal ScrollBar|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Categories1SB);

            Categories2SB = new ScrollBar()
            {
                Tag = "[PageList]$m_propertyTabs|#1/[Window]Class Properties|#1/[Pane]Class Properties|$m_objectTabPage|#1/[Pane]$splitContainer1|#1/[Pane]$13373774|#1/[TreeView]Categories:|$m_objectDefinitionTreeView|#1/[ScrollBar]Categories:[2]|$Vertical ScrollBar|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Categories2SB);

            CategoriesST = new StaticText()
            {
                Tag = "[PageList]$m_propertyTabs|#1/[Window]Class Properties|#1/[Pane]Class Properties|$m_objectTabPage|#1/[Pane]$splitContainer1|#1/[Pane]$13373774|#1/[StaticText]Categories:|$m_objectCategoryLabel|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(CategoriesST);

            Pane3PANE = new Pane()
            {
                Tag = "[PageList]$m_propertyTabs|#1/[Window]Class Properties|#1/[Pane]Class Properties|$m_objectTabPage|#1/[Pane]$splitContainer1|#1/[Pane]$11079236|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Pane3PANE);

            PropertiesLB = new ListBox()
            {
                Tag = "[PageList]$m_propertyTabs|#1/[Window]Class Properties|#1/[Pane]Class Properties|$m_objectTabPage|#1/[Pane]$splitContainer1|#1/[Pane]$11079236|#2/[ListBox]Properties:|$m_objectPropertyListBox|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(PropertiesLB);

            ClassNameLBI = new ListBoxItem()
            {
                Tag = "[PageList]$m_propertyTabs|#1/[Window]Class Properties|#1/[Pane]Class Properties|$m_objectTabPage|#1/[Pane]$splitContainer1|#1/[Pane]$11079236|#2/[ListBox]Properties:|$m_objectPropertyListBox|#1/[ListBoxItem]Class Name|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ClassNameLBI);

            DescriptionLBI = new ListBoxItem()
            {
                Tag = "[PageList]$m_propertyTabs|#1/[Window]Class Properties|#1/[Pane]Class Properties|$m_objectTabPage|#1/[Pane]$splitContainer1|#1/[Pane]$11079236|#2/[ListBox]Properties:|$m_objectPropertyListBox|#1/[ListBoxItem]Description|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(DescriptionLBI);

            ManufacturerLBI = new ListBoxItem()
            {
                Tag = "[PageList]$m_propertyTabs|#1/[Window]Class Properties|#1/[Pane]Class Properties|$m_objectTabPage|#1/[Pane]$splitContainer1|#1/[Pane]$11079236|#2/[ListBox]Properties:|$m_objectPropertyListBox|#1/[ListBoxItem]Manufacturer|#3",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ManufacturerLBI);

            ModelNumberLBI = new ListBoxItem()
            {
                Tag = "[PageList]$m_propertyTabs|#1/[Window]Class Properties|#1/[Pane]Class Properties|$m_objectTabPage|#1/[Pane]$splitContainer1|#1/[Pane]$11079236|#2/[ListBox]Properties:|$m_objectPropertyListBox|#1/[ListBoxItem]Model Number|#4",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ModelNumberLBI);

            SupplierLBI = new ListBoxItem()
            {
                Tag = "[PageList]$m_propertyTabs|#1/[Window]Class Properties|#1/[Pane]Class Properties|$m_objectTabPage|#1/[Pane]$splitContainer1|#1/[Pane]$11079236|#2/[ListBox]Properties:|$m_objectPropertyListBox|#1/[ListBoxItem]Supplier|#5",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(SupplierLBI);

            CommentLBI = new ListBoxItem()
            {
                Tag = "[PageList]$m_propertyTabs|#1/[Window]Class Properties|#1/[Pane]Class Properties|$m_objectTabPage|#1/[Pane]$splitContainer1|#1/[Pane]$11079236|#2/[ListBox]Properties:|$m_objectPropertyListBox|#1/[ListBoxItem]Comment|#6",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(CommentLBI);

            PropertiesST = new StaticText()
            {
                Tag = "[PageList]$m_propertyTabs|#1/[Window]Class Properties|#1/[Pane]Class Properties|$m_objectTabPage|#1/[Pane]$splitContainer1|#1/[Pane]$11079236|#2/[StaticText]Properties:|$m_objectPropertyLabel|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(PropertiesST);

            ProjectPropertiesWIN = new Window()
            {
                Tag = "[PageList]$m_propertyTabs|#1/[Window]Project Properties|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ProjectPropertiesWIN);

            DrawingPropertiesWIN = new Window()
            {
                Tag = "[PageList]$m_propertyTabs|#1/[Window]Drawing Properties|#3",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(DrawingPropertiesWIN);

            SelectDataSourceCTL = new TitleBar()
            {
                Tag = "[TitleBar]Select Data Source|$TitleBar|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(SelectDataSourceCTL);

            SystemMenuBarWIN = new CustomWin()
            {
                Tag = "[TitleBar]Select Data Source|$TitleBar|#1/[CustomWin]System Menu Bar|$SelectDataSource|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(SystemMenuBarWIN);

            SystemMI = new MenuItem()
            {
                Tag = "[TitleBar]Select Data Source|$TitleBar|#1/[CustomWin]System Menu Bar|$SelectDataSource|#1/[MenuItem]System|$Item 1|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(SystemMI);

            ClosePB = new PushButton()
            {
                Tag = "[TitleBar]Select Data Source|$TitleBar|#1/[PushButton]Close|$Close|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ClosePB);
        }
    }
}
