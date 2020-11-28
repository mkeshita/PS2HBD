using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using System.IO;
using System.Net;
using MetroFramework;
using MetroFramework.Forms;
using System.Media;
using FileDownloader;
using System.Diagnostics;

namespace PS2HBD.Forms
{
    public partial class uxMain : MetroForm
    {
        private List<DataGridViewCell> uxContainingCells = new List<DataGridViewCell>();
        private int uxCurrentContainingCellListIndex = 0;

        public static string URL_ENVIRONMENT = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + @"\zimba\ps2hbd.dat";
        public static string URL_APPS = "https://raw.githubusercontent.com/tryller/PS2HBD/main/Homebrews/base.txt";
        private string uxPath = URL_ENVIRONMENT;

        private DataTable uxDataTable = null;
        private static WebClient _webClient = null;
        private IFileDownloader fileDownloader = null;
        private Stopwatch sw = null;

        private TextProgressBar uxProgressBar = null;
        public uxMain()
        {
            InitializeComponent();
        }

        private void uxMain_Load(object sender, EventArgs e)
        {
            uxDataTable = new DataTable();
            uxDataTable.Columns.Add("NOME");
            uxDataTable.Columns.Add("URL");

            uxDatagridList.DataSource = uxDataTable.DefaultView;
            //CheckVersion();
            try
            {
                ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls | SecurityProtocolType.Tls11 | SecurityProtocolType.Tls12;


                fileDownloader = new FileDownloader.FileDownloader();

                _webClient = new WebClient();
                _webClient.DownloadFile(new Uri(URL_APPS), URL_ENVIRONMENT);

                _webClient.Dispose();
                var uxConteudo = File.ReadAllLines(uxPath);
                DataRow row = null;

                if (uxDataTable.Rows.Count > 0)
                    uxDataTable.Rows.Clear();

                var uxSplitConteudo = (from f in uxConteudo select f.Split('|')).ToArray();

                foreach (var l in uxSplitConteudo)
                {
                    row = uxDataTable.NewRow();
                    row["NOME"] = l[0];
                    row["URL"] = l[1];
                    uxDataTable.Rows.Add(row);
                }

                uxTextBoxSearch.Text = string.Empty;
            }
            catch
            {
                MetroMessageBox.Show(this, "Falaha ao carregar a lista de APPS.\nAbra o programa novamente!", "Aviso!");
                Environment.Exit(0);
            }

            try
            {
                if (File.Exists(URL_ENVIRONMENT))
                    File.Delete(URL_ENVIRONMENT);
            }
            catch { }

            uxDatagridList.Columns["NOME"].Width = uxPanel.Width;
            uxDatagridList.Columns["NOME"].SortMode = DataGridViewColumnSortMode.NotSortable;
            uxDatagridList.Columns["URL"].Width = 0;
            uxDatagridList.Columns["URL"].SortMode = DataGridViewColumnSortMode.NotSortable;
        }

        private void uxTextBoxSearch_TextChanged(object sender, EventArgs e)
        {
            uxContainingCells.Clear();
            uxCurrentContainingCellListIndex = 0;
            foreach (DataGridViewRow row in uxDatagridList.Rows)
            {
                if (row.Cells["NOME"].Value == DBNull.Value || row.Cells["NOME"].Value == null)
                    continue;

                if (row.Cells["NOME"].Value.ToString().ToLower().Trim().Contains(uxTextBoxSearch.Text.ToLower().Trim()))
                    uxContainingCells.Add(row.Cells["NOME"]);
            }

            if (uxContainingCells.Count > 0)
                uxDatagridList.CurrentCell = uxContainingCells[uxCurrentContainingCellListIndex++];
        }

        public static byte[] GetFileViaHttp(string url)
        {
            using (WebClient client = new WebClient())
            {
                return client.DownloadData(url);
            }
        }

        private void uxDatagridList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string path = Application.StartupPath + "\\Downloads";
            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
                Thread.Sleep(1500);
            }

            string baseUrl = uxDatagridList.Rows[uxDatagridList.CurrentCell.RowIndex].Cells["URL"].Value.ToString();
            string nome = uxDatagridList.Rows[uxDatagridList.CurrentCell.RowIndex].Cells["NOME"].Value.ToString();

            if (MetroMessageBox.Show(this, "Deseja baixar " + nome + "?", "Aviso!", MessageBoxButtons.YesNo, MessageBoxIcon.Information, 115) == DialogResult.Yes)
            {
                ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls | SecurityProtocolType.Tls11 | SecurityProtocolType.Tls12;

                uxProgressBar = new TextProgressBar();
                uxProgressBar.Name = "uxProgressBar";
                uxProgressBar.Dock = DockStyle.Bottom;
                uxProgressBar.ForeColor = Color.Black;
                uxPanel.Controls.Add(uxProgressBar);

                fileDownloader = new FileDownloader.FileDownloader();
                fileDownloader.DownloadFileCompleted += DownloadFileCompleted;
                fileDownloader.DownloadProgressChanged += DownloadFileProgressChanged;
                fileDownloader.DownloadFileAsync(new Uri(baseUrl), path + "\\" + nome + ".zip");

                sw = new Stopwatch();
                sw.Start();
            }
        }

        void DownloadFileCompleted(object sender, DownloadFileCompletedArgs eventArgs)
        {

            try {
                if (eventArgs.State == CompletedState.Succeeded)
                {
                    uxProgressBar.Value = 0;
                    uxProgressBar.Update();
                    uxPanel.Enabled = true;
                    uxPanel.Controls.Remove(uxProgressBar);
                    _webClient.Dispose();
                    uxProgressBar.Text = string.Empty;
                    SystemSounds.Beep.Play();
                    sw.Reset();
                }
                else if (eventArgs.State == CompletedState.Failed)
                {
                    uxProgressBar.Value = 0;
                    uxProgressBar.Update();
                    uxPanel.Enabled = true;
                    uxPanel.Controls.Remove(uxProgressBar);
                    _webClient.Dispose();
                    uxProgressBar.Text = string.Empty;
                    sw.Reset();
                }
            }
            catch
            {

            }
        }

        private void DownloadFileProgressChanged(object sender, DownloadFileProgressChangedArgs e)
        {
            try
            {
                int percent = e.ProgressPercentage;
                uxProgressBar.Value = percent;
                uxProgressBar.BackColor = Color.Gold;
                uxProgressBar.Text = "Baixados:" + percent.ToString() + "%" + " de " + Converter.SizeSuffix(e.TotalBytesToReceive).ToString() +
                    string.Format(" {0} kb/s", (e.BytesReceived / 1024d / sw.Elapsed.TotalSeconds).ToString("0.00")); ;

                uxProgressBar.Update();
                uxPanel.Enabled = false;
            } catch { }
        }
    }
}