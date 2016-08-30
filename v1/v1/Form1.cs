using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using VersionOne.SDK.APIClient;

namespace v1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
       public List<Defect> Defects = new List<Defect>();

        private void connect_Click(object sender, EventArgs e)
        {
            var webRequest = (HttpWebRequest)WebRequest.Create("https://www8.v1host.com/AppAssureSoftwareInc/query.v1");
            webRequest.Method = "POST";
            webRequest.ContentType = "application/json";
            webRequest.UserAgent = "Mozilla/5.0 (Windows NT 5.1; rv:28.0) Gecko/20100101 Firefox/28.0";
            //webRequest.ContentLength = 0; // added per comment
            string autorization = LoginBox.Text + ":" + Paswbox.Text;
            byte[] binaryAuthorization = System.Text.Encoding.UTF8.GetBytes(autorization);
            autorization = Convert.ToBase64String(binaryAuthorization);
            autorization = "Basic " + autorization;
            webRequest.Headers.Add("AUTHORIZATION", autorization);
            using (var streamWriter = new StreamWriter(webRequest.GetRequestStream()))
            {

                streamWriter.Write(ST_JSON);
                streamWriter.Flush();
                streamWriter.Close();
            }

            var webResponse = (HttpWebResponse)webRequest.GetResponse();
            if (webResponse.StatusCode != HttpStatusCode.OK) ResultField.Text += "OK";
            using (StreamReader reader = new StreamReader(webResponse.GetResponseStream()))
            {
                string alldata = reader.ReadToEnd();
                reader.Close();
                alldata = alldata.TrimStart('[');
                alldata = alldata.TrimEnd(']');
                Defects = DeserializedefDefects(alldata);
                MessageBox.Show(Defects.Count.ToString());
                foreach (var defect in Defects)
                {
                    ResultField.Text += defect.ChangeDate.ToLongDateString();
                    ResultField.Text += Environment.NewLine;
                }
            }



        }


        public List<Defect> DeserializedefDefects(string json)
        {
            return JsonConvert.DeserializeObject<List<Defect>>(json.ToString());
        }
        


        private String ST_JSON = @"
{
  from: Defect,
  select: [
    Name,
        {
    from:    Status,
    select: [
        Name
      ]
    },
    {
    from:    Priority,
    select: [
        Name
      ]
    },
    {
    from: Custom_FoundInBranches,
        select: [
        Name
      ]
    },
     {
    from: Custom_FixedInBranches,
            select: [
        Name
      ]
    },
    ChangeDate,
    ClosedDate,
    CreateDate,
      {
    from: VerifiedBy,
     select: [
        Name
      ]
    },
    {
    from: Custom_Tag2,
     select: [
        Name
      ]
    },
    {
      from: Owners,
      select: [
        Name
      ]
    }
  ],
  find: '[ST]',
  findin: [
  Name
  ]
  }
";








    }
}
