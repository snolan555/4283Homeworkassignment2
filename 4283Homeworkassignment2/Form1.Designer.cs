
namespace _4283Homeworkassignment2
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label statusLabel;
            this.lstquestname = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.campaignBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.smnolanDataSet = new _4283Homeworkassignment2.smnolanDataSet();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtnpc = new System.Windows.Forms.TextBox();
            this.txtquesttype = new System.Windows.Forms.TextBox();
            this.txtqid = new System.Windows.Forms.TextBox();
            this.txtdiff = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtreward = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.txtadate = new System.Windows.Forms.TextBox();
            this.txtdesc = new System.Windows.Forms.TextBox();
            this.txtstatus = new System.Windows.Forms.TextBox();
            this.btncinsert = new System.Windows.Forms.Button();
            this.btncupdate = new System.Windows.Forms.Button();
            this.btncdelete = new System.Windows.Forms.Button();
            this.btnadelete = new System.Windows.Forms.Button();
            this.btnaupdate = new System.Windows.Forms.Button();
            this.btnainsert = new System.Windows.Forms.Button();
            this.btnqdelete = new System.Windows.Forms.Button();
            this.btnqupdate = new System.Windows.Forms.Button();
            this.btnqinsert = new System.Windows.Forms.Button();
            this.btnrefresh = new System.Windows.Forms.Button();
            this.btnexit = new System.Windows.Forms.Button();
            this.label16 = new System.Windows.Forms.Label();
            this.txtnewchar = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.txtnewquest = new System.Windows.Forms.TextBox();
            this.campaignTableAdapter = new _4283Homeworkassignment2.smnolanDataSetTableAdapters.CampaignTableAdapter();
            this.tableAdapterManager = new _4283Homeworkassignment2.smnolanDataSetTableAdapters.TableAdapterManager();
            this.statusTextBox = new System.Windows.Forms.TextBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            statusLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.campaignBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.smnolanDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // statusLabel
            // 
            statusLabel.AutoSize = true;
            statusLabel.Location = new System.Drawing.Point(706, 32);
            statusLabel.Name = "statusLabel";
            statusLabel.Size = new System.Drawing.Size(60, 20);
            statusLabel.TabIndex = 45;
            statusLabel.Text = "Status:";
            // 
            // lstquestname
            // 
            this.lstquestname.FormattingEnabled = true;
            this.lstquestname.ItemHeight = 20;
            this.lstquestname.Location = new System.Drawing.Point(1346, 123);
            this.lstquestname.Name = "lstquestname";
            this.lstquestname.Size = new System.Drawing.Size(277, 244);
            this.lstquestname.TabIndex = 2;
            this.lstquestname.SelectedIndexChanged += new System.EventHandler(this.lstquestname_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cambria", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(1340, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(222, 33);
            this.label2.TabIndex = 3;
            this.label2.Text = "Select Your Quest";
            // 
            // campaignBindingSource
            // 
            this.campaignBindingSource.DataMember = "Campaign";
            this.campaignBindingSource.DataSource = this.smnolanDataSet;
            // 
            // smnolanDataSet
            // 
            this.smnolanDataSet.DataSetName = "smnolanDataSet";
            this.smnolanDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(76, 275);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(98, 20);
            this.label7.TabIndex = 13;
            this.label7.Text = "Player Name";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(1328, 517);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(41, 20);
            this.label8.TabIndex = 21;
            this.label8.Text = "NPC";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(1328, 474);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(90, 20);
            this.label9.TabIndex = 20;
            this.label9.Text = "Quest Type";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(1328, 435);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(73, 20);
            this.label10.TabIndex = 19;
            this.label10.Text = "Quest ID";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(1330, 403);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(69, 20);
            this.label11.TabIndex = 18;
            this.label11.Text = "Difficulty";
            // 
            // txtnpc
            // 
            this.txtnpc.Location = new System.Drawing.Point(1460, 511);
            this.txtnpc.Name = "txtnpc";
            this.txtnpc.Size = new System.Drawing.Size(100, 26);
            this.txtnpc.TabIndex = 17;
            // 
            // txtquesttype
            // 
            this.txtquesttype.Location = new System.Drawing.Point(1460, 469);
            this.txtquesttype.Name = "txtquesttype";
            this.txtquesttype.Size = new System.Drawing.Size(100, 26);
            this.txtquesttype.TabIndex = 16;
            // 
            // txtqid
            // 
            this.txtqid.Location = new System.Drawing.Point(1460, 429);
            this.txtqid.Name = "txtqid";
            this.txtqid.Size = new System.Drawing.Size(100, 26);
            this.txtqid.TabIndex = 15;
            // 
            // txtdiff
            // 
            this.txtdiff.Location = new System.Drawing.Point(1460, 398);
            this.txtdiff.Name = "txtdiff";
            this.txtdiff.Size = new System.Drawing.Size(100, 26);
            this.txtdiff.TabIndex = 14;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(1328, 555);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(64, 20);
            this.label12.TabIndex = 23;
            this.label12.Text = "Reward";
            // 
            // txtreward
            // 
            this.txtreward.Location = new System.Drawing.Point(1460, 549);
            this.txtreward.Name = "txtreward";
            this.txtreward.Size = new System.Drawing.Size(100, 26);
            this.txtreward.TabIndex = 22;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(718, 520);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(98, 20);
            this.label13.TabIndex = 29;
            this.label13.Text = "Accept Date";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(718, 477);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(89, 20);
            this.label14.TabIndex = 28;
            this.label14.Text = "Description";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(718, 440);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(56, 20);
            this.label15.TabIndex = 27;
            this.label15.Text = "Status";
            // 
            // txtadate
            // 
            this.txtadate.Location = new System.Drawing.Point(850, 514);
            this.txtadate.Name = "txtadate";
            this.txtadate.Size = new System.Drawing.Size(100, 26);
            this.txtadate.TabIndex = 26;
            // 
            // txtdesc
            // 
            this.txtdesc.Location = new System.Drawing.Point(850, 472);
            this.txtdesc.Name = "txtdesc";
            this.txtdesc.Size = new System.Drawing.Size(100, 26);
            this.txtdesc.TabIndex = 25;
            // 
            // txtstatus
            // 
            this.txtstatus.Location = new System.Drawing.Point(850, 434);
            this.txtstatus.Name = "txtstatus";
            this.txtstatus.Size = new System.Drawing.Size(100, 26);
            this.txtstatus.TabIndex = 24;
            // 
            // btncinsert
            // 
            this.btncinsert.Location = new System.Drawing.Point(50, 398);
            this.btncinsert.Name = "btncinsert";
            this.btncinsert.Size = new System.Drawing.Size(75, 62);
            this.btncinsert.TabIndex = 30;
            this.btncinsert.Text = "Insert";
            this.btncinsert.UseVisualStyleBackColor = true;
            this.btncinsert.Click += new System.EventHandler(this.btncinsert_Click);
            // 
            // btncupdate
            // 
            this.btncupdate.Location = new System.Drawing.Point(160, 398);
            this.btncupdate.Name = "btncupdate";
            this.btncupdate.Size = new System.Drawing.Size(75, 62);
            this.btncupdate.TabIndex = 31;
            this.btncupdate.Text = "Update";
            this.btncupdate.UseVisualStyleBackColor = true;
            this.btncupdate.Click += new System.EventHandler(this.btncupdate_Click);
            // 
            // btncdelete
            // 
            this.btncdelete.Location = new System.Drawing.Point(106, 466);
            this.btncdelete.Name = "btncdelete";
            this.btncdelete.Size = new System.Drawing.Size(75, 72);
            this.btncdelete.TabIndex = 32;
            this.btncdelete.Text = "Delete";
            this.btncdelete.UseVisualStyleBackColor = true;
            this.btncdelete.Click += new System.EventHandler(this.btncdelete_Click);
            // 
            // btnadelete
            // 
            this.btnadelete.Location = new System.Drawing.Point(918, 554);
            this.btnadelete.Name = "btnadelete";
            this.btnadelete.Size = new System.Drawing.Size(75, 72);
            this.btnadelete.TabIndex = 35;
            this.btnadelete.Text = "Delete";
            this.btnadelete.UseVisualStyleBackColor = true;
            this.btnadelete.Click += new System.EventHandler(this.btnadelete_Click);
            // 
            // btnaupdate
            // 
            this.btnaupdate.Location = new System.Drawing.Point(820, 560);
            this.btnaupdate.Name = "btnaupdate";
            this.btnaupdate.Size = new System.Drawing.Size(75, 62);
            this.btnaupdate.TabIndex = 34;
            this.btnaupdate.Text = "Update";
            this.btnaupdate.UseVisualStyleBackColor = true;
            this.btnaupdate.Click += new System.EventHandler(this.btnaupdate_Click);
            // 
            // btnainsert
            // 
            this.btnainsert.Location = new System.Drawing.Point(722, 560);
            this.btnainsert.Name = "btnainsert";
            this.btnainsert.Size = new System.Drawing.Size(75, 62);
            this.btnainsert.TabIndex = 33;
            this.btnainsert.Text = "Insert";
            this.btnainsert.UseVisualStyleBackColor = true;
            this.btnainsert.Click += new System.EventHandler(this.btnainsert_Click);
            // 
            // btnqdelete
            // 
            this.btnqdelete.Location = new System.Drawing.Point(1604, 488);
            this.btnqdelete.Name = "btnqdelete";
            this.btnqdelete.Size = new System.Drawing.Size(75, 72);
            this.btnqdelete.TabIndex = 38;
            this.btnqdelete.Text = "Delete";
            this.btnqdelete.UseVisualStyleBackColor = true;
            this.btnqdelete.Click += new System.EventHandler(this.btnqdelete_Click);
            // 
            // btnqupdate
            // 
            this.btnqupdate.Location = new System.Drawing.Point(1664, 412);
            this.btnqupdate.Name = "btnqupdate";
            this.btnqupdate.Size = new System.Drawing.Size(75, 62);
            this.btnqupdate.TabIndex = 37;
            this.btnqupdate.Text = "Update";
            this.btnqupdate.UseVisualStyleBackColor = true;
            this.btnqupdate.Click += new System.EventHandler(this.btnqupdate_Click);
            // 
            // btnqinsert
            // 
            this.btnqinsert.Location = new System.Drawing.Point(1568, 412);
            this.btnqinsert.Name = "btnqinsert";
            this.btnqinsert.Size = new System.Drawing.Size(75, 62);
            this.btnqinsert.TabIndex = 36;
            this.btnqinsert.Text = "Insert";
            this.btnqinsert.UseVisualStyleBackColor = true;
            this.btnqinsert.Click += new System.EventHandler(this.btnqinsert_Click);
            // 
            // btnrefresh
            // 
            this.btnrefresh.Location = new System.Drawing.Point(12, 575);
            this.btnrefresh.Name = "btnrefresh";
            this.btnrefresh.Size = new System.Drawing.Size(75, 62);
            this.btnrefresh.TabIndex = 39;
            this.btnrefresh.Text = "Refresh";
            this.btnrefresh.UseVisualStyleBackColor = true;
            this.btnrefresh.Click += new System.EventHandler(this.btnrefresh_Click);
            // 
            // btnexit
            // 
            this.btnexit.Location = new System.Drawing.Point(99, 575);
            this.btnexit.Name = "btnexit";
            this.btnexit.Size = new System.Drawing.Size(75, 62);
            this.btnexit.TabIndex = 40;
            this.btnexit.Text = "Exit";
            this.btnexit.UseVisualStyleBackColor = true;
            this.btnexit.Click += new System.EventHandler(this.btnexit_Click);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(75, 320);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(109, 20);
            this.label16.TabIndex = 43;
            this.label16.Text = "new character";
            // 
            // txtnewchar
            // 
            this.txtnewchar.Location = new System.Drawing.Point(207, 314);
            this.txtnewchar.Name = "txtnewchar";
            this.txtnewchar.Size = new System.Drawing.Size(100, 26);
            this.txtnewchar.TabIndex = 42;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(1330, 602);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(82, 20);
            this.label17.TabIndex = 45;
            this.label17.Text = "new quest";
            // 
            // txtnewquest
            // 
            this.txtnewquest.Location = new System.Drawing.Point(1462, 595);
            this.txtnewquest.Name = "txtnewquest";
            this.txtnewquest.Size = new System.Drawing.Size(100, 26);
            this.txtnewquest.TabIndex = 44;
            // 
            // campaignTableAdapter
            // 
            this.campaignTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CampaignTableAdapter = this.campaignTableAdapter;
            this.tableAdapterManager.UpdateOrder = _4283Homeworkassignment2.smnolanDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // statusTextBox
            // 
            this.statusTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.campaignBindingSource, "Status", true));
            this.statusTextBox.Location = new System.Drawing.Point(772, 29);
            this.statusTextBox.Name = "statusTextBox";
            this.statusTextBox.Size = new System.Drawing.Size(100, 26);
            this.statusTextBox.TabIndex = 46;
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(596, 275);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 100);
            this.groupBox1.TabIndex = 47;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(918, 275);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 48;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1844, 658);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(statusLabel);
            this.Controls.Add(this.statusTextBox);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.txtnewquest);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.txtnewchar);
            this.Controls.Add(this.btnexit);
            this.Controls.Add(this.btnrefresh);
            this.Controls.Add(this.btnqdelete);
            this.Controls.Add(this.btnqupdate);
            this.Controls.Add(this.btnqinsert);
            this.Controls.Add(this.btnadelete);
            this.Controls.Add(this.btnaupdate);
            this.Controls.Add(this.btnainsert);
            this.Controls.Add(this.btncdelete);
            this.Controls.Add(this.btncupdate);
            this.Controls.Add(this.btncinsert);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.txtadate);
            this.Controls.Add(this.txtdesc);
            this.Controls.Add(this.txtstatus);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txtreward);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtnpc);
            this.Controls.Add(this.txtquesttype);
            this.Controls.Add(this.txtqid);
            this.Controls.Add(this.txtdiff);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lstquestname);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.campaignBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.smnolanDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListBox lstquestname;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtnpc;
        private System.Windows.Forms.TextBox txtquesttype;
        private System.Windows.Forms.TextBox txtqid;
        private System.Windows.Forms.TextBox txtdiff;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtreward;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtadate;
        private System.Windows.Forms.TextBox txtdesc;
        private System.Windows.Forms.TextBox txtstatus;
        private System.Windows.Forms.Button btncinsert;
        private System.Windows.Forms.Button btncupdate;
        private System.Windows.Forms.Button btncdelete;
        private System.Windows.Forms.Button btnadelete;
        private System.Windows.Forms.Button btnaupdate;
        private System.Windows.Forms.Button btnainsert;
        private System.Windows.Forms.Button btnqdelete;
        private System.Windows.Forms.Button btnqupdate;
        private System.Windows.Forms.Button btnqinsert;
        private System.Windows.Forms.Button btnrefresh;
        private System.Windows.Forms.Button btnexit;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtnewchar;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox txtnewquest;
        private smnolanDataSet smnolanDataSet;
        private System.Windows.Forms.BindingSource campaignBindingSource;
        private smnolanDataSetTableAdapters.CampaignTableAdapter campaignTableAdapter;
        private smnolanDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox statusTextBox;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
    }
}

