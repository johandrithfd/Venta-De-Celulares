using Entity;
using System.Data.SqlClient;

namespace DAL
{
    public class CompraRepository : Repository<Compra>
    {
        public CompraRepository() : base ("Compra", new string[]
        {
            "Fecha",
            "Total",
            "Id_cliente"
        })
        { }

        protected override void BindParams(SqlCommand comm, Compra t)
        {
            comm.Parameters.AddWithValue(attributes[0], t.Fecha);
            comm.Parameters.AddWithValue(attributes[1], t.Total);
            comm.Parameters.AddWithValue(attributes[2], t.Cliente.Id);
        }

        protected override Compra ToObject(SqlDataReader reader)
        {
            Compra a = new Compra();

            a.Id = reader.GetInt32(0);
            a.Fecha = reader.GetDateTime(1);
            a.Total = reader.GetFloat(2);
            a.Cliente = null;

            return a;
        }
    }
}
