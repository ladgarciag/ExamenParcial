
namespace ExamenParcial
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnInsCab = new System.Windows.Forms.Button();
            this.lview = new System.Windows.Forms.ListView();
            this.txtbox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnInsCab
            // 
            this.btnInsCab.Location = new System.Drawing.Point(504, 90);
            this.btnInsCab.Name = "btnInsCab";
            this.btnInsCab.Size = new System.Drawing.Size(75, 23);
            this.btnInsCab.TabIndex = 0;
            this.btnInsCab.Text = "Insertar";
            this.btnInsCab.UseVisualStyleBackColor = true;
            this.btnInsCab.Click += new System.EventHandler(this.btnInsCab_Click);
            // 
            // lview
            // 
            this.lview.HideSelection = false;
            this.lview.Location = new System.Drawing.Point(28, 304);
            this.lview.Name = "lview";
            this.lview.Size = new System.Drawing.Size(572, 155);
            this.lview.TabIndex = 1;
            this.lview.UseCompatibleStateImageBehavior = false;
            // 
            // txtbox
            // 
            this.txtbox.Location = new System.Drawing.Point(28, 93);
            this.txtbox.Name = "txtbox";
            this.txtbox.Size = new System.Drawing.Size(100, 20);
            this.txtbox.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(53, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "LSECC";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(649, 496);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtbox);
            this.Controls.Add(this.lview);
            this.Controls.Add(this.btnInsCab);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnInsCab;
        private System.Windows.Forms.ListView lview;
        private System.Windows.Forms.TextBox txtbox;
        private System.Windows.Forms.Label label1;
    }
}

