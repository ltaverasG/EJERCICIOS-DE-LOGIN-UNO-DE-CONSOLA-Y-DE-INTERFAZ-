using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace login_de_usuarios_con_interfaz
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            /*      ojo con los usuarios, contraseñas, roll, estado y fecha de creacion.
             *
             *                     TABLA DE CARACTERISTICAS DE USUARIOS
              --------------------------------------------------------------------------------------
              | NOMBRES  | USUARIOS    | CONTRASEÑA |      ROLL     |  ESTADO  | FECHA DE CREACION |
              |----------|-------------|------------|---------------|----------|-------------------|
              |   Luis   | 40229363458 |   223445   | ADMINISTRADOR | activo   |  10 /01/ 2001     |
              |----------|-------------|------------|---------------|----------|-------------------|
              |   Jose   | 40330129321 |   427554   | SUPERVISOR    | activo   |  30 /06/ 2003     |
              |----------|-------------|------------|---------------|----------|-------------------|
              |   Juan   | 40124304839 |   981341   | VENDEDOR      | inactivo |  18 /05/ 2020     |
              --------------------------------------------------------------------------------------
             */
            // variables
            bool usuario;  // variable para validar si un usuario esta activo o inactivo 

            // condiciones de  los usuarios 

            // ADMIN 
            if ((textBox1.Text == "40229363458") && (textBox2.Text == "223445"))
            {
                usuario = true;

                if (usuario == true)
                {
                    MessageBox.Show(" ACABAS DE INGRESAR CON EL USUARIO:" + "\n" + " Luis Taveras " + 
                        textBox1.Text + " y su Roll es: ADMINISTRADOR. ");
                    textBox1.Text = "";
                    textBox2.Text = "";
                }
            }

            // supervisor 
            else if ((textBox1.Text == "40330129321") && (textBox2.Text == "427554")) 
            {
                usuario = true;

                if (usuario == true)
                {
                    MessageBox.Show(" ACABAS DE INGRESAR CON EL USUARIO:" + "\n" + " Jose Deschamps " +
                        textBox1.Text + " y su Roll es: SUPERVISOR. ");
                    textBox1.Text = "";
                    textBox2.Text = "";
                }
            }

             // vendedor ( inactivo ) 
            else  if ((textBox1.Text == "40124304839") && (textBox2.Text == "981341"))
            {
                usuario = false; // usuario inactivo 

                if (usuario == false)
                {
                    MessageBox.Show("USUARIO INACTIVO, VALIDAR CON OTRO USUARIO ");
                    textBox1.Text = "";
                    textBox2.Text = "";
                }
            }

            else
            {
                MessageBox.Show("Contraseña o Usuario incorrectos favor verificar");
                textBox1.Text = "";
                textBox2.Text = "";
            }
        }
    }
}
