using System;

namespace KnowledgeTest.DAL.Model
{
    public class User
    {
        public Guid AnswerId { get; set; }
        public Roles Role { get; set; }
        public string Email { get; set; }
        public string Pass { get; set; }
    }
}
