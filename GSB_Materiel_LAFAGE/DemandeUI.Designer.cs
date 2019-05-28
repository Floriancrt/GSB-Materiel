namespace GSB_Materiel_LAFAGE
{
    partial class DemandeUI
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

        #region Code généré par le Concepteur de composants

        /// <summary> 
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas 
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.ajouter_demande_btn = new System.Windows.Forms.Button();
            this.demande_intervention_txt = new System.Windows.Forms.TextBox();
            this.demande_urgence_txt = new System.Windows.Forms.TextBox();
            this.demande_objet_txt = new System.Windows.Forms.RichTextBox();
            this.demande_materiel_txt = new System.Windows.Forms.TextBox();
            this.demande_ticket_txt = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(251, 3);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(492, 416);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.ajouter_demande_btn);
            this.tabPage1.Controls.Add(this.demande_intervention_txt);
            this.tabPage1.Controls.Add(this.demande_urgence_txt);
            this.tabPage1.Controls.Add(this.demande_objet_txt);
            this.tabPage1.Controls.Add(this.demande_materiel_txt);
            this.tabPage1.Controls.Add(this.demande_ticket_txt);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 26);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(484, 386);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Nouvelle demande";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // ajouter_demande_btn
            // 
            this.ajouter_demande_btn.Location = new System.Drawing.Point(20, 316);
            this.ajouter_demande_btn.Name = "ajouter_demande_btn";
            this.ajouter_demande_btn.Size = new System.Drawing.Size(75, 23);
            this.ajouter_demande_btn.TabIndex = 14;
            this.ajouter_demande_btn.Text = "Valider";
            this.ajouter_demande_btn.UseVisualStyleBackColor = true;
            // 
            // demande_intervention_txt
            // 
            this.demande_intervention_txt.Location = new System.Drawing.Point(149, 250);
            this.demande_intervention_txt.Name = "demande_intervention_txt";
            this.demande_intervention_txt.Size = new System.Drawing.Size(100, 23);
            this.demande_intervention_txt.TabIndex = 13;
            // 
            // demande_urgence_txt
            // 
            this.demande_urgence_txt.Location = new System.Drawing.Point(86, 207);
            this.demande_urgence_txt.Name = "demande_urgence_txt";
            this.demande_urgence_txt.Size = new System.Drawing.Size(100, 23);
            this.demande_urgence_txt.TabIndex = 12;
            // 
            // demande_objet_txt
            // 
            this.demande_objet_txt.Location = new System.Drawing.Point(86, 92);
            this.demande_objet_txt.Name = "demande_objet_txt";
            this.demande_objet_txt.Size = new System.Drawing.Size(300, 96);
            this.demande_objet_txt.TabIndex = 11;
            this.demande_objet_txt.Text = "";
            // 
            // demande_materiel_txt
            // 
            this.demande_materiel_txt.Location = new System.Drawing.Point(86, 62);
            this.demande_materiel_txt.Name = "demande_materiel_txt";
            this.demande_materiel_txt.Size = new System.Drawing.Size(100, 23);
            this.demande_materiel_txt.TabIndex = 10;
            // 
            // demande_ticket_txt
            // 
            this.demande_ticket_txt.Location = new System.Drawing.Point(85, 19);
            this.demande_ticket_txt.Name = "demande_ticket_txt";
            this.demande_ticket_txt.Size = new System.Drawing.Size(100, 23);
            this.demande_ticket_txt.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(17, 253);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(129, 17);
            this.label6.TabIndex = 5;
            this.label6.Text = "Type d\'intervention";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 210);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Urgence";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Objet";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Materiel";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ticket";
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 26);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(484, 386);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Consulter";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // DemandeUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tabControl1);
            this.Name = "DemandeUI";
            this.Size = new System.Drawing.Size(889, 510);
            this.Load += new System.EventHandler(this.DemandeUI_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button ajouter_demande_btn;
        private System.Windows.Forms.TextBox demande_intervention_txt;
        private System.Windows.Forms.TextBox demande_urgence_txt;
        private System.Windows.Forms.RichTextBox demande_objet_txt;
        private System.Windows.Forms.TextBox demande_materiel_txt;
        private System.Windows.Forms.TextBox demande_ticket_txt;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage2;
    }
}
