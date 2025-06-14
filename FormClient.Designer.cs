namespace WindowsFormsApplication1
{
    partial class FormClient
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtnumero = new System.Windows.Forms.TextBox();
            this.txttelephone = new System.Windows.Forms.TextBox();
            this.txtprenom = new System.Windows.Forms.TextBox();
            this.txtnom = new System.Windows.Forms.TextBox();
            this.txtemail = new System.Windows.Forms.TextBox();
            this.txtadresse = new System.Windows.Forms.TextBox();
            this.btmodifier = new System.Windows.Forms.Button();
            this.btajouter = new System.Windows.Forms.Button();
            this.btsupprimer = new System.Windows.Forms.Button();
            this.dtlisteclient = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dtlisteclient)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(78, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Numéro :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(329, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Adresse :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(78, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Nom :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(329, 67);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Prénom :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(566, 67);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Téléphone :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(592, 123);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Email :";
            // 
            // txtnumero
            // 
            this.txtnumero.Location = new System.Drawing.Point(147, 64);
            this.txtnumero.Name = "txtnumero";
            this.txtnumero.Size = new System.Drawing.Size(130, 20);
            this.txtnumero.TabIndex = 7;
            this.txtnumero.TextChanged += new System.EventHandler(this.txtnumero_TextChanged);
            // 
            // txttelephone
            // 
            this.txttelephone.Location = new System.Drawing.Point(647, 64);
            this.txttelephone.Name = "txttelephone";
            this.txttelephone.Size = new System.Drawing.Size(130, 20);
            this.txttelephone.TabIndex = 8;
            this.txttelephone.TextChanged += new System.EventHandler(this.txttelephone_TextChanged);
            // 
            // txtprenom
            // 
            this.txtprenom.Location = new System.Drawing.Point(384, 64);
            this.txtprenom.Name = "txtprenom";
            this.txtprenom.Size = new System.Drawing.Size(130, 20);
            this.txtprenom.TabIndex = 9;
            this.txtprenom.TextChanged += new System.EventHandler(this.txtprenom_TextChanged);
            // 
            // txtnom
            // 
            this.txtnom.Location = new System.Drawing.Point(147, 123);
            this.txtnom.Name = "txtnom";
            this.txtnom.Size = new System.Drawing.Size(130, 20);
            this.txtnom.TabIndex = 10;
            this.txtnom.TextChanged += new System.EventHandler(this.txtnom_TextChanged);
            // 
            // txtemail
            // 
            this.txtemail.Location = new System.Drawing.Point(647, 120);
            this.txtemail.Name = "txtemail";
            this.txtemail.Size = new System.Drawing.Size(130, 20);
            this.txtemail.TabIndex = 11;
            this.txtemail.TextChanged += new System.EventHandler(this.txtemail_TextChanged);
            // 
            // txtadresse
            // 
            this.txtadresse.Location = new System.Drawing.Point(384, 120);
            this.txtadresse.Name = "txtadresse";
            this.txtadresse.Size = new System.Drawing.Size(130, 20);
            this.txtadresse.TabIndex = 12;
            this.txtadresse.TextChanged += new System.EventHandler(this.txtadresse_TextChanged);
            // 
            // btmodifier
            // 
            this.btmodifier.Location = new System.Drawing.Point(439, 208);
            this.btmodifier.Name = "btmodifier";
            this.btmodifier.Size = new System.Drawing.Size(75, 23);
            this.btmodifier.TabIndex = 13;
            this.btmodifier.Text = "Modifier";
            this.btmodifier.UseVisualStyleBackColor = true;
            this.btmodifier.Click += new System.EventHandler(this.btmodifier_Click);
            // 
            // btajouter
            // 
            this.btajouter.Location = new System.Drawing.Point(261, 208);
            this.btajouter.Name = "btajouter";
            this.btajouter.Size = new System.Drawing.Size(75, 23);
            this.btajouter.TabIndex = 14;
            this.btajouter.Text = "Ajouter";
            this.btajouter.UseVisualStyleBackColor = true;
            this.btajouter.Click += new System.EventHandler(this.btajouter_Click);
            // 
            // btsupprimer
            // 
            this.btsupprimer.Location = new System.Drawing.Point(647, 208);
            this.btsupprimer.Name = "btsupprimer";
            this.btsupprimer.Size = new System.Drawing.Size(75, 23);
            this.btsupprimer.TabIndex = 15;
            this.btsupprimer.Text = "Supprimer";
            this.btsupprimer.UseVisualStyleBackColor = true;
            this.btsupprimer.Click += new System.EventHandler(this.btsupprimer_Click);
            // 
            // dtlisteclient
            // 
            this.dtlisteclient.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtlisteclient.Location = new System.Drawing.Point(135, 352);
            this.dtlisteclient.Name = "dtlisteclient";
            this.dtlisteclient.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtlisteclient.Size = new System.Drawing.Size(596, 150);
            this.dtlisteclient.TabIndex = 16;
            // 
            // FormClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(880, 595);
            this.Controls.Add(this.dtlisteclient);
            this.Controls.Add(this.btsupprimer);
            this.Controls.Add(this.btajouter);
            this.Controls.Add(this.btmodifier);
            this.Controls.Add(this.txtadresse);
            this.Controls.Add(this.txtemail);
            this.Controls.Add(this.txtnom);
            this.Controls.Add(this.txtprenom);
            this.Controls.Add(this.txttelephone);
            this.Controls.Add(this.txtnumero);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormClient";
            this.Text = "FormClient";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtlisteclient)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtnumero;
        private System.Windows.Forms.TextBox txttelephone;
        private System.Windows.Forms.TextBox txtprenom;
        private System.Windows.Forms.TextBox txtnom;
        private System.Windows.Forms.TextBox txtemail;
        private System.Windows.Forms.TextBox txtadresse;
        private System.Windows.Forms.Button btmodifier;
        private System.Windows.Forms.Button btajouter;
        private System.Windows.Forms.Button btsupprimer;
        private System.Windows.Forms.DataGridView dtlisteclient;
    }
}

