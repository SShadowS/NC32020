using System;
using System.Collections.Generic;
using Dllosaurus.Models;

namespace Dllosaurus
{
	internal class Program
	{
		private static void Main(string[] args)
		{
			Rechner rechner = new Rechner();
			ABC aBC = new ABC();
			NissasNotizen();
			Console.WriteLine($"{rechner.Plus(rechner.Gange(1.0, 2.0), 1.0)}. \\rnMkFk");
			Console.WriteLine($"{rechner.Minus(rechner.Gange(8.0, 8.0), 2.0)} {aBC.WirLiebenABC()}");
			Console.ReadLine();
		}

		public static void NissasNotizen()
		{
			List<Notiz> list = new List<Notiz>();
			list.Add(new Notiz
			{
				// Jeg er nødt til at notere et par ting, ellers glemmer jeg det ... - Nissa

				Text = "Ich muss mir ein paar dinge notieren, sonst vergess ich die... --Nissa",
				Forfatter = Forfatter.Nissa
			});
			list.Add(new Notiz
			{
				// Kaffemaskinen var tom i dag, hvordan skal jeg arbejde sådan?

				Text = "Kaffeeautomat war heute leer, wie soll ich so arbeiten??",
				Forfatter = Forfatter.Franz
			});
			list.Add(new Notiz
			{
				Text = "7X",
				Forfatter = Forfatter.Nissa
			});
			list.Add(new Notiz
			{
				// Den korrekte rækkefølge er vigtig.

				Text = "Die richtige Reihenfolge ist wichtig.",
				Forfatter = Forfatter.Mette
			});
			list.Add(new Notiz
			{
				// Hun delte det angiveligt i 9 dele.

				Text = "Sie hat es angeblich in 9 Teile geteilt.",
				Forfatter = Forfatter.Hans
			});
			list.Add(new Notiz
			{
				Text = "8Q",
				Forfatter = Forfatter.Nissa
			});
			list.Add(new Notiz
			{
				// Der er stadig ingen kaffe, men nu er det tid!

				Text = "Kaffee gibt's immernoch keinen, jetzt wird's aber Zeit!",
				Forfatter = Forfatter.Franz
			});
			list.Add(new Notiz
			{
				// Jeg * OGSÅ * skjulte noget i en undtagelse, men fortæl det ikke til nogen!

				Text = "Ich habe *Gange* etwas in einer exception versteckt, sag's aber bitte keinem!",
				Forfatter = Forfatter.Nissa
			});
			list.Add(new Notiz
			{
				// Først spurgte jeg Nissa, hvad hun syntes om Cæsar-kryptering, men hun svarede kun -2 .. Jeg kan stadig ikke forstå det!

				Text = "Zuerst habe ich Nissa gefragt, was sie von Caesar-Verschlüsselung hält, aber sie hat nur mit -2 geantwortet.. Ich versteh's bis heute nicht!",
				Forfatter = Forfatter.Jens
			});
			list.Add(new Notiz
			{
				Text = "6F",
				Forfatter = Forfatter.Nissa
			});
			list.Add(new Notiz
			{
				// Hvor er min kaffe?

				Text = "Wo bleibt mein Kaffee?",
				Forfatter = Forfatter.Franz
			});
		}
	}
}
