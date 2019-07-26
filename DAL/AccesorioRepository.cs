using Entity;
using System.Data.SqlClient;

namespace DAL
{
    public class AccesorioRepository : Repository<Accesorio>
    {
        public AccesorioRepository() : base("Accesorio", new string[]
            {
                "Referencia",
                "Nombre",
                "Precio",
                "Descripción",
                "Cantidad",
                "Id_marca",
                "Id_color",
                "Id_tipo"
            })
        { }

        protected override void BindParams(SqlCommand comm, Accesorio t)
        {
            comm.Parameters.AddWithValue(attributes[0], t.Tipo);
            comm.Parameters.AddWithValue(attributes[1], t.Referencia);
            comm.Parameters.AddWithValue(attributes[2], t.Nombre);
            comm.Parameters.AddWithValue(attributes[3], t.Precio);
            comm.Parameters.AddWithValue(attributes[4], t.Descripción);
            comm.Parameters.AddWithValue(attributes[5], t.Cantidad);
            comm.Parameters.AddWithValue(attributes[6], t.Marca.Id);
            comm.Parameters.AddWithValue(attributes[7], t.Color.Id);
            comm.Parameters.AddWithValue(attributes[8], t.Tipo.Id);
        }

        protected override Accesorio ToObject(SqlDataReader reader)
        {
            Accesorio a = new Accesorio();

            a.Id = reader.GetInt16(0);
            a.Referencia = reader.GetString(1);
            a.Nombre = reader.GetString(2);
            a.Precio = reader.GetFloat(3);
            a.Descripción = reader.GetString(4);
            a.Cantidad = reader.GetInt16(5);
            a.Marca = new MarcaRepository().Get(reader.GetInt16(6));
            a.Color = new ColorRepository().Get(reader.GetInt16(7));
            a.Tipo = new TipoDeAccesorioRepository().Get(reader.GetInt16(8));

            return a;
        }
    }
}
