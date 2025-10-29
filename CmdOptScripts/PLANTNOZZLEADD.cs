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
    public class PLANTNOZZLEADDCLASS
    {
        public string FeatureType = "Command";
        public string releaseVer = "2016";
        public List<Command> lcPLANTNOZZLEADD = new List<Command>
        {
            new PLANTNOZZLEADD(),
            new PLANTNOZZLEADD_LOCATION(),
            new PLANTNOZZLEADD_LOCATION_TOP(),
            new PLANTNOZZLEADD_LOCATION_BOTTOM(),
            new PLANTNOZZLEADD_LOCATION_RADIAL(),
            new PLANTNOZZLEADD_LOCATION_LINE(),
            new PLANTNOZZLEADD_HEIGHT(),
            new PLANTNOZZLEADD_ANGLE(),
            new PLANTNOZZLEADD_LENGTH(),
            new PLANTNOZZLEADD_OFFSET(),
            new PLANTNOZZLEADD_INCLINATION(),
            new PLANTNOZZLEADD_ROTATION(),
            new PLANTNOZZLEADD_TWIST()
        };
    }

    public class PLANTNOZZLEADD : Command
    {
        public override void Launch()
        {
            P3DCreateEquipmentDLG P3DCreateEquipmentDLG = new P3DCreateEquipmentDLG();
            P3DCreateEquipmentDLG.Invoke();
            P3DCreateEquipmentDLG.WaitExists(10 * 1000);
            P3DCreateEquipmentDLG.M_BtnCreCreate.Click();
            System.Threading.Thread.Sleep(2000);
            CmdOpt_Engine.EnterPoint(200, 200);
            CmdOpt_Engine.EnterCR();
            CmdOpt_Engine.SendCmd("PLANTNOZZLEADD");
        }

        public override void Dismiss()
        {
            CmdOpt_Engine.EnterText("_last");
            CmdOpt_Engine.SendOpt("_Angle");
            Drawing.Current.TypeKeys("<ESC 2>");
        }

        public override void Verify()
        {
        }
    }

    public class PLANTNOZZLEADD_LOCATION : PLANTNOZZLEADD
    {
        public override void Launch()
        {
            CmdOpt_Engine.SendCmd("_Erase");
            CmdOpt_Engine.SendOpt("_All");
            CmdOpt_Engine.EnterCR();
            CmdOpt_Engine.SendCmd("_PLANTEQUIPMENTCREATE");
            P3DCreateEquipmentDLG P3DCreateEquipmentDLG = new P3DCreateEquipmentDLG();
            if (P3DCreateEquipmentDLG.WaitExists(10 * 1000))
            {
                P3DCreateEquipmentDLG.M_BtnCreCreate.Click();
            }
            System.Threading.Thread.Sleep(2000);
            CmdOpt_Engine.EnterPoint(200, 200);
            CmdOpt_Engine.EnterCR();
            CmdOpt_Engine.SendCmd("_PLANTNOZZLEADD");
            CmdOpt_Engine.EnterText("_last");
            System.Threading.Thread.Sleep(2000);
            CmdOpt_Engine.SendOption("Location", 1, 8);
        }

        public override void Dismiss()
        {
            CmdOpt_Engine.SendOpt("_Top");
            Drawing.Current.TypeKeys("<ESC 2>");
        }

        public override void Verify()
        {
        }
    }

    public class PLANTNOZZLEADD_LOCATION_TOP : PLANTNOZZLEADD
    {
        public override void Launch()
        {
            CmdOpt_Engine.SendCmd("_Erase");
            CmdOpt_Engine.SendOpt("_All");
            CmdOpt_Engine.EnterCR();
            CmdOpt_Engine.SendCmd("_PLANTEQUIPMENTCREATE");
            P3DCreateEquipmentDLG P3DCreateEquipmentDLG = new P3DCreateEquipmentDLG();
            if (P3DCreateEquipmentDLG.WaitExists(10 * 1000))
            {
                P3DCreateEquipmentDLG.M_BtnCreCreate.Click();
            }
            System.Threading.Thread.Sleep(5000);
            CmdOpt_Engine.EnterPoint(200, 200);
            CmdOpt_Engine.EnterCR();
            CmdOpt_Engine.SendCmd("_PLANTNOZZLEADD");
            CmdOpt_Engine.EnterText("_last");
            System.Threading.Thread.Sleep(5000);
            CmdOpt_Engine.SendOpt("_Location");
            CmdOpt_Engine.SendOption("Top", 1, 4);
        }

        public override void Dismiss()
        {
            Drawing.Current.TypeKeys("<ESC 2>");
        }

        public override void Verify()
        {
        }
    }

    public class PLANTNOZZLEADD_LOCATION_BOTTOM : PLANTNOZZLEADD
    {
        public override void Launch()
        {
            CmdOpt_Engine.SendCmd("_Erase");
            CmdOpt_Engine.SendOpt("_All");
            CmdOpt_Engine.EnterCR();
            CmdOpt_Engine.SendCmd("_PLANTEQUIPMENTCREATE");
            P3DCreateEquipmentDLG P3DCreateEquipmentDLG = new P3DCreateEquipmentDLG();
            if (P3DCreateEquipmentDLG.WaitExists(10 * 1000))
            {
                P3DCreateEquipmentDLG.M_BtnCreCreate.Click();
            }
            System.Threading.Thread.Sleep(2000);
            CmdOpt_Engine.EnterPoint(200, 200);
            CmdOpt_Engine.EnterCR();
            CmdOpt_Engine.SendCmd("_PLANTNOZZLEADD");
            CmdOpt_Engine.EnterText("_last");
            CmdOpt_Engine.SendOpt("_Location");
            CmdOpt_Engine.SendOption("Bottom", 2, 4);
        }

        public override void Dismiss()
        {
            Drawing.Current.TypeKeys("<ESC 2>");
        }

        public override void Verify()
        {
        }
    }

    public class PLANTNOZZLEADD_LOCATION_RADIAL : PLANTNOZZLEADD
    {
        public override void Launch()
        {
            CmdOpt_Engine.SendCmd("_Erase");
            CmdOpt_Engine.SendOpt("_All");
            CmdOpt_Engine.EnterCR();
            CmdOpt_Engine.SendCmd("_PLANTEQUIPMENTCREATE");
            P3DCreateEquipmentDLG P3DCreateEquipmentDLG = new P3DCreateEquipmentDLG();
            if (P3DCreateEquipmentDLG.WaitExists(10 * 1000))
            {
                P3DCreateEquipmentDLG.M_BtnCreCreate.Click();
            }
            System.Threading.Thread.Sleep(2000);
            CmdOpt_Engine.EnterPoint(200, 200);
            CmdOpt_Engine.EnterCR();
            CmdOpt_Engine.SendCmd("_PLANTNOZZLEADD");
            CmdOpt_Engine.EnterText("_last");
            CmdOpt_Engine.SendOpt("_Location");
            CmdOpt_Engine.SendOption("Radial", 3, 4);
        }

        public override void Dismiss()
        {
            Drawing.Current.TypeKeys("<ESC 2>");
        }

        public override void Verify()
        {
        }
    }

    public class PLANTNOZZLEADD_LOCATION_LINE : PLANTNOZZLEADD
    {
        public override void Launch()
        {
            CmdOpt_Engine.SendCmd("_Erase");
            CmdOpt_Engine.SendOpt("_All");
            CmdOpt_Engine.EnterCR();
            CmdOpt_Engine.SendCmd("_PLANTEQUIPMENTCREATE");
            P3DCreateEquipmentDLG P3DCreateEquipmentDLG = new P3DCreateEquipmentDLG();
            if (P3DCreateEquipmentDLG.WaitExists(10 * 1000))
            {
                P3DCreateEquipmentDLG.M_BtnCreCreate.Click();
            }
            System.Threading.Thread.Sleep(2000);
            CmdOpt_Engine.EnterPoint(200, 200);
            CmdOpt_Engine.EnterCR();
            CmdOpt_Engine.SendCmd("_PLANTNOZZLEADD");
            CmdOpt_Engine.EnterText("_last");
            CmdOpt_Engine.SendOpt("_Location");
            CmdOpt_Engine.SendOption("Line", 4, 4);
        }

        public override void Dismiss()
        {
            Drawing.Current.TypeKeys("<ESC 2>");
        }

        public override void Verify()
        {
        }
    }

    public class PLANTNOZZLEADD_HEIGHT : PLANTNOZZLEADD
    {
        public override void Launch()
        {
            CmdOpt_Engine.SendCmd("_Erase");
            CmdOpt_Engine.SendOpt("_All");
            CmdOpt_Engine.EnterCR();
            CmdOpt_Engine.SendCmd("_PLANTEQUIPMENTCREATE");
            P3DCreateEquipmentDLG P3DCreateEquipmentDLG = new P3DCreateEquipmentDLG();
            if (P3DCreateEquipmentDLG.WaitExists(10 * 1000))
            {
                P3DCreateEquipmentDLG.M_BtnCreCreate.Click();
            }
            System.Threading.Thread.Sleep(2000);
            CmdOpt_Engine.EnterPoint(200, 200);
            CmdOpt_Engine.EnterCR();
            CmdOpt_Engine.SendCmd("_PLANTNOZZLEADD");
            CmdOpt_Engine.EnterText("_last");
            CmdOpt_Engine.SendOption("Height", 2, 8);
        }

        public override void Dismiss()
        {
            CmdOpt_Engine.EnterInt(20);
            Drawing.Current.TypeKeys("<ESC 2>");
        }

        public override void Verify()
        {
        }
    }

    public class PLANTNOZZLEADD_ANGLE : PLANTNOZZLEADD
    {
        public override void Launch()
        {
            Drawing.Current.SetSysVar("DYNMODE", -3);
            CmdOpt_Engine.SendCmd("_Erase");
            CmdOpt_Engine.SendOpt("_All");
            CmdOpt_Engine.EnterCR();
            CmdOpt_Engine.SendCmd("_PLANTEQUIPMENTCREATE");
            P3DCreateEquipmentDLG P3DCreateEquipmentDLG = new P3DCreateEquipmentDLG();
            if (P3DCreateEquipmentDLG.WaitExists(10 * 1000))
            {
                P3DCreateEquipmentDLG.M_BtnCreCreate.Click();
            }
            System.Threading.Thread.Sleep(2000);
            CmdOpt_Engine.EnterPoint(200, 200);
            CmdOpt_Engine.EnterCR();
            CmdOpt_Engine.SendCmd("_PLANTNOZZLEADD");
            CmdOpt_Engine.EnterText("_last");
            CmdOpt_Engine.SendOption("Angle", 4, 8);
        }

        public override void Dismiss()
        {
            CmdOpt_Engine.EnterInt(45);
            Drawing.Current.TypeKeys("<ESC 2>");
            Drawing.Current.SetSysVar("DYNMODE", 0);
        }

        public override void Verify()
        {
        }
    }

    public class PLANTNOZZLEADD_LENGTH : PLANTNOZZLEADD
    {
        public override void Launch()
        {
            CmdOpt_Engine.SendCmd("_Erase");
            CmdOpt_Engine.SendOpt("_All");
            CmdOpt_Engine.EnterCR();
            CmdOpt_Engine.SendCmd("_PLANTEQUIPMENTCREATE");
            P3DCreateEquipmentDLG P3DCreateEquipmentDLG = new P3DCreateEquipmentDLG();
            if (P3DCreateEquipmentDLG.WaitExists(10 * 1000))
            {
                P3DCreateEquipmentDLG.M_BtnCreCreate.Click();
            }
            System.Threading.Thread.Sleep(2000);
            CmdOpt_Engine.EnterPoint(200, 200);
            CmdOpt_Engine.EnterCR();
            CmdOpt_Engine.SendCmd("_PLANTNOZZLEADD");
            CmdOpt_Engine.EnterText("_last");
            CmdOpt_Engine.SendOption("Length", 3, 8);
        }

        public override void Dismiss()
        {
            CmdOpt_Engine.EnterInt(45);
            Drawing.Current.TypeKeys("<ESC 2>");
        }

        public override void Verify()
        {
        }
    }

    public class PLANTNOZZLEADD_OFFSET : PLANTNOZZLEADD
    {
        public override void Launch()
        {
            CmdOpt_Engine.SendCmd("_Erase");
            CmdOpt_Engine.SendOpt("_All");
            CmdOpt_Engine.EnterCR();
            CmdOpt_Engine.SendCmd("_PLANTEQUIPMENTCREATE");
            P3DCreateEquipmentDLG P3DCreateEquipmentDLG = new P3DCreateEquipmentDLG();
            if (P3DCreateEquipmentDLG.WaitExists(10 * 1000))
            {
                P3DCreateEquipmentDLG.M_BtnCreCreate.Click();
            }
            System.Threading.Thread.Sleep(2000);
            CmdOpt_Engine.EnterPoint(200, 200);
            CmdOpt_Engine.EnterCR();
            CmdOpt_Engine.SendCmd("_PLANTNOZZLEADD");
            CmdOpt_Engine.EnterText("_last");
            CmdOpt_Engine.SendOption("Offset", 5, 8);
        }

        public override void Dismiss()
        {
            CmdOpt_Engine.EnterInt(10);
            Drawing.Current.TypeKeys("<ESC 2>");
        }

        public override void Verify()
        {
        }
    }

    public class PLANTNOZZLEADD_INCLINATION : PLANTNOZZLEADD
    {
        public override void Launch()
        {
            CmdOpt_Engine.SendCmd("_Erase");
            CmdOpt_Engine.SendOpt("_All");
            CmdOpt_Engine.EnterCR();
            CmdOpt_Engine.SendCmd("_PLANTEQUIPMENTCREATE");
            P3DCreateEquipmentDLG P3DCreateEquipmentDLG = new P3DCreateEquipmentDLG();
            if (P3DCreateEquipmentDLG.WaitExists(10 * 1000))
            {
                P3DCreateEquipmentDLG.M_BtnCreCreate.Click();
            }
            System.Threading.Thread.Sleep(2000);
            CmdOpt_Engine.EnterPoint(200, 200);
            CmdOpt_Engine.EnterCR();
            CmdOpt_Engine.SendCmd("_PLANTNOZZLEADD");
            CmdOpt_Engine.EnterText("_last");
            CmdOpt_Engine.SendOption("Inclination", 6, 8);
        }

        public override void Dismiss()
        {
            CmdOpt_Engine.EnterInt(10);
            Drawing.Current.TypeKeys("<ESC 2>");
        }

        public override void Verify()
        {
        }
    }

    public class PLANTNOZZLEADD_ROTATION : PLANTNOZZLEADD
    {
        public override void Launch()
        {
            CmdOpt_Engine.SendCmd("_Erase");
            CmdOpt_Engine.SendOpt("_All");
            CmdOpt_Engine.EnterCR();
            CmdOpt_Engine.SendCmd("_PLANTEQUIPMENTCREATE");
            P3DCreateEquipmentDLG P3DCreateEquipmentDLG = new P3DCreateEquipmentDLG();
            if (P3DCreateEquipmentDLG.WaitExists(10 * 1000))
            {
                P3DCreateEquipmentDLG.M_BtnCreCreate.Click();
            }
            System.Threading.Thread.Sleep(2000);
            CmdOpt_Engine.EnterPoint(200, 200);
            CmdOpt_Engine.EnterCR();
            CmdOpt_Engine.SendCmd("_PLANTNOZZLEADD");
            CmdOpt_Engine.EnterText("_last");
            CmdOpt_Engine.SendOption("Rotation", 7, 8);
        }

        public override void Dismiss()
        {
            CmdOpt_Engine.EnterInt(10);
            Drawing.Current.TypeKeys("<ESC 2>");
        }

        public override void Verify()
        {
        }
    }

    public class PLANTNOZZLEADD_TWIST : PLANTNOZZLEADD
    {
        public override void Launch()
        {
            CmdOpt_Engine.SendCmd("_Erase");
            CmdOpt_Engine.SendOpt("_All");
            CmdOpt_Engine.EnterCR();
            CmdOpt_Engine.SendCmd("_PLANTEQUIPMENTCREATE");
            P3DCreateEquipmentDLG P3DCreateEquipmentDLG = new P3DCreateEquipmentDLG();
            if (P3DCreateEquipmentDLG.WaitExists(10 * 1000))
            {
                P3DCreateEquipmentDLG.M_BtnCreCreate.Click();
            }
            System.Threading.Thread.Sleep(2000);
            CmdOpt_Engine.EnterPoint(200, 200);
            CmdOpt_Engine.EnterCR();
            CmdOpt_Engine.SendCmd("_PLANTNOZZLEADD");
            CmdOpt_Engine.EnterText("_last");
            CmdOpt_Engine.SendOption("Twist", 8, 8);
        }

        public override void Dismiss()
        {
            CmdOpt_Engine.EnterInt(10);
            Drawing.Current.TypeKeys("<ESC 2>");
            //DeleteDrawing("P3D") DeleteDrawing("P3D") = Window.Current<DeleteDrawing("P3D")>();
            Plant3DFunctions.DeleteDrawing();
        }

        public override void Verify()
        {
        }
    }

    //public class NozzleAddInfoDLG : PLANTNOZZLEADD
    //{
    //    public override void ()
    //    {
    //    }

    //    public override void ()
    //    {
    //    }
    //}
}
