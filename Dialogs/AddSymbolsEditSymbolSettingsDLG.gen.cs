// This file is auto-generated - do not hand edit this file.

using Autodesk.GUIHarness;
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{

    [UIElement(Tag = "[DialogBox]Add Symbols - Edit Symbol Settings", Parent = typeof(Plant3D))]
    public partial class AddSymbolsEditSymbolSettingsDLG : Autodesk.GUIHarness.AutoCAD.AcDialogBox
    {
        public  PushButton FinishPB;
        public  PushButton Cancel;
        public  PushButton Help;
        public  ListBox SelectedBlocks;
        public  TextField PIDClassDefinitionsTF;
        public  PushButton BrowsePB;
        public  CustomWin PIDClassDefinitions2;
        public  ListBox ListBox1;
        public  StaticText SelectedBlocksText;
        public  StaticText PIDClassDefinitionsText;

        partial void OnInitialize();

        public AddSymbolsEditSymbolSettingsDLG()
        {
            InitializeComponent();
            OnInitialize();
        }

        private void InitializeComponent()
        {

            FinishPB = new PushButton()
            {
                Tag = "[PushButton]Finish|$1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(FinishPB);

            Cancel = new PushButton()
            {
                Tag = "[PushButton]Cancel|$1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Cancel);

            Help = new PushButton()
            {
                Tag = "[PushButton]Help|$9",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Help);

            SelectedBlocks = new ListBox()
            {
                Tag = "[ListBox]Selected Blocks:|$4793",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(SelectedBlocks);

            PIDClassDefinitionsTF = new TextField()
            {
                Tag = "[TextField]P&ID Class Definitions:|$4794",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(PIDClassDefinitionsTF);

            BrowsePB = new PushButton()
            {
                Tag = "$4795",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(BrowsePB);

            PIDClassDefinitions2 = new CustomWin()
            {
                Tag = "[CustomWin][ATL:*]P&ID Class Definitions:|[ATL:*]$6",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(PIDClassDefinitions2);

            ListBox1 = new ListBox()
            {
                Tag = "$239",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ListBox1);

            SelectedBlocksText = new StaticText()
            {
                Tag = "[StaticText]Selected Blocks:|$4797",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(SelectedBlocksText);

            PIDClassDefinitionsText = new StaticText()
            {
                Tag = "[StaticText]P&ID Class Definitions:|$4798",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(PIDClassDefinitionsText);
        }
    }
}
