// This file is auto-generated - do not hand edit this file.

using Autodesk.GUIHarness;
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{

    [UIElement(Tag = "[DialogBox]Advance Steel XML Export|#1", Parent = typeof(Plant3D), GUIType = GuiType.WIN32)]
    public partial class AdvanceSteelXMLExportDLG : Autodesk.GUIHarness.AutoCAD.AcDialogBox
    {
        public  PushButton ExportPB;
        public  PushButton CancelPB;
        public  PushButton SpecifyRotationAngle0PB;
        public  TextField OutputFileTF;

        partial void OnInitialize();

        public AdvanceSteelXMLExportDLG()
        {
            InitializeComponent();
            OnInitialize();
        }

        private void InitializeComponent()
        {

            ExportPB = new PushButton()
            {
                Tag = "[PushButton]$1|#4",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ExportPB);

            CancelPB = new PushButton()
            {
                Tag = "[PushButton]$2|#5",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(CancelPB);

            SpecifyRotationAngle0PB = new PushButton()
            {
                Tag = "[PushButton]$2603|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(SpecifyRotationAngle0PB);

            OutputFileTF = new TextField()
            {
                Tag = "[TextField]Output file:|$2601|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(OutputFileTF);
        }
    }
}
