// This file is auto-generated - do not hand edit this file.

using Autodesk.GUIHarness;
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{

    [UIElement(Tag = "[MainWin]Autodesk Catalog Builder for AutoCAD Plant 3D 202*|$Window|#1")]
    public partial class AutoCADPlant3DCatalogBuilderApplicationParametricGraphicsDLG : Autodesk.GUIHarness.MainWin
    {
        public  RadioButton Graphics1RB;
        public  RadioButton Graphics2RB;
        public  RadioButton Graphics3RB;

        partial void OnInitialize();

        public AutoCADPlant3DCatalogBuilderApplicationParametricGraphicsDLG()
        {
            InitializeComponent();
            OnInitialize();
        }

        private void InitializeComponent()
        {

            Graphics1RB = new RadioButton()
            {
                Tag = "[Pane]$ScrollViewer_2|#1/[GroupBox]$GroupBox_1|#2/[RadioButton]$RadioButton_1|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Graphics1RB);

            Graphics2RB = new RadioButton()
            {
                Tag = "[Pane]$ScrollViewer_2|#1/[GroupBox]$GroupBox_1|#2/[RadioButton]$RadioButton_2|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Graphics2RB);

            Graphics3RB = new RadioButton()
            {
                Tag = "[Pane]$ScrollViewer_2|#1/[GroupBox]$GroupBox_1|#2/[RadioButton]#3",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Graphics3RB);
        }
    }
}
