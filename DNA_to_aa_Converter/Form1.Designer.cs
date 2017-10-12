namespace DNA_to_aa_Converter
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtDNA = new System.Windows.Forms.RichTextBox();
            this.txtProtein = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnfileOpen = new System.Windows.Forms.Button();
            this.dna_to_amino = new System.Windows.Forms.Button();
            this.amino_to_dna = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.Crimson;
            this.label1.Location = new System.Drawing.Point(12, 210);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "DNA Sequence";
            // 
            // txtDNA
            // 
            this.txtDNA.Location = new System.Drawing.Point(16, 254);
            this.txtDNA.Name = "txtDNA";
            this.txtDNA.Size = new System.Drawing.Size(584, 142);
            this.txtDNA.TabIndex = 1;
            this.txtDNA.Text = "";
            // 
            // txtProtein
            // 
            this.txtProtein.Location = new System.Drawing.Point(16, 464);
            this.txtProtein.Name = "txtProtein";
            this.txtProtein.Size = new System.Drawing.Size(584, 142);
            this.txtProtein.TabIndex = 3;
            this.txtProtein.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.Crimson;
            this.label2.Location = new System.Drawing.Point(12, 425);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "Amino Acids";
            // 
            // btnfileOpen
            // 
            this.btnfileOpen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnfileOpen.FlatAppearance.BorderSize = 0;
            this.btnfileOpen.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnfileOpen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnfileOpen.Location = new System.Drawing.Point(22, 92);
            this.btnfileOpen.Name = "btnfileOpen";
            this.btnfileOpen.Size = new System.Drawing.Size(129, 42);
            this.btnfileOpen.TabIndex = 4;
            this.btnfileOpen.Text = "File Open";
            this.btnfileOpen.UseVisualStyleBackColor = false;
            this.btnfileOpen.Click += new System.EventHandler(this.btnfileOpen_Click);
            // 
            // dna_to_amino
            // 
            this.dna_to_amino.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.dna_to_amino.FlatAppearance.BorderSize = 0;
            this.dna_to_amino.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.dna_to_amino.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dna_to_amino.Location = new System.Drawing.Point(359, 25);
            this.dna_to_amino.Name = "dna_to_amino";
            this.dna_to_amino.Size = new System.Drawing.Size(201, 42);
            this.dna_to_amino.TabIndex = 5;
            this.dna_to_amino.Text = "DNA to Amino Acids";
            this.dna_to_amino.UseVisualStyleBackColor = false;
            this.dna_to_amino.Click += new System.EventHandler(this.dna_to_amino_Click);
            // 
            // amino_to_dna
            // 
            this.amino_to_dna.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.amino_to_dna.FlatAppearance.BorderSize = 0;
            this.amino_to_dna.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.amino_to_dna.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.amino_to_dna.Location = new System.Drawing.Point(359, 92);
            this.amino_to_dna.Name = "amino_to_dna";
            this.amino_to_dna.Size = new System.Drawing.Size(201, 42);
            this.amino_to_dna.TabIndex = 6;
            this.amino_to_dna.Text = "Amino Acids to DNA";
            this.amino_to_dna.UseVisualStyleBackColor = false;
            this.amino_to_dna.Click += new System.EventHandler(this.amino_to_dna_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnClear.FlatAppearance.BorderSize = 0;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnClear.Location = new System.Drawing.Point(170, 92);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(129, 42);
            this.btnClear.TabIndex = 7;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Controls.Add(this.radioButton2);
            this.groupBox1.Controls.Add(this.btnfileOpen);
            this.groupBox1.Controls.Add(this.btnClear);
            this.groupBox1.Controls.Add(this.dna_to_amino);
            this.groupBox1.Controls.Add(this.amino_to_dna);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.groupBox1.Location = new System.Drawing.Point(16, 32);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(584, 159);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "File";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(22, 34);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(126, 24);
            this.radioButton1.TabIndex = 10;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Amino Acids";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(170, 34);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(150, 24);
            this.radioButton2.TabIndex = 9;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "DNA Sequence";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(619, 633);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtProtein);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtDNA);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "DNA to Amino Acids Converter";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox txtDNA;
        private System.Windows.Forms.RichTextBox txtProtein;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnfileOpen;
        private System.Windows.Forms.Button dna_to_amino;
        private System.Windows.Forms.Button amino_to_dna;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
    }
}

