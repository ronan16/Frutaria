using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Linq.Expressions;

namespace Frutaria
{
    public partial class frmLogin : Form
    {
        public  string usu;
        public string senha;
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnAcessar_Click(object sender, EventArgs e)
        {
            //Variaveis de Verificação
            bool login = false;
            
            //declarando a variavel do tipo StreamWriter para
            //abrir ou criar um arquivo para escrita            
            StreamWriter sw;

            //Colocando o caminho fisico e o nome do arquivo a ser criado
            //finalizando com .txt
            string CaminhoNome = "C:\\DADOS\\usuario.txt";

             //Se não existir arquivo de Texto...
            if (!File.Exists(CaminhoNome)) {
                //utilizando o método para criar um arquivo texto
                //e associando o caminho e nome ao metodo
                sw = File.CreateText(CaminhoNome);
            }else 
            {
                //Se já existir, abrir o arquivo e preparar para edição
                var valores = File.ReadAllLines(CaminhoNome)
                              .Where(l => l.StartsWith("usuario"))
                              .Select(l => l.Substring(l.IndexOf(":")+1))
                              .ToList();

                
                foreach (var valor in valores)
                {
                    usu = valor.Substring(0, valor.IndexOf("/Senha:"));

                    if (usu == edtUsuario.Text)
                    {
                        senha = valor.Substring(valor.LastIndexOf(":") + 1);
                        if (senha.IndexOf(edtSenha.Text) > -1)
                        {
                            login = true;
                        }
                    }
                }
                
                if (login)
                {
                    MessageBox.Show("Logado com sucesso", "Resultado");
                    frmCaixa frmC = new frmCaixa(usu);
                    frmC.Show();
                }
                else
                {
                    MessageBox.Show("Login ou senha incorreto", "Resultado");
                }
            }
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void edtUsuario_Leave(object sender, EventArgs e)
        {
            //Metodo para mudar a imagem depois de digitar o usuario
            mudaImagem(edtUsuario.Text);
        }

        private  void mudaImagem(string linha)
        {
            if (linha == "usu1")
            {
                imgUsuario.Image = imgLista.Images[0];
            } else if (linha == "usu2")
            {
                imgUsuario.Image = imgLista.Images[1];
            } else if (linha == "usu3")
            {
                imgUsuario.Image = imgLista.Images[2];
            }
            else if (linha == "usu4")
            {
                imgUsuario.Image = imgLista.Images[3];
            }
            else if (linha == "usu5")
            {
                imgUsuario.Image = imgLista.Images[4];
            }
        }
    }
}
