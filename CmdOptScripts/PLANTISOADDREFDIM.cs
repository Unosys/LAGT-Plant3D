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
    public class PLANTISOADDREFDIMCLASS
    {
        public string FeatureType = "Command";
        public string releaseVer = "2016";
        public List<Command> lcPLANTISOADDREFDIM = new List<Command>
		{
			new PLANTISOADDREFDIM(),
            new PLANTISOADDREFDIM_Building(),
            new PLANTISOADDREFDIM_Equipment(),
            new PLANTISOADDREFDIM_Floor(),
            new PLANTISOADDREFDIM_Gridline(),
            new PLANTISOADDREFDIM_Misc(),
            new PLANTISOADDREFDIM_beAm(),
            new PLANTISOADDREFDIM_Column(),
            new PLANTISOADDREFDIM_Pipe(),
            new PLANTISOADDREFDIM_Wall()
        };
    }

    public class PLANTISOADDREFDIM : Command
    {
        public override void Launch()
        {
            Plant3DFunctions.CreateDrawing("P3D");
            CmdOpt_Engine.SendCmd("_-OSNAP");
            CmdOpt_Engine.SendOpt("_MID");
            CmdOpt_Engine.SendCmd("_PLANTPIPEADD");
            CmdOpt_Engine.EnterPoint(10, 10);
            CmdOpt_Engine.EnterPoint(20, 20);
            CmdOpt_Engine.EnterCR();
            CmdOpt_Engine.SendCmd("PLANTISOADDREFDIM");
            CmdOpt_Engine.EnterPoint(100, 400);
            CmdOpt_Engine.EnterCR();//To invoke error message
            Desktop.Current.MoveMouse(243, 293);
            Desktop.Current.Click(MouseButton.Left, 243, 293);
            System.Threading.Thread.Sleep(1000);
            Desktop.Current.Click(MouseButton.Left, 443, 393);
            Drawing.Current.TypeKeys("<ESC>");
        }
        public override void Dismiss()
        {
            Drawing.Current.TypeKeys("<Delete>");
            System.Threading.Thread.Sleep(500);
            CmdOpt_Engine.SendCmd("_propertiesclose");
        }
        public override void Verify()
        {
            CmdOpt_Engine.CheckEntityInfo();
        }
    }

    public class PLANTISOADDREFDIM_Building : PLANTISOADDREFDIM
    {
        public override void Launch()
        {
            CmdOpt_Engine.SendCmd("_PLANTISOADDREFDIM");
            Desktop.Current.MoveMouse(243, 293);
            Desktop.Current.Click(MouseButton.Left, 243, 293);
            System.Threading.Thread.Sleep(1000);
            Desktop.Current.Click(MouseButton.Left, 443, 393);
            CmdOpt_Engine.SendOption("Building", 1, 9);
            System.Threading.Thread.Sleep(2000);
        }
        public override void Dismiss()
        {
            Drawing.Current.TypeKeys("<Delete>");
            System.Threading.Thread.Sleep(500);
            CmdOpt_Engine.SendCmd("_propertiesclose");
        }
        public override void Verify()
        {
            CmdOpt_Engine.CheckEntityInfo();
        }
    }

    public class PLANTISOADDREFDIM_Equipment : PLANTISOADDREFDIM
    {
        public override void Launch()
        {
            CmdOpt_Engine.SendCmd("_PLANTISOADDREFDIM");
            Desktop.Current.MoveMouse(243, 293);
            Desktop.Current.Click(MouseButton.Left, 243, 293);
            System.Threading.Thread.Sleep(1000);
            Desktop.Current.Click(MouseButton.Left, 443, 393);
            CmdOpt_Engine.SendOption("Equipment", 2, 9);
            System.Threading.Thread.Sleep(2000);
        }
        public override void Dismiss()
        {
            Drawing.Current.TypeKeys("<Delete>");
            System.Threading.Thread.Sleep(500);
            CmdOpt_Engine.SendCmd("_propertiesclose");
        }
        public override void Verify()
        {
            CmdOpt_Engine.CheckEntityInfo();
        }
    }

    public class PLANTISOADDREFDIM_Floor : PLANTISOADDREFDIM
    {
        public override void Launch()
        {
            CmdOpt_Engine.SendCmd("_PLANTISOADDREFDIM");
            Desktop.Current.MoveMouse(243, 293);
            Desktop.Current.Click(MouseButton.Left, 243, 293);
            System.Threading.Thread.Sleep(1000);
            Desktop.Current.Click(MouseButton.Left, 443, 393);
            CmdOpt_Engine.SendOption("Floor", 3, 9);
            System.Threading.Thread.Sleep(2000);
        }
        public override void Dismiss()
        {
            Drawing.Current.TypeKeys("<Delete>");
            System.Threading.Thread.Sleep(500);
            CmdOpt_Engine.SendCmd("_propertiesclose");
        }
        public override void Verify()
        {
            CmdOpt_Engine.CheckEntityInfo();
        }
    }

    public class PLANTISOADDREFDIM_Gridline : PLANTISOADDREFDIM
    {
        public override void Launch()
        {
            CmdOpt_Engine.SendCmd("_PLANTISOADDREFDIM");
            Desktop.Current.MoveMouse(243, 293);
            Desktop.Current.Click(MouseButton.Left, 243, 293);
            System.Threading.Thread.Sleep(1000);
            Desktop.Current.Click(MouseButton.Left, 443, 393);
            CmdOpt_Engine.SendOption("Gridline", 4, 9);
            System.Threading.Thread.Sleep(2000);
        }
        public override void Dismiss()
        {
            Drawing.Current.TypeKeys("<Delete>");
            System.Threading.Thread.Sleep(500);
            CmdOpt_Engine.SendCmd("_propertiesclose");
        }
        public override void Verify()
        {
            CmdOpt_Engine.CheckEntityInfo();
        }
    }

    public class PLANTISOADDREFDIM_Misc : PLANTISOADDREFDIM
    {
        public override void Launch()
        {
            CmdOpt_Engine.SendCmd("_PLANTISOADDREFDIM");
            Desktop.Current.MoveMouse(243, 293);
            Desktop.Current.Click(MouseButton.Left, 243, 293);
            System.Threading.Thread.Sleep(1000);
            Desktop.Current.Click(MouseButton.Left, 443, 393);
            CmdOpt_Engine.SendOption("Misc", 5, 9);
            System.Threading.Thread.Sleep(2000);
        }
        public override void Dismiss()
        {
            Drawing.Current.TypeKeys("<Delete>");
            System.Threading.Thread.Sleep(500);
            CmdOpt_Engine.SendCmd("_propertiesclose");
        }
        public override void Verify()
        {
            CmdOpt_Engine.CheckEntityInfo();
        }
    }

    public class PLANTISOADDREFDIM_beAm : PLANTISOADDREFDIM
    {
        public override void Launch()
        {
            CmdOpt_Engine.SendCmd("_PLANTISOADDREFDIM");
            Desktop.Current.MoveMouse(243, 293);
            Desktop.Current.Click(MouseButton.Left, 243, 293);
            System.Threading.Thread.Sleep(1000);
            Desktop.Current.Click(MouseButton.Left, 443, 393);
            CmdOpt_Engine.SendOption("steel beAm", 6, 9);
            System.Threading.Thread.Sleep(2000);
        }
        public override void Dismiss()
        {
            Drawing.Current.TypeKeys("<Delete>");
            System.Threading.Thread.Sleep(500);
            CmdOpt_Engine.SendCmd("_propertiesclose");
        }
        public override void Verify()
        {
            CmdOpt_Engine.CheckEntityInfo();
        }
    }

    public class PLANTISOADDREFDIM_Column : PLANTISOADDREFDIM
    {
        public override void Launch()
        {
            CmdOpt_Engine.SendCmd("_PLANTISOADDREFDIM");
            Desktop.Current.MoveMouse(243, 293);
            Desktop.Current.Click(MouseButton.Left, 243, 293);
            System.Threading.Thread.Sleep(1000);
            Desktop.Current.Click(MouseButton.Left, 443, 393);
            CmdOpt_Engine.SendOption("steel Column", 7, 9);
            System.Threading.Thread.Sleep(2000);
        }
        public override void Dismiss()
        {
            Drawing.Current.TypeKeys("<Delete>");
            System.Threading.Thread.Sleep(500);
            CmdOpt_Engine.SendCmd("_propertiesclose");
        }
        public override void Verify()
        {
            CmdOpt_Engine.CheckEntityInfo();
        }
    }

    public class PLANTISOADDREFDIM_Pipe : PLANTISOADDREFDIM
    {
        public override void Launch()
        {
            CmdOpt_Engine.SendCmd("_PLANTISOADDREFDIM");
            Desktop.Current.MoveMouse(243, 293);
            Desktop.Current.Click(MouseButton.Left, 243, 293);
            System.Threading.Thread.Sleep(1000);
            Desktop.Current.Click(MouseButton.Left, 443, 393);
            CmdOpt_Engine.SendOption("Pipe", 8, 9);
            System.Threading.Thread.Sleep(2000);
        }
        public override void Dismiss()
        {
            Drawing.Current.TypeKeys("<Delete>");
            System.Threading.Thread.Sleep(500);
            CmdOpt_Engine.SendCmd("_propertiesclose");
        }
        public override void Verify()
        {
            CmdOpt_Engine.CheckEntityInfo();
        }
    }

    public class PLANTISOADDREFDIM_Wall : PLANTISOADDREFDIM
    {
        public override void Launch()
        {
            CmdOpt_Engine.SendCmd("_PLANTISOADDREFDIM");
            Desktop.Current.MoveMouse(243, 293);
            Desktop.Current.Click(MouseButton.Left, 243, 293);
            System.Threading.Thread.Sleep(1000);
            Desktop.Current.Click(MouseButton.Left, 443, 393);
            CmdOpt_Engine.SendOption("Wall", 9, 9);
            System.Threading.Thread.Sleep(2000);
        }
        public override void Dismiss()
        {
            Drawing.Current.TypeKeys("<Delete>");
            System.Threading.Thread.Sleep(500);
            CmdOpt_Engine.SendCmd("_propertiesclose");
            Plant3DFunctions.DeleteAllDrawings();
        }
        public override void Verify()
        {
            CmdOpt_Engine.CheckEntityInfo();
        }
    }
}
