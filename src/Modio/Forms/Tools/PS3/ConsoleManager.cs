﻿using DevExpress.XtraEditors;
using Modio.Forms.Windows;
using PS3Lib;
using System;
using System.Resources;
using System.Windows.Forms;

namespace Modio.Forms.Tools.PS3
{
    public partial class ConsoleManager : XtraForm
    {
        public ConsoleManager()
        {
            InitializeComponent();
        }

        public ResourceManager Language = MainWindow.ResourceLanguage;

        private PS3API PS3 { get; } = new(SelectAPI.PS3Manager);

        private void ConsoleManager_Load(object sender, EventArgs e)
        {
            try
            {
                UpdateStatus(Language.GetString("CONNECTING_TO_CONSOLE"));

                PS3.PS3MAPI.ConnectTarget(MainWindow.ConsoleProfile.Address);

                if (PS3.PS3MAPI.IsConnected())
                {
                    UpdateStatus(Language.GetString("SUCCESS_CONNECTED"));
                    LoadDetails();
                }
                else
                {
                    UpdateStatus(Language.GetString("UNABLE_TO_CONNECT"));
                    XtraMessageBox.Show(this, Language.GetString("WEBMAN_REQUIRED"), Language.GetString("ERROR"), MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Close();
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(this, Language.GetString("WEBMAN_REQUIRED"), Language.GetString("ERROR"), MessageBoxButtons.OK, MessageBoxIcon.Error);
                Close();
            }
        }

        private void GameSaveResigner_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                if (PS3.PS3MAPI.IsConnected())
                {
                    PS3.PS3MAPI.DisconnectTarget();
                }
            }
            catch { }
        }

        private void ButtonRefreshDetails_Click(object sender, EventArgs e)
        {
            LoadDetails();
        }

        private void LoadDetails()
        {
            try
            {
                PS3.PS3MAPI.GetTemperatureCelcius(out uint tempCell, out uint tempRsx);

                LabelTempCELL.Text = Convert.ToString(tempCell) + " °C";
                LabelTempRSX.Text = Convert.ToString(tempRsx) + " °C";

                LabelFirmwareVersion.Text = PS3.PS3MAPI.GetFirmwareVersion();
                LabelFirmwareType.Text = PS3.PS3MAPI.GetFirmwareType();
                LabelCoreVersion.Text = PS3.PS3MAPI.GetCoreVersion();

                UpdateStatus("Successfully loaded console details.");
            }
            catch (Exception ex)
            {
                UpdateStatus($"Unable to fetch console details.", ex);
                XtraMessageBox.Show(this, $"Unable to fetch console details.\n\nError Message: {ex.Message}", Language.GetString("ERROR"), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ButtonSetLEDs_Click(object sender, EventArgs e)
        {
            PS3.PS3MAPI.SetConsoleLed(PS3ManagerAPI.PS3MAPI.PS3_CMD.LedColor.Green, (PS3ManagerAPI.PS3MAPI.PS3_CMD.LedMode)RadioGroupLEDsGreen.SelectedIndex);
            PS3.PS3MAPI.SetConsoleLed(PS3ManagerAPI.PS3MAPI.PS3_CMD.LedColor.Red, (PS3ManagerAPI.PS3MAPI.PS3_CMD.LedMode)RadioGroupLEDsRed.SelectedIndex);
        }

        private void ButtonRingBuzzer_Click(object sender, EventArgs e)
        {
            PS3.PS3MAPI.RingBuzzer((PS3ManagerAPI.PS3MAPI.PS3_CMD.BuzzerMode)RadioGroupBuzzerMode.SelectedIndex);
        }

        private void ButtonSetIDPS_Click(object sender, EventArgs e)
        {
            PS3.PS3MAPI.SetConsoleID(TextBoxIDPS.Text);
        }

        private void ButtonSetPSID_Click(object sender, EventArgs e)
        {
            PS3.PS3MAPI.SetPSID(TextBoxPSID.Text);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="status"></param>
        /// <param name="ex"></param>
        public void UpdateStatus(string status, Exception ex = null)
        {
            if (InvokeRequired)
            {
                BeginInvoke((MethodInvoker)delegate
                {
                    LabelStatus.Caption = status;
                });
            }
            else
            {
                LabelStatus.Caption = status;
            }

            if (ex == null)
            {
                Program.Log.Info(status);
            }
            else
            {
                Program.Log.Error(ex, status);
            }
        }
    }
}