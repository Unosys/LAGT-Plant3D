// This file is auto-generated - do not hand edit this file.

using Autodesk.GUIHarness;
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{

    [UIElement(Tag = "[DialogBox]Open", Parent = typeof(MainWin), GUIType = GuiType.UIA)]
    public partial class SpecUtilityCatalogImportDLG : Autodesk.GUIHarness.AutoCAD.AcDialogBox
    {
        public  PushButton OpenPB;
        public  PushButton CancelPB;
        public  ComboBox FileName;

        partial void OnInitialize();

        public SpecUtilityCatalogImportDLG()
        {
            InitializeComponent();
            OnInitialize();
        }

        private void InitializeComponent()
        {

            OpenPB = new PushButton()
            {
                Tag = "[PushButton]Open|$1|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(OpenPB);

            CancelPB = new PushButton()
            {
                Tag = "[PushButton]Cancel|$2|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(CancelPB);

            FileName = new ComboBox()
            {
                Tag = "[ComboBox]File name:|$1148|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(FileName);
        }
    }
}
