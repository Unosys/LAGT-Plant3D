// This file is auto-generated - do not hand edit this file.

using Autodesk.GUIHarness;
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{

    [UIElement(Tag = "[Window]Create New Component", Parent = typeof(MainWin))]
    public partial class CreateNewComponentDLG1 : Autodesk.GUIHarness.AutoCAD.AcDialogBox
    {
        public  RadioButton GraphicsSelection1RB;
        public  RadioButton GraphicsSelection2RB;
        public  PushButton CreatePB;
        public  PushButton CancelPB;
        public  PushButton PushButton5PB;
        public  ListBox ListBoxLB;
        public  ComboBox NumberOfConnectionPortsCB;
        public  PopupList SizeFromPL;
        public  PopupList ToPL;

        partial void OnInitialize();

        public CreateNewComponentDLG1()
        {
            InitializeComponent();
            OnInitialize();
        }

        private void InitializeComponent()
        {

            GraphicsSelection1RB = new RadioButton()
            {
                Tag = "[CustomWin]$UserControl_ComponentEditor|#1/[GroupBox]Graphics Selection|$P3DGeometryGroup|#2/[RadioButton]Graphics Selection|$GenParametricRadioBtn|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(GraphicsSelection1RB);

            GraphicsSelection2RB = new RadioButton()
            {
                Tag = "[CustomWin]$UserControl_ComponentEditor|#1/[GroupBox]Graphics Selection|$P3DGeometryGroup|#2/[RadioButton]Graphics Selection|$GenCustomRadioBtn|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(GraphicsSelection2RB);

            CreatePB = new PushButton()
            {
                Tag = "[CustomWin]$UserControl_ComponentEditor|#1/[PushButton]Create|$CreateNewComponentCreateBtn|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(CreatePB);

            CancelPB = new PushButton()
            {
                Tag = "[CustomWin]$UserControl_ComponentEditor|#1/[PushButton]Cancel|$CreateNewComponnetCancelBtn|#3",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(CancelPB);

            PushButton5PB = new PushButton()
            {
                Tag = "[CustomWin]$UserControl_ComponentEditor|#1/[GroupBox]Graphics Selection|$P3DGeometryGroup|#2/[PushButton]$Chevron|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(PushButton5PB);

            ListBoxLB = new ListBox()
            {
                Tag = "[CustomWin]$UserControl_ComponentEditor|#1/[GroupBox]Graphics Selection|$P3DGeometryGroup|#2/[CustomWin]$P3dGraphicsThumbnailListBox|#1/[ListBox]$ListBox_1|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ListBoxLB);

            NumberOfConnectionPortsCB = new ComboBox()
            {
                Tag = "[CustomWin]$UserControl_ComponentEditor|#1/[GroupBox]Graphics Selection|$P3DGeometryGroup2|#2/[ComboBox]Number of Connection Ports:|$PortNumberText|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(NumberOfConnectionPortsCB);

            SizeFromPL = new PopupList()
            {
                Tag = "[CustomWin]$UserControl_ComponentEditor|#1/[GroupBox]Basic Part Family Information|$PropertiesFilterGroup|#1/[PopupList]Size From:|$SizeRangeFromComboBox|#3",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(SizeFromPL);

            ToPL = new PopupList()
            {
                Tag = "[CustomWin]$UserControl_ComponentEditor|#1/[GroupBox]Basic Part Family Information|$PropertiesFilterGroup|#1/[PopupList]To:|$SizeRangeToComboBox|#4",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ToPL);
        }
    }
}
