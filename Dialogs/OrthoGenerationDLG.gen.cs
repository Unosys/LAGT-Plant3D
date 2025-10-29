// This file is auto-generated - do not hand edit this file.

using Autodesk.GUIHarness;
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{

    [UIElement(Tag = "[Window]Ortho Generation|$Window_1", Parent = typeof(Desktop), GUIType = GuiType.UIA)]
    public partial class OrthoGenerationDLG : Autodesk.GUIHarness.AutoCAD.AcDialogBox
    {
        public  TitleBar OrthoGenerationCTL;
        public  CustomWin SystemMenuBarWIN;
        public  MenuItem SystemMI;
        public  PushButton ClosePB;
        public  StaticText OrthoGenerationInProgressST;
        public  StaticText QueryingDrawings1ST;
        public  StaticText QueryingDrawings2ST;
        public  Image Image1IMG;
        public  StaticText CollectingGeometry1ST;
        public  StaticText CollectingGeometry2ST;
        public  Image Image2IMG;
        public  StaticText ClippingGeometry1ST;
        public  StaticText ClippingGeometry2ST;
        public  Image Image3IMG;
        public  StaticText ProjectionHiddenLine1ST;
        public  StaticText ProjectionHiddenLine2ST;
        public  Image Image4IMG;
        public  StaticText PreparingOrthographicOutput1ST;
        public  StaticText PreparingOrthographicOutput2ST;
        public  Image Image5IMG;

        partial void OnInitialize();

        public OrthoGenerationDLG()
        {
            InitializeComponent();
            OnInitialize();
        }

        private void InitializeComponent()
        {

            OrthoGenerationCTL = new TitleBar()
            {
                Tag = "[TitleBar]Ortho Generation|$TitleBar|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(OrthoGenerationCTL);

            SystemMenuBarWIN = new CustomWin()
            {
                Tag = "[TitleBar]Ortho Generation|$TitleBar|#1/[CustomWin]System Menu Bar|$SystemMenuBar|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(SystemMenuBarWIN);

            SystemMI = new MenuItem()
            {
                Tag = "[TitleBar]Ortho Generation|$TitleBar|#1/[CustomWin]System Menu Bar|$SystemMenuBar|#1/[MenuItem]System|$Item 1|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(SystemMI);

            ClosePB = new PushButton()
            {
                Tag = "[TitleBar]Ortho Generation|$TitleBar|#1/[PushButton]Close|$Close|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ClosePB);

            OrthoGenerationInProgressST = new StaticText()
            {
                Tag = "[StaticText]Ortho generation in progress; this may take several minutes*|$Introduction1|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(OrthoGenerationInProgressST);

            QueryingDrawings1ST = new StaticText()
            {
                Tag = "[StaticText]Querying drawings|$FirstLabel|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(QueryingDrawings1ST);

            QueryingDrawings2ST = new StaticText()
            {
                Tag = "[StaticText]Querying drawings|$FirstLabel|#2/[StaticText]Querying drawings|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(QueryingDrawings2ST);

            Image1IMG = new Image()
            {
                Tag = "[Image]$FirstImage|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Image1IMG);

            CollectingGeometry1ST = new StaticText()
            {
                Tag = "[StaticText]Collecting geometry|$SecondLabel|#3",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(CollectingGeometry1ST);

            CollectingGeometry2ST = new StaticText()
            {
                Tag = "[StaticText]Collecting geometry|$SecondLabel|#3/[StaticText]Collecting geometry|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(CollectingGeometry2ST);

            Image2IMG = new Image()
            {
                Tag = "[Image]$SecondImage|#3",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Image2IMG);

            ClippingGeometry1ST = new StaticText()
            {
                Tag = "[StaticText]Clipping Geometry|$ThirdLabel|#4",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ClippingGeometry1ST);

            ClippingGeometry2ST = new StaticText()
            {
                Tag = "[StaticText]Clipping Geometry|$ThirdLabel|#4/[StaticText]Clipping Geometry|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ClippingGeometry2ST);

            Image3IMG = new Image()
            {
                Tag = "[Image]$ThirdImage|#4",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Image3IMG);

            ProjectionHiddenLine1ST = new StaticText()
            {
                Tag = "[StaticText]Projection *|$FourthLabel|#5",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ProjectionHiddenLine1ST);

            ProjectionHiddenLine2ST = new StaticText()
            {
                Tag = "[StaticText]Projection *|$FourthLabel|#5/[StaticText]Projection *|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ProjectionHiddenLine2ST);

            Image4IMG = new Image()
            {
                Tag = "[Image]$FourthImage|#5",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Image4IMG);

            PreparingOrthographicOutput1ST = new StaticText()
            {
                Tag = "[StaticText]Preparing orthographic output|$FifthLabel|#6",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(PreparingOrthographicOutput1ST);

            PreparingOrthographicOutput2ST = new StaticText()
            {
                Tag = "[StaticText]Preparing orthographic output|$FifthLabel|#6/[StaticText]Preparing orthographic output|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(PreparingOrthographicOutput2ST);

            Image5IMG = new Image()
            {
                Tag = "[Image]$FifthImage|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Image5IMG);
        }
    }
}
