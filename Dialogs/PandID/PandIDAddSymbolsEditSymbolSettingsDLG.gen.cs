// This file is auto-generated - do not hand edit this file.

using Autodesk.GUIHarness;
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{

    [UIElement(Tag = "[DialogBox]#1|Add Symbols * Edit Symbol Settings", Parent = typeof(Pane), GUIType = GuiType.UIA)]
    public partial class PandIDAddSymbolsEditSymbolSettingsDLG : Autodesk.GUIHarness.AutoCAD.AcDialogBox
    {
        public  PushButton Finish;
        public  ScrollBar HorizontalScrollBar;
        public  TextField PIDClassDefinitions;
        public  StaticText PIDClassDefinitionsLabel;
        public  ListBox PIDClassDefinitionsListBox;
        public  PushButton BrowsePB;
        public  ListBox SelectedBlocks;
        public  StaticText SelectedBlocksLabel;

        partial void OnInitialize();

        public PandIDAddSymbolsEditSymbolSettingsDLG()
        {
            InitializeComponent();
            OnInitialize();
        }

        private void InitializeComponent()
        {

            Finish = new PushButton()
            {
                Tag = "[PushButton]$1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Finish);

            HorizontalScrollBar = new ScrollBar()
            {
                Tag = "[ScrollBar]$",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(HorizontalScrollBar);

            PIDClassDefinitions = new TextField()
            {
                Tag = "[TextField]$",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(PIDClassDefinitions);

            PIDClassDefinitionsLabel = new StaticText()
            {
                Tag = "[StaticText]$",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(PIDClassDefinitionsLabel);

            PIDClassDefinitionsListBox = new ListBox()
            {
                Tag = "[ListBox]$239",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(PIDClassDefinitionsListBox);

            BrowsePB = new PushButton()
            {
                Tag = "[PushButton]$4795",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(BrowsePB);

            SelectedBlocks = new ListBox()
            {
                Tag = "[Pane]$6|#1/[ListBox]$239|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(SelectedBlocks);

            SelectedBlocksLabel = new StaticText()
            {
                Tag = "[StaticText]$",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(SelectedBlocksLabel);
        }
    }
}
