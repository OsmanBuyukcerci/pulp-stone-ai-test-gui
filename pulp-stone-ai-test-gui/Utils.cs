using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace pulp_stone_ai_test_gui
{
    internal class Utils
    {
        public void set_image_count(CheckedListBox checkedListBox, Label countLabel, Label countHeaderLabel, bool isIncrement)
        {
            int newCount = checkedListBox.CheckedItems.Count;
            if (isIncrement)
            {
                newCount++;
            }
            else
            {
                newCount--;
            }

            set_count_label(countLabel, countHeaderLabel, newCount);
        }

        public void set_count_label(Label countLabel, Label countHeaderLabel, int count)
        {
            countLabel.Text = count.ToString();
            countHeaderLabel.ForeColor = count > 0 ? Color.Green : Color.Red;
        }

        public void set_status(Label statusLabel, Label statusHeaderLabel, string message, Color color)
        {
            statusLabel.Text = message;
            statusHeaderLabel.ForeColor = color;
        }

        public void scan_folder_and_add_images_to_listbox(CheckedListBox checkedListBox)
        {
            using (var fbd = new FolderBrowserDialog())
            {
                fbd.Description = "Lütfen taramak istediğiniz klasörü seçin";
                fbd.RootFolder = Environment.SpecialFolder.MyComputer;

                DialogResult result = fbd.ShowDialog();

                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
                {
                    string[] images = Directory.GetFiles(fbd.SelectedPath, "*.png", SearchOption.AllDirectories);

                    foreach (string image in images)
                    {
                        checkedListBox.Items.Add(image, true);
                    }
                }
            }
        }

        public void clear_listbox(CheckedListBox checkedListBox, Label countLabel, Label countHeaderLabel)
        {
            checkedListBox.Items.Clear();
            set_count_label(countLabel, countHeaderLabel, 0);
        }

        public void uncheck_all_items(CheckedListBox checkedListBox)
        {
            for (int i = 0; i < checkedListBox.Items.Count; i++)
            {
                checkedListBox.SetItemChecked(i, false);
            }
        }

        public void check_all_items(CheckedListBox checkedListBox)
        {
            for (int i = 0; i < checkedListBox.Items.Count; i++)
            {
                checkedListBox.SetItemChecked(i, true);
            }
        }

        public void select_model(Label selectedModelLabel, Label selectedModelLabelHeader)
        {
            using (var ofd = new OpenFileDialog())
            {
                string modelsDirectory = Path.Combine(Directory.GetParent(Application.StartupPath).Parent.FullName, "models");

                ofd.Title = "Bir model seçin";
                ofd.Filter = "Modeller|*.pt*";
                ofd.InitialDirectory = modelsDirectory;

                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    string selectedModelPath = ofd.FileName;
                    string selectedModelName = selectedModelPath.Split('\\').Last();

                    

                    selectedModelLabel.Text = selectedModelName;
                    selectedModelLabelHeader.ForeColor = Color.Green;
                }
            }
        }

        public void trackbar_scroll(TrackBar trackbarConfidence, NumericUpDown nupConfidence)
        {
            if (trackbarConfidence.Value == 0)
            {
                nupConfidence.Text = "0";
                return;
            }

            double newConfidence = trackbarConfidence.Value / 100.0;

            nupConfidence.Text = newConfidence.ToString();
        }

        public void numeric_up_down_value_changed(NumericUpDown nupConfidence, TrackBar trackbarConfidence)
        {
            if (nupConfidence.Value == 0)
            {
                trackbarConfidence.Value = 0;
                return;
            }
            double newConfidence = Convert.ToDouble(nupConfidence.Value);
            int trackbarValue = (int)(newConfidence * 100);
            trackbarConfidence.Value = trackbarValue;
        }

        public string[] get_model_names()
        {
            string modelsPath = Path.Combine(Directory.GetParent(Application.StartupPath).Parent.FullName, "models");

            string[] models = Directory.GetFiles(modelsPath);

            return models;
        }

        public Queue<string> check_status(
            Label statusLabel, 
            Label statusHeaderLabel, 
            Label modelLabel, 
            Label modelHeaderLabel,
            Label countLabel,
            Label countHeaderLabel,
            CheckedListBox checkedListBox)
        {
            Queue<string> errorMessageQueue = new Queue<string>();
            Errors errors = new Errors();

            string[] models = get_model_names();

            // Check is model selected
            if (modelLabel.Text == string.Empty)
            {
                errorMessageQueue.Enqueue(Errors.StatusErrors["model_not_selected"]);
            }

            bool isModelSelected = false;
            string selectedModel = string.Empty;

            foreach (string model in models)
            {
                if (Path.GetFileName(model) == modelLabel.Text)
                {
                    isModelSelected = true;
                    selectedModel = Path.GetFileName(model);
                    break;
                }
            }

            if (!isModelSelected)
            {
                errorMessageQueue.Enqueue(Errors.StatusErrors["model_not_selected"]);
            } else
            {
                modelHeaderLabel.ForeColor = Color.Green;
                modelLabel.Text = selectedModel;
            }

            // Check is at least one image selected
            int checkedItemsCounter = checkedListBox.CheckedItems.Count;

            if (checkedItemsCounter == 0)
            {
                errorMessageQueue.Enqueue(Errors.StatusErrors["image_count_zero"]);
            } else
            {
                set_count_label(countLabel, countHeaderLabel, checkedItemsCounter);
            }

            return errorMessageQueue;
        }

        public void update_status(
            Label statusLabel,
            Label statusHeaderLabel,
            Label modelLabel,
            Label modelHeaderLabel,
            Label countLabel,
            Label countHeaderLabel,
            CheckedListBox checkedListBox)
        {
            Queue<string> ErrorQueue = check_status(
                statusLabel,
                statusHeaderLabel,
                modelLabel,
                modelHeaderLabel,
                countLabel,
                countHeaderLabel,
                checkedListBox);

            if (ErrorQueue.Count == 0)
            {
                statusHeaderLabel.ForeColor = Color.Green;
                statusLabel.Text = "Çalıştırılması bekleniyor";
            } else
            {
                statusHeaderLabel.ForeColor = Color.Red;
                statusLabel.Text = statusLabel.Text = string.Join(" | ", ErrorQueue);
            }
        }

        public List<Settings> get_settings(
            CheckBox checkboxShowLogs, 
            CheckBox checkboxSaveLogs, 
            CheckBox checkboxShowResults)
        { 
            List<Settings> settings = new List<Settings>();

            if (checkboxShowLogs.Checked)
            {
                settings.Add(Settings.ShowLogs);
            }

            if (checkboxSaveLogs.Checked)
            {
                settings.Add(Settings.SaveLogs);
            }

            if (checkboxShowResults.Checked)
            {
                settings.Add(Settings.ShowResults);
            }

            return settings;
        }

        public List<string> get_image_paths(CheckedListBox checkedListBoxImages)
        {
            List<string> imagePaths = new List<string>();

            foreach (string path in checkedListBoxImages.CheckedItems)
            {
                imagePaths.Add(path);
            }

            return imagePaths;
        }

        public async Task start_detect(
            List<Settings> settings,
            CheckBox checkboxShowLogs, 
            CheckBox checkboxSaveLogs,
            CheckBox checkboxShowResults,
            Label modelLabel,
            Label statusLabel,
            TrackBar trackbarConfidence,
            CheckedListBox checkedListBoxImages,
            Log logForm)
        {

            string pythonExePath = Path.Combine(Directory.GetParent(Application.StartupPath).Parent.Parent.FullName, "env/Scripts/python.exe");

            string scriptPath = Path.Combine(Directory.GetParent(Application.StartupPath).Parent.FullName, "pulp_stone_ai_test.py");

            double confidence = trackbarConfidence.Value / 100.0;

            var arguments = new
            {
                confidence = confidence,
                images = get_image_paths(checkedListBoxImages),
                model = modelLabel.Text,
                settings = settings
            };

            var jsonArguments = JsonSerializer.Serialize(arguments);

            var tempJsonPath = Path.GetTempFileName();

            File.WriteAllText(tempJsonPath, jsonArguments);

            string args = $"{scriptPath} \"{tempJsonPath}\"";

            var psi = new ProcessStartInfo
            {
                FileName = pythonExePath,
                Arguments = args,
                RedirectStandardOutput = true,
                RedirectStandardError = true,
                UseShellExecute = false,
                CreateNoWindow = true
            };

            Process process = new Process();
            
            process.StartInfo = psi;

            process.OutputDataReceived += (sender, e) =>
            {
                if (!string.IsNullOrEmpty(e.Data))
                {
                    logForm.AppendLog(e.Data);
                }
            };

            process.ErrorDataReceived += (sender, e) =>
            {
                if (!string.IsNullOrEmpty(e.Data))
                {
                    logForm.AppendLog(e.Data);
                }
            };

            statusLabel.Text = "Nesne tanıma işlemi başladı lütfen bekleyiniz...";

            process.Start();

            process.BeginOutputReadLine();
            process.BeginErrorReadLine();

            await Task.Run(() =>
            {
                process.WaitForExit();
            });

            if (settings.Contains(Settings.SaveLogs))
            {
                string logFolderPath = Path.Combine(
                    Directory.GetParent(Application.StartupPath).Parent.FullName, 
                    "logs");
                string logFilePath = Path.Combine(
                    logFolderPath,
                    $"log {DateTime.Now:yyyy-MM-dd_HH-mm-ss}.txt");

                if (!Directory.Exists(logFolderPath))
                {
                    Directory.CreateDirectory(logFilePath);
                }

                logForm.SaveLogs(logFilePath);

                statusLabel.Text = $"Nesne tanıma işlemi tamamlandı. Log dosyası kaydedildi: {logFilePath}";
            } 
            else
            {
                statusLabel.Text = "Nesne tanıma işlemi tamamlandı.";
            }

            uncheck_all_items(checkedListBoxImages);
        }
    }
}
