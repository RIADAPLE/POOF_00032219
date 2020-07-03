namespace Parcial_Final
{
    public class Registro
    {
        public int idregistro{ get; set; }
        public int idusuario { get; set; }
        public bool entrada { get; set; }
        public double temperatura { get; set; }
        public string fechayhora { get; set; }
        

        public Registro()
        {
            idregistro = 0;
            idusuario = 0;
            entrada = true;
            temperatura = 0;
            fechayhora = "";
        }
    }
}