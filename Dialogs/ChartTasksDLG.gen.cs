// This file is auto-generated - do not hand edit this file.

using Autodesk.GUIHarness;
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{

    [UIElement(Tag = "[Pane]#1", Parent = typeof(Pane))]
    public partial class ChartTasksDLG : Autodesk.GUIHarness.Pane
    {
        public  Pane Pane1PANE;
        public  Pane Pane2PANE;
        public  StaticText DataSourceST;
        public  TextField DataSourceTF;
        public  PushButton Open1PB;
        public  Pane Pane3PANE;
        public  StaticText ParametersST;
        public  TextField ParametersTF;
        public  PushButton Open2PB;
        public  Pane Pane4PANE;
        public  StaticText StaticText1ST;
        public  Pane Pane5PANE;
        public  StaticText RunDesignerST;
        public  Link RunDesignerLINK;
        public  Pane RunDesignerPANE;
        public  StaticText SeriesST;
        public  Link SeriesLINK;
        public  Pane SeriesPANE;
        public  StaticText AnnotationsST;
        public  Link AnnotationsLINK;
        public  Pane AnnotationsPANE;
        public  StaticText PalettesST;
        public  Link PalettesLINK;
        public  Pane PalettesPANE;
        public  StaticText StaticText2ST;
        public  Pane Pane6PANE;
        public  StaticText SaveST;
        public  Link SaveLINK;
        public  Pane SavePANE;
        public  StaticText LoadST;
        public  Link LoadLINK;

        partial void OnInitialize();

        public ChartTasksDLG()
        {
            InitializeComponent();
            OnInitialize();
        }

        private void InitializeComponent()
        {

            Pane1PANE = new Pane()
            {
                Tag = "[Pane]#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Pane1PANE);

            Pane2PANE = new Pane()
            {
                Tag = "[Pane]#1/[Pane]#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Pane2PANE);

            DataSourceST = new StaticText()
            {
                Tag = "[Pane]#1/[Pane]#1/[StaticText]Data Source|$7603998|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(DataSourceST);

            DataSourceTF = new TextField()
            {
                Tag = "[Pane]#1/[Pane]#1/[TextField]Data Source|$2689544|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(DataSourceTF);

            Open1PB = new PushButton()
            {
                Tag = "[Pane]#1/[Pane]#1/[TextField]Data Source|$2689544|#1/[PushButton]Open|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Open1PB);

            Pane3PANE = new Pane()
            {
                Tag = "[Pane]#1/[Pane]$2558516|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Pane3PANE);

            ParametersST = new StaticText()
            {
                Tag = "[Pane]#1/[Pane]$2558516|#2/[StaticText]Parameters|$2886150|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ParametersST);

            ParametersTF = new TextField()
            {
                Tag = "[Pane]#1/[Pane]$2558516|#2/[TextField]Parameters|$10684696|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ParametersTF);

            Open2PB = new PushButton()
            {
                Tag = "[Pane]#1/[Pane]$2558516|#2/[TextField]Parameters|$10684696|#1/[PushButton]Open|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Open2PB);

            Pane4PANE = new Pane()
            {
                Tag = "[Pane]#1/[Pane]$2624048|#3",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Pane4PANE);

            StaticText1ST = new StaticText()
            {
                Tag = "[Pane]#1/[Pane]$2624048|#3/[StaticText]$16452128|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(StaticText1ST);

            Pane5PANE = new Pane()
            {
                Tag = "[Pane]#1/[Pane]$3868776|#4",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Pane5PANE);

            RunDesignerST = new StaticText()
            {
                Tag = "[Pane]#1/[Pane]$3868776|#4/[StaticText]Run Designer*|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(RunDesignerST);

            RunDesignerLINK = new Link()
            {
                Tag = "[Pane]#1/[Pane]$3868776|#4/[StaticText]Run Designer*|#1/[Link]Run Designer*|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(RunDesignerLINK);

            RunDesignerPANE = new Pane()
            {
                Tag = "[Pane]#1/[Pane]Run Designer*|$2558524|#5",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(RunDesignerPANE);

            SeriesST = new StaticText()
            {
                Tag = "[Pane]#1/[Pane]Run Designer*|$2558524|#5/[StaticText]Series*|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(SeriesST);

            SeriesLINK = new Link()
            {
                Tag = "[Pane]#1/[Pane]Run Designer*|$2558524|#5/[StaticText]Series*|#1/[Link]Series*|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(SeriesLINK);

            SeriesPANE = new Pane()
            {
                Tag = "[Pane]#1/[Pane]Series*|$2624012|#6",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(SeriesPANE);

            AnnotationsST = new StaticText()
            {
                Tag = "[Pane]#1/[Pane]Series*|$2624012|#6/[StaticText]Annotations*|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(AnnotationsST);

            AnnotationsLINK = new Link()
            {
                Tag = "[Pane]#1/[Pane]Series*|$2624012|#6/[StaticText]Annotations*|#1/[Link]Annotations*|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(AnnotationsLINK);

            AnnotationsPANE = new Pane()
            {
                Tag = "[Pane]#1/[Pane]Annotations*|$2361856|#7",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(AnnotationsPANE);

            PalettesST = new StaticText()
            {
                Tag = "[Pane]#1/[Pane]Annotations*|$2361856|#7/[StaticText]Palettes*|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(PalettesST);

            PalettesLINK = new Link()
            {
                Tag = "[Pane]#1/[Pane]Annotations*|$2361856|#7/[StaticText]Palettes*|#1/[Link]Palettes*|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(PalettesLINK);

            PalettesPANE = new Pane()
            {
                Tag = "[Pane]#1/[Pane]Palettes*|$2820674|#8",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(PalettesPANE);

            StaticText2ST = new StaticText()
            {
                Tag = "[Pane]#1/[Pane]Palettes*|$2820674|#8/[StaticText]$2492992|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(StaticText2ST);

            Pane6PANE = new Pane()
            {
                Tag = "[Pane]#1/[Pane]$2689562|#9",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Pane6PANE);

            SaveST = new StaticText()
            {
                Tag = "[Pane]#1/[Pane]$2689562|#9/[StaticText]Save*|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(SaveST);

            SaveLINK = new Link()
            {
                Tag = "[Pane]#1/[Pane]$2689562|#9/[StaticText]Save*|#1/[Link]Save*|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(SaveLINK);

            SavePANE = new Pane()
            {
                Tag = "[Pane]#1/[Pane]Save*|$2689604|#10",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(SavePANE);

            LoadST = new StaticText()
            {
                Tag = "[Pane]#1/[Pane]Save*|$2689604|#10/[StaticText]Load*|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(LoadST);

            LoadLINK = new Link()
            {
                Tag = "[Pane]#1/[Pane]Save*|$2689604|#10/[StaticText]Load*|#1/[Link]Load*|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(LoadLINK);
        }
    }
}
