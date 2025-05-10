namespace Red_Vial_2._0
{
    public class CarroInfo
    {
        private static int _ultimoId = 0;  
        public int idCarro { get; }  

        public int width { get; set; }

        public int height { get; set; }

        public CarroInfo(int width, int height)
        {
            this.idCarro = ++_ultimoId;  
            this.width = width;
            this.height = height;
        }
    }
}
