namespace Parcial_Final
{
    public class Departamento
    {
        public int iddepartamento{ get; set; }
        public string nombre { get; set; }
        public string ubicacion { get; set; }
        
        public int frecuencia { get; set; }

        public Departamento()
        {
            iddepartamento = 0;
            nombre = "";
            ubicacion = "";
        }
    }
}