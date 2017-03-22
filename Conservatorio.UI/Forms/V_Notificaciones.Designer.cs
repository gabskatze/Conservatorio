namespace Conservatorio.UI.Forms
{
    partial class V_Notificaciones
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(V_Notificaciones));
            this.btnEnviar = new System.Windows.Forms.Button();
            this.lblDestinatario = new System.Windows.Forms.Label();
            this.cbDestinatario = new System.Windows.Forms.ComboBox();
            this.tbxMensaje = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnEnviar
            // 
            this.btnEnviar.Image = ((System.Drawing.Image)(resources.GetObject("btnEnviar.Image")));
            this.btnEnviar.Location = new System.Drawing.Point(274, 332);
            this.btnEnviar.Name = "btnEnviar";
            this.btnEnviar.Size = new System.Drawing.Size(70, 70);
            this.btnEnviar.TabIndex = 0;
            this.btnEnviar.Text = "Enviar";
            this.btnEnviar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnEnviar.UseVisualStyleBackColor = true;
            // 
            // lblDestinatario
            // 
            this.lblDestinatario.AutoSize = true;
            this.lblDestinatario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDestinatario.Location = new System.Drawing.Point(30, 44);
            this.lblDestinatario.Name = "lblDestinatario";
            this.lblDestinatario.Size = new System.Drawing.Size(80, 16);
            this.lblDestinatario.TabIndex = 1;
            this.lblDestinatario.Text = "Destinatario";
            // 
            // cbDestinatario
            // 
            this.cbDestinatario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbDestinatario.FormattingEnabled = true;
            this.cbDestinatario.Location = new System.Drawing.Point(116, 36);
            this.cbDestinatario.Name = "cbDestinatario";
            this.cbDestinatario.Size = new System.Drawing.Size(166, 24);
            this.cbDestinatario.TabIndex = 6;
            // 
            // tbxMensaje
            // 
            this.tbxMensaje.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxMensaje.Location = new System.Drawing.Point(33, 85);
            this.tbxMensaje.Multiline = true;
            this.tbxMensaje.Name = "tbxMensaje";
            this.tbxMensaje.Size = new System.Drawing.Size(549, 230);
            this.tbxMensaje.TabIndex = 7;
            // 
            // V_Notificaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(618, 426);
            this.Controls.Add(this.tbxMensaje);
            this.Controls.Add(this.cbDestinatario);
            this.Controls.Add(this.lblDestinatario);
            this.Controls.Add(this.btnEnviar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "V_Notificaciones";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Notificaciones";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEnviar;
        private System.Windows.Forms.Label lblDestinatario;
        private System.Windows.Forms.ComboBox cbDestinatario;
        private System.Windows.Forms.TextBox tbxMensaje;
    }
}