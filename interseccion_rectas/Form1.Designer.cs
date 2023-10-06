namespace interseccion_rectas
{
    partial class interfas
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
            System.Windows.Forms.Label pendiente_intercepto;
            System.Windows.Forms.Label punto_pendiente;
            this.lbl_ec1 = new System.Windows.Forms.Label();
            this.lbl_ec2 = new System.Windows.Forms.Label();
            this.ec_1 = new System.Windows.Forms.TextBox();
            this.ec_2 = new System.Windows.Forms.TextBox();
            this.Btn_calcular_f1 = new System.Windows.Forms.Button();
            this.lbl_respuesta = new System.Windows.Forms.Label();
            this.btn_calcular_f2 = new System.Windows.Forms.Button();
            this.ecu_2 = new System.Windows.Forms.TextBox();
            this.ecu_1 = new System.Windows.Forms.TextBox();
            this.lbl_ecu2 = new System.Windows.Forms.Label();
            this.lbl_ecu1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            pendiente_intercepto = new System.Windows.Forms.Label();
            punto_pendiente = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_ec1
            // 
            this.lbl_ec1.AutoSize = true;
            this.lbl_ec1.Location = new System.Drawing.Point(12, 107);
            this.lbl_ec1.Name = "lbl_ec1";
            this.lbl_ec1.Size = new System.Drawing.Size(136, 13);
            this.lbl_ec1.TabIndex = 0;
            this.lbl_ec1.Text = "ingresa la priemra ecuacion";
            // 
            // lbl_ec2
            // 
            this.lbl_ec2.AutoSize = true;
            this.lbl_ec2.Location = new System.Drawing.Point(5, 139);
            this.lbl_ec2.Name = "lbl_ec2";
            this.lbl_ec2.Size = new System.Drawing.Size(143, 13);
            this.lbl_ec2.TabIndex = 1;
            this.lbl_ec2.Text = "ingresa la segunda ecuacion";
            // 
            // ec_1
            // 
            this.ec_1.Location = new System.Drawing.Point(168, 107);
            this.ec_1.Name = "ec_1";
            this.ec_1.Size = new System.Drawing.Size(165, 20);
            this.ec_1.TabIndex = 2;
            // 
            // ec_2
            // 
            this.ec_2.Location = new System.Drawing.Point(168, 136);
            this.ec_2.Name = "ec_2";
            this.ec_2.Size = new System.Drawing.Size(165, 20);
            this.ec_2.TabIndex = 3;
            // 
            // Btn_calcular_f1
            // 
            this.Btn_calcular_f1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Btn_calcular_f1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Btn_calcular_f1.Location = new System.Drawing.Point(101, 182);
            this.Btn_calcular_f1.Name = "Btn_calcular_f1";
            this.Btn_calcular_f1.Size = new System.Drawing.Size(156, 54);
            this.Btn_calcular_f1.TabIndex = 4;
            this.Btn_calcular_f1.Text = "Calcular";
            this.Btn_calcular_f1.UseVisualStyleBackColor = false;
            this.Btn_calcular_f1.Click += new System.EventHandler(this.Btn_calcular_f1_Click);
            // 
            // lbl_respuesta
            // 
            this.lbl_respuesta.AutoSize = true;
            this.lbl_respuesta.Font = new System.Drawing.Font("Cooper Black", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_respuesta.ForeColor = System.Drawing.Color.Black;
            this.lbl_respuesta.Location = new System.Drawing.Point(97, 308);
            this.lbl_respuesta.Name = "lbl_respuesta";
            this.lbl_respuesta.Size = new System.Drawing.Size(0, 21);
            this.lbl_respuesta.TabIndex = 5;
            // 
            // pendiente_intercepto
            // 
            pendiente_intercepto.AutoSize = true;
            pendiente_intercepto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            pendiente_intercepto.Location = new System.Drawing.Point(4, 47);
            pendiente_intercepto.Name = "pendiente_intercepto";
            pendiente_intercepto.Size = new System.Drawing.Size(325, 60);
            pendiente_intercepto.TabIndex = 6;
            pendiente_intercepto.Text = "en este campo solo ingresa ecuaciones\r\n               de la forma y=x+b\r\n\r\n";
            // 
            // btn_calcular_f2
            // 
            this.btn_calcular_f2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_calcular_f2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_calcular_f2.Location = new System.Drawing.Point(560, 182);
            this.btn_calcular_f2.Name = "btn_calcular_f2";
            this.btn_calcular_f2.Size = new System.Drawing.Size(156, 54);
            this.btn_calcular_f2.TabIndex = 7;
            this.btn_calcular_f2.Text = "Calcular";
            this.btn_calcular_f2.UseVisualStyleBackColor = false;
            this.btn_calcular_f2.Click += new System.EventHandler(this.btn_calcular_f2_Click);
            // 
            // ecu_2
            // 
            this.ecu_2.Location = new System.Drawing.Point(578, 136);
            this.ecu_2.Name = "ecu_2";
            this.ecu_2.Size = new System.Drawing.Size(165, 20);
            this.ecu_2.TabIndex = 11;
            // 
            // ecu_1
            // 
            this.ecu_1.Location = new System.Drawing.Point(578, 107);
            this.ecu_1.Name = "ecu_1";
            this.ecu_1.Size = new System.Drawing.Size(165, 20);
            this.ecu_1.TabIndex = 10;
            // 
            // lbl_ecu2
            // 
            this.lbl_ecu2.AutoSize = true;
            this.lbl_ecu2.Location = new System.Drawing.Point(415, 139);
            this.lbl_ecu2.Name = "lbl_ecu2";
            this.lbl_ecu2.Size = new System.Drawing.Size(143, 13);
            this.lbl_ecu2.TabIndex = 9;
            this.lbl_ecu2.Text = "ingresa la segunda ecuacion";
            // 
            // lbl_ecu1
            // 
            this.lbl_ecu1.AutoSize = true;
            this.lbl_ecu1.Location = new System.Drawing.Point(422, 107);
            this.lbl_ecu1.Name = "lbl_ecu1";
            this.lbl_ecu1.Size = new System.Drawing.Size(136, 13);
            this.lbl_ecu1.TabIndex = 8;
            this.lbl_ecu1.Text = "ingresa la priemra ecuacion";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Black;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(182, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(454, 24);
            this.label2.TabIndex = 13;
            this.label2.Text = "PUNTO DE INTERSECCION ENTRE 2 RECTAS";
            // 
            // punto_pendiente
            // 
            punto_pendiente.AutoSize = true;
            punto_pendiente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            punto_pendiente.Location = new System.Drawing.Point(414, 44);
            punto_pendiente.Name = "punto_pendiente";
            punto_pendiente.Size = new System.Drawing.Size(325, 60);
            punto_pendiente.TabIndex = 14;
            punto_pendiente.Text = "en este campo solo ingresa ecuaciones\r\n               de la forma y-y1=m(x-x1)\r\n\r" +
    "\n";
            // 
            // interfas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(punto_pendiente);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ecu_2);
            this.Controls.Add(this.ecu_1);
            this.Controls.Add(this.lbl_ecu2);
            this.Controls.Add(this.lbl_ecu1);
            this.Controls.Add(this.btn_calcular_f2);
            this.Controls.Add(pendiente_intercepto);
            this.Controls.Add(this.lbl_respuesta);
            this.Controls.Add(this.Btn_calcular_f1);
            this.Controls.Add(this.ec_2);
            this.Controls.Add(this.ec_1);
            this.Controls.Add(this.lbl_ec2);
            this.Controls.Add(this.lbl_ec1);
            this.Name = "interfas";
            this.Text = "interseccion entre 2 rectas";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_ec1;
        private System.Windows.Forms.Label lbl_ec2;
        private System.Windows.Forms.TextBox ec_1;
        private System.Windows.Forms.TextBox ec_2;
        private System.Windows.Forms.Button Btn_calcular_f1;
        private System.Windows.Forms.Label lbl_respuesta;
        private System.Windows.Forms.Button btn_calcular_f2;
        private System.Windows.Forms.TextBox ecu_2;
        private System.Windows.Forms.TextBox ecu_1;
        private System.Windows.Forms.Label lbl_ecu2;
        private System.Windows.Forms.Label lbl_ecu1;
        private System.Windows.Forms.Label label2;
    }
}

