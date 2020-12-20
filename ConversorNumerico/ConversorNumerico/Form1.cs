using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConversorNumerico{
    public partial class Form1 : Form{
        public Form1(){
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e){
            if (btnMemoria.Visible){
                lb1.Text = "Número Binario: ";
                lb2.Text = "Número Decimal: ";
            }
            else{
                textBox1.Visible = true;
                textBox2.Visible = true;
                lb1.Visible = true;
                lb2.Visible = true;
                btnConversion.Visible = true;
                btnMemoria.Visible = true;
                lb1.Text = "Número Binario: ";
                lb2.Text = "Número Decimal: ";
            }
        }

        private void button3_Click(object sender, EventArgs e){
            if (btnMemoria.Visible){
                lb1.Text = "Número Decimal: ";
                lb2.Text = "Número Binario: ";
            }
            else{
                textBox1.Visible = true;
                textBox2.Visible = true;
                lb1.Visible = true;
                lb2.Visible = true;
                btnConversion.Visible = true;
                btnMemoria.Visible = true;
                lb1.Text = "Número Binario: ";
                lb1.Text = "Número Decimal: ";
            }

        }

        private void button4_Click(object sender, EventArgs e){
            if (btnMemoria.Visible){
                lb1.Text = "Número Decimal: ";
                lb2.Text = "Número Octal: ";
            }
            else{
                textBox1.Visible = true;
                textBox2.Visible = true;
                lb1.Visible = true;
                lb2.Visible = true;
                btnConversion.Visible = true;
                btnMemoria.Visible = true;
                lb1.Text = "Número Decimal: ";
                lb2.Text = "Número Octal: ";
            }
        }

        private void button5_Click(object sender, EventArgs e){
            if (btnMemoria.Visible){
                lb1.Text = "Número Octal: ";
                lb2.Text = "Número Decimal: ";
            }
            else{
                textBox1.Visible = true;
                textBox2.Visible = true;
                lb1.Visible = true;
                lb2.Visible = true;
                btnConversion.Visible = true;
                btnMemoria.Visible = true;
                lb1.Text = "Número Octal: ";
                lb2.Text = "Número Decimal: ";
            }
        }

        private void button6_Click(object sender, EventArgs e){
            if (btnMemoria.Visible){
                lb1.Text = "Número Decimal: ";
                lb2.Text = "Número Hexadecimal: ";
            }
            else{
                textBox1.Visible = true;
                textBox2.Visible = true;
                lb1.Visible = true;
                lb2.Visible = true;
                btnConversion.Visible = true;
                btnMemoria.Visible = true;
                lb1.Text = "Número Decimal: ";
                lb2.Text = "Número Hexadecimal: ";
            }
        }

        private void button7_Click(object sender, EventArgs e){
            if (btnMemoria.Visible){
                lb1.Text = "Número Hexadecimal: ";
                lb2.Text = "Número Decimal: ";
            }
            else{
                textBox1.Visible = true;
                textBox2.Visible = true;
                lb1.Visible = true;
                lb2.Visible = true;
                btnConversion.Visible = true;
                btnMemoria.Visible = true;
                lb1.Text = "Número Hexadecimal: ";
                lb2.Text = "Número Decimal: ";
            }
        }

        private void button9_Click(object sender, EventArgs e){
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e){
            textBox1.Clear();
            textBox2.Clear();
        }

        private void button8_Click(object sender, EventArgs e){
            if(lb1.Text== "Número Decimal: "&& lb2.Text== "Número Binario: "){
                decimalBinario();

            }else if(lb1.Text == "Número Binario: " && lb2.Text == "Número Decimal: "){
                binarioDecimal();

            }else if(lb1.Text == "Número Decimal: " && lb2.Text == "Número Octal: "){
                decimalOctal();

            }else if(lb1.Text == "Número Octal: " && lb2.Text == "Número Decimal: "){
                octalDecimal();

            }else if(lb1.Text == "Número Decimal: " && lb2.Text == "Número Hexadecimal: "){
                decimalHexadecimal();

            }else if(lb1.Text == "Número Hexadecimal: " && lb2.Text == "Número Decimal: "){
                hexadecimalDecimal();
            }
        }
        private void decimalBinario(){
            try{
                long numero, residuo;
                String ordenar = "";
                numero = Convert.ToInt64(textBox1.Text);
                while (numero != 0){
                    residuo = numero % 2;
                    numero = numero / 2;
                    textBox2.Text += residuo;
                }
                String binario = textBox2.Text;
                textBox2.Clear();
                for (int i = binario.Length - 1; i >= 0; i--){
                    ordenar += binario[i];
                }
                textBox2.Text = ordenar;
            }catch{
                MessageBox.Show("Error","Entrada Invalida.",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }  
        }
        private void binarioDecimal(){
            try{
                string numerobinario;
                string digitos = "01";
                char caracter;
                numerobinario = textBox1.Text;
                int d, valorDecimal = 0;
                for (int i = 0; i <= numerobinario.Length - 1; i++){
                    caracter = numerobinario[i];
                    d = digitos.IndexOf(caracter);
                    valorDecimal = 2 * valorDecimal + d;
                }
                textBox2.Text = Convert.ToString(valorDecimal);
            }catch{
                MessageBox.Show("Error", "Entrada Invalida.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           
        }
        private void decimalOctal(){
            try{
                long Decimal, residuo;
                string ordenar = "";
                Decimal = Convert.ToInt64(textBox1.Text);
                while (Decimal > 0){
                    residuo = Decimal % 8;
                    Decimal = Decimal / 8;
                    textBox2.Text += residuo;
                }
                string numeroDecimal = textBox2.Text;
                textBox2.Clear();
                for (int i = numeroDecimal.Length - 1; i >= 0; i--){
                    ordenar += numeroDecimal[i];
                }
                textBox2.Text = Convert.ToString(ordenar);
            }catch{
                MessageBox.Show("Error", "Entrada Invalida.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } 
        }
        private void octalDecimal(){
            try{
                string numeroOctal;
                string digitos = "01234567";
                char caracter;
                numeroOctal = textBox1.Text;
                int d, valorDecimal = 0;
                for (int i = 0; i <= numeroOctal.Length - 1; i++){
                    caracter = numeroOctal[i];
                    d = digitos.IndexOf(caracter);
                    valorDecimal = 8 * valorDecimal + d;
                }
                textBox2.Text = Convert.ToString(valorDecimal);
            }catch{
                MessageBox.Show("Error", "Entrada Invalida.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }
        private void decimalHexadecimal(){
            try{
                long nDecimal, rem;
                String hexadecimal = "", valorHex;
                char[] caracteres = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9', 'A', 'B', 'C', 'D', 'E', 'F' };
                nDecimal = Convert.ToInt64(textBox1.Text);
                while (nDecimal > 0){
                    rem = nDecimal % 16;
                    hexadecimal = caracteres[rem] + hexadecimal;
                    nDecimal = nDecimal / 16;
                }
                textBox2.Text = Convert.ToString(hexadecimal);
            }catch{
                MessageBox.Show("Error", "Entrada Invalida.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }
        private void hexadecimalDecimal(){
            try{
                string numeroHexadecimal;
                string digitos = "0123456789ABCDEF";
                char caracter;
                numeroHexadecimal = textBox1.Text;
                numeroHexadecimal = numeroHexadecimal.ToUpper();
                int d, valorDecimal = 0;
                for (int i = 0; i <= numeroHexadecimal.Length - 1; i++){
                    caracter = numeroHexadecimal[i];
                    d = digitos.IndexOf(caracter);
                    valorDecimal = 16 * valorDecimal + d;
                }
                textBox2.Text = Convert.ToString(valorDecimal);
            }
            catch{
                MessageBox.Show("Error", "Entrada Invalida.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}