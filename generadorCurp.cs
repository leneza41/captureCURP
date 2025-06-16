using System.Diagnostics;
using System.Security.Cryptography;

namespace captureCURP
{
    public partial class generadorCurp : UserControl
    {
        public event EventHandler CurpGenerada;

        public class ComboBoxItem
        {
            public string Text { get; set; }
            public string Value { get; set; }

            public ComboBoxItem(string text, string value)
            {
                Text = text;
                Value = value;
            }

            public override string ToString()
            {
                return Text;
            }
        }
        public generadorCurp()
        {
            InitializeComponent();
            agregarEstados();
            addGender();
        }

        private void addGender()
        {
            cboSexo.Items.Add(new ComboBoxItem("Hombre", "H"));
            cboSexo.Items.Add(new ComboBoxItem("Mujer", "M"));
        }

        private string replaceSpecial(string texto)
        {
            return texto
                .Replace('á', 'a').Replace('é', 'e').Replace('í', 'i')
                .Replace('ó', 'o').Replace('ú', 'u')
                .Replace('Á', 'A').Replace('É', 'E').Replace('Í', 'I')
                .Replace('Ó', 'O').Replace('Ú', 'U')
                .Replace('ñ', 'x').Replace('Ñ', 'X');
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text.Trim();
            nombre = replaceSpecial(nombre);
            string apellidoPaterno = txtApellidoPaterno.Text.Trim();
            apellidoPaterno = replaceSpecial(apellidoPaterno);
            string apellidoMaterno = txtApellidoMaterno.Text.Trim();
            apellidoMaterno = replaceSpecial(apellidoMaterno);
            string fechaNacimiento = dtpFechaNacimiento.Value.ToString("yyMMdd");
            int year = dtpFechaNacimiento.Value.Year;
            // el apellido materno puede ir vacio
            if (nombre == "" || apellidoPaterno == ""
                || cboSexo.SelectedItem == null || cboEntidadFederativa.SelectedItem == null)
            {
                MessageBox.Show("Por favor, complete todos los campos requeridos.");
                return;
            }
            string genero = ((ComboBoxItem)cboSexo.SelectedItem).Value;
            string estado = ((ComboBoxItem)cboEntidadFederativa.SelectedItem).Value;
            string curp;
            curp = "" + apellidoPaterno[0] + getFirstOcurrence(apellidoPaterno, true);
            if(apellidoMaterno != "") 
            {
                curp += apellidoMaterno[0];
            } else
            {
                curp += 'X';
            }
            curp += nombre[0];
            curp += fechaNacimiento;
            curp += genero;
            curp += estado;
            curp += getFirstOcurrence(apellidoPaterno.Substring(1), false);
            if (apellidoMaterno.Length > 0)
            {
                curp += getFirstOcurrence(apellidoMaterno.Substring(1), false);
            } else
            {
                curp += 'X';
            }
            curp += getFirstOcurrence(nombre.Substring(1), false);
            // ya que los siguientes digitos son generados mediante algoritmos o
            // metodos no proporcionados se usara random
            Random random = new Random();
            if (year <= 1999)
            {
                curp += random.Next(0, 10);
            } else
            {
                curp += (char)random.Next('A', 'J' + 1);

            }
            curp += random.Next(0, 10);
            curp = curp.ToUpper();
            lblCurp.Text = curp;
            Debug.WriteLine($"CURP Generada: {curp}");
            MessageBox.Show("La CURP se genero exitosamente");
            OnCurpGenerada();
        }

        protected virtual void OnCurpGenerada()
        {
            CurpGenerada?.Invoke(this, EventArgs.Empty);
        }

    private char getFirstOcurrence(string str, bool vowel)
        {
            for(int i = 0; i < str.Length; i++  )
            {
                if (vowel == isVowel(str[i]))
                {
                    return str[i];
                }
            }
            return 'X';
        }

        private bool isVowel(char c)
        {
            return "aeiou".Contains(char.ToLower(c));
        }

        void agregarEstados() 
        {
            cboEntidadFederativa.Items.Add(new ComboBoxItem("Aguascalientes", "AG"));
            cboEntidadFederativa.Items.Add(new ComboBoxItem("Baja California", "BC"));
            cboEntidadFederativa.Items.Add(new ComboBoxItem("Baja California Sur", "BS"));
            cboEntidadFederativa.Items.Add(new ComboBoxItem("Campeche", "CC"));
            cboEntidadFederativa.Items.Add(new ComboBoxItem("Chiapas", "CS"));
            cboEntidadFederativa.Items.Add(new ComboBoxItem("Chihuahua", "CH"));
            cboEntidadFederativa.Items.Add(new ComboBoxItem("Ciudad", "DF"));
            cboEntidadFederativa.Items.Add(new ComboBoxItem("Coahuila", "CL"));
            cboEntidadFederativa.Items.Add(new ComboBoxItem("Colima", "CM"));
            cboEntidadFederativa.Items.Add(new ComboBoxItem("Durango", "DG"));
            cboEntidadFederativa.Items.Add(new ComboBoxItem("Guanajuato", "GT"));
            cboEntidadFederativa.Items.Add(new ComboBoxItem("Guerrero", "GR"));
            cboEntidadFederativa.Items.Add(new ComboBoxItem("Hidalgo", "HG"));
            cboEntidadFederativa.Items.Add(new ComboBoxItem("Jalisco", "JC"));
            cboEntidadFederativa.Items.Add(new ComboBoxItem("México", "MC"));
            cboEntidadFederativa.Items.Add(new ComboBoxItem("Michoacán", "MN"));
            cboEntidadFederativa.Items.Add(new ComboBoxItem("Morelos", "MS"));
            cboEntidadFederativa.Items.Add(new ComboBoxItem("Nayarit", "NT"));
            cboEntidadFederativa.Items.Add(new ComboBoxItem("Nuevo", "NL"));
            cboEntidadFederativa.Items.Add(new ComboBoxItem("Oaxaca", "OC"));
            cboEntidadFederativa.Items.Add(new ComboBoxItem("Puebla", "PL"));
            cboEntidadFederativa.Items.Add(new ComboBoxItem("Querétaro", "QT"));
            cboEntidadFederativa.Items.Add(new ComboBoxItem("Quintana", "QR"));
            cboEntidadFederativa.Items.Add(new ComboBoxItem("San", "SP"));
            cboEntidadFederativa.Items.Add(new ComboBoxItem("Sinaloa", "SL"));
            cboEntidadFederativa.Items.Add(new ComboBoxItem("Sonora", "SR"));
            cboEntidadFederativa.Items.Add(new ComboBoxItem("Tabasco", "TC"));
            cboEntidadFederativa.Items.Add(new ComboBoxItem("Tamaulipas", "TS"));
            cboEntidadFederativa.Items.Add(new ComboBoxItem("Tlaxcala", "TL"));
            cboEntidadFederativa.Items.Add(new ComboBoxItem("Veracruz", "VZ"));
            cboEntidadFederativa.Items.Add(new ComboBoxItem("Yucatán", "YN"));
            cboEntidadFederativa.Items.Add(new ComboBoxItem("Zacatecas", "ZS"));
        }
    }
}
