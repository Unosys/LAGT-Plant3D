// This file is auto-generated - do not hand edit this file.

using Autodesk.GUIHarness;
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{

    [UIElement(Tag = "[Pane]Size Mapping|$SizeMappingDlg|#1", Parent = typeof(Plant3D), GUIType = GuiType.UIA)]
    public partial class SizeMappingDLG : Pane
    {
        public  PushButton Btn_DeleteRow;
        public  PushButton Btn_AddRow;
        public  Table DataGridView_SizeMapping;
        public  PushButton Btn_Help;
        public  PushButton Btn_Cancel;
        public  PushButton Btn_OK;
        public  RadioButton SelectA3DSize1RB;
        public  RadioButton SelectA3DSize2RB;
        public  StaticText ShowST;
        public  StaticText SelectA3DSizeST;
        public  TitleBar SizeMappingCTL;
        public  CustomWin SystemMenuBarWIN;
        public  MenuItem SystemMI;
        public  PushButton ClosePB;

        partial void OnInitialize();

        public SizeMappingDLG()
        {
            InitializeComponent();
            OnInitialize();
        }

        private void InitializeComponent()
        {

            Btn_DeleteRow = new PushButton()
            {
                Tag = "[PushButton]Delete Row|$Btn_DeleteRow|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Btn_DeleteRow);

            Btn_AddRow = new PushButton()
            {
                Tag = "[PushButton]Add Row|$Btn_AddRow|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Btn_AddRow);

            DataGridView_SizeMapping = new Table()
            {
                Tag = "[Table]DataGridView|$DataGridView_SizeMapping|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(DataGridView_SizeMapping);

            Btn_Help = new PushButton()
            {
                Tag = "[PushButton]Help|$Btn_Help|#5",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Btn_Help);

            Btn_Cancel = new PushButton()
            {
                Tag = "[PushButton]Cancel|$Btn_Cancel|#4",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Btn_Cancel);

            Btn_OK = new PushButton()
            {
                Tag = "[PushButton]OK|$Btn_OK|#3",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Btn_OK);

            SelectA3DSize1RB = new RadioButton()
            {
                Tag = "[RadioButton]Select a 3D size for each PID size*[1]|$RadioBtn_Metric|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(SelectA3DSize1RB);

            SelectA3DSize2RB = new RadioButton()
            {
                Tag = "[RadioButton]Select a 3D size for each PID size*[2]|$RadioBtn_Imperial|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(SelectA3DSize2RB);

            ShowST = new StaticText()
            {
                Tag = "[StaticText]Show:|$label2|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ShowST);

            SelectA3DSizeST = new StaticText()
            {
                Tag = "[StaticText]Select a 3D size for each P*|$label1|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(SelectA3DSizeST);

            SizeMappingCTL = new TitleBar()
            {
                Tag = "[TitleBar]Size Mapping|$TitleBar|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(SizeMappingCTL);

            SystemMenuBarWIN = new CustomWin()
            {
                Tag = "[TitleBar]Size Mapping|$TitleBar|#1/[CustomWin]System Menu Bar|$SizeMappingDlg|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(SystemMenuBarWIN);

            SystemMI = new MenuItem()
            {
                Tag = "[TitleBar]Size Mapping|$TitleBar|#1/[CustomWin]System Menu Bar|$SizeMappingDlg|#1/[MenuItem]System|$Item 1|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(SystemMI);

            ClosePB = new PushButton()
            {
                Tag = "[TitleBar]Size Mapping|$TitleBar|#1/[PushButton]Close|$Close|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ClosePB);
        }
    }
}
