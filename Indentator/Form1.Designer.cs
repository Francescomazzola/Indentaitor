namespace Indentator
{
    partial class Form1
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.codeTBEditor = new System.Windows.Forms.TextBox();
            this.indenterButton = new System.Windows.Forms.Button();
            this.selectfileButton = new System.Windows.Forms.Button();
            this.pathTB = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // codeTBEditor
            // 
            this.codeTBEditor.Location = new System.Drawing.Point(12, 59);
            this.codeTBEditor.Multiline = true;
            this.codeTBEditor.Name = "codeTBEditor";
            this.codeTBEditor.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.codeTBEditor.Size = new System.Drawing.Size(554, 200);
            this.codeTBEditor.TabIndex = 0;
            // 
            // indenterButton
            // 
            this.indenterButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.indenterButton.Location = new System.Drawing.Point(12, 279);
            this.indenterButton.Name = "indenterButton";
            this.indenterButton.Size = new System.Drawing.Size(554, 94);
            this.indenterButton.TabIndex = 1;
            this.indenterButton.Text = "indent";
            this.indenterButton.UseVisualStyleBackColor = true;
            this.indenterButton.Click += new System.EventHandler(this.indenterButton_Click);
            // 
            // selectfileButton
            // 
            this.selectfileButton.Location = new System.Drawing.Point(12, 12);
            this.selectfileButton.Name = "selectfileButton";
            this.selectfileButton.Size = new System.Drawing.Size(75, 23);
            this.selectfileButton.TabIndex = 2;
            this.selectfileButton.Text = "select file";
            this.selectfileButton.UseVisualStyleBackColor = true;
            this.selectfileButton.Click += new System.EventHandler(this.selectfileButton_Click);
            // 
            // pathTB
            // 
            this.pathTB.Enabled = false;
            this.pathTB.Location = new System.Drawing.Point(93, 12);
            this.pathTB.Name = "pathTB";
            this.pathTB.Size = new System.Drawing.Size(473, 20);
            this.pathTB.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(578, 385);
            this.Controls.Add(this.pathTB);
            this.Controls.Add(this.selectfileButton);
            this.Controls.Add(this.indenterButton);
            this.Controls.Add(this.codeTBEditor);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox codeTBEditor;
        private System.Windows.Forms.Button indenterButton;
        private System.Windows.Forms.Button selectfileButton;
        private System.Windows.Forms.TextBox pathTB;
    }
}

