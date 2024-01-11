using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows.Forms;
using Steamworks;
using Steamworks.Data;
using Steamworks.ServerList;

namespace Carbon.Launcher;

public class Steam
{
	private static readonly int Timeout = 60;
	private static Internet Request = new();
	public static readonly List<ServerInfo> Cache = new();
	private static Action<ServerInfo> _onChange;

	public static void Init()
	{
		try
		{
			if (!SteamClient.IsValid)
			{
				SteamClient.Init(252490, true);
			}
		}
		catch (System.Exception e)
		{
			MessageBox.Show(e.Message);
		}
	}
	public static void RefreshInfo(Action<ServerInfo> onChange, Action onFinal)
	{
		_onChange = onChange;

		Request?.Dispose();
		Request = new();

		Request.AddFilter("gametagsand", "c4c");
		Request.OnChanges += OnServersUpdated;

		Task.Run(async () =>
		{
			await Request.RunQueryAsync(Timeout);

			onFinal?.Invoke();

			Request?.Dispose();
		});
	}

	private static void OnServersUpdated()
	{
		if (Request.Responsive.Count > 0)
		{
			// Process each responsive server
			// Clear the server list so it doesn't get double processed
			lock (Request.Responsive)
			{
				foreach (ServerInfo Server in Request.Responsive)
				{
					Cache.Add(Server);
					_onChange?.Invoke(Server);
				}
				Request.Responsive.Clear();
			}
		}
	}
}
