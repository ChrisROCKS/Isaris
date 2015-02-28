using System;
//using System.Windows.Forms;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Isaris.Entities;
using Isaris.DataAccess;

namespace Isaris.Negocio
{
    public class ClienteBO
    {
        public static List<ClienteEntity> GetAll()
        {
            return ClienteDAL.GetAll();
        }

        public static ClienteEntity GetById(int id)
        {
            return ClienteDAL.GetById(id);
        }

        public static ClienteEntity Save(ClienteEntity cliente)
        {

            if (ClienteDAL.Exists(cliente.idCliente))
                return ClienteDAL.Update(cliente);
            else
                return ClienteDAL.Create(cliente);

        }
        
    }
}
