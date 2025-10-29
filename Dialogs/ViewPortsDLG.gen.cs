// This file is auto-generated - do not hand edit this file.

using Autodesk.GUIHarness;
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{

    [UIElement(Tag = "[DialogBox]Viewports", Parent = typeof(Plant3D))]
    public partial class ViewPortsDLG : Autodesk.GUIHarness.AutoCAD.AcDialogBox
    {
        public  DialogBox DialogBox1;
        public  StaticText CurrentNameText;
        public  StaticText StandardViewportsText;
        public  ListView StandardViewports;
        public  StaticText ViewportSpacingText;
        public  TextField ViewportSpacing;
        public  UpDown Spin3;
        public  StaticText SetupText;
        public  PopupList Setup;
        public  StaticText PreviewText;
        public  PushButton Preview;
        public  StaticText ChangeViewToText;
        public  PopupList ChangeViewTo;
        public  StaticText VisualStyleText;
        public  PopupList VisualStyle;
        public  StaticText ActiveModelConfigurationTe;
        public  PushButton OK;
        public  PushButton Cancel;
        public  PushButton Help;
        public  PageList PageList1;

        partial void OnInitialize();

        public ViewPortsDLG()
        {
            InitializeComponent();
            OnInitialize();
        }

        private void InitializeComponent()
        {

            DialogBox1 = new DialogBox()
            {
                Tag = "$0",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(DialogBox1);

            CurrentNameText = new StaticText()
            {
                Tag = "[StaticText]Current name:|$1834",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(CurrentNameText);

            StandardViewportsText = new StaticText()
            {
                Tag = "[StaticText]Standard viewports:|$1838",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(StandardViewportsText);

            StandardViewports = new ListView()
            {
                Tag = "[ListView]Standard viewports:|$1820",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(StandardViewports);

            ViewportSpacingText = new StaticText()
            {
                Tag = "[StaticText]Viewport Spacing:|$1824",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ViewportSpacingText);

            ViewportSpacing = new TextField()
            {
                Tag = "[TextField]Viewport Spacing:|$1872",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ViewportSpacing);

            Spin3 = new UpDown()
            {
                Tag = "[UpDown]Spin3|$1873",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Spin3);

            SetupText = new StaticText()
            {
                Tag = "[StaticText]Setup:|$1826",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(SetupText);

            Setup = new PopupList()
            {
                Tag = "[PopupList]Setup:|$1823",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Setup);

            PreviewText = new StaticText()
            {
                Tag = "[StaticText]Preview|$1822",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(PreviewText);

            Preview = new PushButton()
            {
                Tag = "[PushButton]Preview|$1836",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Preview);

            ChangeViewToText = new StaticText()
            {
                Tag = "[StaticText]Change view to:|$1827",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ChangeViewToText);

            ChangeViewTo = new PopupList()
            {
                Tag = "[PopupList]Change view to:|$1825",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ChangeViewTo);

            VisualStyleText = new StaticText()
            {
                Tag = "[StaticText]Visual Style:|$1865",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(VisualStyleText);

            VisualStyle = new PopupList()
            {
                Tag = "[PopupList]Visual Style:|$1833",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(VisualStyle);

            ActiveModelConfigurationTe = new StaticText()
            {
                Tag = "[StaticText]?Active Model Configuration?|$1877",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ActiveModelConfigurationTe);

            OK = new PushButton()
            {
                Tag = "[PushButton]OK|$1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(OK);

            Cancel = new PushButton()
            {
                Tag = "[PushButton]Cancel|$2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Cancel);

            Help = new PushButton()
            {
                Tag = "[PushButton]Help|$57670",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Help);

            PageList1 = new PageList()
            {
                Tag = "$1819",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(PageList1);
        }
    }
}
