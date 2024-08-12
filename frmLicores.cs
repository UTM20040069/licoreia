using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace licoreria
{
    public partial class frmLicores : Form
    {
        LicoreriaDBEntities contexto;

        public frmLicores()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LlenarGrid();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnExaminar_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog openfile = new OpenFileDialog();
                openfile.Title = "Abrir imagen";
                openfile.Filter = "Archivos JPG (*.jpg, *.jpeg)| *.jpg; *.jpeg ";

                if (openfile.ShowDialog() == DialogResult.OK)
                {
                    string image = openfile.FileName;
                    txtRutaImagen.Text = image;
                    pbImagen.Image = Image.FromFile(image);
                }
                else
                {
                    MessageBox.Show("No se selecciono Imagen");
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Ocurrio un error: " + ex.ToString());
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void LlenarGrid()
        {
            try
            {
                contexto = new LicoreriaDBEntities();

                var datos = from a in contexto.Licores1
                            select new
                            {
                               IdProducto = a.IdProducto, 
                               Nombre = a.Nombre,
                               TipoDeLicor = a.TipoDeLicor,
                               Precio = a.Precio
                            };

                dgvDatos.DataSource = datos.ToList();
                dgvDatos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            catch (Exception ex)
            {

                MessageBox.Show("Ocurrio un error: " + ex.ToString());
            }
        }
        private void LimpiarTextos()
        {
            txtIdProducto.Text = "";
            txtNombre.Text = "";
            txtTipoDeLicor.Text = "";
            txtPrecio.Text = "";
            txtRutaImagen.Text = "";
            pbImagen.ImageLocation = "";

        }
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                contexto = new LicoreriaDBEntities();

                //Agregamos un producto nuevo
                Licores licores = new Licores()
                {
                    IdProducto = int.Parse(txtIdProducto.Text),
                    Nombre = txtNombre.Text,
                    TipoDeLicor = txtTipoDeLicor.Text,
                    Precio = int.Parse(txtPrecio.Text),
                    Imagen = txtRutaImagen.Text,
                };
                //Agregar producto a la base de datos
                contexto.Licores1.Add(licores);
                contexto.SaveChanges();
                MessageBox.Show("Producto agregado correctamente");
                LimpiarTextos();
                LlenarGrid();
            }
            catch (Exception ex)
            {

                MessageBox.Show("Ocurrio un error: " + ex.ToString());
            }

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtIdProducto.Text != string.Empty)
                {
                    int clave = int.Parse(txtIdProducto.Text);
                    contexto = new LicoreriaDBEntities();

                    Licores buscar = (from a in contexto.Licores1
                                      where a.IdProducto == clave
                                      select a).SingleOrDefault();

                    if (buscar != null) {

                        txtNombre.Text = buscar.Nombre;
                        txtTipoDeLicor.Text = buscar.TipoDeLicor;
                        txtPrecio.Text = buscar.Precio.ToString();
                        txtRutaImagen.Text = buscar.Imagen;
                        pbImagen.Image = Image.FromFile(buscar.Imagen);

                    }
                    else
                    {
                        LimpiarTextos();
                        MessageBox.Show("No se encontro el registro");

                    }
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Ocurrio un error: " + ex.ToString());
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtIdProducto.Text != string.Empty)
                {
                    int clave = int.Parse(txtIdProducto.Text);

                    contexto = new LicoreriaDBEntities();

                    Licores actualizar = (from a in contexto.Licores1
                                          where a.IdProducto == clave
                                          select a).SingleOrDefault();
                    if (actualizar != null)
                    {
                        actualizar.Nombre = txtIdProducto.Text;  
                        actualizar.TipoDeLicor = txtIdProducto.Text;
                        actualizar.Precio = int.Parse(txtPrecio.Text);
                        actualizar.Imagen = txtRutaImagen.Text;

                        contexto.SaveChanges();
                        MessageBox.Show("Producto actualizado");
                        LimpiarTextos();
                        LlenarGrid();

                    }
                    else
                    {
                        MessageBox.Show("No se encontro el registro");

                    }

                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Ocurrio un error: " + ex.ToString());

            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtIdProducto.Text != string.Empty)
                {
                    int clave = int.Parse(txtIdProducto.Text);

                    contexto = new LicoreriaDBEntities();

                    Licores eliminar = (from a in contexto.Licores1
                                        where a.IdProducto == clave
                                        select a).SingleOrDefault(); 
                    if (eliminar != null) 
                    {
                        contexto.Licores1.Remove(eliminar);
                        contexto.SaveChanges();
                        MessageBox.Show("Producto eliminado");
                        LlenarGrid();
                    }
                    else
                    {
                        MessageBox.Show("No se encontro el registro");
                    }
                    
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Ocurrio un error: " + ex.ToString());


            }
        }

        private void txtPrecio_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblFolio_Click(object sender, EventArgs e)
        {

        }

        private void lblCantidad_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnEliminar_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (txtIdProducto.Text != string.Empty)
                {
                    int clave = int.Parse(txtIdProducto.Text);

                    contexto = new LicoreriaDBEntities();

                    Licores eliminar = (from a in contexto.Licores1
                                        where a.IdProducto == clave
                                        select a).SingleOrDefault();
                    if (eliminar != null)
                    {
                        contexto.Licores1.Remove(eliminar);
                        contexto.SaveChanges();
                        MessageBox.Show("Producto eliminado");
                        LimpiarTextos();
                        LlenarGrid();
                    }
                    else
                    {
                        MessageBox.Show("No se encontro el registro");
                    }

                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Ocurrio un error: " + ex.ToString());


            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnAgregar_Click_1(object sender, EventArgs e)
        {
            try
            {
                contexto = new LicoreriaDBEntities();

                //Agregamos un producto nuevo
                Licores licores = new Licores()
                {
                    IdProducto = int.Parse(txtIdProducto.Text),
                    Nombre = txtNombre.Text,
                    TipoDeLicor = txtTipoDeLicor.Text,
                    Precio = int.Parse(txtPrecio.Text),
                    Imagen = txtRutaImagen.Text,
                };
                //Agregar producto a la base de datos
                contexto.Licores1.Add(licores);
                contexto.SaveChanges();
                MessageBox.Show("Producto agregado correctamente");
                LimpiarTextos();
                LlenarGrid();
            }
            catch (Exception ex)
            {

                MessageBox.Show("Ocurrio un error: " + ex.ToString());
            }

        }

        private void btnActualizar_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (txtIdProducto.Text != string.Empty)
                {
                    int clave = int.Parse(txtIdProducto.Text);

                    contexto = new LicoreriaDBEntities();

                    Licores actualizar = (from a in contexto.Licores1
                                          where a.IdProducto == clave
                                          select a).SingleOrDefault();
                    if (actualizar != null)
                    {
                        actualizar.Nombre = txtNombre.Text;
                        actualizar.TipoDeLicor = txtTipoDeLicor.Text;
                        actualizar.Precio = int.Parse(txtPrecio.Text);
                        actualizar.Imagen = txtRutaImagen.Text;

                        contexto.SaveChanges();
                        MessageBox.Show("Producto actualizado");
                        LimpiarTextos();
                        LlenarGrid();

                    }
                    else
                    {
                        MessageBox.Show("No se encontro el registro");

                    }

                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Ocurrio un error: " + ex.ToString());

            }
        }
    }
}
