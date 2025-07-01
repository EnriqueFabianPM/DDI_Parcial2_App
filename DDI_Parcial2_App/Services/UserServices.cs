using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DDI_Parcial2_App.Models;

namespace DDI_Parcial2_App.Services
{
    public class UserServices
    {
        private List<User> usuarios = new()
        {
            new User { Nombre = "Enrique Fabian", Email = "21024@virtual.utsc.edu.mx", Password = "21024" },
            new User { Nombre = "Oscar Omar", Email = "21031@virtual.utsc.edu.mx", Password = "21031" },
            new User { Nombre = "Daniel FLores", Email = "21008@virtual.utsc.edu.mx", Password = "21008" },
            new User { Nombre = "Elias Rafael", Email = "21017@virtual.utsc.edu.mx", Password = "21017" },
            new User { Nombre = "Edgardo Puente", Email = "21026@virtual.utsc.edu.mx", Password = "21026" },
            new User { Nombre = "Joel Alexander", Email = "21160@virtual.utsc.edu.mx", Password = "21160" },
            new User { Nombre = "Kevin Aldahir", Email = "21136@virtual.utsc.edu.mx", Password = "21136" },
            new User { Nombre = "Ethan Andres", Email = "16246@virtual.utsc.edu.mx", Password = "16246" },
            new User { Nombre = "Paul Eduardo", Email = "18167@virtual.utsc.edu.mx", Password = "18167" }
        };

        public User? Login(string email, string password)
        {
            return usuarios.FirstOrDefault(u => u.Email == email && u.Password == password);
        }

        public User? BuscarPorCorreo(string email)
        {
            return usuarios.FirstOrDefault(u => u.Email == email);
        }

        public List<User> ObtenerTodos() => usuarios;
    }
}
