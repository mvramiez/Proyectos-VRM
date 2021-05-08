using System;
using System.Windows.Forms;
using PicoyPlaca;


namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            PicoyPlacaClase Datos = new PicoyPlacaClase();

            Datos.Placa = mTxtPlaca.Text.ToUpper();
            Datos.Fecha = mTxtFecha.Text;
            Datos.Hora = mTxtHora.Text;
            lblMensaje.Text = "";
            lblmensaje2.Text = "";

            try
            {
                if (ValidarPlaca(Datos.Placa) == 0)
                {
                    if (ValidarFechas(Datos.Fecha, Datos.Hora, Datos.Placa) != 0)
                    {
                        MessageBox.Show("La fecha ingresada debe ser mayor a la fecha actual", "Fecha");
                    }
                }
                else
                    MessageBox.Show("Datos de la placa incorrectos, favor varificar", "Placa");
            }
            catch (Exception ex)
            {
                MessageBox.Show("La fecha y/o la hora ingresadas no son correctas", "Fecha");
            }
        }


        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        private int ValidarPlaca(string Placa)
        {
            int flag = 0; //Initilize flag 
            if (Placa.Length == 10)
            {
                char[] c = Placa.Substring(0, 3).ToCharArray();
                for (int i = 0; i <= 2; i++)
                {
                    if (!((int)(c[i]) >= 65 && (int)(c[i]) <= 90)) //Check if the first letters are in the range from A to Z in Ascii code to verify if they are capital ones
                    {
                        flag = 1;//In case of error
                        return flag;
                    }
                }

                try
                {
                    char[] l = Placa.Substring(4, 6).Replace('-', ' ').Trim().ToCharArray();
                    for (int i = 0; i <= 3; i++)
                    {
                        if (!((int)(l[i]) >= 48 && (int)(l[i]) <= 57)) //Check if the last numbers are in the range from 0 to 9 in Ascii code to verify if they are correct 
                        {
                            flag = 1;//In case of error
                            return flag;
                        }
                    }
                }
                catch (Exception ex)
                {
                    flag = 1;//In case of error
                    return flag;
                }
            }
            else
            {
                flag = 1;//In case of error
            }
            return flag;
        }

        private int ValidarFechas(string Fecha, string Hora, string Placa)
        {
            PicoyPlacaClase Datos = new PicoyPlacaClase();

            string[] Dias = { "Friday", "Monday", "Monday", "Tuesday", "Tuesday", "Wednesday", "Wednesday", "Thursday", "Thursday", "Friday" };
            Datos.HoraInicioM = "07:00";
            Datos.HoraFinM = "09:30";
            Datos.HoraInicioT = "16:00";
            Datos.HoraFinT = "19:30";

            int flag = 0; //initilize flag

            int DigitoPlaca = Convert.ToInt32(Placa.Substring(Placa.Length - 1, 1)); // Lisence plate last digit
            string DiaRestriccion = TraducirDia(Dias[DigitoPlaca]); //Restriction day
            DateTime tiempo = DateTime.Parse(Fecha.ToString() + " " + Hora); //Entered date
            string DiaSemana = TraducirDia(tiempo.DayOfWeek.ToString()); //Day according entered date
            string FechaActual = DateTime.Now.ToString("MM/dd/yyyy hh:mm"); //current day

            if (Fecha.Length == 10) //check date length
            {
                Datos.anio = Convert.ToInt32(Fecha.Substring(6, 4));
                Datos.dia = Convert.ToInt32(Fecha.Substring(3, 2));
                Datos.mes = Convert.ToInt32(Fecha.Substring(0, 2));
                Datos.hora = Convert.ToInt32(Hora.Substring(0, 2));
                Datos.minutos = Convert.ToInt32(Hora.Substring(3, 2));

                if ((Datos.mes > 0 && Datos.mes <= 12) && (Datos.dia > 0 && Datos.dia <= 31) && (Datos.hora >= 0 && Datos.hora <= 23) && (Datos.minutos >= 0 && Datos.minutos <= 59))
                {//Check if parmeters are entered correctly 
                    if (tiempo > DateTime.Parse(FechaActual))
                    {   //Check vehicle restriction through the entered date
                        if (DiaSemana == DiaRestriccion && 
                            ((Convert.ToDateTime(Hora) >= Convert.ToDateTime(Datos.HoraInicioM) && Convert.ToDateTime(Hora) <= Convert.ToDateTime(Datos.HoraFinM)) || 
                            (Convert.ToDateTime(Hora) >= Convert.ToDateTime(Datos.HoraInicioT) && Convert.ToDateTime(Hora) <= Convert.ToDateTime(Datos.HoraFinT))))
                        {
                            lblMensaje.Text = "Tiene Restircción vehicular.";
                            lblmensaje2.Text = "Su placa termina en " + DigitoPlaca + " y es " + DiaRestriccion + " en la fecha indicada.";
                        }
                        else
                        {
                            lblMensaje.Text = "No tiene restrición vehicular.";
                        }
                    }
                    else
                    {
                        flag = 1;
                    }
                }
                else
                {
                    flag = 1;
                }
            }
            return flag;
        }

        private string TraducirDia(string dia)// translate days into spanish to get a right message
        {
            string diaEs = "";
            switch (dia)
            {
                case "Monday":
                    diaEs = "Lunes";
                    break;
                case "Tuesday":
                    diaEs = "Martes";
                    break;
                case "Wednesday":
                    diaEs = "Miércoles";
                    break;
                case "Thursday":
                    diaEs = "Jueves";
                    break;
                case "Friday":
                    diaEs = "Viernes";
                    break;
            }
            return diaEs;
        }
    }
}
