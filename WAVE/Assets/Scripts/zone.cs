﻿using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Zone {

    uint id = 0;
	public Dictionary<Zone, List<TilePair>> neighbors_tiles; // public for now because it's simpler for testing
	public List<tile> tiles; // List of tiles within this zone
	public List<Zone> connected; // Zones that are actually connected by a door
    public Zone[] neighbors;
    public uint distance;

	public Zone(uint id)
	{
        this.id = id;
		neighbors_tiles = new Dictionary<Zone, List<TilePair>>();
		tiles = new List<tile>();
		connected = new List<Zone>();
        distance = uint.MaxValue;
	}

	public uint get_id() {return id;}


	public void add_tile(tile t)
	{
		if(t != null)
		{
			tiles.Add(t);
		}

	}


	//Connected methods




		
}
