using Microsoft.Xna.Framework;
using System.Timers;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using Terraria;
using TerrariaApi.Server;
using TShockAPI;

namespace GetPos
{
	[ApiVersion(2, 1)]

	public class GetPos : TerrariaPlugin
	{

		public override string Name
		{
			get { return "GetPos"; }
		}

		public override string Author
		{
			get { return "Comdar"; }
		}

		public override string Description
		{
			get { return "Plugin that will show coordinates."; }
		}

		public string HelpText { get; private set; }

		public GetPos(Main game)
			: base(game)
		{
			Order = +4;
		}


		public override void Initialize()
		{
			Commands.ChatCommands.Add(new Command("getpos", getpos, "getpos"));
		}

		void getpos(CommandArgs args)
		{
			int x = (int)args.Player.X / 16;
			int y = (int)args.Player.Y / 16;
			args.Player.SendMessage(string.Format("PosX: {0}, PosY: {1}", x, y), Color.LimeGreen);
		}
	}
}