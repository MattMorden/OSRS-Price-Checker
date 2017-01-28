using HtmlAgilityPack;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace RunescapePriceChecker
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        // Lists to hold all the ID's of the items that we will be searching, and the items as responses.
        List<string> idList = new List<string>();
        List<Item> itemList = new List<Item>();

        private void searchButton_Click(object sender, RoutedEventArgs e)
        {
            label1.Content = generateOutput(idList);// Fill the label content with results of calling generateOutput
        }

        private void addButton_Click(object sender, RoutedEventArgs e)
        {
            string mid = textBox.Text.ToString();
            idList.Add(mid);
            listBox1.Items.Add(mid);
            textBox.Clear();// Clear the textbox so that user can add a new id
        }

        private string generateOutput(List<string> list)
        {
            string output = "";
            // Loop through each item in the list
            foreach(var item in list)
            { 
            string url = "https://api.rsbuddy.com/grandExchange?a=guidePrice&i=" + item;// Assign id to the end of url
            var json = new WebClient().DownloadString(url);// Download the JSON string from web page
            var results =  Newtonsoft.Json.JsonConvert.DeserializeObject<Item>(json);// Convert the json string into an Item object
  
            output += "\nItem: " + item + "      Buy: " + results.buying + "      Sell: " + results.selling;
            }
            return output;
        }





    }
}
