using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CefSharp;
using CefSharp.WinForms;
using AForge.Video;
using AForge.Video.DirectShow;

namespace IDesktop_SME
{
    public partial class frmPrincipal : Form
    {
        public ChromiumWebBrowser browser;

        FilterInfoCollection filterInfoCollection;
        VideoCaptureDevice videoCaptureDevice;

        

        public void IniciarNavegador()
        {
            Cef.Initialize(new CefSettings());
            browser = new ChromiumWebBrowser("https://sistemaprontos.com.br/auth/realms/motaengil/protocol/openid-connect/auth?client_id=portal-web&redirect_uri=https%3A%2F%2Fmotaengil-portal.sistemaprontos.com.br%2F%23%2Fdashboard&state=2ec193c0-b955-4d3e-8a4c-1dd11763242a&response_mode=fragment&response_type=code&scope=openid&nonce=da178c79-e53e-4791-9213-9f54c98817a7#");
            this.pnlBrowser.Controls.Add(browser);
            browser.Dock = DockStyle.Fill;
        }

        private void SelecionarCamera()
        {

            filterInfoCollection = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            foreach (FilterInfo Device in filterInfoCollection)
                cboCamera.Items.Add(Device.Name);
            cboCamera.SelectedIndex = 0;
            videoCaptureDevice = new VideoCaptureDevice();
        }

        private void IniciarCamera()
        {
            videoCaptureDevice = new VideoCaptureDevice(filterInfoCollection[cboCamera.SelectedIndex].MonikerString);
            videoCaptureDevice.NewFrame += FinalFrame_NewFrame;
            videoCaptureDevice.Start();
        }
        private void FinalFrame_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            picCamera.Image = (Bitmap)eventArgs.Frame.Clone();
        }

        public frmPrincipal()
        {
            InitializeComponent();
            
        }

        private void btClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            IniciarNavegador();
            SelecionarCamera();
            IniciarCamera();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            //blData.Text = DateTime.Now.ToShortDateString();
            lblHora.ForeColor = Color.White;
            lblHora.Text = DateTime.Now.ToLongTimeString() + " <> " + DateTime.Now.ToShortDateString();
        }

        private void frmPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (videoCaptureDevice.IsRunning == true)
                videoCaptureDevice.Stop();
        }

        private void btInfo_Click(object sender, EventArgs e)
        {
            frmAjuda ajuda = new frmAjuda();
            ajuda.ShowDialog();
        }

        private void btKeyboard_Click(object sender, EventArgs e)
        {
            //System.Diagnostics.Process.Start("osk.exe");
        }
    }
}
