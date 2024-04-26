namespace TiendaProductos
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
            textBox1 = new TextBox();
            panel1 = new Panel();
            Obtener = new Button();
            comboBox1 = new ComboBox();
            Seleccionar = new Label();
            button5 = new Button();
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            Nombre = new Label();
            dataVentasPorArticulo = new DataGridView();
            IDProducto = new DataGridViewTextBoxColumn();
            Titulo = new DataGridViewTextBoxColumn();
            Descripcion = new DataGridViewTextBoxColumn();
            TotalVendido = new DataGridViewTextBoxColumn();
            PrecioUnitario = new DataGridViewTextBoxColumn();
            TotalVentas = new DataGridViewTextBoxColumn();
            Existencias = new DataGridViewTextBoxColumn();
            label1 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataVentasPorArticulo).BeginInit();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.CornflowerBlue;
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox1.ForeColor = SystemColors.Menu;
            textBox1.Location = new Point(-1, -1);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(765, 32);
            textBox1.TabIndex = 0;
            textBox1.Text = "INFORMACIÓN DE PRODUCTOS DE LIMPIEZA";
            textBox1.TextAlign = HorizontalAlignment.Center;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.BackgroundImageLayout = ImageLayout.None;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(Obtener);
            panel1.Controls.Add(comboBox1);
            panel1.Controls.Add(Seleccionar);
            panel1.Controls.Add(button5);
            panel1.Controls.Add(button4);
            panel1.Controls.Add(button3);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(Nombre);
            panel1.Controls.Add(dataVentasPorArticulo);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(25, 51);
            panel1.Name = "panel1";
            panel1.Size = new Size(704, 374);
            panel1.TabIndex = 1;
            // 
            // Obtener
            // 
            Obtener.Location = new Point(399, 54);
            Obtener.Name = "Obtener";
            Obtener.Size = new Size(75, 23);
            Obtener.TabIndex = 12;
            Obtener.Text = "Obtener";
            Obtener.UseVisualStyleBackColor = true;
            Obtener.Click += Obtener_Click;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(491, 54);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(188, 23);
            comboBox1.TabIndex = 11;
            // 
            // Seleccionar
            // 
            Seleccionar.AutoSize = true;
            Seleccionar.Location = new Point(556, 36);
            Seleccionar.Name = "Seleccionar";
            Seleccionar.Size = new Size(123, 15);
            Seleccionar.TabIndex = 9;
            Seleccionar.Text = "Selecciona un articulo";
            Seleccionar.Click += label3_Click;
            // 
            // button5
            // 
            button5.Location = new Point(30, 292);
            button5.Name = "button5";
            button5.Size = new Size(89, 54);
            button5.TabIndex = 8;
            button5.Text = "Productos menor a 100";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button4
            // 
            button4.Location = new Point(30, 228);
            button4.Name = "button4";
            button4.Size = new Size(89, 58);
            button4.TabIndex = 7;
            button4.Text = "Cantidad productos existentes";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button3
            // 
            button3.Location = new Point(30, 178);
            button3.Name = "button3";
            button3.Size = new Size(89, 44);
            button3.TabIndex = 6;
            button3.Text = "Articulos mas vendidos";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.Location = new Point(30, 129);
            button2.Name = "button2";
            button2.Size = new Size(89, 43);
            button2.TabIndex = 5;
            button2.Text = "Ventas globales";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Location = new Point(30, 82);
            button1.Name = "button1";
            button1.Size = new Size(89, 41);
            button1.TabIndex = 4;
            button1.Text = "Ventas por articulo";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Nombre
            // 
            Nombre.AutoSize = true;
            Nombre.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Nombre.Location = new Point(142, 52);
            Nombre.Name = "Nombre";
            Nombre.Size = new Size(111, 15);
            Nombre.TabIndex = 3;
            Nombre.Text = "Ventas por articulo";
            Nombre.Click += label2_Click;
            // 
            // dataVentasPorArticulo
            // 
            dataVentasPorArticulo.BackgroundColor = SystemColors.Control;
            dataVentasPorArticulo.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataVentasPorArticulo.Columns.AddRange(new DataGridViewColumn[] { IDProducto, Titulo, Descripcion, TotalVendido, PrecioUnitario, TotalVentas, Existencias });
            dataVentasPorArticulo.Location = new Point(142, 82);
            dataVentasPorArticulo.Name = "dataVentasPorArticulo";
            dataVentasPorArticulo.Size = new Size(537, 264);
            dataVentasPorArticulo.TabIndex = 1;
            // 
            // IDProducto
            // 
            IDProducto.HeaderText = "IDProducto";
            IDProducto.Name = "IDProducto";
            // 
            // Titulo
            // 
            Titulo.HeaderText = "Titulo";
            Titulo.Name = "Titulo";
            // 
            // Descripcion
            // 
            Descripcion.HeaderText = "Descripcion";
            Descripcion.Name = "Descripcion";
            // 
            // TotalVendido
            // 
            TotalVendido.HeaderText = "Total Vendido";
            TotalVendido.Name = "TotalVendido";
            // 
            // PrecioUnitario
            // 
            PrecioUnitario.HeaderText = "Precio Unitario";
            PrecioUnitario.Name = "PrecioUnitario";
            // 
            // TotalVentas
            // 
            TotalVentas.HeaderText = "Total Ventas";
            TotalVentas.Name = "TotalVentas";
            // 
            // Existencias
            // 
            Existencias.HeaderText = "Existencias";
            Existencias.Name = "Existencias";
            // 
            // label1
            // 
            label1.AccessibleRole = AccessibleRole.Window;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(253, 13);
            label1.Name = "label1";
            label1.Size = new Size(183, 21);
            label1.TabIndex = 0;
            label1.Text = "Productos de Limpieza";
            label1.Click += label1_Click_1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Lavender;
            ClientSize = new Size(759, 450);
            Controls.Add(panel1);
            Controls.Add(textBox1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataVentasPorArticulo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private Panel panel1;
        private Label label1;
        private DataGridView dataVentasPorArticulo;
        private Label Nombre;
        private Button button5;
        private Button button4;
        private Button button3;
        private Button button2;
        private Button button1;
        private Label Seleccionar;
        private DataGridViewTextBoxColumn IDProducto;
        private DataGridViewTextBoxColumn Titulo;
        private DataGridViewTextBoxColumn Descripcion;
        private DataGridViewTextBoxColumn TotalVendido;
        private DataGridViewTextBoxColumn PrecioUnitario;
        private DataGridViewTextBoxColumn TotalVentas;
        private DataGridViewTextBoxColumn Existencias;
        private ComboBox comboBox1;
        private Button Obtener;
    }
}
