namespace Uso_del_formulario_MDI
{
    partial class FormularioHijo
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
            bSumar = new Button();
            lbl_msg = new Label();
            tbDato = new TextBox();
            tbDato1 = new TextBox();
            lblmsg = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // bSumar
            // 
            bSumar.Location = new Point(332, 104);
            bSumar.Name = "bSumar";
            bSumar.Size = new Size(75, 23);
            bSumar.TabIndex = 3;
            bSumar.Text = "Sumar";
            bSumar.UseVisualStyleBackColor = true;
            bSumar.Click += bSumar_Click;
            // 
            // lbl_msg
            // 
            lbl_msg.AutoSize = true;
            lbl_msg.Font = new Font("Arial", 11F);
            lbl_msg.Location = new Point(32, 88);
            lbl_msg.Name = "lbl_msg";
            lbl_msg.Size = new Size(134, 17);
            lbl_msg.TabIndex = 0;
            lbl_msg.Text = "Ingresa un número:";
            lbl_msg.Click += lbl_msg_Click;
            // 
            // tbDato
            // 
            tbDato.Location = new Point(172, 83);
            tbDato.MaxLength = 34000;
            tbDato.Name = "tbDato";
            tbDato.Size = new Size(100, 23);
            tbDato.TabIndex = 1;
            tbDato.TextAlign = HorizontalAlignment.Center;
            tbDato.TextChanged += tbDato_TextChanged;
            // 
            // tbDato1
            // 
            tbDato1.Location = new Point(172, 121);
            tbDato1.Name = "tbDato1";
            tbDato1.Size = new Size(100, 23);
            tbDato1.TabIndex = 2;
            tbDato1.TextAlign = HorizontalAlignment.Center;
            tbDato1.TextChanged += tbDato1_TextChanged;
            // 
            // lblmsg
            // 
            lblmsg.AutoSize = true;
            lblmsg.Font = new Font("Arial", 11F);
            lblmsg.Location = new Point(32, 126);
            lblmsg.Name = "lblmsg";
            lblmsg.Size = new Size(134, 17);
            lblmsg.TabIndex = 0;
            lblmsg.Text = "Ingresa un número:";
            lblmsg.Click += lblmsg_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 20F);
            label1.Location = new Point(181, 18);
            label1.Name = "label1";
            label1.Size = new Size(84, 32);
            label1.TabIndex = 4;
            label1.Text = "Suma";
            // 
            // FormularioHijo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(439, 192);
            Controls.Add(label1);
            Controls.Add(tbDato1);
            Controls.Add(lblmsg);
            Controls.Add(tbDato);
            Controls.Add(lbl_msg);
            Controls.Add(bSumar);
            Name = "FormularioHijo";
            Text = "Formulario Hijo";
            Load += FormularioHijo_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button bSumar;
        private Label lbl_msg;
        private TextBox tbDato;
        private TextBox tbDato1;
        private Label lblmsg;
        private Label label1;
    }
}