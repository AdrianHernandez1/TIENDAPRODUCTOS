using TiendaProductos.Controlador;
using TiendaProductos.Models;

namespace TiendaProductos
{
    public partial class Form1 : Form
    {
        private ProductosController productosController;
        private VentaPorArticulo ventaPorArticulo;

        public Form1()
        {
            InitializeComponent();
            productosController = new ProductosController();
            ventaPorArticulo = new VentaPorArticulo();
            obtenerProductos();

            this.MaximizeBox = false;

        }

        private async void obtenerVentasPorArticulo()
        {
            LimpiarTabla();
            Nombre.Text = "Ventas por articulo";

            if (comboBox1.SelectedItem != null)
            {
                Productos productoSeleccionado = (Productos)comboBox1.SelectedItem;

                int idProductoSeleccionado = productoSeleccionado.IDProductos;

                List<VentaPorArticulo> ventasPorArticulo = await productosController.obtenerVentasPorArticulo(idProductoSeleccionado);

                if (ventasPorArticulo != null && ventasPorArticulo.Count > 0)
                {
                    dataVentasPorArticulo.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                    foreach (var venta in ventasPorArticulo)
                    {
                        DataGridViewRow row = new DataGridViewRow();
                        row.CreateCells(dataVentasPorArticulo);

                        row.Cells[0].Value = venta.IDProducto;
                        row.Cells[1].Value = venta.Titulo;
                        row.Cells[2].Value = venta.Descripcion;
                        row.Cells[3].Value = venta.TotalVendido;
                        row.Cells[4].Value = venta.PrecioUnitario;
                        row.Cells[5].Value = venta.TotalVentas;
                        dataVentasPorArticulo.Columns[6].Visible = false;

                        dataVentasPorArticulo.Rows.Add(row);
                    }
                }
                else
                {
                    MessageBox.Show("No se puede obtener la petición.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Seleccione un producto.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private async void obtenerVentasGlobales()
        {
            LimpiarTabla();
            comboBox1.Visible = false;
            Obtener.Visible = false;
            Seleccionar.Visible = false;
            Nombre.Text = "Ventas globales";


            List<VentaPorArticulo> vestasGlobales = await productosController.obtenerVentasGlobales();

            if (vestasGlobales != null && vestasGlobales.Count > 0)
            {
                dataVentasPorArticulo.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                foreach (var venta in vestasGlobales)
                {
                    DataGridViewRow row = new DataGridViewRow();
                    row.CreateCells(dataVentasPorArticulo);

                    row.Cells[0].Value = venta.IDProducto;
                    row.Cells[1].Value = venta.Titulo;
                    row.Cells[2].Value = venta.Descripcion;
                    row.Cells[3].Value = venta.TotalVendido;
                    row.Cells[4].Value = venta.PrecioUnitario;
                    row.Cells[5].Value = venta.TotalVentas;
                    dataVentasPorArticulo.Columns[6].Visible = false;

                    dataVentasPorArticulo.Rows.Add(row);
                }
            }
            else
            {
                MessageBox.Show("No se puede obtener la petición.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void obtenerArticulosMasVendidos()
        {
            LimpiarTabla();
            comboBox1.Visible = false;
            Obtener.Visible = false;
            Seleccionar.Visible = false;
            Nombre.Text = "Articulos mas vendidos";


            List<VentaPorArticulo> articulosMasVendidos = await productosController.obtenerArticulosMasVendidos();

            if (articulosMasVendidos != null && articulosMasVendidos.Count > 0)
            {
                dataVentasPorArticulo.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                foreach (var venta in articulosMasVendidos)
                {
                    DataGridViewRow row = new DataGridViewRow();
                    row.CreateCells(dataVentasPorArticulo);

                    dataVentasPorArticulo.Columns[0].Visible = false;
                    row.Cells[1].Value = venta.Titulo;
                    row.Cells[2].Value = venta.Descripcion;
                    dataVentasPorArticulo.Columns[3].Visible = false;
                    dataVentasPorArticulo.Columns[4].Visible = false;
                    row.Cells[5].Value = venta.TotalVentas;
                    dataVentasPorArticulo.Columns[6].Visible = false;


                    dataVentasPorArticulo.Rows.Add(row);
                }
            }
            else
            {
                MessageBox.Show("No se puede obtener la petición.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void obtenerCantidadProductosExistentes()
        {
            LimpiarTabla();
            comboBox1.Visible = false;
            Obtener.Visible = false;
            Seleccionar.Visible = false;
            Nombre.Text = "Cantidad de Productos Existentes";


            List<Productos> cantidadProductosExistentes = await productosController.obtenerCantidadProductosExistentes();

            if (cantidadProductosExistentes != null && cantidadProductosExistentes.Count > 0)
            {
                dataVentasPorArticulo.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                foreach (var venta in cantidadProductosExistentes)
                {
                    DataGridViewRow row = new DataGridViewRow();
                    row.CreateCells(dataVentasPorArticulo);

                    row.Cells[0].Value = venta.IDProductos;
                    row.Cells[1].Value = venta.Titulo;
                    row.Cells[2].Value = venta.Descripcion;
                    dataVentasPorArticulo.Columns[3].Visible = false;
                    row.Cells[4].Value = venta.PrecioUnitario;
                    row.Cells[5].Value = venta.TotalVentas;
                    row.Cells[6].Value = venta.Existencias;

                    dataVentasPorArticulo.Rows.Add(row);
                }
            }
            else
            {
                MessageBox.Show("No se puede obtener la petición.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void obtenerCantidadProductosExistentesMenorACien()
        {
            LimpiarTabla();
            comboBox1.Visible = false;
            Obtener.Visible = false;
            Seleccionar.Visible = false;
            Nombre.Text = "Articulos menos a 100 existencias";


            List<Productos> cantidadProductosExistentes = await productosController.obtenerCantidadProductosExistentes();

            if (cantidadProductosExistentes != null && cantidadProductosExistentes.Count > 0)
            {
                dataVentasPorArticulo.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                foreach (var venta in cantidadProductosExistentes)
                {
                    if (venta.Existencias < 100)
                    {
                        DataGridViewRow row = new DataGridViewRow();
                        row.CreateCells(dataVentasPorArticulo);

                        row.Cells[0].Value = venta.IDProductos;
                        row.Cells[1].Value = venta.Titulo;
                        row.Cells[2].Value = venta.Descripcion;
                        dataVentasPorArticulo.Columns[3].Visible = false;
                        row.Cells[4].Value = venta.PrecioUnitario;
                        row.Cells[5].Value = venta.TotalVentas;
                        row.Cells[6].Value = venta.Existencias;

                        dataVentasPorArticulo.Rows.Add(row);
                    }
                }
            }
            else
            {
                MessageBox.Show("No se puede obtener la petición.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void obtenerProductos()
        {

            List<Productos> cantidadProductosExistentes = await productosController.obtenerCantidadProductosExistentes();

            if (cantidadProductosExistentes != null && cantidadProductosExistentes.Count > 0)
            {
                dataVentasPorArticulo.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                foreach (var venta in cantidadProductosExistentes)
                {
                    comboBox1.Items.Add(new Productos { IDProductos = venta.IDProductos, Titulo = venta.Titulo });
                }

                comboBox1.DisplayMember = "Titulo";

                comboBox1.ValueMember = "IDProductos";
            }
            else
            {
                MessageBox.Show("No se puede obtener la petición.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LimpiarTabla()
        {
            dataVentasPorArticulo.Rows.Clear();
            dataVentasPorArticulo.Columns[1].Visible = true;
            dataVentasPorArticulo.Columns[2].Visible = true;
            dataVentasPorArticulo.Columns[3].Visible = true;
            dataVentasPorArticulo.Columns[4].Visible = true;
            dataVentasPorArticulo.Columns[5].Visible = true;
            dataVentasPorArticulo.Columns[6].Visible = true;

            comboBox1.Visible= true;
            Obtener.Visible = true;
            Seleccionar.Visible = true;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {
        }

        private void label2_Click(object sender, EventArgs e)
        {
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            obtenerVentasPorArticulo();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            obtenerVentasGlobales();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            obtenerArticulosMasVendidos();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            obtenerCantidadProductosExistentes();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            obtenerCantidadProductosExistentesMenorACien();
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void Obtener_Click(object sender, EventArgs e)
        {
            obtenerVentasPorArticulo();
        }
    }
}
