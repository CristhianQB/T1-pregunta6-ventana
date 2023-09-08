namespace T1_pregunta6_ventana
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            button1 = new System.Windows.Forms.Button();
            label1 = new System.Windows.Forms.Label();
            txtb1 = new System.Windows.Forms.TextBox();
            label2 = new System.Windows.Forms.Label();
            lbl = new System.Windows.Forms.Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new System.Drawing.Point(142, 177);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(68, 26);
            button1.TabIndex = 0;
            button1.Text = "Calcular";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label1.Location = new System.Drawing.Point(51, 39);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(121, 20);
            label1.TabIndex = 1;
            label1.Text = "Ingrese el monto";
            // 
            // txtb1
            // 
            txtb1.Location = new System.Drawing.Point(211, 40);
            txtb1.Name = "txtb1";
            txtb1.Size = new System.Drawing.Size(87, 23);
            txtb1.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label2.Location = new System.Drawing.Point(51, 112);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(125, 21);
            label2.TabIndex = 3;
            label2.Text = "El precio final es:";
            // 
            // lbl
            // 
            lbl.AutoSize = true;
            lbl.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lbl.Location = new System.Drawing.Point(199, 112);
            lbl.Name = "lbl";
            lbl.Size = new System.Drawing.Size(28, 21);
            lbl.TabIndex = 4;
            lbl.Text = "00";
            // 
            // Form1
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(415, 450);
            Controls.Add(lbl);
            Controls.Add(label2);
            Controls.Add(txtb1);
            Controls.Add(label1);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtb1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl;
    }
}
