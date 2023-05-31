namespace pryZamoracadenadetextoo
{
    partial class FrmPrincipal
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
            this.txtTextoE = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTextoD = new System.Windows.Forms.TextBox();
            this.lblTextoD = new System.Windows.Forms.Label();
            this.txtTextoC = new System.Windows.Forms.TextBox();
            this.btnReemplazar = new System.Windows.Forms.Button();
            this.lblHora = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.txtTextoB = new System.Windows.Forms.TextBox();
            this.lblTextoC = new System.Windows.Forms.Label();
            this.lblTextoB = new System.Windows.Forms.Label();
            this.btnComparar = new System.Windows.Forms.Button();
            this.lblTextoA = new System.Windows.Forms.Label();
            this.txtTextoA = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtTextoE
            // 
            this.txtTextoE.Location = new System.Drawing.Point(279, 107);
            this.txtTextoE.Name = "txtTextoE";
            this.txtTextoE.Size = new System.Drawing.Size(100, 20);
            this.txtTextoE.TabIndex = 56;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(385, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 55;
            this.label3.Text = "Texto E";
            // 
            // txtTextoD
            // 
            this.txtTextoD.Location = new System.Drawing.Point(92, 107);
            this.txtTextoD.Name = "txtTextoD";
            this.txtTextoD.Size = new System.Drawing.Size(100, 20);
            this.txtTextoD.TabIndex = 54;
            // 
            // lblTextoD
            // 
            this.lblTextoD.AutoSize = true;
            this.lblTextoD.Location = new System.Drawing.Point(42, 110);
            this.lblTextoD.Name = "lblTextoD";
            this.lblTextoD.Size = new System.Drawing.Size(45, 13);
            this.lblTextoD.TabIndex = 53;
            this.lblTextoD.Text = "Texto D";
            // 
            // txtTextoC
            // 
            this.txtTextoC.Location = new System.Drawing.Point(279, 78);
            this.txtTextoC.Name = "txtTextoC";
            this.txtTextoC.Size = new System.Drawing.Size(100, 20);
            this.txtTextoC.TabIndex = 52;
            // 
            // btnReemplazar
            // 
            this.btnReemplazar.Location = new System.Drawing.Point(198, 105);
            this.btnReemplazar.Name = "btnReemplazar";
            this.btnReemplazar.Size = new System.Drawing.Size(75, 23);
            this.btnReemplazar.TabIndex = 51;
            this.btnReemplazar.Text = "Reemplazar";
            this.btnReemplazar.UseVisualStyleBackColor = true;
            // 
            // lblHora
            // 
            this.lblHora.AutoSize = true;
            this.lblHora.Location = new System.Drawing.Point(89, 188);
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(30, 13);
            this.lblHora.TabIndex = 50;
            this.lblHora.Text = "Hora";
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Location = new System.Drawing.Point(89, 174);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(37, 13);
            this.lblFecha.TabIndex = 49;
            this.lblFecha.Text = "Fecha";
            // 
            // dtpFecha
            // 
            this.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFecha.Location = new System.Drawing.Point(92, 150);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(100, 20);
            this.dtpFecha.TabIndex = 48;
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(279, 49);
            this.txtBuscar.MaxLength = 1;
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(27, 20);
            this.txtBuscar.TabIndex = 47;
            this.txtBuscar.Visible = false;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(198, 47);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 46;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click_1);
            // 
            // txtTextoB
            // 
            this.txtTextoB.Location = new System.Drawing.Point(92, 78);
            this.txtTextoB.Name = "txtTextoB";
            this.txtTextoB.Size = new System.Drawing.Size(100, 20);
            this.txtTextoB.TabIndex = 45;
            // 
            // lblTextoC
            // 
            this.lblTextoC.AutoSize = true;
            this.lblTextoC.Location = new System.Drawing.Point(385, 81);
            this.lblTextoC.Name = "lblTextoC";
            this.lblTextoC.Size = new System.Drawing.Size(44, 13);
            this.lblTextoC.TabIndex = 44;
            this.lblTextoC.Text = "Texto C";
            // 
            // lblTextoB
            // 
            this.lblTextoB.AutoSize = true;
            this.lblTextoB.Location = new System.Drawing.Point(42, 81);
            this.lblTextoB.Name = "lblTextoB";
            this.lblTextoB.Size = new System.Drawing.Size(44, 13);
            this.lblTextoB.TabIndex = 43;
            this.lblTextoB.Text = "Texto B";
            // 
            // btnComparar
            // 
            this.btnComparar.Location = new System.Drawing.Point(198, 76);
            this.btnComparar.Name = "btnComparar";
            this.btnComparar.Size = new System.Drawing.Size(75, 23);
            this.btnComparar.TabIndex = 42;
            this.btnComparar.Text = "Comparar";
            this.btnComparar.UseVisualStyleBackColor = true;
            // 
            // lblTextoA
            // 
            this.lblTextoA.AutoSize = true;
            this.lblTextoA.Location = new System.Drawing.Point(42, 52);
            this.lblTextoA.Name = "lblTextoA";
            this.lblTextoA.Size = new System.Drawing.Size(44, 13);
            this.lblTextoA.TabIndex = 41;
            this.lblTextoA.Text = "Texto A";
            // 
            // txtTextoA
            // 
            this.txtTextoA.Location = new System.Drawing.Point(92, 49);
            this.txtTextoA.Name = "txtTextoA";
            this.txtTextoA.Size = new System.Drawing.Size(100, 20);
            this.txtTextoA.TabIndex = 40;
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtTextoE);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtTextoD);
            this.Controls.Add(this.lblTextoD);
            this.Controls.Add(this.txtTextoC);
            this.Controls.Add(this.btnReemplazar);
            this.Controls.Add(this.lblHora);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.dtpFecha);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.txtTextoB);
            this.Controls.Add(this.lblTextoC);
            this.Controls.Add(this.lblTextoB);
            this.Controls.Add(this.btnComparar);
            this.Controls.Add(this.lblTextoA);
            this.Controls.Add(this.txtTextoA);
            this.Name = "FrmPrincipal";
            this.Text = "Cdena de texto";
            this.Load += new System.EventHandler(this.FrmPrincipal_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtTextoE;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTextoD;
        private System.Windows.Forms.Label lblTextoD;
        private System.Windows.Forms.TextBox txtTextoC;
        private System.Windows.Forms.Button btnReemplazar;
        private System.Windows.Forms.Label lblHora;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TextBox txtTextoB;
        private System.Windows.Forms.Label lblTextoC;
        private System.Windows.Forms.Label lblTextoB;
        private System.Windows.Forms.Button btnComparar;
        private System.Windows.Forms.Label lblTextoA;
        private System.Windows.Forms.TextBox txtTextoA;
    }
}

