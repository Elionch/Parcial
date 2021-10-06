using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Parcial1
{
    public partial class Form1 : Form
    {
        private List<Alumno> alumnos = new List<Alumno>();

        public Form1()
        {
            InitializeComponent();

        }
        private void Form1_Load(object sender, EventArgs e)
        {


        }

        private void btnSave_Click(object sender, EventArgs e)
        {




            
        }
        private void btnMostrar_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnSave_Click_1(object sender, EventArgs e)
        {
            if (Validar())
            {
                alumnos.Add(new Alumno(txtNom.Text, txtAp.Text, txtMail.Text, txtCar.Text, Int32.Parse(txtDni.Text), Int32.Parse(txtNac.Text), Int32.Parse(txtLeg.Text), Int32.Parse(txtInsc.Text)));

                int n = dtGridw.Rows.Add();
                dtGridw.Rows[n].Cells[0].Value = txtNom.Text;
                dtGridw.Rows[n].Cells[1].Value = txtAp.Text;
                dtGridw.Rows[n].Cells[2].Value = txtDni.Text;
                dtGridw.Rows[n].Cells[3].Value = txtNac.Text;
                dtGridw.Rows[n].Cells[4].Value = txtLeg.Text;
                dtGridw.Rows[n].Cells[5].Value = txtMail.Text;

                txtNom.Clear();
                txtAp.Clear();
                txtNac.Clear();
                txtDni.Clear();
                txtLeg.Clear();
                txtCar.Clear();
                txtMail.Clear();
                txtInsc.Clear();
                MessageBox.Show("Alumno agregado");



            }
            if (alumnos.Count == 0)
            {

            }
            else if (alumnos.Count > 1)
            {
                lblCont2.Text = (alumnos.Count) + " alumnos agregados";
            }
            else
            {
                lblCont2.Text = (alumnos.Count) + " alumno agregado";
            }

        }
        private bool Validar()
        {
            bool datovalido = true;

            if (txtNom.Text.Trim() == "")
            {
                MessageBox.Show("El campo nombre es obligatorio");
                datovalido = false;
                txtNom.Focus();
            }
            if (txtAp.Text.Trim() == "")
            {
                MessageBox.Show("El campo apellido es obligatorio");
                datovalido = false;
                txtAp.Focus();

            }
            try
            {
                Int32.Parse(txtDni.Text.Trim());
            }
            catch (Exception ex)
            {
                MessageBox.Show("El campo dni es incorrecto o esta vacio");
                datovalido = false;
                txtDni.Focus();
            }
            try
            {
                Int32.Parse(txtLeg.Text.Trim());
            }
            catch (Exception ex)
            {
                MessageBox.Show("El campo legajo es incorrecto o esta vacio");
                datovalido = false;
                txtLeg.Focus();
            }
            if (txtCar.Text.Trim() == "")
            {
                MessageBox.Show("El campo carrera es obligatorio");
                datovalido = false;
                txtCar.Focus();
            }
            try
            {
                Int32.Parse(txtInsc.Text.Trim());
            }
            catch (Exception ex)
            {
                MessageBox.Show("El campo año de inscripcion es incorrecto o esta vacio");
                datovalido = false;
                txtInsc.Focus();
            }
            try
            {
                Int32.Parse(txtNac.Text.Trim());
                if (Int32.Parse(txtNac.Text) > 2002)
                {
                    MessageBox.Show("No se permite la incripcion a menores de 18");
                    datovalido = false;
                    txtNac.Focus();
                }

            }

            catch (Exception ex3)
            {
                MessageBox.Show("El campo año de nacimiento es incorrecto o esta vacio");
                datovalido = false;
            }

            return datovalido;

        }
    }

}