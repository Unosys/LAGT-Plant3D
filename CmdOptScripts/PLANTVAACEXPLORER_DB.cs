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
	public class PLANTVAACEXPLORER_DBCLASS
	{
		public string FeatureType = "Command";
		public string releaseVer = "2016";
		public List<Command> lcPLANTVAACEXPLORER_DB = new List<Command>
		{
			new PLANTVAACEXPLORER_DB()
		};
	}

	public class PLANTVAACEXPLORER_DB : Command
	{
		public override void Launch()
		{
			CmdOpt_Engine.SendCmd("PLANTVAACEXPLORER");
			LaunchingAutodeskVaultProfessionalWarningDLG LaunchingAutodeskVaultProfessionalWarningDLG = Window.Current<LaunchingAutodeskVaultProfessionalWarningDLG>();
			LaunchingAutodeskVaultProfessionalWarningDLG.SetActive();
			if (!LaunchingAutodeskVaultProfessionalWarningDLG.Exists)
			{
				CmdOpt_ErrorReport.tError sError = new CmdOpt_ErrorReport.tError("CMD_NOT_WORKING", "Dialog was not called or its tag is incorrect.", "", "", "");
				CmdOpt_ErrorReport.ReportError(sError);
			}
            //else //define dialogs manually!
            //{
            //    LaunchingAutodeskVaultProfessionalWarningDLG.OK.Click();
            //    System.Threading.Thread.Sleep(2000);
            //    AutodeskVaultProfessionaLogIn AutodeskVaultProfessionaLogIn = new AutodeskVaultProfessionaLogIn();
            //    if (AutodeskVaultProfessionaLogIn.Exists)
            //    {
            //        AutodeskVaultProfessionaLogIn.SetActive();
            //        AutodeskVaultProfessionaLogIn.Close();
            //        System.Threading.Thread.Sleep(2000);
            //    }
            //    System.Threading.Thread.Sleep(3000);
            //    AutodeskVaultProfessional20DLG AutodeskVaultProfessional20DLG = Window.Current<AutodeskVaultProfessional20DLG>();
            //    AutodeskVaultProfessional20DLG.SetActive();
            //    AutodeskVaultProfessional20DLG.Close();
            //}
		}

		public override void Dismiss()
		{
		}

		public override void Verify()
		{
		}
	}

    //public class AutodeskVaultProfessional20DLG : PLANTVAACEXPLORER_DB
    //{
    //    public override void ()
    //    {
    //    }

    //    public override void ()
    //    {
    //        tag "[WindowsForms10 tag "[WindowsForms10 = Window.Current<tag "[WindowsForms10>();
    //        tag "[WindowsForms10.Window.8.app.0.3ce0bb8_r14_ad1]$6488930";
    //        CustomWin WindowsForms10Window8App01 CustomWin WindowsForms10Window8App01 = Window.Current<CustomWin WindowsForms10Window8App01>();
    //        CustomWin WindowsForms10Window8App01;
    //        tag "[WindowsForms10.Window.8.app.0.3ce0bb8_r14_ad1]$7275674";
    //        CustomWin WindowsForms10Window8App0 CustomWin WindowsForms10Window8App0 = Window.Current<CustomWin WindowsForms10Window8App0>();
    //        CustomWin WindowsForms10Window8App0;
    //        tag "[WindowsForms10.Window.8.app.0.3ce0bb8_r14_ad1]$3080572";
    //        CustomWin WindowsForms10Window8App0;
    //        tag "[WindowsForms10.Window.8.app.0.3ce0bb8_r14_ad1]$526350";
    //        CustomWin ShellEmbedding1 CustomWin ShellEmbedding1 = Window.Current<CustomWin ShellEmbedding1>();
    //        CustomWin ShellEmbedding1;
    //        tag "[Shell Embedding]$0" tag "[Shell Embedding]$0" = Window.Current<tag "[Shell Embedding]$0">();
    //        tag "[Shell Embedding]$0";
    //        CustomWin ShellDocObjectView1 CustomWin ShellDocObjectView1 = Window.Current<CustomWin ShellDocObjectView1>();
    //        CustomWin ShellDocObjectView1;
    //        tag "[Shell DocObject View]$0" tag "[Shell DocObject View]$0" = Window.Current<tag "[Shell DocObject View]$0">();
    //        tag "[Shell DocObject View]$0";
    //        CustomWin InternetExplorer_Server1 CustomWin InternetExplorer_Server1 = Window.Current<CustomWin InternetExplorer_Server1>();
    //        CustomWin InternetExplorer_Server1;
    //        tag "[Internet Explorer_Server]$0" tag "[Internet Explorer_Server]$0" = Window.Current<tag "[Internet Explorer_Server]$0">();
    //        tag "[Internet Explorer_Server]$0";
    //        CustomWin WindowsForms10Window8App02 CustomWin WindowsForms10Window8App02 = Window.Current<CustomWin WindowsForms10Window8App02>();
    //        CustomWin WindowsForms10Window8App02;
    //        tag "[WindowsForms10.Window.8.app.0.3ce0bb8_r14_ad1]$5179078";
    //        CustomWin WindowsForms10Window8App03 CustomWin WindowsForms10Window8App03 = Window.Current<CustomWin WindowsForms10Window8App03>();
    //        CustomWin WindowsForms10Window8App03;
    //        tag "[WindowsForms10.Window.8.app.0.3ce0bb8_r14_ad1]$7407172";
    //        CustomWin WindowsForms10Window8App0;
    //        tag "[WindowsForms10.Window.8.app.0.3ce0bb8_r14_ad1]$5506928";
    //        CustomWin NavBarControl1 CustomWin NavBarControl1 = Window.Current<CustomWin NavBarControl1>();
    //        CustomWin NavBarControl1;
    //        tag "[WindowsForms10.Window.8.app.0.3ce0bb8_r14_ad1]$657450";
    //        CustomWin WindowsForms10Window8App0;
    //        tag "[WindowsForms10.Window.8.app.0.3ce0bb8_r14_ad1]$395268";
    //        CustomWin WindowsForms10Window8App0;
    //        tag "[WindowsForms10.Window.8.app.0.3ce0bb8_r14_ad1]$3278802";
    //        CustomWin WindowsForms10Window8App0;
    //        tag "[WindowsForms10.Window.8.app.0.3ce0bb8_r14_ad1]$4588364";
    //        CustomWin WindowsForms10Window8App0;
    //        tag "[WindowsForms10.Window.8.app.0.3ce0bb8_r14_ad1]$3868586";
    //        CustomWin WindowsForms10Window8App01;
    //        tag "[WindowsForms10.Window.8.app.0.3ce0bb8_r14_ad1]$4785926";
    //        CustomWin WindowsForms10SysTreeView32A CustomWin WindowsForms10SysTreeView32A = Window.Current<CustomWin WindowsForms10SysTreeView32A>();
    //        CustomWin WindowsForms10SysTreeView32A;
    //        tag "[WindowsForms10.SysTreeView32.app.0.3ce0bb8_r14_ad1]$2819106";
    //        CustomWin WindowsForms10Window8App02;
    //        tag "[WindowsForms10.Window.8.app.0.3ce0bb8_r14_ad1]$4195872";
    //        CustomWin WindowsForms10Window8App01;
    //        tag "[WindowsForms10.Window.8.app.0.3ce0bb8_r14_ad1]$6096244";
    //        CustomWin WindowsForms10SysTreeView32A;
    //        tag "[WindowsForms10.SysTreeView32.app.0.3ce0bb8_r14_ad1]$985122";
    //        CustomWin WindowsForms10Window8App02;
    //        tag "[WindowsForms10.Window.8.app.0.3ce0bb8_r14_ad1]$395320";
    //        CustomWin MyWorklist CustomWin MyWorklist = Window.Current<CustomWin MyWorklist>();
    //        CustomWin MyWorklist;
    //        tag "[WindowsForms10.STATIC.app.0.3ce0bb8_r14_ad1]$2360938";
    //        CustomWin WindowsForms10Window8App0;
    //        tag "[WindowsForms10.Window.8.app.0.3ce0bb8_r14_ad1]$395316";
    //        CustomWin WindowsForms10Window8App03;
    //        tag "[WindowsForms10.Window.8.app.0.3ce0bb8_r14_ad1]$395318";
    //        CustomWin WindowsForms10Window8App01;
    //        tag "[WindowsForms10.Window.8.app.0.3ce0bb8_r14_ad1]$395304";
    //        CustomWin WindowsForms10SysTreeView32A;
    //        tag "[WindowsForms10.SysTreeView32.app.0.3ce0bb8_r14_ad1]$1836860";
    //        CustomWin WindowsForms10Window8App0;
    //        tag "[WindowsForms10.Window.8.app.0.3ce0bb8_r14_ad1]$7668202";
    //        CustomWin WindowsForms10Window8App0;
    //        tag "[WindowsForms10.Window.8.app.0.3ce0bb8_r14_ad1]$4588920";
    //        CustomWin AddNewGroup CustomWin AddNewGroup = Window.Current<CustomWin AddNewGroup>();
    //        CustomWin AddNewGroup;
    //        tag "[WindowsForms10.STATIC.app.0.3ce0bb8_r14_ad1]$3081698";
    //        CustomWin WindowsForms10Window8App02;
    //        tag "[WindowsForms10.Window.8.app.0.3ce0bb8_r14_ad1]$4654932";
    //        CustomWin MyShortcuts CustomWin MyShortcuts = Window.Current<CustomWin MyShortcuts>();
    //        CustomWin MyShortcuts;
    //        tag "[WindowsForms10.STATIC.app.0.3ce0bb8_r14_ad1]$6620490";
    //        CustomWin WindowsForms10Window8App0;
    //        tag "[WindowsForms10.Window.8.app.0.3ce0bb8_r14_ad1]$4654818";
    //    }

    //    public override void ()
    //    {
    //        tag "[WindowsForms10.Window.8.app.0.3ce0bb8_r14_ad1]$6555364";
    //        CustomWin WindowsForms10Window8App0;
    //        tag "[WindowsForms10.Window.8.app.0.3ce0bb8_r14_ad1]$5309694";
    //        CustomWin WindowsForms10Window8App0;
    //        tag "[WindowsForms10.Window.8.app.0.3ce0bb8_r14_ad1]$2164816";
    //        CustomWin WindowsForms10Window8App01;
    //        tag "[WindowsForms10.Window.8.app.0.3ce0bb8_r14_ad1]$4720368";
    //        CustomWin Panel1 CustomWin Panel1 = Window.Current<CustomWin Panel1>();
    //        CustomWin Panel1;
    //        tag "[WindowsForms10.Window.8.app.0.3ce0bb8_r14_ad1]$788566";
    //        CustomWin WindowsForms10Window8App0;
    //        tag "[WindowsForms10.Window.8.app.0.3ce0bb8_r14_ad1]$591918";
    //        CustomWin WindowsForms10Window8App0;
    //        tag "[WindowsForms10.Window.8.app.0.3ce0bb8_r14_ad1]$6226996";
    //        CustomWin Panel2 CustomWin Panel2 = Window.Current<CustomWin Panel2>();
    //        CustomWin Panel2;
    //        tag "[WindowsForms10.Window.8.app.0.3ce0bb8_r14_ad1]$723036";
    //        CustomWin WindowsForms10WindowBApp0 CustomWin WindowsForms10WindowBApp0 = Window.Current<CustomWin WindowsForms10WindowBApp0>();
    //        CustomWin WindowsForms10WindowBApp0;
    //        tag "[WindowsForms10.Window.b.app.0.3ce0bb8_r14_ad1]$788564";
    //        CustomWin WindowsForms10Window8App02;
    //        tag "[WindowsForms10.Window.8.app.0.3ce0bb8_r14_ad1]$723040";
    //        CustomWin WindowsForms10Window8App03;
    //        tag "[WindowsForms10.Window.8.app.0.3ce0bb8_r14_ad1]$460810";
    //        CustomWin WindowsForms10Window8App04 CustomWin WindowsForms10Window8App04 = Window.Current<CustomWin WindowsForms10Window8App04>();
    //        CustomWin WindowsForms10Window8App04;
    //        tag "[WindowsForms10.Window.8.app.0.3ce0bb8_r14_ad1]$4982174";
    //        CustomWin WindowsForms10Window8App05 CustomWin WindowsForms10Window8App05 = Window.Current<CustomWin WindowsForms10Window8App05>();
    //        CustomWin WindowsForms10Window8App05;
    //        tag "[WindowsForms10.Window.8.app.0.3ce0bb8_r14_ad1]$723038";
    //        CustomWin WindowsForms10Window8App0;
    //        tag "[WindowsForms10.Window.8.app.0.3ce0bb8_r14_ad1]$4654204";
    //    }

    //    public override void ()
    //    {
    //        tag "[WindowsForms10.Window.8.app.0.3ce0bb8_r14_ad1]$3539372";
    //    }

    //    public override void ()
    //    {
    //        tag "[WindowsForms10.Window.8.app.0.3ce0bb8_r14_ad1]$6555530";
    //    }

    //    public override void ()
    //    {
    //        tag "[WindowsForms10.Window.8.app.0.3ce0bb8_r14_ad1]$5112862";
    //        CustomWin WindowsForms10Window8App0;
    //        tag "[WindowsForms10.Window.8.app.0.3ce0bb8_r14_ad1]$4850614";
    //    }

    //    public override void ()
    //    {
    //        tag "[WindowsForms10.Window.8.app.0.3ce0bb8_r14_ad1]$5375388";
    //        CustomWin WindowsForms10Window8App01;
    //        tag "[WindowsForms10.Window.8.app.0.3ce0bb8_r14_ad1]$3933760";
    //        CustomWin WindowsForms10Window8App02;
    //        tag "[WindowsForms10.Window.8.app.0.3ce0bb8_r14_ad1]$6227326";
    //        CustomWin WindowsForms10Window8App03;
    //        tag "[WindowsForms10.Window.8.app.0.3ce0bb8_r14_ad1]$3934032";
    //        CustomWin WindowsForms10Window8App04;
    //        tag "[WindowsForms10.Window.8.app.0.3ce0bb8_r14_ad1]$1574728";
    //        CustomWin WindowsForms10Window8App05;
    //        tag "[WindowsForms10.Window.8.app.0.3ce0bb8_r14_ad1]$3147436";
    //    }

    //    public override void ()
    //    {
    //        tag "[WindowsForms10.Window.8.app.0.3ce0bb8_r14_ad1]$5505914";
    //    }

    //    public override void ()
    //    {
    //        tag "[WindowsForms10.Window.8.app.0.3ce0bb8_r14_ad1]$4196244";
    //    }

    //    public override void ()
    //    {
    //        tag "[WindowsForms10.Window.8.app.0.3ce0bb8_r14_ad1]$4719660";
    //    }

    //    public override void ()
    //    {
    //        tag "[WindowsForms10.Window.8.app.0.3ce0bb8_r14_ad1]$7144902";
    //    }

    //    public override void ()
    //    {
    //        tag "[WindowsForms10.Window.8.app.0.3ce0bb8_r14_ad1]$6751590";
    //    }

    //    public override void ()
    //    {
    //        tag "[WindowsForms10.Window.8.app.0.3ce0bb8_r14_ad1]$3344282";
    //    }

    //    public override void ()
    //    {
    //        tag "[WindowsForms10.Window.8.app.0.3ce0bb8_r14_ad1]$3998158";
    //    }

    //    public override void ()
    //    {
    //        tag "[WindowsForms10.Window.8.app.0.3ce0bb8_r14_ad1]$5178856";
    //    }

    //    public override void ()
    //    {
    //        tag "[WindowsForms10.Window.8.app.0.3ce0bb8_r14_ad1]$3016534";
    //    }

    //    public override void ()
    //    {
    //        tag "[WindowsForms10.Window.8.app.0.3ce0bb8_r14_ad1]$4194780";
    //    }

    //    public override void ()
    //    {
    //        tag "[WindowsForms10.Window.8.app.0.3ce0bb8_r14_ad1]$3344246";
    //    }

    //    public override void ()
    //    {
    //        tag "[WindowsForms10.Window.8.app.0.3ce0bb8_r14_ad1]$4589434";
    //    }

    //    public override void ()
    //    {
    //        tag "[WindowsForms10.Window.8.app.0.3ce0bb8_r14_ad1]$3474816";
    //    }

    //    public override void ()
    //    {
    //        tag "[WindowsForms10.Window.8.app.0.3ce0bb8_r14_ad1]$3080736";
    //    }

    //    public override void ()
    //    {
    //        tag "[WindowsForms10.Window.8.app.0.3ce0bb8_r14_ad1]$2819896";
    //    }

    //    public override void ()
    //    {
    //        tag "[WindowsForms10.Window.8.app.0.3ce0bb8_r14_ad1]$4458398";
    //    }

    //    public override void ()
    //    {
    //        tag "[WindowsForms10.Window.8.app.0.3ce0bb8_r14_ad1]$4588070";
    //    }

    //    public override void ()
    //    {
    //        tag "[WindowsForms10.Window.8.app.0.3ce0bb8_r14_ad1]$4392420";
    //    }

    //    public override void ()
    //    {
    //        tag "[WindowsForms10.Window.8.app.0.3ce0bb8_r14_ad1]$4327102";
    //    }

    //    public override void ()
    //    {
    //        tag "[WindowsForms10.Window.8.app.0.3ce0bb8_r14_ad1]$5440592";
    //    }

    //    public override void ()
    //    {
    //        tag "[WindowsForms10.Window.8.app.0.3ce0bb8_r14_ad1]$3015688";
    //    }

    //    public override void ()
    //    {
    //        tag "[WindowsForms10.Window.8.app.0.3ce0bb8_r14_ad1]$5768762";
    //    }

    //    public override void ()
    //    {
    //        tag "[WindowsForms10.Window.8.app.0.3ce0bb8_r14_ad1]$1181556";
    //    }

    //    public override void ()
    //    {
    //        tag "[WindowsForms10.Window.8.app.0.3ce0bb8_r14_ad1]$3999500";
    //    }

    //    public override void ()
    //    {
    //        tag "[WindowsForms10.Window.8.app.0.3ce0bb8_r14_ad1]$3671568";
    //    }

    //    public override void ()
    //    {
    //        tag "[WindowsForms10.Window.8.app.0.3ce0bb8_r14_ad1]$9635106";
    //    }

    //    public override void ()
    //    {
    //        tag "[WindowsForms10.Window.8.app.0.3ce0bb8_r14_ad1]$7996648";
    //    }

    //    public override void ()
    //    {
    //        tag "[WindowsForms10.Window.8.app.0.3ce0bb8_r14_ad1]$3015638";
    //    }

    //    public override void ()
    //    {
    //        tag "[WindowsForms10.Window.8.app.0.3ce0bb8_r14_ad1]$8128070";
    //    }

    //    public override void ()
    //    {
    //        tag "[WindowsForms10.Window.8.app.0.3ce0bb8_r14_ad1]$3408984";
    //    }

    //    public override void ()
    //    {
    //        tag "[WindowsForms10.Window.8.app.0.3ce0bb8_r14_ad1]$3606386";
    //    }

    //    public override void ()
    //    {
    //        tag "[WindowsForms10.Window.8.app.0.3ce0bb8_r14_ad1]$7669126";
    //    }

    //    public override void ()
    //    {
    //        tag "[WindowsForms10.Window.8.app.0.3ce0bb8_r14_ad1]$6882340";
    //    }

    //    public override void ()
    //    {
    //        tag "[WindowsForms10.Window.8.app.0.3ce0bb8_r14_ad1]$5767968";
    //    }

    //    public override void ()
    //    {
    //        tag "[WindowsForms10.Window.8.app.0.3ce0bb8_r14_ad1]$5636898";
    //    }

    //    public override void ()
    //    {
    //        tag "[WindowsForms10.Window.8.app.0.3ce0bb8_r14_ad1]$4458072";
    //    }

    //    public override void ()
    //    {
    //        tag "[WindowsForms10.Window.8.app.0.3ce0bb8_r14_ad1]$1836204";
    //    }

    //    public override void ()
    //    {
    //        tag "[WindowsForms10.Window.8.app.0.3ce0bb8_r14_ad1]$1378250";
    //    }

    //    public override void ()
    //    {
    //        tag "[WindowsForms10.Window.8.app.0.3ce0bb8_r14_ad1]$5572236";
    //    }

    //    public override void ()
    //    {
    //        tag "[WindowsForms10.Window.8.app.0.3ce0bb8_r14_ad1]$329776";
    //    }

    //    public override void ()
    //    {
    //        tag "[WindowsForms10.Window.8.app.0.3ce0bb8_r14_ad1]$329752";
    //    }

    //    public override void ()
    //    {
    //        tag "[WindowsForms10.Window.8.app.0.3ce0bb8_r14_ad1]$526256";
    //    }

    //    public override void ()
    //    {
    //        tag "[WindowsForms10.Window.8.app.0.3ce0bb8_r14_ad1]$7406690";
    //    }

    //    public override void ()
    //    {
    //        tag "[WindowsForms10.Window.8.app.0.3ce0bb8_r14_ad1]$4851386";
    //    }

    //    public override void ()
    //    {
    //        tag "[WindowsForms10.Window.8.app.0.3ce0bb8_r14_ad1]$4785994";
    //    }

    //    public override void ()
    //    {
    //        tag "[WindowsForms10.Window.8.app.0.3ce0bb8_r14_ad1]$5899744";
    //    }

    //    public override void ()
    //    {
    //        tag "[WindowsForms10.Window.8.app.0.3ce0bb8_r14_ad1]$4916186";
    //    }

    //    public override void ()
    //    {
    //        tag "[WindowsForms10.Window.8.app.0.3ce0bb8_r14_ad1]$5113182";
    //    }

    //    public override void ()
    //    {
    //        tag "[WindowsForms10.Window.8.app.0.3ce0bb8_r14_ad1]$8193560";
    //    }

    //    public override void ()
    //    {
    //        tag "[WindowsForms10.Window.8.app.0.3ce0bb8_r14_ad1]$3474978";
    //    }

    //    public override void ()
    //    {
    //        tag "[WindowsForms10.Window.8.app.0.3ce0bb8_r14_ad1]$5112616";
    //    }

    //    public override void ()
    //    {
    //        tag "[WindowsForms10.Window.8.app.0.3ce0bb8_r14_ad1]$329786";
    //    }

    //    public override void ()
    //    {
    //        tag "[WindowsForms10.Window.8.app.0.3ce0bb8_r14_ad1]$264258";
    //    }

    //    public override void ()
    //    {
    //        tag "[WindowsForms10.Window.8.app.0.3ce0bb8_r14_ad1]$264260";
    //    }

    //    public override void ()
    //    {
    //        tag "[WindowsForms10.Window.8.app.0.3ce0bb8_r14_ad1]$3278038";
    //    }

    //    public override void ()
    //    {
    //        tag "[WindowsForms10.Window.8.app.0.3ce0bb8_r14_ad1]$5374788";
    //    }

    //    public override void ()
    //    {
    //        tag "[WindowsForms10.Window.8.app.0.3ce0bb8_r14_ad1]$7014188";
    //    }

    //    public override void ()
    //    {
    //        tag "[WindowsForms10.Window.8.app.0.3ce0bb8_r14_ad1]$657330";
    //    }

    //    public override void ()
    //    {
    //        tag "[WindowsForms10.Window.8.app.0.3ce0bb8_r14_ad1]$264254";
    //    }

    //    public override void ()
    //    {
    //        tag "[WindowsForms10.Window.8.app.0.3ce0bb8_r14_ad1]$264256";
    //    }
    //}

    //public class AutodeskVaultProfessionaLogIn : PLANTVAACEXPLORER_DB
    //{
    //    public override void ()
    //    {
    //    }

    //    public override void ()
    //    {
    //    }

    //    public override void ()
    //    {
    //        tag "[WindowsForms10 tag "[WindowsForms10 = Window.Current<tag "[WindowsForms10>();
    //        tag "[WindowsForms10.Window.8.app.0.3ce0bb8_r14_ad1]$1181748";
    //        CustomWin AutomaticallyLogInNextSess CustomWin AutomaticallyLogInNextSess = Window.Current<CustomWin AutomaticallyLogInNextSess>();
    //        CustomWin AutomaticallyLogInNextSess;
    //        tag "[WindowsForms10.BUTTON.app.0.3ce0bb8_r14_ad1]$3213268";
    //        CustomWin UserName CustomWin UserName = Window.Current<CustomWin UserName>();
    //        CustomWin UserName;
    //        tag "[WindowsForms10.STATIC.app.0.3ce0bb8_r14_ad1]$4785678";
    //        CustomWin Password CustomWin Password = Window.Current<CustomWin Password>();
    //        CustomWin Password;
    //        tag "[WindowsForms10.STATIC.app.0.3ce0bb8_r14_ad1]$7996296";
    //        CustomWin Server CustomWin Server = Window.Current<CustomWin Server>();
    //        CustomWin Server;
    //        tag "[WindowsForms10.STATIC.app.0.3ce0bb8_r14_ad1]$3999224";
    //        CustomWin Vault CustomWin Vault = Window.Current<CustomWin Vault>();
    //        CustomWin Vault;
    //        tag "[WindowsForms10.STATIC.app.0.3ce0bb8_r14_ad1]$7406820";
    //        CustomWin Administrator CustomWin Administrator = Window.Current<CustomWin Administrator>();
    //        CustomWin Administrator;
    //        tag "[WindowsForms10.EDIT.app.0.3ce0bb8_r14_ad1]$6096310";
    //        CustomWin WindowsForms10EDITApp03ce0 CustomWin WindowsForms10EDITApp03ce0 = Window.Current<CustomWin WindowsForms10EDITApp03ce0>();
    //        CustomWin WindowsForms10EDITApp03ce0;
    //        tag "[WindowsForms10.EDIT.app.0.3ce0bb8_r14_ad1]$5965268";
    //        CustomWin ENV006PC CustomWin ENV006PC = Window.Current<CustomWin ENV006PC>();
    //        CustomWin ENV006PC;
    //        tag "[WindowsForms10.COMBOBOX.app.0.3ce0bb8_r14_ad1]$2754254";
    //        AdTextField TextField1 AdTextField TextField1 = Window.Current<AdTextField TextField1>();
    //        AdTextField TextField1;
    //        tag "$1001" tag "$1001" = Window.Current<tag "$1001">();
    //        tag "$1001";
    //        CustomWin WindowsForms10Window8App01 CustomWin WindowsForms10Window8App01 = Window.Current<CustomWin WindowsForms10Window8App01>();
    //        CustomWin WindowsForms10Window8App01;
    //        tag "[WindowsForms10.Window.8.app.0.3ce0bb8_r14_ad1]$7407216";
    //        CustomWin WindowsForms10Window8App0 CustomWin WindowsForms10Window8App0 = Window.Current<CustomWin WindowsForms10Window8App0>();
    //        CustomWin WindowsForms10Window8App0;
    //        tag "[WindowsForms10.Window.8.app.0.3ce0bb8_r14_ad1]$3802408";
    //        CustomWin WindowsForms10BUTTONApp03c CustomWin WindowsForms10BUTTONApp03c = Window.Current<CustomWin WindowsForms10BUTTONApp03c>();
    //        CustomWin WindowsForms10BUTTONApp03c;
    //        tag "[WindowsForms10.BUTTON.app.0.3ce0bb8_r14_ad1]$3868468";
    //        CustomWin OK CustomWin OK = Window.Current<CustomWin OK>();
    //        CustomWin OK;
    //        tag "[WindowsForms10.BUTTON.app.0.3ce0bb8_r14_ad1]$8455088";
    //        CustomWin Help CustomWin Help = Window.Current<CustomWin Help>();
    //        CustomWin Help;
    //        tag "[WindowsForms10.BUTTON.app.0.3ce0bb8_r14_ad1]$5702652";
    //        CustomWin Cancel CustomWin Cancel = Window.Current<CustomWin Cancel>();
    //        CustomWin Cancel;
    //        tag "[WindowsForms10.BUTTON.app.0.3ce0bb8_r14_ad1]$4392238";
    //        CustomWin WindowsForms10Window8App02 CustomWin WindowsForms10Window8App02 = Window.Current<CustomWin WindowsForms10Window8App02>();
    //        CustomWin WindowsForms10Window8App02;
    //        tag "[WindowsForms10.Window.8.app.0.3ce0bb8_r14_ad1]$4719874";
    //        CustomWin WindowsForms10Window8App0;
    //        tag "[WindowsForms10.Window.8.app.0.3ce0bb8_r14_ad1]$4785990";
    //        CustomWin Vault;
    //        tag "[WindowsForms10.COMBOBOX.app.0.3ce0bb8_r14_ad1]$5834034";
    //        AdTextField TextField1;
    //        tag "$1001";
    //        CustomWin WindowsForms10BUTTONApp03c;
    //        tag "[WindowsForms10.BUTTON.app.0.3ce0bb8_r14_ad1]$460860";
    //        CustomWin VaultAccount CustomWin VaultAccount = Window.Current<CustomWin VaultAccount>();
    //        CustomWin VaultAccount;
    //        tag "[WindowsForms10.COMBOBOX.app.0.3ce0bb8_r14_ad1]$6162370";
    //        CustomWin Authentication CustomWin Authentication = Window.Current<CustomWin Authentication>();
    //        CustomWin Authentication;
    //        tag "[WindowsForms10.STATIC.app.0.3ce0bb8_r14_ad1]$6161186";
    //    }

    //    public override void ()
    //    {
    //        tag "[WindowsForms10.Window.8.app.0.3ce0bb8_r14_ad1]$4851172";
    //        CustomWin WindowsForms10Window8App01;
    //        tag "[WindowsForms10.Window.8.app.0.3ce0bb8_r14_ad1]$4851390";
    //        CustomWin WindowsForms10Window8App02;
    //        tag "[WindowsForms10.Window.8.app.0.3ce0bb8_r14_ad1]$5899706";
    //    }

    //    public override void ()
    //    {
    //        tag "[WindowsForms10.Window.8.app.0.3ce0bb8_r14_ad1]$2884076";
    //    }
	//}
}
