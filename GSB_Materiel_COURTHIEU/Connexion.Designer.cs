namespace GSB_Materiel_LAFAGE
{
    partial class Connexion
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Connexion));
            this.id_txt = new System.Windows.Forms.TextBox();
            this.mdp_txt = new System.Windows.Forms.TextBox();
            this.admin_rbtn = new System.Windows.Forms.RadioButton();
            this.visit_rbtn = new System.Windows.Forms.RadioButton();
            this.tech_rbtn = new System.Windows.Forms.RadioButton();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.date_lbl = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.connexion_btn = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // id_txt
            // 
            this.id_txt.Location = new System.Drawing.Point(530, 178);
            this.id_txt.Name = "id_txt";
            this.id_txt.Size = new System.Drawing.Size(100, 20);
            this.id_txt.TabIndex = 3;
            this.id_txt.TextChanged += new System.EventHandler(this.id_txt_TextChanged);
            // 
            // mdp_txt
            // 
            this.mdp_txt.Location = new System.Drawing.Point(530, 282);
            this.mdp_txt.Name = "mdp_txt";
            this.mdp_txt.Size = new System.Drawing.Size(100, 20);
            this.mdp_txt.TabIndex = 4;
            this.mdp_txt.UseSystemPasswordChar = true;
            // 
            // admin_rbtn
            // 
            this.admin_rbtn.AutoSize = true;
            this.admin_rbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.admin_rbtn.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.admin_rbtn.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.admin_rbtn.Location = new System.Drawing.Point(321, 434);
            this.admin_rbtn.Name = "admin_rbtn";
            this.admin_rbtn.Size = new System.Drawing.Size(119, 21);
            this.admin_rbtn.TabIndex = 5;
            this.admin_rbtn.TabStop = true;
            this.admin_rbtn.Text = "Administrateur";
            this.admin_rbtn.UseVisualStyleBackColor = true;
            // 
            // visit_rbtn
            // 
            this.visit_rbtn.AutoSize = true;
            this.visit_rbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.visit_rbtn.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.visit_rbtn.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.visit_rbtn.Location = new System.Drawing.Point(530, 434);
            this.visit_rbtn.Name = "visit_rbtn";
            this.visit_rbtn.Size = new System.Drawing.Size(71, 21);
            this.visit_rbtn.TabIndex = 6;
            this.visit_rbtn.TabStop = true;
            this.visit_rbtn.Text = "Visiteur";
            this.visit_rbtn.UseVisualStyleBackColor = true;
            // 
            // tech_rbtn
            // 
            this.tech_rbtn.AutoSize = true;
            this.tech_rbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tech_rbtn.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tech_rbtn.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.tech_rbtn.Location = new System.Drawing.Point(703, 434);
            this.tech_rbtn.Name = "tech_rbtn";
            this.tech_rbtn.Size = new System.Drawing.Size(93, 21);
            this.tech_rbtn.TabIndex = 7;
            this.tech_rbtn.TabStop = true;
            this.tech_rbtn.Text = "Technicien";
            this.tech_rbtn.UseVisualStyleBackColor = true;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(418, 269);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(52, 50);
            this.pictureBox2.TabIndex = 9;
            this.pictureBox2.TabStop = false;
            // 
            // date_lbl
            // 
            this.date_lbl.AutoSize = true;
            this.date_lbl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(237)))), ((int)(((byte)(253)))));
            this.date_lbl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.date_lbl.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.date_lbl.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.date_lbl.Location = new System.Drawing.Point(3, 0);
            this.date_lbl.Name = "date_lbl";
            this.date_lbl.Size = new System.Drawing.Size(74, 24);
            this.date_lbl.TabIndex = 10;
            this.date_lbl.Text = "label1";
            this.date_lbl.Click += new System.EventHandler(this.date_lbl_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.label1.Location = new System.Drawing.Point(13, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 24);
            this.label1.TabIndex = 11;
            this.label1.Text = "Je suis";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(418, 162);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(56, 48);
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // connexion_btn
            // 
            this.connexion_btn.BackColor = System.Drawing.Color.White;
            this.connexion_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.connexion_btn.FlatAppearance.BorderSize = 0;
            this.connexion_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.connexion_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.connexion_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.connexion_btn.ForeColor = System.Drawing.Color.Transparent;
            this.connexion_btn.Image = ((System.Drawing.Image)(resources.GetObject("connexion_btn.Image")));
            this.connexion_btn.Location = new System.Drawing.Point(523, 507);
            this.connexion_btn.Name = "connexion_btn";
            this.connexion_btn.Size = new System.Drawing.Size(68, 54);
            this.connexion_btn.TabIndex = 13;
            this.connexion_btn.UseVisualStyleBackColor = false;
            this.connexion_btn.Click += new System.EventHandler(this.connexion_btn_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(237)))), ((int)(((byte)(253)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1140, 17);
            this.panel2.TabIndex = 15;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(237)))), ((int)(((byte)(253)))));
            this.panel3.Controls.Add(this.pictureBox3);
            this.panel3.Location = new System.Drawing.Point(35, 12);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(189, 173);
            this.panel3.TabIndex = 16;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(12, 34);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(165, 98);
            this.pictureBox3.TabIndex = 0;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(120)))), ((int)(((byte)(120)))));
            this.label2.Location = new System.Drawing.Point(413, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(248, 30);
            this.label2.TabIndex = 17;
            this.label2.Text = "Page de connexion";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(237)))), ((int)(((byte)(253)))));
            this.panel4.Controls.Add(this.label1);
            this.panel4.Location = new System.Drawing.Point(358, 363);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(99, 31);
            this.panel4.TabIndex = 18;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(237)))), ((int)(((byte)(253)))));
            this.panel5.Controls.Add(this.date_lbl);
            this.panel5.Location = new System.Drawing.Point(870, 23);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(270, 29);
            this.panel5.TabIndex = 19;
            // 
            // Connexion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1140, 645);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.connexion_btn);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.tech_rbtn);
            this.Controls.Add(this.visit_rbtn);
            this.Controls.Add(this.admin_rbtn);
            this.Controls.Add(this.mdp_txt);
            this.Controls.Add(this.id_txt);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Connexion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Connexion";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Connexion_FormClosing);
            this.Load += new System.EventHandler(this.Connexion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox id_txt;
        private System.Windows.Forms.TextBox mdp_txt;
        private System.Windows.Forms.RadioButton admin_rbtn;
        private System.Windows.Forms.RadioButton visit_rbtn;
        private System.Windows.Forms.RadioButton tech_rbtn;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label date_lbl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button connexion_btn;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
    }
}

