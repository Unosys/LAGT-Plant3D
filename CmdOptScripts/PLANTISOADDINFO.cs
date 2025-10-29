using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Autodesk.GUIHarness;
using Autodesk.GUIHarness.AutoCAD.Dialogs;
using Autodesk.GUIHarness.AutoCAD.TestSuites.GlobalCmdOpt;
using Autodesk.GUIHarness.Plant3D.TestSuites.GlobalCmdOpt;
using ProductTestSuite.CommonFiles;
using LAGT.CommonFiles.Classes;
using Autodesk.GUIHarness.Plant3D.Dialogs;

namespace Autodesk.GUIHarness.Plant3D.CmdOptScripts
{
    public class PLANTISOADDINFOCLASS
    {
        public string FeatureType = "Command";
        public string releaseVer = "2016";
        public List<Command> lcPLANTISOADDINFO = new List<Command>
        {
            new PLANTISOADDINFO(),
            new PLANTISOADDINFO_Breakpoint(),
            new PLANTISOADDINFO_Floorsymbol(),
            new PLANTISOADDINFO_flowArrow(),
            new PLANTISOADDINFO_flowArrow_Accept(),
            new PLANTISOADDINFO_flowArrow_Reverse(),
            new PLANTISOADDINFO_Insulation(),
            new PLANTISOADDINFO_Locationpoint(),
            new PLANTISOADDINFO_Startpoint()
        };
    }

    public class PLANTISOADDINFO : Command
    {
        public override void Launch()
        {
            Plant3DFunctions.CreateDrawing("P3D");
            CmdOpt_Engine.SendCmd("_PLANTPIPEADD");
            CmdOpt_Engine.EnterPoint(60, 70);
            CmdOpt_Engine.EnterPoint(100, 70);
            CmdOpt_Engine.EnterCR();
            CmdOpt_Engine.SendCmd("_Zoom");
            CmdOpt_Engine.SendOpt("_Extents");
            CmdOpt_Engine.SendCmd("PLANTISOADDINFO");
        }

        public override void Dismiss()
        {
            CmdOpt_Engine.SendOpt("_Break");
            //switch (LAGT.CommonFiles.Product.Variables.Language.ToUpper())
            //{
            //	case "JPN":
            //		Drawing.Current.ClientArea.DoubleClick(MouseButton.Left, 200, 300);
            //		break;
            //             case "CHS":
            //                 Drawing.Current.ClientArea.DoubleClick(MouseButton.Left, 200, 300);
            //                 break;
            //             default:
            //		Drawing.Current.ClientArea.DoubleClick(MouseButton.Left, 81, 217);
            //		break;
            //}
            RECT r = Drawing.Current.ClientArea.GetRect(true);
            Drawing.Current.ClientArea.DoubleClick(MouseButton.Left, 200, r.ySize / 2);
            Drawing.Current.TypeKeys("<ESC 3>");
        }

        public override void Verify()
        {
        }
    }

    public class PLANTISOADDINFO_Breakpoint : PLANTISOADDINFO
    {
        public override void Launch()
        {
            CmdOpt_Engine.SendCmd("_Erase");
            CmdOpt_Engine.SendOpt("_last");
            CmdOpt_Engine.EnterCR();
            CmdOpt_Engine.SendCmd("_PLANTPIPEADD");
            CmdOpt_Engine.EnterPoint(60, 70);
            CmdOpt_Engine.EnterPoint(100, 70);
            CmdOpt_Engine.EnterCR();
            CmdOpt_Engine.SendCmd("_Zoom");
            CmdOpt_Engine.SendOpt("_Extents");
            CmdOpt_Engine.SendCmd("_PLANTISOADDINFO");
            CmdOpt_Engine.SendOption("Break", 1, 6);
        }

        public override void Dismiss()
        {
            //Desktop.Current.Click(MouseButton.Left, 150, 295);
            //switch (LAGT.CommonFiles.Product.Variables.Language.ToUpper())
            //{
            //	case "JPN":
            //		Drawing.Current.ClientArea.DoubleClick(MouseButton.Left, 200, 300);
            //		break;
            //             case "CHS":
            //                 Drawing.Current.ClientArea.DoubleClick(MouseButton.Left, 200, 300);
            //                 break;
            //             default:
            //		Drawing.Current.ClientArea.DoubleClick(MouseButton.Left, 81, 217);
            //		break;
            //}
            RECT r = Drawing.Current.ClientArea.GetRect(true);
            Drawing.Current.ClientArea.DoubleClick(MouseButton.Left, 200, r.ySize / 2);
            Drawing.Current.TypeKeys("<ESC 3>");
        }

        public override void Verify()
        {
        }
    }

    public class PLANTISOADDINFO_Floorsymbol : PLANTISOADDINFO
    {
        public override void Launch()
        {
            CmdOpt_Engine.SendCmd("_Erase");
            CmdOpt_Engine.SendOpt("_last");
            CmdOpt_Engine.EnterCR();
            CmdOpt_Engine.SendCmd("_PLANTPIPEADD");
            CmdOpt_Engine.EnterPoint(60, 70);
            CmdOpt_Engine.EnterPoint(100, 70);
            CmdOpt_Engine.EnterCR();
            CmdOpt_Engine.SendCmd("_Zoom");
            CmdOpt_Engine.SendOpt("_Extents");
            CmdOpt_Engine.SendCmd("_PLANTISOADDINFO");
            CmdOpt_Engine.SendOption("Floor", 2, 6);
        }

        public override void Dismiss()
        {
            //switch (LAGT.CommonFiles.Product.Variables.Language.ToUpper())
            //{
            //	case "JPN":
            //		Drawing.Current.ClientArea.DoubleClick(MouseButton.Left, 200, 300);
            //		break;
            //             case "CHS":
            //                 Drawing.Current.ClientArea.DoubleClick(MouseButton.Left, 200, 300);
            //                 break;
            //             default:
            //		Drawing.Current.ClientArea.DoubleClick(MouseButton.Left, 81, 217);
            //		break;
            //}

            RECT r = Drawing.Current.ClientArea.GetRect(true);
            Drawing.Current.ClientArea.DoubleClick(MouseButton.Left, 200, r.ySize / 2);
            Drawing.Current.TypeKeys("<ESC 3>");
        }

        public override void Verify()
        {
        }
    }

    public class PLANTISOADDINFO_flowArrow : PLANTISOADDINFO
    {
        public override void Launch()
        {
            CmdOpt_Engine.SendCmd("_Erase");
            CmdOpt_Engine.SendOpt("_last");
            CmdOpt_Engine.EnterCR();
            CmdOpt_Engine.SendCmd("_PLANTPIPEADD");
            CmdOpt_Engine.EnterPoint(60, 70);
            CmdOpt_Engine.EnterPoint(100, 70);
            CmdOpt_Engine.EnterCR();
            CmdOpt_Engine.SendCmd("_Zoom");
            CmdOpt_Engine.SendOpt("_Extents");
            CmdOpt_Engine.SendCmd("_PLANTISOADDINFO");
            CmdOpt_Engine.SendOption("Arrow", 3, 6);
        }

        public override void Dismiss()
        {
            RECT r = Drawing.Current.ClientArea.GetRect(true);
            Drawing.Current.ClientArea.DoubleClick(MouseButton.Left, 200, r.ySize / 2);
            //         switch (LAGT.CommonFiles.Product.Variables.Language.ToUpper())
            //{
            //	case "JPN":
            //		Drawing.Current.ClientArea.DoubleClick(MouseButton.Left, 200, 300);
            //		break;
            //             case "CHS":
            //                 Drawing.Current.ClientArea.DoubleClick(MouseButton.Left, 200, r.ySize/2);
            //                 break;
            //             default:
            //		Drawing.Current.ClientArea.DoubleClick(MouseButton.Left, 81, 217);
            //		break;
            //}
            CmdOpt_Engine.SendOpt("_Accept");
            Drawing.Current.TypeKeys("<ESC 3>");

        }

        public override void Verify()
        {
        }
    }

    public class PLANTISOADDINFO_flowArrow_Accept : PLANTISOADDINFO
    {
        public override void Launch()
        {
            CmdOpt_Engine.SendCmd("_Erase");
            CmdOpt_Engine.SendOpt("_last");
            CmdOpt_Engine.EnterCR();
            CmdOpt_Engine.SendCmd("_PLANTPIPEADD");
            CmdOpt_Engine.EnterPoint(60, 70);
            CmdOpt_Engine.EnterPoint(100, 70);
            CmdOpt_Engine.EnterCR();
            CmdOpt_Engine.SendCmd("_Zoom");
            CmdOpt_Engine.SendOpt("_Extents");
            CmdOpt_Engine.SendCmd("_PLANTISOADDINFO");
            CmdOpt_Engine.SendOpt("_Arrow");
            //switch (LAGT.CommonFiles.Product.Variables.Language.ToUpper())
            //{
            //	case "JPN":
            //		Drawing.Current.ClientArea.DoubleClick(MouseButton.Left, 200, 300);
            //		break;
            //             case "CHS":
            //                 Drawing.Current.ClientArea.DoubleClick(MouseButton.Left, 200, 300);
            //                 break;
            //             default:
            //		Drawing.Current.ClientArea.DoubleClick(MouseButton.Left, 81, 217);
            //		break;
            //}
            RECT r = Drawing.Current.ClientArea.GetRect(true);
            Drawing.Current.ClientArea.DoubleClick(MouseButton.Left, 200, r.ySize / 2);
            CmdOpt_Engine.SendOption("Accept", 1, 2);
        }

        public override void Dismiss()
        {
            Drawing.Current.TypeKeys("<ESC 3>");
        }

        public override void Verify()
        {
        }
    }

    public class PLANTISOADDINFO_flowArrow_Reverse : PLANTISOADDINFO
    {
        public override void Launch()
        {
            CmdOpt_Engine.SendCmd("_Erase");
            CmdOpt_Engine.SendOpt("_last");
            CmdOpt_Engine.EnterCR();
            CmdOpt_Engine.SendCmd("_PLANTPIPEADD");
            CmdOpt_Engine.EnterPoint(60, 70);
            CmdOpt_Engine.EnterPoint(100, 70);
            CmdOpt_Engine.EnterCR();
            CmdOpt_Engine.SendCmd("_Zoom");
            CmdOpt_Engine.SendOpt("_Extents");
            CmdOpt_Engine.SendCmd("_PLANTISOADDINFO");
            CmdOpt_Engine.SendOpt("_Arrow");
            //switch (LAGT.CommonFiles.Product.Variables.Language.ToUpper())
            //{
            //	case "JPN":
            //		Drawing.Current.ClientArea.DoubleClick(MouseButton.Left, 200, 300);
            //		break;
            //             case "CHS":
            //                 Drawing.Current.ClientArea.DoubleClick(MouseButton.Left, 200, 300);
            //                 break;
            //             default:
            //		Drawing.Current.ClientArea.DoubleClick(MouseButton.Left, 81, 217);
            //		break;
            //}
            RECT r = Drawing.Current.ClientArea.GetRect(true);
            Drawing.Current.ClientArea.DoubleClick(MouseButton.Left, 200, r.ySize / 2);
            CmdOpt_Engine.SendOption("Reverse", 2, 2);
        }

        public override void Dismiss()
        {
            Drawing.Current.TypeKeys("<ESC 3>");
        }

        public override void Verify()
        {
        }
    }

    public class PLANTISOADDINFO_Insulation : PLANTISOADDINFO
    {
        public override void Launch()
        {
            CmdOpt_Engine.SendCmd("_Erase");
            CmdOpt_Engine.SendOpt("_last");
            CmdOpt_Engine.EnterCR();
            CmdOpt_Engine.SendCmd("_PLANTPIPEADD");
            CmdOpt_Engine.EnterPoint(60, 70);
            CmdOpt_Engine.EnterPoint(100, 70);
            CmdOpt_Engine.EnterCR();
            CmdOpt_Engine.SendCmd("_Zoom");
            CmdOpt_Engine.SendOpt("_Extents");
            CmdOpt_Engine.SendCmd("_PLANTISOADDINFO");
            CmdOpt_Engine.SendOption("Insulation", 4, 6);
        }

        public override void Dismiss()
        {
            //switch (LAGT.CommonFiles.Product.Variables.Language.ToUpper())
            //{
            //	case "JPN":
            //		Drawing.Current.ClientArea.DoubleClick(MouseButton.Left, 200, 300);
            //		break;
            //             case "CHS":
            //                 Drawing.Current.ClientArea.DoubleClick(MouseButton.Left, 200, 300);
            //                 break;
            //             default:
            //		Drawing.Current.ClientArea.DoubleClick(MouseButton.Left, 81, 217);
            //		break;
            //}
            RECT r = Drawing.Current.ClientArea.GetRect(true);
            Drawing.Current.ClientArea.DoubleClick(MouseButton.Left, 200, r.ySize / 2);
            Drawing.Current.TypeKeys("<ESC 3>");
        }

        public override void Verify()
        {
        }
    }

    public class PLANTISOADDINFO_Locationpoint : PLANTISOADDINFO
    {
        public override void Launch()
        {
            CmdOpt_Engine.SendCmd("_Erase");
            CmdOpt_Engine.SendOpt("_last");
            CmdOpt_Engine.EnterCR();
            CmdOpt_Engine.SendCmd("_PLANTPIPEADD");
            CmdOpt_Engine.EnterPoint(60, 70);
            CmdOpt_Engine.EnterPoint(100, 70);
            CmdOpt_Engine.EnterCR();
            CmdOpt_Engine.SendCmd("_Zoom");
            CmdOpt_Engine.SendOpt("_Extents");
            CmdOpt_Engine.SendCmd("_PLANTISOADDINFO");
            CmdOpt_Engine.SendOption("Location", 5, 6);
        }

        public override void Dismiss()
        {
            //switch (LAGT.CommonFiles.Product.Variables.Language.ToUpper())
            //{
            //	case "JPN":
            //		Drawing.Current.ClientArea.DoubleClick(MouseButton.Left, 200, 300);
            //		break;
            //             case "CHS":
            //                 Drawing.Current.ClientArea.DoubleClick(MouseButton.Left, 200, 300);
            //                 break;
            //             default:
            //		Drawing.Current.ClientArea.DoubleClick(MouseButton.Left, 81, 217);
            //		break;
            //}
            RECT r = Drawing.Current.ClientArea.GetRect(true);
            Drawing.Current.ClientArea.DoubleClick(MouseButton.Left, 200, r.ySize / 2);
            Drawing.Current.TypeKeys("<ESC 3>");
        }

        public override void Verify()
        {
        }
    }
    public class PLANTISOADDINFO_Startpoint : PLANTISOADDINFO
    {
        public override void Launch()
        {
            CmdOpt_Engine.SendCmd("_Erase");
            CmdOpt_Engine.SendOpt("_last");
            CmdOpt_Engine.EnterCR();
            CmdOpt_Engine.SendCmd("_PLANTPIPEADD");
            CmdOpt_Engine.EnterPoint(60, 70);
            CmdOpt_Engine.EnterPoint(100, 70);
            CmdOpt_Engine.EnterCR();
            CmdOpt_Engine.SendCmd("_Zoom");
            CmdOpt_Engine.SendOpt("_Extents");
            CmdOpt_Engine.SendCmd("_PLANTISOADDINFO");
            System.Threading.Thread.Sleep(2000);
            CmdOpt_Engine.SendOption("Start", 6, 6);
        }

        public override void Dismiss()
        {
            //switch (LAGT.CommonFiles.Product.Variables.Language.ToUpper())
            //{
            //	case "JPN":
            //		Drawing.Current.ClientArea.DoubleClick(MouseButton.Left, 200, 300);
            //		break;
            //             case "CHS":
            //                 Drawing.Current.ClientArea.DoubleClick(MouseButton.Left, 200, 300);
            //                 break;
            //             default:
            //		Drawing.Current.ClientArea.DoubleClick(MouseButton.Left, 81, 217);
            //		break;
            //}
            RECT r = Drawing.Current.ClientArea.GetRect(true);
            Drawing.Current.ClientArea.DoubleClick(MouseButton.Left, 200, r.ySize / 2);
            Drawing.Current.TypeKeys("<ESC 3>");

            Plant3DFunctions.DeleteAllDrawings();
        }

        public override void Verify()
        {
        }
    }
}
