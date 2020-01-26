using System;
using System.Collections.Generic;
using System.Text;

namespace Teamwork_projects
{
    public class Team
    {
        public Member Creator { get; set; }

        public string Name { get; set; }

        public IList<Member> Members { get; private set; }

        public Team(Member member, string team)
        {
            this.Creator = member;
            this.Name = team;
            this.Members = new List<Member>();
            Console.WriteLine($"Team {this.Name} has been created by {this.Creator.Name}");
        }

        public void AddMember(Member member)
        {
            this.Members.Add(member);
        }

        public override string ToString()
        {
            return $"Team {this.Name} has been created by {this.Creator}";
        }
    }
}
