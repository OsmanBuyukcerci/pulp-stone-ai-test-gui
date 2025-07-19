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
        public Main()
        {
            InitializeComponent();

            this.Text = "Pulp Stone AI Test GUI";

            lstbox_images.HorizontalScrollbar = true;
        }

        private void btn_scan_folder_Click(object sender, EventArgs e)
        {
            Utils utils = new Utils();

            utils.scan_folder_and_add_images_to_listbox(lstbox_images);

            utils.update_status(lbl_status, lbl_status_header, lbl_selected_model, lbl_selected_model_header, lbl_image_count, lbl_image_count_header, lstbox_images);
        }

        private void btn_clear_listbox_Click(object sender, EventArgs e)
        {
            Utils utils = new Utils();

            utils.clear_listbox(lstbox_images, lbl_image_count, lbl_image_count_header);

            utils.update_status(lbl_status, lbl_status_header, lbl_selected_model, lbl_selected_model_header, lbl_image_count, lbl_image_count_header, lstbox_images);
        }

        private void btn_uncheck_all_items_Click(object sender, EventArgs e)
        {
            Utils utils = new Utils();

            utils.uncheck_all_items(lstbox_images);

            utils.update_status(lbl_status, lbl_status_header, lbl_selected_model, lbl_selected_model_header, lbl_image_count, lbl_image_count_header, lstbox_images);
        }

        private void btn_check_all_items_Click(object sender, EventArgs e)
        {
            Utils utils = new Utils();

            utils.check_all_items(lstbox_images);

            utils.update_status(lbl_status, lbl_status_header, lbl_selected_model, lbl_selected_model_header, lbl_image_count, lbl_image_count_header, lstbox_images);
        }

        private async void btn_start_detect_Click(object sender, EventArgs e)
        {
            Utils utils = new Utils();

            Log logForm = new Log();

            List<Settings> settings = utils.get_settings(chkbox_option_log, chkbox_option_save_logs, chkbox_option_show_results);

            if (settings.Contains(Settings.ShowLogs))
            {
                logForm.Show();
            }

            await utils.start_detect(
                settings,
                chkbox_option_log,
                chkbox_option_save_logs,
                chkbox_option_show_results,
                lbl_selected_model,
                lbl_status,
                trkbar_confidence,
                lstbox_images,
                logForm);
        }

        private void lstbox_images_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            Utils utils = new Utils();

            if (e.NewValue == CheckState.Checked)
            {
                // If the item is checked, increment the count
                utils.set_image_count(lstbox_images, lbl_image_count, lbl_image_count_header, true);
            }
            else if (e.NewValue == CheckState.Unchecked)
            {
                // If the item is unchecked, decrement the count
                utils.set_image_count(lstbox_images, lbl_image_count, lbl_image_count_header, false);
            }
        }

        private void btn_select_model_Click(object sender, EventArgs e)
        {
            Utils utils = new Utils();

            utils.select_model(lbl_selected_model, lbl_selected_model_header);

            utils.update_status(lbl_status, lbl_status_header, lbl_selected_model, lbl_selected_model_header, lbl_image_count, lbl_image_count_header, lstbox_images);
        }

        private void trkbar_confidence_Scroll(object sender, EventArgs e)
        {
            Utils utils = new Utils();

            utils.trackbar_scroll(trkbar_confidence, nmrc_up_down_confidence);
        }

        private void nmrc_up_down_confidence_ValueChanged(object sender, EventArgs e)
        {
            Utils utils = new Utils();

            utils.numeric_up_down_value_changed(nmrc_up_down_confidence, trkbar_confidence);
        }
    }
}
