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
using Google.Apis.Auth.OAuth2;
using Google.Apis.Sheets.v4;
using Google.Apis.Sheets.v4.Data;
using Google.Apis.Services;
using Google.Apis.Util.Store;
using System.Threading;

namespace VTPSInventory
{
    public partial class Form1 : Form
    {
        static readonly string[] Scopes = { SheetsService.Scope.Spreadsheets };
        static readonly string ApplicationName = "InventoryLocations";
        static readonly string SpreadsheetId = "14LTmOA1xTyFOZ0eHHOENEZzabqh5bnTXVgC6Zs_QZj4";
        static readonly string sheet = "InventoryLocations";
        static SheetsService service;
          
        public Form1()
        {
            InitializeComponent();
            GoogleCredential credential;
            using (var stream = new FileStream("client_secret.json", FileMode.Open, FileAccess.Read))
            {
                credential = GoogleCredential.FromStream(stream)
                    .CreateScoped(Scopes);
            }

            // Create Google Sheets API service.
            service = new SheetsService(new BaseClientService.Initializer()
            {
                HttpClientInitializer = credential,
                ApplicationName = ApplicationName,
            });
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        void ReadEntries()
        {
            var range = $"{sheet}!A:B";
            SpreadsheetsResource.ValuesResource.GetRequest request =
                    service.Spreadsheets.Values.Get(SpreadsheetId, range);

            var response = request.Execute();
            IList<IList<object>> values = response.Values;
            if (values != null && values.Count > 0)
            {
                foreach (var row in values)
                {
                    if (row[0].ToString().Contains(itemTextbox.Text))
                    {
                        itemNameLabel.Text = "Item Name: " + row[0];
                        itemLocationLabel.Text = "Item Location: " + row[1];
                    }
                }
            }
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            ReadEntries();
        }
    }
}