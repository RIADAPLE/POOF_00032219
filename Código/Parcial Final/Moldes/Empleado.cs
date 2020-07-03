namespace Parcial_Final
{
    public class Empleado
    {
        public int idusuario { get; set; }
        public int iddepartamento { get; set; }
        public string contraseña { get; set; }
        public string nombre { get; set; }
        public string apellido { get; set; }
        public string dui { get; set; }
        public string fechanacimiento { get; set; }

        public Empleado()
        {
            idusuario = 0;
            iddepartamento = 0;
            contraseña = "";
            nombre = "";
            apellido = "";
            dui = "";
            fechanacimiento = "";
        }
    }
}