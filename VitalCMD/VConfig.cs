using Newtonsoft.Json;
using System.Collections.Generic;
using System.IO;

namespace VitalCMD
{
	public class VConfig
	{
		public bool ShowBackMessageOnDeath = true;
		public string PrefixNicknamesWith = "~";
		public bool LockRedTeam = false;
		public string RedTeamPassword = "";
		public string RedTeamPermission = "vital.team.red";
		public bool LockGreenTeam = false;
		public string GreenTeamPassword = "";
		public string GreenTeamPermission = "vital.team.green";
		public bool LockBlueTeam = false;
		public string BlueTeamPassword = "";
		public string BlueTeamPermission = "vital.team.blue";
		public bool LockYellowTeam = false;
		public string YellowTeamPassword = "";
        public string YellowTeamPermission = "vital.team.yellow";
		public List<string> DisableSetHomeInRegions = new List<string>();
		public int BackCooldown = 0;

        public void Write(string path)
        {
            File.WriteAllText(path, JsonConvert.SerializeObject(this, Formatting.Indented));
        }

        public static VConfig Read(string path)
        {
            return !File.Exists(path)
                ? new VConfig()
                : JsonConvert.DeserializeObject<VConfig>(File.ReadAllText(path));
        }
	}
}
