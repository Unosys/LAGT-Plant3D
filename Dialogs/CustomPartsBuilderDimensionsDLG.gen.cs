// This file is auto-generated - do not hand edit this file.

using Autodesk.GUIHarness;
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{

    [UIElement(Tag = "[Pane]Dimensions|$CustomPartPicPreview", Parent = typeof(Plant3D), GUIType = GuiType.UIA)]
    public partial class CustomPartsBuilderDimensionsDLG : Pane
    {
        public  TitleBar DimensionsCTL;
        public  CustomWin SystemMenuBarWIN;
        public  MenuItem SystemMI;
        public  PushButton ClosePB;

        partial void OnInitialize();

        public CustomPartsBuilderDimensionsDLG()
        {
            InitializeComponent();
            OnInitialize();
        }

        private void InitializeComponent()
        {

            DimensionsCTL = new TitleBar()
            {
                Tag = "[TitleBar]Dimensions|$TitleBar",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(DimensionsCTL);

            SystemMenuBarWIN = new CustomWin()
            {
                Tag = "[TitleBar]Dimensions|$TitleBar/[CustomWin]System Menu Bar|$CustomPartPicPreview",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(SystemMenuBarWIN);

            SystemMI = new MenuItem()
            {
                Tag = "[TitleBar]Dimensions|$TitleBar/[CustomWin]System Menu Bar|$CustomPartPicPreview/[MenuItem]System|$Item 1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(SystemMI);

            ClosePB = new PushButton()
            {
                Tag = "[TitleBar]Dimensions|$TitleBar/[PushButton]Close|$Close",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ClosePB);
        }
    }
}
