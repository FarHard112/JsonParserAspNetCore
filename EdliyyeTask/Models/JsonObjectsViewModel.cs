using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Nancy.Json;

namespace EdliyyeTask.Models
{
    public class JsonObjectsViewModel
    {
        //public UsersComments userComment { get; set; }
        public List<UsersComments> userComments { get; set; }
        public List<UsersPost> userPosts { get; set; }
        public UsersPost userPost { get; set; }
    }
}
