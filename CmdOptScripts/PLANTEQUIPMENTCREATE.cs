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
	public class PLANTEQUIPMENTCREATECLASS
	{
		public string FeatureType = "Command";
		public string releaseVer = "2016";
		public List<Command> lcPLANTEQUIPMENTCREATE = new List<Command>
		{
			new PLANTEQUIPMENTCREATE(),
			new PLANTEQUIPMENTCREATE_PLANE()
		};
	}

	public class PLANTEQUIPMENTCREATE : Command
	{
		public override void Launch()
		{
			//CreateDraw("P3D") CreateDraw("P3D") = Window.Current<CreateDraw("P3D")>();
			Plant3DFunctions.CreateDrawing("P3D");
			CmdOpt_Engine.SendCmd("PLANTEQUIPMENTCREATE");
			System.Threading.Thread.Sleep(7000);
			P3DCreateEquipmentDLG P3DCreateEquipmentDLG = new P3DCreateEquipmentDLG();
			if (P3DCreateEquipmentDLG.Exists)
			{
				P3DCreateEquipmentDLG.SetActive();
				P3DCreateEquipmentDLG.M_BtnCreCreate.Click();
			}
		}

		public override void Dismiss()
		{
			System.Threading.Thread.Sleep(2000);
			CmdOpt_Engine.EnterPoint(200,200);
			CmdOpt_Engine.EnterCR();
		}

		public override void Verify()
		{
			CmdOpt_Engine.CheckEntityInfo();
		}
	}

	public class PLANTEQUIPMENTCREATE_PLANE : PLANTEQUIPMENTCREATE
	{
		public override void Launch()
		{
			CmdOpt_Engine.SendCmd("_PLANTEQUIPMENTCREATE");
			System.Threading.Thread.Sleep(7000);
			P3DCreateEquipmentDLG P3DCreateEquipmentDLG = new P3DCreateEquipmentDLG();
			if (P3DCreateEquipmentDLG.Exists)
			{
				P3DCreateEquipmentDLG.SetActive();
				P3DCreateEquipmentDLG.M_BtnCreCreate.Click();
			}
			System.Threading.Thread.Sleep(2000);
			CmdOpt_Engine.EnterPoint(200,200);
			CmdOpt_Engine.SendOption("Plane",1,1);
		}

		public override void Dismiss()
		{
			CmdOpt_Engine.EnterCR();
            Plant3DFunctions.DeleteAllDrawings();
		}

		public override void Verify()
		{
			CmdOpt_Engine.CheckEntityInfo();
		}
	}

    //public class PLANTEQUIPMENTCREATE_COMPASS : PLANTEQUIPMENTCREATE
    //{
    //    public override void Launch()
    //    {
    //        CmdOpt_Engine.SendCmd("_PLANTEQUIPMENTCREATE");
    //        System.Threading.Thread.Sleep(7000);
    //        P3DCreateEquipmentDLG P3DCreateEquipmentDLG = new P3DCreateEquipmentDLG();
    //        if (P3DCreateEquipmentDLG.Exists)
    //        {
    //            P3DCreateEquipmentDLG.SetActive();
    //            P3DCreateEquipmentDLG.M_BtnCreCreate.Click();
    //        }
    //        System.Threading.Thread.Sleep(2000);
    //        CmdOpt_Engine.EnterPoint(200,200);
    //        CmdOpt_Engine.SendOption("Compass",2,2);
    //    }

    //    public override void Dismiss()
    //    {
    //        CmdOpt_Engine.EnterCR();
    //        //DeleteDrawing("P3D") DeleteDrawing("P3D") = Window.Current<DeleteDrawing("P3D")>();
    //        Plant3DFunctions.DeleteAllDrawings();
    //    }

    //    public override void Verify()
    //    {
    //        CmdOpt_Engine.CheckEntityInfo();
        
	
}
