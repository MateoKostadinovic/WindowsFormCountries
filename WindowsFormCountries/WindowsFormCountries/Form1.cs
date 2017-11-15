using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Diagnostics;
using System.Net;
using System.IO;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;

namespace WindowsFormCountries
{
    public partial class Form1 : Form
    {
        public List<Country> lCountries = new List<Country>();
        public static string CallRestMethod(string url)
        {
            HttpWebRequest webrequest = (HttpWebRequest)WebRequest.Create(url);
            webrequest.Method = "GET";
            webrequest.ContentType = "application/x-www-form-urlencoded";
            //webrequest.Headers.Add("Username", "xyz");
            //webrequest.Headers.Add("Password", "abc");
            HttpWebResponse webresponse = (HttpWebResponse)webrequest.GetResponse();
            Encoding enc = System.Text.Encoding.GetEncoding("utf-8");
            StreamReader responseStream = new StreamReader(webresponse.GetResponseStream(),
            enc);
            string result = string.Empty;
            result = responseStream.ReadToEnd();
            webresponse.Close();
            return result;
        }
        public List<Country> GetCountries()
        {
            List<Country> lRESTCountries = new List<Country>();
            string sUrl = System.Configuration.ConfigurationManager.AppSettings["RestApiUrl"];
            string sJson = CallRestMethod(sUrl);
            JArray aJson = JArray.Parse(sJson);
            foreach (JObject item in aJson)
            {
                string Code = (string)item.GetValue("alpha2Code");
                string Name = (string)item.GetValue("name");
                string Capital = (string)item.GetValue("capital");
                int Population = (int)item.GetValue("population");
                float area = -1;
                if (item.GetValue("area").Type == JTokenType.Null)
                {
                    area = 0;
                }
                else
                {
                    area = (float)item.GetValue("area");
                }
                string Region = (string)item.GetValue("region");
                lRESTCountries.Add(new Country
                {
                    sCode = Code,
                    sName = Name,
                    sCapital = Capital,
                    nPopulation = Population,
                    fArea = area,
                    sRegion = Region
                });                 
            }
            return lRESTCountries;
        }
        public Form1()
        {
            InitializeComponent();

            /*DATA GRID*/
            lCountries = GetCountries();
            dataGridViewCountries.DataSource = lCountries;

            /*COMBO BOX- FILTRIRANJE*/
            List<String> lRegions = lCountries.Where(o => o.sRegion != "").Select(o => o.sRegion).Distinct().ToList();
            lRegions.Insert(0, "Svi kontinenti");
            comboBoxRegion.DataSource = lRegions;

            /*COMBO BOX- SORTIRANJE*/
            List<string> lSortCriterias = new List<string>()
            {
                "‐",
                "Glavni grad",
                "Naziv",
                "Broj stanovnika",
                "Povrsina"
            };
            comboBoxSort.DataSource = lSortCriterias;

            /*COMBO BOX- DODAVANJE DRZAVE*/
            List<String> lRegions2 = lCountries.Where(o => o.sRegion != "").Select(o => o.sRegion).Distinct().ToList();
            lRegions2.Insert(0, "Svi kontinenti");
            comboBoxAdd.DataSource = lRegions2;
        }

        private void comboBoxRegion_SelectedIndexChanged(object sender, EventArgs e)
        {
            string sRegion = (string)comboBoxRegion.SelectedItem; // odabrana vrijednost
            lCountries = GetCountries();
            if (sRegion != "Svi kontinenti")
            {
                lCountries = lCountries.Where(o => o.sRegion == sRegion).ToList();
                dataGridViewCountries.DataSource = lCountries;
            }
            else
            {
                dataGridViewCountries.DataSource = lCountries;
            }
        }

        private void comboBoxSort_SelectedIndexChanged(object sender, EventArgs e)
        {
            string sKriterij = (string)comboBoxSort.SelectedItem;
            switch(sKriterij)
            {               
                case "Glavni grad":
                    dataGridViewCountries.DataSource = lCountries.OrderBy(o => o.sCapital).ToList();
                    break;
                case "Naziv":
                    dataGridViewCountries.DataSource = lCountries.OrderBy(o => o.sName).ToList();
                    break;
                case "Broj stanovnika":
                    dataGridViewCountries.DataSource = lCountries.OrderByDescending(o => o.nPopulation).ToList();
                    break;
                case "Povrsina":
                    dataGridViewCountries.DataSource = lCountries.OrderByDescending(o => o.fArea).ToList();
                    break;
            }
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            string sPretrazi = (string)textBoxSearch.Text;
            dataGridViewCountries.DataSource = lCountries.Where(o => o.sName.Contains(sPretrazi)).ToList();
        }

        private void buttonSpremi_Click(object sender, EventArgs e)
        {      
            string sKod = textBoxKod.Text;
            string sNaziv = textBoxNaziv.Text;
            string sGlavniGrad = textBoxGlavniGrad.Text;
            int nBrojStanovnika = Convert.ToInt32(textBoxBrojStan.Text);
            float fPovrsina = Convert.ToSingle(textBoxPovrsina.Text);
            string sKontinent = comboBoxAdd.Text;

            lCountries.Add(new Country
            {
                sCode = sKod,
                sName = sNaziv,
                sCapital = sGlavniGrad,
                nPopulation = nBrojStanovnika,
                fArea = fPovrsina,
                sRegion = sKontinent
            });

            dataGridViewCountries.DataSource = lCountries;
        }
    }
}
