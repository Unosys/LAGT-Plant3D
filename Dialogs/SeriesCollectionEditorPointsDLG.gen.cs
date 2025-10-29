// This file is auto-generated - do not hand edit this file.

using Autodesk.GUIHarness;
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{

    [UIElement(Tag = "[Pane]Series Collection Editor|$SeriesCollectionForm", Parent = typeof(Pane), GUIType = GuiType.UIA)]
    public partial class SeriesCollectionEditorPointsDLG : Pane
    {
        public  StaticText StaticTextST;
        public  Pane PanelSeriesPANE;
        public  ListBox ListBoxLB;
        public  PushButton ClosePB;
        public  PushButton RemovePB;
        public  PushButton CopyPB;
        public  PushButton AddPB;
        public  PushButton PushButton1PB;
        public  PushButton PushButton2PB;
        public  Pane PointsPANE;

        partial void OnInitialize();

        public SeriesCollectionEditorPointsDLG()
        {
            InitializeComponent();
            OnInitialize();
        }

        private void InitializeComponent()
        {

            StaticTextST = new StaticText()
            {
                Tag = "[StaticText]$labelSeparator|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(StaticTextST);

            PanelSeriesPANE = new Pane()
            {
                Tag = "[Pane]panelSeries|$panelSeries|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(PanelSeriesPANE);

            ListBoxLB = new ListBox()
            {
                Tag = "[Pane]panelSeries|$panelSeries|#1/[ListBox]$lvSeries|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ListBoxLB);

            ClosePB = new PushButton()
            {
                Tag = "[PushButton]$btnClose|#6",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ClosePB);

            RemovePB = new PushButton()
            {
                Tag = "[PushButton]*Remove*|$btnRemove|#5",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(RemovePB);

            CopyPB = new PushButton()
            {
                Tag = "[PushButton]*Copy*|$btnCopy|#4",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(CopyPB);

            AddPB = new PushButton()
            {
                Tag = "[PushButton]$btnAdd|#3",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(AddPB);

            PushButton1PB = new PushButton()
            {
                Tag = "[PushButton]$btnDown|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(PushButton1PB);

            PushButton2PB = new PushButton()
            {
                Tag = "[PushButton]$btnUp|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(PushButton2PB);

            PointsPANE = new Pane()
            {
                Tag = "[PageList]$tabControl|#1/[Pane]Points|$tabPagePoints|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(PointsPANE);
        }
    }
}
