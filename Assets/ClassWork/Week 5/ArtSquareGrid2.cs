using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Art
{
    public class ArtSquareGrid2 : ArtMakerTemplate
    {
        public GameObject[] objects;
        public int amount = 10;

        public override void MakeArt()
        {
            for (int i = 0; i < amount; i++)
            {
                for (int j = 0; j < amount; j++)
                {
                    GameObject thing = Instantiate(objects[0]);
                    thing.transform.position = new Vector3(i, j, 0);
                    float scale = Random.value;
                    thing.transform.localScale = new Vector3(scale, scale, scale);
                    thing.transform.parent = root.transform;

                    GameObject sphere = Instantiate(objects[1]);
                    sphere.transform.position = new Vector3(i, j, 0);
                    sphere.transform.localScale = new Vector3(scale*1.1f, scale*1, scale*1.2f);
                    sphere.transform.parent = root.transform;
                }
            }
        }
    }
}