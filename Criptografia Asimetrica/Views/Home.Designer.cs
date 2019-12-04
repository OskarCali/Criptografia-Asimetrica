namespace Criptografia_Asimetrica.Views
{
    partial class formHome
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formHome));
            this.grpBxOptions = new System.Windows.Forms.GroupBox();
            this.btnShowHide = new System.Windows.Forms.Button();
            this.btnProcess = new System.Windows.Forms.Button();
            this.lblFolder = new System.Windows.Forms.Label();
            this.btnKeys = new System.Windows.Forms.Button();
            this.radBtnDecrypt = new System.Windows.Forms.RadioButton();
            this.radBtnCrypt = new System.Windows.Forms.RadioButton();
            this.lblTitle = new System.Windows.Forms.Label();
            this.toolStripContainer1 = new System.Windows.Forms.ToolStripContainer();
            this.stStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStLblAuthor = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStLblText = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStLblInfo = new System.Windows.Forms.ToolStripStatusLabel();
            this.splitCont = new System.Windows.Forms.SplitContainer();
            this.richTxtBxSource = new System.Windows.Forms.RichTextBox();
            this.richTxtBxCripto = new System.Windows.Forms.RichTextBox();
            this.folderBrowser = new System.Windows.Forms.FolderBrowserDialog();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.grpBxOptions.SuspendLayout();
            this.toolStripContainer1.BottomToolStripPanel.SuspendLayout();
            this.toolStripContainer1.ContentPanel.SuspendLayout();
            this.toolStripContainer1.SuspendLayout();
            this.stStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitCont)).BeginInit();
            this.splitCont.Panel1.SuspendLayout();
            this.splitCont.Panel2.SuspendLayout();
            this.splitCont.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpBxOptions
            // 
            this.grpBxOptions.Controls.Add(this.btnShowHide);
            this.grpBxOptions.Controls.Add(this.btnProcess);
            this.grpBxOptions.Controls.Add(this.lblFolder);
            this.grpBxOptions.Controls.Add(this.btnKeys);
            this.grpBxOptions.Controls.Add(this.radBtnDecrypt);
            this.grpBxOptions.Controls.Add(this.radBtnCrypt);
            this.grpBxOptions.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpBxOptions.Location = new System.Drawing.Point(0, 50);
            this.grpBxOptions.Margin = new System.Windows.Forms.Padding(2);
            this.grpBxOptions.Name = "grpBxOptions";
            this.grpBxOptions.Padding = new System.Windows.Forms.Padding(2);
            this.grpBxOptions.Size = new System.Drawing.Size(704, 80);
            this.grpBxOptions.TabIndex = 3;
            this.grpBxOptions.TabStop = false;
            // 
            // btnShowHide
            // 
            this.btnShowHide.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnShowHide.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold);
            this.btnShowHide.Location = new System.Drawing.Point(597, 18);
            this.btnShowHide.Margin = new System.Windows.Forms.Padding(2);
            this.btnShowHide.Name = "btnShowHide";
            this.btnShowHide.Size = new System.Drawing.Size(96, 32);
            this.btnShowHide.TabIndex = 5;
            this.btnShowHide.Text = "MOSTRAR";
            this.btnShowHide.UseVisualStyleBackColor = true;
            this.btnShowHide.Click += new System.EventHandler(this.btnShowHide_Click);
            // 
            // btnProcess
            // 
            this.btnProcess.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnProcess.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold);
            this.btnProcess.Location = new System.Drawing.Point(486, 18);
            this.btnProcess.Margin = new System.Windows.Forms.Padding(2);
            this.btnProcess.Name = "btnProcess";
            this.btnProcess.Size = new System.Drawing.Size(96, 32);
            this.btnProcess.TabIndex = 4;
            this.btnProcess.Text = "INICIO";
            this.btnProcess.UseVisualStyleBackColor = true;
            this.btnProcess.Click += new System.EventHandler(this.btnProcess_Click);
            // 
            // lblFolder
            // 
            this.lblFolder.AutoSize = true;
            this.lblFolder.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic);
            this.lblFolder.Location = new System.Drawing.Point(169, 52);
            this.lblFolder.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFolder.Name = "lblFolder";
            this.lblFolder.Size = new System.Drawing.Size(42, 15);
            this.lblFolder.TabIndex = 3;
            this.lblFolder.Text = "Folder";
            // 
            // btnKeys
            // 
            this.btnKeys.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold);
            this.btnKeys.Location = new System.Drawing.Point(172, 17);
            this.btnKeys.Margin = new System.Windows.Forms.Padding(2);
            this.btnKeys.Name = "btnKeys";
            this.btnKeys.Size = new System.Drawing.Size(168, 32);
            this.btnKeys.TabIndex = 2;
            this.btnKeys.Text = "GENERAR LLAVES";
            this.btnKeys.UseVisualStyleBackColor = true;
            this.btnKeys.Click += new System.EventHandler(this.btnKeys_Click);
            // 
            // radBtnDecrypt
            // 
            this.radBtnDecrypt.AutoSize = true;
            this.radBtnDecrypt.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F);
            this.radBtnDecrypt.Location = new System.Drawing.Point(9, 45);
            this.radBtnDecrypt.Margin = new System.Windows.Forms.Padding(2);
            this.radBtnDecrypt.Name = "radBtnDecrypt";
            this.radBtnDecrypt.Size = new System.Drawing.Size(112, 24);
            this.radBtnDecrypt.TabIndex = 1;
            this.radBtnDecrypt.TabStop = true;
            this.radBtnDecrypt.Text = "Desencriptar";
            this.radBtnDecrypt.UseVisualStyleBackColor = true;
            this.radBtnDecrypt.CheckedChanged += new System.EventHandler(this.radBtnDecrypt_CheckedChanged);
            // 
            // radBtnCrypt
            // 
            this.radBtnCrypt.AutoSize = true;
            this.radBtnCrypt.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F);
            this.radBtnCrypt.Location = new System.Drawing.Point(9, 18);
            this.radBtnCrypt.Margin = new System.Windows.Forms.Padding(2);
            this.radBtnCrypt.Name = "radBtnCrypt";
            this.radBtnCrypt.Size = new System.Drawing.Size(87, 24);
            this.radBtnCrypt.TabIndex = 0;
            this.radBtnCrypt.TabStop = true;
            this.radBtnCrypt.Text = "Encriptar";
            this.radBtnCrypt.UseVisualStyleBackColor = true;
            this.radBtnCrypt.CheckedChanged += new System.EventHandler(this.radBtnCrypt_CheckedChanged);
            // 
            // lblTitle
            // 
            this.lblTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTitle.Font = new System.Drawing.Font("MS Reference Sans Serif", 13.8F, System.Drawing.FontStyle.Bold);
            this.lblTitle.Location = new System.Drawing.Point(0, 0);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(704, 50);
            this.lblTitle.TabIndex = 2;
            this.lblTitle.Text = "CRIPTOGRAFIA ASIMETRICA";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // toolStripContainer1
            // 
            // 
            // toolStripContainer1.BottomToolStripPanel
            // 
            this.toolStripContainer1.BottomToolStripPanel.Controls.Add(this.stStrip);
            // 
            // toolStripContainer1.ContentPanel
            // 
            this.toolStripContainer1.ContentPanel.Controls.Add(this.splitCont);
            this.toolStripContainer1.ContentPanel.Size = new System.Drawing.Size(704, 278);
            this.toolStripContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolStripContainer1.Location = new System.Drawing.Point(0, 130);
            this.toolStripContainer1.Name = "toolStripContainer1";
            this.toolStripContainer1.Size = new System.Drawing.Size(704, 302);
            this.toolStripContainer1.TabIndex = 4;
            this.toolStripContainer1.Text = "toolStripContainer1";
            // 
            // stStrip
            // 
            this.stStrip.Dock = System.Windows.Forms.DockStyle.None;
            this.stStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStLblAuthor,
            this.toolStripStLblText,
            this.toolStripStLblInfo});
            this.stStrip.Location = new System.Drawing.Point(0, 0);
            this.stStrip.Name = "stStrip";
            this.stStrip.Size = new System.Drawing.Size(704, 24);
            this.stStrip.TabIndex = 0;
            // 
            // toolStripStLblAuthor
            // 
            this.toolStripStLblAuthor.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold);
            this.toolStripStLblAuthor.Name = "toolStripStLblAuthor";
            this.toolStripStLblAuthor.Size = new System.Drawing.Size(55, 19);
            this.toolStripStLblAuthor.Text = "AUTOR";
            this.toolStripStLblAuthor.Click += new System.EventHandler(this.toolStripStLblAuthor_Click);
            // 
            // toolStripStLblText
            // 
            this.toolStripStLblText.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.toolStripStLblText.Name = "toolStripStLblText";
            this.toolStripStLblText.Size = new System.Drawing.Size(580, 19);
            this.toolStripStLblText.Spring = true;
            this.toolStripStLblText.Text = "Texto Accion";
            this.toolStripStLblText.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // toolStripStLblInfo
            // 
            this.toolStripStLblInfo.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.toolStripStLblInfo.Name = "toolStripStLblInfo";
            this.toolStripStLblInfo.Size = new System.Drawing.Size(54, 19);
            this.toolStripStLblInfo.Text = "Analisis";
            // 
            // splitCont
            // 
            this.splitCont.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitCont.Location = new System.Drawing.Point(0, 0);
            this.splitCont.Name = "splitCont";
            // 
            // splitCont.Panel1
            // 
            this.splitCont.Panel1.Controls.Add(this.richTxtBxSource);
            // 
            // splitCont.Panel2
            // 
            this.splitCont.Panel2.Controls.Add(this.richTxtBxCripto);
            this.splitCont.Size = new System.Drawing.Size(704, 278);
            this.splitCont.SplitterDistance = 381;
            this.splitCont.TabIndex = 0;
            // 
            // richTxtBxSource
            // 
            this.richTxtBxSource.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTxtBxSource.Location = new System.Drawing.Point(0, 0);
            this.richTxtBxSource.Name = "richTxtBxSource";
            this.richTxtBxSource.Size = new System.Drawing.Size(381, 278);
            this.richTxtBxSource.TabIndex = 0;
            this.richTxtBxSource.Text = "";
            this.richTxtBxSource.TextChanged += new System.EventHandler(this.richTxtBxSource_TextChanged);
            // 
            // richTxtBxCripto
            // 
            this.richTxtBxCripto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTxtBxCripto.Location = new System.Drawing.Point(0, 0);
            this.richTxtBxCripto.Name = "richTxtBxCripto";
            this.richTxtBxCripto.ReadOnly = true;
            this.richTxtBxCripto.Size = new System.Drawing.Size(319, 278);
            this.richTxtBxCripto.TabIndex = 0;
            this.richTxtBxCripto.Text = "";
            // 
            // formHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(704, 432);
            this.Controls.Add(this.toolStripContainer1);
            this.Controls.Add(this.grpBxOptions);
            this.Controls.Add(this.lblTitle);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "formHome";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Home";
            this.Load += new System.EventHandler(this.formHome_Load);
            this.grpBxOptions.ResumeLayout(false);
            this.grpBxOptions.PerformLayout();
            this.toolStripContainer1.BottomToolStripPanel.ResumeLayout(false);
            this.toolStripContainer1.BottomToolStripPanel.PerformLayout();
            this.toolStripContainer1.ContentPanel.ResumeLayout(false);
            this.toolStripContainer1.ResumeLayout(false);
            this.toolStripContainer1.PerformLayout();
            this.stStrip.ResumeLayout(false);
            this.stStrip.PerformLayout();
            this.splitCont.Panel1.ResumeLayout(false);
            this.splitCont.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitCont)).EndInit();
            this.splitCont.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpBxOptions;
        private System.Windows.Forms.Label lblFolder;
        private System.Windows.Forms.Button btnKeys;
        private System.Windows.Forms.RadioButton radBtnDecrypt;
        private System.Windows.Forms.RadioButton radBtnCrypt;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.ToolStripContainer toolStripContainer1;
        private System.Windows.Forms.StatusStrip stStrip;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStLblAuthor;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStLblText;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStLblInfo;
        private System.Windows.Forms.Button btnShowHide;
        private System.Windows.Forms.Button btnProcess;
        private System.Windows.Forms.SplitContainer splitCont;
        private System.Windows.Forms.RichTextBox richTxtBxSource;
        private System.Windows.Forms.RichTextBox richTxtBxCripto;
        private System.Windows.Forms.FolderBrowserDialog folderBrowser;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
    }
}