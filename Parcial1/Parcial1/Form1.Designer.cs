
namespace Parcial1
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
            this.lblCont2 = new System.Windows.Forms.Label();
            this.dtGridw = new System.Windows.Forms.DataGridView();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Apellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Dni = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha_Nacimiento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Legajo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Mail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblCont = new System.Windows.Forms.Label();
            this.txtMail = new System.Windows.Forms.TextBox();
            this.lblMail = new System.Windows.Forms.Label();
            this.txtNac = new System.Windows.Forms.TextBox();
            this.lblNac = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtInsc = new System.Windows.Forms.TextBox();
            this.lblInscripcion = new System.Windows.Forms.Label();
            this.txtCar = new System.Windows.Forms.TextBox();
            this.lblCarrera = new System.Windows.Forms.Label();
            this.txtLeg = new System.Windows.Forms.TextBox();
            this.lblLegajo = new System.Windows.Forms.Label();
            this.txtDni = new System.Windows.Forms.TextBox();
            this.lblDni = new System.Windows.Forms.Label();
            this.txtAp = new System.Windows.Forms.TextBox();
            this.lblApellido = new System.Windows.Forms.Label();
            this.txtNom = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtGridw)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCont2
            // 
            this.lblCont2.AutoSize = true;
            this.lblCont2.Location = new System.Drawing.Point(88, 382);
            this.lblCont2.Name = "lblCont2";
            this.lblCont2.Size = new System.Drawing.Size(0, 13);
            this.lblCont2.TabIndex = 42;
            // 
            // dtGridw
            // 
            this.dtGridw.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGridw.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nombre,
            this.Apellido,
            this.Dni,
            this.Fecha_Nacimiento,
            this.Legajo,
            this.Mail});
            this.dtGridw.Location = new System.Drawing.Point(72, 398);
            this.dtGridw.Name = "dtGridw";
            this.dtGridw.Size = new System.Drawing.Size(644, 214);
            this.dtGridw.TabIndex = 41;
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            // 
            // Apellido
            // 
            this.Apellido.HeaderText = "Apellido";
            this.Apellido.Name = "Apellido";
            // 
            // Dni
            // 
            this.Dni.HeaderText = "Dni";
            this.Dni.Name = "Dni";
            // 
            // Fecha_Nacimiento
            // 
            this.Fecha_Nacimiento.HeaderText = "F. Nacimiento";
            this.Fecha_Nacimiento.Name = "Fecha_Nacimiento";
            this.Fecha_Nacimiento.Width = 101;
            // 
            // Legajo
            // 
            this.Legajo.HeaderText = "Legajo";
            this.Legajo.Name = "Legajo";
            // 
            // Mail
            // 
            this.Mail.HeaderText = "Mail";
            this.Mail.Name = "Mail";
            // 
            // lblCont
            // 
            this.lblCont.AutoSize = true;
            this.lblCont.Location = new System.Drawing.Point(507, 534);
            this.lblCont.Name = "lblCont";
            this.lblCont.Size = new System.Drawing.Size(0, 13);
            this.lblCont.TabIndex = 40;
            // 
            // txtMail
            // 
            this.txtMail.Location = new System.Drawing.Point(189, 273);
            this.txtMail.Name = "txtMail";
            this.txtMail.Size = new System.Drawing.Size(160, 20);
            this.txtMail.TabIndex = 39;
            // 
            // lblMail
            // 
            this.lblMail.AutoSize = true;
            this.lblMail.Font = new System.Drawing.Font("Minion Pro Cond", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMail.Location = new System.Drawing.Point(85, 263);
            this.lblMail.Name = "lblMail";
            this.lblMail.Size = new System.Drawing.Size(64, 33);
            this.lblMail.TabIndex = 38;
            this.lblMail.Text = "Mail:";
            // 
            // txtNac
            // 
            this.txtNac.Location = new System.Drawing.Point(307, 212);
            this.txtNac.Name = "txtNac";
            this.txtNac.Size = new System.Drawing.Size(160, 20);
            this.txtNac.TabIndex = 37;
            // 
            // lblNac
            // 
            this.lblNac.AutoSize = true;
            this.lblNac.Font = new System.Drawing.Font("Minion Pro Cond", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNac.Location = new System.Drawing.Point(85, 202);
            this.lblNac.Name = "lblNac";
            this.lblNac.Size = new System.Drawing.Size(202, 33);
            this.lblNac.TabIndex = 36;
            this.lblNac.Text = "Año de nacimiento:";
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Minion Pro Cond", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(358, 311);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(122, 47);
            this.btnSave.TabIndex = 35;
            this.btnSave.Text = "Guardar";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click_1);
            // 
            // txtInsc
            // 
            this.txtInsc.Location = new System.Drawing.Point(593, 276);
            this.txtInsc.Name = "txtInsc";
            this.txtInsc.Size = new System.Drawing.Size(171, 20);
            this.txtInsc.TabIndex = 34;
            // 
            // lblInscripcion
            // 
            this.lblInscripcion.AutoSize = true;
            this.lblInscripcion.Font = new System.Drawing.Font("Minion Pro Cond", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInscripcion.Location = new System.Drawing.Point(387, 263);
            this.lblInscripcion.Name = "lblInscripcion";
            this.lblInscripcion.Size = new System.Drawing.Size(200, 33);
            this.lblInscripcion.TabIndex = 33;
            this.lblInscripcion.Text = "Año de inscripcion:";
            // 
            // txtCar
            // 
            this.txtCar.Location = new System.Drawing.Point(579, 212);
            this.txtCar.Name = "txtCar";
            this.txtCar.Size = new System.Drawing.Size(171, 20);
            this.txtCar.TabIndex = 32;
            // 
            // lblCarrera
            // 
            this.lblCarrera.AutoSize = true;
            this.lblCarrera.Font = new System.Drawing.Font("Minion Pro Cond", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCarrera.Location = new System.Drawing.Point(473, 205);
            this.lblCarrera.Name = "lblCarrera";
            this.lblCarrera.Size = new System.Drawing.Size(94, 33);
            this.lblCarrera.TabIndex = 31;
            this.lblCarrera.Text = "Carrera:";
            // 
            // txtLeg
            // 
            this.txtLeg.Location = new System.Drawing.Point(579, 132);
            this.txtLeg.Name = "txtLeg";
            this.txtLeg.Size = new System.Drawing.Size(171, 20);
            this.txtLeg.TabIndex = 30;
            // 
            // lblLegajo
            // 
            this.lblLegajo.AutoSize = true;
            this.lblLegajo.Font = new System.Drawing.Font("Minion Pro Cond", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLegajo.Location = new System.Drawing.Point(473, 122);
            this.lblLegajo.Name = "lblLegajo";
            this.lblLegajo.Size = new System.Drawing.Size(84, 33);
            this.lblLegajo.TabIndex = 29;
            this.lblLegajo.Text = "Legajo:";
            // 
            // txtDni
            // 
            this.txtDni.Location = new System.Drawing.Point(163, 132);
            this.txtDni.Name = "txtDni";
            this.txtDni.Size = new System.Drawing.Size(171, 20);
            this.txtDni.TabIndex = 28;
            // 
            // lblDni
            // 
            this.lblDni.AutoSize = true;
            this.lblDni.Font = new System.Drawing.Font("Minion Pro Cond", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDni.Location = new System.Drawing.Point(85, 122);
            this.lblDni.Name = "lblDni";
            this.lblDni.Size = new System.Drawing.Size(72, 33);
            this.lblDni.TabIndex = 27;
            this.lblDni.Text = "D.N.I:";
            // 
            // txtAp
            // 
            this.txtAp.Location = new System.Drawing.Point(579, 46);
            this.txtAp.Name = "txtAp";
            this.txtAp.Size = new System.Drawing.Size(171, 20);
            this.txtAp.TabIndex = 26;
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Font = new System.Drawing.Font("Minion Pro Cond", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApellido.Location = new System.Drawing.Point(473, 36);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(100, 33);
            this.lblApellido.TabIndex = 25;
            this.lblApellido.Text = "Apellido:";
            // 
            // txtNom
            // 
            this.txtNom.Location = new System.Drawing.Point(189, 46);
            this.txtNom.Name = "txtNom";
            this.txtNom.Size = new System.Drawing.Size(171, 20);
            this.txtNom.TabIndex = 24;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Minion Pro Cond", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(85, 36);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(98, 33);
            this.lblNombre.TabIndex = 23;
            this.lblNombre.Text = "Nombre:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(796, 649);
            this.Controls.Add(this.lblCont2);
            this.Controls.Add(this.dtGridw);
            this.Controls.Add(this.lblCont);
            this.Controls.Add(this.txtMail);
            this.Controls.Add(this.lblMail);
            this.Controls.Add(this.txtNac);
            this.Controls.Add(this.lblNac);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtInsc);
            this.Controls.Add(this.lblInscripcion);
            this.Controls.Add(this.txtCar);
            this.Controls.Add(this.lblCarrera);
            this.Controls.Add(this.txtLeg);
            this.Controls.Add(this.lblLegajo);
            this.Controls.Add(this.txtDni);
            this.Controls.Add(this.lblDni);
            this.Controls.Add(this.txtAp);
            this.Controls.Add(this.lblApellido);
            this.Controls.Add(this.txtNom);
            this.Controls.Add(this.lblNombre);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dtGridw)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCont2;
        private System.Windows.Forms.DataGridView dtGridw;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Apellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dni;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha_Nacimiento;
        private System.Windows.Forms.DataGridViewTextBoxColumn Legajo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Mail;
        private System.Windows.Forms.Label lblCont;
        private System.Windows.Forms.TextBox txtMail;
        private System.Windows.Forms.Label lblMail;
        private System.Windows.Forms.TextBox txtNac;
        private System.Windows.Forms.Label lblNac;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtInsc;
        private System.Windows.Forms.Label lblInscripcion;
        private System.Windows.Forms.TextBox txtCar;
        private System.Windows.Forms.Label lblCarrera;
        private System.Windows.Forms.TextBox txtLeg;
        private System.Windows.Forms.Label lblLegajo;
        private System.Windows.Forms.TextBox txtDni;
        private System.Windows.Forms.Label lblDni;
        private System.Windows.Forms.TextBox txtAp;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.TextBox txtNom;
        private System.Windows.Forms.Label lblNombre;
    }
}

