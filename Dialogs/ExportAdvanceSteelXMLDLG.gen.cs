// This file is auto-generated - do not hand edit this file.

using Autodesk.GUIHarness;
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{

    [UIElement(Tag = "[DialogBox]Export Advance Steel XML file", Parent = typeof(DialogBox))]
    public partial class ExportAdvanceSteelXMLDLG : Autodesk.GUIHarness.AutoCAD.AcDialogBox
    {
        public  PushButton SavePB;
        public  PushButton CancelPB;

        partial void OnInitialize();

        public ExportAdvanceSteelXMLDLG()
        {
            InitializeComponent();
            OnInitialize();
        }

        private void InitializeComponent()
        {

            SavePB = new PushButton()
            {
                Tag = "[PushButton]Save|$1|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(SavePB);

            CancelPB = new PushButton()
            {
                Tag = "[PushButton]Cancel|$2|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(CancelPB);
        }
    }
}
