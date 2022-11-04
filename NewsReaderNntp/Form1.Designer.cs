namespace NewsReaderNntp
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnStart = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.lblArticlesNumber = new System.Windows.Forms.Label();
            this.txtArticlesNumber = new System.Windows.Forms.TextBox();
            this.comboBoxNewsgroupsNames = new System.Windows.Forms.ComboBox();
            this.comboBoxArticlesHeaderes = new System.Windows.Forms.ComboBox();
            this.txtArticle = new System.Windows.Forms.TextBox();
            this.btnAddNews = new System.Windows.Forms.Button();
            this.btnNewsOk = new System.Windows.Forms.Button();
            this.btnOkArticle = new System.Windows.Forms.Button();
            this.btnAddArticle = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.listBoxFavorite = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnPost = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnStart
            // 
            this.btnStart.BackColor = System.Drawing.Color.Ivory;
            this.btnStart.Font = new System.Drawing.Font("Showcard Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnStart.ForeColor = System.Drawing.Color.LightSalmon;
            this.btnStart.Location = new System.Drawing.Point(470, 36);
            this.btnStart.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(170, 35);
            this.btnStart.TabIndex = 0;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = false;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnStop
            // 
            this.btnStop.BackColor = System.Drawing.Color.Ivory;
            this.btnStop.Font = new System.Drawing.Font("Showcard Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnStop.ForeColor = System.Drawing.Color.LightSalmon;
            this.btnStop.Location = new System.Drawing.Point(678, 36);
            this.btnStop.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(170, 35);
            this.btnStop.TabIndex = 1;
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = false;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // lblArticlesNumber
            // 
            this.lblArticlesNumber.AutoSize = true;
            this.lblArticlesNumber.BackColor = System.Drawing.Color.SeaShell;
            this.lblArticlesNumber.Font = new System.Drawing.Font("Showcard Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblArticlesNumber.ForeColor = System.Drawing.Color.LightSalmon;
            this.lblArticlesNumber.Location = new System.Drawing.Point(58, 36);
            this.lblArticlesNumber.Name = "lblArticlesNumber";
            this.lblArticlesNumber.Size = new System.Drawing.Size(158, 21);
            this.lblArticlesNumber.TabIndex = 2;
            this.lblArticlesNumber.Text = "Articles Number";
            // 
            // txtArticlesNumber
            // 
            this.txtArticlesNumber.BackColor = System.Drawing.Color.SeaShell;
            this.txtArticlesNumber.Font = new System.Drawing.Font("Showcard Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtArticlesNumber.ForeColor = System.Drawing.Color.LightSalmon;
            this.txtArticlesNumber.Location = new System.Drawing.Point(219, 36);
            this.txtArticlesNumber.Name = "txtArticlesNumber";
            this.txtArticlesNumber.Size = new System.Drawing.Size(196, 29);
            this.txtArticlesNumber.TabIndex = 3;
            this.txtArticlesNumber.TextChanged += new System.EventHandler(this.txtArticlesNumber_TextChanged);
            // 
            // comboBoxNewsgroupsNames
            // 
            this.comboBoxNewsgroupsNames.BackColor = System.Drawing.Color.SeaShell;
            this.comboBoxNewsgroupsNames.Font = new System.Drawing.Font("Showcard Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.comboBoxNewsgroupsNames.ForeColor = System.Drawing.Color.LightSalmon;
            this.comboBoxNewsgroupsNames.FormattingEnabled = true;
            this.comboBoxNewsgroupsNames.Location = new System.Drawing.Point(58, 86);
            this.comboBoxNewsgroupsNames.Name = "comboBoxNewsgroupsNames";
            this.comboBoxNewsgroupsNames.Size = new System.Drawing.Size(357, 29);
            this.comboBoxNewsgroupsNames.TabIndex = 4;
            this.comboBoxNewsgroupsNames.SelectedIndexChanged += new System.EventHandler(this.comboBoxNewsgroupsNames_SelectedIndexChanged);
            // 
            // comboBoxArticlesHeaderes
            // 
            this.comboBoxArticlesHeaderes.BackColor = System.Drawing.Color.SeaShell;
            this.comboBoxArticlesHeaderes.Font = new System.Drawing.Font("Showcard Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.comboBoxArticlesHeaderes.ForeColor = System.Drawing.Color.LightSalmon;
            this.comboBoxArticlesHeaderes.FormattingEnabled = true;
            this.comboBoxArticlesHeaderes.Location = new System.Drawing.Point(58, 148);
            this.comboBoxArticlesHeaderes.Name = "comboBoxArticlesHeaderes";
            this.comboBoxArticlesHeaderes.Size = new System.Drawing.Size(357, 29);
            this.comboBoxArticlesHeaderes.TabIndex = 5;
            // 
            // txtArticle
            // 
            this.txtArticle.BackColor = System.Drawing.Color.SeaShell;
            this.txtArticle.Font = new System.Drawing.Font("Showcard Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtArticle.ForeColor = System.Drawing.Color.LightSalmon;
            this.txtArticle.Location = new System.Drawing.Point(58, 208);
            this.txtArticle.Multiline = true;
            this.txtArticle.Name = "txtArticle";
            this.txtArticle.Size = new System.Drawing.Size(357, 350);
            this.txtArticle.TabIndex = 6;
            // 
            // btnAddNews
            // 
            this.btnAddNews.BackColor = System.Drawing.Color.Ivory;
            this.btnAddNews.Font = new System.Drawing.Font("Showcard Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAddNews.ForeColor = System.Drawing.Color.LightSalmon;
            this.btnAddNews.Location = new System.Drawing.Point(678, 86);
            this.btnAddNews.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnAddNews.Name = "btnAddNews";
            this.btnAddNews.Size = new System.Drawing.Size(170, 35);
            this.btnAddNews.TabIndex = 8;
            this.btnAddNews.Tag = "";
            this.btnAddNews.Text = "Add to favorite";
            this.btnAddNews.UseVisualStyleBackColor = false;
            this.btnAddNews.Click += new System.EventHandler(this.btnAddNews_Click);
            // 
            // btnNewsOk
            // 
            this.btnNewsOk.BackColor = System.Drawing.Color.Ivory;
            this.btnNewsOk.Font = new System.Drawing.Font("Showcard Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnNewsOk.ForeColor = System.Drawing.Color.LightSalmon;
            this.btnNewsOk.Location = new System.Drawing.Point(470, 86);
            this.btnNewsOk.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnNewsOk.Name = "btnNewsOk";
            this.btnNewsOk.Size = new System.Drawing.Size(170, 35);
            this.btnNewsOk.TabIndex = 7;
            this.btnNewsOk.Text = "Select ";
            this.btnNewsOk.UseVisualStyleBackColor = false;
            this.btnNewsOk.Click += new System.EventHandler(this.btnNewsOk_Click);
            // 
            // btnOkArticle
            // 
            this.btnOkArticle.BackColor = System.Drawing.Color.Ivory;
            this.btnOkArticle.Font = new System.Drawing.Font("Showcard Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnOkArticle.ForeColor = System.Drawing.Color.LightSalmon;
            this.btnOkArticle.Location = new System.Drawing.Point(470, 148);
            this.btnOkArticle.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnOkArticle.Name = "btnOkArticle";
            this.btnOkArticle.Size = new System.Drawing.Size(170, 35);
            this.btnOkArticle.TabIndex = 9;
            this.btnOkArticle.Text = "Select ";
            this.btnOkArticle.UseVisualStyleBackColor = false;
            this.btnOkArticle.Click += new System.EventHandler(this.btnOkArticle_Click);
            // 
            // btnAddArticle
            // 
            this.btnAddArticle.BackColor = System.Drawing.Color.Ivory;
            this.btnAddArticle.Font = new System.Drawing.Font("Showcard Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAddArticle.ForeColor = System.Drawing.Color.LightSalmon;
            this.btnAddArticle.Location = new System.Drawing.Point(678, 148);
            this.btnAddArticle.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnAddArticle.Name = "btnAddArticle";
            this.btnAddArticle.Size = new System.Drawing.Size(170, 35);
            this.btnAddArticle.TabIndex = 10;
            this.btnAddArticle.Text = "Add to favorite";
            this.btnAddArticle.UseVisualStyleBackColor = false;
            this.btnAddArticle.Click += new System.EventHandler(this.btnAddArticle_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Ivory;
            this.button1.Font = new System.Drawing.Font("Showcard Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.ForeColor = System.Drawing.Color.LightSalmon;
            this.button1.Location = new System.Drawing.Point(678, 523);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(170, 35);
            this.button1.TabIndex = 12;
            this.button1.Text = "Add to favorite";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.Ivory;
            this.btnSave.Font = new System.Drawing.Font("Showcard Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSave.ForeColor = System.Drawing.Color.LightSalmon;
            this.btnSave.Location = new System.Drawing.Point(470, 523);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(170, 35);
            this.btnSave.TabIndex = 11;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // listBoxFavorite
            // 
            this.listBoxFavorite.BackColor = System.Drawing.Color.SeaShell;
            this.listBoxFavorite.Font = new System.Drawing.Font("Showcard Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.listBoxFavorite.ForeColor = System.Drawing.Color.LightSalmon;
            this.listBoxFavorite.FormattingEnabled = true;
            this.listBoxFavorite.ItemHeight = 21;
            this.listBoxFavorite.Location = new System.Drawing.Point(507, 246);
            this.listBoxFavorite.Name = "listBoxFavorite";
            this.listBoxFavorite.Size = new System.Drawing.Size(314, 235);
            this.listBoxFavorite.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.SeaShell;
            this.label1.Font = new System.Drawing.Font("Showcard Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.LightSalmon;
            this.label1.Location = new System.Drawing.Point(507, 225);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 21);
            this.label1.TabIndex = 14;
            this.label1.Text = "Favorite List";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.SeaShell;
            this.label2.Font = new System.Drawing.Font("Showcard Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.LightSalmon;
            this.label2.Location = new System.Drawing.Point(58, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 21);
            this.label2.TabIndex = 15;
            this.label2.Text = "Newsgroups";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.SeaShell;
            this.label3.Font = new System.Drawing.Font("Showcard Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.LightSalmon;
            this.label3.Location = new System.Drawing.Point(58, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 21);
            this.label3.TabIndex = 16;
            this.label3.Text = "Articles";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.SeaShell;
            this.label4.Font = new System.Drawing.Font("Showcard Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.LightSalmon;
            this.label4.Location = new System.Drawing.Point(58, 184);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(129, 21);
            this.label4.TabIndex = 17;
            this.label4.Text = "Articles Text";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.SeaShell;
            this.label5.Font = new System.Drawing.Font("Showcard Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.LightSalmon;
            this.label5.Location = new System.Drawing.Point(615, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(112, 21);
            this.label5.TabIndex = 18;
            this.label5.Text = "Connection";
            // 
            // btnPost
            // 
            this.btnPost.BackColor = System.Drawing.Color.Ivory;
            this.btnPost.Font = new System.Drawing.Font("Showcard Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnPost.ForeColor = System.Drawing.Color.LightSalmon;
            this.btnPost.Location = new System.Drawing.Point(577, 487);
            this.btnPost.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnPost.Name = "btnPost";
            this.btnPost.Size = new System.Drawing.Size(170, 35);
            this.btnPost.TabIndex = 19;
            this.btnPost.Text = "Post";
            this.btnPost.UseVisualStyleBackColor = false;
            this.btnPost.Click += new System.EventHandler(this.btnPost_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Wheat;
            this.ClientSize = new System.Drawing.Size(898, 584);
            this.Controls.Add(this.btnPost);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBoxFavorite);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnAddArticle);
            this.Controls.Add(this.btnOkArticle);
            this.Controls.Add(this.btnAddNews);
            this.Controls.Add(this.btnNewsOk);
            this.Controls.Add(this.txtArticle);
            this.Controls.Add(this.comboBoxArticlesHeaderes);
            this.Controls.Add(this.comboBoxNewsgroupsNames);
            this.Controls.Add(this.txtArticlesNumber);
            this.Controls.Add(this.lblArticlesNumber);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btnStart);
            this.Font = new System.Drawing.Font("Showcard Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ForeColor = System.Drawing.Color.Lavender;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "NewsReader";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnStart;
        private Button btnStop;
        private Label lblArticlesNumber;
        private TextBox txtArticlesNumber;
        private ComboBox comboBoxNewsgroupsNames;
        private ComboBox comboBoxArticlesHeaderes;
        private TextBox txtArticle;
        private Button btnAddNews;
        private Button btnNewsOk;
        private Button btnOkArticle;
        private Button btnAddArticle;
        private Button button1;
        private Button btnSave;
        private ListBox listBoxFavorite;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Button btnPost;
    }
}