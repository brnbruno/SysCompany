/*
 * Created by SharpDevelop.
 * User: Bruno
 * Date: 27/11/2016
 * Time: 16:35
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace SysDeCompany.Classes
{
	/// <summary>
	/// Description of clnValida.
	/// </summary>
	public class clnValida
	{
		public string msn = "";
        public int aux = 0;
		public void moeda(ref System.Windows.Forms.TextBox txt)
        {
		string n = string.Empty;
            double v = 0;
            try
            {
                n = txt.Text.Replace(",", "").Replace(".", "");
                if (n.Equals(""))
                    n = "";
                n = n.PadLeft(3, '0');
                if (n.Length > 3 & n.Substring(0, 1) == "0")
                    n = n.Substring(1, n.Length - 1);
                v = Convert.ToDouble(n) / 100;
                txt.Text = string.Format("{0:N}", v);
                txt.SelectionStart = txt.Text.Length;
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message, "Somente numero");
            }
        }
        public void soNumero(ref System.Windows.Forms.TextBox txt, System.Windows.Forms.KeyPressEventArgs e)
        {
            if (char.IsPunctuation(e.KeyChar) || char.IsSymbol(e.KeyChar) || char.IsWhiteSpace(e.KeyChar) || char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        public void soLetraSpace(ref  System.Windows.Forms.TextBox txt, System.Windows.Forms.KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar) || char.IsSymbol(e.KeyChar) || char.IsPunctuation(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        public void soLetra(ref  System.Windows.Forms.TextBox txt, System.Windows.Forms.KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar) || char.IsSymbol(e.KeyChar) || char.IsPunctuation(e.KeyChar) || char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        public void soLeNuSpa(ref System.Windows.Forms.TextBox txt, System.Windows.Forms.KeyPressEventArgs e)
        {
            if (char.IsSymbol(e.KeyChar) || char.IsPunctuation(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        //===============================================================================================================================================================
        public void txtNomeValidacao(ref System.Windows.Forms.TextBox txt)
        {
            if (txt.Text.Length < 3)
            {
                aux++;
                msn = " Nome preenchido incorretamente \n";
                txt.Focus();



            }

        }
        public void maskedTelValidacao(ref System.Windows.Forms.MaskedTextBox txt, System.Windows.Forms.MaskedTextBox txt2, System.Windows.Forms.MaskedTextBox txt3)
        {
            if (!txt.MaskFull && !txt2.MaskFull && !txt3.MaskFull)
            {
                aux++;
                msn += " Nenhum Numero de chamada foi preenchido\n";

            }


        }
        public void maskedCepfvalidacao(ref System.Windows.Forms.MaskedTextBox txt)
        {
            if (!txt.MaskFull)
            {
                aux++;
                msn += " CEP preenchido incorretamente \n";

            }

        }
        public void txtNr(ref System.Windows.Forms.TextBox txt)
        {
            if (txt.Text.Length == 0)
            {
                aux++;
                msn += " O Número do Imóvel não foi preenchido \n";

            }

        }
        public void maskedPlacaValidacao(ref System.Windows.Forms.MaskedTextBox txt)
        {
            if (!txt.MaskFull)
            {
                aux++;
                msn += " Placa do veículo não preenchida \n";

            }
        }
        public void txtEstado(ref System.Windows.Forms.TextBox txt)
        {
            if (txt.Text != "AC" && txt.Text != "AL" && txt.Text != "AP" && txt.Text != "AM" && txt.Text != "BA" &&
                txt.Text != "CE" && txt.Text != "DF" && txt.Text != "ES" && txt.Text != "GO" && txt.Text != "MA" &&
                txt.Text != "MT" && txt.Text != "MS" && txt.Text != "MG" && txt.Text != "PA" && txt.Text != "PB" &&
                txt.Text != "PR" && txt.Text != "PE" && txt.Text != "PI" && txt.Text != "RJ" && txt.Text != "RN" &&
                txt.Text != "RS" && txt.Text != "RO" && txt.Text != "RR" && txt.Text != "SC" && txt.Text != "SP" &&
                txt.Text != "SE" && txt.Text != "TO")
            {
                aux++;
                msn += " Estado não existente ou em Branco \n";

            }
        }
        public void txtEndereco(ref System.Windows.Forms.TextBox txt)
        {
            if (txt.Text.Length < 3)
            {
                aux++;
                msn += " Endereço Logradouro Preechido incorretamente  \n";
                txt.Focus();


            }
        }
        public void txtBairro(ref System.Windows.Forms.TextBox txt)
        {
            if (txt.Text.Length < 3)
            {
                aux++;
                msn += " Endereço Bairro Preechido incorretamente  \n";
                txt.Focus();


            }
        }
        public void txtCidade(ref System.Windows.Forms.TextBox txt)
        {
            if (txt.Text.Length < 3)
            {
                aux++;
                msn += " Endereço Cidade Preechido incorretamente  \n";
                txt.Focus();


            }
        }
	}
}
