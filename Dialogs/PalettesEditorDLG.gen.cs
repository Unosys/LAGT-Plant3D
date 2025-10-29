// This file is auto-generated - do not hand edit this file.

using Autodesk.GUIHarness;
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{

    [UIElement(Tag = "[Pane]*/$PaletteEditorForm")]
    public partial class PalettesEditorDLG : Pane
    {
        public  CustomWin BtnAddColor;
        public  CustomWin BtnAddPalette;
        public  CustomWin BtnClearColor;
        public  CustomWin BtnClose;
        public  CustomWin BtnCopyPalette;
        public  CustomWin BtnRemoveColor;
        public  CustomWin BtnRemovePalette;
        public  CustomWin DevExpressXtraEditorsVScrollBar;
        public  CustomWin LabelControl1;
        public  CustomWin LbPaletteColors;
        public  CustomWin LbPalettes;
        public  CustomWin TbPaletteName;

        partial void OnInitialize();

        public PalettesEditorDLG()
        {
            InitializeComponent();
            OnInitialize();
        }

        private void InitializeComponent()
        {

            BtnAddColor = new CustomWin()
            {
                Tag = "[CustomWin]$btnAddColor",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(BtnAddColor);

            BtnAddPalette = new CustomWin()
            {
                Tag = "[CustomWin]$btnAddPalette",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(BtnAddPalette);

            BtnClearColor = new CustomWin()
            {
                Tag = "[CustomWin]$btnClearColor",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(BtnClearColor);

            BtnClose = new CustomWin()
            {
                Tag = "[CustomWin]$btnClose",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(BtnClose);

            BtnCopyPalette = new CustomWin()
            {
                Tag = "[CustomWin]$btnCopyPalette",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(BtnCopyPalette);

            BtnRemoveColor = new CustomWin()
            {
                Tag = "[CustomWin]$btnRemoveColor",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(BtnRemoveColor);

            BtnRemovePalette = new CustomWin()
            {
                Tag = "[CustomWin]$btnRemovePalette",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(BtnRemovePalette);

            DevExpressXtraEditorsVScrollBar = new CustomWin()
            {
                Tag = "[CustomWin]$lbPalettes",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(DevExpressXtraEditorsVScrollBar);

            LabelControl1 = new CustomWin()
            {
                Tag = "[CustomWin]$labelControl1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(LabelControl1);

            LbPaletteColors = new CustomWin()
            {
                Tag = "[CustomWin]$lbPaletteColors",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(LbPaletteColors);

            LbPalettes = new CustomWin()
            {
                Tag = "[CustomWin]$lbPalettes",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(LbPalettes);

            TbPaletteName = new CustomWin()
            {
                Tag = "[CustomWin]$tbPaletteName",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(TbPaletteName);
        }
    }
}
