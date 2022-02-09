using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Always_Coffee_Time.BL
{
   public class Contexto: DbContext
    {
        public Contexto() : base(@"Data Source=(LocalDb)\MSSQLLocalDB;AttachDBFilename=" +
             Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + @"\MiBaseDatos.mdf")
        {
            
        }

        

        /* public Contexto(): base("Always_Coffee_TimeDB")
        {

        }*/
        public DbSet<Producto> Productos { get; set; }
    }
}
