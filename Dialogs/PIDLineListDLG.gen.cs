// This file is auto-generated - do not hand edit this file.

using Autodesk.GUIHarness;
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{

    [UIElement(Tag = "[CustomWin]#3", Parent = typeof(Plant3D), GUIType = GuiType.WIN32)]
    public partial class PIDLineListDLG : Autodesk.GUIHarness.AutoCAD.AcDialogBox
    {
        public  CustomWin AfxControlBar90u1;
        public  CustomWin AfxWnd90u1;
        public  CustomWin PIDLineList;
        public  CustomWin LineListESW;
        public  CustomWin Panel1;
        public  PushButton Btn_Open;
        public  CustomWin Panel2;
        public  PushButton Btn_Refresh;
        public  CheckBox ZoomToSelectedItem;
        public  PushButton Place;
        public  PopupList M_cmbDwgTitles;
        public  TreeView M_treeLines;

        partial void OnInitialize();

        public PIDLineListDLG()
        {
            InitializeComponent();
            OnInitialize();
        }

        private void InitializeComponent()
        {

            AfxControlBar90u1 = new CustomWin()
            {
                Tag = "[CustomWin][AfxControlBar*u]#1|[AfxControlBar*u]$59423",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(AfxControlBar90u1);

            AfxWnd90u1 = new CustomWin()
            {
                Tag = "[CustomWin][AfxWnd*u]#1|[AfxWnd*u]$16719",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(AfxWnd90u1);

            PIDLineList = new CustomWin()
            {
                Tag = "[CustomWin][AfxWnd*u]PID Line List|[AfxWnd*u]#1|[AfxWnd*u]$8",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(PIDLineList);

            LineListESW = new CustomWin()
            {
                Tag = "[Autodesk.ProcessPower.PnP3dInteropUI.LineListESW]$LineListESW",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(LineListESW);

            Panel1 = new CustomWin()
            {
                Tag = "[System.Windows.Forms.Panel]$panel1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Panel1);

            Btn_Open = new PushButton()
            {
                Tag = "$Btn_Open",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Btn_Open);

            Panel2 = new CustomWin()
            {
                Tag = "[System.Windows.Forms.Panel]$panel2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Panel2);

            Btn_Refresh = new PushButton()
            {
                Tag = "$Btn_Refresh",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Btn_Refresh);

            ZoomToSelectedItem = new CheckBox()
            {
                Tag = "[CheckBox]Zoom to selected item|$m_chkZoom",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ZoomToSelectedItem);

            Place = new PushButton()
            {
                Tag = "[PushButton]Place|$m_btnPlace",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Place);

            M_cmbDwgTitles = new PopupList()
            {
                Tag = "$m_cmbDwgTitles",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_cmbDwgTitles);

            M_treeLines = new TreeView()
            {
                Tag = "[TreeView]#1|$m_treeLines",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_treeLines);
        }
    }
}
