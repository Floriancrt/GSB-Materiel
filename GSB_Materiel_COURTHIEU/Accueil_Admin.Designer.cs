namespace GSB_Materiel_LAFAGE
{
    partial class Accueil_Admin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Accueil_Admin));
            this.actualiser_visit_btn = new System.Windows.Forms.Button();
            this.panelbutton = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.visiteurUI1 = new GSB_Materiel_LAFAGE.VisiteurUI();
            this.technicienUI1 = new GSB_Materiel_LAFAGE.TechnicienUI();
            this.demandeUI1 = new GSB_Materiel_LAFAGE.DemandeUI();
            this.panelbutton.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // actualiser_visit_btn
            // 
            this.actualiser_visit_btn.BackColor = System.Drawing.Color.White;
            this.actualiser_visit_btn.Image = ((System.Drawing.Image)(resources.GetObject("actualiser_visit_btn.Image")));
            this.actualiser_visit_btn.Location = new System.Drawing.Point(12, 555);
            this.actualiser_visit_btn.Name = "actualiser_visit_btn";
            this.actualiser_visit_btn.Size = new System.Drawing.Size(48, 48);
            this.actualiser_visit_btn.TabIndex = 7;
            this.actualiser_visit_btn.UseVisualStyleBackColor = false;
            this.actualiser_visit_btn.Click += new System.EventHandler(this.actualiser_visit_btn_Click);
            // 
            // panelbutton
            // 
            this.panelbutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.panelbutton.Controls.Add(this.panel6);
            this.panelbutton.Controls.Add(this.button4);
            this.panelbutton.Controls.Add(this.button3);
            this.panelbutton.Controls.Add(this.button2);
            this.panelbutton.Controls.Add(this.button1);
            this.panelbutton.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelbutton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panelbutton.Location = new System.Drawing.Point(0, 0);
            this.panelbutton.Name = "panelbutton";
            this.panelbutton.Size = new System.Drawing.Size(200, 645);
            this.panelbutton.TabIndex = 15;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(237)))), ((int)(((byte)(253)))));
            this.panel6.Location = new System.Drawing.Point(0, 198);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(10, 49);
            this.panel6.TabIndex = 4;
            // 
            // button4
            // 
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(237)))), ((int)(((byte)(253)))));
            this.button4.Image = ((System.Drawing.Image)(resources.GetObject("button4.Image")));
            this.button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button4.Location = new System.Drawing.Point(12, 363);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(188, 49);
            this.button4.TabIndex = 3;
            this.button4.Text = "      Matériels";
            this.button4.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(237)))), ((int)(((byte)(253)))));
            this.button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.Location = new System.Drawing.Point(12, 308);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(188, 49);
            this.button3.TabIndex = 2;
            this.button3.Text = "      Demandes";
            this.button3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(237)))), ((int)(((byte)(253)))));
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(12, 253);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(188, 49);
            this.button2.TabIndex = 1;
            this.button2.Text = "      Technicien";
            this.button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(237)))), ((int)(((byte)(253)))));
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(12, 198);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(188, 49);
            this.button1.TabIndex = 0;
            this.button1.Text = "      Visiteur";
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(237)))), ((int)(((byte)(253)))));
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(200, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(940, 17);
            this.panel2.TabIndex = 16;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(237)))), ((int)(((byte)(253)))));
            this.panel4.Location = new System.Drawing.Point(655, 23);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(200, 45);
            this.panel4.TabIndex = 18;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(237)))), ((int)(((byte)(253)))));
            this.panel3.Controls.Add(this.pictureBox3);
            this.panel3.Location = new System.Drawing.Point(223, 12);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(189, 173);
            this.panel3.TabIndex = 17;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(12, 34);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(165, 98);
            this.pictureBox3.TabIndex = 0;
            this.pictureBox3.TabStop = false;
            // 
            // visiteurUI1
            // 
            this.visiteurUI1.Location = new System.Drawing.Point(223, 191);
            this.visiteurUI1.Name = "visiteurUI1";
            this.visiteurUI1.Size = new System.Drawing.Size(889, 529);
            this.visiteurUI1.TabIndex = 18;
            // 
            // technicienUI1
            // 
            this.technicienUI1.Location = new System.Drawing.Point(223, 191);
            this.technicienUI1.Name = "technicienUI1";
            this.technicienUI1.Size = new System.Drawing.Size(889, 529);
            this.technicienUI1.TabIndex = 19;
            // 
            // demandeUI1
            // 
            this.demandeUI1.Location = new System.Drawing.Point(223, 191);
            this.demandeUI1.Name = "demandeUI1";
            this.demandeUI1.Size = new System.Drawing.Size(899, 529);
            this.demandeUI1.TabIndex = 20;
            // 
            // Accueil_Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1140, 645);
            this.Controls.Add(this.demandeUI1);
            this.Controls.Add(this.technicienUI1);
            this.Controls.Add(this.visiteurUI1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panelbutton);
            this.Controls.Add(this.actualiser_visit_btn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Accueil_Admin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Accueil";
            this.Load += new System.EventHandler(this.Accueil_Admin_Load);
            this.panelbutton.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button actualiser_visit_btn;
        private System.Windows.Forms.Panel panelbutton;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Panel panel6;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private VisiteurUI visiteurUI1;
        private TechnicienUI technicienUI1;
        private DemandeUI demandeUI1;
    }
}