using System;

namespace gestion_rendez_vous
{
    partial class frmMDI
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.aCTIONToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pARAMETREToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pATIENTToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mEDECINToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aCTIONToolStripMenuItem,
            this.pARAMETREToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(902, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // aCTIONToolStripMenuItem
            // 
            this.aCTIONToolStripMenuItem.Name = "aCTIONToolStripMenuItem";
            this.aCTIONToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
            this.aCTIONToolStripMenuItem.Text = "ACTION";
            // 
            // pARAMETREToolStripMenuItem
            // 
            this.pARAMETREToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pATIENTToolStripMenuItem,
            this.mEDECINToolStripMenuItem});
            this.pARAMETREToolStripMenuItem.Name = "pARAMETREToolStripMenuItem";
            this.pARAMETREToolStripMenuItem.Size = new System.Drawing.Size(84, 20);
            this.pARAMETREToolStripMenuItem.Text = "PARAMETRE";
            // 
            // pATIENTToolStripMenuItem
            // 
            this.pATIENTToolStripMenuItem.Name = "pATIENTToolStripMenuItem";
            this.pATIENTToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.pATIENTToolStripMenuItem.Text = "PATIENT";
            this.pATIENTToolStripMenuItem.Click += new System.EventHandler(this.pATIENTToolStripMenuItem_Click);
            // 
            // mEDECINToolStripMenuItem
            // 
            this.mEDECINToolStripMenuItem.Name = "mEDECINToolStripMenuItem";
            this.mEDECINToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.mEDECINToolStripMenuItem.Text = "MEDECIN";
            this.mEDECINToolStripMenuItem.Click += new System.EventHandler(this.mEDECINToolStripMenuItem_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Bookman Old Style", 72F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(339, 433);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(728, 111);
            this.label5.TabIndex = 76;
            this.label5.Text = "Clinique Amitie";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bookman Old Style", 48F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(527, 170);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(353, 71);
            this.label1.TabIndex = 77;
            this.label1.Text = "Bienvenue";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bookman Old Style", 48F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(643, 313);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(152, 71);
            this.label2.TabIndex = 78;
            this.label2.Text = "A la";
            // 
            // frmMDI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(902, 530);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMDI";
            this.Text = "Form1";
            this.TransparencyKey = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Load += new System.EventHandler(this.frmMDI_Load_1);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem aCTIONToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pARAMETREToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pATIENTToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mEDECINToolStripMenuItem;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

