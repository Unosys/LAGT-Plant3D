// This file is auto-generated - do not hand edit this file.

using Autodesk.GUIHarness;
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{

    [UIElement(Tag = "[Window]Convert AutoPLANT Specs and Catalogs|$SpecMigrationConversionWindow")]
    public partial class ConvertAutoPLANTSpecsAndCatalogsDLG : Window
    {
        public  PushButton CancelPB;
        public  PushButton PushButtonPB;
        public  PushButton AddPB;

        partial void OnInitialize();

        public ConvertAutoPLANTSpecsAndCatalogsDLG()
        {
            InitializeComponent();
            OnInitialize();
        }

        private void InitializeComponent()
        {

            CancelPB = new PushButton()
            {
                Tag = "[PushButton]Cancel|$Cancel",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(CancelPB);

            PushButtonPB = new PushButton()
            {
                Tag = "[PushButton]**|$Button_1|#3",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(PushButtonPB);

            AddPB = new PushButton()
            {
                Tag = "[PushButton]Add|$AddButton",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(AddPB);
        }
    }
}
