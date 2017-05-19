using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProyectoPlantillaPersonal.Formularios;
using ProyectoPlantillaPersonal.Modelos;

namespace ProyectoPlantillaPersonal
{
    public partial class Loggin : Form
    {
        ModeloCuenta modeloCuenta { get; set; }
        public Loggin()
        {
            InitializeComponent();
            modeloCuenta = new ModeloCuenta();
        }
        
        
        private void btnIniciarSesion_Click(object sender, EventArgs e)
        {
           
            using (Modelos.SistemaPlantillaPersonalEntities entity = new Modelos.SistemaPlantillaPersonalEntities()) {
                Cuenta cuenta;
                try
                {
                    cuenta = modeloCuenta.seleccionarCuenta(txtUsuario.Text, txtPassword.Text);
                }
                catch (Exception)
                {

                    cuenta = null;
                }
                
                if (cuenta != null)
                {
                    if (cuenta.tipo.Equals("Administrador"))
                    {
                        MenuPrincipalAdministrador form = new MenuPrincipalAdministrador();
                        form.Show();
                        this.Visible = false;
                    }
                    else {
                        if (cuenta.tipo.Equals("Visor"))
                        {
                            MenuPrincipalVisor form = new MenuPrincipalVisor();
                            form.Show();
                            this.Visible = false;
                        }
                        else
                        {
                            if (cuenta.tipo.Equals("Gestor"))
                            {
                                MenuPrincipalGestor form = new MenuPrincipalGestor();
                                form.Show();
                                this.Visible = false;
                            }
                            else
                            {
                                MessageBox.Show("Usuario no reconocido");
                            }
                        }
                    }
                }
                else {
                    MessageBox.Show("Usuario o contraseña incorrectos");
                }
                

                this.txtPassword.ResetText();
            }
                
            //this.txtUsuario.ResetText(); 
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (e.CloseReason==CloseReason.UserClosing) {
                Application.Exit();
            }
        }

        private void txtUsuario_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 13) {
                btnIniciarSesion.PerformClick();
            }
        }


    }
}
