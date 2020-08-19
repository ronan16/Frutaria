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

namespace Frutaria
{
    public partial class frmCaixa : Form
    {     
        public string usuConectado;

        public frmCaixa(string usu)
        {
            InitializeComponent();            
            usuConectado = usu;
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            //Colocando o caminho fisico e o nome do arquivo a ser criado
            //finalizando com .txt
            string CaminhoNome = "C:\\DADOS\\produto.txt";
            StreamWriter sw;

            //Se não existir arquivo de Texto...
            if (!File.Exists(CaminhoNome))
            {
                //utilizando o método para criar um arquivo texto
                //e associando o caminho e nome ao metodo
                sw = File.CreateText(CaminhoNome);
            }
            else
            {
                //Se já existir, abrir o arquivo e preparar para edição
                var valores = File.ReadAllLines(CaminhoNome)
                              .ToList();

                string cod, prod, tipo, preco;

                foreach (var valor in valores)
                {
                    cod = valor.Substring(0, valor.IndexOf(";"));
                    prod = valor.Substring(valor.IndexOf(";") + 1, (valor.IndexOf("/") - valor.IndexOf(";")-1));
                    tipo = valor.Substring(valor.IndexOf("/") + 1, (valor.LastIndexOf(";") - valor.IndexOf("/")-1));
                    preco = valor.Substring(valor.LastIndexOf(";") + 1);

                    if (edtCodigo.Text == cod)
                    {
                        edtProduto.Text = prod;
                        edtTipo.Text = tipo;
                        edtPreco.Text = preco;

                        if (cod =="1")
                        {
                            imgProdutos.Image = imgListaProd.Images[0];
                        }
                        if (cod == "2")
                        {
                            imgProdutos.Image = imgListaProd.Images[1];
                        }
                        if (cod == "3")
                        {
                            imgProdutos.Image = imgListaProd.Images[2];
                        }
                        if (cod == "4")
                        {
                            imgProdutos.Image = imgListaProd.Images[3];
                        }
                    }
                }
            }
        }

        private void edtQtd_TextChanged(object sender, EventArgs e)
        {
            if (edtQtd.Text !="") {
                int qtd = Int32.Parse(edtQtd.Text);
                float preco = float.Parse(edtPreco.Text);
                float subtotal = preco * qtd;
                edtSubTotal.Text = subtotal.ToString();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            lstProdutos.Items.Add(edtProduto.Text + ";" +
                                  edtSubTotal.Text+";"+
                                  usuConectado+";"+
                                  DateTime.Today.ToString("d")); ;
            edtCodigo.Text   = "";
            edtProduto.Text  = "";
            edtPreco.Text    = "";
            edtTipo.Text     = "";
            edtQtd.Text = "";
            imgProdutos.Image = null;

            float total = (float.Parse(edtTotal.Text)) + (float.Parse(edtSubTotal.Text));
            edtTotal.Text = total.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Gravar no Arquivo
            StreamWriter sw;
            string CaminhoNome = "C:\\DADOS\\compra.txt";

            if (!File.Exists(CaminhoNome))
            {
                sw = File.CreateText(CaminhoNome);              
            }
            else
            {
                sw = File.AppendText(CaminhoNome);
            }
            foreach (var v in lstProdutos.Items)
            {
                sw.WriteLine(v);
            }
            sw.Close();
            lstProdutos.Items.Clear();
        }
    }
}
