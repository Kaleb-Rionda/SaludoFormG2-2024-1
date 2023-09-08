using System;
using System.Drawing;
using System.Windows.Forms;

namespace SaludoFormG2_2024_1
{
    internal partial class SaludoForm : Form
    {
        private Label lbNombre;
        private TextBox txtNombre;
        private Button btnAceptar;
        private Button btnLimpiar;



        public void InitializeComponent()
        {
            // Redimensionando y configurando la ventana
            this.Size = new System.Drawing.Size(600,400);
            this.Text = "form saludo";

            //Label : Ingresa tu nombre
            lbNombre = new Label(); //Instanciamos objeto
            lbNombre.Text = "Ingresa tu nombre";
            lbNombre.Location = new Point(200,100);//indica donde se pondra

            //Buttons

			btnAceptar = new Button(); //Instanciamos objeto
			btnAceptar.Text = "Aceptar";
			btnAceptar.Location = new Point(300, 200);//indica donde se pondra
            btnAceptar.Click += new EventHandler(btnAceptar_Click);

			btnLimpiar = new Button(); //Instanciamos objeto
			btnLimpiar.Text = "Limpiar";
			btnLimpiar.Location = new Point(100, 200);//indica donde se pondra

			txtNombre = new TextBox(); //Instanciamos objeto
			txtNombre.Text = "";
			txtNombre.Location = new Point(200, 150);//indica donde se pondr


			this.Controls.Add(lbNombre);

			this.Controls.Add(btnLimpiar);

			this.Controls.Add(btnAceptar);

			this.Controls.Add(txtNombre);
		}

    }
}
