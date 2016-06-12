using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Net;
using System.Collections.Specialized;
using System.Xml;
using Newtonsoft.Json;

namespace SteamWorkshopDownloader
{
    public partial class Form1 : Form
    {
        static RootObject root;

        public Form1()
        {
            InitializeComponent();
        }


        private void submitButton_Click(object sender, EventArgs e)
        {
            using (var client = new WebClient())
            {
                var values = new NameValueCollection();
                values["itemcount"] = "1";
                values["publishedfileids[0]"] = idBox.Text;

                var response = client.UploadValues("http://api.steampowered.com/ISteamRemoteStorage/GetPublishedFileDetails/v0001/", values);
                var responseString = Encoding.Default.GetString(response);
                root = JsonConvert.DeserializeObject<RootObject>(responseString);
                updateFields(root);
            }

            // TODO: Disable button until it finishes
        }

        private void updateFields (RootObject root)
        {
            try
            {
                titleBox.Text = root.response.publishedfiledetails[0].title;
                //creatorBox.Text = root.response.publishedfiledetails[0].creator;
                filesizeBox.Text = root.response.publishedfiledetails[0].file_size.ToString() + " kb";
                fileurlBox.Text = root.response.publishedfiledetails[0].file_url;
                createdBox.Text = root.response.publishedfiledetails[0].time_created.ToString();
                updatedBox.Text = root.response.publishedfiledetails[0].time_updated.ToString();
            }
            catch (Exception)
            { }

            try
            {
                filenameBox.Text = root.response.publishedfiledetails[0].filename.Substring(5);
            }
            catch (NullReferenceException)
            {
                filenameBox.Text = root.response.publishedfiledetails[0].filename;
            }

            try
            {
                pictureBox1.LoadAsync(root.response.publishedfiledetails[0].preview_url);
            }
            catch (InvalidOperationException)
            { }
        }

        private void downloadButton_Click(object sender, EventArgs e)
        {
            downloadButton.Enabled = false;

            saveFileDialog1.FileName = filenameBox.Text;
            saveFileDialog1.ShowDialog();
            WebClient myWebClient = new WebClient();

            myWebClient.DownloadFileCompleted += new AsyncCompletedEventHandler(DownloadFileCompleteCallback);
            // Specify a progress notification handler.
            myWebClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(DownloadProgressCallback);
            Uri url = new Uri(root.response.publishedfiledetails[0].file_url);

            myWebClient.DownloadFileAsync(url, saveFileDialog1.FileName );
        }

        private void DownloadFileCompleteCallback(object sender, AsyncCompletedEventArgs e)
        {
            downloadButton.Enabled = true;
        }

        private void DownloadProgressCallback(object sender, DownloadProgressChangedEventArgs e)
        {
            //TODO
            double bytesIn = double.Parse(e.BytesReceived.ToString());
            double totalBytes = double.Parse(e.TotalBytesToReceive.ToString());
            double percentage = bytesIn / totalBytes * 100;

            progressBar1.Value = int.Parse(Math.Truncate(percentage).ToString());
        }

        private void idBox_Validating(object sender, CancelEventArgs e)
        {
            string errorMsg;
            submitButton.Enabled = false;
            if (!ValidID(idBox.Text, out errorMsg))
            {
                // Cancel the event and select the text to be corrected by the user.
                e.Cancel = true;
                idBox.SelectAll();

                // Set the ErrorProvider error with the text to display. 
                this.errorProvider1.SetError(idBox, errorMsg);
            }
        }

        private void idBox_Validated(object sender, EventArgs e)
        {
            // If all conditions have been met, clear the ErrorProvider of errors.
            errorProvider1.SetError(idBox, "");
            submitButton.Enabled = true;
        }

        public bool ValidID(string id, out string errorMessage)
        {
            if (id.Length == 0)
            {
                errorMessage = "An ID is required";
                return false;
            }

            if (!id.All(Char.IsDigit))
            {
                errorMessage = "Only digits are allowed";
                return false;
            }

            errorMessage = "";
            return true;
        }

        private void idBox_TextChanged(object sender, EventArgs e)
        {
            Validate();
        }

        private void titleBox_TextChanged(object sender, EventArgs e)
        {
            if (titleBox.Text != "")
                downloadButton.Enabled = true;
            //TODO: Add checks to enable
        }
    }
}
