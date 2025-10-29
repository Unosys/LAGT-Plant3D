// This file is auto-generated - do not hand edit this file.

using Autodesk.GUIHarness;
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{

    [UIElement(Tag = "[Window]Specify Double Line Piping|$Window_DoubleLine", Parent = typeof(MainWin), GUIType = GuiType.UIA)]
    public partial class SpecifyDoubleLinePipingDLG : Autodesk.GUIHarness.AutoCAD.AcDialogBox
    {
        public  PushButton PushButton1PB;
        public  PushButton PushButton2PB;
        public  PushButton CancelPB;
        public  PushButton OKPB;

        partial void OnInitialize();

        public SpecifyDoubleLinePipingDLG()
        {
            InitializeComponent();
            OnInitialize();
        }

        private void InitializeComponent()
        {

            PushButton1PB = new PushButton()
            {
                Tag = "[PushButton]$Button_SelectAllNone|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(PushButton1PB);

            PushButton2PB = new PushButton()
            {
                Tag = "[PushButton]$Button_ManualSelect|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(PushButton2PB);

            CancelPB = new PushButton()
            {
                Tag = "[PushButton]Cancel|$CancelButton|#4",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(CancelPB);

            OKPB = new PushButton()
            {
                Tag = "[PushButton]OK|$OKButton|#3",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(OKPB);
        }
    }
}
