using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AlmacenLT.Utilidades
{
    public class UtilidadesFormularios
    {
        public static ErrorProvider errorProvider = new ErrorProvider();
        public static void LimpiarTextBox(List<TextBox> listTextBox)
        {
            foreach (var textBox in listTextBox)
            {
                textBox.Clear();
            }
        }
        public static void Limpiar(List<TextBox> listTextBox, List<MaskedTextBox> listMaskedBox, List<ComboBox> listComboBox)
        {
            if (listTextBox != null)
            {
                foreach (var textBox in listTextBox)
                {
                    textBox.Clear();
                }
            }
            if (listMaskedBox != null)
            {
                foreach (var maskedTextBox in listMaskedBox)
                {
                    maskedTextBox.Clear();
                }
            }
            if(listComboBox != null)
            {
                foreach (var comboBox in listComboBox)
                {
                    comboBox.SelectedIndex = -1;
                }
            }
            errorProvider.Clear();
        }
        public static void LimpiarTextBox(List<MaskedTextBox> listMaskedTextBox)
        {
            foreach (var maskedTextBox in listMaskedTextBox)
            {
                maskedTextBox.Clear();
            }
        }
        public static void LimpiarTextBox(MaskedTextBox maskedTextBox)
        {
            maskedTextBox.Clear();
        }
        public static void LimpiarTextBox(TextBox textBox)
        {
            textBox.Clear();
        }

        public static bool Validar(List<TextBox> listTextBox)
        {
            int errorCount = 0;
            
            foreach (var texBox in listTextBox)
            {
                if (string.IsNullOrEmpty(texBox.Text) || string.IsNullOrWhiteSpace(texBox.Text))
                {
                    errorCount++;
                    errorProvider.SetError(texBox, "Invalido!");
                }
            }

            if (errorCount == 0)
            {
                errorProvider.Clear();
                return true;
            }
            return false;
        }
        public static bool Validar(List<TextBox> listTextBox, List<MaskedTextBox> listMaskedTextBox, List<ComboBox> listComboBox)
        {
            int errorCount = 0;

            if (listTextBox != null)
            {
                foreach (var texBox in listTextBox)
                {
                    if (string.IsNullOrEmpty(texBox.Text) || string.IsNullOrWhiteSpace(texBox.Text))
                    {
                        errorCount++;
                        errorProvider.SetError(texBox, "Invalido!");
                    }
                }
            }
            if (listMaskedTextBox != null)
            {
                foreach (var textBox in listMaskedTextBox)
                {
                    if (!textBox.MaskFull)
                    {
                        errorCount++;
                        errorProvider.SetError(textBox, "Invalido!");                        
                    }
                }
            }
            if (listComboBox != null)
            {
                foreach (var comboBox in listComboBox)
                {
                    if (!(comboBox.SelectedIndex >= 0))
                    {
                        errorCount++;
                        errorProvider.SetError(comboBox, "Invalido!");
                    }
                }
            }
            if (errorCount == 0)
            {
                errorProvider.Clear();
                return true;
            }
            return false;
        }
        public static bool Validar(MaskedTextBox maskedTextBox)
        {
            int errorCount = 0;
            if (string.IsNullOrEmpty(maskedTextBox.Text) || string.IsNullOrWhiteSpace(maskedTextBox.Text))
            {
                errorCount++;
                errorProvider.SetError(maskedTextBox, "Invalido!");
                return false;
            }
            errorProvider.Clear();
            return true;
        }
        public static bool Validar(List<MaskedTextBox> listmaskedTextBox)
        {
            int errorCount = 0;
            foreach (var textBox in listmaskedTextBox)
            {
                if (string.IsNullOrEmpty(textBox.Text) || string.IsNullOrWhiteSpace(textBox.Text))
                {
                    errorCount++;
                    errorProvider.SetError(textBox, "Invalido!");
                }
            }
            if (errorCount == 0)
            {
                errorProvider.Clear();
                return true;
            }
            else
            {
                return false;
            }
        }
        public static bool Validar(TextBox textBox)
        {
            int errorCount = 0;
            if (string.IsNullOrEmpty(textBox.Text) || string.IsNullOrWhiteSpace(textBox.Text))
            {
                errorCount++;
                errorProvider.SetError(textBox, "Invalido!");
                return false;
            }
            errorProvider.Clear();
            return true;
        }
    }
}
