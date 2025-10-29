// This file is auto-generated - do not hand edit this file.

using Autodesk.GUIHarness;
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{

    [UIElement(Tag = "[Window]Add Property|$PropertyWindowInConnections")]
    public partial class AddPropertyConnections : Autodesk.GUIHarness.AutoCAD.AcDialogBox
    {
        public  PushButton AddPropertyPB;
        public  PushButton CancelPB;
        public  Window PCFWIN;
        public  StaticText PCFST;
        public  Window SymbolsWIN;
        public  StaticText SymbolsST;

        partial void OnInitialize();

        public AddPropertyConnections()
        {
            InitializeComponent();
            OnInitialize();
        }

        private void InitializeComponent()
        {

            AddPropertyPB = new PushButton()
            {
                Tag = "[PushButton]Add Property|$AddPropertyBtn|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(AddPropertyPB);

            CancelPB = new PushButton()
            {
                Tag = "[PushButton]Cancel|$CancelBtn|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(CancelPB);

            PCFWIN = new Window()
            {
                Tag = "[PageList]$AddPropertyTabControl|#1/[Window]PCF|$PCFTabItem|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(PCFWIN);

            PCFST = new StaticText()
            {
                Tag = "[PageList]$AddPropertyTabControl|#1/[Window]PCF|$PCFTabItem|#1/[StaticText]PCF|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(PCFST);

            SymbolsWIN = new Window()
            {
                Tag = "[PageList]$AddPropertyTabControl|#1/[Window]Symbols|$SymbolsTabItem|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(SymbolsWIN);

            SymbolsST = new StaticText()
            {
                Tag = "[PageList]$AddPropertyTabControl|#1/[Window]Symbols|$SymbolsTabItem|#2/[StaticText]#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(SymbolsST);
        }
    }
}
