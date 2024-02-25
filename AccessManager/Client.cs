using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessManager
{
    public class Client
    {
        public String name;
        public String fullName;
        public bool active;

        public List<ClientAccess> accesses;
        public List<Note> Notes;

        public void AddAccess(ClientAccess access)
        {
            accesses.Add(access);
        }

        public void DeleteAccess(ClientAccess access)
        {
            accesses.Remove(access);
        }
    }

    
}
