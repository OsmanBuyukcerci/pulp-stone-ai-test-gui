namespace pulp_stone_ai_test_gui
{
    partial class Main
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.lstbox_images = new System.Windows.Forms.CheckedListBox();
            this.btn_scan_folder = new System.Windows.Forms.Button();
            this.btn_clear_listbox = new System.Windows.Forms.Button();
            this.btn_uncheck_all_items = new System.Windows.Forms.Button();
            this.grpbox_buttons = new System.Windows.Forms.GroupBox();
            this.btn_select_model = new System.Windows.Forms.Button();
            this.btn_start_detect = new System.Windows.Forms.Button();
            this.btn_check_all_items = new System.Windows.Forms.Button();
            this.lbl_status_header = new System.Windows.Forms.Label();
            this.lbl_status = new System.Windows.Forms.Label();
            this.grpbox_details = new System.Windows.Forms.GroupBox();
            this.lbl_selected_model = new System.Windows.Forms.Label();
            this.lbl_image_count = new System.Windows.Forms.Label();
            this.lbl_selected_model_header = new System.Windows.Forms.Label();
            this.lbl_image_count_header = new System.Windows.Forms.Label();
            this.grpbox_settings = new System.Windows.Forms.GroupBox();
            this.nmrc_up_down_confidence = new System.Windows.Forms.NumericUpDown();
            this.lbl_confidence_header = new System.Windows.Forms.Label();
            this.trkbar_confidence = new System.Windows.Forms.TrackBar();
            this.chkbox_option_show_results = new System.Windows.Forms.CheckBox();
            this.chkbox_option_save_logs = new System.Windows.Forms.CheckBox();
            this.chkbox_option_log = new System.Windows.Forms.CheckBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.grpbox_buttons.SuspendLayout();
            this.grpbox_details.SuspendLayout();
            this.grpbox_settings.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmrc_up_down_confidence)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trkbar_confidence)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstbox_images
            // 
            this.lstbox_images.FormattingEnabled = true;
            this.lstbox_images.Location = new System.Drawing.Point(16, 15);
            this.lstbox_images.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lstbox_images.Name = "lstbox_images";
            this.lstbox_images.Size = new System.Drawing.Size(367, 242);
            this.lstbox_images.TabIndex = 1;
            this.lstbox_images.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.lstbox_images_ItemCheck);
            // 
            // btn_scan_folder
            // 
            this.btn_scan_folder.Location = new System.Drawing.Point(8, 23);
            this.btn_scan_folder.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_scan_folder.Name = "btn_scan_folder";
            this.btn_scan_folder.Size = new System.Drawing.Size(139, 28);
            this.btn_scan_folder.TabIndex = 3;
            this.btn_scan_folder.Text = "Klasör Tara";
            this.btn_scan_folder.UseVisualStyleBackColor = true;
            this.btn_scan_folder.Click += new System.EventHandler(this.btn_scan_folder_Click);
            // 
            // btn_clear_listbox
            // 
            this.btn_clear_listbox.Location = new System.Drawing.Point(8, 59);
            this.btn_clear_listbox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_clear_listbox.Name = "btn_clear_listbox";
            this.btn_clear_listbox.Size = new System.Drawing.Size(139, 28);
            this.btn_clear_listbox.TabIndex = 4;
            this.btn_clear_listbox.Text = "Listeyi Temizle";
            this.btn_clear_listbox.UseVisualStyleBackColor = true;
            this.btn_clear_listbox.Click += new System.EventHandler(this.btn_clear_listbox_Click);
            // 
            // btn_uncheck_all_items
            // 
            this.btn_uncheck_all_items.Location = new System.Drawing.Point(8, 95);
            this.btn_uncheck_all_items.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_uncheck_all_items.Name = "btn_uncheck_all_items";
            this.btn_uncheck_all_items.Size = new System.Drawing.Size(139, 28);
            this.btn_uncheck_all_items.TabIndex = 5;
            this.btn_uncheck_all_items.Text = "Seçimleri Temizle";
            this.btn_uncheck_all_items.UseVisualStyleBackColor = true;
            this.btn_uncheck_all_items.Click += new System.EventHandler(this.btn_uncheck_all_items_Click);
            // 
            // grpbox_buttons
            // 
            this.grpbox_buttons.Controls.Add(this.btn_select_model);
            this.grpbox_buttons.Controls.Add(this.btn_start_detect);
            this.grpbox_buttons.Controls.Add(this.btn_check_all_items);
            this.grpbox_buttons.Controls.Add(this.btn_scan_folder);
            this.grpbox_buttons.Controls.Add(this.btn_uncheck_all_items);
            this.grpbox_buttons.Controls.Add(this.btn_clear_listbox);
            this.grpbox_buttons.Location = new System.Drawing.Point(392, 15);
            this.grpbox_buttons.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpbox_buttons.Name = "grpbox_buttons";
            this.grpbox_buttons.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpbox_buttons.Size = new System.Drawing.Size(155, 238);
            this.grpbox_buttons.TabIndex = 6;
            this.grpbox_buttons.TabStop = false;
            this.grpbox_buttons.Text = "Butonlar";
            // 
            // btn_select_model
            // 
            this.btn_select_model.Location = new System.Drawing.Point(11, 167);
            this.btn_select_model.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_select_model.Name = "btn_select_model";
            this.btn_select_model.Size = new System.Drawing.Size(136, 28);
            this.btn_select_model.TabIndex = 10;
            this.btn_select_model.Text = "Model Seç";
            this.btn_select_model.UseVisualStyleBackColor = true;
            this.btn_select_model.Click += new System.EventHandler(this.btn_select_model_Click);
            // 
            // btn_start_detect
            // 
            this.btn_start_detect.Location = new System.Drawing.Point(8, 203);
            this.btn_start_detect.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_start_detect.Name = "btn_start_detect";
            this.btn_start_detect.Size = new System.Drawing.Size(139, 28);
            this.btn_start_detect.TabIndex = 7;
            this.btn_start_detect.Text = "Çalıştır";
            this.btn_start_detect.UseVisualStyleBackColor = true;
            this.btn_start_detect.Click += new System.EventHandler(this.btn_start_detect_Click);
            // 
            // btn_check_all_items
            // 
            this.btn_check_all_items.Location = new System.Drawing.Point(9, 132);
            this.btn_check_all_items.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_check_all_items.Name = "btn_check_all_items";
            this.btn_check_all_items.Size = new System.Drawing.Size(137, 28);
            this.btn_check_all_items.TabIndex = 6;
            this.btn_check_all_items.Text = "Tümünü Seç";
            this.btn_check_all_items.UseVisualStyleBackColor = true;
            this.btn_check_all_items.Click += new System.EventHandler(this.btn_check_all_items_Click);
            // 
            // lbl_status_header
            // 
            this.lbl_status_header.AutoSize = true;
            this.lbl_status_header.ForeColor = System.Drawing.Color.Red;
            this.lbl_status_header.Location = new System.Drawing.Point(4, 10);
            this.lbl_status_header.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_status_header.Name = "lbl_status_header";
            this.lbl_status_header.Size = new System.Drawing.Size(49, 16);
            this.lbl_status_header.TabIndex = 7;
            this.lbl_status_header.Text = "Durum:";
            // 
            // lbl_status
            // 
            this.lbl_status.AutoSize = true;
            this.lbl_status.Location = new System.Drawing.Point(61, 10);
            this.lbl_status.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_status.Name = "lbl_status";
            this.lbl_status.Size = new System.Drawing.Size(204, 16);
            this.lbl_status.TabIndex = 8;
            this.lbl_status.Text = "Lütfen en az bir tane resim seçiniz";
            // 
            // grpbox_details
            // 
            this.grpbox_details.Controls.Add(this.panel1);
            this.grpbox_details.Controls.Add(this.lbl_selected_model);
            this.grpbox_details.Controls.Add(this.lbl_image_count);
            this.grpbox_details.Controls.Add(this.lbl_selected_model_header);
            this.grpbox_details.Controls.Add(this.lbl_image_count_header);
            this.grpbox_details.Location = new System.Drawing.Point(16, 378);
            this.grpbox_details.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpbox_details.Name = "grpbox_details";
            this.grpbox_details.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpbox_details.Size = new System.Drawing.Size(523, 138);
            this.grpbox_details.TabIndex = 9;
            this.grpbox_details.TabStop = false;
            this.grpbox_details.Text = "Detaylar";
            // 
            // lbl_selected_model
            // 
            this.lbl_selected_model.AutoSize = true;
            this.lbl_selected_model.Location = new System.Drawing.Point(120, 53);
            this.lbl_selected_model.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_selected_model.Name = "lbl_selected_model";
            this.lbl_selected_model.Size = new System.Drawing.Size(147, 16);
            this.lbl_selected_model.TabIndex = 11;
            this.lbl_selected_model.Text = "Henüz model seçilmedi";
            // 
            // lbl_image_count
            // 
            this.lbl_image_count.AutoSize = true;
            this.lbl_image_count.Location = new System.Drawing.Point(156, 25);
            this.lbl_image_count.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_image_count.Name = "lbl_image_count";
            this.lbl_image_count.Size = new System.Drawing.Size(14, 16);
            this.lbl_image_count.TabIndex = 10;
            this.lbl_image_count.Text = "0";
            // 
            // lbl_selected_model_header
            // 
            this.lbl_selected_model_header.AutoSize = true;
            this.lbl_selected_model_header.ForeColor = System.Drawing.Color.Red;
            this.lbl_selected_model_header.Location = new System.Drawing.Point(9, 53);
            this.lbl_selected_model_header.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_selected_model_header.Name = "lbl_selected_model_header";
            this.lbl_selected_model_header.Size = new System.Drawing.Size(96, 16);
            this.lbl_selected_model_header.TabIndex = 10;
            this.lbl_selected_model_header.Text = "Seçilen Model:";
            // 
            // lbl_image_count_header
            // 
            this.lbl_image_count_header.AutoSize = true;
            this.lbl_image_count_header.ForeColor = System.Drawing.Color.Red;
            this.lbl_image_count_header.Location = new System.Drawing.Point(9, 25);
            this.lbl_image_count_header.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_image_count_header.Name = "lbl_image_count_header";
            this.lbl_image_count_header.Size = new System.Drawing.Size(131, 16);
            this.lbl_image_count_header.TabIndex = 9;
            this.lbl_image_count_header.Text = "Seçilen Resim Adeti:";
            // 
            // grpbox_settings
            // 
            this.grpbox_settings.Controls.Add(this.nmrc_up_down_confidence);
            this.grpbox_settings.Controls.Add(this.lbl_confidence_header);
            this.grpbox_settings.Controls.Add(this.trkbar_confidence);
            this.grpbox_settings.Controls.Add(this.chkbox_option_show_results);
            this.grpbox_settings.Controls.Add(this.chkbox_option_save_logs);
            this.grpbox_settings.Controls.Add(this.chkbox_option_log);
            this.grpbox_settings.Location = new System.Drawing.Point(16, 267);
            this.grpbox_settings.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpbox_settings.Name = "grpbox_settings";
            this.grpbox_settings.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpbox_settings.Size = new System.Drawing.Size(523, 103);
            this.grpbox_settings.TabIndex = 10;
            this.grpbox_settings.TabStop = false;
            this.grpbox_settings.Text = "Ayarlar";
            // 
            // nmrc_up_down_confidence
            // 
            this.nmrc_up_down_confidence.DecimalPlaces = 2;
            this.nmrc_up_down_confidence.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.nmrc_up_down_confidence.Location = new System.Drawing.Point(383, 21);
            this.nmrc_up_down_confidence.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.nmrc_up_down_confidence.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nmrc_up_down_confidence.Name = "nmrc_up_down_confidence";
            this.nmrc_up_down_confidence.Size = new System.Drawing.Size(87, 22);
            this.nmrc_up_down_confidence.TabIndex = 14;
            this.nmrc_up_down_confidence.ValueChanged += new System.EventHandler(this.nmrc_up_down_confidence_ValueChanged);
            // 
            // lbl_confidence_header
            // 
            this.lbl_confidence_header.AutoSize = true;
            this.lbl_confidence_header.Location = new System.Drawing.Point(289, 26);
            this.lbl_confidence_header.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_confidence_header.Name = "lbl_confidence_header";
            this.lbl_confidence_header.Size = new System.Drawing.Size(78, 16);
            this.lbl_confidence_header.TabIndex = 12;
            this.lbl_confidence_header.Text = "Confidence:";
            // 
            // trkbar_confidence
            // 
            this.trkbar_confidence.Location = new System.Drawing.Point(293, 44);
            this.trkbar_confidence.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.trkbar_confidence.Maximum = 100;
            this.trkbar_confidence.Name = "trkbar_confidence";
            this.trkbar_confidence.Size = new System.Drawing.Size(221, 56);
            this.trkbar_confidence.TabIndex = 11;
            this.trkbar_confidence.Scroll += new System.EventHandler(this.trkbar_confidence_Scroll);
            // 
            // chkbox_option_show_results
            // 
            this.chkbox_option_show_results.AutoSize = true;
            this.chkbox_option_show_results.Location = new System.Drawing.Point(8, 79);
            this.chkbox_option_show_results.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.chkbox_option_show_results.Name = "chkbox_option_show_results";
            this.chkbox_option_show_results.Size = new System.Drawing.Size(128, 20);
            this.chkbox_option_show_results.TabIndex = 2;
            this.chkbox_option_show_results.Text = "Sonuçları Göster";
            this.chkbox_option_show_results.UseVisualStyleBackColor = true;
            // 
            // chkbox_option_save_logs
            // 
            this.chkbox_option_save_logs.AutoSize = true;
            this.chkbox_option_save_logs.Location = new System.Drawing.Point(8, 52);
            this.chkbox_option_save_logs.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.chkbox_option_save_logs.Name = "chkbox_option_save_logs";
            this.chkbox_option_save_logs.Size = new System.Drawing.Size(115, 20);
            this.chkbox_option_save_logs.TabIndex = 1;
            this.chkbox_option_save_logs.Text = "Logları Kaydet";
            this.chkbox_option_save_logs.UseVisualStyleBackColor = true;
            // 
            // chkbox_option_log
            // 
            this.chkbox_option_log.AutoSize = true;
            this.chkbox_option_log.Location = new System.Drawing.Point(8, 25);
            this.chkbox_option_log.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.chkbox_option_log.Name = "chkbox_option_log";
            this.chkbox_option_log.Size = new System.Drawing.Size(113, 20);
            this.chkbox_option_log.TabIndex = 0;
            this.chkbox_option_log.Text = "Logları Göster";
            this.chkbox_option_log.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(this.lbl_status_header);
            this.panel1.Controls.Add(this.lbl_status);
            this.panel1.Location = new System.Drawing.Point(8, 72);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(502, 54);
            this.panel1.TabIndex = 12;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(556, 516);
            this.Controls.Add(this.grpbox_settings);
            this.Controls.Add(this.grpbox_details);
            this.Controls.Add(this.grpbox_buttons);
            this.Controls.Add(this.lstbox_images);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Main";
            this.Text = "Form1";
            this.grpbox_buttons.ResumeLayout(false);
            this.grpbox_details.ResumeLayout(false);
            this.grpbox_details.PerformLayout();
            this.grpbox_settings.ResumeLayout(false);
            this.grpbox_settings.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmrc_up_down_confidence)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trkbar_confidence)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.CheckedListBox lstbox_images;
        private System.Windows.Forms.Button btn_scan_folder;
        private System.Windows.Forms.Button btn_clear_listbox;
        private System.Windows.Forms.Button btn_uncheck_all_items;
        private System.Windows.Forms.GroupBox grpbox_buttons;
        private System.Windows.Forms.Button btn_check_all_items;
        private System.Windows.Forms.Button btn_start_detect;
        private System.Windows.Forms.Label lbl_status_header;
        private System.Windows.Forms.Label lbl_status;
        private System.Windows.Forms.Button btn_select_model;
        private System.Windows.Forms.GroupBox grpbox_details;
        private System.Windows.Forms.Label lbl_image_count;
        private System.Windows.Forms.Label lbl_image_count_header;
        private System.Windows.Forms.Label lbl_selected_model;
        private System.Windows.Forms.Label lbl_selected_model_header;
        private System.Windows.Forms.GroupBox grpbox_settings;
        private System.Windows.Forms.CheckBox chkbox_option_save_logs;
        private System.Windows.Forms.CheckBox chkbox_option_log;
        private System.Windows.Forms.CheckBox chkbox_option_show_results;
        private System.Windows.Forms.Label lbl_confidence_header;
        private System.Windows.Forms.TrackBar trkbar_confidence;
        private System.Windows.Forms.NumericUpDown nmrc_up_down_confidence;
        private System.Windows.Forms.Panel panel1;
    }
}

