using System;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

public class Electricity
{
	public static int PROGR = 0;

	private float tW;
	private int idRete;

	public Electricity()
	{
		tW = 0f;
		idRete = PROGR++;
		Terraria.Chat.ChatMessage("[DEBUG]: Rete creata " + idRete.ToString() + " tW: " + tW.ToString());
	}

	public void setTW(float tW)
    {
		this.tW = tW;
    }

	public float getTW()
    {
		return this.tW;
    }
}
