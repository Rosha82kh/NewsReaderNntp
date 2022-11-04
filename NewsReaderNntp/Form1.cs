using System;
using System.Linq;
using System.Threading;
using mcnntp.common;
using mcnntp.common.client;


namespace NewsReaderNntp
{
    public partial class Form1 : Form

    {
        private static object args;

        private StreamReader StreamReader;
        string ipAdress = "172.20.10.2";
        string newsServer = "news.dotsrc.org";
        int Port = 119;
        string username = "rosha82kh@gmail.com";
        string pass = "92a060";
        string host = "127.0.0.1.";


        CancellationTokenSource cts = new CancellationTokenSource();
        NntpClient mcnntp = new NntpClient();


        public Form1()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            startConnection();
        }

        public void startConnection()
        {
            {

                try
                {

                    MessageBox.Show("Connecting to ..." + host);
                     mcnntp.ConnectAsync(newsServer);
                    
                    MessageBox.Show("Connected to "+ host);
                    MessageBox.Show("Retrieving server capabilities");
                    var caps= mcnntp.GetCapabilitiesAsync(cts.Token).Result;
                    foreach (var cap in caps)
                        MessageBox.Show(cap);
                    var sasl = mcnntp.AuthenticateSaslPlainAsync(username, pass, cts.Token).Result;

                    var date = mcnntp.DateAsync(cts.Token).Result;

                    MessageBox.Show($"Server date: {date.DateTime}");
                    var newsgroups = mcnntp.GetNewsgroupsListAsync(cts.Token).Result;
                    txtArticlesNumber.Text = ($"\r\nGroups count={newsgroups.Count}");
                    foreach (var ng in newsgroups)
                        comboBoxNewsgroupsNames.Items.Add(ng);

                    //MessageBox.Show($"\r\nRetrieving news...");
                    //foreach (var ng in newsgroups)
                    //{
                    //    MessageBox.Show($"\tGroup summary for {ng}");
                    //    var group = mcnntp.GetGroupAsync(ng, cts.Token).Result;
                    //    MessageBox.Show($"\t\tEstimated article count: {group.EstimatedArticleCount}");
                    //    MessageBox.Show($"\t\tLow watermark: {group.LowWatermark}");
                    //    MessageBox.Show($"\t\tHigh watermark: {group.HighWatermark}");


                    //    if (group.HighWatermark == group.LowWatermark - 1)
                    //    {
                    //        MessageBox.Show("\t\t--- EMPTY GROUP WITH NO ARTICLES ---");
                    //    }
                    //    else
                    //    {
                    //        var groupList = mcnntp.GetGroupListAsync(ng, null, null, cts.Token).Result;
                    //        comboBoxArticlesHeaderes.Items.Add($"\t\tLISTGROUP also called low {groupList.LowWatermark}~={group.LowWatermark}");

                    //        MessageBox.Show($"\tNews for {ng}");
                    //        var overResponse = mcnntp.OverAsync(group.LowWatermark, group.HighWatermark, cts.Token).Result;
                    //        MessageBox.Show($"\t\tArticle count={overResponse.Count}");
                    //        foreach (var over in overResponse.Take(2))
                    //        {
                    //            comboBoxArticlesHeaderes.Items.Add($"\t\t#{over.ArticleNumber}: {over.Subject}");
                    //            var articleByNumber = mcnntp.ArticleAsync(over.ArticleNumber, cts.Token).Result;
                    //            txtArticlesNumber.Text = ($"\t\t\t({articleByNumber.Code}) ARTICLE:\r\n{articleByNumber.Lines.Take(50).Aggregate((c, n) => c + "\r\n\t\t\t" + n)}");

                    //            var headers = articleByNumber.GetHeaders();

                    //            var messageId = articleByNumber.GetHeaderValues("Message-ID").FirstOrDefault();

                    //            var articleByMessageId = mcnntp.ArticleAsync(messageId, cts.Token).Result;
                    //            MessageBox.Show($"\t\t\t\t({articleByMessageId.Code}) ARTICLE: {articleByNumber.Lines.Take(5).Aggregate((c, n) => c + "\r\n\t\t\t" + n)}");

                    //            var articleCurrent = mcnntp.ArticleAsync(cts.Token).Result;
                    //            var messageIdCurrent = articleCurrent.GetHeaderValues("Message-ID").FirstOrDefault();

                    //            var stat = mcnntp.StatAsync(over.ArticleNumber, cts.Token).Result;
                    //            MessageBox.Show($"\t\t\t\tArticle-Num={messageId} ~= Article-Current={messageIdCurrent} ~= Stat={stat.MessageId}");
                    //        }
                    //        // Test some other commands for groups
                    //        var next = mcnntp.LastAsync(cts.Token).Result;
                    //        MessageBox.Show($"\t\tNEXT ({next.Code}) article={next.ArticleNumber}, messageId={next.MessageId}");

                    //        var last = mcnntp.LastAsync(cts.Token).Result;
                    //        MessageBox.Show($"\t\tLAST ({last.Code}) article={last.ArticleNumber}, messageId={last.MessageId}");
                    //    }
                    //    // Test some other commands globally
                    //    {
                    //        var newGroups = mcnntp.NewGroupsAsync(DateTime.Now.AddYears(-30), cts.Token).Result;
                    //        MessageBox.Show($"\r\nChecking for new groups in the past 30 years...");
                    //        foreach (var ng in newGroups.Groups.Take(20))
                    //            Console.WriteLine($"\t{ng.Group} {ng.LowWatermark}-{ng.HighWatermark} {ng.Status}");

                    //        var newNews = mcnntp.NewNewsAsync("*", DateTime.Now.AddYears(-30), cts.Token).Result;
                    //        MessageBox.Show($"\r\nChecking for new messages in the past 30 years...");
                    //        foreach (var msg in newNews.MessageIds.Take(20))
                    //            Console.WriteLine($"\t{msg}");

                    //        var activeGroups = mcnntp.ListActiveAsync(cts.Token).Result;
                    //        Console.WriteLine($"\r\nLIST ACTIVE Groups count={activeGroups.Groups.Count}");

                    //        var activeTimesGroups = mcnntp.ListActiveTimesAsync(cts.Token).Result;
                    //        Console.WriteLine($"\r\nLIST ACTIVE.TIMES Groups count={activeGroups.Groups.Count}");

                    //        var newsgroupsList = mcnntp.ListNewsgroupsAsync(cts.Token).Result;
                    //        Console.WriteLine($"\r\nLIST NEWSGROUPS Groups count={newsgroupsList.Groups.Count}");
                    //    }

                    //mcnntp.AuthenticateAsync(username, pass, default);
                    //mcnntp.AuthenticateSaslPlainAsync(username, pass, default);
                    //MessageBox.Show("The server is running at port " + Port);
                    // MessageBox.Show("Waiting for a connection.....");
                    //MessageBox.Show("Connection accepted   ");
                    //mcnntp.ConnectAsync(newsServer, true);
                     //var s = mcnntp.GetGroupListAsync(newsServer, 1, 3);
                    //txtArticle.Text = s.ToString();

                    //comboBoxNewsgroupsNames.Items.Add(s).ToString();
                    //string selectedGroup = comboBoxNewsgroupsNames.SelectedItem.ToString();
                    //comboBoxArticlesHeaderes.Items.Add(mcnntp.ArticleAsync(selectedGroup, default));
                    //string selectedArticle = comboBoxArticlesHeaderes.SelectedItem.ToString();
                    ////txtArticle.Text = mcnntp.BodyAsync(selectedArticle);





                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);

                }
            }


        }





        //private void btnOk_Click(object sender, EventArgs e)
        //{
        //    //Retrieve newsgroup entries
        //    btnStart.Enabled = false;
        //    try
        //    {
        //        NntpClient nntp = new NntpClient();
        //        nntp.ConnectAsync(newsServer);
        //       // NewsgroupsListResponse group = nntp.GetNewsgroupsListAsync();
        //        //Display the listView1 of entries received
        //        for (int i = 0; i < 10; i++)
        //        {
        //            try
        //            {
        //                comboBoxNewsgroupsNames.Items.Add(new ListViewItem(group.RetrieveHeaderObject().Subject));
        //                //group.Next();
        //            }
        //            catch
        //            {
        //            }
        //        }
        //        nntp.DisconnectAsync();
        //    }
        //    finally
        //    {
        //        btnStart.Enabled = true;
        //    }
        //}
        public void groupCommand()
        {
            comboBoxNewsgroupsNames.Items.Add(mcnntp.GetGroupAsync(newsServer).Result);
        }
        public void StopConnection()
        {
            try {
                var quitResponse = mcnntp.DisconnectAsync().Result;
                if (quitResponse == null)
                    MessageBox.Show($"Connection is already closed");
                else
                    MessageBox.Show($"Closed connection: {quitResponse}");
                 

             }catch (Exception ex) {
                MessageBox.Show(ex.Message + ex.StackTrace);

            }
        }

        public void btnStop_Click(object sender, EventArgs e)
        {
            StopConnection();
        }

        private void comboBoxNewsgroupsNames_SelectedIndexChanged(object sender, EventArgs e)
        {
           comboBoxNewsgroupsNames.Items.Add( mcnntp.GetNewsgroupsListAsync(default));
           string array= mcnntp.CurrentNewsgroup.ToLower().Trim();


         }

        private void btnNewsOk_Click(object sender, EventArgs e)
        {
            string selectedGroup = comboBoxNewsgroupsNames.SelectedItem.ToString();

            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = selectedGroup;
            openFileDialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            //string file = openFileDialog.FileName;
            openFileDialog.ShowDialog();
           // comboBoxNewsgroupsNames.SelectedItem.ToString();

        }

        private void btnOkArticle_Click(object sender, EventArgs e)
        {
            string selectedArticle = comboBoxArticlesHeaderes.SelectedItem.ToString();
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = comboBoxArticlesHeaderes.SelectedText;
            openFileDialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            string file = openFileDialog.FileName;
            openFileDialog.ShowDialog();
          //  comboBoxArticlesHeaderes.SelectedItem.ToString();   
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SaveFileDialog dlg = new SaveFileDialog();
            dlg.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            dlg.FileName = txtArticle.Text + ".txt";
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                string strPath = dlg.FileName;
                if (Path.GetExtension(dlg.FileName).ToLower() != ".txt")
                {
                    strPath += ".txt";
                }
                StreamWriter streamWriter = new StreamWriter(strPath);
                streamWriter.WriteLine(txtArticle.Text);
                streamWriter.Close();


            }
        }

        private void btnAddNews_Click(object sender, EventArgs e)
        {

        }
        public class favourites
        {
            public string myText { get; set; }
        }
        private void btnAddArticle_Click(object sender, EventArgs e)
        { 
    }

        private void txtArticlesNumber_TextChanged(object sender, EventArgs e)
        {
          // txtArticlesNumber.Text= NntpClient.GetGroupListAsync(newsServer,articleNumberRangeStart,articleNumberRangeEnd,default);
        }
        public void Post()
        {
           var post= txtArticle.Text.ToCharArray();
            StreamWriter streamWriter= new StreamWriter(txtArticle.Text);
            streamWriter.AutoFlush = true;
            streamWriter.Write(post);
            mcnntp.PostAsync(newsServer, "sport", "Iman", post.ToString(), default);
            streamWriter.Close();
        }

        private void btnPost_Click(object sender, EventArgs e)
        {
            Post();
        }
    }
        
    
}