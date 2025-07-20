using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pulp_stone_ai_test_gui
{
    public partial class Main : Form
    {
        private Utils utils;

        public Main()
        {
            InitializeComponent();

            Log logForm = new Log();

            utils = new Utils(
                lbl_status, lbl_status_header,
                lbl_selected_model, lbl_selected_model_header,
                lbl_image_count, lbl_image_count_header,
                lstbox_images, trkbar_confidence, nmrc_up_down_confidence,
                chkbox_option_log, chkbox_option_save_logs, chkbox_option_show_results,
                logForm);

            this.Text = "Pulp Stone AI Test GUI";
            this.MaximizeBox = false;

            lstbox_images.HorizontalScrollbar = true;
        }

        private void btn_scan_folder_Click(object sender, EventArgs e)
        {
            utils.scan_folder_and_add_images_to_listbox();

            utils.update_status();
        }

        private void btn_clear_listbox_Click(object sender, EventArgs e)
        {
            utils.clear_listbox();

            utils.update_status();
        }

        private void btn_uncheck_all_items_Click(object sender, EventArgs e)
        {
            utils.uncheck_all_items();

            utils.update_status();
        }

        private void btn_check_all_items_Click(object sender, EventArgs e)
        {
            utils.check_all_items();

            utils.update_status();
        }

        private async void btn_start_detect_Click(object sender, EventArgs e)
        {
            List<Settings> settings = utils.get_settings();

            await utils.start_detect();
        }

        private void lstbox_images_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            if (e.NewValue == CheckState.Checked)
            {
                // If the item is checked, increment the count
                utils.set_image_count(true);
            }
            else if (e.NewValue == CheckState.Unchecked)
            {
                // If the item is unchecked, decrement the count
                utils.set_image_count(false);
            }
        }

        private void btn_select_model_Click(object sender, EventArgs e)
        {
            utils.select_model();

            utils.update_status();
        }

        private void trkbar_confidence_Scroll(object sender, EventArgs e)
        {
            utils.trackbar_scroll();
        }

        private void nmrc_up_down_confidence_ValueChanged(object sender, EventArgs e)
        {
            utils.numeric_up_down_value_changed();
        }
    }
}
