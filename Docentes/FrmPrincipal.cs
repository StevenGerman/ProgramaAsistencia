using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Docentes
{
    

    public partial class FrmPrincipal : Form
    {
        private List<Profesor> listaProfesores;
        private ProfesorDatos negocio = new ProfesorDatos();
        private List<Profesor> listaConCatedras;
        private CatedrasDatos negocioCatedras = new CatedrasDatos();
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void AbrirFormulario<MiForm>() where MiForm : Form,new(){

            Form formulario;
            formulario = panelFomularios.Controls.OfType<MiForm>().FirstOrDefault();

            if(formulario == null)
            {
                formulario = new MiForm();
                formulario.TopLevel = false;
                formulario.FormBorderStyle = FormBorderStyle.None;
                formulario.Dock = DockStyle.Fill;
                panelFomularios.Controls.Add(formulario);
                panelFomularios.Tag = formulario;
                formulario.Show();
                formulario.BringToFront();
            }
            else{
                formulario.BringToFront();
            }





        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            //AbrirFormulario<FrmAltaProfesor>();
            Profesor prof = new Profesor();
            ProfesorDatos profesorDatos = new ProfesorDatos();
            try
            {
                prof.nombre = txtNombre.Text;
                prof.apellido = txtBApellido.Text;
                prof.email = txtEmail.Text;
                prof.dni = txtBDni.Text;
                prof.telefono = txtBTelefono.Text;
                profesorDatos.agregar(prof);
                MessageBox.Show("Agregado exitosamente");
                cargarProfesores(dgvProfesores);


            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }






        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            //AbrirFormulario<FrmModificar>();
            /*Profesor prof = new Profesor();*/
            ProfesorDatos profesorDatos = new ProfesorDatos();
            Profesor seleccionado;
            seleccionado = (Profesor)dgvProfesores.CurrentRow.DataBoundItem;
            try
            {
                seleccionado.id = seleccionado.id;
                seleccionado.nombre = txtNombre.Text;
                seleccionado.apellido = txtBApellido.Text;
                seleccionado.email = txtEmail.Text;
                seleccionado.dni = txtBDni.Text;
                seleccionado.telefono = txtBTelefono.Text;
                profesorDatos.Modificar(seleccionado);
                MessageBox.Show("Modificado exitosamente");
                cargarProfesores(dgvProfesores);


            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private void cargarProfesorCatedras(DataGridView listaProfesorCatedra)
        {
            ProfesorDatos datosConCatedra = new ProfesorDatos();
            try
            {
                listaConCatedras = datosConCatedra.ListarConCatedras();
                dgvCatedras.DataSource = listaConCatedras;
                
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }


        private void cargarProfesores(DataGridView listaProfes)
        {
            try
            {
                listaProfesores = negocio.Listar();
                dgvProfesores.DataSource = listaProfesores;
                dgvProfesores.Columns["id"].Visible = false;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            cargarProfesores(dgvProfesores);
        }

        

        private void dgvProfesores_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            Profesor seleccionado;
            seleccionado = (Profesor)dgvProfesores.CurrentRow.DataBoundItem;

            txtNombre.Text = seleccionado.nombre.ToString();
            txtBApellido.Text = seleccionado.apellido.ToString();
            txtBDni.Text = seleccionado.dni.ToString();
            txtEmail.Text = seleccionado.email.ToString();
            txtBTelefono.Text = seleccionado.telefono.ToString();
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            try
            {
                cargarProfesores(dgvProfesores);
                cargarProfesorCatedras(dgvCatedras);
                dgvCatedras.Columns["dni"].Visible = false;
                dgvCatedras.Columns["email"].Visible = false;
                dgvCatedras.Columns["telefono"].Visible = false;
                dgvCatedras.Columns["id"].Visible = false;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            Profesor seleccionado;
            seleccionado = (Profesor)dgvProfesores.CurrentRow.DataBoundItem;
            ProfesorDatos profesorDatos = new ProfesorDatos();
            profesorDatos.eliminar(seleccionado);
            MessageBox.Show("Se ha eliminado un registro");
            cargarProfesores(dgvProfesores);



        }

        private void dgvCatedras_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnAsignarCatedra_Click(object sender, EventArgs e)
        {
            //AbrirFormulario<FrmModificar>();
        }
    }
}
