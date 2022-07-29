namespace Resume_Generator_Program
{
    partial class Resumegenerator
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
            this.components = new System.ComponentModel.Container();
            this.RGclearbutton = new System.Windows.Forms.Button();
            this.RGtitle = new System.Windows.Forms.Label();
            this.RGjsonviewer = new System.Windows.Forms.RichTextBox();
            this.RGopenjsonbutton = new System.Windows.Forms.Button();
            this.RGsaveaspdfbutton = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // RGclearbutton
            // 
            this.RGclearbutton.Location = new System.Drawing.Point(31, 192);
            this.RGclearbutton.Name = "RGclearbutton";
            this.RGclearbutton.Size = new System.Drawing.Size(181, 23);
            this.RGclearbutton.TabIndex = 68;
            this.RGclearbutton.Text = "Clear All";
            this.RGclearbutton.UseVisualStyleBackColor = true;
            this.RGclearbutton.Click += new System.EventHandler(this.button2_Click);
            // 
            // RGtitle
            // 
            this.RGtitle.AutoSize = true;
            this.RGtitle.BackColor = System.Drawing.Color.Transparent;
            this.RGtitle.Font = new System.Drawing.Font("Magneto", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.RGtitle.ForeColor = System.Drawing.Color.MintCream;
            this.RGtitle.Location = new System.Drawing.Point(12, 34);
            this.RGtitle.Name = "RGtitle";
            this.RGtitle.Size = new System.Drawing.Size(215, 58);
            this.RGtitle.TabIndex = 69;
            this.RGtitle.Text = "resume";
            // 
            // RGjsonviewer
            // 
            this.RGjsonviewer.Location = new System.Drawing.Point(243, 12);
            this.RGjsonviewer.Name = "RGjsonviewer";
            this.RGjsonviewer.Size = new System.Drawing.Size(932, 620);
            this.RGjsonviewer.TabIndex = 70;
            this.RGjsonviewer.Text = "";
            this.RGjsonviewer.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // RGopenjsonbutton
            // 
            this.RGopenjsonbutton.Location = new System.Drawing.Point(31, 248);
            this.RGopenjsonbutton.Name = "RGopenjsonbutton";
            this.RGopenjsonbutton.Size = new System.Drawing.Size(181, 23);
            this.RGopenjsonbutton.TabIndex = 71;
            this.RGopenjsonbutton.Text = "Open JSON";
            this.RGopenjsonbutton.UseVisualStyleBackColor = true;
            this.RGopenjsonbutton.Click += new System.EventHandler(this.RGopenjsonbutton_Click);
            // 
            // RGsaveaspdfbutton
            // 
            this.RGsaveaspdfbutton.Location = new System.Drawing.Point(31, 304);
            this.RGsaveaspdfbutton.Name = "RGsaveaspdfbutton";
            this.RGsaveaspdfbutton.Size = new System.Drawing.Size(181, 23);
            this.RGsaveaspdfbutton.TabIndex = 72;
            this.RGsaveaspdfbutton.Text = "Save as PDF";
            this.RGsaveaspdfbutton.UseVisualStyleBackColor = true;
            this.RGsaveaspdfbutton.Click += new System.EventHandler(this.RGsaveaspdfbutton_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(31, 132);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(181, 23);
            this.comboBox1.TabIndex = 75;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // Resumegenerator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Resume_Generator_Program.Properties.Resources.resumegenerator;
            this.ClientSize = new System.Drawing.Size(1187, 644);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.RGsaveaspdfbutton);
            this.Controls.Add(this.RGopenjsonbutton);
            this.Controls.Add(this.RGjsonviewer);
            this.Controls.Add(this.RGtitle);
            this.Controls.Add(this.RGclearbutton);
            this.Name = "Resumegenerator";
            this.Text = "RESUME GENERATOR";
            this.Load += new System.EventHandler(this.Resumegenerator_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Button RGclearbutton;
        private Label RGtitle;
        private RichTextBox RGjsonviewer;
        private Button RGopenjsonbutton;
        private Button RGsaveaspdfbutton;
        private ContextMenuStrip contextMenuStrip1;
        private ComboBox comboBox1;
    }
}