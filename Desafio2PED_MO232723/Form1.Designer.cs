namespace Desafio2PED_MO232723
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
            label1 = new Label();
            label2 = new Label();
            groupBox1 = new GroupBox();
            btnList = new Button();
            btnDelete = new Button();
            btnAdd = new Button();
            txtCantidad = new TextBox();
            label8 = new Label();
            txtPrecio = new TextBox();
            label7 = new Label();
            cmbCategoria = new ComboBox();
            label6 = new Label();
            txtNombre = new TextBox();
            label5 = new Label();
            txtCodigo = new TextBox();
            label4 = new Label();
            label3 = new Label();
            btnSearch = new Button();
            dataGridView1 = new DataGridView();
            txtCodBuscar = new TextBox();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Lime;
            label1.Location = new Point(322, 22);
            label1.Name = "label1";
            label1.Size = new Size(209, 25);
            label1.TabIndex = 0;
            label1.Text = "SISTEMAS DE VENTAS";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.Lime;
            label2.Location = new Point(12, 426);
            label2.Name = "label2";
            label2.Size = new Size(234, 15);
            label2.TabIndex = 1;
            label2.Text = "Creado por William Mazariego - MO232723";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnList);
            groupBox1.Controls.Add(btnDelete);
            groupBox1.Controls.Add(btnAdd);
            groupBox1.Controls.Add(txtCantidad);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(txtPrecio);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(cmbCategoria);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(txtNombre);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(txtCodigo);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.ForeColor = Color.Lime;
            groupBox1.Location = new Point(22, 66);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(401, 329);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Datos a Ingresar";
            // 
            // btnList
            // 
            btnList.BackColor = Color.Cyan;
            btnList.ForeColor = Color.Black;
            btnList.Location = new Point(289, 263);
            btnList.Name = "btnList";
            btnList.Size = new Size(90, 40);
            btnList.TabIndex = 14;
            btnList.Text = "Listar";
            btnList.UseVisualStyleBackColor = false;
            btnList.Click += btnList_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.Yellow;
            btnDelete.ForeColor = Color.Black;
            btnDelete.Location = new Point(156, 263);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(99, 40);
            btnDelete.TabIndex = 13;
            btnDelete.Text = "Eliminar";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.Red;
            btnAdd.ForeColor = Color.White;
            btnAdd.Location = new Point(10, 263);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(106, 40);
            btnAdd.TabIndex = 11;
            btnAdd.Text = "Agregar";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // txtCantidad
            // 
            txtCantidad.Location = new Point(70, 225);
            txtCantidad.Multiline = true;
            txtCantidad.Name = "txtCantidad";
            txtCantidad.Size = new Size(102, 23);
            txtCantidad.TabIndex = 10;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(6, 225);
            label8.Name = "label8";
            label8.Size = new Size(58, 15);
            label8.TabIndex = 9;
            label8.Text = "Cantidad:";
            // 
            // txtPrecio
            // 
            txtPrecio.Location = new Point(69, 191);
            txtPrecio.Multiline = true;
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(102, 23);
            txtPrecio.TabIndex = 8;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(6, 194);
            label7.Name = "label7";
            label7.Size = new Size(60, 15);
            label7.TabIndex = 7;
            label7.Text = "Precio ($):";
            // 
            // cmbCategoria
            // 
            cmbCategoria.FormattingEnabled = true;
            cmbCategoria.Items.AddRange(new object[] { "Ropa", "Calzado", "Hogar", "Comida", "Técnologia", "Jardín", "Automotriz" });
            cmbCategoria.Location = new Point(69, 155);
            cmbCategoria.Name = "cmbCategoria";
            cmbCategoria.Size = new Size(115, 23);
            cmbCategoria.TabIndex = 6;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(6, 158);
            label6.Name = "label6";
            label6.Size = new Size(61, 15);
            label6.TabIndex = 5;
            label6.Text = "Categoria:";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(69, 118);
            txtNombre.Multiline = true;
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(206, 23);
            txtNombre.TabIndex = 4;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(10, 121);
            label5.Name = "label5";
            label5.Size = new Size(54, 15);
            label5.TabIndex = 3;
            label5.Text = "Nombre:";
            // 
            // txtCodigo
            // 
            txtCodigo.Location = new Point(69, 77);
            txtCodigo.Multiline = true;
            txtCodigo.Name = "txtCodigo";
            txtCodigo.Size = new Size(102, 23);
            txtCodigo.TabIndex = 2;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(10, 80);
            label4.Name = "label4";
            label4.Size = new Size(49, 15);
            label4.TabIndex = 1;
            label4.Text = "Codigo:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Red;
            label3.Location = new Point(69, 28);
            label3.Name = "label3";
            label3.Size = new Size(257, 15);
            label3.TabIndex = 0;
            label3.Text = "** TODOS LOS CAMPOS SON OBLIGATORIOS **";
            // 
            // btnSearch
            // 
            btnSearch.BackColor = Color.Blue;
            btnSearch.ForeColor = Color.White;
            btnSearch.Location = new Point(565, 81);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(78, 40);
            btnSearch.TabIndex = 12;
            btnSearch.Text = "Buscar";
            btnSearch.UseVisualStyleBackColor = false;
            btnSearch.Click += btnSearch_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(447, 143);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(613, 343);
            dataGridView1.TabIndex = 3;
            // 
            // txtCodBuscar
            // 
            txtCodBuscar.Location = new Point(447, 81);
            txtCodBuscar.Multiline = true;
            txtCodBuscar.Name = "txtCodBuscar";
            txtCodBuscar.Size = new Size(100, 40);
            txtCodBuscar.TabIndex = 13;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(1072, 588);
            Controls.Add(txtCodBuscar);
            Controls.Add(dataGridView1);
            Controls.Add(groupBox1);
            Controls.Add(btnSearch);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private GroupBox groupBox1;
        private Label label3;
        private Label label5;
        private TextBox txtCodigo;
        private Label label4;
        private TextBox txtCantidad;
        private Label label8;
        private TextBox txtPrecio;
        private Label label7;
        private ComboBox cmbCategoria;
        private Label label6;
        private TextBox txtNombre;
        private Button btnAdd;
        private Button btnList;
        private Button btnDelete;
        private Button btnSearch;
        private DataGridView dataGridView1;
        private TextBox txtCodBuscar;
    }
}
