namespace DialoguesModaux
{
    partial class DialModal
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
            this.gbIdentification = new System.Windows.Forms.GroupBox();
            this.textMDP = new System.Windows.Forms.TextBox();
            this.textID = new System.Windows.Forms.TextBox();
            this.MDP = new System.Windows.Forms.Label();
            this.Identifiant = new System.Windows.Forms.Label();
            this.Connexion = new System.Windows.Forms.Button();
            this.Quitter = new System.Windows.Forms.Button();
            this.buttonTest = new System.Windows.Forms.Button();
            this.gbIdentification.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbIdentification
            // 
            this.gbIdentification.Controls.Add(this.textMDP);
            this.gbIdentification.Controls.Add(this.textID);
            this.gbIdentification.Controls.Add(this.MDP);
            this.gbIdentification.Controls.Add(this.Identifiant);
            this.gbIdentification.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbIdentification.ForeColor = System.Drawing.SystemColors.Highlight;
            this.gbIdentification.Location = new System.Drawing.Point(66, 85);
            this.gbIdentification.Name = "gbIdentification";
            this.gbIdentification.Size = new System.Drawing.Size(369, 228);
            this.gbIdentification.TabIndex = 0;
            this.gbIdentification.TabStop = false;
            this.gbIdentification.Text = "Identification";
            // 
            // textMDP
            // 
            this.textMDP.Location = new System.Drawing.Point(168, 115);
            this.textMDP.Name = "textMDP";
            this.textMDP.Size = new System.Drawing.Size(137, 24);
            this.textMDP.TabIndex = 3;
            this.textMDP.Validating += new System.ComponentModel.CancelEventHandler(this.EventValidatingMDP);
            // 
            // textID
            // 
            this.textID.Location = new System.Drawing.Point(168, 56);
            this.textID.Name = "textID";
            this.textID.Size = new System.Drawing.Size(137, 24);
            this.textID.TabIndex = 2;
            this.textID.Validating += new System.ComponentModel.CancelEventHandler(this.EventValidatingID);
            // 
            // MDP
            // 
            this.MDP.AutoSize = true;
            this.MDP.ForeColor = System.Drawing.SystemColors.Desktop;
            this.MDP.Location = new System.Drawing.Point(26, 115);
            this.MDP.Name = "MDP";
            this.MDP.Size = new System.Drawing.Size(98, 18);
            this.MDP.TabIndex = 1;
            this.MDP.Text = "Mot de passe";
            // 
            // Identifiant
            // 
            this.Identifiant.AutoSize = true;
            this.Identifiant.ForeColor = System.Drawing.SystemColors.Desktop;
            this.Identifiant.Location = new System.Drawing.Point(23, 56);
            this.Identifiant.Name = "Identifiant";
            this.Identifiant.Size = new System.Drawing.Size(69, 18);
            this.Identifiant.TabIndex = 0;
            this.Identifiant.Text = "Identifiant";
            // 
            // Connexion
            // 
            this.Connexion.CausesValidation = false;
            this.Connexion.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.Connexion.Location = new System.Drawing.Point(95, 374);
            this.Connexion.Name = "Connexion";
            this.Connexion.Size = new System.Drawing.Size(75, 23);
            this.Connexion.TabIndex = 1;
            this.Connexion.Text = "Connexion";
            this.Connexion.UseVisualStyleBackColor = true;
            this.Connexion.Click += new System.EventHandler(this.EventClickConnect);
            // 
            // Quitter
            // 
            this.Quitter.CausesValidation = false;
            this.Quitter.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Quitter.Location = new System.Drawing.Point(296, 374);
            this.Quitter.Name = "Quitter";
            this.Quitter.Size = new System.Drawing.Size(75, 23);
            this.Quitter.TabIndex = 2;
            this.Quitter.Text = "Quitter";
            this.Quitter.UseVisualStyleBackColor = true;
            this.Quitter.Click += new System.EventHandler(this.EventClickQuit);
            // 
            // buttonTest
            // 
            this.buttonTest.CausesValidation = false;
            this.buttonTest.Location = new System.Drawing.Point(644, 375);
            this.buttonTest.Name = "buttonTest";
            this.buttonTest.Size = new System.Drawing.Size(75, 23);
            this.buttonTest.TabIndex = 3;
            this.buttonTest.Text = "Test";
            this.buttonTest.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonTest.UseVisualStyleBackColor = true;
            this.buttonTest.Click += new System.EventHandler(this.EventClickTest);
            // 
            // DialModal
            // 
            this.AcceptButton = this.Connexion;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.Quitter;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonTest);
            this.Controls.Add(this.Quitter);
            this.Controls.Add(this.Connexion);
            this.Controls.Add(this.gbIdentification);
            this.Name = "DialModal";
            this.Text = "DialogueModal";
            this.gbIdentification.ResumeLayout(false);
            this.gbIdentification.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbIdentification;
        private System.Windows.Forms.TextBox textMDP;
        private System.Windows.Forms.TextBox textID;
        private System.Windows.Forms.Label MDP;
        private System.Windows.Forms.Label Identifiant;
        private System.Windows.Forms.Button Connexion;
        private System.Windows.Forms.Button Quitter;
        private System.Windows.Forms.Button buttonTest;
    }
}