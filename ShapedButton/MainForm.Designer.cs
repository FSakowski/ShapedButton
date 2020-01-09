namespace ShapedButton
{
    partial class MainForm
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.shapedButton3 = new ShapedButton();
            this.shapedButton2 = new ShapedButton();
            this.shapedButton1 = new ShapedButton();
            this.SuspendLayout();
            // 
            // shapedButton3
            // 
            this.shapedButton3.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.shapedButton3.ForeColor = System.Drawing.Color.White;
            this.shapedButton3.Location = new System.Drawing.Point(84, 176);
            this.shapedButton3.Name = "shapedButton3";
            this.shapedButton3.ShapeColor = System.Drawing.Color.DarkOrchid;
            this.shapedButton3.Size = new System.Drawing.Size(120, 40);
            this.shapedButton3.TabIndex = 2;
            this.shapedButton3.Text = "Press me";
            this.shapedButton3.UseVisualStyleBackColor = true;
            this.shapedButton3.Click += new System.EventHandler(this.shapedButton_Click);
            // 
            // shapedButton2
            // 
            this.shapedButton2.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.shapedButton2.ForeColor = System.Drawing.Color.White;
            this.shapedButton2.Location = new System.Drawing.Point(84, 118);
            this.shapedButton2.Name = "shapedButton2";
            this.shapedButton2.ShapeColor = System.Drawing.Color.Green;
            this.shapedButton2.Size = new System.Drawing.Size(120, 40);
            this.shapedButton2.TabIndex = 1;
            this.shapedButton2.Text = "Press me";
            this.shapedButton2.UseVisualStyleBackColor = true;
            this.shapedButton2.Click += new System.EventHandler(this.shapedButton_Click);
            // 
            // shapedButton1
            // 
            this.shapedButton1.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.shapedButton1.Location = new System.Drawing.Point(84, 58);
            this.shapedButton1.Name = "shapedButton1";
            this.shapedButton1.ShapeColor = System.Drawing.Color.Red;
            this.shapedButton1.Size = new System.Drawing.Size(120, 40);
            this.shapedButton1.TabIndex = 0;
            this.shapedButton1.Text = "Press me";
            this.shapedButton1.UseVisualStyleBackColor = true;
            this.shapedButton1.Click += new System.EventHandler(this.shapedButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(315, 318);
            this.Controls.Add(this.shapedButton3);
            this.Controls.Add(this.shapedButton2);
            this.Controls.Add(this.shapedButton1);
            this.Name = "MainForm";
            this.Text = "ShapedButton sample";
            this.ResumeLayout(false);

        }

        #endregion

        private ShapedButton shapedButton1;
        private ShapedButton shapedButton2;
        private ShapedButton shapedButton3;
    }
}

