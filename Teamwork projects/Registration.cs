using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Teamwork_projects
{
    public class Registration
    {
        private List<Team> teams;

        public Registration()
        {
            this.teams = new List<Team>();
        }

        public void AddTeam(Team team)
        {
            if(this.teams.Where(t => t.Name == team.Name).ToList().Count > 0)
            {
                Console.WriteLine($"Team {team.Name} was already created!");
            }
            else if (this.teams.Where(m => m.Creator.Name == team.Creator.Name).ToList().Count > 0)
            {
                Console.WriteLine($"{team.Creator.Name} cannot create another team!");
            }
            else
            {
                this.teams.Add(team);
            }
        }

        public void JoinMemberToTeam(string teamName, Member member)
        {
            if(this.teams.Where(t => t.Name == teamName).ToList().Count > 0)
            {
                if(this.teams.Where(t => t.Members.FirstOrDefault(m => m.Name == member.Name) != null).ToList().Count > 0)
                {
                    Console.WriteLine($"Member { member.Name} cannot join team { teamName}");
                }
                else
                {
                    this.teams.FirstOrDefault(t => t.Name == teamName)?.AddMember(member);
                }
            }
            else
            {
                Console.WriteLine($"Team { teamName} does not exist!");
            }
        }

        public override string ToString()
        {
            var text = new StringBuilder();
            foreach (var team in this.teams)
            {
                text.AppendLine(team.Name);
                text.AppendLine("- " + team.Creator.Name);

                foreach (var member in team.Members)
                {
                    text.AppendLine("-- " + member.Name);
                }
            }

            return text.ToString();
        }
    }
}
