using System
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeamWorkProject
{
   public class Program
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            Dictionary<string, string> userWithTeams = new Dictionary<string, string>();
            for(int i=0; i<n; i++)
            {
                string[] userAndTeams=Console.ReadLine().Split('-').ToArray();  
                string name = userAndTeams[0];
                string nameOfteam = userAndTeams[1];
                userWithTeams[name] = nameOfteam;
            }
            string secondInput = Console.ReadLine();
            Dictionary<string, string> joinInTeams = new Dictionary<string, string>();
            while(secondInput != "end of assignment")
            {
                string[] joinInteams = secondInput.Split('-', '>');
                string joinName = joinInteams[0];
                string joinTeam = joinInteams[1];
                joinInTeams[joinName] = joinTeam;
            }


        }
    }
}
