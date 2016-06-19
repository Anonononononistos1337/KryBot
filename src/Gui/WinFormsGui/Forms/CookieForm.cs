﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using KryBot.CommonResources.Localization;
using KryBot.Core;

namespace KryBot.Gui.WinFormsGui.Forms
{
	public partial class FormCookie : Form
	{
		private readonly Bot _bot;
		private readonly List<string> _names;
		private readonly string _site;

		public FormCookie(string site, List<string> names, Bot bot)
		{
			_site = site;
			_names = names;
			_bot = bot;
			InitializeComponent();
		}

		private void formCookie_Load(object sender, EventArgs e)
		{
			Text = _site;

			foreach (var name in _names)
			{
				var label = new Label
				{
					Location = new Point(6, Controls.Count == 0 ? 6 : Controls[Controls.Count - 1].Location.Y + 26),
					Text = name.Split(':')[0] + ':',
					Width = 68
				};
				Controls.Add(label);

				var textbox = new TextBox
				{
					Location =
						new Point(10 + label.Size.Width,
							Controls.Count == 1 ? 3 : Controls[Controls.Count - 2].Location.Y + 26),
					Name = name.Split(':')[0],
					Text = name.Split(':')[1],
					Width = 194
				};
				Controls.Add(textbox);
			}

			var button = new Button
			{
				Location = new Point(6, Controls[Controls.Count - 1].Location.Y + 28),
				Width = 272,
				Text = strings.CookieForm_Save
			};
			button.Click += ButtonOnClick;
			Controls.Add(button);

			Height = Controls[Controls.Count - 1].Location.Y + 68;
		}

		private void ButtonOnClick(object sender, EventArgs eventArgs)
		{
			switch (_site)
			{
				case "GameMiner":
					_bot.GameMiner.Cookies.Token = (Controls["token"] as TextBox)?.Text;
					_bot.GameMiner.Cookies.Xsrf = (Controls["_xsrf"] as TextBox)?.Text;
					_bot.GameMiner.UserAgent = (Controls["UserAgent"] as TextBox)?.Text;
					_bot.GameMiner.Enabled = true;
					_bot.Save();
					ShowMessage();
					break;

				case "SteamGifts":
					_bot.SteamGifts.Cookies.PhpSessId = (Controls["PHPSESSID"] as TextBox)?.Text;
					_bot.SteamGifts.UserAgent = (Controls["UserAgent"] as TextBox)?.Text;
					_bot.SteamGifts.Enabled = true;
					_bot.Save();
					ShowMessage();
					break;

				case "SteamCompanion":
					_bot.SteamCompanion.Cookies.PhpSessId = (Controls["PHPSESSID"] as TextBox)?.Text;
					_bot.SteamCompanion.Cookies.UserId = (Controls["userid"] as TextBox)?.Text;
					_bot.SteamCompanion.Cookies.UserC = (Controls["userc"] as TextBox)?.Text;
					_bot.SteamCompanion.Cookies.UserT = (Controls["usert"] as TextBox)?.Text;
					_bot.SteamCompanion.Enabled = true;
					_bot.Save();
					ShowMessage();
					break;

				case "UseGamble":
					_bot.UseGamble.Cookies.PhpSessId = (Controls["PHPSESSID"] as TextBox)?.Text;
					_bot.UseGamble.Enabled = true;
					_bot.Save();
					ShowMessage();
					break;

				case "Steamtrade":
					_bot.SteamTrade.Cookies.PhpSessId = (Controls["PHPSESSID"] as TextBox)?.Text;
					_bot.SteamTrade.Cookies.DlePassword = (Controls["dle_password"] as TextBox)?.Text;
					_bot.SteamTrade.Cookies.DleUserId = (Controls["dle_user_id"] as TextBox)?.Text;
					_bot.SteamTrade.Cookies.PassHash = (Controls["passhash"] as TextBox)?.Text;
					_bot.SteamTrade.Enabled = true;
					_bot.Save();
					ShowMessage();
					break;

				case "Steam":
					_bot.Steam.Cookies.Login = (Controls["steamLogin"] as TextBox)?.Text;
					_bot.Steam.Cookies.Sessid = (Controls["sessionid"] as TextBox)?.Text;
					_bot.Steam.Enabled = true;
					_bot.Save();
					ShowMessage();
					break;

				case "PlayBlink":
					_bot.PlayBlink.Cookies.PhpSessId = (Controls["PHPSESSID"] as TextBox)?.Text;
					_bot.PlayBlink.Enabled = true;
					_bot.Save();
					ShowMessage();
					break;
			}

			Close();
		}

		private void ShowMessage()
		{
			MessageBox.Show(strings.CookieForm_MustRestart, strings.Information,
				MessageBoxButtons.OK, MessageBoxIcon.Information);
		}
	}
}