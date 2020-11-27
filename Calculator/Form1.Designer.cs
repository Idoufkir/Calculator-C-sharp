namespace Calculator
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

        private System.Windows.Forms.PictureBox Logo;

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.bntSept = new System.Windows.Forms.Button();
            this.bntHuit = new System.Windows.Forms.Button();
            this.bntNeuf = new System.Windows.Forms.Button();
            this.btnDiviser = new System.Windows.Forms.Button();
            this.btnCe = new System.Windows.Forms.Button();
            this.btnC = new System.Windows.Forms.Button();
            this.btnFois = new System.Windows.Forms.Button();
            this.btnSix = new System.Windows.Forms.Button();
            this.btCninq = new System.Windows.Forms.Button();
            this.btnQuatre = new System.Windows.Forms.Button();
            this.btnMoins = new System.Windows.Forms.Button();
            this.btnTrois = new System.Windows.Forms.Button();
            this.btnDeux = new System.Windows.Forms.Button();
            this.btnUn = new System.Windows.Forms.Button();
            this.btnEgale = new System.Windows.Forms.Button();
            this.btnPlus = new System.Windows.Forms.Button();
            this.btnVirgule = new System.Windows.Forms.Button();
            this.btnZero = new System.Windows.Forms.Button();
            this.textBox_Result = new System.Windows.Forms.TextBox();
            this.labelCurrentOperation = new System.Windows.Forms.Label();
            this.Logo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).BeginInit();
            this.SuspendLayout();
            // 
            // bntSept
            // 
            this.bntSept.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bntSept.Location = new System.Drawing.Point(64, 237);
            this.bntSept.Name = "bntSept";
            this.bntSept.Size = new System.Drawing.Size(120, 55);
            this.bntSept.TabIndex = 0;
            this.bntSept.Text = "7";
            this.bntSept.UseVisualStyleBackColor = true;
            this.bntSept.Click += new System.EventHandler(this.button_click);
            // 
            // bntHuit
            // 
            this.bntHuit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bntHuit.Location = new System.Drawing.Point(190, 237);
            this.bntHuit.Name = "bntHuit";
            this.bntHuit.Size = new System.Drawing.Size(120, 55);
            this.bntHuit.TabIndex = 1;
            this.bntHuit.Text = "8";
            this.bntHuit.UseVisualStyleBackColor = true;
            this.bntHuit.Click += new System.EventHandler(this.button_click);
            // 
            // bntNeuf
            // 
            this.bntNeuf.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bntNeuf.Location = new System.Drawing.Point(316, 237);
            this.bntNeuf.Name = "bntNeuf";
            this.bntNeuf.Size = new System.Drawing.Size(120, 55);
            this.bntNeuf.TabIndex = 2;
            this.bntNeuf.Text = "9";
            this.bntNeuf.UseVisualStyleBackColor = true;
            this.bntNeuf.Click += new System.EventHandler(this.button_click);
            // 
            // btnDiviser
            // 
            this.btnDiviser.BackColor = System.Drawing.Color.LightGreen;
            this.btnDiviser.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDiviser.Location = new System.Drawing.Point(442, 237);
            this.btnDiviser.Name = "btnDiviser";
            this.btnDiviser.Size = new System.Drawing.Size(120, 55);
            this.btnDiviser.TabIndex = 3;
            this.btnDiviser.Text = "/";
            this.btnDiviser.UseVisualStyleBackColor = false;
            this.btnDiviser.Click += new System.EventHandler(this.operator_click);
            // 
            // btnCe
            // 
            this.btnCe.BackColor = System.Drawing.Color.Orange;
            this.btnCe.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCe.Location = new System.Drawing.Point(568, 237);
            this.btnCe.Name = "btnCe";
            this.btnCe.Size = new System.Drawing.Size(128, 55);
            this.btnCe.TabIndex = 4;
            this.btnCe.Text = "CE";
            this.btnCe.UseVisualStyleBackColor = false;
            this.btnCe.Click += new System.EventHandler(this.buttonCe_Click);
            // 
            // btnC
            // 
            this.btnC.BackColor = System.Drawing.Color.Orange;
            this.btnC.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnC.Location = new System.Drawing.Point(568, 298);
            this.btnC.Name = "btnC";
            this.btnC.Size = new System.Drawing.Size(128, 55);
            this.btnC.TabIndex = 9;
            this.btnC.Text = "C";
            this.btnC.UseVisualStyleBackColor = false;
            this.btnC.Click += new System.EventHandler(this.buttonC_Click);
            // 
            // btnFois
            // 
            this.btnFois.BackColor = System.Drawing.Color.LightGreen;
            this.btnFois.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFois.Location = new System.Drawing.Point(442, 298);
            this.btnFois.Name = "btnFois";
            this.btnFois.Size = new System.Drawing.Size(120, 55);
            this.btnFois.TabIndex = 8;
            this.btnFois.Text = "*";
            this.btnFois.UseVisualStyleBackColor = false;
            this.btnFois.Click += new System.EventHandler(this.operator_click);
            // 
            // btnSix
            // 
            this.btnSix.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSix.Location = new System.Drawing.Point(316, 298);
            this.btnSix.Name = "btnSix";
            this.btnSix.Size = new System.Drawing.Size(120, 55);
            this.btnSix.TabIndex = 7;
            this.btnSix.Text = "6";
            this.btnSix.UseVisualStyleBackColor = true;
            this.btnSix.Click += new System.EventHandler(this.button_click);
            // 
            // btCninq
            // 
            this.btCninq.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCninq.Location = new System.Drawing.Point(190, 298);
            this.btCninq.Name = "btCninq";
            this.btCninq.Size = new System.Drawing.Size(120, 55);
            this.btCninq.TabIndex = 6;
            this.btCninq.Text = "5";
            this.btCninq.UseVisualStyleBackColor = true;
            this.btCninq.Click += new System.EventHandler(this.button_click);
            // 
            // btnQuatre
            // 
            this.btnQuatre.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuatre.Location = new System.Drawing.Point(64, 298);
            this.btnQuatre.Name = "btnQuatre";
            this.btnQuatre.Size = new System.Drawing.Size(120, 55);
            this.btnQuatre.TabIndex = 5;
            this.btnQuatre.Text = "4";
            this.btnQuatre.UseVisualStyleBackColor = true;
            this.btnQuatre.Click += new System.EventHandler(this.button_click);
            // 
            // btnMoins
            // 
            this.btnMoins.BackColor = System.Drawing.Color.LightGreen;
            this.btnMoins.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMoins.Location = new System.Drawing.Point(442, 359);
            this.btnMoins.Name = "btnMoins";
            this.btnMoins.Size = new System.Drawing.Size(120, 55);
            this.btnMoins.TabIndex = 13;
            this.btnMoins.Text = "-";
            this.btnMoins.UseVisualStyleBackColor = false;
            this.btnMoins.Click += new System.EventHandler(this.operator_click);
            // 
            // btnTrois
            // 
            this.btnTrois.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTrois.Location = new System.Drawing.Point(316, 359);
            this.btnTrois.Name = "btnTrois";
            this.btnTrois.Size = new System.Drawing.Size(120, 55);
            this.btnTrois.TabIndex = 12;
            this.btnTrois.Text = "3";
            this.btnTrois.UseVisualStyleBackColor = true;
            this.btnTrois.Click += new System.EventHandler(this.button_click);
            // 
            // btnDeux
            // 
            this.btnDeux.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeux.Location = new System.Drawing.Point(190, 359);
            this.btnDeux.Name = "btnDeux";
            this.btnDeux.Size = new System.Drawing.Size(120, 55);
            this.btnDeux.TabIndex = 11;
            this.btnDeux.Text = "2";
            this.btnDeux.UseVisualStyleBackColor = true;
            this.btnDeux.Click += new System.EventHandler(this.button_click);
            // 
            // btnUn
            // 
            this.btnUn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUn.Location = new System.Drawing.Point(64, 359);
            this.btnUn.Name = "btnUn";
            this.btnUn.Size = new System.Drawing.Size(120, 55);
            this.btnUn.TabIndex = 10;
            this.btnUn.Text = "1";
            this.btnUn.UseVisualStyleBackColor = true;
            this.btnUn.Click += new System.EventHandler(this.button_click);
            // 
            // btnEgale
            // 
            this.btnEgale.BackColor = System.Drawing.Color.Moccasin;
            this.btnEgale.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEgale.Location = new System.Drawing.Point(568, 359);
            this.btnEgale.Name = "btnEgale";
            this.btnEgale.Size = new System.Drawing.Size(128, 116);
            this.btnEgale.TabIndex = 19;
            this.btnEgale.Text = "=";
            this.btnEgale.UseVisualStyleBackColor = false;
            this.btnEgale.Click += new System.EventHandler(this.buttonEgale_Click);
            // 
            // btnPlus
            // 
            this.btnPlus.BackColor = System.Drawing.Color.LightGreen;
            this.btnPlus.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlus.Location = new System.Drawing.Point(442, 420);
            this.btnPlus.Name = "btnPlus";
            this.btnPlus.Size = new System.Drawing.Size(120, 55);
            this.btnPlus.TabIndex = 18;
            this.btnPlus.Text = "+";
            this.btnPlus.UseVisualStyleBackColor = false;
            this.btnPlus.Click += new System.EventHandler(this.operator_click);
            // 
            // btnVirgule
            // 
            this.btnVirgule.BackColor = System.Drawing.Color.LightGreen;
            this.btnVirgule.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVirgule.Location = new System.Drawing.Point(316, 420);
            this.btnVirgule.Name = "btnVirgule";
            this.btnVirgule.Size = new System.Drawing.Size(120, 55);
            this.btnVirgule.TabIndex = 17;
            this.btnVirgule.Text = ".";
            this.btnVirgule.UseVisualStyleBackColor = false;
            this.btnVirgule.Click += new System.EventHandler(this.button_click);
            // 
            // btnZero
            // 
            this.btnZero.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnZero.Location = new System.Drawing.Point(64, 420);
            this.btnZero.Name = "btnZero";
            this.btnZero.Size = new System.Drawing.Size(246, 55);
            this.btnZero.TabIndex = 15;
            this.btnZero.Text = "0";
            this.btnZero.UseVisualStyleBackColor = true;
            this.btnZero.Click += new System.EventHandler(this.button_click);
            // 
            // textBox_Result
            // 
            this.textBox_Result.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_Result.Location = new System.Drawing.Point(316, 503);
            this.textBox_Result.Name = "textBox_Result";
            this.textBox_Result.Size = new System.Drawing.Size(380, 29);
            this.textBox_Result.TabIndex = 20;
            this.textBox_Result.Text = "0";
            this.textBox_Result.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // labelCurrentOperation
            // 
            this.labelCurrentOperation.AutoSize = true;
            this.labelCurrentOperation.BackColor = System.Drawing.SystemColors.Window;
            this.labelCurrentOperation.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCurrentOperation.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.labelCurrentOperation.Location = new System.Drawing.Point(74, 508);
            this.labelCurrentOperation.Name = "labelCurrentOperation";
            this.labelCurrentOperation.Size = new System.Drawing.Size(0, 24);
            this.labelCurrentOperation.TabIndex = 21;
            // 
            // Logo
            // 
            this.Logo.Image = ((System.Drawing.Image)(resources.GetObject("Logo.Image")));
            this.Logo.Location = new System.Drawing.Point(129, 28);
            this.Logo.Name = "Logo";
            this.Logo.Size = new System.Drawing.Size(517, 159);
            this.Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Logo.TabIndex = 22;
            this.Logo.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(730, 553);
            this.Controls.Add(this.Logo);
            this.Controls.Add(this.labelCurrentOperation);
            this.Controls.Add(this.textBox_Result);
            this.Controls.Add(this.btnEgale);
            this.Controls.Add(this.btnPlus);
            this.Controls.Add(this.btnVirgule);
            this.Controls.Add(this.btnZero);
            this.Controls.Add(this.btnMoins);
            this.Controls.Add(this.btnTrois);
            this.Controls.Add(this.btnDeux);
            this.Controls.Add(this.btnUn);
            this.Controls.Add(this.btnC);
            this.Controls.Add(this.btnFois);
            this.Controls.Add(this.btnSix);
            this.Controls.Add(this.btCninq);
            this.Controls.Add(this.btnQuatre);
            this.Controls.Add(this.btnCe);
            this.Controls.Add(this.btnDiviser);
            this.Controls.Add(this.bntNeuf);
            this.Controls.Add(this.bntHuit);
            this.Controls.Add(this.bntSept);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculator";
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnZero;
        private System.Windows.Forms.Button btnUn;
        private System.Windows.Forms.Button btnDeux;
        private System.Windows.Forms.Button btnTrois;
        private System.Windows.Forms.Button btnQuatre;
        private System.Windows.Forms.Button btCninq;
        private System.Windows.Forms.Button btnSix;
        private System.Windows.Forms.Button bntSept;
        private System.Windows.Forms.Button bntHuit;
        private System.Windows.Forms.Button bntNeuf;


        private System.Windows.Forms.Button btnDiviser;
        private System.Windows.Forms.Button btnFois;
        private System.Windows.Forms.Button btnMoins;
        private System.Windows.Forms.Button btnEgale;
        private System.Windows.Forms.Button btnPlus;
        private System.Windows.Forms.Button btnVirgule;


        private System.Windows.Forms.Button btnCe;
        private System.Windows.Forms.Button btnC;


        private System.Windows.Forms.TextBox textBox_Result;
        private System.Windows.Forms.Label labelCurrentOperation;
    }
}

