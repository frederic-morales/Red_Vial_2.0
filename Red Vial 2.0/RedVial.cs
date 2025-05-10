namespace Red_Vial_2._0
{
    public class RedVial
    {
        public NodoInterseccion NodoCentral { get; set; }

        public List<CarroInfo> carrosTotales { get; set; }  // Cambia a List<>

        public RedVial()
        {
            NodoCentral = null;
            carrosTotales = new List<CarroInfo>();  // Inicializa como lista
        }

        public void CrearNodoCentral(InformacionNodo info)
        {
            NodoCentral = new NodoInterseccion(info);
        }

        public NodoInterseccion AgregarNodo(NodoInterseccion origen, string direccion, InformacionNodo info)
        {
            NodoInterseccion nuevo = new NodoInterseccion(info);

            switch (direccion.ToLower())
            {
                case "norte":
                    origen.Norte = nuevo;
                    nuevo.Sur = origen;
                    break;
                case "sur":
                    origen.Sur = nuevo;
                    nuevo.Norte = origen;
                    break;  
                case "este":
                    origen.Este = nuevo;
                    nuevo.Oeste = origen;
                    break;
                case "oeste":
                    origen.Oeste = nuevo;
                    nuevo.Este = origen;
                    break;
            }

            return nuevo;
        }

        public void AgregarCarro(int width, int height)
        {
            CarroInfo nuevoCarro = new CarroInfo(width, height);
            carrosTotales.Add(nuevoCarro);  // Método más simple
        }

        public bool MoverCarroAlNorte(int idCarro, int cantidad)
        {
            var carro = carrosTotales.FirstOrDefault(c => c.idCarro == idCarro);
            if (carro != null)
            {
                carro.height -= cantidad; // Restar para mover hacia arriba (norte)
                return true;
            }
            return false;
        }

        public bool MoverCarroAlSur(int idCarro, int cantidad)
        {
            var carro = carrosTotales.FirstOrDefault(c => c.idCarro == idCarro);
            if (carro != null)
            {
                carro.height += cantidad; // Sumar para mover hacia abajo (sur)
                return true;
            }
            return false;
        }

        public bool MoverCarroAlOeste(int idCarro, int cantidad)
        {
            var carro = carrosTotales.FirstOrDefault(c => c.idCarro == idCarro);
            if (carro != null)
            {
                carro.width -= cantidad; // Restar para mover hacia la izquierda (oeste)
                return true;
            }
            return false;
        }

        public bool MoverCarroAlEste(int idCarro, int cantidad)
        {
            var carro = carrosTotales.FirstOrDefault(c => c.idCarro == idCarro);
            if (carro != null)
            {
                carro.width += cantidad; // Sumar para mover hacia la derecha (este)
                return true;
            }
            return false;
        }

    }
}
