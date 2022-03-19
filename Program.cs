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
            this.txtUser.Location = new Point(10, 50);
            this.txtUser.Size = new Size(280, 30);

            this.txtPass = new TextBox();
            this.txtPass.Location = new Point(10, 110);
            this.txtPass.Size = new Size(280, 30);
            this.txtPass.PasswordChar = '*';

            this.btnConfirm = new Button();
            this.btnConfirm.Text = "Confirmar";
            this.btnConfirm.Location = new Point(100, 180);
            this.btnConfirm.Size = new Size(80, 30);
            this.btnConfirm.Click += new EventHandler(this.handleConfirmClick);


            this.btnCancel = new Button();
            this.btnCancel.Text = "Cancelar";
            this.btnCancel.Location = new Point(100, 220);
            this.btnCancel.Size = new Size(80, 30);
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


        private void handleConfirmClick(object sender, EventArgs e)
        {

            if (this.txtUser.Text == "dentista" && this.txtPass.Text == "123")
            {
                Form2 form = new Form2();
                form.Show();
            }
            else
            {
                //Form3 form = new Form3();
                //form.Show();

            }
        }

        private void handleCancelClick(object sender, EventArgs e)
        {
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
            this.lblDentista.Location = new Point(120, 20);

            this.btnDentista = new Button();
            this.btnDentista.Text = "Dentista";
            this.btnDentista.Location = new Point(40, 60);
            this.btnDentista.Size = new Size(80, 30);
            this.btnDentista.Click += new EventHandler(this.handleConfirmDentista);

            this.btnPaciente = new Button();
            this.btnPaciente.Text = "Paciente";
            this.btnPaciente.Location = new Point(160, 60);
            this.btnPaciente.Size = new Size(80, 30);
            this.btnPaciente.Click += new EventHandler(this.handleConfirmPaciente);

            this.btnProcedi = new Button();
            this.btnProcedi.Text = "Procedi";
            this.btnProcedi.Location = new Point(40, 100);
            this.btnProcedi.Size = new Size(80, 30);
            this.btnProcedi.Click += new EventHandler(this.handleConfirmProcedimento);

            this.btnEspeciali = new Button();
            this.btnEspeciali.Text = "Especiali";
            this.btnEspeciali.Location = new Point(160, 100);
            this.btnEspeciali.Size = new Size(80, 30);

            this.btnSala = new Button();
            this.btnSala.Text = "Sala";
            this.btnSala.Location = new Point(40, 140);
            this.btnSala.Size = new Size(80, 30);

            this.btnAgendamento = new Button();
            this.btnAgendamento.Text = "Agenda";
            this.btnAgendamento.Location = new Point(160, 140);
            this.btnAgendamento.Size = new Size(80, 30);

            this.btnCancel = new Button();
            this.btnCancel.Text = "Cancelar";
            this.btnCancel.Location = new Point(100, 200);
            this.btnCancel.Size = new Size(80, 30);
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
        private void handleConfirmPaciente(object sender, EventArgs e)
        {
            Form3 menu = new Form3();
            menu.ShowDialog();
        }
         private void handleConfirmDentista(object sender, EventArgs e)
        {
            Form7 menu = new Form7();
            menu.ShowDialog();
        }
         private void handleConfirmProcedimento(object sender, EventArgs e)
        {
            Form8 menu = new Form8();
            menu.ShowDialog();
        }
        private void handleCancelClick(object sender, EventArgs e)
        {
            this.Close();
        }
    }

    public class Form3 : Form
    {
        private System.ComponentModel.IContainer components = null;

        Label lblPaciente;

        Button btnCancel;

        Button btnInsert;
        Button btnDeletar;
        Button btnUpdate;

        ListView listView;
        public Form3()
        {
            //this.Text = "Paciente";

            this.lblPaciente = new Label();
            this.lblPaciente.Text = "Paciente";
            this.lblPaciente.Location = new Point(220, 10);

            this.Controls.Add(this.lblPaciente);

            listView = new ListView();
            listView.Location = new Point(45, 70);
            listView.Size = new Size(410, 100);
            listView.View = View.Details;
            ListViewItem lista1 = new ListViewItem("Lucas Rafael");
            lista1.SubItems.Add("Maria");
            lista1.SubItems.Add("Obturação");
            lista1.SubItems.Add("Clareamento");
            lista1.SubItems.Add("7");
            lista1.SubItems.Add("...");

            ListViewItem lista2 = new ListViewItem("Lucas Rafael");
            lista2.SubItems.Add("Maria");
            lista2.SubItems.Add("Obturação");
            lista2.SubItems.Add("Clareamento");
            lista2.SubItems.Add("7");
            lista2.SubItems.Add("...");

            ListViewItem lista3 = new ListViewItem("Lucas Rafael");
            lista3.SubItems.Add("Maria");
            lista3.SubItems.Add("Obturação");
            lista3.SubItems.Add("Clareamento");
            lista3.SubItems.Add("7");
            lista3.SubItems.Add("...");

            listView.Items.AddRange(new ListViewItem[] { lista1, lista2, lista3 });
            listView.Columns.Add("Dentista", -2, HorizontalAlignment.Left);
            listView.Columns.Add("Paciente", -2, HorizontalAlignment.Left);
            listView.Columns.Add("Procedimento", -2, HorizontalAlignment.Left);
            listView.Columns.Add("Especialidade", -2, HorizontalAlignment.Left);
            listView.Columns.Add("Sala", -2, HorizontalAlignment.Left);
            listView.Columns.Add("Status", -2, HorizontalAlignment.Left);
            listView.FullRowSelect = true;
            listView.GridLines = true;
            listView.AllowColumnReorder = true;
            listView.Sorting = SortOrder.Ascending;

            this.btnCancel = new Button();
            this.btnCancel.Text = "Cancelar";
            this.btnCancel.Location = new Point(360, 220);
            this.btnCancel.Size = new Size(80, 30);
            this.btnCancel.Click += new EventHandler(this.handleCancelClick);

            this.btnInsert = new Button();
            this.btnInsert.Text = "Inserir";
            this.btnInsert.Location = new Point(60, 220);
            this.btnInsert.Size = new Size(80, 30);
            this.btnInsert.Click += new EventHandler(this.handleConfirmClickInserir);

            this.btnDeletar = new Button();
            this.btnDeletar.Text = "Deletar";
            this.btnDeletar.Location = new Point(160, 220);
            this.btnDeletar.Size = new Size(80, 30);
            this.btnDeletar.Click += new EventHandler(this.handleConfirmClickDeletar);

            this.btnUpdate = new Button();
            this.btnUpdate.Text = "Atualizar";
            this.btnUpdate.Location = new Point(260, 220);
            this.btnUpdate.Size = new Size(80, 30);
            this.btnUpdate.Click += new EventHandler(this.handleConfirmClickAtualizar);

            this.Controls.Add(listView);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.btnDeletar);
            this.Controls.Add(this.btnUpdate);

            this.ClientSize = new System.Drawing.Size(500, 300);
        }

        private void handleConfirmClickAtualizar(object sender, EventArgs e)
        {
            Form6 menu = new Form6();
            menu.ShowDialog();
        }
         private void handleConfirmClickDeletar(object sender, EventArgs e)
        {
            DialogResult result;
            result = MessageBox.Show(
                $"Deseja realmente excluir o paciente?" +
                $"",
                "STATUS!",
                MessageBoxButtons.YesNo
            );
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
            else
            {
                Console.WriteLine("Clicou não");
            }
        }
        private void handleConfirmClickInserir(object sender, EventArgs e)
        {
            Form4 menu = new Form4();
            menu.ShowDialog();
        }
        private void handleConfirmClick(object sender, EventArgs e)
        {
            DialogResult result;
            result = MessageBox.Show(
                $"Deseja realmente confirmar o agendamento?" +
                $"",
                "STATUS!",
                MessageBoxButtons.YesNo
            );
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
            else
            {
                Console.WriteLine("Clicou não");
            }
        }
        private void handleCancelClick(object sender, EventArgs e)
        {

            this.Close();
        }
    }

        public class Form4 : Form
        {
            private System.ComponentModel.IContainer components = null;

            Label lblNome;
            Label lblNascimento;
            Label lblCpf;
            TextBox txtNome;
            TextBox txtNascimento;
            TextBox txtCpf;

            Button btnConfirm;
            Button btnCancel;

            public Form4()
            {
                this.lblNome = new Label();
                this.lblNome.Text = "Nome";
                this.lblNome.Location = new Point(120, 20);

                this.lblNascimento = new Label();
                this.lblNascimento.Text = "Dt. Nascimento";
                this.lblNascimento.Location = new Point(100, 80);

                this.lblCpf = new Label();
                this.lblCpf.Text = "CPF";
                this.lblCpf.Location = new Point(130, 140);

                this.txtNome = new TextBox();
                this.txtNome.Location = new Point(10, 50);
                this.txtNome.Size = new Size(280, 30);

                this.txtNascimento = new TextBox();
                this.txtNascimento.Location = new Point(10, 110);
                this.txtNascimento.Size = new Size(280, 30);
                this.txtNascimento.PasswordChar = '*';

                this.txtCpf = new TextBox();
                this.txtCpf.Location = new Point(10, 170);
                this.txtCpf.Size = new Size(280, 30);
                this.txtCpf.PasswordChar = '*';

                this.btnConfirm = new Button();
                this.btnConfirm.Text = "Confirmar";
                this.btnConfirm.Location = new Point(100, 220);
                this.btnConfirm.Size = new Size(80, 30);
                this.btnConfirm.Click += new EventHandler(this.handleConfirmClick);

                this.btnCancel = new Button();
                this.btnCancel.Text = "Cancelar";
                this.btnCancel.Location = new Point(100, 260);
                this.btnCancel.Size = new Size(80, 30);
                this.btnCancel.Click += new EventHandler(this.handleCancelClick);

                this.Controls.Add(this.lblNome);
                this.Controls.Add(this.lblNascimento);
                this.Controls.Add(this.lblCpf);
                this.Controls.Add(this.txtNome);
                this.Controls.Add(this.txtNascimento);
                this.Controls.Add(this.txtCpf);
                this.Controls.Add(this.btnCancel);
                this.Controls.Add(this.btnConfirm);

                this.components = new System.ComponentModel.Container();
                this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
                this.ClientSize = new System.Drawing.Size(300, 300);
                this.Text = "Inserir Paciente ";
                this.StartPosition = FormStartPosition.CenterScreen;
            }
            private void handleConfirmClick(object sender, EventArgs e)
            {

            }

            private void handleCancelClick(object sender, EventArgs e)
            {
                this.Close();
            }
    
        }
           public class Form5 : Form
            {
            Label lblId;
            TextBox TxtId;

            public Form5()
            {
                this.lblId = new Label();
                this.lblId.Text = "Deseja realmente excluir esse registro:";
                this.lblId.Location = new Point(120, 20);

                this.TxtId = new TextBox();
                this.TxtId.Location = new Point(10, 50);
                this.TxtId.Size = new Size(280, 30);

                this.Controls.Add(this.lblId);
                this.Controls.Add(this.TxtId);

                //this.components = new System.ComponentModel.Container();
                this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
                this.ClientSize = new System.Drawing.Size(300, 300);
                this.Text = "Deletar Paciente ";
                this.StartPosition = FormStartPosition.CenterScreen;
            }
        }

            public class Form6 : Form
            {
            Label lblNome;
            Label lblNascimento;
            Label lblCpf;
            TextBox txtNome;
            TextBox txtNascimento;
            TextBox txtCpf;

            Button btnConfirm;
            Button btnCancel;

            public Form6()
            {
                this.lblNome = new Label();
                this.lblNome.Text = "Nome";
                this.lblNome.Location = new Point(120, 20);

                this.lblNascimento = new Label();
                this.lblNascimento.Text = "Dt. Nascimento";
                this.lblNascimento.Location = new Point(100, 80);

                this.lblCpf = new Label();
                this.lblCpf.Text = "CPF";
                this.lblCpf.Location = new Point(130, 140);

                this.txtNome = new TextBox();
                this.txtNome.Location = new Point(10, 50);
                this.txtNome.Size = new Size(280, 30);

                this.txtNascimento = new TextBox();
                this.txtNascimento.Location = new Point(10, 110);
                this.txtNascimento.Size = new Size(280, 30);
                this.txtNascimento.PasswordChar = '*';

                this.txtCpf = new TextBox();
                this.txtCpf.Location = new Point(10, 170);
                this.txtCpf.Size = new Size(280, 30);
                this.txtCpf.PasswordChar = '*';

                this.btnConfirm = new Button();
                this.btnConfirm.Text = "Confirmar";
                this.btnConfirm.Location = new Point(100, 220);
                this.btnConfirm.Size = new Size(80, 30);
                this.btnConfirm.Click += new EventHandler(this.handleConfirmClick);

                this.btnCancel = new Button();
                this.btnCancel.Text = "Cancelar";
                this.btnCancel.Location = new Point(100, 260);
                this.btnCancel.Size = new Size(80, 30);
                this.btnCancel.Click += new EventHandler(this.handleCancelClick);

                this.Controls.Add(this.lblNome);
                this.Controls.Add(this.lblNascimento);
                this.Controls.Add(this.lblCpf);
                this.Controls.Add(this.txtNome);
                this.Controls.Add(this.txtNascimento);
                this.Controls.Add(this.txtCpf);
                this.Controls.Add(this.btnCancel);
                this.Controls.Add(this.btnConfirm);

                //this.components = new System.ComponentModel.Container();
                this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
                this.ClientSize = new System.Drawing.Size(300, 300);
                this.Text = "Atualizar Paciente ";
                this.StartPosition = FormStartPosition.CenterScreen;
            }
              private void handleConfirmClick(object sender, EventArgs e)
            {

            }
            private void handleCancelClick(object sender, EventArgs e)
            {
                this.Close();
            }
        }

     public class Form7 : Form
        {
        private System.ComponentModel.IContainer components = null;

        Label lblDentista;

        Button btnCancel;

        Button btnInsert;
        Button btnDeletar;
        Button btnUpdate;

        ListView listView;
        public Form7()
        {
            //this.Text = "Paciente";

            this.lblDentista = new Label();
            this.lblDentista.Text = "Dentista";
            this.lblDentista.Location = new Point(220, 10);

            this.Controls.Add(this.lblDentista);

            listView = new ListView();
            listView.Location = new Point(45, 70);
            listView.Size = new Size(410, 100);
            listView.View = View.Details;
            ListViewItem lista1 = new ListViewItem("Lucas Rafael");
            lista1.SubItems.Add("Maria");
            lista1.SubItems.Add("Obturação");
            lista1.SubItems.Add("Clareamento");
            lista1.SubItems.Add("7");
            lista1.SubItems.Add("...");

            ListViewItem lista2 = new ListViewItem("Lucas Rafael");
            lista2.SubItems.Add("Maria");
            lista2.SubItems.Add("Obturação");
            lista2.SubItems.Add("Clareamento");
            lista2.SubItems.Add("7");
            lista2.SubItems.Add("...");

            ListViewItem lista3 = new ListViewItem("Lucas Rafael");
            lista3.SubItems.Add("Maria");
            lista3.SubItems.Add("Obturação");
            lista3.SubItems.Add("Clareamento");
            lista3.SubItems.Add("7");
            lista3.SubItems.Add("...");

            listView.Items.AddRange(new ListViewItem[] { lista1, lista2, lista3 });
            listView.Columns.Add("Dentista", -2, HorizontalAlignment.Left);
            listView.Columns.Add("Paciente", -2, HorizontalAlignment.Left);
            listView.Columns.Add("Procedimento", -2, HorizontalAlignment.Left);
            listView.Columns.Add("Especialidade", -2, HorizontalAlignment.Left);
            listView.Columns.Add("Sala", -2, HorizontalAlignment.Left);
            listView.Columns.Add("Status", -2, HorizontalAlignment.Left);
            listView.FullRowSelect = true;
            listView.GridLines = true;
            listView.AllowColumnReorder = true;
            listView.Sorting = SortOrder.Ascending;

            this.btnCancel = new Button();
            this.btnCancel.Text = "Cancelar";
            this.btnCancel.Location = new Point(360, 220);
            this.btnCancel.Size = new Size(80, 30);
            this.btnCancel.Click += new EventHandler(this.handleCancelClick);

            this.btnInsert = new Button();
            this.btnInsert.Text = "Inserir";
            this.btnInsert.Location = new Point(60, 220);
            this.btnInsert.Size = new Size(80, 30);
            this.btnInsert.Click += new EventHandler(this.handleConfirmClickInserir);

            this.btnDeletar = new Button();
            this.btnDeletar.Text = "Deletar";
            this.btnDeletar.Location = new Point(160, 220);
            this.btnDeletar.Size = new Size(80, 30);
            this.btnDeletar.Click += new EventHandler(this.handleConfirmClickDeletar);

            this.btnUpdate = new Button();
            this.btnUpdate.Text = "Atualizar";
            this.btnUpdate.Location = new Point(260, 220);
            this.btnUpdate.Size = new Size(80, 30);
            this.btnUpdate.Click += new EventHandler(this.handleConfirmClickAtualizar);

            this.Controls.Add(listView);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.btnDeletar);
            this.Controls.Add(this.btnUpdate);

            this.ClientSize = new System.Drawing.Size(500, 300);
        }

        private void handleConfirmClickAtualizar(object sender, EventArgs e)
        {
            Form6 menu = new Form6();
            menu.ShowDialog();
        }
         private void handleConfirmClickDeletar(object sender, EventArgs e)
        {
            DialogResult result;
            result = MessageBox.Show(
                $"Deseja realmente excluir o paciente?" +
                $"",
                "STATUS!",
                MessageBoxButtons.YesNo
            );
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
            else
            {
                Console.WriteLine("Clicou não");
            }
        }
        private void handleConfirmClickInserir(object sender, EventArgs e)
        {
            Form4 menu = new Form4();
            menu.ShowDialog();
        }
        private void handleConfirmClick(object sender, EventArgs e)
        {
            DialogResult result;
            result = MessageBox.Show(
                $"Deseja realmente confirmar o agendamento?" +
                $"",
                "STATUS!",
                MessageBoxButtons.YesNo
            );
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
            else
            {
                Console.WriteLine("Clicou não");
            }
        }
        private void handleCancelClick(object sender, EventArgs e)
        {

            this.Close();
        }
    }

     public class Form8 : Form
          {

            Label lblPreco;
            Label lblDescricao;
            
            TextBox txtPreco;
            RichTextBox txtDescricao;

            Button btnConfirm;
            Button btnCancel;
           
            public Form8()
            {

            this.lblPreco = new Label();
            this.lblPreco.Text = "Preço";
            this.lblPreco.Location = new Point(10, 20);

            this.lblDescricao = new Label();
            this.lblDescricao.Text = "Descrição";
            this.lblDescricao.Location = new Point(120, 80);

            this.txtPreco = new TextBox();
            this.txtPreco.Location = new Point(120, 20);
            this.txtPreco.Size = new Size(50, 30);

            this.txtDescricao = new RichTextBox();
            this.txtDescricao.Location = new Point(10, 110);
            this.txtDescricao.Size = new Size(280, 65);

            this.btnConfirm = new Button();
            this.btnConfirm.Text = "Confirmar";
            this.btnConfirm.Location = new Point(100, 180);
            this.btnConfirm.Size = new Size(80, 30);
            this.btnConfirm.Click += new EventHandler(this.handleConfirmClick);


            this.btnCancel = new Button();
            this.btnCancel.Text = "Cancelar";
            this.btnCancel.Location = new Point(100, 220);
            this.btnCancel.Size = new Size(80, 30);
            this.btnCancel.Click += new EventHandler(this.handleCancelClick);

            this.Controls.Add(this.lblPreco);
            this.Controls.Add(this.lblDescricao);
            this.Controls.Add(this.txtDescricao);
            this.Controls.Add(this.txtPreco);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.btnCancel);

            this.ClientSize = new System.Drawing.Size(300, 300);

            }

        private void handleConfirmClick(object sender, EventArgs e)
        {

        }

        private void handleCancelClick(object sender, EventArgs e)
        {
            this.Close();
        }
            
    }

}