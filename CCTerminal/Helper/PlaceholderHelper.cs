using Exiled.API.Features;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CCTerminal.Helper
{
    internal class PlaceholderHelper
    {
        public Dictionary<string, string> Placeholders;
        public PlaceholderHelper(Player Player)
        {
            Placeholders = new()
            {
                {
                    "nickname", Player.Nickname
                },
                {
                    "health", Player.Health.ToString()
                },
                {
                    "max_health", Player.MaxHealth.ToString()
                },
                {
                    "current_room", Player.CurrentRoom.Name
                },
                {
                    "current_zone", Player.CurrentRoom.Zone.ToString()
                },
                {
                    "current_role", Player.Role.Name
                },
                {
                    "current_team", Player.Role.Team.ToString()
                },
                {
                    "current_item", Player.CurrentItem.ToString()
                },
                {
                    "other_same_roles_alive", Player.List.Where(player => player.Role.Type == Player.Role.Type && player.IsAlive).Count().ToString()
                },
                {
                    "other_same_roles_alive_in_same_zone", Player.List.Where(player => player.Role.Type == Player.Role.Type && player.IsAlive && player.CurrentRoom.Zone == Player.CurrentRoom.Zone).Count().ToString()
                },
                {
                    "other_same_teammates_alive", Player.List.Where(player => player.Role.Team == Player.Role.Team && player.IsAlive).Count().ToString()
                },
                {
                    "other_same_teammates_alive_in_same_zone", Player.List.Where(player => player.Role.Team == Player.Role.Team && player.IsAlive && player.CurrentRoom.Zone == Player.CurrentRoom.Zone).Count().ToString()
                },
                {
                    "leading_team", Player.LeadingTeam.ToString()
                },
                {
                    "member_count", Player.List.Count().ToString()
                },
                {
                    "escaped_class_d", Round.EscapedDClasses.ToString()
                },
                {
                    "escaped_scientists", Round.EscapedScientists.ToString()
                },
                {
                    "kills_by_scp", Round.KillsByScp.ToString()
                },
                {
                    "total_kills", Round.Kills.ToString()
                },
                {
                    "scp_alive", Round.SurvivingSCPs.ToString()
                },
                {
                    "is_scp_079_alive", (Player.List.Where(player => player.Role.Type == PlayerRoles.RoleTypeId.Scp079).Count() > 0) ? "true" : "false"
                },
                {
                    "is_scp_049_alive", (Player.List.Where(player => player.Role.Type == PlayerRoles.RoleTypeId.Scp049).Count() > 0) ? "true" : "false"
                },
                {
                    "is_scp_173_alive", (Player.List.Where(player => player.Role.Type == PlayerRoles.RoleTypeId.Scp173).Count() > 0) ? "true" : "false"
                },
                {
                    "is_scp_096_alive", (Player.List.Where(player => player.Role.Type == PlayerRoles.RoleTypeId.Scp096).Count() > 0) ? "true" : "false"
                },
                {
                    "is_scp_939_alive", (Player.List.Where(player => player.Role.Type == PlayerRoles.RoleTypeId.Scp939).Count() > 0) ? "true" : "false"
                },
                {
                    "is_scp_106_alive", (Player.List.Where(player => player.Role.Type == PlayerRoles.RoleTypeId.Scp106).Count() > 0) ? "true" : "false"
                }
            };
        }

        public string ReplacePlaceholders(string Input)
        {
            foreach (KeyValuePair<string, string> Pair in Placeholders)
            {
                if (Input.Contains($"%{Pair.Key}%"))
                {
                    Input.Replace($"%{Pair.Key}%", Pair.Value);
                }
            }
            return Input;
        }
    }
}
