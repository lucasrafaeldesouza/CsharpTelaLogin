using System;
using System.Linq;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Drawing;
using System.ComponentModel;
using System.Diagnostics;
using System.Threading;
using System.IO;

namespace exemplo_winforms
{
    static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            //Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }

    public class Form1 : Form
    {
        private System.ComponentModel.IContainer components = null;

        Label lblUser;
        Label lblPass;


        TextBox txtUser;
        TextBox txtPass;

        Button btnConfirm;
        Button btnCancel;

        public Form1()
        {
            this.lblUser = new Label();
            this.lblUser.Text = "Usuário";
            this.lblUser.Location = new Point(120, 20);

            this.lblPass = new Label();
            this.lblPass.Text = "Senha";
            this.lblPass.Location = new Point(120, 80);

            this.txtUser = new TextBox();
            this.txtUser.Location = new Point(10,50);
            this.txtUser.Size = new Size(280,30);

            this.txtPass = new TextBox();
            this.txtPass.Location = new Point(10,110);
            this.txtPass.Size = new Size(280,30);
            this.txtPass.PasswordChar = '*';

            this.btnConfirm = new Button();
            this.btnConfirm.Text = "Confirmar";
            this.btnConfirm.Location = new Point(100,180);
            this.btnConfirm.Size = new Size(80,30);
            this.btnConfirm.Click += new EventHandler(this.handleConfirmClick);
            
            
            this.btnCancel = new Button();
            this.btnCancel.Text = "Cancelar";
            this.btnCancel.Location = new Point(100,220);
            this.btnCancel.Size = new Size(80,30);
            this.btnCancel.Click += new EventHandler(this.handleCancelClick);

            this.Controls.Add(this.lblUser);
            this.Controls.Add(this.lblPass);
            this.Controls.Add(this.txtUser);
            this.Controls.Add(this.txtPass);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnConfirm);

            this.components = new System.ComponentModel.Container();
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 300);
            this.Text = "Login";
            this.StartPosition = FormStartPosition.CenterScreen;
        }


        private void handleConfirmClick(object sender, EventArgs e) {
            Form2 form = new Form2();
            form.Show();
        }

        private void handleCancelClick(object sender, EventArgs e) {
            this.Close();
        }
    }

    public class Form2 : Form
    {
        private System.ComponentModel.IContainer components = null;

        Label lblDentista;

        Button btnDentista;
        Button btnPaciente;
        Button btnProcedi;
        Button btnEspeciali;
        Button btnSala;
        Button btnAgendamento;
        Button btnCancel;

        public Form2()
        {
            //this.Text = "Dentista";

            this.lblDentista = new Label();
            this.lblDentista.Text = "Dentista";
            this.lblDentista.Location = new Point(120, 40);

            this.btnDentista = new Button();
            this.btnDentista.Text = "Dentista";
            this.btnDentista.Location = new Point(40,80);
            this.btnDentista.Size = new Size(80,30);
            
            this.btnPaciente = new Button();
            this.btnPaciente.Text = "Paciente";
            this.btnPaciente.Location = new Point(160,80);
            this.btnPaciente.Size = new Size(80,30);

            this.btnProcedi = new Button();
            this.btnProcedi.Text = "Procedi";
            this.btnProcedi.Location = new Point(40,120);
            this.btnProcedi.Size = new Size(80,30);

            this.btnEspeciali = new Button();
            this.btnEspeciali.Text = "Especiali";
            this.btnEspeciali.Location = new Point(160,120);
            this.btnEspeciali.Size = new Size(80,30);

            this.btnSala = new Button();
            this.btnSala.Text = "Sala";
            this.btnSala.Location = new Point(40,160);
            this.btnSala.Size = new Size(80,30);

            this.btnAgendamento = new Button();
            this.btnAgendamento.Text = "Agenda";
            this.btnAgendamento.Location = new Point(160,160);
            this.btnAgendamento.Size = new Size(80,30);

            this.btnCancel = new Button();
            this.btnCancel.Text = "Cancelar";
            this.btnCancel.Location = new Point(100,220);
            this.btnCancel.Size = new Size(80,30);
            this.btnCancel.Click += new EventHandler(this.handleCancelClick);

            this.Controls.Add(this.lblDentista);

            this.Controls.Add(this.btnDentista);
            this.Controls.Add(this.btnPaciente);
            this.Controls.Add(this.btnProcedi);
            this.Controls.Add(this.btnEspeciali);
            this.Controls.Add(this.btnSala);
            this.Controls.Add(this.btnAgendamento);
            this.Controls.Add(this.btnCancel);
            
        }

        private void handleConfirmClick(object sender, EventArgs e) {
        }
        private void handleCancelClick(object sender, EventArgs e) {
            this.Close();
        }
    }
}