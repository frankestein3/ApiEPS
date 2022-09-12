using Microsoft.AspNetCore.Mvc;
using ProyectoApi1.Models;

namespace ProyectoApi1.Controllers
{

    [ApiController]
    [Route("Client")]
    public class ClientController: ControllerBase
    {
        [HttpGet]
        [Route("list")]
        public dynamic listClients()
        {
            List<Client> clients = new List<Client>
            {
                new Client
                {
                    id = 1,
                    name = "Pepito Perez",
                    email = "pepito@gmail.com",
                    age = 19
                },
                new Client
                {
                    id = 2,
                    name = "Clarita Oscuro",
                    email = "clarita@gmail.com",
                    age = 22
                }
            };
            return clients;
        }
        [HttpGet]
        [Route("listClient")]
        public dynamic listClient(int id)
        {

            return new Client
            {
                id = id,
                name = "Pepito Perez",
                email = "pepito@gmail.com",
                age = 19
            };
        }
        [HttpPost]
        [Route("save")]
        public dynamic saveClient(Client client)
        {
            client.id = 3;
            return new
            {
                success = true,
                message = "Client insert",
                result = client
            };
        }
    }
}
