// This file is auto-generated - do not hand edit this file.

using Autodesk.GUIHarness;
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{

    [UIElement(Tag = "[Pane]Indicator Type|$IndicatorTypeForm", Parent = typeof(Pane))]
    public partial class FibonacciIndicatorKindsDLG : Pane
    {
        public  PushButton CancelPB;
        public  PushButton OKPB;
        public  ListBox ListBoxLB;
        public  ListBoxItem RegressionLineLBI;
        public  ListBoxItem TrendLineLBI;
        public  ListBoxItem FibonacciArcsLBI;
        public  ListBoxItem FibonacciFansLBI;
        public  ListBoxItem FibonacciRetracementLBI;
        public  ListBoxItem SimpleMovingAverageLBI;
        public  ListBoxItem ExponentialMovingAverageLBI;
        public  ListBoxItem WeightedMovingAverageLBI;
        public  ListBoxItem TriangularMovingAverageLBI;
        public  StaticText StaticTextST;
        public  TitleBar IndicatorTypeCTL;

        partial void OnInitialize();

        public FibonacciIndicatorKindsDLG()
        {
            InitializeComponent();
            OnInitialize();
        }

        private void InitializeComponent()
        {

            CancelPB = new PushButton()
            {
                Tag = "[PushButton]Cancel|$btnCancel|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(CancelPB);

            OKPB = new PushButton()
            {
                Tag = "[PushButton]OK|$btnOk|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(OKPB);

            ListBoxLB = new ListBox()
            {
                Tag = "[ListBox]$listView|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ListBoxLB);

            RegressionLineLBI = new ListBoxItem()
            {
                Tag = "[ListBox]$listView|#1/[ListBoxItem]Regression Line|#4",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(RegressionLineLBI);

            TrendLineLBI = new ListBoxItem()
            {
                Tag = "[ListBox]$listView|#1/[ListBoxItem]Trend Line|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(TrendLineLBI);

            FibonacciArcsLBI = new ListBoxItem()
            {
                Tag = "[ListBox]$listView|#1/[ListBoxItem]Fibonacci Arcs|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(FibonacciArcsLBI);

            FibonacciFansLBI = new ListBoxItem()
            {
                Tag = "[ListBox]$listView|#1/[ListBoxItem]Fibonacci Fans|#3",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(FibonacciFansLBI);

            FibonacciRetracementLBI = new ListBoxItem()
            {
                Tag = "[ListBox]$listView|#1/[ListBoxItem]Fibonacci Retracement|#5",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(FibonacciRetracementLBI);

            SimpleMovingAverageLBI = new ListBoxItem()
            {
                Tag = "[ListBox]$listView|#1/[ListBoxItem]Simple Moving Average|#6",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(SimpleMovingAverageLBI);

            ExponentialMovingAverageLBI = new ListBoxItem()
            {
                Tag = "[ListBox]$listView|#1/[ListBoxItem]Exponential Moving Average|#7",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ExponentialMovingAverageLBI);

            WeightedMovingAverageLBI = new ListBoxItem()
            {
                Tag = "[ListBox]$listView|#1/[ListBoxItem]Weighted Moving Average|#8",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(WeightedMovingAverageLBI);

            TriangularMovingAverageLBI = new ListBoxItem()
            {
                Tag = "[ListBox]$listView|#1/[ListBoxItem]Triangular Moving Average|#9",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(TriangularMovingAverageLBI);

            StaticTextST = new StaticText()
            {
                Tag = "[StaticText]$separator|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(StaticTextST);

            IndicatorTypeCTL = new TitleBar()
            {
                Tag = "[TitleBar]Indicator Type|$TitleBar|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(IndicatorTypeCTL);
        }
    }
}
