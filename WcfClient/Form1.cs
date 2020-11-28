using System;
using System.Net.Http;
using System.Windows.Forms;

namespace WcfClient
{
    public partial class mainForm : Form
    {
        static HttpClient client = new HttpClient();

        public mainForm()
        {
            InitializeComponent();

            client.BaseAddress = new Uri("http://localhost:8080");
            client.DefaultRequestHeaders.Accept.Clear();
        }


        private void getFilePieceButton_Click(object sender, EventArgs e)
        {
            if ((fileNameTextBox.TextLength > 0) && (offsetTextBox.TextLength > 0) && (sizeTextBox.TextLength > 0))
            {
                string res = "/files/" + fileNameTextBox.Text + "?offset=" + offsetTextBox.Text + "&size=" + sizeTextBox.Text;
                HttpResponseMessage response = client.GetAsync(res).Result;
                resultTextBox.Text = response.Content.ReadAsStringAsync().Result;
            }
        }

        private void sendTextButton_Click(object sender, EventArgs e)
        {
            if ((textTextBox.TextLength > 0) && (fileNameTextBox.TextLength > 0))
            {
                HttpResponseMessage response = client.PostAsync(String.Format("/files/?name={0}&text={1}",
                    fileNameTextBox.Text, textTextBox.Text), new StringContent("")).Result;
                resultTextBox.Text = response.Content.ReadAsStringAsync().Result;
            }
        }

        private void getHashCodeButton_Click(object sender, EventArgs e)
        {
            if (textTextBox.TextLength > 0)
            {
                HttpResponseMessage response = client.GetAsync(String.Format("/hash/?text={0}",
                    textTextBox.Text)).Result;
                resultTextBox.Text = response.Content.ReadAsStringAsync().Result;
            }
        }

        private void getBase64Button_Click(object sender, EventArgs e)
        {
            if (textTextBox.TextLength > 0)
            {

                HttpResponseMessage response = client.PostAsync("/base64", new StringContent(textTextBox.Text)).Result;
                resultTextBox.Text = response.Content.ReadAsStringAsync().Result;
            }
        }
    }
}
