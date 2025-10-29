// This file is auto-generated - do not hand edit this file.

using Autodesk.GUIHarness;
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{

    [UIElement(Tag = "[Window]Catalog Properties|$Window_1", Parent = typeof(MainWin))]
    public partial class CatalogPropertiesGeneralPropertiesDLG : Autodesk.GUIHarness.AutoCAD.AcDialogBox
    {
        public  PushButton EditOperatorAssignmentsPB;
        public  Window GeneralPropertiesWIN;
        public  StaticText GeneralPropertiesST;
        public  Window SizesWIN;
        public  StaticText SizesST;
        public  PushButton PushButton1PB;
        public  PushButton PushButton2PB;
        public  PushButton PushButton3PB;

        partial void OnInitialize();

        public CatalogPropertiesGeneralPropertiesDLG()
        {
            InitializeComponent();
            OnInitialize();
        }

        private void InitializeComponent()
        {

            EditOperatorAssignmentsPB = new PushButton()
            {
                Tag = "[PageList]$PropertiesTabControl|#1/[Window]General Properties|$TabItem_1|#2/[PushButton]Edit Operator Assignments|$Button_1|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(EditOperatorAssignmentsPB);

            GeneralPropertiesWIN = new Window()
            {
                Tag = "[PageList]$PropertiesTabControl|#1/[Window]General Properties|$TabItem_1|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(GeneralPropertiesWIN);

            GeneralPropertiesST = new StaticText()
            {
                Tag = "[PageList]$PropertiesTabControl|#1/[Window]General Properties|$TabItem_1|#1/[StaticText]General Properties|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(GeneralPropertiesST);

            SizesWIN = new Window()
            {
                Tag = "[PageList]$PropertiesTabControl|#1/[Window]Sizes|$TabItem_2|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(SizesWIN);

            SizesST = new StaticText()
            {
                Tag = "[PageList]$PropertiesTabControl|#1/[Window]Sizes|$TabItem_2|#2/[StaticText]Sizes|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(SizesST);

            PushButton1PB = new PushButton()
            {
                Tag = "[PageList]$PropertiesTabControl|#1/[Window]Sizes|$TabItem_2|#2/[PushButton]$Add_Button|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(PushButton1PB);

            PushButton2PB = new PushButton()
            {
                Tag = "[PageList]$PropertiesTabControl|#1/[Window]Sizes|$TabItem_2|#2/[PushButton]$Duplicate_Button|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(PushButton2PB);

            PushButton3PB = new PushButton()
            {
                Tag = "[PageList]$PropertiesTabControl|#1/[Window]Sizes|$TabItem_2|#2/[PushButton]$Remove_Button|#3",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(PushButton3PB);
        }
    }
}
