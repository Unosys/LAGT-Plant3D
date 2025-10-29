using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LAGT.CommonFiles.Test_Suites.GlobalArt;
using Autodesk.GUIHarness.Plant3D.ArtScripts;

namespace Autodesk.GUIHarness.Plant3D.TestSuites.Art
{
    public class ArtAutomation_Setup : IArtAutomation_Setup
    {
        public ArtAutomation_Setup()
        {
            this._RecoverBatWaitTime = 500;
        }

        public List<string> _AllArtAutomationScreenShots = new List<string>()
        {
//"dlg_add_endcode",
            //"db_proj_setup_3d_piping_connectors_add_joint",
            //"dlg_create_equipment_equip_tab",
            //"dlg_modify_equipment_equip_tab",
            //"dlg_iso_projectannotations",
            //"dlg_iso_projectdimensions",
            //"dlg_iso_projectisoslopesandskews",
            //"dlg_ps_iso_advanced_defaults_ref",
            //"db_proj_setup_themes",
            //"dlg_iso_projectisostylesetup",
             //"dlg_iso_createisostyle",
             //"dlg_create_new_style",
             //"dlg_iso_projecttitleblockanddisplay",
             //"dlg_isothemesdefaulttheme",
             //"dlg_project_setup_iso_table_setup_settings_tab",
             //"dlg_proj_setup_gen_set_proj_detail_general_props",
             //"db_proj_setup_proj_details_add",
             //"dlg_project_setup_wizard_5",
             //"dlg_report_query_configuration",
             //"dlg_sdnf_export",
             //"ico_remove_from_spec",
             //"ill_ortho_template",
             //"ill_ribbon_iso",
             //"balloon_iso_complete",
             //"ill_iso_refdim_beam_xref",
             //"dlg_tpcftopipe",
             //  "dlg_ps_joint_spec_filter",
             //"dlg_equ_trim_override",
             //"dlg_ps_iso_sym_ref",
             //"iso_refdim_preview_pp", 
             "dlg_convert_split_points", //not working properly
             //"ill_opc_connect_list" //semi
             //"iso_refdim_preview", //snagit
             //"ill_iso_refdim_wall_type", //snagit
             //"iso_refdim_add", //snagit
             //"dlg_vault_vaac",
             //"dlg_vault_options",
             //"dlg_vault_project_setup",
             //"dlg_vault_check_in",
             //"dlg_vault_get_checkout",
             //"dlg_attachexternalreference_ref",
             //"dlg_attachexternalreferencerelated_ref",
              //Milan
              //"dlg_vault_dns",
              //"dlg_open_vault_project_piper",
             //"ill_routing_tolerance_offset",
            
        };


        // Set the Harness watchdog timer
        private int _RecoverBatWaitTime = 500;

        public List<string> AllArtAutomationScreenshots
        {
            get
            {
                return this._AllArtAutomationScreenShots;
            }
        }
        public int RecoverBatWaitTime 
        { 
            get 
            {
                return this._RecoverBatWaitTime;
            }
        }


    }
}
