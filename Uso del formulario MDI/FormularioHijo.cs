using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Uso_del_formulario_MDI
{
    public partial class FormularioHijo : Form
    {
        public FormularioHijo()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
        }

        private void FormularioHijo_Load(object sender, EventArgs e)
        {

        }

        private void lbl_msg_Click(object sender, EventArgs e)
        {

        }

        private void tbDato_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblmsg_Click(object sender, EventArgs e)
        {

        }

        private void tbDato1_TextChanged(object sender, EventArgs e)
        {

        }

        private void bSumar_Click(object sender, EventArgs e)
        {
            double x = Convert.ToDouble(tbDato.Text), y = Convert.ToDouble(tbDato1.Text), z = 0;
            MessageBox.Show(
                $"El resultado de la suma de {x} y {y} es {z = x + y}", 
                "FormularioHijo", 
                MessageBoxButtons.OK, 
                MessageBoxIcon.Information, 
                MessageBoxDefaultButton.Button1
            );
        }
    }
}
