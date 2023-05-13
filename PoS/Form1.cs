using System.Windows.Forms;

namespace PoS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            HoraFecha.Text = DateTime.Now.ToLongTimeString() + " " + DateTime.Now.ToLongDateString();
            //Localizacion del lable, con la linea 13, hacemos que se localice en la mitad.
            titulo.Location = new Point((this.Width / 2) - (titulo.Width / 2), 0);
            //Centramos el desarrollado por, sobre el titulo que realizamos la inicio. 
            Desarrollado.Location = new Point((this.Width / 2) - (Desarrollado.Width / 2), titulo.Height);
            labeltotal.Location = new Point((this.Width / 3));
            labeltotal.Location = new Point((this.Height / 3));
            //Hora y fecha está a altura sumada de lo que vale titulo, desarrollado, centrado. 
            HoraFecha.Location = new Point((this.Width / 2) - (HoraFecha.Width / 2), (titulo.Height + Desarrollado.Height));
            //Localizamos el datagrid, según al nivel de hora y fecha
            dataGridProductos.Location = new Point((10), (titulo.Height + Desarrollado.Height + HoraFecha.Height));
            dataGridProductos.Width = this.Width - 20;//Con esto separamos 10 pixeles entre el objeto y la ventana, de cada lado. 
            dataGridProductos.Height = (this.Height / 4) * 3;//Con esto le damos al 3/4 segun la altura
            pictureBoxLogo.Location = new Point((this.Width - pictureBoxLogo.Width), 0);
            txtCodigo.Location = new Point((10), this.Height - txtCodigo.Height);
            txtCodigo.Width = this.Width - 20;//esta segun el nivel del data grid. 


            dataGridProductos.Columns.Add("Cantidad", "Cantidad");//Aqui añadimos las columnas. 
            dataGridProductos.Columns[0].HeaderCell.Style.Font = new Font("Cambria Math", 20F);
            dataGridProductos.Columns[0].Width = dataGridProductos.Width / 10; //Porcentaje que tiene cada columna.
            dataGridProductos.Columns[0].ReadOnly = true; //Propiedad para que la columna no pueda ser modificada directamente.
            dataGridProductos.Columns.Add("Nombre", "Nombre");//Aqui añadimos las columnas. 
            dataGridProductos.Columns[1].Width = dataGridProductos.Width * 5 / 10; //Porcentaje que tiene cada columna.
            dataGridProductos.Columns[1].ReadOnly = true; //Propiedad para que la columna no pueda ser modificada directamente.
            dataGridProductos.Columns[1].HeaderCell.Style.Font = new Font("Cambria Math", 20F);
            dataGridProductos.Columns.Add("Precio", "Precio");//Aqui añadimos las columnas. 
            dataGridProductos.Columns[2].Width = dataGridProductos.Width * 2 / 10; //Porcentaje que tiene cada columna
            dataGridProductos.Columns[2].ReadOnly = true; //Propiedad para que la columna no pueda ser modificada directamente.
            dataGridProductos.Columns[2].HeaderCell.Style.Font = new Font("Cambria Math", 20F);
            dataGridProductos.Columns.Add("Total", "Total");//Aqui añadimos las columnas. 
            dataGridProductos.Columns[3].Width = dataGridProductos.Width * 2 / 10; //Porcentaje que tiene cada columna
            dataGridProductos.Columns[3].ReadOnly = true; //Propiedad para que la columna no pueda ser modificada directamente.
            dataGridProductos.Columns[3].HeaderCell.Style.Font = new Font("Cambria Math", 20F);

            txtCodigo.TabIndex = 0; //Cuando se inicia la forma, el cursor estará en el Text Box del código de barras.

            int posicion = (this.Height - (titulo.Height + Desarrollado.Height + HoraFecha.Height + dataGridProductos.Height + txtCodigo.Height));
            labeltotal.Location = new Point(10 + dataGridProductos.Columns[0].Width + dataGridProductos.Columns[1].Width + dataGridProductos.Columns[2].Width,
            (titulo.Height + Desarrollado.Height + HoraFecha.Height + dataGridProductos.Height) + posicion / 4); //Localización del label de Total.
            Font fuente = new Font("Cambria Math", 20F);
            labeltotal.Font = fuente;

        }

        //Personalizamos el lable de hora y fecha según la hora y fecha del sistema, esta se actualiza. 
        private void time_Tick(object sender, EventArgs e)
        {
            HoraFecha.Text = DateTime.Now.ToLongTimeString() + " " + DateTime.Now.ToLongDateString();
        }

        private void txtCodigo_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyCode == Keys.Tab)
            {
                e.IsInputKey = true;
            }
        }

        private void txtCodigo_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)//Para cuando el usuario presione Enter, se mande el mensaje.
            {
                MessageBox.Show("SELECT * FROM productos WHERE codigo = " + "'" + txtCodigo.Text + "'");
                txtCodigo.Clear();
            }
        }
    }
}