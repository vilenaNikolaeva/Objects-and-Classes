using System;
using System.Collections.Generic;
using System.Linq;

namespace Teamwork_projects
{
    class Program
    {
        static void Main(string[] args)
        {
            var count = int.Parse(Console.ReadLine());
            var cmd = Console.ReadLine();
            var symbol = "-";
            var counter = 0;
            var registration = new Registration();

            while (cmd != "end of assignment")
            {
                if(count <= counter)
                {
                    symbol = "->";
                    var param = cmd.Split(symbol);
                    var member = new Member(param[0]);
                    registration.JoinMemberToTeam(param[1], member);                    
                }
                else
                {
                    var param = cmd.Split(symbol);
                    var member = new Member(param[0]);
                    var team = new Team(member, param[1]);
                    registration.AddTeam(team);
                }

                counter++;
                cmd = Console.ReadLine();
            }

            Console.WriteLine(registration);
        }
    }
}
